<a name='assembly'></a>
# GHM.Windows

## Contents

- [MainWindow](#T-GHM-Windows-MainWindow 'GHM.Windows.MainWindow')
  - [#ctor()](#M-GHM-Windows-MainWindow-#ctor 'GHM.Windows.MainWindow.#ctor')
  - [Presenter](#F-GHM-Windows-MainWindow-Presenter 'GHM.Windows.MainWindow.Presenter')
  - [_isSignedIn](#F-GHM-Windows-MainWindow-_isSignedIn 'GHM.Windows.MainWindow._isSignedIn')
  - [_loginDialogBox](#F-GHM-Windows-MainWindow-_loginDialogBox 'GHM.Windows.MainWindow._loginDialogBox')
  - [_progressDialog](#F-GHM-Windows-MainWindow-_progressDialog 'GHM.Windows.MainWindow._progressDialog')
  - [components](#F-GHM-Windows-MainWindow-components 'GHM.Windows.MainWindow.components')
  - [CurrentConfig](#P-GHM-Windows-MainWindow-CurrentConfig 'GHM.Windows.MainWindow.CurrentConfig')
  - [GitHubManagerConfigProvider](#P-GHM-Windows-MainWindow-GitHubManagerConfigProvider 'GHM.Windows.MainWindow.GitHubManagerConfigProvider')
  - [Instance](#P-GHM-Windows-MainWindow-Instance 'GHM.Windows.MainWindow.Instance')
  - [IsSignedIn](#P-GHM-Windows-MainWindow-IsSignedIn 'GHM.Windows.MainWindow.IsSignedIn')
  - [Session](#P-GHM-Windows-MainWindow-Session 'GHM.Windows.MainWindow.Session')
  - [#cctor()](#M-GHM-Windows-MainWindow-#cctor 'GHM.Windows.MainWindow.#cctor')
  - [CloseLoginDialogBox()](#M-GHM-Windows-MainWindow-CloseLoginDialogBox 'GHM.Windows.MainWindow.CloseLoginDialogBox')
  - [CloseProgressDialog()](#M-GHM-Windows-MainWindow-CloseProgressDialog 'GHM.Windows.MainWindow.CloseProgressDialog')
  - [Dispose(disposing)](#M-GHM-Windows-MainWindow-Dispose-System-Boolean- 'GHM.Windows.MainWindow.Dispose(System.Boolean)')
  - [InitializeComponent()](#M-GHM-Windows-MainWindow-InitializeComponent 'GHM.Windows.MainWindow.InitializeComponent')
  - [OnDropDownOpeningViewMenu(sender,e)](#M-GHM-Windows-MainWindow-OnDropDownOpeningViewMenu-System-Object,System-EventArgs- 'GHM.Windows.MainWindow.OnDropDownOpeningViewMenu(System.Object,System.EventArgs)')
  - [OnDropDownOpeningViewToolbarsMenu(sender,e)](#M-GHM-Windows-MainWindow-OnDropDownOpeningViewToolbarsMenu-System-Object,System-EventArgs- 'GHM.Windows.MainWindow.OnDropDownOpeningViewToolbarsMenu(System.Object,System.EventArgs)')
  - [OnFileExit(sender,e)](#M-GHM-Windows-MainWindow-OnFileExit-System-Object,System-EventArgs- 'GHM.Windows.MainWindow.OnFileExit(System.Object,System.EventArgs)')
  - [OnFileLogin(sender,e)](#M-GHM-Windows-MainWindow-OnFileLogin-System-Object,System-EventArgs- 'GHM.Windows.MainWindow.OnFileLogin(System.Object,System.EventArgs)')
  - [OnFileMenuDropDownOpening(sender,e)](#M-GHM-Windows-MainWindow-OnFileMenuDropDownOpening-System-Object,System-EventArgs- 'GHM.Windows.MainWindow.OnFileMenuDropDownOpening(System.Object,System.EventArgs)')
  - [OnGitHubAuthenticated(sender,e)](#M-GHM-Windows-MainWindow-OnGitHubAuthenticated-System-Object,xyLOGIX-OAuth-GitHub-Events-GitHubAuthenticatedEventArgs- 'GHM.Windows.MainWindow.OnGitHubAuthenticated(System.Object,xyLOGIX.OAuth.GitHub.Events.GitHubAuthenticatedEventArgs)')
  - [OnLoad(e)](#M-GHM-Windows-MainWindow-OnLoad-System-EventArgs- 'GHM.Windows.MainWindow.OnLoad(System.EventArgs)')
  - [OnShown(e)](#M-GHM-Windows-MainWindow-OnShown-System-EventArgs- 'GHM.Windows.MainWindow.OnShown(System.EventArgs)')
  - [OnSignedInChanged()](#M-GHM-Windows-MainWindow-OnSignedInChanged 'GHM.Windows.MainWindow.OnSignedInChanged')
  - [OnToolsOptions(sender,e)](#M-GHM-Windows-MainWindow-OnToolsOptions-System-Object,System-EventArgs- 'GHM.Windows.MainWindow.OnToolsOptions(System.Object,System.EventArgs)')
  - [OnUpdateCmdUI(sender,e)](#M-GHM-Windows-MainWindow-OnUpdateCmdUI-System-Object,System-EventArgs- 'GHM.Windows.MainWindow.OnUpdateCmdUI(System.Object,System.EventArgs)')
  - [OnViewNavigateToolbar(sender,e)](#M-GHM-Windows-MainWindow-OnViewNavigateToolbar-System-Object,System-EventArgs- 'GHM.Windows.MainWindow.OnViewNavigateToolbar(System.Object,System.EventArgs)')
  - [OnViewStatusBar(sender,e)](#M-GHM-Windows-MainWindow-OnViewStatusBar-System-Object,System-EventArgs- 'GHM.Windows.MainWindow.OnViewStatusBar(System.Object,System.EventArgs)')
- [Resources](#T-GHM-Windows-Properties-Resources 'GHM.Windows.Properties.Resources')
  - [Culture](#P-GHM-Windows-Properties-Resources-Culture 'GHM.Windows.Properties.Resources.Culture')
  - [ResourceManager](#P-GHM-Windows-Properties-Resources-ResourceManager 'GHM.Windows.Properties.Resources.ResourceManager')

<a name='T-GHM-Windows-MainWindow'></a>
## MainWindow `type`

##### Namespace

GHM.Windows

##### Summary

Main window of the application.

<a name='M-GHM-Windows-MainWindow-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this
class.

##### Parameters

This constructor has no parameters.

<a name='F-GHM-Windows-MainWindow-Presenter'></a>
### Presenter `constants`

##### Summary

Reference to an instance of an object that implements the
[IMainWindowPresenter](#T-GitHubManager-IMainWindowPresenter 'GitHubManager.IMainWindowPresenter') interface.

<a name='F-GHM-Windows-MainWindow-_isSignedIn'></a>
### _isSignedIn `constants`

##### Summary

Flag indicating whether the application is signed-in.

<a name='F-GHM-Windows-MainWindow-_loginDialogBox'></a>
### _loginDialogBox `constants`

##### Summary

Reference to an instance of an object that implements the
[ILoginDialogBox](#T-GHM-Dialogs-Interfaces-ILoginDialogBox 'GHM.Dialogs.Interfaces.ILoginDialogBox') interface.

<a name='F-GHM-Windows-MainWindow-_progressDialog'></a>
### _progressDialog `constants`

##### Summary

Reference to an instance of an object that implements the
[IMarqueeProgressDialogBox](#T-xyLOGIX-Core-Dialogs-Progress-Interfaces-IMarqueeProgressDialogBox 'xyLOGIX.Core.Dialogs.Progress.Interfaces.IMarqueeProgressDialogBox')
interface that represents the used to keep
the user entertained while a long process, having indeterminate duration, runs.

<a name='F-GHM-Windows-MainWindow-components'></a>
### components `constants`

##### Summary

Required designer variable.

<a name='P-GHM-Windows-MainWindow-CurrentConfig'></a>
### CurrentConfig `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IGitHubManagerConfig](#T-GHM-Config-Interfaces-IGitHubManagerConfig 'GHM.Config.Interfaces.IGitHubManagerConfig') interface that
represents the currently-loaded application configuration.

<a name='P-GHM-Windows-MainWindow-GitHubManagerConfigProvider'></a>
### GitHubManagerConfigProvider `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IGitHubManagerConfigProvider](#T-GHM-Config-Providers-Interfaces-IGitHubManagerConfigProvider 'GHM.Config.Providers.Interfaces.IGitHubManagerConfigProvider')
interface.

<a name='P-GHM-Windows-MainWindow-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[MainWindow](#T-GHM-Windows-MainWindow 'GHM.Windows.MainWindow').

<a name='P-GHM-Windows-MainWindow-IsSignedIn'></a>
### IsSignedIn `property`

##### Summary

Gets or sets a value indicating whether the user is signed in.

##### Remarks

When this property's value is changed, the
[](#E-GHM-Windows-MainWindow-SignedInChanged 'GHM.Windows.MainWindow.SignedInChanged') event is raised.

<a name='P-GHM-Windows-MainWindow-Session'></a>
### Session `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IGitHubSession](#T-xyLOGIX-OAuth-GitHub-Interfaces-IGitHubSession 'xyLOGIX.OAuth.GitHub.Interfaces.IGitHubSession') interface.

##### Remarks

This particular property needs to be computed on each
call.

<a name='M-GHM-Windows-MainWindow-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this
class.

##### Parameters

This method has no parameters.

<a name='M-GHM-Windows-MainWindow-CloseLoginDialogBox'></a>
### CloseLoginDialogBox() `method`

##### Summary

Closes the Login dialog box, if it is open.

##### Parameters

This method has no parameters.

<a name='M-GHM-Windows-MainWindow-CloseProgressDialog'></a>
### CloseProgressDialog() `method`

##### Summary

Closes the progress dialog box, if it is open.

##### Parameters

This method has no parameters.

<a name='M-GHM-Windows-MainWindow-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Clean up any resources being used.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if managed resources should be disposed; otherwise, false. |

<a name='M-GHM-Windows-MainWindow-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Required method for Designer support - do not modify the contents of this method with the code editor.

##### Parameters

This method has no parameters.

<a name='M-GHM-Windows-MainWindow-OnDropDownOpeningViewMenu-System-Object,System-EventArgs-'></a>
### OnDropDownOpeningViewMenu(sender,e) `method`

##### Summary

Handles the
[](#E-System-Windows-Forms-ToolStripDropDownItem-DropDownOpening 'System.Windows.Forms.ToolStripDropDownItem.DropDownOpening')
event raised by the menu..

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the
event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | A [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event
data. |

##### Remarks

This method responds by setting the Checked state of the various menu
items that tell the user whether UI/UX elements are visible (checked) or hidden
(not checked).

<a name='M-GHM-Windows-MainWindow-OnDropDownOpeningViewToolbarsMenu-System-Object,System-EventArgs-'></a>
### OnDropDownOpeningViewToolbarsMenu(sender,e) `method`

##### Summary

Handles the
[](#E-System-Windows-Forms-ToolStripDropDownItem-DropDownOpening 'System.Windows.Forms.ToolStripDropDownItem.DropDownOpening')
event raised by the submenu of the
menu..

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the
event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | A [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event
data. |

##### Remarks

This method responds by setting the Checked state of the menu items
for the various toolbars displayed in the main application window, depending on
whether they are visible (checked) or hidden (not checked)

<a name='M-GHM-Windows-MainWindow-OnFileExit-System-Object,System-EventArgs-'></a>
### OnFileExit(sender,e) `method`

##### Summary

Handles the [](#E-System-Windows-Forms-ToolStripItem-Click 'System.Windows.Forms.ToolStripItem.Click')
event raised by the menu item on the
menu..

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the
event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | A [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event
data. |

##### Remarks

This method responds by closing this window; since this window is the
main application window, this also terminates the lifecycle of the application
process.

<a name='M-GHM-Windows-MainWindow-OnFileLogin-System-Object,System-EventArgs-'></a>
### OnFileLogin(sender,e) `method`

##### Summary

Handles the [](#E-System-Windows-Forms-ToolStripItem-Click 'System.Windows.Forms.ToolStripItem.Click')
event raised by the menu item on the
menu..

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the
event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | A [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event
data. |

##### Remarks

This menu responds by showing the user the Login dialog box for
GitHub and signing the user into the account that is chosen.

<a name='M-GHM-Windows-MainWindow-OnFileMenuDropDownOpening-System-Object,System-EventArgs-'></a>
### OnFileMenuDropDownOpening(sender,e) `method`

##### Summary

Handles the
[](#E-System-Windows-Forms-ToolStripDropDownItem-DropDownOpening 'System.Windows.Forms.ToolStripDropDownItem.DropDownOpening')
event raised by the menu when it is being dropped down by
a mouse click..

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the
event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | A [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event
data. |

##### Remarks

This method responds by showing the enabled and/or disabled state of
the items on the menu to correspond with the current
state of the application.

<a name='M-GHM-Windows-MainWindow-OnGitHubAuthenticated-System-Object,xyLOGIX-OAuth-GitHub-Events-GitHubAuthenticatedEventArgs-'></a>
### OnGitHubAuthenticated(sender,e) `method`

##### Summary

Handles the
[](#E-GitHubManager-IGitHubSession-GitHubAuthenticated 'GitHubManager.IGitHubSession.GitHubAuthenticated') event raised
by the GitHub Session Object when the OAuth flow is complete.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the
event. |
| e | [xyLOGIX.OAuth.GitHub.Events.GitHubAuthenticatedEventArgs](#T-xyLOGIX-OAuth-GitHub-Events-GitHubAuthenticatedEventArgs 'xyLOGIX.OAuth.GitHub.Events.GitHubAuthenticatedEventArgs') | A [GitHubAuthenticatedEventArgs](#T-GitHubManager-GitHubAuthenticatedEventArgs 'GitHubManager.GitHubAuthenticatedEventArgs')
that contains the event data. |

##### Remarks

This method responds by initiating the process of loading repository
data into the DataGridView displayed in the middle of the window.

<a name='M-GHM-Windows-MainWindow-OnLoad-System-EventArgs-'></a>
### OnLoad(e) `method`

##### Summary

Raises the [](#E-System-Windows-Forms-Form-Load 'System.Windows.Forms.Form.Load') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | An [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event
data. |

<a name='M-GHM-Windows-MainWindow-OnShown-System-EventArgs-'></a>
### OnShown(e) `method`

##### Summary

Raises the [](#E-System-Windows-Forms-Form-Shown 'System.Windows.Forms.Form.Shown') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | A [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event
data. |

<a name='M-GHM-Windows-MainWindow-OnSignedInChanged'></a>
### OnSignedInChanged() `method`

##### Summary

Raises the [](#E-GHM-Windows-MainWindow-SignedInChanged 'GHM.Windows.MainWindow.SignedInChanged')
event.

##### Parameters

This method has no parameters.

<a name='M-GHM-Windows-MainWindow-OnToolsOptions-System-Object,System-EventArgs-'></a>
### OnToolsOptions(sender,e) `method`

##### Summary

Handles the [](#E-System-Windows-Forms-ToolStripItem-Click 'System.Windows.Forms.ToolStripItem.Click')
event raised by the menu item on the
menu.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the
event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | A [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event
data. |

##### Remarks

This method responds by instructing the Presenter to enable the user
to configure options that affect the behavior of this application.

<a name='M-GHM-Windows-MainWindow-OnUpdateCmdUI-System-Object,System-EventArgs-'></a>
### OnUpdateCmdUI(sender,e) `method`

##### Summary

Handles the [](#E-System-Windows-Forms-Application-Idle 'System.Windows.Forms.Application.Idle')
event raised by the application.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the
event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | A [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event
data. |

##### Remarks

This method responds by ensuring that the enabled/disabled state of
controls corresponds to the internal state of the application.

<a name='M-GHM-Windows-MainWindow-OnViewNavigateToolbar-System-Object,System-EventArgs-'></a>
### OnViewNavigateToolbar(sender,e) `method`

##### Summary

Handles the [](#E-System-Windows-Forms-ToolStripItem-Click 'System.Windows.Forms.ToolStripItem.Click')
event raised by the menu item on the
sub-menu of the menu..

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the
event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | A [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event
data. |

##### Remarks

This method shows or hides the toolbar.

<a name='M-GHM-Windows-MainWindow-OnViewStatusBar-System-Object,System-EventArgs-'></a>
### OnViewStatusBar(sender,e) `method`

##### Summary

Handles the [](#E-System-Windows-Forms-ToolStripItem-Click 'System.Windows.Forms.ToolStripItem.Click')
event raised by the menu item on the
menu..

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the
event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | A [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event
data. |

##### Remarks

This method shows or hides the Status Bar.

<a name='T-GHM-Windows-Properties-Resources'></a>
## Resources `type`

##### Namespace

GHM.Windows.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-GHM-Windows-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-GHM-Windows-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
