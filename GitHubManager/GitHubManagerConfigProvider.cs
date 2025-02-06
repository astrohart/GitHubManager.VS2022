using Alphaleonis.Win32.Filesystem;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Diagnostics;
using xyLOGIX.Core.Debug;

namespace GitHubManager
{
    /// <summary>
    /// Methods and properties for loading, accessing, and saving the
    /// config.
    /// </summary>
    public class GitHubManagerConfigProvider : IGitHubManagerConfigProvider
    {
        /// <summary> Gets the fully-qualified pathname of the default config file. </summary>
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
        static GitHubManagerConfigProvider() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this
        /// class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected GitHubManagerConfigProvider() { }

        /// <summary>
        /// Gets or sets a reference to the instance of an object implementing
        /// the <see cref="T:GitHubManager.IGitHubManagerConfig" /> interface that
        /// represents the currently-loaded config.
        /// </summary>
        public IGitHubManagerConfig CurrentConfig
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that
        /// implements the
        /// <see cref="T:GitHubManager.IGitHubManagerConfigProvider" /> interface.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static IGitHubManagerConfigProvider Instance
        {
            [DebuggerStepThrough] get;
        } = new GitHubManagerConfigProvider();

        /// <summary>
        /// Loads the config from the default config file, and
        /// stores the result in the
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:GitHubManager.IGitHubManagerConfig" /> interface, whose
        /// properties have been initialized from the values in the application's default
        /// config file.
        /// </returns>
        /// <remarks>
        /// If the config file does not exist, or an I/O or other error
        /// occurs during the read operation, then the method returns a newly-constructed
        /// config object, all of whose properties are initialized to the default
        /// settings.
        /// </remarks>
        public IGitHubManagerConfig Load()
        {
            var result = CurrentConfig =
                MakeNewGitHubManagerConfig.FromScratch();

            try
            {
                if (!File.Exists(ConfigurationFilePathname))
                    return result;

                var fileContents = File.ReadAllText(ConfigurationFilePathname);

                if (string.IsNullOrWhiteSpace(fileContents))
                    return result;

                result = CurrentConfig =
                    ConvertGitHubManagerConfig.FromJson(fileContents);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = CurrentConfig =
                    MakeNewGitHubManagerConfig.FromScratch();
            }

            return result;
        }

        /// <summary>
        /// Saves the current config to the default config file on
        /// the disk.
        /// </summary>
        public void Save()
        {
            var folder = Path.GetDirectoryName(ConfigurationFilePathname);

            if (CurrentConfig == null)
                CurrentConfig = MakeNewGitHubManagerConfig.FromScratch();

            try
            {
                if (!Directory.Exists(folder))
                    Directory.CreateDirectory(folder);

                if (File.Exists(ConfigurationFilePathname))
                    File.Delete(ConfigurationFilePathname);

                var fileContents = CurrentConfig.ToJson();

                if (string.IsNullOrWhiteSpace(fileContents)) return;

                File.WriteAllText(ConfigurationFilePathname, fileContents);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }
    }
}