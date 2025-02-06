using PostSharp.Patterns.Diagnostics;
using System;
using System.Diagnostics;

namespace GitHubManager
{
    /// <summary>
    /// Creates new instances of objects that implement the
    /// <see cref="T:GitHubManager.IGitHubManagerConfig" /> interface, and
    /// returns references to them.
    /// </summary>
    public static class MakeNewGitHubManagerConfig
    {
        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the <see cref="T:GitHubManager.MakeNewGitHubManagerConfig" /> class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance being
        /// created or before any static members are referenced.
        /// <para />
        /// We've decorated this constructor with the <c>[Log(AttributeExclude = true)]</c>
        /// attribute in order to simplify the logging output.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static MakeNewGitHubManagerConfig() { }

        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see cref="T:GitHubManager.IGitHubManagerConfig" /> interface and
        /// returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:GitHubManager.IGitHubManagerConfig" /> interface.
        /// </returns>
        [DebuggerStepThrough]
        [return: NotLogged]
        public static IGitHubManagerConfig FromScratch()
            => new GitHubManagerConfig();

        /// <summary>
        /// Builder extension method that initializes the
        /// <see cref="P:GitHubManager.IGitHubManagerConfig.LoginOnStartup" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that
        /// implements the <see cref="T:GitHubManager.IGitHubManagerConfig" />
        /// interface.
        /// </param>
        /// <param name="loginOnStartup">
        /// (Required.) A <see cref="T:System.Boolean" />
        /// value that determines whether the application shows the user the Login form or
        /// attempts to log in to GitHub upon startup.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this method,
        /// for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required
        /// parameter, <paramref name="self" />, is passed a <see langword="null" /> value.
        /// </exception>
        [return: NotLogged]
        [DebuggerStepThrough]
        public static IGitHubManagerConfig ThatHasLoginOnStartupSetTo(
            [NotLogged] this IGitHubManagerConfig self,
            bool loginOnStartup
        )
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.LoginOnStartup = loginOnStartup;
            return self;
        }
    }
}