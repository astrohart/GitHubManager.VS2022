<a name='assembly'></a>
# GHM.Dialogs.Helpers

## Contents

- [KeyChars](#T-GHM-Dialogs-Helpers-KeyChars 'GHM.Dialogs.Helpers.KeyChars')
  - [ESCAPE](#F-GHM-Dialogs-Helpers-KeyChars-ESCAPE 'GHM.Dialogs.Helpers.KeyChars.ESCAPE')
- [KeyboardHandler](#T-GHM-Dialogs-Helpers-KeyboardHandler 'GHM.Dialogs.Helpers.KeyboardHandler')
  - [#ctor()](#M-GHM-Dialogs-Helpers-KeyboardHandler-#ctor 'GHM.Dialogs.Helpers.KeyboardHandler.#ctor')
  - [#ctor(form)](#M-GHM-Dialogs-Helpers-KeyboardHandler-#ctor-xyLOGIX-UI-Dark-Forms-IDarkForm- 'GHM.Dialogs.Helpers.KeyboardHandler.#ctor(xyLOGIX.UI.Dark.Forms.IDarkForm)')
  - [Form](#P-GHM-Dialogs-Helpers-KeyboardHandler-Form 'GHM.Dialogs.Helpers.KeyboardHandler.Form')
  - [#cctor()](#M-GHM-Dialogs-Helpers-KeyboardHandler-#cctor 'GHM.Dialogs.Helpers.KeyboardHandler.#cctor')
  - [OnKeyEvent(chromiumWebBrowser,browser,type,windowsKeyCode,nativeKeyCode,modifiers,isSystemKey)](#M-GHM-Dialogs-Helpers-KeyboardHandler-OnKeyEvent-CefSharp-IWebBrowser,CefSharp-IBrowser,CefSharp-KeyType,System-Int32,System-Int32,CefSharp-CefEventFlags,System-Boolean- 'GHM.Dialogs.Helpers.KeyboardHandler.OnKeyEvent(CefSharp.IWebBrowser,CefSharp.IBrowser,CefSharp.KeyType,System.Int32,System.Int32,CefSharp.CefEventFlags,System.Boolean)')
  - [OnPreKeyEvent(chromiumWebBrowser,browser,type,windowsKeyCode,nativeKeyCode,modifiers,isSystemKey,isKeyboardShortcut)](#M-GHM-Dialogs-Helpers-KeyboardHandler-OnPreKeyEvent-CefSharp-IWebBrowser,CefSharp-IBrowser,CefSharp-KeyType,System-Int32,System-Int32,CefSharp-CefEventFlags,System-Boolean,System-Boolean@- 'GHM.Dialogs.Helpers.KeyboardHandler.OnPreKeyEvent(CefSharp.IWebBrowser,CefSharp.IBrowser,CefSharp.KeyType,System.Int32,System.Int32,CefSharp.CefEventFlags,System.Boolean,System.Boolean@)')
- [Resources](#T-GHM-Dialogs-Helpers-Properties-Resources 'GHM.Dialogs.Helpers.Properties.Resources')
  - [Culture](#P-GHM-Dialogs-Helpers-Properties-Resources-Culture 'GHM.Dialogs.Helpers.Properties.Resources.Culture')
  - [ResourceManager](#P-GHM-Dialogs-Helpers-Properties-Resources-ResourceManager 'GHM.Dialogs.Helpers.Properties.Resources.ResourceManager')

<a name='T-GHM-Dialogs-Helpers-KeyChars'></a>
## KeyChars `type`

##### Namespace

GHM.Dialogs.Helpers

##### Summary

ASCII character codes for keyboard keys.

<a name='F-GHM-Dialogs-Helpers-KeyChars-ESCAPE'></a>
### ESCAPE `constants`

##### Summary

ASCII code for the ESC key on the keyboard.

<a name='T-GHM-Dialogs-Helpers-KeyboardHandler'></a>
## KeyboardHandler `type`

##### Namespace

GHM.Dialogs.Helpers

##### Summary

Keyboard-handler object for the CefSharp WebBrowser control.

##### Remarks

This object handles key presses etc. on the control, such the user
pressing the `ESC` key triggering a close of the containing dialog box.

<a name='M-GHM-Dialogs-Helpers-KeyboardHandler-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[KeyboardHandler](#T-GHM-Dialogs-Helpers-KeyboardHandler 'GHM.Dialogs.Helpers.KeyboardHandler') and returns a reference to
it.

##### Parameters

This constructor has no parameters.

<a name='M-GHM-Dialogs-Helpers-KeyboardHandler-#ctor-xyLOGIX-UI-Dark-Forms-IDarkForm-'></a>
### #ctor(form) `constructor`

##### Summary

Constructs a new instance of
[KeyboardHandler](#T-GitHubManager-KeyboardHandler 'GitHubManager.KeyboardHandler') and returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| form | [xyLOGIX.UI.Dark.Forms.IDarkForm](#T-xyLOGIX-UI-Dark-Forms-IDarkForm 'xyLOGIX.UI.Dark.Forms.IDarkForm') | (Required.) Reference to an instance of an object that
implements the [IDarkForm](#T-xyLOGIX-UI-Dark-Forms-IDarkForm 'xyLOGIX.UI.Dark.Forms.IDarkForm') interface. |

<a name='P-GHM-Dialogs-Helpers-KeyboardHandler-Form'></a>
### Form `property`

##### Summary

Reference to an instance of an object that implements the
[IDarkForm](#T-xyLOGIX-UI-Dark-Forms-IDarkForm 'xyLOGIX.UI.Dark.Forms.IDarkForm') interface.

<a name='M-GHM-Dialogs-Helpers-KeyboardHandler-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the [KeyboardHandler](#T-GHM-Dialogs-Helpers-KeyboardHandler 'GHM.Dialogs.Helpers.KeyboardHandler') class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance being
created or before any static members are referenced.



We've decorated this constructor with the `[Log(AttributeExclude = true)]`
attribute in order to simplify the logging output.

<a name='M-GHM-Dialogs-Helpers-KeyboardHandler-OnKeyEvent-CefSharp-IWebBrowser,CefSharp-IBrowser,CefSharp-KeyType,System-Int32,System-Int32,CefSharp-CefEventFlags,System-Boolean-'></a>
### OnKeyEvent(chromiumWebBrowser,browser,type,windowsKeyCode,nativeKeyCode,modifiers,isSystemKey) `method`

##### Summary

Called after the renderer and JavaScript in the page has had a chance
to handle the event. Return true if the keyboard event was handled or false
otherwise.

##### Returns

Return true if the keyboard event was handled or false otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| chromiumWebBrowser | [CefSharp.IWebBrowser](#T-CefSharp-IWebBrowser 'CefSharp.IWebBrowser') | the ChromiumWebBrowser control |
| browser | [CefSharp.IBrowser](#T-CefSharp-IBrowser 'CefSharp.IBrowser') | The browser instance. |
| type | [CefSharp.KeyType](#T-CefSharp-KeyType 'CefSharp.KeyType') | Whether this was a key up/down/raw/etc... |
| windowsKeyCode | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The Windows key code for the key event. This
value is used by the DOM specification. Sometimes it comes directly from the
event (i.e. on Windows) and sometimes it's determined using a mapping function.
See WebCore/platform/chromium/KeyboardCodes.h for the list of values. |
| nativeKeyCode | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The native key code. On Windows this appears to be
in the format of WM_KEYDOWN/WM_KEYUP/etc... lParam data. |
| modifiers | [CefSharp.CefEventFlags](#T-CefSharp-CefEventFlags 'CefSharp.CefEventFlags') | What other modifier keys are currently down:
Shift/Control/Alt/OS X Command/etc... |
| isSystemKey | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Indicates whether the event is considered a "system
key" event (see http://msdn.microsoft.com/en-us/library/ms646286(VS.85).aspx
for details). |

<a name='M-GHM-Dialogs-Helpers-KeyboardHandler-OnPreKeyEvent-CefSharp-IWebBrowser,CefSharp-IBrowser,CefSharp-KeyType,System-Int32,System-Int32,CefSharp-CefEventFlags,System-Boolean,System-Boolean@-'></a>
### OnPreKeyEvent(chromiumWebBrowser,browser,type,windowsKeyCode,nativeKeyCode,modifiers,isSystemKey,isKeyboardShortcut) `method`

##### Summary

Called before a keyboard event is sent to the renderer. Return true if the
event was handled or false otherwise. If the event will be handled in
[OnKeyEvent](#M-CefSharp-IKeyboardHandler-OnKeyEvent-CefSharp-IWebBrowser,CefSharp-IBrowser,CefSharp-KeyType,System-Int32,System-Int32,CefSharp-CefEventFlags,System-Boolean- 'CefSharp.IKeyboardHandler.OnKeyEvent(CefSharp.IWebBrowser,CefSharp.IBrowser,CefSharp.KeyType,System.Int32,System.Int32,CefSharp.CefEventFlags,System.Boolean)')
as a keyboard shortcut set isKeyboardShortcut to true and return false.

##### Returns

Returns true if the event was handled or false otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| chromiumWebBrowser | [CefSharp.IWebBrowser](#T-CefSharp-IWebBrowser 'CefSharp.IWebBrowser') | the ChromiumWebBrowser control |
| browser | [CefSharp.IBrowser](#T-CefSharp-IBrowser 'CefSharp.IBrowser') | The browser instance. |
| type | [CefSharp.KeyType](#T-CefSharp-KeyType 'CefSharp.KeyType') | Whether this was a key up/down/raw/etc... |
| windowsKeyCode | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The Windows key code for the key event. This
value is used by the DOM specification. Sometimes it comes directly from the
event (i.e. on Windows) and sometimes it's determined using a mapping function.
See WebCore/platform/chromium/KeyboardCodes.h for the list of values. |
| nativeKeyCode | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The native key code. On Windows this appears to be
in the format of WM_KEYDOWN/WM_KEYUP/etc... lParam data. |
| modifiers | [CefSharp.CefEventFlags](#T-CefSharp-CefEventFlags 'CefSharp.CefEventFlags') | What other modifier keys are currently down:
Shift/Control/Alt/OS X Command/etc... |
| isSystemKey | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Indicates whether the event is considered a "system
key" event (see http://msdn.microsoft.com/en-us/library/ms646286(VS.85).aspx
for details). |
| isKeyboardShortcut | [System.Boolean@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean@ 'System.Boolean@') | See the summary for an explanation of when to
set this to true. |

<a name='T-GHM-Dialogs-Helpers-Properties-Resources'></a>
## Resources `type`

##### Namespace

GHM.Dialogs.Helpers.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-GHM-Dialogs-Helpers-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-GHM-Dialogs-Helpers-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
