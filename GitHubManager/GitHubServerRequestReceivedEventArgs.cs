using System;
using System.Net;

namespace GitHubManager
{
    /// <summary>
    /// Provides information for GitHubServerRequestReceived event handlers.
    /// </summary>
    public class GitHubServerRequestReceivedEventArgs : EventArgs
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:GitHubManager.GitHubServerRequestReceivedEventArgs" /> and returns
        /// a reference to it.
        /// </summary>
        /// <param name="request">
        /// (Required.) Reference to an instance of
        /// <see cref="T:System.Net.HttpListenerRequest" /> that contains information about
        /// the request that has been received.
        /// </param>
        /// <param name="response">
        /// (Required.) Reference to an instance of
        /// <see cref="T:System.Net.HttpListenerResponse" /> that contains the endpoint to
        /// use for sending responses.
        /// </param>
        public GitHubServerRequestReceivedEventArgs(HttpListenerRequest request,
            HttpListenerResponse response)
        {
            Request = request;
            Response = response;
        }

        /// <summary>
        /// Gets a reference to an instance of
        /// <see cref="T:System.Net.HttpListenerRequest" /> that contains the information
        /// about the request that has been received.
        /// </summary>
        public HttpListenerRequest Request { get; }

        /// <summary>
        /// Gets a reference to an instance of
        /// <see cref="T:System.Net.HttpListenerResponse" /> that contains the endpoint to
        /// use for sending responses.
        /// </summary>
        public HttpListenerResponse Response { get; }
    }
}
