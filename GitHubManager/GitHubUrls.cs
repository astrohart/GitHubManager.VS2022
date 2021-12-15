namespace GitHubManager
{
    public static class GitHubUrls
    {
        /// <summary>
        /// String containing the start of the URL that GitHub navigates our browser to,
        /// through a HTTP redirect.
        /// </summary>
        /// <remarks>
        /// This is the starting text of the URL that provides the Client ID,
        /// scope, and state for the current login request.
        /// </remarks>
        public const string GitHubLoginAuthorizeUrlStart =
            @"https://github.com/login/oauth/authorize?";

        /// <summary>
        /// URL route that our internal HTTP server listens on for incoming authorization
        /// requests.
        /// </summary>
        public const string OAuthRedirectURL =
            @"http://localhost:38929/home/authorize";
    }
}