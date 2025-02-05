using System;

namespace GitHubManagerSampleApplication
{
    /// <summary>
    /// Creates new instances of objects that implement the
    /// <see cref="T:GitHubManager.IOptionsDialog" /> interface, and returns references
    /// to them.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class MakeNewOptionsDialogBox
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see cref="T:GitHubManager.IOptionsDialog" /> interface and returns a reference
        /// to it.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:GitHubManager.IOptionsDialog" /> interface.
        /// </returns>
        public static IOptionsDialogBox FromScratch()
            => new OptionsDialogBox();

        /// <summary>
        /// Builder extension method that initializes the
        /// <see cref="P:GitHubManagerSampleApplication.IOptionsDialogBox.Configuration" /> property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that
        /// implements the <see cref="T:GitHubManagerSampleApplication.IOptionsDialogBox" /> interface.
        /// </param>
        /// <param name="configuration">
        /// (Required.) Reference to an instance of an object
        /// that implements the <see cref="T:GitHubManagerSampleApplication.IGitHubManagerConfiguration" />
        /// interface.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this method,
        /// for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required
        /// parameter, <paramref name="self" />, is passed a <see langword="null" /> value.
        /// </exception>
        public static IOptionsDialogBox HavingConfiguration(
            this IOptionsDialogBox self,
            IGitHubManagerConfiguration configuration
        )
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.Configuration = configuration;
            return self;
        }
    }
}