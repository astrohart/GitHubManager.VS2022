using System;
using System.Net;
using System.Threading;

namespace GitHubManager
{
    /// <summary>
    /// Simple HTTP server that catches the action of receiving login information from
    /// GitHub.
    /// </summary>
    public class GitHubLoginServer : IGitHubLoginServer
    {
        /// <summary>
        /// A <see cref="T:System.Net.HttpListener" /> that listens for calls on URLs for
        /// us.
        /// </summary>
        private readonly HttpListener _httpListener;

        /// <summary>
        /// A <see cref="T:System.Threading.Thread" /> that monitors for incoming requests.
        /// </summary>
        private readonly Thread _requestContextThread;

        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        static GitHubLoginServer() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        protected GitHubLoginServer()
        {
            _httpListener = new HttpListener();
            _requestContextThread = new Thread(RequestContextThread);
        }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see cref="T:GitHubManager.GitHubLoginServer" />.
        /// </summary>
        public static IGitHubLoginServer Instance { get; } =
            new GitHubLoginServer();

        /// <summary>
        /// Occurs when a request has been received from GitHub.
        /// </summary>
        public event GitHubServerRequestReceivedEventHandler
            GitHubServerRequestReceived;

        /// <summary>
        /// Gets a value indicating whether the server has been started.
        /// </summary>
        public bool IsStarted { get; private set; }

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
        public void Start(string route)
        {
            if (string.IsNullOrWhiteSpace(route))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(route)
                );
            if (!route.StartsWith("http://"))
                throw new InvalidOperationException(
                    "The route must start with 'http://'."
                );

            if (_httpListener == null)
                return;

            if (!route.EndsWith("/"))
                route += "/";

            _httpListener.Prefixes.Add(route);
            _httpListener.Start();

            while (!_httpListener.IsListening)
                Thread.Sleep(50);

            IsStarted = _httpListener.IsListening;

            _requestContextThread.Start();
        }

        /// <summary>
        /// Stops this GitHub login server instance from acknowledging any further
        /// requests.
        /// </summary>
        public void Stop()
        {
            IsStarted = false;

            _requestContextThread?.Abort();
        }

        /// <summary>
        /// Raises the
        /// <see cref="E:GitHubManager.GitHubLoginServer.GitHubServerRequestReceived" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A
        /// <see cref="T:GitHubManager.GitHubServerRequestReceivedEventArgs" /> that
        /// contains the event data.
        /// </param>
        protected virtual void OnGitHubServerRequestReceived(
            GitHubServerRequestReceivedEventArgs e)
            => GitHubServerRequestReceived?.Invoke(this, e);

        /// <summary>
        /// Method that is called when a new HTTP request comes in from a client.
        /// </summary>
        /// <param name="ar">
        /// (Required.) Reference to an instance of an object that
        /// implements the <see cref="T:System.IAsyncResult" /> interface.
        /// </param>
        private void GetContextCallback(IAsyncResult ar)
        {
            if (ar == null)
                return;

            if (_httpListener == null || !_httpListener.IsListening)
                return;

            if (!IsStarted) return;

            var context = _httpListener.EndGetContext(ar);
            if (context == null)
                return;

            _httpListener.BeginGetContext(GetContextCallback, null);

            OnGitHubServerRequestReceived(
                new GitHubServerRequestReceivedEventArgs(
                    context.Request, context.Response
                )
            );
        }

        /// <summary>
        /// Background thread that listens for new requests and then calls a callback
        /// method when they come in.
        /// </summary>
        private void RequestContextThread()
        {
            if (_httpListener == null || !_httpListener.IsListening)
                return;

            if (!IsStarted) return;

            var context = _httpListener.BeginGetContext(
                GetContextCallback, null
            );
        }
    }
}