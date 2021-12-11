using System.Collections.Generic;
using System.Threading.Tasks;

namespace GitHubManager
{
    public interface IMainWindowPresenter
    {
        /// <summary>
        /// Shows the user a dialog that allows the user to set the options that change the
        /// program's behavior.
        /// </summary>
        /// <remarks>The options are persisted to and from the configuration.</remarks>
        void ConfigureOptions();

        /// <summary>
        /// Gets all the user's repositories.
        /// <para />
        /// </summary>
        /// <returns>
        /// Collection of instances of <see cref="T:GitHubManager.Repo" /> objects
        /// that contain the data for all of the repositories for the current user.
        /// </returns>
        Task<List<Repo>> GetRepos();
    }
}