namespace GitHubManager
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of a POCO that
    /// maintains information about each Repository.
    /// </summary>
    public interface IRepo
    {
        /// <summary>
        /// Gets or sets the Clone URL (URL ending in <c>.git</c>) from which the
        /// repository can be cloned.
        /// </summary>
        string CloneUrl { get; set; }

        /// <summary> Gets or sets the repository's description. </summary>
        string Description { get; set; }

        /// <summary> Gets or sets the name of the repository. </summary>
        string Name { get; set; }
    }

    /// <summary> POCO to encapsulate a GitHub repository. </summary>
    public class Repo : IRepo
    {
        /// <summary>
        /// Gets or sets the Clone URL (URL ending in <c>.git</c>) from which the
        /// repository can be cloned.
        /// </summary>
        public string CloneUrl { get; set; }

        /// <summary> Gets or sets the repository's description. </summary>
        public string Description { get; set; }

        /// <summary> Gets or sets the name of the repository. </summary>
        public string Name { get; set; }
    }
}