namespace GitHubManager
{
    public interface IGitHubLoginServer
    {
        /// <summary>
        /// Occurs when a request has been received from GitHub.
        /// </summary>
        event GitHubServerRequestReceivedEventHandler
            GitHubServerRequestReceived;

        /// <summary>
        /// Gets a value indicating whether the server has been started.
        /// </summary>
        bool IsStarted { get; }

        /// <summary>
        /// Starts this server.
        /// </summary>
        /// <param name="route">
        /// (Required.) String containing the route (i.e., URL) that
        /// the server should listen on.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter,
        /// <paramref name="route" />, is passed a blank or <see langword="null" /> string
        /// for a value.
        /// </exception>
        /// <exception cref="T:System.InvalidOperationException">
        /// Thrown if the <paramref name="route" /> parameter's value does not start with
        /// <c>'http://'</c>.
        /// </exception>
        void Start(string route);
    }
}
