using Alphaleonis.Win32.Filesystem;
using GHM.Dialogs.Interfaces;
using GHM.Dialogs.Presenters.Interfaces;
using Newtonsoft.Json;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace GHM.Dialogs.Presenters
{
    /// <summary> This is the Presenter for the Login dialog box. </summary>
    public class LoginDialogBoxPresenter : ILoginDialogBoxPresenter
    {
        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the <see cref="T:GHM.Dialogs.Presenters.LoginDialogBoxPresenter" /> class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance being
        /// created or before any static members are referenced.
        /// <para />
        /// We've decorated this constructor with the <c>[Log(AttributeExclude = true)]</c>
        /// attribute in order to simplify the logging output.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static LoginDialogBoxPresenter() { }

        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:GHM.Dialogs.Presenters.LoginDialogBoxPresenter" /> and returns a
        /// reference
        /// to it.
        /// </summary>
        [Log(AttributeExclude = true)]
        public LoginDialogBoxPresenter()
        {
            View = null;

            CommonConstruct();
        }

        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:GHM.Dialogs.Presenters.LoginDialogBoxPresenter" /> and returns a
        /// reference
        /// to it.
        /// </summary>
        /// <param name="view">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see cref="T:GHM.Dialogs.Interfaces.ILoginDialogBox" /> interface that
        /// represents the view.
        /// </param>
        [Log(AttributeExclude = true)]
        public LoginDialogBoxPresenter(ILoginDialogBox view)
        {
            View = view;

            CommonConstruct();
        }

        /// <summary>
        /// Gets or sets a reference to a collection of strings that is the
        /// history of navigated addresses.
        /// </summary>
        public IList<string> AddressHistoryList
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] private set;
        }

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:GitHubManager.IGitHubSession" /> interface.
        /// </summary>
        public IGitHubSession Session
            => GetGitHubSession.SoleInstance();

        /// <summary>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:GHM.Dialogs.Interfaces.ILoginDialogBox" /> interface.
        /// </summary>
        public ILoginDialogBox View { [DebuggerStepThrough] get; }

        /// <summary>
        /// Saves the address history to a file in the user's Local AppData
        /// directory.
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
        /// Provides common initialization for all of this object's constructor
        /// overloads.
        /// </summary>
        private void CommonConstruct()
            => AddressHistoryList = new List<string>();
    }
}