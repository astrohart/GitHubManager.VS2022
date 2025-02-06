using CefSharp;
using PostSharp.Patterns.Diagnostics;
using System.Diagnostics;
using System.Windows.Forms;
using xyLOGIX.Core.Extensions;
using xyLOGIX.UI.Dark.Forms;

namespace GHM.Dialogs.Helpers
{
    /// <summary> Keyboard-handler object for the CefSharp WebBrowser control. </summary>
    /// <remarks>
    /// This object handles key presses etc. on the control, such the user
    /// pressing the <c>ESC</c> key triggering a close of the containing dialog box.
    /// </remarks>
    public class KeyboardHandler : IKeyboardHandler
    {
        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the <see cref="T:GHM.Dialogs.Helpers.KeyboardHandler" /> class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance being
        /// created or before any static members are referenced.
        /// <para />
        /// We've decorated this constructor with the <c>[Log(AttributeExclude = true)]</c>
        /// attribute in order to simplify the logging output.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static KeyboardHandler() { }

        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:GHM.Dialogs.Helpers.KeyboardHandler" /> and returns a reference to
        /// it.
        /// </summary>
        [Log(AttributeExclude = true)]
        public KeyboardHandler()
            => Form = null;

        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:GitHubManager.KeyboardHandler" /> and returns a reference to it.
        /// </summary>
        /// <param name="form">
        /// (Required.) Reference to an instance of an object that
        /// implements the <see cref="T:xyLOGIX.UI.Dark.Forms.IDarkForm" /> interface.
        /// </param>
        [Log(AttributeExclude = true)]
        public KeyboardHandler([NotLogged] IDarkForm form)
            => Form = form;

        /// <summary>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:xyLOGIX.UI.Dark.Forms.IDarkForm" /> interface.
        /// </summary>
        private IDarkForm Form { [DebuggerStepThrough] get; }

        /// <summary>
        /// Called after the renderer and JavaScript in the page has had a chance
        /// to handle the event. Return true if the keyboard event was handled or false
        /// otherwise.
        /// </summary>
        /// <param name="chromiumWebBrowser">the ChromiumWebBrowser control</param>
        /// <param name="browser">The browser instance.</param>
        /// <param name="type">Whether this was a key up/down/raw/etc...</param>
        /// <param name="windowsKeyCode">
        /// The Windows key code for the key event. This
        /// value is used by the DOM specification. Sometimes it comes directly from the
        /// event (i.e. on Windows) and sometimes it's determined using a mapping function.
        /// See WebCore/platform/chromium/KeyboardCodes.h for the list of values.
        /// </param>
        /// <param name="nativeKeyCode">
        /// The native key code. On Windows this appears to be
        /// in the format of WM_KEYDOWN/WM_KEYUP/etc... lParam data.
        /// </param>
        /// <param name="modifiers">
        /// What other modifier keys are currently down:
        /// Shift/Control/Alt/OS X Command/etc...
        /// </param>
        /// <param name="isSystemKey">
        /// Indicates whether the event is considered a "system
        /// key" event (see http://msdn.microsoft.com/en-us/library/ms646286(VS.85).aspx
        /// for details).
        /// </param>
        /// <returns>Return true if the keyboard event was handled or false otherwise.</returns>
        [Log(AttributeExclude = true)]
        public bool OnKeyEvent(
            [NotLogged] IWebBrowser chromiumWebBrowser,
            [NotLogged] IBrowser browser,
            [NotLogged] KeyType type,
            [NotLogged] int windowsKeyCode,
            [NotLogged] int nativeKeyCode,
            [NotLogged] CefEventFlags modifiers,
            [NotLogged] bool isSystemKey
        )
        {
            if (Form == null)
                return false;

            if (type != KeyType.RawKeyDown)
                return false;

            // check for modifiers
            var mod = (int)modifiers;
            if (mod.IsBitmaskOn((int)CefEventFlags.ControlDown) ||
                mod.IsBitmaskOn((int)CefEventFlags.ShiftDown) ||
                mod.IsBitmaskOn((int)CefEventFlags.AltDown))
                return false;

            if (KeyChars.ESCAPE != windowsKeyCode)
                return false;

            if (Form.InvokeRequired)
                Form.BeginInvoke(
                    new MethodInvoker(Form.Close), new object[] { }
                );
            else
                Form.Close();

            return true;
        }

        /// <summary>
        /// Called before a keyboard event is sent to the renderer. Return true if the
        /// event was handled or false otherwise. If the event will be handled in
        /// <see
        ///     cref="M:CefSharp.IKeyboardHandler.OnKeyEvent(CefSharp.IWebBrowser,CefSharp.IBrowser,CefSharp.KeyType,System.Int32,System.Int32,CefSharp.CefEventFlags,System.Boolean)" />
        /// as a keyboard shortcut set isKeyboardShortcut to true and return false.
        /// </summary>
        /// <param name="chromiumWebBrowser">the ChromiumWebBrowser control</param>
        /// <param name="browser">The browser instance.</param>
        /// <param name="type">Whether this was a key up/down/raw/etc...</param>
        /// <param name="windowsKeyCode">
        /// The Windows key code for the key event. This
        /// value is used by the DOM specification. Sometimes it comes directly from the
        /// event (i.e. on Windows) and sometimes it's determined using a mapping function.
        /// See WebCore/platform/chromium/KeyboardCodes.h for the list of values.
        /// </param>
        /// <param name="nativeKeyCode">
        /// The native key code. On Windows this appears to be
        /// in the format of WM_KEYDOWN/WM_KEYUP/etc... lParam data.
        /// </param>
        /// <param name="modifiers">
        /// What other modifier keys are currently down:
        /// Shift/Control/Alt/OS X Command/etc...
        /// </param>
        /// <param name="isSystemKey">
        /// Indicates whether the event is considered a "system
        /// key" event (see http://msdn.microsoft.com/en-us/library/ms646286(VS.85).aspx
        /// for details).
        /// </param>
        /// <param name="isKeyboardShortcut">
        /// See the summary for an explanation of when to
        /// set this to true.
        /// </param>
        /// <returns>Returns true if the event was handled or false otherwise.</returns>
        public bool OnPreKeyEvent(
            IWebBrowser chromiumWebBrowser,
            IBrowser browser,
            KeyType type,
            int windowsKeyCode,
            int nativeKeyCode,
            CefEventFlags modifiers,
            bool isSystemKey,
            ref bool isKeyboardShortcut
        )
            => false;
    }
}