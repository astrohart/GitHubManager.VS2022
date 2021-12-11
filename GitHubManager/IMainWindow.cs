namespace GitHubManager
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of the main application
    /// window.
    /// </summary>
    public interface IMainWindow : IForm
    {
        /// <summary>
        /// Gets or sets a value indicating whether the user is signed in.
        /// </summary>
        bool IsSignedIn { get; set; }
    }
}