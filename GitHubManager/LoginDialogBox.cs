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

        private KeyboardHandler _keyboardHandler;

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
        /// Gets a reference to an instance of
        /// <see cref="T:GitHubManager.GitHubLoginInfo" /> that contains important login
        /// information.
        /// </summary>
        public GitHubLoginInfo GitHubLoginInfo { get; private set; }

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

        private void InitializeWebBrowser()
        {
            _keyboardHandler = new KeyboardHandler(this);
            webBrowser.KeyboardHandler = _keyboardHandler;
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

        private void OnWebBrowserAddressChanged(object sender,
            AddressChangedEventArgs e)
        {
            if (!webBrowser.IsBrowserInitialized)
                return;

            SetFocusToWebBrowser();

            Presenter.AddressHistoryList.Add(e.Address);

            if (!e.Address.StartsWith(GitHubUrls.GitHubLoginAuthorizeUrlStart))
                return;

            GitHubLoginInfo = GitHubLoginInfo.FromUrl(e.Address);

            OnGitHubLoginInfoReceived(
                new GitHubLoginInfoReceivedEventArgs(e.Address, GitHubLoginInfo)
            );
        }

        private void OnWebBrowserInitializedChanged(object sender, EventArgs e)
        {
            if (!webBrowser.IsBrowserInitialized)
                return;

            SetFocusToWebBrowser();
        }

        private async void OnWebBrowserLoadingStateChanged(object sender,
            LoadingStateChangedEventArgs e)
        {
            if (!webBrowser.IsBrowserInitialized)
                return;

            if (!webBrowser.IsLoading)
            {
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
        }

        private void SetFocusToWebBrowser()
        {
            if (InvokeRequired)
                Invoke(new MethodInvoker(() => webBrowser.Focus()));
        }
    }
}