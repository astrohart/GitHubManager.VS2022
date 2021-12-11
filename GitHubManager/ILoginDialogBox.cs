namespace GitHubManager
{
    public interface ILoginDialogBox : IForm
    {
        /// <summary>
        /// Occurs when important login and authorization information is received from
        /// GitHub.
        /// </summary>
        event GitHubLoginInfoReceivedEventHandler GitHubLoginInfoReceived;

        /// <summary>
        /// Gets a reference to an instance of
        /// <see cref="T:GitHubManager.GitHubLoginInfo" /> that contains important login
        /// information.
        /// </summary>
        GitHubLoginInfo GitHubLoginInfo { get; }
    }
}