<a name='assembly'></a>
# GHM.Config.Factories

## Contents

- [MakeNewGitHubManagerConfig](#T-GHM-Config-Factories-MakeNewGitHubManagerConfig 'GHM.Config.Factories.MakeNewGitHubManagerConfig')
  - [#cctor()](#M-GHM-Config-Factories-MakeNewGitHubManagerConfig-#cctor 'GHM.Config.Factories.MakeNewGitHubManagerConfig.#cctor')
  - [FromScratch()](#M-GHM-Config-Factories-MakeNewGitHubManagerConfig-FromScratch 'GHM.Config.Factories.MakeNewGitHubManagerConfig.FromScratch')
  - [ThatHasLoginOnStartupSetTo(self,loginOnStartup)](#M-GHM-Config-Factories-MakeNewGitHubManagerConfig-ThatHasLoginOnStartupSetTo-GHM-Config-Interfaces-IGitHubManagerConfig,System-Boolean- 'GHM.Config.Factories.MakeNewGitHubManagerConfig.ThatHasLoginOnStartupSetTo(GHM.Config.Interfaces.IGitHubManagerConfig,System.Boolean)')
- [Resources](#T-GHM-Config-Factories-Properties-Resources 'GHM.Config.Factories.Properties.Resources')
  - [Culture](#P-GHM-Config-Factories-Properties-Resources-Culture 'GHM.Config.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-GHM-Config-Factories-Properties-Resources-ResourceManager 'GHM.Config.Factories.Properties.Resources.ResourceManager')

<a name='T-GHM-Config-Factories-MakeNewGitHubManagerConfig'></a>
## MakeNewGitHubManagerConfig `type`

##### Namespace

GHM.Config.Factories

##### Summary

Creates new instances of objects that implement the
[IGitHubManagerConfig](#T-GHM-Config-Interfaces-IGitHubManagerConfig 'GHM.Config.Interfaces.IGitHubManagerConfig') interface, and
returns references to them.

<a name='M-GHM-Config-Factories-MakeNewGitHubManagerConfig-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the [MakeNewGitHubManagerConfig](#T-GHM-Config-Factories-MakeNewGitHubManagerConfig 'GHM.Config.Factories.MakeNewGitHubManagerConfig') class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance being
created or before any static members are referenced.



We've decorated this constructor with the `[Log(AttributeExclude = true)]`
attribute in order to simplify the logging output.

<a name='M-GHM-Config-Factories-MakeNewGitHubManagerConfig-FromScratch'></a>
### FromScratch() `method`

##### Summary

Creates a new instance of an object that implements the
[IGitHubManagerConfig](#T-GHM-Config-Interfaces-IGitHubManagerConfig 'GHM.Config.Interfaces.IGitHubManagerConfig') interface and
returns a reference to it.

##### Returns

Reference to an instance of an object that implements the
[IGitHubManagerConfig](#T-GHM-Config-Interfaces-IGitHubManagerConfig 'GHM.Config.Interfaces.IGitHubManagerConfig') interface.

##### Parameters

This method has no parameters.

<a name='M-GHM-Config-Factories-MakeNewGitHubManagerConfig-ThatHasLoginOnStartupSetTo-GHM-Config-Interfaces-IGitHubManagerConfig,System-Boolean-'></a>
### ThatHasLoginOnStartupSetTo(self,loginOnStartup) `method`

##### Summary

Builder extension method that initializes the
[LoginOnStartup](#P-GitHubManager-IGitHubManagerConfig-LoginOnStartup 'GitHubManager.IGitHubManagerConfig.LoginOnStartup')
property.

##### Returns

Reference to the same instance of the object that called this method,
for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [GHM.Config.Interfaces.IGitHubManagerConfig](#T-GHM-Config-Interfaces-IGitHubManagerConfig 'GHM.Config.Interfaces.IGitHubManagerConfig') | (Required.) Reference to an instance of an object that
implements the [IGitHubManagerConfig](#T-GHM-Config-Interfaces-IGitHubManagerConfig 'GHM.Config.Interfaces.IGitHubManagerConfig')
interface. |
| loginOnStartup | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Required.) A [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean')
value that determines whether the application shows the user the Login form or
attempts to log in to GitHub upon startup. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required
parameter, `self`, is passed a `null` value. |

<a name='T-GHM-Config-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

GHM.Config.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-GHM-Config-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-GHM-Config-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
