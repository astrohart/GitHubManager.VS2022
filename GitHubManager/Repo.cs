using System.Diagnostics;

namespace GitHubManager
{
    /// <summary> POCO to encapsulate a GitHub repository. </summary>
    public class Repo : IRepo
    {
        /// <summary>
        /// Gets or sets the Clone URL (URL ending in <c>.git</c>) from which the
        /// repository can be cloned.
        /// </summary>
        public string CloneUrl { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

        /// <summary> Gets or sets the repository's description. </summary>
        public string Description { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

        /// <summary> Gets or sets the name of the repository. </summary>
        public string Name { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
    }
}