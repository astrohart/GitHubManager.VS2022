<a name='assembly'></a>
# GHM.Config.Providers

## Contents

- [GitHubManagerConfigProvider](#T-GHM-Config-Providers-GitHubManagerConfigProvider 'GHM.Config.Providers.GitHubManagerConfigProvider')
  - [#ctor()](#M-GHM-Config-Providers-GitHubManagerConfigProvider-#ctor 'GHM.Config.Providers.GitHubManagerConfigProvider.#ctor')
  - [ConfigurationFilePathname](#F-GHM-Config-Providers-GitHubManagerConfigProvider-ConfigurationFilePathname 'GHM.Config.Providers.GitHubManagerConfigProvider.ConfigurationFilePathname')
  - [CurrentConfig](#P-GHM-Config-Providers-GitHubManagerConfigProvider-CurrentConfig 'GHM.Config.Providers.GitHubManagerConfigProvider.CurrentConfig')
  - [Instance](#P-GHM-Config-Providers-GitHubManagerConfigProvider-Instance 'GHM.Config.Providers.GitHubManagerConfigProvider.Instance')
  - [#cctor()](#M-GHM-Config-Providers-GitHubManagerConfigProvider-#cctor 'GHM.Config.Providers.GitHubManagerConfigProvider.#cctor')
  - [Load()](#M-GHM-Config-Providers-GitHubManagerConfigProvider-Load 'GHM.Config.Providers.GitHubManagerConfigProvider.Load')
  - [Save()](#M-GHM-Config-Providers-GitHubManagerConfigProvider-Save 'GHM.Config.Providers.GitHubManagerConfigProvider.Save')
- [Resources](#T-GHM-Config-Providers-Properties-Resources 'GHM.Config.Providers.Properties.Resources')
  - [Culture](#P-GHM-Config-Providers-Properties-Resources-Culture 'GHM.Config.Providers.Properties.Resources.Culture')
  - [ResourceManager](#P-GHM-Config-Providers-Properties-Resources-ResourceManager 'GHM.Config.Providers.Properties.Resources.ResourceManager')

<a name='T-GHM-Config-Providers-GitHubManagerConfigProvider'></a>
## GitHubManagerConfigProvider `type`

##### Namespace

GHM.Config.Providers

##### Summary

Methods and properties for loading, accessing, and saving the
config.

<a name='M-GHM-Config-Providers-GitHubManagerConfigProvider-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this
class.

##### Parameters

This constructor has no parameters.

<a name='F-GHM-Config-Providers-GitHubManagerConfigProvider-ConfigurationFilePathname'></a>
### ConfigurationFilePathname `constants`

##### Summary

Gets the fully-qualified pathname of the default config file.

<a name='P-GHM-Config-Providers-GitHubManagerConfigProvider-CurrentConfig'></a>
### CurrentConfig `property`

##### Summary

Gets or sets a reference to the instance of an object implementing
the [IGitHubManagerConfig](#T-GHM-Config-Interfaces-IGitHubManagerConfig 'GHM.Config.Interfaces.IGitHubManagerConfig') interface that
represents the currently-loaded config.

<a name='P-GHM-Config-Providers-GitHubManagerConfigProvider-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that
implements the
[IGitHubManagerConfigProvider](#T-GHM-Config-Providers-Interfaces-IGitHubManagerConfigProvider 'GHM.Config.Providers.Interfaces.IGitHubManagerConfigProvider') interface.

<a name='M-GHM-Config-Providers-GitHubManagerConfigProvider-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this
class.

##### Parameters

This method has no parameters.

<a name='M-GHM-Config-Providers-GitHubManagerConfigProvider-Load'></a>
### Load() `method`

##### Summary

Loads the config from the default config file, and
stores the result in the

##### Returns

Reference to an instance of an object that implements the
[IGitHubManagerConfig](#T-GHM-Config-Interfaces-IGitHubManagerConfig 'GHM.Config.Interfaces.IGitHubManagerConfig') interface, whose
properties have been initialized from the values in the application's default
config file.

##### Parameters

This method has no parameters.

##### Remarks

If the config file does not exist, or an I/O or other error
occurs during the read operation, then the method returns a newly-constructed
config object, all of whose properties are initialized to the default
settings.

<a name='M-GHM-Config-Providers-GitHubManagerConfigProvider-Save'></a>
### Save() `method`

##### Summary

Saves the current config to the default config file on
the disk.

##### Parameters

This method has no parameters.

<a name='T-GHM-Config-Providers-Properties-Resources'></a>
## Resources `type`

##### Namespace

GHM.Config.Providers.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-GHM-Config-Providers-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-GHM-Config-Providers-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
