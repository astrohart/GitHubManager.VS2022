using System.Collections.Generic;

namespace GitHubManager
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of an object, the values of
    /// whose properties define the behaviors of the application.
    /// </summary>
    public interface IGitHubManagerConfiguration
    {
        /// <summary>
        /// Gets or sets a string containing the ID of the particular GitHub app we want to
        /// utilize with this application.
        /// </summary>
        string ClientId { get; set; }

        /// <summary>
        /// Gets or sets a string containing the Client Secret of the OAuth App to bind to
        /// this application.
        /// </summary>
        string ClientSecret { get; set; }

        /// <summary>
        /// Gets or sets a value that determines whether the application logs in to GitHub
        /// on startup.
        /// </summary>
        bool LoginOnStartup { get; set; }

        /// <summary>
        /// Get or sets a collection of strings that defines the scopes to be used with
        /// this application.
        /// </summary>
        IList<string> Scopes { get; set; }
    }
}
