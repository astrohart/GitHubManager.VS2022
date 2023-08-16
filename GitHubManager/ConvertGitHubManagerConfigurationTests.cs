using NUnit.Framework;

namespace GitHubManager
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see cref="T:ConvertGitHubManagerConfiguration" /> class.
    /// </summary>
    [TestFixture]
    public class ConvertGitHubManagerConfigurationTests
    {
        /// <summary>
        /// <see cref="T:System.String" /> containing sample JSON content.
        /// </summary>
        private const string CONFIGURATION_JSON =
            "{\r\n  \"loginOnStartup\": true\r\n}";

        /// <summary>
        /// Asserts that the
        /// <see cref="M:GitHubManager.ConvertGitHubManagerConfiguration.FromJson" />
        /// method correctly parses the sample
        /// <see
        ///     cref="F:GitHubManager.ConvertGitHubManagerConfigurationTests.CONFIGURATION_JSON" />
        /// and returns a reference to an instance of an object that implements the
        /// <see cref="T:GitHubManager.IGitHubManagerConfiguration" /> interface.
        /// </summary>
        [Test]
        public void Test_FromJson_Works()
        {
            IGitHubManagerConfiguration configuration = default;

            Assert.DoesNotThrow(
                () => configuration =
                    ConvertGitHubManagerConfiguration.FromJson(
                        CONFIGURATION_JSON
                    )
            );

            Assert.That(configuration, Is.Not.Null);
            Assert.That(configuration.LoginOnStartup, Is.EqualTo(true));
        }

        /// <summary>
        /// Asserts that the
        /// <see cref="M:GitHubManager.ConvertGitHubManagerConfiguration.ToJson" /> method
        /// correctly turns an instance of
        /// <see cref="T:GitHubManager.GitHubManagerConfiguration" /> into JSON content.
        /// </summary>
        [Test]
        public void Test_ToJson_Works()
        {
            var configuration =
                new GitHubManagerConfiguration { LoginOnStartup = true };

            Assert.That(configuration.ToJson(), Is.EqualTo(CONFIGURATION_JSON));
        }
    }
}
