<a name='assembly'></a>
# GHM.Config.Providers.Factories

## Contents

- [GetGitHubManagerConfigProvider](#T-GHM-Config-Providers-Factories-GetGitHubManagerConfigProvider 'GHM.Config.Providers.Factories.GetGitHubManagerConfigProvider')
  - [#cctor()](#M-GHM-Config-Providers-Factories-GetGitHubManagerConfigProvider-#cctor 'GHM.Config.Providers.Factories.GetGitHubManagerConfigProvider.#cctor')
  - [SoleInstance()](#M-GHM-Config-Providers-Factories-GetGitHubManagerConfigProvider-SoleInstance 'GHM.Config.Providers.Factories.GetGitHubManagerConfigProvider.SoleInstance')
- [Resources](#T-GHM-Config-Providers-Factories-Properties-Resources 'GHM.Config.Providers.Factories.Properties.Resources')
  - [Culture](#P-GHM-Config-Providers-Factories-Properties-Resources-Culture 'GHM.Config.Providers.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-GHM-Config-Providers-Factories-Properties-Resources-ResourceManager 'GHM.Config.Providers.Factories.Properties.Resources.ResourceManager')

<a name='T-GHM-Config-Providers-Factories-GetGitHubManagerConfigProvider'></a>
## GetGitHubManagerConfigProvider `type`

##### Namespace

GHM.Config.Providers.Factories

##### Summary

Provides access to the one and only instance of the object that
implements the
[IGitHubManagerConfigProvider](#T-GHM-Config-Providers-Interfaces-IGitHubManagerConfigProvider 'GHM.Config.Providers.Interfaces.IGitHubManagerConfigProvider')
interface.

<a name='M-GHM-Config-Providers-Factories-GetGitHubManagerConfigProvider-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the
[GetGitHubManagerConfigProvider](#T-GHM-Config-Providers-Factories-GetGitHubManagerConfigProvider 'GHM.Config.Providers.Factories.GetGitHubManagerConfigProvider')
class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance being
created or before any static members are referenced.



We've decorated this constructor with the `[Log(AttributeExclude = true)]`
attribute in order to simplify the logging output.

<a name='M-GHM-Config-Providers-Factories-GetGitHubManagerConfigProvider-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[IGitHubManagerConfigProvider](#T-GHM-Config-Providers-Interfaces-IGitHubManagerConfigProvider 'GHM.Config.Providers.Interfaces.IGitHubManagerConfigProvider')
interface,
and returns a reference to it.

##### Returns

Reference to the one, and only, instance of the object that
implements the
[IGitHubManagerConfigProvider](#T-GHM-Config-Providers-Interfaces-IGitHubManagerConfigProvider 'GHM.Config.Providers.Interfaces.IGitHubManagerConfigProvider')
interface.

##### Parameters

This method has no parameters.

<a name='T-GHM-Config-Providers-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

GHM.Config.Providers.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-GHM-Config-Providers-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-GHM-Config-Providers-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
