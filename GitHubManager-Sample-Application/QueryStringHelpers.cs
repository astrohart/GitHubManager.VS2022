using System.Web;

namespace GitHubManager
{
    public static class QueryStringHelpers
    {
        public static T To<T>(this string queryString) where T : new()
        {
            var obj = new T();
            var properties = typeof(T).GetProperties();

            // ASSUME that the queryString parameter actually contains
            // a query string

            var dict = HttpUtility.ParseQueryString(queryString);
            foreach (var property in properties)
                property.SetValue(obj, dict[property.Name], null);

            return obj;
        }
    }
}