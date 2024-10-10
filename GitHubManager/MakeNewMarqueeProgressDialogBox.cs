using System;

namespace GitHubManager
{
    /// <summary>
    /// Creates new instances of objects that implement the
    /// <see cref="T:GitHubManager.IMarqueeProgressDialogBox" /> interface, and returns
    /// references to them.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class MakeNewMarqueeProgressDialogBox
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see cref="T:GitHubManager.IMarqueeProgressDialogBox" /> interface and returns
        /// a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:GitHubManager.IMarqueeProgressDialogBox" /> interface.
        /// </returns>
        public static IMarqueeProgressDialogBox FromScratch()
            => new MarqueeProgressDialogBox();

        /// <summary>
        /// Builder extension method that initializes the
        /// <see cref="P:GitHubManager.IMarqueeProgressDialogBox.Message" /> property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that
        /// implements the <see cref="T:GitHubManager.IMarqueeProgressDialogBox" />
        /// interface.
        /// </param>
        /// <param name="message">
        /// (Required.) String containing the new value of the
        /// <see cref="P:GitHubManager.IMarqueeProgressDialogBox.Message" /> property.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this method,
        /// for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required
        /// parameter, <paramref name="self" />, is passed a <see langword="null" /> value.
        /// </exception>
        public static IMarqueeProgressDialogBox HavingMessage(
            this IMarqueeProgressDialogBox self,
            string message
        )
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.Message = message;
            return self;
        }
    }
}