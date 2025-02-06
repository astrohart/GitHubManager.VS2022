using GHM.Config.Interfaces;
using GHM.Dialogs.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Diagnostics;

namespace GHM.Dialogs.Factories
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
        /// Initializes static data or performs actions that need to be performed once only
        /// for the <see cref="T:GHM.Dialogs.Factories.MakeNewOptionsDialogBox" /> class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance being
        /// created or before any static members are referenced.
        /// <para />
        /// We've decorated this constructor with the <c>[Log(AttributeExclude = true)]</c>
        /// attribute in order to simplify the logging output.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static MakeNewOptionsDialogBox() { }

        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see cref="T:GitHubManager.IOptionsDialog" /> interface and returns a reference
        /// to it.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:GitHubManager.IOptionsDialog" /> interface.
        /// </returns>
        [DebuggerStepThrough]
        [return: NotLogged]
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
        /// that implements the <see cref="T:GHM.Config.Interfaces.IGitHubManagerConfig" />
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
        [DebuggerStepThrough]
        [return: NotLogged]
        public static IOptionsDialogBox HavingConfiguration(
            [NotLogged] this IOptionsDialogBox self,
            [NotLogged] IGitHubManagerConfig config
        )
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.CurrentConfig = config;
            return self;
        }
    }
}