<a name='assembly'></a>
# GHM.Windows.Factories

## Contents

- [GetMainWindow](#T-GHM-Windows-Factories-GetMainWindow 'GHM.Windows.Factories.GetMainWindow')
  - [#cctor()](#M-GHM-Windows-Factories-GetMainWindow-#cctor 'GHM.Windows.Factories.GetMainWindow.#cctor')
  - [SoleInstance()](#M-GHM-Windows-Factories-GetMainWindow-SoleInstance 'GHM.Windows.Factories.GetMainWindow.SoleInstance')
- [Resources](#T-GHM-Windows-Factories-Properties-Resources 'GHM.Windows.Factories.Properties.Resources')
  - [Culture](#P-GHM-Windows-Factories-Properties-Resources-Culture 'GHM.Windows.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-GHM-Windows-Factories-Properties-Resources-ResourceManager 'GHM.Windows.Factories.Properties.Resources.ResourceManager')

<a name='T-GHM-Windows-Factories-GetMainWindow'></a>
## GetMainWindow `type`

##### Namespace

GHM.Windows.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[IMainWindow](#T-GitHubManager-IMainWindow 'GitHubManager.IMainWindow') interface.

<a name='M-GHM-Windows-Factories-GetMainWindow-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed
once only for the [GetMainWindow](#T-GHM-Windows-Factories-GetMainWindow 'GHM.Windows.Factories.GetMainWindow') class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance
being created or before any static members are referenced.

<a name='M-GHM-Windows-Factories-GetMainWindow-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[IMainWindow](#T-GitHubManager-IMainWindow 'GitHubManager.IMainWindow') interface, and returns a reference
to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[IMainWindow](#T-GitHubManager-IMainWindow 'GitHubManager.IMainWindow') interface.

##### Parameters

This method has no parameters.

<a name='T-GHM-Windows-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

GHM.Windows.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-GHM-Windows-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-GHM-Windows-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
