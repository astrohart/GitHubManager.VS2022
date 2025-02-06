using System.Diagnostics;

namespace GitHubManager
{
    public interface IGitHubLoginInfo
    {
        /// <summary> Gets or sets a string containing the ID of the client. </summary>
        string client_id
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary> Gets or sets a string containing a comma-separated list of scopes. </summary>
        string scope { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

        /// <summary> Gets or sets a string containing a state value. </summary>
        string state { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
    }
}