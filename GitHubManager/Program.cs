using CefSharp;
using CefSharp.WinForms;
using PostSharp.Patterns.Diagnostics;
using PostSharp.Patterns.Diagnostics.Backends.Console;
using System;
using System.Windows.Forms;

namespace GitHubManager
{
    /// <summary>
    /// Defines the behaviors of the application.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Gets or sets a reference to an instance of an object that implements the
        /// <see cref="T:GitHubManager.IGitHubManagerConfiguration" /> interface that
        /// represents the currently-loaded configuration.
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
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            LoggingServices.DefaultBackend = new ConsoleLoggingBackend();

            Cef.Initialize(new CefSettings());

            GitHubManagerConfigurationProvider.CurrentConfiguration =
                GitHubManagerConfigurationProvider.Load();

            Session.AssociateWithApp(
                CurrentConfiguration.ClientId, CurrentConfiguration.ClientSecret
            );

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run((Form)MainWindow.Instance);

            GitHubManagerConfigurationProvider.Save();
        }
    }
}