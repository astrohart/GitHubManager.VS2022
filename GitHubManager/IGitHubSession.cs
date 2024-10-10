using System;

namespace GitHubManager
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of a session of
    /// interaction with GitHub.
    /// </summary>
    public interface IGitHubSession
    {
        /// <summary> Gets a value that determines whether the session is authenticated. </summary>
        bool Authenticated { get; }

        /// <summary>
        /// Reference to an instance of <see cref="T:Octokit.GitHubClient" />
        /// that allows communication with the GitHub server.
        /// </summary>
        GitHubClient Client { get; }

        /// <summary> Gets a string containing the Client ID of this session. </summary>
        string ClientId { get; }

        /// <summary> Gets a string containing the Client Secret of this session. </summary>
        string ClientSecet { get; }

        /// <summary> Gets or sets a random string that uniquely identifies this session. </summary>
        string CsrfId { get; }

        /// <summary>
        /// Gets or sets a <see cref="T:Octokit.OauthToken" /> to be used for API
        /// calls.
        /// </summary>
        OauthToken Token { get; set; }

        /// <summary> Occurs when the user's GitHub account has been authenticated. </summary>
        event GitHubAuthenticatedEventHandler GitHubAuthenticated;

        /// <summary>
        /// Occurs when we are ready to have a client, e.g., form, navigate to
        /// the login page.
        /// </summary>
        event EventHandler<Uri> ReadyToNavigateToLoginPage;

        /// <summary> Associates this session object with a particular GitHub OAuth App. </summary>
        /// <param name="clientId">(Required.) String containing the Client ID of the app.</param>
        /// <param name="clientSecret">
        /// (Required.) String containing the Client Secret of
        /// the app.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if either of the required
        /// parameters, <paramref name="clientId" /> or <paramref name="clientSecret" />,
        /// are passed blank or <see langword="null" /> strings for values.
        /// </exception>
        void AssociateWithApp(string clientId, string clientSecret);

        /// <summary> This method is called to initiate the OAuth process. </summary>
        void InitiateOauthFlow();
    }
}