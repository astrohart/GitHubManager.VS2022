<a name='assembly'></a>
# GHM.Config

## Contents

- [GitHubManagerConfig](#T-GHM-Config-GitHubManagerConfig 'GHM.Config.GitHubManagerConfig')
  - [#ctor()](#M-GHM-Config-GitHubManagerConfig-#ctor 'GHM.Config.GitHubManagerConfig.#ctor')
  - [Blank](#P-GHM-Config-GitHubManagerConfig-Blank 'GHM.Config.GitHubManagerConfig.Blank')
  - [ClientId](#P-GHM-Config-GitHubManagerConfig-ClientId 'GHM.Config.GitHubManagerConfig.ClientId')
  - [ClientSecret](#P-GHM-Config-GitHubManagerConfig-ClientSecret 'GHM.Config.GitHubManagerConfig.ClientSecret')
  - [LoginOnStartup](#P-GHM-Config-GitHubManagerConfig-LoginOnStartup 'GHM.Config.GitHubManagerConfig.LoginOnStartup')
  - [Scopes](#P-GHM-Config-GitHubManagerConfig-Scopes 'GHM.Config.GitHubManagerConfig.Scopes')
  - [#cctor()](#M-GHM-Config-GitHubManagerConfig-#cctor 'GHM.Config.GitHubManagerConfig.#cctor')
  - [IsNullOrBlank()](#M-GHM-Config-GitHubManagerConfig-IsNullOrBlank-GHM-Config-Interfaces-IGitHubManagerConfig- 'GHM.Config.GitHubManagerConfig.IsNullOrBlank(GHM.Config.Interfaces.IGitHubManagerConfig)')
  - [Reset()](#M-GHM-Config-GitHubManagerConfig-Reset 'GHM.Config.GitHubManagerConfig.Reset')
- [Resources](#T-GHM-Config-Properties-Resources 'GHM.Config.Properties.Resources')
  - [Culture](#P-GHM-Config-Properties-Resources-Culture 'GHM.Config.Properties.Resources.Culture')
  - [ResourceManager](#P-GHM-Config-Properties-Resources-ResourceManager 'GHM.Config.Properties.Resources.ResourceManager')

<a name='T-GHM-Config-GitHubManagerConfig'></a>
## GitHubManagerConfig `type`

##### Namespace

GHM.Config

##### Summary

Settings that are user-configurable and that alter the behavior of
the application

<a name='M-GHM-Config-GitHubManagerConfig-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[GitHubManagerConfig](#T-GHM-Config-GitHubManagerConfig 'GHM.Config.GitHubManagerConfig') and returns a
reference to it.

##### Parameters

This constructor has no parameters.

<a name='P-GHM-Config-GitHubManagerConfig-Blank'></a>
### Blank `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IGitHubManagerConfig](#T-GHM-Config-Interfaces-IGitHubManagerConfig 'GHM.Config.Interfaces.IGitHubManagerConfig') interface that
represents the `Blank Configuration`.

##### Remarks

The value of this property is a reference to an instance of the configuration
object whose property(ies) are always set to the default value(s).

<a name='P-GHM-Config-GitHubManagerConfig-ClientId'></a>
### ClientId `property`

##### Summary

Gets or sets a string containing the ID of the particular GitHub app
we want to utilize with this application.

##### Remarks

The default value of this property is the
[Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') value.

<a name='P-GHM-Config-GitHubManagerConfig-ClientSecret'></a>
### ClientSecret `property`

##### Summary

Gets or sets a string containing the Client Secret of the OAuth App
to bind to this application.

##### Remarks

The default value of this property is the
[Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') value.

<a name='P-GHM-Config-GitHubManagerConfig-LoginOnStartup'></a>
### LoginOnStartup `property`

##### Summary

Gets or sets a value that determines whether the application logs in
to GitHub on startup.

##### Remarks

The default value of this property is `false`.

<a name='P-GHM-Config-GitHubManagerConfig-Scopes'></a>
### Scopes `property`

##### Summary

Get or sets a collection of strings that defines the scopes to be
used with this application.

<a name='M-GHM-Config-GitHubManagerConfig-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the [GitHubManagerConfig](#T-GHM-Config-GitHubManagerConfig 'GHM.Config.GitHubManagerConfig') class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance being
created or before any static members are referenced.



We've decorated this constructor with the `[Log(AttributeExclude = true)]`
attribute in order to simplify the logging output.

<a name='M-GHM-Config-GitHubManagerConfig-IsNullOrBlank-GHM-Config-Interfaces-IGitHubManagerConfig-'></a>
### IsNullOrBlank() `method`

##### Summary

Gets a value indicating whether the specified `config` is
`null` or has all of its properties set to their default
values.

##### Returns

`true` if the specified `config` is
`null` or has all of its properties set to their default
values; otherwise, `false`.

##### Parameters

This method has no parameters.

<a name='M-GHM-Config-GitHubManagerConfig-Reset'></a>
### Reset() `method`

##### Summary

Sets the value(s) of the property(ies) of this object to their default(s).

##### Parameters

This method has no parameters.

<a name='T-GHM-Config-Properties-Resources'></a>
## Resources `type`

##### Namespace

GHM.Config.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-GHM-Config-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-GHM-Config-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
