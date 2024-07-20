namespace GitHubManager
{
    /// <summary> Represents a handler for a GitHubAuthenticated event. </summary>
    /// <param name="sender">
    /// Reference to the instance of the object that raised the
    /// event.
    /// </param>
    /// <param name="e">
    /// A <see cref="T:GitHubManager.GitHubAuthenticatedEventArgs" />
    /// that contains the event data.
    /// </param>
    /// <remarks>
    /// This delegate merely specifies the signature of all methods that
    /// handle the GitHubAuthenticated event.
    /// </remarks>
    public delegate void GitHubAuthenticatedEventHandler(
        object sender,
        GitHubAuthenticatedEventArgs e
    );
}