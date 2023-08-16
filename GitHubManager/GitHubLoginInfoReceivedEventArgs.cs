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
        /// (Required.) Reference to an instance of an object that implements the
        /// <see cref="T:GitHubManager.IGitHubLoginInfo" /> interface that plays the role
        /// of an object that contains important login information.
        /// </param>
        public GitHubLoginInfoReceivedEventArgs(string address,
            IGitHubLoginInfo loginInfo)
        {
            Address = address;
            LoginInfo = loginInfo;
        }

        /// <summary>
        /// URL from GitHub that delivered the authorization information.
        /// </summary>
        public string Address { get; }

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:GitHubManager.IGitHubLoginInfo" /> interface that plays the role
        /// of an object that contains important login information.
        /// </summary>
        public IGitHubLoginInfo LoginInfo { get; }
    }
}
