<a name='assembly'></a>
# GHM.Windows.Presenters.Factories

## Contents

- [MakeNewMainWindowPresenter](#T-GHM-Windows-Presenters-Factories-MakeNewMainWindowPresenter 'GHM.Windows.Presenters.Factories.MakeNewMainWindowPresenter')
  - [#cctor()](#M-GHM-Windows-Presenters-Factories-MakeNewMainWindowPresenter-#cctor 'GHM.Windows.Presenters.Factories.MakeNewMainWindowPresenter.#cctor')
  - [ForView(view)](#M-GHM-Windows-Presenters-Factories-MakeNewMainWindowPresenter-ForView-GHM-Windows-Interfaces-IMainWindow- 'GHM.Windows.Presenters.Factories.MakeNewMainWindowPresenter.ForView(GHM.Windows.Interfaces.IMainWindow)')
- [Resources](#T-GHM-Windows-Presenters-Factories-Properties-Resources 'GHM.Windows.Presenters.Factories.Properties.Resources')
  - [Culture](#P-GHM-Windows-Presenters-Factories-Properties-Resources-Culture 'GHM.Windows.Presenters.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-GHM-Windows-Presenters-Factories-Properties-Resources-ResourceManager 'GHM.Windows.Presenters.Factories.Properties.Resources.ResourceManager')

<a name='T-GHM-Windows-Presenters-Factories-MakeNewMainWindowPresenter'></a>
## MakeNewMainWindowPresenter `type`

##### Namespace

GHM.Windows.Presenters.Factories

##### Summary

Creates new instances of objects that implement the
[IMainWindowPresenter](#T-GHM-Windows-Presenters-Interfaces-IMainWindowPresenter 'GHM.Windows.Presenters.Interfaces.IMainWindowPresenter')
interface, and returns references to them.

<a name='M-GHM-Windows-Presenters-Factories-MakeNewMainWindowPresenter-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed
once only for the
[MakeNewMainWindowPresenter](#T-GHM-Windows-Presenters-Factories-MakeNewMainWindowPresenter 'GHM.Windows.Presenters.Factories.MakeNewMainWindowPresenter')
class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance
being created or before any static members are referenced.

<a name='M-GHM-Windows-Presenters-Factories-MakeNewMainWindowPresenter-ForView-GHM-Windows-Interfaces-IMainWindow-'></a>
### ForView(view) `method`

##### Summary

Creates a new instance of an object that implements the
[IMainWindowPresenter](#T-GHM-Windows-Presenters-Interfaces-IMainWindowPresenter 'GHM.Windows.Presenters.Interfaces.IMainWindowPresenter')
interface and returns a reference to it.

##### Returns

Reference to an instance of an object that implements the
[IMainWindowPresenter](#T-GHM-Windows-Presenters-Interfaces-IMainWindowPresenter 'GHM.Windows.Presenters.Interfaces.IMainWindowPresenter')
interface.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| view | [GHM.Windows.Interfaces.IMainWindow](#T-GHM-Windows-Interfaces-IMainWindow 'GHM.Windows.Interfaces.IMainWindow') | (Required.) Reference to an instance of an object that implements the
[IMainWindow](#T-GHM-Windows-Interfaces-IMainWindow 'GHM.Windows.Interfaces.IMainWindow') interface that represents
the main application window. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required
parameter, `view`, is passed a `null` value. |

<a name='T-GHM-Windows-Presenters-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

GHM.Windows.Presenters.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-GHM-Windows-Presenters-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-GHM-Windows-Presenters-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
