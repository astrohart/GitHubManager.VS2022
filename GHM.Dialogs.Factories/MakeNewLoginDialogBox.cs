using PostSharp.Patterns.Diagnostics;
using System.Diagnostics;

namespace GHM.Dialogs.Factories
{
    /// <summary>
    /// Creates new instances of objects that implement the
    /// <see cref="T:GitHubManager.ILoginDialogBox" /> interface, and returns
    /// references to them.
    /// </summary>
    public static class MakeNewLoginDialogBox
    {
        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the <see cref="T:GHM.Dialogs.Factories.MakeNewLoginDialogBox" /> class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance being
        /// created or before any static members are referenced.
        /// <para />
        /// We've decorated this constructor with the <c>[Log(AttributeExclude = true)]</c>
        /// attribute in order to simplify the logging output.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static MakeNewLoginDialogBox() { }

        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see cref="T:GitHubManager.ILoginDialogBox" /> interface and returns a
        /// reference to it.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:GitHubManager.ILoginDialogBox" /> interface.
        /// </returns>
        [return: NotLogged]
        [DebuggerStepThrough]
        public static ILoginDialogBox FromScratch()
            => new LoginDialogBox();
    }
}