using Alphaleonis.Win32.Filesystem;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Diagnostics;

namespace GitHubManager
{
    /// <summary>
    /// Methods and properties for loading, accessing, and saving the
    /// configuration.
    /// </summary>
    public class
        GitHubManagerConfigurationProvider : IGitHubManagerConfigurationProvider
    {
        /// <summary> Gets the fully-qualified pathname of the default configuration file. </summary>
        public readonly string ConfigurationFilePathname = Path.Combine(
            Environment.GetFolderPath(
                Environment.SpecialFolder.LocalApplicationData
            ), @"xyLOGIX, LLC\GitHub Manager\Config\.config.json"
        );

        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this
        /// class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static GitHubManagerConfigurationProvider() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this
        /// class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected GitHubManagerConfigurationProvider() { }

        /// <summary>
        /// Gets or sets a reference to the instance of an object implementing
        /// the <see cref="T:GitHubManager.IGitHubManagerConfiguration" /> interface that
        /// represents the currently-loaded configuration.
        /// </summary>
        public IGitHubManagerConfiguration CurrentConfiguration { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that
        /// implements the
        /// <see cref="T:GitHubManager.IGitHubManagerConfigurationProvider" /> interface.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static IGitHubManagerConfigurationProvider Instance { [DebuggerStepThrough] get; } =
            new GitHubManagerConfigurationProvider();

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
        public IGitHubManagerConfiguration Load()
        {
            var result = MakeNewGitHubManagerConfiguration.FromScratch();

            try
            {
                if (!File.Exists(ConfigurationFilePathname))
                    return result;

                result = ConvertGitHubManagerConfiguration.FromJson(
                    File.ReadAllText(ConfigurationFilePathname)
                );
            }
            catch
            {
                result = MakeNewGitHubManagerConfiguration.FromScratch();
            }

            return result;
        }

        /// <summary>
        /// Saves the current configuration to the default configuration file on
        /// the disk.
        /// </summary>
        public void Save()
        {
            var folder = Path.GetDirectoryName(ConfigurationFilePathname);

            if (CurrentConfiguration == null)
                CurrentConfiguration =
                    MakeNewGitHubManagerConfiguration.FromScratch();

            try
            {
                if (!Directory.Exists(folder))
                    Directory.CreateDirectory(folder);

                if (File.Exists(ConfigurationFilePathname))
                    File.Delete(ConfigurationFilePathname);

                File.WriteAllText(
                    ConfigurationFilePathname, CurrentConfiguration.ToJson()
                );
            }
            catch
            {
                //Ignored.
            }
        }
    }
}