using System;
using System.Collections.Generic;

namespace GitHubManager
{
    /// <summary> Provides information for GitHubAuthenticated event handlers. </summary>
    public class GitHubAuthenticatedEventArgs : EventArgs
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:GitHubManager.GitHubAuthenticatedEventArgs" /> and returns a
        /// reference to it.
        /// </summary>
        /// <param name="accessToken">
        /// (Required.) String containing the access token for
        /// the newly-authenticated GitHub session.
        /// </param>
        /// <param name="scope">
        /// (Required.) Reference to an instance of an object that
        /// implements the <see cref="T:System.Collections.Generic.IReadOnlyList" />
        /// interface that contains a collection of scope strings.
        /// </param>
        public GitHubAuthenticatedEventArgs(
            string accessToken,
            IReadOnlyList<string> scope
        )
        {
            AccessToken = accessToken;
            Scope = scope;
        }

        /// <summary>
        /// Gets or sets a string containing the GitHub access token for further
        /// API calls.
        /// </summary>
        public string AccessToken { get; }

        /// <summary>
        /// Gets a reference to a collection of strings containing the scopes
        /// that are available for the token.
        /// </summary>
        public IReadOnlyList<string> Scope { get; }
    }
}