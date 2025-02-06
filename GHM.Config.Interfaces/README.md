<a name='assembly'></a>
# GHM.Config.Interfaces

## Contents

- [IGitHubManagerConfig](#T-GHM-Config-Interfaces-IGitHubManagerConfig 'GHM.Config.Interfaces.IGitHubManagerConfig')
  - [ClientId](#P-GHM-Config-Interfaces-IGitHubManagerConfig-ClientId 'GHM.Config.Interfaces.IGitHubManagerConfig.ClientId')
  - [ClientSecret](#P-GHM-Config-Interfaces-IGitHubManagerConfig-ClientSecret 'GHM.Config.Interfaces.IGitHubManagerConfig.ClientSecret')
  - [LoginOnStartup](#P-GHM-Config-Interfaces-IGitHubManagerConfig-LoginOnStartup 'GHM.Config.Interfaces.IGitHubManagerConfig.LoginOnStartup')
  - [Scopes](#P-GHM-Config-Interfaces-IGitHubManagerConfig-Scopes 'GHM.Config.Interfaces.IGitHubManagerConfig.Scopes')
  - [Reset()](#M-GHM-Config-Interfaces-IGitHubManagerConfig-Reset 'GHM.Config.Interfaces.IGitHubManagerConfig.Reset')
- [Resources](#T-GHM-Config-Interfaces-Properties-Resources 'GHM.Config.Interfaces.Properties.Resources')
  - [Culture](#P-GHM-Config-Interfaces-Properties-Resources-Culture 'GHM.Config.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-GHM-Config-Interfaces-Properties-Resources-ResourceManager 'GHM.Config.Interfaces.Properties.Resources.ResourceManager')

<a name='T-GHM-Config-Interfaces-IGitHubManagerConfig'></a>
## IGitHubManagerConfig `type`

##### Namespace

GHM.Config.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of an object, the
values of whose properties define the behaviors of the application.

<a name='P-GHM-Config-Interfaces-IGitHubManagerConfig-ClientId'></a>
### ClientId `property`

##### Summary

Gets or sets a string containing the ID of the particular GitHub app
we want to utilize with this application.

<a name='P-GHM-Config-Interfaces-IGitHubManagerConfig-ClientSecret'></a>
### ClientSecret `property`

##### Summary

Gets or sets a string containing the Client Secret of the OAuth App
to bind to this application.

<a name='P-GHM-Config-Interfaces-IGitHubManagerConfig-LoginOnStartup'></a>
### LoginOnStartup `property`

##### Summary

Gets or sets a value that determines whether the application logs in
to GitHub on startup.

<a name='P-GHM-Config-Interfaces-IGitHubManagerConfig-Scopes'></a>
### Scopes `property`

##### Summary

Get or sets a collection of strings that defines the scopes to be
used with this application.

<a name='M-GHM-Config-Interfaces-IGitHubManagerConfig-Reset'></a>
### Reset() `method`

##### Summary

Sets the value(s) of the property(ies) of this object to their default(s).

##### Parameters

This method has no parameters.

<a name='T-GHM-Config-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

GHM.Config.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-GHM-Config-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-GHM-Config-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
