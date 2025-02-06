<a name='assembly'></a>
# GHM.Windows.Presenters

## Contents

- [MainWindowPresenter](#T-GHM-Windows-Presenters-MainWindowPresenter 'GHM.Windows.Presenters.MainWindowPresenter')
  - [#ctor()](#M-GHM-Windows-Presenters-MainWindowPresenter-#ctor 'GHM.Windows.Presenters.MainWindowPresenter.#ctor')
  - [#ctor(view)](#M-GHM-Windows-Presenters-MainWindowPresenter-#ctor-GHM-Windows-Interfaces-IMainWindow- 'GHM.Windows.Presenters.MainWindowPresenter.#ctor(GHM.Windows.Interfaces.IMainWindow)')
  - [View](#F-GHM-Windows-Presenters-MainWindowPresenter-View 'GHM.Windows.Presenters.MainWindowPresenter.View')
  - [CurrentConfig](#P-GHM-Windows-Presenters-MainWindowPresenter-CurrentConfig 'GHM.Windows.Presenters.MainWindowPresenter.CurrentConfig')
  - [GitHubManagerConfigProvider](#P-GHM-Windows-Presenters-MainWindowPresenter-GitHubManagerConfigProvider 'GHM.Windows.Presenters.MainWindowPresenter.GitHubManagerConfigProvider')
  - [Session](#P-GHM-Windows-Presenters-MainWindowPresenter-Session 'GHM.Windows.Presenters.MainWindowPresenter.Session')
  - [#cctor()](#M-GHM-Windows-Presenters-MainWindowPresenter-#cctor 'GHM.Windows.Presenters.MainWindowPresenter.#cctor')
  - [ConfigureOptions()](#M-GHM-Windows-Presenters-MainWindowPresenter-ConfigureOptions 'GHM.Windows.Presenters.MainWindowPresenter.ConfigureOptions')
  - [GetRepos()](#M-GHM-Windows-Presenters-MainWindowPresenter-GetRepos 'GHM.Windows.Presenters.MainWindowPresenter.GetRepos')
- [Resources](#T-GHM-Windows-Presenters-Properties-Resources 'GHM.Windows.Presenters.Properties.Resources')
  - [Culture](#P-GHM-Windows-Presenters-Properties-Resources-Culture 'GHM.Windows.Presenters.Properties.Resources.Culture')
  - [ResourceManager](#P-GHM-Windows-Presenters-Properties-Resources-ResourceManager 'GHM.Windows.Presenters.Properties.Resources.ResourceManager')

<a name='T-GHM-Windows-Presenters-MainWindowPresenter'></a>
## MainWindowPresenter `type`

##### Namespace

GHM.Windows.Presenters

##### Summary

Presenter object that defines the behaviors of the main application
window.

<a name='M-GHM-Windows-Presenters-MainWindowPresenter-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[MainWindowPresenter](#T-GHM-Windows-Presenters-MainWindowPresenter 'GHM.Windows.Presenters.MainWindowPresenter') and returns a
reference to
it.

##### Parameters

This constructor has no parameters.

<a name='M-GHM-Windows-Presenters-MainWindowPresenter-#ctor-GHM-Windows-Interfaces-IMainWindow-'></a>
### #ctor(view) `constructor`

##### Summary

Constructs a new instance of
[MainWindowPresenter](#T-GitHubManager-MainWindowPresenter 'GitHubManager.MainWindowPresenter') and returns a reference to
it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| view | [GHM.Windows.Interfaces.IMainWindow](#T-GHM-Windows-Interfaces-IMainWindow 'GHM.Windows.Interfaces.IMainWindow') | (Required.) Reference to an instance of an object that
implements the [IMainWindow](#T-GitHubManager-IMainWindow 'GitHubManager.IMainWindow') interface that plays
the role of the main application window. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required
parameter, `view`, is passed a `null` value. |

<a name='F-GHM-Windows-Presenters-MainWindowPresenter-View'></a>
### View `constants`

##### Summary

Reference to an instance of an object that implements the
[IMainWindow](#T-GitHubManager-IMainWindow 'GitHubManager.IMainWindow') interface.

##### Remarks

This object serves as the View for this Presenter.

<a name='P-GHM-Windows-Presenters-MainWindowPresenter-CurrentConfig'></a>
### CurrentConfig `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IGitHubManagerConfig](#T-GHM-Config-Interfaces-IGitHubManagerConfig 'GHM.Config.Interfaces.IGitHubManagerConfig') interface.

<a name='P-GHM-Windows-Presenters-MainWindowPresenter-GitHubManagerConfigProvider'></a>
### GitHubManagerConfigProvider `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IGitHubManagerConfigProvider](#T-GHM-Config-Providers-Interfaces-IGitHubManagerConfigProvider 'GHM.Config.Providers.Interfaces.IGitHubManagerConfigProvider') interface.

<a name='P-GHM-Windows-Presenters-MainWindowPresenter-Session'></a>
### Session `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IGitHubSession](#T-xyLOGIX-OAuth-GitHub-Interfaces-IGitHubSession 'xyLOGIX.OAuth.GitHub.Interfaces.IGitHubSession') interface.

<a name='M-GHM-Windows-Presenters-MainWindowPresenter-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the [MainWindowPresenter](#T-GHM-Windows-Presenters-MainWindowPresenter 'GHM.Windows.Presenters.MainWindowPresenter') class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance being
created or before any static members are referenced.



We've decorated this constructor with the `[Log(AttributeExclude = true)]`
attribute in order to simplify the logging output.

<a name='M-GHM-Windows-Presenters-MainWindowPresenter-ConfigureOptions'></a>
### ConfigureOptions() `method`

##### Summary

Shows the user a dialog that allows the user to set the options that
change the program's behavior.

##### Parameters

This method has no parameters.

##### Remarks

The options are persisted to and from the config.

<a name='M-GHM-Windows-Presenters-MainWindowPresenter-GetRepos'></a>
### GetRepos() `method`

##### Summary

Gets all the user's repositories.

##### Returns

Collection of objects, each of which implements the
[IRepo](#T-xyLOGIX-OAuth-GitHub-Models-Interfaces-IRepo 'xyLOGIX.OAuth.GitHub.Models.Interfaces.IRepo') interface,
respectively, that represents the requested data set.



The empty collection is returned if either the information could not be
obtained or if a different error occurred.

##### Parameters

This method has no parameters.

<a name='T-GHM-Windows-Presenters-Properties-Resources'></a>
## Resources `type`

##### Namespace

GHM.Windows.Presenters.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-GHM-Windows-Presenters-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-GHM-Windows-Presenters-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
