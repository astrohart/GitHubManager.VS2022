namespace GitHubManager

using PostSharp.Patterns.Diagnostics;
{
    ///  <summary> Provides access to the one and only instance of the object that implements the <see cref="T:GitHubManager.IGitHubLoginServer" /> interface. </summary>
    [Log(AttributeExclude = true)]
    public static class GetGitHubLoginServer
{
    ///  <summary> Obtains access to the sole instance of the object that implements the <see cref="T:GitHubManager.IGitHubLoginServer" /> interface, and returns a reference to it. </summary> <returns> Reference to the one, and only, instance of the object that implements the <see cref="T:GitHubManager.IGitHubLoginServer" /> interface. </returns>
    public static IGitHubLoginServer SoleInstance()
        => GitHubLoginServer.Instance;
}
}