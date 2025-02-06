using GHM.Config.Interfaces;
using GHM.Config.Providers.Factories;
using GHM.Config.Providers.Interfaces;
using GHM.Dialogs.Factories;
using GHM.Windows.Interfaces;
using GHM.Windows.Presenters.Interfaces;
using PostSharp.Patterns.Collections;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using xyLOGIX.Core.Debug;
using xyLOGIX.OAuth.GitHub.Factories;
using xyLOGIX.OAuth.GitHub.Interfaces;
using xyLOGIX.OAuth.GitHub.Models.Factories;
using xyLOGIX.OAuth.GitHub.Models.Interfaces;

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
        /// Initializes static data or performs actions that need to be performed once only
        /// for the <see cref="T:GHM.Windows.Presenters.MainWindowPresenter" /> class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance being
        /// created or before any static members are referenced.
        /// <para />
        /// We've decorated this constructor with the <c>[Log(AttributeExclude = true)]</c>
        /// attribute in order to simplify the logging output.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static MainWindowPresenter() { }

        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:GHM.Windows.Presenters.MainWindowPresenter" /> and returns a
        /// reference to
        /// it.
        /// </summary>
        [Log(AttributeExclude = true)]
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
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required
        /// parameter, <paramref name="view" />, is passed a <see langword="null" /> value.
        /// </exception>
        [Log(AttributeExclude = true)]
        public MainWindowPresenter(IMainWindow view)
            => View = view ?? throw new ArgumentNullException(nameof(view));

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:GHM.Config.Interfaces.IGitHubManagerConfig" /> interface.
        /// </summary>
        private static IGitHubManagerConfig CurrentConfig
        {
            [DebuggerStepThrough]
            get => GitHubManagerConfigProvider.CurrentConfig;
        }

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:GHM.Config.Providers.Interfaces.IGitHubManagerConfigProvider" />
        /// interface.
        /// </summary>
        private static IGitHubManagerConfigProvider GitHubManagerConfigProvider
        {
            [DebuggerStepThrough] get;
        } = GetGitHubManagerConfigProvider.SoleInstance();

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:xyLOGIX.OAuth.GitHub.Interfaces.IGitHubSession" /> interface.
        /// </summary>
        private static IGitHubSession Session { [DebuggerStepThrough] get; } =
            GetGitHubSession.SoleInstance();

        /// <summary>
        /// Shows the user a dialog that allows the user to set the options that
        /// change the program's behavior.
        /// </summary>
        /// <remarks>The options are persisted to and from the config.</remarks>
        public void ConfigureOptions()
        {
            using (var dialogBox = MakeNewOptionsDialogBox.FromScratch()
                       .HavingConfiguration(CurrentConfig))
            {
                if (DialogResult.Cancel == dialogBox.ShowDialog(View))
                    return;
            }
        }

        /// <summary>
        /// Gets all the user's repositories.
        /// <para />
        /// </summary>
        /// <returns>
        /// Collection of objects, each of which implements the
        /// <see cref="T:xyLOGIX.OAuth.GitHub.Models.Interfaces.IRemoteRepo" /> interface,
        /// respectively, that represents the requested data set.
        /// <para />
        /// The empty collection is returned if either the information could not be
        /// obtained or if a different error occurred.
        /// </returns>
        public async Task<IList<IRemoteRepo>> GetRepos()
        {
            var result = new AdvisableCollection<IRemoteRepo>();

            try
            {
                var repositories =
                    await Session.Client.Repository.GetAllForCurrent();

                if (repositories == null) return result;
                if (repositories.Count <= 0) return result;

                foreach (var gitHubRepoInfo in repositories)
                {
                    if (gitHubRepoInfo == null) continue;
                    if (string.IsNullOrWhiteSpace(gitHubRepoInfo.Name))
                        continue;
                    if (string.IsNullOrWhiteSpace(gitHubRepoInfo.CloneUrl))
                        continue;
                    if (string.IsNullOrWhiteSpace(gitHubRepoInfo.Description))
                        continue;

                    result.Add(
                        MakeNewRemoteRepo.HavingCloneUrl(gitHubRepoInfo.CloneUrl)
                                   .AndDescription(gitHubRepoInfo.Description)
                                   .AndName(gitHubRepoInfo.Name)
                    );
                }
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = new AdvisableCollection<IRemoteRepo>();
            }

            return result;
        }
    }
}