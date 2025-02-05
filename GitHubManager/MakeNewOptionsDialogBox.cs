using PostSharp.Patterns.Diagnostics;
using System;

namespace GitHubManager
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
        /// <see cref="P:GitHubManager.IOptionsDialogBox.Config" /> property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that
        /// implements the <see cref="T:GitHubManager.IOptionsDialogBox" /> interface.
        /// </param>
        /// <param name="config">
        /// (Required.) Reference to an instance of an object
        /// that implements the <see cref="T:GitHubManager.IGitHubManagerConfig" />
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
            IGitHubManagerConfig config
        )
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.Config = config;
            return self;
        }
    }
}