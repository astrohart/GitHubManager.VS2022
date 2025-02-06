using GHM.Config.Providers.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Diagnostics;
using xyLOGIX.Core.Debug;

namespace GHM.Config.Providers.Factories

{
    /// <summary>
    /// Provides access to the one and only instance of the object that
    /// implements the
    /// <see cref="T:GHM.Config.Providers.Interfaces.IGitHubManagerConfigProvider" />
    /// interface.
    /// </summary>
    public static class GetGitHubManagerConfigProvider
    {
        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the
        /// <see cref="T:GHM.Config.Providers.Factories.GetGitHubManagerConfigProvider" />
        /// class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance being
        /// created or before any static members are referenced.
        /// <para />
        /// We've decorated this constructor with the <c>[Log(AttributeExclude = true)]</c>
        /// attribute in order to simplify the logging output.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static GetGitHubManagerConfigProvider() { }

        /// <summary>
        /// Obtains access to the sole instance of the object that implements the
        /// <see cref="T:GHM.Config.Providers.Interfaces.IGitHubManagerConfigProvider" />
        /// interface,
        /// and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to the one, and only, instance of the object that
        /// implements the
        /// <see cref="T:GHM.Config.Providers.Interfaces.IGitHubManagerConfigProvider" />
        /// interface.
        /// </returns>
        [DebuggerStepThrough]
        [return: NotLogged]
        public static IGitHubManagerConfigProvider SoleInstance()
        {
            IGitHubManagerConfigProvider result = default;

            try
            {
                result = GitHubManagerConfigProvider.Instance;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = default;
            }

            return result;
        }
    }
}