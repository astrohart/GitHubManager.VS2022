using System;

namespace GitHubManager
{
    /// <summary>
    /// Creates new instances of objects that implement the
    /// <see cref="T:GitHubManager.IGitHubManagerConfiguration" /> interface, and
    /// returns references to them.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class MakeNewGitHubManagerConfiguration
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see cref="T:GitHubManager.IGitHubManagerConfiguration" /> interface and
        /// returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:GitHubManager.IGitHubManagerConfiguration" /> interface.
        /// </returns>
        public static IGitHubManagerConfiguration FromScratch()
            => new GitHubManagerConfiguration();

        /// <summary>
        /// Builder extension method that initializes the
        /// <see cref="P:GitHubManager.IGitHubManagerConfiguration.LoginOnStartup" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that
        /// implements the <see cref="T:GitHubManager.IGitHubManagerConfiguration" />
        /// interface.
        /// </param>
        /// <param name="loginOnStartup">
        /// (Required.) A <see cref="T:System.Boolean" />
        /// value that determines whether the application shows the user the Login form or
        /// attempts to login to GitHub upon startup.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this method,
        /// for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required
        /// parameter, <paramref name="self" />, is passed a <see langword="null" /> value.
        /// </exception>
        public static IGitHubManagerConfiguration ThatHasLoginOnStartupSetTo(
            this IGitHubManagerConfiguration self,
            bool loginOnStartup
        )
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.LoginOnStartup = loginOnStartup;
            return self;
        }
    }
}