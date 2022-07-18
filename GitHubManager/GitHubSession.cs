using Octokit;
using System;

namespace GitHubManager
{
    /// <summary>
    /// Manages all interaction with GitHub.
    /// </summary>
    public class GitHubSession : IGitHubSession
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        static GitHubSession() { }

        /// <summary>
        /// Constructs a new instance of <see cref="T:GitHubManager.GitHubSession" /> and
        /// returns a reference to it.
        /// </summary>
        protected GitHubSession()
            => CsrfId = Guid.NewGuid()
                            .ToString("N");

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see cref="T:GitHubManager.GitHubSession" />.
        /// </summary>
        public static IGitHubSession Instance { get; } = new GitHubSession();

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:GitHubManager.IGitHubLoginServer" /> interface.
        /// </summary>
        private static IGitHubLoginServer GitHubLoginServer
            => GetGitHubLoginServer.SoleInstance();

        /// <summary>
        /// Gets or sets a <see cref="T:Octokit.OauthLoginRequest" /> that represents the
        /// OAuth Flow.
        /// </summary>
        private OauthLoginRequest Request { get; set; }

        /// <summary>
        /// Occurs when the user's GitHub account has been authenticated.
        /// </summary>
        public event GitHubAuthenticatedEventHandler GitHubAuthenticated;

        /// <summary>
        /// Occurs when we are ready to have a client, e.g., form, navigate to the login
        /// page.
        /// </summary>
        public event EventHandler<Uri> ReadyToNavigateToLoginPage;

        /// <summary>
        /// Gets a value that determines whether the session is authenticated.
        /// </summary>
        public bool Authenticated
            => Token != null && !string.IsNullOrWhiteSpace(Token.AccessToken);

        /// <summary>
        /// Reference to an instance of <see cref="T:Octokit.GitHubClient" /> that allows
        /// communication with the GitHub server.
        /// </summary>
        public GitHubClient Client { get; } = new GitHubClient(
            new ProductHeaderValue("xyLOGIX-GitHub-Manager")
        );

        /// <summary>
        /// Gets a string containing the Client ID of this session.
        /// </summary>
        public string ClientId { get; private set; }

        /// <summary>
        /// Gets a string containing the Client Secret of this session.
        /// </summary>
        public string ClientSecet { get; private set; }

        /// <summary>
        /// Gets or sets a random string that uniquely identifies this session.
        /// </summary>
        public string CsrfId { get; }

        /// <summary>
        /// Gets or sets a <see cref="T:Octokit.OauthToken" /> to be used for API calls.
        /// </summary>
        public OauthToken Token { get; set; }

        /// <summary>
        /// Associates this session object with a particular GitHub OAuth App.
        /// </summary>
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
        public void AssociateWithApp(string clientId, string clientSecret)
        {
            if (string.IsNullOrWhiteSpace(clientId))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(clientId)
                );
            if (string.IsNullOrWhiteSpace(clientSecret))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(clientSecret)
                );

            ClientId = clientId;
            ClientSecet = clientSecret;

            Request = null;
            Token = null;

            InitializeOAUthRequest();

            GitHubLoginServer.GitHubServerRequestReceived +=
                OnGitHubServerRequestReceived;
            GitHubLoginServer.Start(GitHubUrls.OAuthRedirectURL);
        }

        /// <summary>
        /// This method is called to initiate the OAuth process.
        /// </summary>
        public void InitiateOauthFlow()
        {
            if (Client == null)
                return;

            if (Request == null)
                return;

            OnReadyToNavigateToLoginPage(
                Client.Oauth.GetGitHubLoginUrl(Request)
            );
        }

        /// <summary>
        /// Raises the <see cref="E:GitHubManager.GitHubSession.GitHubAuthenticated" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A <see cref="T:GitHubManager.GitHubAuthenticatedEventArgs" />
        /// that contains the event data.
        /// </param>
        protected virtual void OnGitHubAuthenticated(
            GitHubAuthenticatedEventArgs e)
            => GitHubAuthenticated?.Invoke(this, e);

        /// <summary>
        /// Sets up the parameters of the OAuth request object for this session.
        /// </summary>
        private void InitializeOAUthRequest()
            => Request = new OauthLoginRequest(ClientId)
            {
                Scopes = { "repo" }, State = CsrfId
            };

        /// <summary>
        /// Handles the
        /// <see cref="E:GitHubManager.IGitHubLoginServer.GitHubServerRequestReceived" />
        /// event raised by the server object we depend upon.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the
        /// event.
        /// </param>
        /// <param name="e">
        /// A
        /// <see cref="T:GitHubManager.GitHubServerRequestReceivedEventArgs" /> that
        /// contains the event data.
        /// </param>
        /// <remarks>
        /// This method responds by parsing the request and then posting our
        /// authorization information to the server, to then receive an access token.
        /// </remarks>
        private async void OnGitHubServerRequestReceived(object sender,
            GitHubServerRequestReceivedEventArgs e)
        {
            // Obtain code and state from GitHub callback endpoint
            var info = GitHubAuthorizationRequestInfo.FromRequest(e.Request);

            var request = new OauthTokenRequest(
                ClientId, ClientSecet, info.code
            );
            var token = await Client.Oauth.CreateAccessToken(request);

            if (string.IsNullOrWhiteSpace(token.AccessToken))
                return;

            Client.Credentials = new Credentials(token.AccessToken);

            OnGitHubAuthenticated(
                new GitHubAuthenticatedEventArgs(token.AccessToken, token.Scope)
            );

            // WE ARE READY FOR BUSINESS!!
        }

        /// <summary>
        /// Raises the
        /// <see cref="E:GitHubManager.GitHubSession.ReadyToNavigateToLoginPage" /> event.
        /// </summary>
        /// <param name="uri">
        /// (Required.) A <see cref="T:System.Uri" /> containing the OAuth Flow URL to be
        /// navigated to, in order to start the process.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required
        /// parameter, <paramref name="uri" />, is passed a <see langword="null" /> value.
        /// </exception>
        private void OnReadyToNavigateToLoginPage(Uri uri)
        {
            if (uri == null) throw new ArgumentNullException(nameof(uri));
            ReadyToNavigateToLoginPage?.Invoke(this, uri);
        }
    }
}
