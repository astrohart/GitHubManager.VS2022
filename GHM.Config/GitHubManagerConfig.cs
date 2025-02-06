using GHM.Config.Interfaces;
using Newtonsoft.Json;
using PostSharp.Patterns.Collections;
using PostSharp.Patterns.Diagnostics;
using PostSharp.Patterns.Threading;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using xyLOGIX.Core.Debug;

namespace GHM.Config
{
    /// <summary>
    /// Settings that are user-configurable and that alter the behavior of
    /// the application
    /// </summary>
    [ExplicitlySynchronized]
    public class GitHubManagerConfig : IGitHubManagerConfig
    {
        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the <see cref="T:GHM.Config.GitHubManagerConfig" /> class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance being
        /// created or before any static members are referenced.
        /// <para />
        /// We've decorated this constructor with the <c>[Log(AttributeExclude = true)]</c>
        /// attribute in order to simplify the logging output.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static GitHubManagerConfig() { }

        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:GHM.Config.GitHubManagerConfig" /> and returns a
        /// reference to it.
        /// </summary>
        [JsonConstructor, Log(AttributeExclude = true)]
        public GitHubManagerConfig()
            => Reset();

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:GHM.Config.Interfaces.IGitHubManagerConfig" /> interface that
        /// represents the <c>Blank Configuration</c>.
        /// </summary>
        /// <remarks>
        /// The value of this property is a reference to an instance of the configuration
        /// object whose property(ies) are always set to the default value(s).
        /// </remarks>
        public static IGitHubManagerConfig
            Blank { [DebuggerStepThrough] get; } = new GitHubManagerConfig();

        /// <summary>
        /// Gets or sets a string containing the ID of the particular GitHub app
        /// we want to utilize with this application.
        /// </summary>
        /// <remarks>
        /// The default value of this property is the
        /// <see cref="F:System.String.Empty" /> value.
        /// </remarks>
        [JsonProperty("client_id")]
        public string ClientId
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a string containing the Client Secret of the OAuth App
        /// to bind to this application.
        /// </summary>
        /// <remarks>
        /// The default value of this property is the
        /// <see cref="F:System.String.Empty" /> value.
        /// </remarks>
        [JsonProperty("client_secret")]
        public string ClientSecret
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a value that determines whether the application logs in
        /// to GitHub on startup.
        /// </summary>
        /// <remarks>The default value of this property is <see langword="false" />.</remarks>
        [JsonProperty("login_on_startup")]
        public bool LoginOnStartup
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Get or sets a collection of strings that defines the scopes to be
        /// used with this application.
        /// </summary>
        [JsonProperty("scopes")]
        public IList<string> Scopes
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        } = new AdvisableCollection<string>();

        /// <summary>
        /// Gets a value indicating whether the specified <paramref name="config" /> is
        /// <see langword="null" /> or has all of its properties set to their default
        /// values.
        /// </summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:GHM.Config.Interfaces.IGitHubManagerConfig" />
        /// interface that is to be examined.
        /// <returns>
        /// <see langword="true" /> if the specified <paramref name="config" /> is
        /// <see langword="null" /> or has all of its properties set to their default
        /// values; otherwise, <see langword="false" />.
        /// </returns>
        public static bool IsNullOrBlank(
            [NotLogged] IGitHubManagerConfig config
        )
        {
            var result = true;

            try
            {
                if (config == null) return result;

                result = string.IsNullOrWhiteSpace(config.ClientId) &&
                         string.IsNullOrWhiteSpace(config.ClientSecret) &&
                         config.LoginOnStartup == false &&
                         config.Scopes.Count <= 0;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = true;
            }

            return result;
        }

        /// <summary>
        /// Sets the value(s) of the property(ies) of this object to their default(s).
        /// </summary>
        [Log(AttributeExclude = true)]
        public void Reset()
        {
            ClientId = string.Empty;
            ClientSecret = string.Empty;
            LoginOnStartup = false;
            Scopes.Clear();
        }
    }
}