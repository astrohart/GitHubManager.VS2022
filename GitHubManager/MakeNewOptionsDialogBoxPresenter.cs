using System;

namespace GitHubManager
{
    /// <summary>
    /// Creates new instances of objects that implement the
    /// <see cref="T:GitHubManager.IOptionsDialogBoxPresenter" /> interface, and
    /// returns references to them.
    /// </summary>
    public static class MakeNewOptionsDialogBoxPresenter
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see cref="T:GitHubManager.IOptionsDialogBoxPresenter" /> interface and returns
        /// a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:GitHubManager.IOptionsDialogBoxPresenter" /> interface.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required
        /// parameter, <paramref name="view" />, is passed a <see langword="null" /> value.
        /// </exception>
        public static IOptionsDialogBoxPresenter FromScratch(
            IOptionsDialogBox view)
        {
            if (view == null) throw new ArgumentNullException(nameof(view));
            return new OptionsDialogBoxPresenter(view);
        }
    }
}