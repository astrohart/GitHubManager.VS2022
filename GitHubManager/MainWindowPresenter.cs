using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitHubManager
{
    public class MainWindowPresenter : IMainWindowPresenter
    {
        /// <summary>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:GitHubManager.IMainWindow" /> interface.
        /// </summary>
        /// <remarks>This object serves as the View for this Presenter.</remarks>
        private readonly IMainWindow View;

        /// <summary>
        /// Constructs a new instance of <see cref="T:GitHubManager.MainWindowPresenter" />
        /// and returns a reference to it.
        /// </summary>
        public MainWindowPresenter()
            => View = null;

        /// <summary>
        /// Constructs a new instance of <see cref="T:GitHubManager.MainWindowPresenter" />
        /// and returns a reference to it.
        /// </summary>
        public MainWindowPresenter(IMainWindow view)
            => View = view;

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:GitHubManager.IGitHubManagerConfiguration" /> interface.
        /// </summary>
        private static IGitHubManagerConfiguration CurrentConfiguration
            => GitHubManagerConfigurationProvider.CurrentConfiguration;

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:GitHubManager.IGitHubSession" /> interface.
        /// </summary>
        private static IGitHubSession Session
            => GetGitHubSession.SoleInstance();

        /// <summary>
        /// Shows the user a dialog that allows the user to set the options that change the
        /// program's behavior.
        /// </summary>
        /// <remarks>The options are persisted to and from the configuration.</remarks>
        public void ConfigureOptions()
        {
            using (var dialogBox = MakeNewOptionsDialogBox.FromScratch()
                .HavingConfiguration(CurrentConfiguration))
            {
                if (DialogResult.Cancel == dialogBox.ShowDialog(View)) return;
            }
        }

        /// <summary>
        /// Gets all the user's repositories.
        /// <para />
        /// </summary>
        /// <returns>
        /// Collection of instances of <see cref="T:GitHubManager.Repo" /> objects
        /// that contain the data for all of the repositories for the current user.
        /// </returns>
        public async Task<List<Repo>> GetRepos()
        {
            var result = new List<Repo>();

            try
            {
                var repositories =
                    await Session.Client.Repository.GetAllForCurrent();

                result = repositories.Select(
                                         r => new Repo
                                         {
                                             CloneUrl = r.CloneUrl,
                                             Description = r.Description,
                                             Name = r.Name
                                         }
                                     )
                                     .ToList();
            }
            catch
            {
                result = new List<Repo>();
            }

            return result;
        }
    }
}