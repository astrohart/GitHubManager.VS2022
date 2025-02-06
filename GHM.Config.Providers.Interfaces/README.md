<a name='assembly'></a>
# GHM.Config.Providers.Interfaces

## Contents

- [IGitHubManagerConfigProvider](#T-GHM-Config-Providers-Interfaces-IGitHubManagerConfigProvider 'GHM.Config.Providers.Interfaces.IGitHubManagerConfigProvider')
  - [CurrentConfig](#P-GHM-Config-Providers-Interfaces-IGitHubManagerConfigProvider-CurrentConfig 'GHM.Config.Providers.Interfaces.IGitHubManagerConfigProvider.CurrentConfig')
  - [Load()](#M-GHM-Config-Providers-Interfaces-IGitHubManagerConfigProvider-Load 'GHM.Config.Providers.Interfaces.IGitHubManagerConfigProvider.Load')
  - [Save()](#M-GHM-Config-Providers-Interfaces-IGitHubManagerConfigProvider-Save 'GHM.Config.Providers.Interfaces.IGitHubManagerConfigProvider.Save')
- [Resources](#T-GHM-Config-Providers-Interfaces-Properties-Resources 'GHM.Config.Providers.Interfaces.Properties.Resources')
  - [Culture](#P-GHM-Config-Providers-Interfaces-Properties-Resources-Culture 'GHM.Config.Providers.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-GHM-Config-Providers-Interfaces-Properties-Resources-ResourceManager 'GHM.Config.Providers.Interfaces.Properties.Resources.ResourceManager')

<a name='T-GHM-Config-Providers-Interfaces-IGitHubManagerConfigProvider'></a>
## IGitHubManagerConfigProvider `type`

##### Namespace

GHM.Config.Providers.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of a
config-provider object.

<a name='P-GHM-Config-Providers-Interfaces-IGitHubManagerConfigProvider-CurrentConfig'></a>
### CurrentConfig `property`

##### Summary

Gets or sets a reference to the instance of an object implementing
the [IGitHubManagerConfig](#T-GHM-Config-Interfaces-IGitHubManagerConfig 'GHM.Config.Interfaces.IGitHubManagerConfig') interface that
represents the currently-loaded config.

<a name='M-GHM-Config-Providers-Interfaces-IGitHubManagerConfigProvider-Load'></a>
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

<a name='M-GHM-Config-Providers-Interfaces-IGitHubManagerConfigProvider-Save'></a>
### Save() `method`

##### Summary

Saves the current config to the default config file on
the disk.

##### Parameters

This method has no parameters.

<a name='T-GHM-Config-Providers-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

GHM.Config.Providers.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-GHM-Config-Providers-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-GHM-Config-Providers-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
