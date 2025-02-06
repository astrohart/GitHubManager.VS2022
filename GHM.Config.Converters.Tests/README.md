<a name='assembly'></a>
# GHM.Config.Converters.Tests

## Contents

- [ConvertGitHubManagerConfigTests](#T-GHM-Config-Converters-Tests-ConvertGitHubManagerConfigTests 'GHM.Config.Converters.Tests.ConvertGitHubManagerConfigTests')
  - [CONFIGURATION_JSON](#F-GHM-Config-Converters-Tests-ConvertGitHubManagerConfigTests-CONFIGURATION_JSON 'GHM.Config.Converters.Tests.ConvertGitHubManagerConfigTests.CONFIGURATION_JSON')
  - [Test_FromJson_Works()](#M-GHM-Config-Converters-Tests-ConvertGitHubManagerConfigTests-Test_FromJson_Works 'GHM.Config.Converters.Tests.ConvertGitHubManagerConfigTests.Test_FromJson_Works')
  - [Test_ToJson_Works()](#M-GHM-Config-Converters-Tests-ConvertGitHubManagerConfigTests-Test_ToJson_Works 'GHM.Config.Converters.Tests.ConvertGitHubManagerConfigTests.Test_ToJson_Works')
- [Resources](#T-GHM-Config-Converters-Tests-Properties-Resources 'GHM.Config.Converters.Tests.Properties.Resources')
  - [Culture](#P-GHM-Config-Converters-Tests-Properties-Resources-Culture 'GHM.Config.Converters.Tests.Properties.Resources.Culture')
  - [ResourceManager](#P-GHM-Config-Converters-Tests-Properties-Resources-ResourceManager 'GHM.Config.Converters.Tests.Properties.Resources.ResourceManager')

<a name='T-GHM-Config-Converters-Tests-ConvertGitHubManagerConfigTests'></a>
## ConvertGitHubManagerConfigTests `type`

##### Namespace

GHM.Config.Converters.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[ConvertGitHubManagerConfig](#T-ConvertGitHubManagerConfig 'ConvertGitHubManagerConfig') class.

<a name='F-GHM-Config-Converters-Tests-ConvertGitHubManagerConfigTests-CONFIGURATION_JSON'></a>
### CONFIGURATION_JSON `constants`

##### Summary

[String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing sample JSON content.

<a name='M-GHM-Config-Converters-Tests-ConvertGitHubManagerConfigTests-Test_FromJson_Works'></a>
### Test_FromJson_Works() `method`

##### Summary

Asserts that the
[FromJson](#M-GitHubManager-ConvertGitHubManagerConfig-FromJson 'GitHubManager.ConvertGitHubManagerConfig.FromJson')
method correctly parses the sample
[CONFIGURATION_JSON](#F-GitHubManager-ConvertGitHubManagerConfigTests-CONFIGURATION_JSON 'GitHubManager.ConvertGitHubManagerConfigTests.CONFIGURATION_JSON')
and returns a reference to an instance of an object that implements the
[IGitHubManagerConfig](#T-GHM-Config-Interfaces-IGitHubManagerConfig 'GHM.Config.Interfaces.IGitHubManagerConfig') interface.

##### Parameters

This method has no parameters.

<a name='M-GHM-Config-Converters-Tests-ConvertGitHubManagerConfigTests-Test_ToJson_Works'></a>
### Test_ToJson_Works() `method`

##### Summary

Asserts that the
[ToJson](#M-GitHubManager-ConvertGitHubManagerConfig-ToJson 'GitHubManager.ConvertGitHubManagerConfig.ToJson') method
correctly turns an instance of
[GitHubManagerConfig](#T-GitHubManager-GitHubManagerConfig 'GitHubManager.GitHubManagerConfig') into JSON content.

##### Parameters

This method has no parameters.

<a name='T-GHM-Config-Converters-Tests-Properties-Resources'></a>
## Resources `type`

##### Namespace

GHM.Config.Converters.Tests.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-GHM-Config-Converters-Tests-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-GHM-Config-Converters-Tests-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
