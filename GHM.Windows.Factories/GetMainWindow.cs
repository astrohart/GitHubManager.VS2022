using GHM.Windows.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Diagnostics;
using xyLOGIX.Core.Debug;

namespace GHM.Windows.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see cref="T:GitHubManager.IMainWindow" /> interface.
    /// </summary>
    public static class GetMainWindow
    {
        /// <summary>
        /// Initializes static data or performs actions that need to be performed
        /// once only for the <see cref="T:GHM.Windows.Factories.GetMainWindow" /> class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance
        /// being created or before any static members are referenced.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static GetMainWindow() { }

        /// <summary>
        /// Obtains access to the sole instance of the object that implements the
        /// <see cref="T:GitHubManager.IMainWindow" /> interface, and returns a reference
        /// to it.
        /// </summary>
        /// <returns>
        /// Reference to the one, and only, instance of the object that implements the
        /// <see cref="T:GitHubManager.IMainWindow" /> interface.
        /// </returns>
        [DebuggerStepThrough]
        public static IMainWindow SoleInstance()
        {
            IMainWindow result;

            try
            {
                result = MainWindow.Instance;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = default;
            }

            return result;
        }
    }
}