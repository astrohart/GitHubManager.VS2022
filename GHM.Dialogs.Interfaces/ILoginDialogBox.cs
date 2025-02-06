using System.Diagnostics;

namespace GHM.Dialogs.Interfaces
{
    public interface ILoginDialogBox : IDarkForm
    {
        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:GitHubManager.IGitHubLoginInfo" /> interface that plays the role
        /// of an object that contains important login information.
        /// </summary>
        IGitHubLoginInfo GitHubLoginInfo { [DebuggerStepThrough] get; }

        /// <summary>
        /// Occurs when important login and authorization information is received
        /// from GitHub.
        /// </summary>
        event GitHubLoginInfoReceivedEventHandler GitHubLoginInfoReceived;
    }
}