using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GHM.Windows.Presenters
{
    /// <summary>
    /// Presenter object that defines the behaviors of the main application
    /// window.
    /// </summary>
    public class MainWindowPresenter : IMainWindowPresenter
    {
        /// <summary>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:GitHubManager.IMainWindow" /> interface.
        /// </summary>
        /// <remarks>This object serves as the View for this Presenter.</remarks>
        private readonly IMainWindow View;

        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:GHM.Windows.Presenters.MainWindowPresenter" /> and returns a reference to
        /// it.
        /// </summary>
        public MainWindowPresenter()
            => View = null;

        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:GitHubManager.MainWindowPresenter" /> and returns a reference to
        /// it.
        /// </summary>
        /// <param name="view">
        /// (Required.) Reference to an instance of an object that
        /// implements the <see cref="T:GitHubManager.IMainWindow" /> interface that plays
        /// the role of the main application window.
        /// </param>
        public MainWindowPresenter(IMainWindow view)
            => View = view;

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:GitHubManager.IGitHubManagerConfig" /> interface.
        /// </summary>
        private static IGitHubManagerConfig CurrentConfig
            => GitHubManagerConfigProvider.CurrentConfig;

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:GitHubManager.IGitHubManagerConfigProvider" /> interface.
        /// </summary>
        private static IGitHubManagerConfigProvider
            GitHubManagerConfigProvider
            => GetGitHubManagerConfigProvider.SoleInstance();

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:GitHubManager.IGitHubSession" /> interface.
        /// </summary>
        private static IGitHubSession Session
            => GetGitHubSession.SoleInstance();

        /// <summary>
        /// Shows the user a dialog that allows the user to set the options that
        /// change the program's behavior.
        /// </summary>
        /// <remarks>The options are persisted to and from the config.</remarks>
        public void ConfigureOptions()
        {
            using (var dialogBox = MakeNewOptionsDialogBox.FromScratch()
                       .HavingConfiguration(CurrentConfig))
                if (DialogResult.Cancel == dialogBox.ShowDialog(View))
                    return;
        }

        /// <summary>
        /// Gets all the user's repositories.
        /// <para />
        /// </summary>
        /// <returns>
        /// Collection of instances of <see cref="T:GitHubManager.Repo" />
        /// objects that contain the data for all of the repositories for the current user.
        /// </returns>
        public async Task<IList<IRepo>> GetRepos()
        {
            var result = new List<IRepo>();

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
                                     .Cast<IRepo>()
                                     .ToList();
            }
            catch
            {
                result = new List<IRepo>();
            }

            return result;
        }
    }
}