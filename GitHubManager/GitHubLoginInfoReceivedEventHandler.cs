namespace GitHubManager
{
    /// <summary>
    /// Represents a handler for a GitHubLoginInfoReceived event.
    /// </summary>
    /// <param name="sender">
    /// Reference to the instance of the object that raised the event.
    /// </param>
    /// <param name="e">
    /// A <see cref="T:GitHubManager.GitHubLoginInfoReceivedEventArgs" /> that contains
    /// the event data.
    /// </param>
    /// <remarks>
    /// This delegate merely specifies the signature of all methods that handle the
    /// GitHubLoginInfoReceived event.
    /// </remarks>
    public delegate void GitHubLoginInfoReceivedEventHandler(object sender,
        GitHubLoginInfoReceivedEventArgs e);
}