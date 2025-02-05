using PostSharp.Patterns.Diagnostics;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using xyLOGIX.UI.Dark.Forms;

namespace GitHubManager
{
    /// <summary>
    /// Dialog box to allow the user to select from among options that alter
    /// the behavior of the application.
    /// </summary>
    public partial class OptionsDialogBox : DarkForm, IOptionsDialogBox
    {
        /// <summary>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:GitHubManager.IOptionsDialogBoxPresenter" /> interface.
        /// </summary>
        /// <remarks>This object plays the role of this dialog box's Presenter.</remarks>
        private readonly IOptionsDialogBoxPresenter Presenter;

        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:GitHubManager.OptionsDialogBox" /> and returns a reference to it.
        /// </summary>
        public OptionsDialogBox()
        {
            InitializeComponent();

            Presenter = MakeNewOptionsDialogBoxPresenter.FromScratch(this);

            Application.Idle += OnUpdateCmdUI;
        }

        /// <summary>
        /// Gets or sets a reference to an instance of an object that implements
        /// the <see cref="T:GitHubManager.IGitHubManagerConfig" /> interface that
        /// serves as the config for the application.
        /// </summary>
        public IGitHubManagerConfig Config { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

        /// <summary>
        /// Occurs when the user clicks the <strong>Apply</strong> button.
        /// <para />
        /// This notifies other parts of the application that the state may have been
        /// changed.
        /// </summary>
        public event EventHandler Applied;

        /// <summary>
        /// Raises the <see cref="E:GitHubManager.OptionsDialogBox.Applied" />
        /// event.
        /// </summary>
        protected virtual void OnApplied()
            => Applied?.Invoke(this, EventArgs.Empty);

        /// <summary>Raises the <see cref="E:System.Windows.Forms.Form.Load" /> event.</summary>
        /// <param name="e">
        /// An <see cref="T:System.EventArgs" /> that contains the event
        /// data.
        /// </param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            UpdateData(false);
        }

        /// <summary>
        /// Handles the
        /// <see cref="E:System.Windows.Forms.CheckBox.CheckedChanged" /> event raised by
        /// the <strong>Login on Startup</strong> checkbox when the user clicks it to
        /// change its value..
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
        /// The method responds by alerting the property sheet code that the data
        /// in the property sheet has been modified.
        /// </remarks>
        private void OnCheckedChangedLoginOnStartupCheckBox(
            object sender,
            EventArgs e
        )
            => Presenter.IsModified =
                !Presenter
                    .IsModified; // toggle because the checkbox is a toggle

        private void OnClickOK(object sender, EventArgs e)
            => UpdateData();

        [Log(AttributeExclude = true)]
        private void OnUpdateCmdUI(object sender, EventArgs e)
            => applyButton.Enabled = Presenter.IsModified;

        /// <summary> Moves data from this dialog's controls to the config object. </summary>
        /// <param name="bSaveAndValidate">
        /// (Required.) A <see cref="T:System.Boolean" />
        /// that specifies whether to save information from the screen into data variables.
        /// <see langword="false" /> to load data to the screen.
        /// </param>
        private void UpdateData(bool bSaveAndValidate = true)
        {
            if (bSaveAndValidate)
                Config.LoginOnStartup = loginOnStartupCheckBox.Checked;
            else
                loginOnStartupCheckBox.Checked = Config.LoginOnStartup;

            Presenter.IsModified = false; // always set this to false here
        }
    }
}