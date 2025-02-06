using GHM.Windows.Interfaces;
using GHM.Windows.Presenters.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;

namespace GHM.Windows.Presenters.Factories
{
    /// <summary>
    /// Creates new instances of objects that implement the
    /// <see cref="T:GHM.Windows.Presenters.Interfaces.IMainWindowPresenter" />
    /// interface, and returns references to them.
    /// </summary>
    public static class MakeNewMainWindowPresenter
    {
        /// <summary>
        /// Initializes static data or performs actions that need to be performed
        /// once only for the
        /// <see cref="T:GHM.Windows.Presenters.Factories.MakeNewMainWindowPresenter" />
        /// class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance
        /// being created or before any static members are referenced.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static MakeNewMainWindowPresenter() { }

        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see cref="T:GHM.Windows.Presenters.Interfaces.IMainWindowPresenter" />
        /// interface and returns a reference to it.
        /// </summary>
        /// <param name="view">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see cref="T:GHM.Windows.Interfaces.IMainWindow" /> interface that represents
        /// the main application window.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:GHM.Windows.Presenters.Interfaces.IMainWindowPresenter" />
        /// interface.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required
        /// parameter, <paramref name="view" />, is passed a <see langword="null" /> value.
        /// </exception>
        public static IMainWindowPresenter ForView(IMainWindow view)
            => new MainWindowPresenter(
                view ?? throw new ArgumentNullException(nameof(view))
            );
    }
}