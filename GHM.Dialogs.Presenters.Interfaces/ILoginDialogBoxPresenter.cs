using System.Collections.Generic;
using System.Diagnostics;
using xyLOGIX.OAuth.GitHub.Interfaces;

namespace GHM.Dialogs.Presenters.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of the Presenter
    /// of the Login dialog box.
    /// </summary>
    public interface ILoginDialogBoxPresenter
    {
        /// <summary>
        /// Gets or sets a reference to a collection of strings that is the
        /// history of navigated addresses.
        /// </summary>
        IList<string> AddressHistoryList { [DebuggerStepThrough] get; }

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:xyLOGIX.OAuth.GitHub.Interfaces.IGitHubSession" /> interface.
        /// </summary>
        IGitHubSession Session { [DebuggerStepThrough] get; }

        /// <summary>
        /// Saves the address history to a file in the user's Local AppData
        /// directory.
        /// </summary>
        void SaveAddressHistoryList();
    }
}