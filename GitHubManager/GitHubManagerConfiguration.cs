using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;

namespace GitHubManager
{
    /// <summary>
    /// Settings that are user-configurable and that alter the behavior of
    /// the application
    /// </summary>
    public class GitHubManagerConfiguration : IGitHubManagerConfiguration
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:GitHubManager.GitHubManagerConfiguration" /> and returns a
        /// reference to it.
        /// </summary>
        [JsonConstructor]
        public GitHubManagerConfiguration()
        {
            LoginOnStartup = false;

            Scopes = new List<string>();
        }

        /// <summary>
        /// Gets or sets a string containing the ID of the particular GitHub app
        /// we want to utilize with this application.
        /// </summary>
        [JsonProperty("clientId")]
        public string ClientId { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

        /// <summary>
        /// Gets or sets a string containing the Client Secret of the OAuth App
        /// to bind to this application.
        /// </summary>
        [JsonProperty("clientSecret")]
        public string ClientSecret { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

        /// <summary>
        /// Gets or sets a value that determines whether the application logs in
        /// to GitHub on startup.
        /// </summary>
        [JsonProperty("loginOnStartup")]
        public bool LoginOnStartup { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

        /// <summary>
        /// Get or sets a collection of strings that defines the scopes to be
        /// used with this application.
        /// </summary>
        [JsonProperty("scopes")]
        public IList<string> Scopes { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
    }
}