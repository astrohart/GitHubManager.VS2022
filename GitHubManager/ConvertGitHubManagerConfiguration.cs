using System;
using System.Globalization;

namespace GitHubManager
{
    /// <summary>
    /// Methods to serialize and deserialize the application's configuration
    /// to and/or from JSON content.
    /// </summary>
    public static class ConvertGitHubManagerConfiguration
    {
        /// <summary>
        /// Reference to an instance of
        /// <see cref="T:Newtonsoft.Json.JsonSerializerSettings" /> that specifies JSON
        /// configuration settings.
        /// </summary>
        public static readonly JsonSerializerSettings Settings =
            new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                DateParseHandling = DateParseHandling.None,
                Formatting = Formatting.Indented,
                Converters =
                {
                    new IsoDateTimeConverter
                    {
                        DateTimeStyles =
                            DateTimeStyles.AssumeUniversal
                    }
                }
            };

        /// <summary>
        /// Parses the specified <paramref name="json" /> content and, if
        /// successful, initializes an instance of an object that implements the
        /// <see cref="T:GitHubManager.IGitHubManagerConfiguration" /> interface and
        /// returns a reference to it.
        /// </summary>
        /// <param name="json">(Required.) String containing the JSON content to be parsed.</param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:GitHubManager.IGitHubManagerConfiguration" /> interface whose
        /// properties are initialized from the JSON provided..
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter,
        /// <paramref name="json" />, is passed a blank or <see langword="null" /> string
        /// for a value.
        /// </exception>
        public static IGitHubManagerConfiguration FromJson(string json)
        {
            if (string.IsNullOrWhiteSpace(json))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(json)
                );
            return JsonConvert.DeserializeObject<GitHubManagerConfiguration>(
                json, Settings
            );
        }

        /// <summary>
        /// Serializes an instance of an object that implements the
        /// <see cref="T:GitHubManager.IGitHubManagerConfiguration" /> interface to JSON
        /// and returns this data in the form of a <see cref="T:System.String" />.
        /// </summary>
        /// <param name="configuration">
        /// (Required.) Reference to an instance of an object
        /// that implements the <see cref="T:GitHubManager.IGitHubManagerConfiguration" />
        /// interface.
        /// </param>
        /// <returns>
        /// A <see cref="T:System.String" /> that contains the JSON content
        /// equivalent to the object passed.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required
        /// parameter, <paramref name="configuration" />, is passed a
        /// <see langword="null" /> value.
        /// </exception>
        public static string ToJson(
            this IGitHubManagerConfiguration configuration
        )
        {
            if (configuration == null)
                throw new ArgumentNullException(nameof(configuration));

            return JsonConvert.SerializeObject(configuration, Settings);
        }
    }
}