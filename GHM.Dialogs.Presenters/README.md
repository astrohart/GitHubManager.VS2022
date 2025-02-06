<a name='assembly'></a>
# GHM.Dialogs.Presenters

## Contents

- [LoginDialogBoxPresenter](#T-GHM-Dialogs-Presenters-LoginDialogBoxPresenter 'GHM.Dialogs.Presenters.LoginDialogBoxPresenter')
  - [#ctor()](#M-GHM-Dialogs-Presenters-LoginDialogBoxPresenter-#ctor 'GHM.Dialogs.Presenters.LoginDialogBoxPresenter.#ctor')
  - [#ctor(view)](#M-GHM-Dialogs-Presenters-LoginDialogBoxPresenter-#ctor-GHM-Dialogs-Interfaces-ILoginDialogBox- 'GHM.Dialogs.Presenters.LoginDialogBoxPresenter.#ctor(GHM.Dialogs.Interfaces.ILoginDialogBox)')
  - [AddressHistoryList](#P-GHM-Dialogs-Presenters-LoginDialogBoxPresenter-AddressHistoryList 'GHM.Dialogs.Presenters.LoginDialogBoxPresenter.AddressHistoryList')
  - [Session](#P-GHM-Dialogs-Presenters-LoginDialogBoxPresenter-Session 'GHM.Dialogs.Presenters.LoginDialogBoxPresenter.Session')
  - [View](#P-GHM-Dialogs-Presenters-LoginDialogBoxPresenter-View 'GHM.Dialogs.Presenters.LoginDialogBoxPresenter.View')
  - [#cctor()](#M-GHM-Dialogs-Presenters-LoginDialogBoxPresenter-#cctor 'GHM.Dialogs.Presenters.LoginDialogBoxPresenter.#cctor')
  - [CommonConstruct()](#M-GHM-Dialogs-Presenters-LoginDialogBoxPresenter-CommonConstruct 'GHM.Dialogs.Presenters.LoginDialogBoxPresenter.CommonConstruct')
  - [SaveAddressHistoryList()](#M-GHM-Dialogs-Presenters-LoginDialogBoxPresenter-SaveAddressHistoryList 'GHM.Dialogs.Presenters.LoginDialogBoxPresenter.SaveAddressHistoryList')
- [OptionsDialogBoxPresenter](#T-GHM-Dialogs-Presenters-OptionsDialogBoxPresenter 'GHM.Dialogs.Presenters.OptionsDialogBoxPresenter')
  - [#ctor()](#M-GHM-Dialogs-Presenters-OptionsDialogBoxPresenter-#ctor 'GHM.Dialogs.Presenters.OptionsDialogBoxPresenter.#ctor')
  - [#ctor(view)](#M-GHM-Dialogs-Presenters-OptionsDialogBoxPresenter-#ctor-GHM-Dialogs-Interfaces-IOptionsDialogBox- 'GHM.Dialogs.Presenters.OptionsDialogBoxPresenter.#ctor(GHM.Dialogs.Interfaces.IOptionsDialogBox)')
  - [View](#F-GHM-Dialogs-Presenters-OptionsDialogBoxPresenter-View 'GHM.Dialogs.Presenters.OptionsDialogBoxPresenter.View')
  - [IsModified](#P-GHM-Dialogs-Presenters-OptionsDialogBoxPresenter-IsModified 'GHM.Dialogs.Presenters.OptionsDialogBoxPresenter.IsModified')
- [Resources](#T-GHM-Dialogs-Presenters-Properties-Resources 'GHM.Dialogs.Presenters.Properties.Resources')
  - [Culture](#P-GHM-Dialogs-Presenters-Properties-Resources-Culture 'GHM.Dialogs.Presenters.Properties.Resources.Culture')
  - [ResourceManager](#P-GHM-Dialogs-Presenters-Properties-Resources-ResourceManager 'GHM.Dialogs.Presenters.Properties.Resources.ResourceManager')

<a name='T-GHM-Dialogs-Presenters-LoginDialogBoxPresenter'></a>
## LoginDialogBoxPresenter `type`

##### Namespace

GHM.Dialogs.Presenters

##### Summary

This is the Presenter for the Login dialog box.

<a name='M-GHM-Dialogs-Presenters-LoginDialogBoxPresenter-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[LoginDialogBoxPresenter](#T-GHM-Dialogs-Presenters-LoginDialogBoxPresenter 'GHM.Dialogs.Presenters.LoginDialogBoxPresenter') and returns a
reference
to it.

##### Parameters

This constructor has no parameters.

<a name='M-GHM-Dialogs-Presenters-LoginDialogBoxPresenter-#ctor-GHM-Dialogs-Interfaces-ILoginDialogBox-'></a>
### #ctor(view) `constructor`

##### Summary

Constructs a new instance of
[LoginDialogBoxPresenter](#T-GHM-Dialogs-Presenters-LoginDialogBoxPresenter 'GHM.Dialogs.Presenters.LoginDialogBoxPresenter') and returns a
reference
to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| view | [GHM.Dialogs.Interfaces.ILoginDialogBox](#T-GHM-Dialogs-Interfaces-ILoginDialogBox 'GHM.Dialogs.Interfaces.ILoginDialogBox') | (Required.) Reference to an instance of an object that implements the
[ILoginDialogBox](#T-GHM-Dialogs-Interfaces-ILoginDialogBox 'GHM.Dialogs.Interfaces.ILoginDialogBox') interface that
represents the view. |

<a name='P-GHM-Dialogs-Presenters-LoginDialogBoxPresenter-AddressHistoryList'></a>
### AddressHistoryList `property`

##### Summary

Gets or sets a reference to a collection of strings that is the
history of navigated addresses.

<a name='P-GHM-Dialogs-Presenters-LoginDialogBoxPresenter-Session'></a>
### Session `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IGitHubSession](#T-xyLOGIX-OAuth-GitHub-Interfaces-IGitHubSession 'xyLOGIX.OAuth.GitHub.Interfaces.IGitHubSession') interface.

<a name='P-GHM-Dialogs-Presenters-LoginDialogBoxPresenter-View'></a>
### View `property`

##### Summary

Reference to an instance of an object that implements the
[ILoginDialogBox](#T-GHM-Dialogs-Interfaces-ILoginDialogBox 'GHM.Dialogs.Interfaces.ILoginDialogBox') interface.

<a name='M-GHM-Dialogs-Presenters-LoginDialogBoxPresenter-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the [LoginDialogBoxPresenter](#T-GHM-Dialogs-Presenters-LoginDialogBoxPresenter 'GHM.Dialogs.Presenters.LoginDialogBoxPresenter') class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance being
created or before any static members are referenced.



We've decorated this constructor with the `[Log(AttributeExclude = true)]`
attribute in order to simplify the logging output.

<a name='M-GHM-Dialogs-Presenters-LoginDialogBoxPresenter-CommonConstruct'></a>
### CommonConstruct() `method`

##### Summary

Provides common initialization for all of this object's constructor
overloads.

##### Parameters

This method has no parameters.

<a name='M-GHM-Dialogs-Presenters-LoginDialogBoxPresenter-SaveAddressHistoryList'></a>
### SaveAddressHistoryList() `method`

##### Summary

Saves the address history to a file in the user's Local AppData
directory.

##### Parameters

This method has no parameters.

<a name='T-GHM-Dialogs-Presenters-OptionsDialogBoxPresenter'></a>
## OptionsDialogBoxPresenter `type`

##### Namespace

GHM.Dialogs.Presenters

##### Summary

Serves as the Presenter for the Options dialog box.

<a name='M-GHM-Dialogs-Presenters-OptionsDialogBoxPresenter-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[OptionsDialogBoxPresenter](#T-GHM-Dialogs-Presenters-OptionsDialogBoxPresenter 'GHM.Dialogs.Presenters.OptionsDialogBoxPresenter') and returns a
reference to it.

##### Parameters

This constructor has no parameters.

<a name='M-GHM-Dialogs-Presenters-OptionsDialogBoxPresenter-#ctor-GHM-Dialogs-Interfaces-IOptionsDialogBox-'></a>
### #ctor(view) `constructor`

##### Summary

Constructs a new instance of
[OptionsDialogBoxPresenter](#T-GitHubManager-OptionsDialogBoxPresenter 'GitHubManager.OptionsDialogBoxPresenter') and returns a
reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| view | [GHM.Dialogs.Interfaces.IOptionsDialogBox](#T-GHM-Dialogs-Interfaces-IOptionsDialogBox 'GHM.Dialogs.Interfaces.IOptionsDialogBox') | (Required.) Reference to an instance of an object that
implements the [IOptionsDialogBox](#T-GitHubManager-IOptionsDialogBox 'GitHubManager.IOptionsDialogBox') interface.



This object plays the role of the View that displays this Presenter's data. |

<a name='F-GHM-Dialogs-Presenters-OptionsDialogBoxPresenter-View'></a>
### View `constants`

##### Summary

Reference to an instance of an object that implements the
[IOptionsDialogBox](#T-GitHubManager-IOptionsDialogBox 'GitHubManager.IOptionsDialogBox') interface.

##### Remarks

This object serves as the View that this Presenter is associated with.

<a name='P-GHM-Dialogs-Presenters-OptionsDialogBoxPresenter-IsModified'></a>
### IsModified `property`

##### Summary

Gets or sets a value that indicates whether any of the settings on
the property sheet have been modified.

<a name='T-GHM-Dialogs-Presenters-Properties-Resources'></a>
## Resources `type`

##### Namespace

GHM.Dialogs.Presenters.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-GHM-Dialogs-Presenters-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-GHM-Dialogs-Presenters-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
