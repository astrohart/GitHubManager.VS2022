using CefSharp;
using System;
using System.Threading;
using System.Windows.Forms;

namespace GitHubManager
{
    /// <summary>
    /// Dialog box that helps the user log in to GitHub.
    /// </summary>
    public partial class LoginDialogBox : Form, ILoginDialogBox
    {
        /// <summary>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:GitHubManager.ILoginDialogBoxPresenter" /> interface.
        /// </summary>
        private readonly ILoginDialogBoxPresenter Presenter;

        /// <summary>
        /// Constructs a new instance of <see cref="T:GitHubManager.LoginDialogBox" /> and
        /// returns a reference to it.
        /// </summary>
        public LoginDialogBox()
        {
            InitializeComponent();

            InitializeWebBrowser();

            Presenter = new LoginDialogBoxPresenter(this);
        }

        /// <summary>
        /// Occurs when important login and authorization information is received from
        /// GitHub.
        /// </summary>
        public event GitHubLoginInfoReceivedEventHandler
            GitHubLoginInfoReceived;

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:GitHubManager.IGitHubLoginInfo" /> interface that plays the role
        /// of an object that contains important login information.
        /// </summary>
        public IGitHubLoginInfo GitHubLoginInfo { get; private set; }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Form.FormClosing" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A <see cref="T:System.Windows.Forms.FormClosingEventArgs" />
        /// that contains the event data.</pa
        protected override void OnFormClosing(FormClosingEventArgs e)
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
            GitHubLoginInfoReceivedEventArgs e)
            => GitHubLoginInfoReceived?.Invoke(this, e);

        /// <summary>Raises the <see cref="E:System.Windows.Forms.Form.Shown" /> event.</summary>
        /// <param name="e">
        /// A <see cref="T:System.EventArgs" /> that contains the event
        /// data.
        /// </param>
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            Presenter.Session.ReadyToNavigateToLoginPage +=
                OnReadyToNavigateToLoginPage;
            Presenter.Session.InitiateOauthFlow();
        }

        /// <summary>
        /// Sets up the properties and event handlers of the internal Web browser control.
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
        /// page specified in the <paramref name="e" /> parameter.
        /// </rema
        private void OnReadyToNavigateToLoginPage(object sender, Uri e)
        {
            webBrowser.Load(e.AbsoluteUri);

            Thread.Sleep(500);

            webBrowser.Focus();
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
        private void OnWebBrowserAddressChanged(object sender,
            AddressChangedEventArgs e)
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
        private void OnWebBrowserInitializedChanged(object sender, EventArgs e)
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
        private async void OnWebBrowserLoadingStateChanged(object sender,
            LoadingStateChangedEventArgs e)
        {
            if (!webBrowser.IsBrowserInitialized)
                return;

            if (webBrowser.IsLoading)
                return;

            var source = await webBrowser.GetSourceAsync();
            if (string.IsNullOrWhiteSpace(source)) return;

            if (!source.Contains(
                "You are being redirected to the authorized application."
            ))
                return;

            Thread.Sleep(500);

            if (InvokeRequired)
            {
                Invoke(
                    new MethodInvoker(
                        () =>
                        {
                            DialogResult = DialogResult.OK;
                            Close();
                        }
                    )
                );
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        /// <summary>
        /// Sets the focus to the internal CefSharp Web browser control that is hosted by
        /// this dialog, and does so in a thread-safe manner.
        /// </summary>
        private void SetFocusToWebBrowser()
            => this.InvokeIfRequired(
                new MethodInvoker(() => webBrowser.Focus())
            );
    }
}