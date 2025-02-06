<a name='assembly'></a>
# GHM.Dialogs

## Contents

- [LoginDialogBox](#T-GHM-Dialogs-LoginDialogBox 'GHM.Dialogs.LoginDialogBox')
  - [#ctor()](#M-GHM-Dialogs-LoginDialogBox-#ctor 'GHM.Dialogs.LoginDialogBox.#ctor')
  - [Presenter](#F-GHM-Dialogs-LoginDialogBox-Presenter 'GHM.Dialogs.LoginDialogBox.Presenter')
  - [components](#F-GHM-Dialogs-LoginDialogBox-components 'GHM.Dialogs.LoginDialogBox.components')
  - [GitHubLoginInfo](#P-GHM-Dialogs-LoginDialogBox-GitHubLoginInfo 'GHM.Dialogs.LoginDialogBox.GitHubLoginInfo')
  - [#cctor()](#M-GHM-Dialogs-LoginDialogBox-#cctor 'GHM.Dialogs.LoginDialogBox.#cctor')
  - [Dispose(disposing)](#M-GHM-Dialogs-LoginDialogBox-Dispose-System-Boolean- 'GHM.Dialogs.LoginDialogBox.Dispose(System.Boolean)')
  - [InitializeComponent()](#M-GHM-Dialogs-LoginDialogBox-InitializeComponent 'GHM.Dialogs.LoginDialogBox.InitializeComponent')
  - [InitializeWebBrowser()](#M-GHM-Dialogs-LoginDialogBox-InitializeWebBrowser 'GHM.Dialogs.LoginDialogBox.InitializeWebBrowser')
  - [OnGitHubLoginInfoReceived(e)](#M-GHM-Dialogs-LoginDialogBox-OnGitHubLoginInfoReceived-xyLOGIX-OAuth-GitHub-Events-GitHubLoginInfoReceivedEventArgs- 'GHM.Dialogs.LoginDialogBox.OnGitHubLoginInfoReceived(xyLOGIX.OAuth.GitHub.Events.GitHubLoginInfoReceivedEventArgs)')
  - [OnShown(e)](#M-GHM-Dialogs-LoginDialogBox-OnShown-System-EventArgs- 'GHM.Dialogs.LoginDialogBox.OnShown(System.EventArgs)')
  - [OnWebBrowserAddressChanged(sender,e)](#M-GHM-Dialogs-LoginDialogBox-OnWebBrowserAddressChanged-System-Object,CefSharp-AddressChangedEventArgs- 'GHM.Dialogs.LoginDialogBox.OnWebBrowserAddressChanged(System.Object,CefSharp.AddressChangedEventArgs)')
  - [OnWebBrowserInitializedChanged(sender,e)](#M-GHM-Dialogs-LoginDialogBox-OnWebBrowserInitializedChanged-System-Object,System-EventArgs- 'GHM.Dialogs.LoginDialogBox.OnWebBrowserInitializedChanged(System.Object,System.EventArgs)')
  - [OnWebBrowserLoadingStateChanged(sender,e)](#M-GHM-Dialogs-LoginDialogBox-OnWebBrowserLoadingStateChanged-System-Object,CefSharp-LoadingStateChangedEventArgs- 'GHM.Dialogs.LoginDialogBox.OnWebBrowserLoadingStateChanged(System.Object,CefSharp.LoadingStateChangedEventArgs)')
  - [SetFocusToWebBrowser()](#M-GHM-Dialogs-LoginDialogBox-SetFocusToWebBrowser 'GHM.Dialogs.LoginDialogBox.SetFocusToWebBrowser')
- [OptionsDialogBox](#T-GHM-Dialogs-OptionsDialogBox 'GHM.Dialogs.OptionsDialogBox')
  - [#ctor()](#M-GHM-Dialogs-OptionsDialogBox-#ctor 'GHM.Dialogs.OptionsDialogBox.#ctor')
  - [Presenter](#F-GHM-Dialogs-OptionsDialogBox-Presenter 'GHM.Dialogs.OptionsDialogBox.Presenter')
  - [components](#F-GHM-Dialogs-OptionsDialogBox-components 'GHM.Dialogs.OptionsDialogBox.components')
  - [CurrentConfig](#P-GHM-Dialogs-OptionsDialogBox-CurrentConfig 'GHM.Dialogs.OptionsDialogBox.CurrentConfig')
  - [Dispose(disposing)](#M-GHM-Dialogs-OptionsDialogBox-Dispose-System-Boolean- 'GHM.Dialogs.OptionsDialogBox.Dispose(System.Boolean)')
  - [InitializeComponent()](#M-GHM-Dialogs-OptionsDialogBox-InitializeComponent 'GHM.Dialogs.OptionsDialogBox.InitializeComponent')
  - [OnApplied()](#M-GHM-Dialogs-OptionsDialogBox-OnApplied 'GHM.Dialogs.OptionsDialogBox.OnApplied')
  - [OnCheckedChangedLoginOnStartupCheckBox(sender,e)](#M-GHM-Dialogs-OptionsDialogBox-OnCheckedChangedLoginOnStartupCheckBox-System-Object,System-EventArgs- 'GHM.Dialogs.OptionsDialogBox.OnCheckedChangedLoginOnStartupCheckBox(System.Object,System.EventArgs)')
  - [OnLoad(e)](#M-GHM-Dialogs-OptionsDialogBox-OnLoad-System-EventArgs- 'GHM.Dialogs.OptionsDialogBox.OnLoad(System.EventArgs)')
  - [UpdateData(bSaveAndValidate)](#M-GHM-Dialogs-OptionsDialogBox-UpdateData-System-Boolean- 'GHM.Dialogs.OptionsDialogBox.UpdateData(System.Boolean)')
- [Resources](#T-GHM-Dialogs-Properties-Resources 'GHM.Dialogs.Properties.Resources')
  - [Culture](#P-GHM-Dialogs-Properties-Resources-Culture 'GHM.Dialogs.Properties.Resources.Culture')
  - [ResourceManager](#P-GHM-Dialogs-Properties-Resources-ResourceManager 'GHM.Dialogs.Properties.Resources.ResourceManager')

<a name='T-GHM-Dialogs-LoginDialogBox'></a>
## LoginDialogBox `type`

##### Namespace

GHM.Dialogs

##### Summary

Dialog box that helps the user log in to GitHub.

<a name='M-GHM-Dialogs-LoginDialogBox-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[LoginDialogBox](#T-GHM-Dialogs-LoginDialogBox 'GHM.Dialogs.LoginDialogBox') and returns a reference to it.

##### Parameters

This constructor has no parameters.

<a name='F-GHM-Dialogs-LoginDialogBox-Presenter'></a>
### Presenter `constants`

##### Summary

Reference to an instance of an object that implements the
[ILoginDialogBoxPresenter](#T-GHM-Dialogs-Presenters-Interfaces-ILoginDialogBoxPresenter 'GHM.Dialogs.Presenters.Interfaces.ILoginDialogBoxPresenter')
interface.

<a name='F-GHM-Dialogs-LoginDialogBox-components'></a>
### components `constants`

##### Summary

Required designer variable.

<a name='P-GHM-Dialogs-LoginDialogBox-GitHubLoginInfo'></a>
### GitHubLoginInfo `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IGitHubLoginInfo](#T-xyLOGIX-OAuth-GitHub-Models-Interfaces-IGitHubLoginInfo 'xyLOGIX.OAuth.GitHub.Models.Interfaces.IGitHubLoginInfo')
interface that plays the role
of an object that contains important login information.

<a name='M-GHM-Dialogs-LoginDialogBox-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the [LoginDialogBox](#T-GHM-Dialogs-LoginDialogBox 'GHM.Dialogs.LoginDialogBox') class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance being
created or before any static members are referenced.



We've decorated this constructor with the `[Log(AttributeExclude = true)]`
attribute in order to simplify the logging output.

<a name='M-GHM-Dialogs-LoginDialogBox-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Clean up any resources being used.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if managed resources should be disposed; otherwise, false. |

<a name='M-GHM-Dialogs-LoginDialogBox-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Required method for Designer support - do not modify the contents of this method with the code editor.

##### Parameters

This method has no parameters.

<a name='M-GHM-Dialogs-LoginDialogBox-InitializeWebBrowser'></a>
### InitializeWebBrowser() `method`

##### Summary

Sets up the properties and event handlers of the internal Web browser
control.

##### Parameters

This method has no parameters.

<a name='M-GHM-Dialogs-LoginDialogBox-OnGitHubLoginInfoReceived-xyLOGIX-OAuth-GitHub-Events-GitHubLoginInfoReceivedEventArgs-'></a>
### OnGitHubLoginInfoReceived(e) `method`

##### Summary

Raises the
[](#E-GitHubManager-LoginDialogBox-GitHubLoginInfoReceived 'GitHubManager.LoginDialogBox.GitHubLoginInfoReceived') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [xyLOGIX.OAuth.GitHub.Events.GitHubLoginInfoReceivedEventArgs](#T-xyLOGIX-OAuth-GitHub-Events-GitHubLoginInfoReceivedEventArgs 'xyLOGIX.OAuth.GitHub.Events.GitHubLoginInfoReceivedEventArgs') | A
[GitHubLoginInfoReceivedEventArgs](#T-GitHubManager-GitHubLoginInfoReceivedEventArgs 'GitHubManager.GitHubLoginInfoReceivedEventArgs') that contains
the event data. |

<a name='M-GHM-Dialogs-LoginDialogBox-OnShown-System-EventArgs-'></a>
### OnShown(e) `method`

##### Summary

Raises the [](#E-System-Windows-Forms-Form-Shown 'System.Windows.Forms.Form.Shown') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | A [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event
data. |

<a name='M-GHM-Dialogs-LoginDialogBox-OnWebBrowserAddressChanged-System-Object,CefSharp-AddressChangedEventArgs-'></a>
### OnWebBrowserAddressChanged(sender,e) `method`

##### Summary

Handles the
[](#E-CefSharp-WinForms-ChromiumWebBrowser-AddressChanged 'CefSharp.WinForms.ChromiumWebBrowser.AddressChanged') event
raised by the CefSharp Web Browser control.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the
event. |
| e | [CefSharp.AddressChangedEventArgs](#T-CefSharp-AddressChangedEventArgs 'CefSharp.AddressChangedEventArgs') | A [AddressChangedEventArgs](#T-CefSharp-AddressChangedEventArgs 'CefSharp.AddressChangedEventArgs') that
contains the event data. |

##### Remarks

This method responds by checking which address the Web browser is
currently pointing at.



Depending on the particular address that the Web browser is pointing to, the
appropriate action is taken, such as closing the dialog box once the user's
portion of the authorization is finished.

<a name='M-GHM-Dialogs-LoginDialogBox-OnWebBrowserInitializedChanged-System-Object,System-EventArgs-'></a>
### OnWebBrowserInitializedChanged(sender,e) `method`

##### Summary

Handles the
[](#E-CefSharp-WinForms-Host-ChromiumHostControlBase-IsBrowserInitializedChanged 'CefSharp.WinForms.Host.ChromiumHostControlBase.IsBrowserInitializedChanged')
event raised by the CefSharp Web browser control that is hosted in this dialog
box.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the
event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | A [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event
data. |

##### Remarks

The method responds by setting the focus to the internal CefSharp Web
Browser control once the initialization of the control is completed (such as
loading a page).

<a name='M-GHM-Dialogs-LoginDialogBox-OnWebBrowserLoadingStateChanged-System-Object,CefSharp-LoadingStateChangedEventArgs-'></a>
### OnWebBrowserLoadingStateChanged(sender,e) `method`

##### Summary

Handles the
[](#E-CefSharp-WinForms-ChromiumWebBrowser-LoadingStateChanged 'CefSharp.WinForms.ChromiumWebBrowser.LoadingStateChanged') event
raised by the internal CefSharp Web browser control that is hosted by this
dialog box.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the
event. |
| e | [CefSharp.LoadingStateChangedEventArgs](#T-CefSharp-LoadingStateChangedEventArgs 'CefSharp.LoadingStateChangedEventArgs') | A [LoadingStateChangedEventArgs](#T-CefSharp-LoadingStateChangedEventArgs 'CefSharp.LoadingStateChangedEventArgs') that
contains the event data. |

##### Remarks

This method detects whether the user's portion of the authorization
flow is completed.



If so, then the dialog box is automatically dismissed with the
[OK](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.DialogResult.OK 'System.Windows.Forms.DialogResult.OK') value for the
[DialogResult](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Form.DialogResult 'System.Windows.Forms.Form.DialogResult') property set.

<a name='M-GHM-Dialogs-LoginDialogBox-SetFocusToWebBrowser'></a>
### SetFocusToWebBrowser() `method`

##### Summary

Sets the focus to the internal CefSharp Web browser control that is
hosted by this dialog, and does so in a thread-safe manner.

##### Parameters

This method has no parameters.

<a name='T-GHM-Dialogs-OptionsDialogBox'></a>
## OptionsDialogBox `type`

##### Namespace

GHM.Dialogs

##### Summary

Dialog box to allow the user to select from among options that alter
the behavior of the application.

<a name='M-GHM-Dialogs-OptionsDialogBox-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[OptionsDialogBox](#T-GHM-Dialogs-OptionsDialogBox 'GHM.Dialogs.OptionsDialogBox') and returns a reference to it.

##### Parameters

This constructor has no parameters.

<a name='F-GHM-Dialogs-OptionsDialogBox-Presenter'></a>
### Presenter `constants`

##### Summary

Reference to an instance of an object that implements the
[IOptionsDialogBoxPresenter](#T-GHM-Dialogs-Presenters-Interfaces-IOptionsDialogBoxPresenter 'GHM.Dialogs.Presenters.Interfaces.IOptionsDialogBoxPresenter')
interface.

##### Remarks

This object plays the role of this dialog box's Presenter.

<a name='F-GHM-Dialogs-OptionsDialogBox-components'></a>
### components `constants`

##### Summary

Required designer variable.

<a name='P-GHM-Dialogs-OptionsDialogBox-CurrentConfig'></a>
### CurrentConfig `property`

##### Summary

Gets or sets a reference to an instance of an object that implements
the [IGitHubManagerConfig](#T-GHM-Config-Interfaces-IGitHubManagerConfig 'GHM.Config.Interfaces.IGitHubManagerConfig') interface that
serves as the config for the application.

<a name='M-GHM-Dialogs-OptionsDialogBox-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Clean up any resources being used.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if managed resources should be disposed; otherwise, false. |

<a name='M-GHM-Dialogs-OptionsDialogBox-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Required method for Designer support - do not modify the contents of this method with the code editor.

##### Parameters

This method has no parameters.

<a name='M-GHM-Dialogs-OptionsDialogBox-OnApplied'></a>
### OnApplied() `method`

##### Summary

Raises the [](#E-GHM-Dialogs-OptionsDialogBox-Applied 'GHM.Dialogs.OptionsDialogBox.Applied')
event.

##### Parameters

This method has no parameters.

<a name='M-GHM-Dialogs-OptionsDialogBox-OnCheckedChangedLoginOnStartupCheckBox-System-Object,System-EventArgs-'></a>
### OnCheckedChangedLoginOnStartupCheckBox(sender,e) `method`

##### Summary

Handles the
[](#E-System-Windows-Forms-CheckBox-CheckedChanged 'System.Windows.Forms.CheckBox.CheckedChanged') event raised by
the checkbox when the user clicks it to
change its value..

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the
event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | A [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event
data. |

##### Remarks

The method responds by alerting the property sheet code that the data
in the property sheet has been modified.

<a name='M-GHM-Dialogs-OptionsDialogBox-OnLoad-System-EventArgs-'></a>
### OnLoad(e) `method`

##### Summary

Raises the [](#E-System-Windows-Forms-Form-Load 'System.Windows.Forms.Form.Load') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | An [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event
data. |

<a name='M-GHM-Dialogs-OptionsDialogBox-UpdateData-System-Boolean-'></a>
### UpdateData(bSaveAndValidate) `method`

##### Summary

Moves data from this dialog's controls to the config object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bSaveAndValidate | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Required.) A [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean')
that specifies whether to save information from the screen into data variables.
`false` to load data to the screen. |

<a name='T-GHM-Dialogs-Properties-Resources'></a>
## Resources `type`

##### Namespace

GHM.Dialogs.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-GHM-Dialogs-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-GHM-Dialogs-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
