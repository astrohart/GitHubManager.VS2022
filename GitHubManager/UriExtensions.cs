using System;
using System.Collections.Specialized;
using System.Linq;

namespace GitHubManager
{
    /// <summary>
    /// Extension methods for instances of <see cref="T:System.Uri" />.
    /// </summary>
    public static class UriExtensions
    {
        /// <summary>
        /// Parses the query string (data provided after the '?' character in a URL) of the
        /// specified <paramref name="uri" />.
        /// </summary>
        /// <param name="uri">
        /// (Required.) A <see cref="T:System.Uri" /> whose query string
        /// is to be parsed.
        /// </param>
        /// <returns>
        /// If the parse operation is successful, a
        /// <see cref="T:System.Collections.Specialized.NameValueCollection" /> is returned
        /// where the names are the names of the query parameters and the values are the
        /// query parameter values.
        /// </returns>
        public static NameValueCollection ParseQueryString(this Uri uri)
        {
            if (uri == null) throw new ArgumentNullException(nameof(uri));
            if (string.IsNullOrWhiteSpace(uri.Query))
                throw new ArgumentException(
                    "The provided URI does not have a query string."
                );
            if (string.IsNullOrWhiteSpace(uri.AbsoluteUri))
                throw new ArgumentException(
                    "There is nothing provided for the request URI."
                );

            var result = new NameValueCollection();

            try
            {
                if (!uri.AbsoluteUri.StartsWith(GitHubUrls.OAuthRedirectURL))
                    return result;

                var queryString =
                    uri.Query.Substring(1); // Remove '?' character in front
                if (string.IsNullOrWhiteSpace(queryString)) return result;

                return queryString.Split('&')
                                  .ToDictionary(
                                      s => s.Split('=')[0], s => s.Split('=')[1]
                                  )
                                  .Aggregate(
                                      new NameValueCollection(), (seed, current)
                                          =>
                                      {
                                          seed.Add(current.Key, current.Value);
                                          return seed;
                                      }
                                  );
            }
            catch
            {
                result = result = new NameValueCollection();
            }

            return result;
        }
    }
}