namespace GitHubManager

using PostSharp.Patterns.Diagnostics;
{
    ///  <summary> Provides access to the one and only instance of the object that implements the <see cref="T:GitHubManager.IGitHubSession" /> interface. </summary>
    [Log(AttributeExclude = true)]
    public static class GetGitHubSession
{
    ///  <summary> Obtains access to the sole instance of the object that implements the <see cref="T:GitHubManager.IGitHubSession" /> interface, and returns a reference to it. </summary> <returns> Reference to the one, and only, instance of the object that implements the <see cref="T:GitHubManager.IGitHubSession" /> interface. </returns>
    public static IGitHubSession SoleInstance()
        => GitHubSession.Instance;
}
}