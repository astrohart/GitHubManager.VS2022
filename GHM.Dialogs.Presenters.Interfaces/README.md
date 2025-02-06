<a name='assembly'></a>
# GHM.Dialogs.Presenters.Interfaces

## Contents

- [ILoginDialogBoxPresenter](#T-GHM-Dialogs-Presenters-Interfaces-ILoginDialogBoxPresenter 'GHM.Dialogs.Presenters.Interfaces.ILoginDialogBoxPresenter')
  - [AddressHistoryList](#P-GHM-Dialogs-Presenters-Interfaces-ILoginDialogBoxPresenter-AddressHistoryList 'GHM.Dialogs.Presenters.Interfaces.ILoginDialogBoxPresenter.AddressHistoryList')
  - [Session](#P-GHM-Dialogs-Presenters-Interfaces-ILoginDialogBoxPresenter-Session 'GHM.Dialogs.Presenters.Interfaces.ILoginDialogBoxPresenter.Session')
  - [SaveAddressHistoryList()](#M-GHM-Dialogs-Presenters-Interfaces-ILoginDialogBoxPresenter-SaveAddressHistoryList 'GHM.Dialogs.Presenters.Interfaces.ILoginDialogBoxPresenter.SaveAddressHistoryList')
- [IOptionsDialogBoxPresenter](#T-GHM-Dialogs-Presenters-Interfaces-IOptionsDialogBoxPresenter 'GHM.Dialogs.Presenters.Interfaces.IOptionsDialogBoxPresenter')
  - [IsModified](#P-GHM-Dialogs-Presenters-Interfaces-IOptionsDialogBoxPresenter-IsModified 'GHM.Dialogs.Presenters.Interfaces.IOptionsDialogBoxPresenter.IsModified')
- [Resources](#T-GHM-Dialogs-Presenters-Interfaces-Properties-Resources 'GHM.Dialogs.Presenters.Interfaces.Properties.Resources')
  - [Culture](#P-GHM-Dialogs-Presenters-Interfaces-Properties-Resources-Culture 'GHM.Dialogs.Presenters.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-GHM-Dialogs-Presenters-Interfaces-Properties-Resources-ResourceManager 'GHM.Dialogs.Presenters.Interfaces.Properties.Resources.ResourceManager')

<a name='T-GHM-Dialogs-Presenters-Interfaces-ILoginDialogBoxPresenter'></a>
## ILoginDialogBoxPresenter `type`

##### Namespace

GHM.Dialogs.Presenters.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of the Presenter
of the Login dialog box.

<a name='P-GHM-Dialogs-Presenters-Interfaces-ILoginDialogBoxPresenter-AddressHistoryList'></a>
### AddressHistoryList `property`

##### Summary

Gets or sets a reference to a collection of strings that is the
history of navigated addresses.

<a name='P-GHM-Dialogs-Presenters-Interfaces-ILoginDialogBoxPresenter-Session'></a>
### Session `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IGitHubSession](#T-xyLOGIX-OAuth-GitHub-Interfaces-IGitHubSession 'xyLOGIX.OAuth.GitHub.Interfaces.IGitHubSession') interface.

<a name='M-GHM-Dialogs-Presenters-Interfaces-ILoginDialogBoxPresenter-SaveAddressHistoryList'></a>
### SaveAddressHistoryList() `method`

##### Summary

Saves the address history to a file in the user's Local AppData
directory.

##### Parameters

This method has no parameters.

<a name='T-GHM-Dialogs-Presenters-Interfaces-IOptionsDialogBoxPresenter'></a>
## IOptionsDialogBoxPresenter `type`

##### Namespace

GHM.Dialogs.Presenters.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of a Presenter
object for the Options dialog box.

<a name='P-GHM-Dialogs-Presenters-Interfaces-IOptionsDialogBoxPresenter-IsModified'></a>
### IsModified `property`

##### Summary

Gets or sets a value that indicates whether any of the settings on
the property sheet have been modified.

<a name='T-GHM-Dialogs-Presenters-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

GHM.Dialogs.Presenters.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-GHM-Dialogs-Presenters-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-GHM-Dialogs-Presenters-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
