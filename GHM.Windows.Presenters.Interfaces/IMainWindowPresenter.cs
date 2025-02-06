using System.Collections.Generic;
using System.Threading.Tasks;
using xyLOGIX.OAuth.GitHub.Models.Interfaces;

namespace GHM.Windows.Presenters.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of the
    /// <c>Presenter</c> object for the main application window.
    /// </summary>
    public interface IMainWindowPresenter
    {
        /// <summary>
        /// Shows the user a dialog that allows the user to set the options that
        /// change the program's behavior.
        /// </summary>
        /// <remarks>The options are persisted to and from the config.</remarks>
        void ConfigureOptions();

        /// <summary>
        /// Gets all the user's repositories.
        /// <para />
        /// </summary>
        /// <returns>
        /// Collection of objects, each of which implements the
        /// <see cref="T:xyLOGIX.OAuth.GitHub.Models.Interfaces.IRepo" /> interface,
        /// respectively, that represents the requested data set.
        /// <para />
        /// The empty collection is returned if either the information could not be
        /// obtained or if a different error occurred.
        /// </returns>
        Task<IList<IRepo>> GetRepos();
    }
}