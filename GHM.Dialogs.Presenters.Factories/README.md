<a name='assembly'></a>
# GHM.Dialogs.Presenters.Factories

## Contents

- [MakeNewLoginDialogBoxPresenter](#T-GHM-Dialogs-Presenters-Factories-MakeNewLoginDialogBoxPresenter 'GHM.Dialogs.Presenters.Factories.MakeNewLoginDialogBoxPresenter')
  - [#cctor()](#M-GHM-Dialogs-Presenters-Factories-MakeNewLoginDialogBoxPresenter-#cctor 'GHM.Dialogs.Presenters.Factories.MakeNewLoginDialogBoxPresenter.#cctor')
  - [ForView()](#M-GHM-Dialogs-Presenters-Factories-MakeNewLoginDialogBoxPresenter-ForView-GHM-Dialogs-Interfaces-ILoginDialogBox- 'GHM.Dialogs.Presenters.Factories.MakeNewLoginDialogBoxPresenter.ForView(GHM.Dialogs.Interfaces.ILoginDialogBox)')
- [MakeNewOptionsDialogBoxPresenter](#T-GHM-Dialogs-Presenters-Factories-MakeNewOptionsDialogBoxPresenter 'GHM.Dialogs.Presenters.Factories.MakeNewOptionsDialogBoxPresenter')
  - [ForView()](#M-GHM-Dialogs-Presenters-Factories-MakeNewOptionsDialogBoxPresenter-ForView-GHM-Dialogs-Interfaces-IOptionsDialogBox- 'GHM.Dialogs.Presenters.Factories.MakeNewOptionsDialogBoxPresenter.ForView(GHM.Dialogs.Interfaces.IOptionsDialogBox)')
- [Resources](#T-GHM-Dialogs-Presenters-Factories-Properties-Resources 'GHM.Dialogs.Presenters.Factories.Properties.Resources')
  - [Culture](#P-GHM-Dialogs-Presenters-Factories-Properties-Resources-Culture 'GHM.Dialogs.Presenters.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-GHM-Dialogs-Presenters-Factories-Properties-Resources-ResourceManager 'GHM.Dialogs.Presenters.Factories.Properties.Resources.ResourceManager')

<a name='T-GHM-Dialogs-Presenters-Factories-MakeNewLoginDialogBoxPresenter'></a>
## MakeNewLoginDialogBoxPresenter `type`

##### Namespace

GHM.Dialogs.Presenters.Factories

##### Summary

Creates new instances of objects that implement the
[ILoginDialogBoxPresenter](#T-GHM-Dialogs-Presenters-Interfaces-ILoginDialogBoxPresenter 'GHM.Dialogs.Presenters.Interfaces.ILoginDialogBoxPresenter')
interface, and returns references to them.

<a name='M-GHM-Dialogs-Presenters-Factories-MakeNewLoginDialogBoxPresenter-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed
once only for the
[MakeNewLoginDialogBoxPresenter](#T-GHM-Dialogs-Presenters-Factories-MakeNewLoginDialogBoxPresenter 'GHM.Dialogs.Presenters.Factories.MakeNewLoginDialogBoxPresenter')
class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance
being created or before any static members are referenced.

<a name='M-GHM-Dialogs-Presenters-Factories-MakeNewLoginDialogBoxPresenter-ForView-GHM-Dialogs-Interfaces-ILoginDialogBox-'></a>
### ForView() `method`

##### Summary

Creates a new instance of an object that implements the
[ILoginDialogBoxPresenter](#T-GHM-Dialogs-Presenters-Interfaces-ILoginDialogBoxPresenter 'GHM.Dialogs.Presenters.Interfaces.ILoginDialogBoxPresenter')
interface and returns a reference to it.

##### Returns

Reference to an instance of an object that implements the
[ILoginDialogBoxPresenter](#T-GHM-Dialogs-Presenters-Interfaces-ILoginDialogBoxPresenter 'GHM.Dialogs.Presenters.Interfaces.ILoginDialogBoxPresenter')
interface.

##### Parameters

This method has no parameters.

<a name='T-GHM-Dialogs-Presenters-Factories-MakeNewOptionsDialogBoxPresenter'></a>
## MakeNewOptionsDialogBoxPresenter `type`

##### Namespace

GHM.Dialogs.Presenters.Factories

##### Summary

Creates new instances of objects that implement the
[IOptionsDialogBoxPresenter](#T-GHM-Dialogs-Presenters-Interfaces-IOptionsDialogBoxPresenter 'GHM.Dialogs.Presenters.Interfaces.IOptionsDialogBoxPresenter') interface, and
returns references to them.

<a name='M-GHM-Dialogs-Presenters-Factories-MakeNewOptionsDialogBoxPresenter-ForView-GHM-Dialogs-Interfaces-IOptionsDialogBox-'></a>
### ForView() `method`

##### Summary

Creates a new instance of an object that implements the
[IOptionsDialogBoxPresenter](#T-GHM-Dialogs-Presenters-Interfaces-IOptionsDialogBoxPresenter 'GHM.Dialogs.Presenters.Interfaces.IOptionsDialogBoxPresenter') interface and returns
a reference to it.

##### Returns

Reference to an instance of an object that implements the
[IOptionsDialogBoxPresenter](#T-GHM-Dialogs-Presenters-Interfaces-IOptionsDialogBoxPresenter 'GHM.Dialogs.Presenters.Interfaces.IOptionsDialogBoxPresenter') interface.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required
parameter, `view`, is passed a `null` value. |

<a name='T-GHM-Dialogs-Presenters-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

GHM.Dialogs.Presenters.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-GHM-Dialogs-Presenters-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-GHM-Dialogs-Presenters-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
