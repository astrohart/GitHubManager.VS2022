using System;

namespace GitHubManagerSampleApplication
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of the main
    /// application window.
    /// </summary>
    public interface IMainWindow : IForm
    {
        /// <summary> Gets or sets a value indicating whether the user is signed in. </summary>
        /// <remarks>
        /// When this property's value is changed, the
        /// <see cref="E:GitHubManagerSampleApplication.MainWindow.SignedInChanged" /> event is raised.
        /// </remarks>
        bool IsSignedIn { get; }

        /// <summary>
        /// Occurs when the value of the
        /// <see cref="P:GitHubManagerSampleApplication.IMainWindow.IsSignedIn" /> property changes.
        /// </summary>
        event EventHandler SignedInChanged;
    }
}