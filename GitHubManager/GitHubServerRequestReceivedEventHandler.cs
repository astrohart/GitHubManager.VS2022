namespace GitHubManager
{
    /// <summary> Represents a handler for a GitHubServerRequestReceived event. </summary>
    /// <param name="sender">
    /// Reference to the instance of the object that raised the
    /// event.
    /// </param>
    /// <param name="e">
    /// A
    /// <see cref="T:GitHubManager.GitHubServerRequestReceivedEventArgs" /> that
    /// contains the event data.
    /// </param>
    /// <remarks>
    /// This delegate merely specifies the signature of all methods that
    /// handle the GitHubServerRequestReceived event.
    /// </remarks>
    public delegate void GitHubServerRequestReceivedEventHandler(
        object sender,
        GitHubServerRequestReceivedEventArgs e
    );
}