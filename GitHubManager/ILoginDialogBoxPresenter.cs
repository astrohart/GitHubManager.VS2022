using System.Collections.Generic;

namespace GitHubManager
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
        IList<string> AddressHistoryList { get; }

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:GitHubManager.IGitHubSession" /> interface.
        /// </summary>
        IGitHubSession Session { get; }

        /// <summary>
        /// Saves the address history to a file in the user's Local AppData
        /// directory.
        /// </summary>
        void SaveAddressHistoryList();
    }
}