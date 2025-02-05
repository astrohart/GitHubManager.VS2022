namespace GitHubManagerSampleApplication
{
    public interface ILoginDialogBox : IForm
    {
        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:GitHubManagerSampleApplication.IGitHubLoginInfo" /> interface that plays the role
        /// of an object that contains important login information.
        /// </summary>
        IGitHubLoginInfo GitHubLoginInfo { get; }

        /// <summary>
        /// Occurs when important login and authorization information is received
        /// from GitHub.
        /// </summary>
        event GitHubLoginInfoReceivedEventHandler GitHubLoginInfoReceived;
    }
}