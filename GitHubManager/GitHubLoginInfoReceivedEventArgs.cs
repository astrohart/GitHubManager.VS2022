using System;

namespace GitHubManager
{
    /// <summary>
    /// Provides information for GitHubLoginInfoReceived event handlers.
    /// </summary>
    public class GitHubLoginInfoReceivedEventArgs : EventArgs
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:GitHubManager.GitHubLoginInfoReceivedEventArgs" /> and returns a
        /// reference to it.
        /// </summary>
        /// <param name="address">
        /// (Required.) String containing the URL conveying important login information.
        /// </param>
        /// <param name="loginInfo">
        /// (Required.) Reference to an instance of
        /// <see cref="T:GitHubManager.GitHubLoginInfo" /> that contains the login
        /// information, parsed from the url in the <paramref name="address" /> parameter.
        /// </param>
        public GitHubLoginInfoReceivedEventArgs(string address,
            GitHubLoginInfo loginInfo)
        {
            Address = address;
            LoginInfo = loginInfo;
        }

        /// <summary>
        /// URL from GitHub that delivered the authorization information.
        /// </summary>
        public string Address { get; }

        /// <summary>
        /// Gets a reference to an instance of
        /// <see cref="T:GitHubManager.GitHubLoginInfo" /> that contains information about
        /// the login.
        /// </summary>
        public GitHubLoginInfo LoginInfo { get; }
    }
}