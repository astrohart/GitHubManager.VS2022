<a name='assembly'></a>
# GHM.Config.Converters

## Contents

- [ConvertGitHubManagerConfig](#T-GHM-Config-Converters-ConvertGitHubManagerConfig 'GHM.Config.Converters.ConvertGitHubManagerConfig')
  - [Settings](#F-GHM-Config-Converters-ConvertGitHubManagerConfig-Settings 'GHM.Config.Converters.ConvertGitHubManagerConfig.Settings')
  - [#cctor()](#M-GHM-Config-Converters-ConvertGitHubManagerConfig-#cctor 'GHM.Config.Converters.ConvertGitHubManagerConfig.#cctor')
  - [FromJson(json)](#M-GHM-Config-Converters-ConvertGitHubManagerConfig-FromJson-System-String- 'GHM.Config.Converters.ConvertGitHubManagerConfig.FromJson(System.String)')
  - [ToJson(config)](#M-GHM-Config-Converters-ConvertGitHubManagerConfig-ToJson-GHM-Config-Interfaces-IGitHubManagerConfig- 'GHM.Config.Converters.ConvertGitHubManagerConfig.ToJson(GHM.Config.Interfaces.IGitHubManagerConfig)')
- [Resources](#T-GHM-Config-Converters-Properties-Resources 'GHM.Config.Converters.Properties.Resources')
  - [Culture](#P-GHM-Config-Converters-Properties-Resources-Culture 'GHM.Config.Converters.Properties.Resources.Culture')
  - [ResourceManager](#P-GHM-Config-Converters-Properties-Resources-ResourceManager 'GHM.Config.Converters.Properties.Resources.ResourceManager')

<a name='T-GHM-Config-Converters-ConvertGitHubManagerConfig'></a>
## ConvertGitHubManagerConfig `type`

##### Namespace

GHM.Config.Converters

##### Summary

Methods to serialize and deserialize the application's config
to and/or from JSON content.

<a name='F-GHM-Config-Converters-ConvertGitHubManagerConfig-Settings'></a>
### Settings `constants`

##### Summary

Reference to an instance of
[JsonSerializerSettings](#T-Newtonsoft-Json-JsonSerializerSettings 'Newtonsoft.Json.JsonSerializerSettings') that specifies JSON
config settings.

<a name='M-GHM-Config-Converters-ConvertGitHubManagerConfig-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the
[ConvertGitHubManagerConfig](#T-GHM-Config-Converters-ConvertGitHubManagerConfig 'GHM.Config.Converters.ConvertGitHubManagerConfig')
class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance being
created or before any static members are referenced.



We've decorated this constructor with the `[Log(AttributeExclude = true)]`
attribute in order to simplify the logging output.

<a name='M-GHM-Config-Converters-ConvertGitHubManagerConfig-FromJson-System-String-'></a>
### FromJson(json) `method`

##### Summary

Parses the specified `json` content and, if
successful, initializes an instance of an object that implements the
[IGitHubManagerConfig](#T-GHM-Config-Interfaces-IGitHubManagerConfig 'GHM.Config.Interfaces.IGitHubManagerConfig')
interface and
returns a reference to it.

##### Returns

Reference to an instance of an object that implements the
[IGitHubManagerConfig](#T-GHM-Config-Interfaces-IGitHubManagerConfig 'GHM.Config.Interfaces.IGitHubManagerConfig')
interface whose
properties are initialized from the JSON provided..

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| json | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the JSON content to be parsed. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter,
`json`, is passed a blank or `null` string
for a value. |

<a name='M-GHM-Config-Converters-ConvertGitHubManagerConfig-ToJson-GHM-Config-Interfaces-IGitHubManagerConfig-'></a>
### ToJson(config) `method`

##### Summary

Serializes an instance of an object that implements the
[IGitHubManagerConfig](#T-GHM-Config-Interfaces-IGitHubManagerConfig 'GHM.Config.Interfaces.IGitHubManagerConfig')
interface to JSON
and returns this data in the form of a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String').

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the JSON content
equivalent to the object passed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| config | [GHM.Config.Interfaces.IGitHubManagerConfig](#T-GHM-Config-Interfaces-IGitHubManagerConfig 'GHM.Config.Interfaces.IGitHubManagerConfig') | (Required.) Reference to an instance of an object
that implements the
[IGitHubManagerConfig](#T-GHM-Config-Interfaces-IGitHubManagerConfig 'GHM.Config.Interfaces.IGitHubManagerConfig')
interface. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required
parameter, `config`, is passed a
`null` value. |

<a name='T-GHM-Config-Converters-Properties-Resources'></a>
## Resources `type`

##### Namespace

GHM.Config.Converters.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-GHM-Config-Converters-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-GHM-Config-Converters-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
