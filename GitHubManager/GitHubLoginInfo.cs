using System;

namespace GitHubManager
{
    public interface IGitHubLoginInfo
    {
        /// <summary> Gets or sets a string containing the ID of the client. </summary>
        string client_id { get; set; }

        /// <summary> Gets or sets a string containing a comma-separated list of scopes. </summary>
        string scope { get; set; }

        /// <summary> Gets or sets a string containing a state value. </summary>
        string state { get; set; }
    }

    /// <summary>
    /// Contains information needed during the process of logging in to
    /// GitHub.
    /// </summary>
    public class GitHubLoginInfo : IGitHubLoginInfo
    {
        /// <summary> Gets or sets a string containing the ID of the client. </summary>
        public string client_id { get; set; }

        /// <summary> Gets or sets a string containing a comma-separated list of scopes. </summary>
        public string scope { get; set; }

        /// <summary> Gets or sets a string containing a state value. </summary>
        public string state { get; set; }

        /// <summary>
        /// Parses the query string of the specified <paramref name="url" /> and
        /// returns a new instance of <see cref="T:GitHubManager.GitHubLoginInfo" /> whose
        /// properties are initialized with the results.
        /// </summary>
        /// <param name="url">(Required.) String that contains a URL that begins with the </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:GitHubManager.IGitHubLoginInfo" /> interface whose properties are
        /// initialized to the values that are parsed from the provided
        /// <paramref name="url" />, or <see langword="null" /> if this is not feasible.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter,
        /// <paramref name="url" />, is passed a blank or <see langword="null" /> string
        /// for a value.
        /// </exception>
        public static IGitHubLoginInfo FromUrl(string url)
        {
            if (string.IsNullOrWhiteSpace(url))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(url)
                );

            return !url.StartsWith(GitHubUrls.GitHubLoginAuthorizeUrlStart)
                ? default
                : new Uri(url).Query.To<GitHubLoginInfo>();
        }
    }
}