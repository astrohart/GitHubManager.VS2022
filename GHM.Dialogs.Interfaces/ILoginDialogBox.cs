using System.Diagnostics;
using xyLOGIX.OAuth.GitHub.Events;
using xyLOGIX.OAuth.GitHub.Models.Interfaces;
using xyLOGIX.UI.Dark.Forms;

namespace GHM.Dialogs.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed events, methods and properties of a dialog box
    /// that is used to log in to GitHub.
    /// </summary>
    public interface ILoginDialogBox : IDarkForm
    {
        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:xyLOGIX.OAuth.GitHub.Models.Interfaces.IGitHubLoginInfo" />
        /// interface that plays the role
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