using System.Diagnostics;
using GHM.Dialogs.Interfaces;
using GHM.Dialogs.Presenters.Interfaces;
using PostSharp.Patterns.Diagnostics;

namespace GHM.Dialogs.Presenters.Factories
{
    /// <summary>
    /// Creates new instances of objects that implement the
    /// <see cref="T:GHM.Dialogs.Presenters.Interfaces.ILoginDialogBoxPresenter" />
    /// interface, and returns references to them.
    /// </summary>
    public static class MakeNewLoginDialogBoxPresenter
    {
        /// <summary>
        /// Initializes static data or performs actions that need to be performed
        /// once only for the
        /// <see cref="T:GHM.Dialogs.Presenters.Factories.MakeNewLoginDialogBoxPresenter" />
        /// class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance
        /// being created or before any static members are referenced.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static MakeNewLoginDialogBoxPresenter() { }

        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see cref="T:GHM.Dialogs.Presenters.Interfaces.ILoginDialogBoxPresenter" />
        /// interface and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:GHM.Dialogs.Presenters.Interfaces.ILoginDialogBoxPresenter" />
        /// interface.
        /// </returns>
        public static ILoginDialogBoxPresenter ForView(ILoginDialogBox view)
            => new LoginDialogBoxPresenter(view);
    }
}