namespace GitHubManager
{
    /// <summary>
    /// Creates new instances of objects that implement the
    /// <see cref="T:GitHubManager.ILoginDialogBox" /> interface, and returns
    /// references to them.
    /// </summary>
    public static class MakeNewLoginDialogBox
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see cref="T:GitHubManager.ILoginDialogBox" /> interface and returns a
        /// reference to it.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:GitHubManager.ILoginDialogBox" /> interface.
        /// </returns>
        public static ILoginDialogBox FromScratch()
            => new LoginDialogBox();
    }
}