using NUnit.Framework;
using PostSharp.Patterns.Threading;

namespace GHM.Config.Converters.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see cref="T:ConvertGitHubManagerConfig" /> class.
    /// </summary>
    [TestFixture, ExplicitlySynchronized]
    public class ConvertGitHubManagerConfigTests
    {
        /// <summary> <see cref="T:System.String" /> containing sample JSON content. </summary>
        private const string CONFIGURATION_JSON =
            "{\r\n  \"loginOnStartup\": true\r\n}";

        /// <summary>
        /// Asserts that the
        /// <see cref="M:GitHubManager.ConvertGitHubManagerConfig.FromJson" />
        /// method correctly parses the sample
        /// <see
        ///     cref="F:GitHubManager.ConvertGitHubManagerConfigTests.CONFIGURATION_JSON" />
        /// and returns a reference to an instance of an object that implements the
        /// <see cref="T:GitHubManager.IGitHubManagerConfig" /> interface.
        /// </summary>
        [Test]
        public void Test_FromJson_Works()
        {
            IGitHubManagerConfig config = default;

            Assert.DoesNotThrow(
                () => config =
                    ConvertGitHubManagerConfig.FromJson(
                        CONFIGURATION_JSON
                    )
            );

            Assert.That(config, Is.Not.Null);
            Assert.That(config.LoginOnStartup, Is.EqualTo(true));
        }

        /// <summary>
        /// Asserts that the
        /// <see cref="M:GitHubManager.ConvertGitHubManagerConfig.ToJson" /> method
        /// correctly turns an instance of
        /// <see cref="T:GitHubManager.GitHubManagerConfig" /> into JSON content.
        /// </summary>
        [Test]
        public void Test_ToJson_Works()
        {
            var configuration =
                new GitHubManagerConfig { LoginOnStartup = true };

            Assert.That(configuration.ToJson(), Is.EqualTo(CONFIGURATION_JSON));
        }
    }
}