namespace GitHubManager

using PostSharp.Patterns.Diagnostics;
{
    ///  <summary> Creates new instances of objects that implement the <see cref="T:GitHubManager.IGitHubLoginInfo" /> interface, and returns references to them. </summary>
    [Log(AttributeExclude = true)]
    public static class MakeNewGitHubLoginInfo
{
    ///  <summary> Parses the query string of the specified <paramref name="url" /> and returns a new instance of <see cref="T:GitHubManager.GitHubLoginInfo" /> whose properties are initialized with the results. </summary> <param name="url">(Required.) String that contains a URL that begins with the </param> <returns> Reference to an instance of an object that implements the <see cref="T:GitHubManager.IGitHubLoginInfo" /> interface whose properties are initialized to the values that are parsed from the provided <paramref name="url" />, or <see langword="null" /> if this is not feasible. </returns> <exception cref="T:System.ArgumentException"> Thrown if the required parameter, <paramref name="url" />, is passed a blank or <see langword="null" /> string for a value. </exception>
    public static IGitHubLoginInfo FromUrl(string url)
        => GitHubLoginInfo.FromUrl(url);
}
}