<a name='assembly'></a>
# GHM.Dialogs.Factories

## Contents

- [MakeNewLoginDialogBox](#T-GHM-Dialogs-Factories-MakeNewLoginDialogBox 'GHM.Dialogs.Factories.MakeNewLoginDialogBox')
  - [#cctor()](#M-GHM-Dialogs-Factories-MakeNewLoginDialogBox-#cctor 'GHM.Dialogs.Factories.MakeNewLoginDialogBox.#cctor')
  - [FromScratch()](#M-GHM-Dialogs-Factories-MakeNewLoginDialogBox-FromScratch 'GHM.Dialogs.Factories.MakeNewLoginDialogBox.FromScratch')
- [MakeNewOptionsDialogBox](#T-GHM-Dialogs-Factories-MakeNewOptionsDialogBox 'GHM.Dialogs.Factories.MakeNewOptionsDialogBox')
  - [#cctor()](#M-GHM-Dialogs-Factories-MakeNewOptionsDialogBox-#cctor 'GHM.Dialogs.Factories.MakeNewOptionsDialogBox.#cctor')
  - [FromScratch()](#M-GHM-Dialogs-Factories-MakeNewOptionsDialogBox-FromScratch 'GHM.Dialogs.Factories.MakeNewOptionsDialogBox.FromScratch')
  - [HavingConfiguration(self,config)](#M-GHM-Dialogs-Factories-MakeNewOptionsDialogBox-HavingConfiguration-GHM-Dialogs-Interfaces-IOptionsDialogBox,GHM-Config-Interfaces-IGitHubManagerConfig- 'GHM.Dialogs.Factories.MakeNewOptionsDialogBox.HavingConfiguration(GHM.Dialogs.Interfaces.IOptionsDialogBox,GHM.Config.Interfaces.IGitHubManagerConfig)')
- [Resources](#T-GHM-Dialogs-Factories-Properties-Resources 'GHM.Dialogs.Factories.Properties.Resources')
  - [Culture](#P-GHM-Dialogs-Factories-Properties-Resources-Culture 'GHM.Dialogs.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-GHM-Dialogs-Factories-Properties-Resources-ResourceManager 'GHM.Dialogs.Factories.Properties.Resources.ResourceManager')

<a name='T-GHM-Dialogs-Factories-MakeNewLoginDialogBox'></a>
## MakeNewLoginDialogBox `type`

##### Namespace

GHM.Dialogs.Factories

##### Summary

Creates new instances of objects that implement the
[ILoginDialogBox](#T-GHM-Dialogs-Interfaces-ILoginDialogBox 'GHM.Dialogs.Interfaces.ILoginDialogBox') interface, and returns
references to them.

<a name='M-GHM-Dialogs-Factories-MakeNewLoginDialogBox-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the [MakeNewLoginDialogBox](#T-GHM-Dialogs-Factories-MakeNewLoginDialogBox 'GHM.Dialogs.Factories.MakeNewLoginDialogBox') class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance being
created or before any static members are referenced.



We've decorated this constructor with the `[Log(AttributeExclude = true)]`
attribute in order to simplify the logging output.

<a name='M-GHM-Dialogs-Factories-MakeNewLoginDialogBox-FromScratch'></a>
### FromScratch() `method`

##### Summary

Creates a new instance of an object that implements the
[ILoginDialogBox](#T-GHM-Dialogs-Interfaces-ILoginDialogBox 'GHM.Dialogs.Interfaces.ILoginDialogBox') interface and returns a
reference to it.

##### Returns

Reference to an instance of an object that implements the
[ILoginDialogBox](#T-GHM-Dialogs-Interfaces-ILoginDialogBox 'GHM.Dialogs.Interfaces.ILoginDialogBox') interface.

##### Parameters

This method has no parameters.

<a name='T-GHM-Dialogs-Factories-MakeNewOptionsDialogBox'></a>
## MakeNewOptionsDialogBox `type`

##### Namespace

GHM.Dialogs.Factories

##### Summary

Creates new instances of objects that implement the
[IOptionsDialog](#T-GitHubManager-IOptionsDialog 'GitHubManager.IOptionsDialog') interface, and returns references
to them.

<a name='M-GHM-Dialogs-Factories-MakeNewOptionsDialogBox-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the [MakeNewOptionsDialogBox](#T-GHM-Dialogs-Factories-MakeNewOptionsDialogBox 'GHM.Dialogs.Factories.MakeNewOptionsDialogBox') class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance being
created or before any static members are referenced.



We've decorated this constructor with the `[Log(AttributeExclude = true)]`
attribute in order to simplify the logging output.

<a name='M-GHM-Dialogs-Factories-MakeNewOptionsDialogBox-FromScratch'></a>
### FromScratch() `method`

##### Summary

Creates a new instance of an object that implements the
[IOptionsDialog](#T-GitHubManager-IOptionsDialog 'GitHubManager.IOptionsDialog') interface and returns a reference
to it.

##### Returns

Reference to an instance of an object that implements the
[IOptionsDialog](#T-GitHubManager-IOptionsDialog 'GitHubManager.IOptionsDialog') interface.

##### Parameters

This method has no parameters.

<a name='M-GHM-Dialogs-Factories-MakeNewOptionsDialogBox-HavingConfiguration-GHM-Dialogs-Interfaces-IOptionsDialogBox,GHM-Config-Interfaces-IGitHubManagerConfig-'></a>
### HavingConfiguration(self,config) `method`

##### Summary

Builder extension method that initializes the
[Config](#P-GitHubManager-IOptionsDialogBox-Config 'GitHubManager.IOptionsDialogBox.Config') property.

##### Returns

Reference to the same instance of the object that called this method,
for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [GHM.Dialogs.Interfaces.IOptionsDialogBox](#T-GHM-Dialogs-Interfaces-IOptionsDialogBox 'GHM.Dialogs.Interfaces.IOptionsDialogBox') | (Required.) Reference to an instance of an object that
implements the [IOptionsDialogBox](#T-GitHubManager-IOptionsDialogBox 'GitHubManager.IOptionsDialogBox') interface. |
| config | [GHM.Config.Interfaces.IGitHubManagerConfig](#T-GHM-Config-Interfaces-IGitHubManagerConfig 'GHM.Config.Interfaces.IGitHubManagerConfig') | (Required.) Reference to an instance of an object
that implements the [IGitHubManagerConfig](#T-GHM-Config-Interfaces-IGitHubManagerConfig 'GHM.Config.Interfaces.IGitHubManagerConfig')
interface. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required
parameter, `self`, is passed a `null` value. |

<a name='T-GHM-Dialogs-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

GHM.Dialogs.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-GHM-Dialogs-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-GHM-Dialogs-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
