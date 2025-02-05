using PostSharp.Patterns.Diagnostics;
using PostSharp.Patterns.Threading;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace GitHubManager
{
    /// <summary> Provides information for GitHubAuthenticated event handlers. </summary>
    [ExplicitlySynchronized]
    public class GitHubAuthenticatedEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the <see cref="T:GitHubManager.GitHubAuthenticatedEventArgs" /> class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance being
        /// created or before any static members are referenced.
        /// <para />
        /// We've decorated this constructor with the <c>[Log(AttributeExclude = true)]</c>
        /// attribute in order to simplify the logging output.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static GitHubAuthenticatedEventArgs() { }

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
        [Log(AttributeExclude = true)]
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
        public string AccessToken { [DebuggerStepThrough] get; }

        /// <summary>
        /// Gets a reference to a collection of strings containing the scopes
        /// that are available for the token.
        /// </summary>
        public IReadOnlyList<string> Scope { [DebuggerStepThrough] get; }
    }
}