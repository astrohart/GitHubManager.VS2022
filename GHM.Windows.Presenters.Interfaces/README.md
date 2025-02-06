<a name='assembly'></a>
# GHM.Windows.Presenters.Interfaces

## Contents

- [IMainWindowPresenter](#T-GHM-Windows-Presenters-Interfaces-IMainWindowPresenter 'GHM.Windows.Presenters.Interfaces.IMainWindowPresenter')
  - [ConfigureOptions()](#M-GHM-Windows-Presenters-Interfaces-IMainWindowPresenter-ConfigureOptions 'GHM.Windows.Presenters.Interfaces.IMainWindowPresenter.ConfigureOptions')
  - [GetRepos()](#M-GHM-Windows-Presenters-Interfaces-IMainWindowPresenter-GetRepos 'GHM.Windows.Presenters.Interfaces.IMainWindowPresenter.GetRepos')
- [Resources](#T-GHM-Windows-Presenters-Interfaces-Properties-Resources 'GHM.Windows.Presenters.Interfaces.Properties.Resources')
  - [Culture](#P-GHM-Windows-Presenters-Interfaces-Properties-Resources-Culture 'GHM.Windows.Presenters.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-GHM-Windows-Presenters-Interfaces-Properties-Resources-ResourceManager 'GHM.Windows.Presenters.Interfaces.Properties.Resources.ResourceManager')

<a name='T-GHM-Windows-Presenters-Interfaces-IMainWindowPresenter'></a>
## IMainWindowPresenter `type`

##### Namespace

GHM.Windows.Presenters.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of the
`Presenter` object for the main application window.

<a name='M-GHM-Windows-Presenters-Interfaces-IMainWindowPresenter-ConfigureOptions'></a>
### ConfigureOptions() `method`

##### Summary

Shows the user a dialog that allows the user to set the options that
change the program's behavior.

##### Parameters

This method has no parameters.

##### Remarks

The options are persisted to and from the config.

<a name='M-GHM-Windows-Presenters-Interfaces-IMainWindowPresenter-GetRepos'></a>
### GetRepos() `method`

##### Summary

Gets all the user's repositories.

##### Returns

Collection of objects, each of which implements the
[IRemoteRepo](#T-xyLOGIX-OAuth-GitHub-Models-Interfaces-IRemoteRepo 'xyLOGIX.OAuth.GitHub.Models.Interfaces.IRemoteRepo') interface,
respectively, that represents the requested data set.



The empty collection is returned if either the information could not be
obtained or if a different error occurred.

##### Parameters

This method has no parameters.

<a name='T-GHM-Windows-Presenters-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

GHM.Windows.Presenters.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-GHM-Windows-Presenters-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-GHM-Windows-Presenters-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
