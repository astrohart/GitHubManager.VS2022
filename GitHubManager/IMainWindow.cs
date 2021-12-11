using System;

namespace GitHubManager
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of the main application
    /// window.
    /// </summary>
    public interface IMainWindow : IForm
    {
        /// <summary>
        /// Occurs when the value of the <see cref="P:GitHubManager.IMainWindow.IsSignedIn"/> property changes.
        /// </summary>
        event EventHandler SignedInChanged;

        /// <summary>
        /// Gets or sets a value indicating whether the user is signed in.
        /// </summary>
        bool IsSignedIn { get; }
    }
}