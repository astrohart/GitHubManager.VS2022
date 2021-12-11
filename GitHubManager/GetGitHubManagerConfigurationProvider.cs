namespace GitHubManager
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see cref="T:GitHubManager.IGitHubManagerConfigurationProvider" /> interface.
    /// </summary>
    public static class GetGitHubManagerConfigurationProvider
    {
        /// <summary>
        /// Obtains access to the sole instance of the object that implements the
        /// <see cref="T:GitHubManager.IGitHubManagerConfigurationProvider" /> interface,
        /// and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to the one, and only, instance of the object that implements the
        /// <see cref="T:GitHubManager.IGitHubManagerConfigurationProvider" /> interface.
        /// </returns>
        public static IGitHubManagerConfigurationProvider SoleInstance()
            => GitHubManagerConfigurationProvider.Instance;
    }
}