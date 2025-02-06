<a name='assembly'></a>
# GHM.Dialogs.Interfaces

## Contents

- [ILoginDialogBox](#T-GHM-Dialogs-Interfaces-ILoginDialogBox 'GHM.Dialogs.Interfaces.ILoginDialogBox')
  - [GitHubLoginInfo](#P-GHM-Dialogs-Interfaces-ILoginDialogBox-GitHubLoginInfo 'GHM.Dialogs.Interfaces.ILoginDialogBox.GitHubLoginInfo')
- [IOptionsDialogBox](#T-GHM-Dialogs-Interfaces-IOptionsDialogBox 'GHM.Dialogs.Interfaces.IOptionsDialogBox')
  - [CurrentConfig](#P-GHM-Dialogs-Interfaces-IOptionsDialogBox-CurrentConfig 'GHM.Dialogs.Interfaces.IOptionsDialogBox.CurrentConfig')
- [Resources](#T-GHM-Dialogs-Interfaces-Properties-Resources 'GHM.Dialogs.Interfaces.Properties.Resources')
  - [Culture](#P-GHM-Dialogs-Interfaces-Properties-Resources-Culture 'GHM.Dialogs.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-GHM-Dialogs-Interfaces-Properties-Resources-ResourceManager 'GHM.Dialogs.Interfaces.Properties.Resources.ResourceManager')

<a name='T-GHM-Dialogs-Interfaces-ILoginDialogBox'></a>
## ILoginDialogBox `type`

##### Namespace

GHM.Dialogs.Interfaces

##### Summary

Defines the publicly-exposed events, methods and properties of a dialog box
that is used to log in to GitHub.

<a name='P-GHM-Dialogs-Interfaces-ILoginDialogBox-GitHubLoginInfo'></a>
### GitHubLoginInfo `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IGitHubLoginInfo](#T-xyLOGIX-OAuth-GitHub-Models-Interfaces-IGitHubLoginInfo 'xyLOGIX.OAuth.GitHub.Models.Interfaces.IGitHubLoginInfo')
interface that plays the role
of an object that contains important login information.

<a name='T-GHM-Dialogs-Interfaces-IOptionsDialogBox'></a>
## IOptionsDialogBox `type`

##### Namespace

GHM.Dialogs.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of an object that
represents the Options dialog box.

<a name='P-GHM-Dialogs-Interfaces-IOptionsDialogBox-CurrentConfig'></a>
### CurrentConfig `property`

##### Summary

Gets or sets a reference to an instance of an object that implements
the [IGitHubManagerConfig](#T-GHM-Config-Interfaces-IGitHubManagerConfig 'GHM.Config.Interfaces.IGitHubManagerConfig') interface that
serves as the config for the application.

<a name='T-GHM-Dialogs-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

GHM.Dialogs.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-GHM-Dialogs-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-GHM-Dialogs-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
