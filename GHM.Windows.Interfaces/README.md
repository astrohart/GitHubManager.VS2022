<a name='assembly'></a>
# GHM.Windows.Interfaces

## Contents

- [IMainWindow](#T-GHM-Windows-Interfaces-IMainWindow 'GHM.Windows.Interfaces.IMainWindow')
  - [IsSignedIn](#P-GHM-Windows-Interfaces-IMainWindow-IsSignedIn 'GHM.Windows.Interfaces.IMainWindow.IsSignedIn')
- [Resources](#T-GHM-Windows-Interfaces-Properties-Resources 'GHM.Windows.Interfaces.Properties.Resources')
  - [Culture](#P-GHM-Windows-Interfaces-Properties-Resources-Culture 'GHM.Windows.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-GHM-Windows-Interfaces-Properties-Resources-ResourceManager 'GHM.Windows.Interfaces.Properties.Resources.ResourceManager')

<a name='T-GHM-Windows-Interfaces-IMainWindow'></a>
## IMainWindow `type`

##### Namespace

GHM.Windows.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of the main
application window.

<a name='P-GHM-Windows-Interfaces-IMainWindow-IsSignedIn'></a>
### IsSignedIn `property`

##### Summary

Gets or sets a value indicating whether the user is signed in.

##### Remarks

When this property's value is changed, the
[](#E-GitHubManager-MainWindow-SignedInChanged 'GitHubManager.MainWindow.SignedInChanged') event is raised.

<a name='T-GHM-Windows-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

GHM.Windows.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-GHM-Windows-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-GHM-Windows-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
