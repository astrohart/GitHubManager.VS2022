namespace GitHubManager
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of a
    /// configuration-provider object.
    /// </summary>
    public interface IGitHubManagerConfigurationProvider
    {
        /// <summary>
        /// Gets or sets a reference to the instance of an object implementing
        /// the <see cref="T:GitHubManager.IGitHubManagerConfiguration" /> interface that
        /// represents the currently-loaded configuration.
        /// </summary>
        IGitHubManagerConfiguration CurrentConfiguration { get; set; }

        /// <summary>
        /// Loads the configuration from the default configuration file, and
        /// stores the result in the
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:GitHubManager.IGitHubManagerConfiguration" /> interface, whose
        /// properties have been initialized from the values in the application's default
        /// configuration file.
        /// </returns>
        /// <remarks>
        /// If the configuration file does not exist, or an I/O or other error
        /// occurs during the read operation, then the method returns a newly-constructed
        /// configuration object, all of whose properties are initialized to the default
        /// settings.
        /// </remarks>
        IGitHubManagerConfiguration Load();

        /// <summary>
        /// Saves the current configuration to the default configuration file on
        /// the disk.
        /// </summary>
        void Save();
    }
}