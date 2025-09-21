﻿using CefSharp;
using GHM.Dialogs.Helpers;
using GHM.Dialogs.Interfaces;
using GHM.Dialogs.Presenters.Factories;
using GHM.Dialogs.Presenters.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using xyLOGIX.Core.Debug;
using xyLOGIX.Core.Extensions;
using xyLOGIX.OAuth.GitHub.Events;
using xyLOGIX.OAuth.GitHub.Models.Factories;
using xyLOGIX.OAuth.GitHub.Models.Interfaces;
using xyLOGIX.OAuth.GitHub.Servers.Constants;
using xyLOGIX.UI.Dark.Forms;

namespace GHM.Dialogs
{
    /// <summary> Dialog box that helps the user log in to GitHub. </summary>
    public partial class LoginDialogBox : DarkForm, ILoginDialogBox
    {
        /// <summary>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:GHM.Dialogs.Presenters.Interfaces.ILoginDialogBoxPresenter" />
        /// interface.
        /// </summary>
        private ILoginDialogBoxPresenter Presenter;

        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the <see cref="T:GHM.Dialogs.LoginDialogBox" /> class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance being
        /// created or before any static members are referenced.
        /// <para />
        /// We've decorated this constructor with the <c>[Log(AttributeExclude = true)]</c>
        /// attribute in order to simplify the logging output.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static LoginDialogBox() { }

        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:GHM.Dialogs.LoginDialogBox" /> and returns a reference to it.
        /// </summary>
        [Log(AttributeExclude = true)]
        public LoginDialogBox()
        {
            InitializeComponent();

            InitializeWebBrowser();

            InitializePresenter();
        }

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:xyLOGIX.OAuth.GitHub.Models.Interfaces.IGitHubLoginInfo" />
        /// interface that plays the role
        /// of an object that contains important login information.
        /// </summary>
        public IGitHubLoginInfo GitHubLoginInfo
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] private set;
        }

        /// <summary>
        /// Occurs when important login and authorization information is received
        /// from GitHub.
        /// </summary>
        public event GitHubLoginInfoReceivedEventHandler
            GitHubLoginInfoReceived;

        private void InitializePresenter()
            => Presenter = MakeNewLoginDialogBoxPresenter.ForView(this);

        /// <summary>
        /// Sets up the properties and event handlers of the internal Web browser
        /// control.
        /// </summary>
        private void InitializeWebBrowser()
        {
            webBrowser.KeyboardHandler = new KeyboardHandler(this);
            webBrowser.AddressChanged += OnWebBrowserAddressChanged;
            webBrowser.IsBrowserInitializedChanged +=
                OnWebBrowserInitializedChanged;
            webBrowser.LoadingStateChanged += OnWebBrowserLoadingStateChanged;
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Form.FormClosing" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A <see cref="T:System.Windows.Forms.FormClosingEventArgs" />
        /// that contains the event data.</pa
        protected override void OnFormClosing(FormClosing[NotLogged] EventArgs e)
        {
            base.OnFormClosing(e);

            Presenter.SaveAddressHistoryList();
        }

        /// <summary>
        /// Raises the
        /// <see cref="E:GitHubManager.LoginDialogBox.GitHubLoginInfoReceived" /> event.
        /// </summary>
        /// <param name="e">
        /// A
        /// <see cref="T:GitHubManager.GitHubLoginInfoReceivedEventArgs" /> that contains
        /// the event data.
        /// </param>
        protected virtual void OnGitHubLoginInfoReceived(
        [NotLogged] GitHubLoginInfoReceivedEventArgs e
        )
            => GitHubLoginInfoReceived?.Invoke(this, e);

        /// <summary>
        /// Handles the
        /// <see cref="E:GitHubManager.LoginDialogBox.OnReadyToNavigateToLoginPage" />
        /// event raised by the GitHub Session object.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the
        /// event.
        /// </param>
        /// <param name="e">
        /// A <see cref="T:System.EventArgs" /> that contains the event
        /// data.
        /// </param>
        /// <remarks>
        /// This method responds by navigating the embedded web browser to the
        /// page specified in the <paramref name="e" /> parameter. </rema
        private void OnReadyToNavigateToLoginPage(
            [NotLogged] object sender,
            [NotLogged] ReadyToNavigateToLoginPageEventArgs e
        )
        {
            if (e.Uri == null) return;

            if (webBrowser == null) return;
            if (webBrowser.IsDisposed) return;

            webBrowser.Load(e.Uri.AbsoluteUri);

            Thread.Sleep(500);

            webBrowser.GetDevToolsClient()
                      .Emulation.SetAutoDarkModeOverrideAsync(true);

            webBrowser.Focus();
        }

        /// <summary>Raises the <see cref="E:System.Windows.Forms.Form.Shown" /> event.</summary>
        /// <param name="e">
        /// A <see cref="T:System.EventArgs" /> that contains the event
        /// data.
        /// </param>
        protected override void OnShown([NotLogged] EventArgs e)
        {
            base.OnShown(e);

            Presenter.Session.ReadyToNavigateToLoginPage +=
                OnReadyToNavigateToLoginPage;
            Presenter.Session.InitiateOauthFlow();
        }

        /// <summary>
        /// Handles the
        /// <see cref="E:CefSharp.WinForms.ChromiumWebBrowser.AddressChanged" /> event
        /// raised by the CefSharp Web Browser control.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the
        /// event.
        /// </param>
        /// <param name="e">
        /// A <see cref="T:CefSharp.AddressChangedEventArgs" /> that
        /// contains the event data.
        /// </param>
        /// <remarks>
        /// This method responds by checking which address the Web browser is
        /// currently pointing at.
        /// <para />
        /// Depending on the particular address that the Web browser is pointing to, the
        /// appropriate action is taken, such as closing the dialog box once the user's
        /// portion of the authorization is finished.
        /// </remarks>
        private void OnWebBrowserAddressChanged(
            [NotLogged] object sender,
            [NotLogged] AddressChangedEventArgs e
        )
        {
            if (!webBrowser.IsBrowserInitialized)
                return;

            SetFocusToWebBrowser();

            Presenter.AddressHistoryList.Add(e.Address);

            if (!e.Address.StartsWith(GitHubUrls.GitHubLoginAuthorizeUrlStart))
                return;

            GitHubLoginInfo = MakeNewGitHubLoginInfo.FromUrl(e.Address);

            OnGitHubLoginInfoReceived(
                new GitHubLoginInfoReceivedEventArgs(e.Address, GitHubLoginInfo)
            );
        }

        /// <summary>
        /// Handles the
        /// <see
        ///     cref="E:CefSharp.WinForms.Host.ChromiumHostControlBase.IsBrowserInitializedChanged" />
        /// event raised by the CefSharp Web browser control that is hosted in this dialog
        /// box.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the
        /// event.
        /// </param>
        /// <param name="e">
        /// A <see cref="T:System.EventArgs" /> that contains the event
        /// data.
        /// </param>
        /// <remarks>
        /// The method responds by setting the focus to the internal CefSharp Web
        /// Browser control once the initialization of the control is completed (such as
        /// loading a page).
        /// </remarks>
        private void OnWebBrowserInitializedChanged([NotLogged] object sender, [NotLogged] EventArgs e)
        {
            if (!webBrowser.IsBrowserInitialized)
                return;

            SetFocusToWebBrowser();
        }

        /// <summary>
        /// Handles the
        /// <see cref="E:CefSharp.WinForms.ChromiumWebBrowser.LoadingStateChanged" /> event
        /// raised by the internal CefSharp Web browser control that is hosted by this
        /// dialog box.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the
        /// event.
        /// </param>
        /// <param name="e">
        /// A <see cref="T:CefSharp.LoadingStateChangedEventArgs" /> that
        /// contains the event data.
        /// </param>
        /// <remarks>
        /// This method detects whether the user's portion of the authorization
        /// flow is completed.
        /// <para />
        /// If so, then the dialog box is automatically dismissed with the
        /// <see cref="T:System.Windows.Forms.DialogResult.OK" /> value for the
        /// <see cref="P:System.Windows.Forms.Form.DialogResult" /> property set.
        /// </remarks>
        private async void OnWebBrowserLoadingStateChanged(
            [NotLogged] object sender,
            [NotLogged] LoadingStateChangedEventArgs e
        )
        {
            try
            {
                if (!webBrowser.IsBrowserInitialized)
                    return;

                if (webBrowser.IsLoading)
                    return;

                if (IsDisposed) return;

                var source = await webBrowser.GetSourceAsync();
                if (string.IsNullOrWhiteSpace(source)) return;

                if (!source.Contains(
                        "You are being redirected to the authorized application."
                    ))
                {
                    this.InvokeIfRequired(
                        () =>
                        {
                            Show();
                            browserCoverPanel.Hide();
                        }
                    );
                    return;
                }

                Thread.Sleep(500);

                if (InvokeRequired)
                {
                    Invoke(
                        new MethodInvoker(
                            () =>
                            {
                                if (IsDisposed) return;

                                DialogResult = DialogResult.OK;
                                Close();
                            }
                        )
                    );
                }
                else
                {
                    if (IsDisposed) return;

                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }

        /// <summary>
        /// Sets the focus to the internal CefSharp Web browser control that is
        /// hosted by this dialog, and does so in a thread-safe manner.
        /// </summary>
        private void SetFocusToWebBrowser()
            => this.InvokeIfRequired(() =>
            {
                browserCoverPanel.Hide();
                return webBrowser.Focus();
            });
    }
}