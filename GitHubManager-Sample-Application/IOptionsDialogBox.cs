using System.Diagnostics;

namespace GitHubManager
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of an object that
    /// represents the Options dialog box.
    /// </summary>
    public interface IOptionsDialogBox : IForm
    {
        /// <summary>
        /// Gets or sets a reference to an instance of an object that implements
        /// the <see cref="T:GitHubManager.IGitHubManagerConfiguration" /> interface that
        /// serves as the configuration for the application.
        /// </summary>
        IGitHubManagerConfiguration Configuration { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
    }
}