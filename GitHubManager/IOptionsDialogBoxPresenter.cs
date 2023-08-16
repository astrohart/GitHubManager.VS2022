namespace GitHubManager
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of a Presenter object for
    /// the Options dialog box.
    /// </summary>
    public interface IOptionsDialogBoxPresenter
    {
        /// <summary>
        /// Gets or sets a value that indicates whether any of the settings on the property
        /// sheet have been modified.
        /// </summary>
        bool IsModified { get; set; }
    }
}
