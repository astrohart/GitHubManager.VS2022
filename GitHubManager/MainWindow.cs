using PostSharp.Patterns.Diagnostics;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using xyLOGIX.Core.Dialogs.Progress.Factories;
using xyLOGIX.Core.Dialogs.Progress.Interfaces;
using xyLOGIX.Core.Extensions;
using xyLOGIX.UI.Dark.Controls.Actions;
using xyLOGIX.UI.Dark.Forms;

namespace GitHubManager
{
    /// <summary> Main window of the application. </summary>
    public partial class MainWindow : DarkForm, IMainWindow
    {
        /// <summary> Flag indicating whether the application is signed-in. </summary>
        private bool _isSignedIn;

        /// <summary>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:GitHubManager.ILoginDialogBox" /> interface.
        /// </summary>
        private ILoginDialogBox _loginDialogBox;

        /// <summary>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:xyLOGIX.Core.Dialogs.Progress.Interfaces.IMarqueeProgressDialogBox" />
        /// interface that represents the <b>Marquee Progress Dialog Box</b> used to keep
        /// the user entertained while a long process, having indeterminate duration, runs.
        /// </summary>
        private IMarqueeProgressDialogBox _progressDialog;

        /// <summary>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:GitHubManager.IMainWindowPresenter" /> interface.
        /// </summary>
        private readonly IMainWindowPresenter Presenter;

        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this
        /// class.
        /// </summary>
        static MainWindow() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this
        /// class.
        /// </summary>
        protected MainWindow()
        {
            InitializeComponent();

            Presenter = new MainWindowPresenter(this);

            Session.GitHubAuthenticated += OnGitHubAuthenticated;

            Application.Idle += OnUpdateCmdUI;
        }

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:GitHubManager.IGitHubManagerConfigurationProvider" /> interface.
        /// </summary>
        private static IGitHubManagerConfigurationProvider
            GitHubManagerConfigurationProvider
            => GetGitHubManagerConfigurationProvider.SoleInstance();

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see cref="T:GitHubManager.MainWindow" />.
        /// </summary>
        public static IMainWindow Instance { [DebuggerStepThrough] get; } =
            new MainWindow();

        /// <summary> Gets or sets a value indicating whether the user is signed in. </summary>
        /// <remarks>
        /// When this property's value is changed, the
        /// <see cref="E:GitHubManager.MainWindow.SignedInChanged" /> event is raised.
        /// </remarks>
        public bool IsSignedIn
        {
            get => _isSignedIn;
            private set
            {
                var changed = value != _isSignedIn;

                _isSignedIn = value;

                if (changed)
                    OnSignedInChanged();
            }
        }

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:GitHubManager.IGitHubSession" /> interface.
        /// </summary>
        private static IGitHubSession Session
            => GetGitHubSession.SoleInstance();

        /// <summary>
        /// Occurs when the value of the
        /// <see cref="P:GitHubManager.IMainWindow.IsSignedIn" /> property changes.
        /// </summary>
        public event EventHandler SignedInChanged;

        private void CloseLoginDialogBox()
        {
            if (_loginDialogBox == null) return;
            if (_loginDialogBox.IsDisposed) return;

            _loginDialogBox.DoIfNotDisposed(
                () =>
                {
                    _loginDialogBox.Hide();
                    _loginDialogBox.Dispose();
                    _loginDialogBox = null;
                }
            );
        }

        private void CloseProgressDialog()
        {
            if (_progressDialog == null) return;

            _progressDialog.DoIfNotDisposed(
                () =>
                {
                    _progressDialog.Close();
                    _progressDialog.Dispose();
                    _progressDialog = null;
                }
            );
        }

        /// <summary>
        /// Handles the
        /// <see cref="E:System.Windows.Forms.ToolStripDropDownItem.DropDownOpening" />
        /// event raised by the <strong>View</strong> menu..
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
        /// This method responds by setting the Checked state of the various menu
        /// items that tell the user whether UI/UX elements are visible (checked) or hidden
        /// (not checked).
        /// </remarks>
        private void OnDropDownOpeningViewMenu(object sender, EventArgs e)
            => viewStatusBar.Checked = statusBar.Visible;

        /// <summary>
        /// Handles the
        /// <see cref="E:System.Windows.Forms.ToolStripDropDownItem.DropDownOpening" />
        /// event raised by the <strong>Toolbars</strong> submenu of the
        /// <strong>View</strong> menu..
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
        /// This method responds by setting the Checked state of the menu items
        /// for the various toolbars displayed in the main application window, depending on
        /// whether they are visible (checked) or hidden (not checked)
        /// </remarks>
        private void OnDropDownOpeningViewToolbarsMenu(
            object sender,
            EventArgs e
        )
            => viewNavigateToolbar.Checked = navigateToolBar.Visible;

        /// <summary>
        /// Handles the <see cref="E:System.Windows.Forms.ToolStripItem.Click" />
        /// event raised by the <strong>Exit</strong> menu item on the
        /// <strong>File</strong> menu..
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
        /// This method responds by closing this window; since this window is the
        /// main application window, this also terminates the lifecycle of the application
        /// process.
        /// </remarks>
        private void OnFileExit(object sender, EventArgs e)
            => Close();

        /// <summary>
        /// Handles the <see cref="E:System.Windows.Forms.ToolStripItem.Click" />
        /// event raised by the <strong>Login</strong> menu item on the
        /// <strong>File</strong> menu..
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
        /// This menu responds by showing the user the Login dialog box for
        /// GitHub and signing the user into the account that is chosen.
        /// </remarks>
        private void OnFileLogin(object sender, EventArgs e)
        {
            _loginDialogBox = MakeNewLoginDialogBox.FromScratch();

            _loginDialogBox.Show(this);
        }

        /// <summary>
        /// Handles the
        /// <see cref="E:System.Windows.Forms.ToolStripDropDownItem.DropDownOpening" />
        /// event raised by the <strong>File</strong> menu when it is being dropped down by
        /// a mouse click..
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
        /// This method responds by showing the enabled and/or disabled state of
        /// the items on the <strong>File</strong> menu to correspond with the current
        /// state of the application.
        /// </remarks>
        private void OnFileMenuDropDownOpening(object sender, EventArgs e)
            => fileLogin.Enabled = !IsSignedIn;

        /// <summary>
        /// Handles the
        /// <see cref="E:GitHubManager.IGitHubSession.GitHubAuthenticated" /> event raised
        /// by the GitHub Session Object when the OAuth flow is complete.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the
        /// event.
        /// </param>
        /// <param name="e">
        /// A <see cref="T:GitHubManager.GitHubAuthenticatedEventArgs" />
        /// that contains the event data.
        /// </param>
        /// <remarks>
        /// This method responds by initiating the process of loading repository
        /// data into the DataGridView displayed in the middle of the window.
        /// </remarks>
        private void OnGitHubAuthenticated(
            object sender,
            GitHubAuthenticatedEventArgs e
        )
            => this.InvokeIfRequired(
                new MethodInvoker(

                    // ReSharper disable once AsyncVoidLambda
                    async () =>
                    {
                        CloseLoginDialogBox();

                        _progressDialog = MakeNewDarkMarqueeProgressDialogBox.FromScratch()
                            .HavingStatusText("Retrieving repositories...");
                        _progressDialog.StartPosition =
                            FormStartPosition.CenterScreen;
                        _progressDialog.Show(this);

                        reposListBindingSource.DataSource = null;
                        reposListBindingSource.DataSource =
                            new BindingList<IRepo>(await Presenter.GetRepos());

                        Thread.Sleep(
                            500
                        ); // allow time for the DataGridView to be filled

                        workspacePanel.Hide();

                        Text = $"Repositories - {Application.ProductName}";

                        CloseProgressDialog();
                    }
                )
            );

        /// <summary>Raises the <see cref="E:System.Windows.Forms.Form.Load" /> event.</summary>
        /// <param name="e">
        /// An <see cref="T:System.EventArgs" /> that contains the event
        /// data.
        /// </param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            Set.ExplorerDarkTheme(reposDataGridView.Handle);

            // obscure the (as yet unfilled) DataGridView behind a panel
            workspacePanel.Show();
            workspacePanel.BringToFront();

            CloseProgressDialog();
        }

        /// <summary>Raises the <see cref="E:System.Windows.Forms.Form.Shown" /> event.</summary>
        /// <param name="e">
        /// A <see cref="T:System.EventArgs" /> that contains the event
        /// data.
        /// </param>
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (GitHubManagerConfigurationProvider.CurrentConfiguration
                                                  .LoginOnStartup)
                fileLogin.PerformClick();
        }

        /// <summary>
        /// Raises the <see cref="E:GitHubManager.MainWindow.SignedInChanged" />
        /// event.
        /// </summary>
        protected virtual void OnSignedInChanged()
            => SignedInChanged?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Handles the <see cref="E:System.Windows.Forms.ToolStripItem.Click" />
        /// event raised by the <strong>Options</strong> menu item on the
        /// <strong>Tools</strong> menu.
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
        /// This method responds by instructing the Presenter to enable the user
        /// to configure options that affect the behavior of this application.
        /// </remarks>
        private void OnToolsOptions(object sender, EventArgs e)
            => Presenter.ConfigureOptions();

        /// <summary>
        /// Handles the <see cref="E:System.Windows.Forms.Application.Idle" />
        /// event raised by the application.
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
        /// This method responds by ensuring that the enabled/disabled state of
        /// controls corresponds to the internal state of the application.
        /// </remarks>
        [Log(AttributeExclude = true)]
        private void OnUpdateCmdUI(object sender, EventArgs e)
            => navigateToolBar.Enabled = false;

        /// <summary>
        /// Handles the <see cref="E:System.Windows.Forms.ToolStripItem.Click" />
        /// event raised by the <strong>Navigate</strong> menu item on the
        /// <strong>Toolbars</strong> sub-menu of the <strong>View</strong> menu..
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the
        /// event.
        /// </param>
        /// <param name="e">
        /// A <see cref="T:System.EventArgs" /> that contains the event
        /// data.
        /// </param>
        /// <remarks>This method shows or hides the <strong>Navigate</strong> toolbar.</remarks>
        private void OnViewNavigateToolbar(object sender, EventArgs e)
            => navigateToolBar.Visible = !navigateToolBar.Visible;

        /// <summary>
        /// Handles the <see cref="E:System.Windows.Forms.ToolStripItem.Click" />
        /// event raised by the <strong>Status Bar</strong> menu item on the
        /// <strong>View</strong> menu..
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the
        /// event.
        /// </param>
        /// <param name="e">
        /// A <see cref="T:System.EventArgs" /> that contains the event
        /// data.
        /// </param>
        /// <remarks>This method shows or hides the Status Bar.</remarks>
        private void OnViewStatusBar(object sender, EventArgs e)
            => statusBar.Visible = !statusBar.Visible;
    }
}