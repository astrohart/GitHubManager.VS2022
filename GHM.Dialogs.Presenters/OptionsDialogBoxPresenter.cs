using GHM.Dialogs.Interfaces;
using GHM.Dialogs.Presenters.Interfaces;
using System.Diagnostics;

namespace GHM.Dialogs.Presenters
{
    /// <summary> Serves as the Presenter for the Options dialog box. </summary>
    public class OptionsDialogBoxPresenter : IOptionsDialogBoxPresenter
    {
        /// <summary>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:GitHubManager.IOptionsDialogBox" /> interface.
        /// </summary>
        /// <remarks>This object serves as the View that this Presenter is associated with.</remarks>
        private IOptionsDialogBox View;

        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:GHM.Dialogs.Presenters.OptionsDialogBoxPresenter" /> and returns a
        /// reference to it.
        /// </summary>
        public OptionsDialogBoxPresenter()
            => View = null;

        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:GitHubManager.OptionsDialogBoxPresenter" /> and returns a
        /// reference to it.
        /// </summary>
        /// <param name="view">
        /// (Required.) Reference to an instance of an object that
        /// implements the <see cref="T:GitHubManager.IOptionsDialogBox" /> interface.
        /// <para />
        /// This object plays the role of the View that displays this Presenter's data.
        /// </param>
        public OptionsDialogBoxPresenter(IOptionsDialogBox view)
            => View = view;

        /// <summary>
        /// Gets or sets a value that indicates whether any of the settings on
        /// the property sheet have been modified.
        /// </summary>
        public bool IsModified { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
    }
}