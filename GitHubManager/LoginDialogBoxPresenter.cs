using Alphaleonis.Win32.Filesystem;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace GitHubManager
{
    /// <summary>
    /// This is the Presenter for the Login dialog box.
    /// </summary>
    public class LoginDialogBoxPresenter : ILoginDialogBoxPresenter
    {
        /// <summary>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:GitHubManager.ILoginDialogBox" /> interface.
        /// </summary>
        private ILoginDialogBox View;

        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:GitHubManager.LoginDialogBoxPresenter" /> and returns a reference
        /// to it.
        /// </summary>
        public LoginDialogBoxPresenter()
        {
            View = null;

            CommonConstruct();
        }

        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:GitHubManager.LoginDialogBoxPresenter" /> and returns a reference
        /// to it.
        /// </summary>
        public LoginDialogBoxPresenter(ILoginDialogBox view)
        {
            View = view;

            CommonConstruct();
        }

        /// <summary>
        /// Gets a reference to an instance of an object that implements the <see cref="T:GitHubManager.IGitHubSession" /> interface.
        /// </summary>
        public IGitHubSession Session
            => GetGitHubSession.SoleInstance();

        /// <summary>
        /// Gets or sets a reference to a collection of strings that is the history of
        /// navigated addresses.
        /// </summary>
        public IList<string> AddressHistoryList { get; private set; }

        /// <summary>
        /// Saves the address history to a file in the user's Local AppData directory.
        /// </summary>
        public void SaveAddressHistoryList()
        {
            try
            {
                var json = JsonConvert.SerializeObject(
                    AddressHistoryList, Formatting.Indented
                );

                var file = Path.Combine(
                    Environment.GetFolderPath(
                        Environment.SpecialFolder.LocalApplicationData
                    ),
                    @"xyLOGIX, LLC\GitHub Manager\History\.address.history.json"
                );

                var folder = Path.GetDirectoryName(file);

                if (!Directory.Exists(folder))
                    Directory.CreateDirectory(folder);

                if (File.Exists(file))
                    File.Delete(file);

                File.WriteAllText(file, json);
            }
            catch
            {
                //Ignored.
            }
        }

        /// <summary>
        /// Provides common initialization for all of this object's constructor overloads.
        /// </summary>
        private void CommonConstruct()
        {
            AddressHistoryList = new List<string>();
        }
    }
}