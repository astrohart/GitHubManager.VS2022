using System.Diagnostics;
using xyLOGIX.UI.Dark.Forms;

namespace GitHubManager
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of an object that
    /// represents the Options dialog box.
    /// </summary>
    public interface IOptionsDialogBox : IDarkForm
    {
        /// <summary>
        /// Gets or sets a reference to an instance of an object that implements
        /// the <see cref="T:GitHubManager.IGitHubManagerConfig" /> interface that
        /// serves as the config for the application.
        /// </summary>
        IGitHubManagerConfig Config { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
    }
}