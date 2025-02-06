using GHM.Config.Interfaces;
using System.Diagnostics;

namespace GHM.Config.Providers.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of a
    /// config-provider object.
    /// </summary>
    public interface IGitHubManagerConfigProvider
    {
        /// <summary>
        /// Gets or sets a reference to the instance of an object implementing
        /// the <see cref="T:GHM.Config.Interfaces.IGitHubManagerConfig" /> interface that
        /// represents the currently-loaded config.
        /// </summary>
        IGitHubManagerConfig CurrentConfig
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Loads the config from the default config file, and
        /// stores the result in the
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:GHM.Config.Interfaces.IGitHubManagerConfig" /> interface, whose
        /// properties have been initialized from the values in the application's default
        /// config file.
        /// </returns>
        /// <remarks>
        /// If the config file does not exist, or an I/O or other error
        /// occurs during the read operation, then the method returns a newly-constructed
        /// config object, all of whose properties are initialized to the default
        /// settings.
        /// </remarks>
        IGitHubManagerConfig Load();

        /// <summary>
        /// Saves the current config to the default config file on
        /// the disk.
        /// </summary>
        void Save();
    }
}