using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace GitHubManager
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of a Windows Form.
    /// </summary>
    public interface IForm : IWin32Window, IDisposable, ISynchronizeInvoke
    {
        /// <summary>
        /// Occurs when this form is first loaded into memory.
        /// </summary>
        event EventHandler Load;

        /// <summary>
        /// Occurs when this form is first shown to the user.
        /// </summary>
        event EventHandler Shown;

        /// <summary>
        /// Gets or sets a <see cref="T:System.Windows.Forms.DialogResult" /> value that
        /// indicates how the user closed this form if it was shown as a dialog box using
        /// the <see cref="M:GitHubManager.IForm.ShowDialog" /> method.
        /// </summary>
        DialogResult DialogResult { get; set; }

        /// <summary>
        /// Gets a value indicating whether this form has been disposed.
        /// </summary>
        bool IsDisposed { get; }

        /// <summary>
        /// Gets a value indicating whether this form's window handle has been created.
        /// </summary>
        bool IsHandleCreated { get; }

        /// <summary>
        /// Closes this form.
        /// </summary>
        void Close();

        /// <summary>
        /// Hides the form, but does not close it.
        /// </summary>
        void Hide();

        /// <summary>
        /// Makes this form visible to the user, but not as a modal dialog box.
        /// </summary>
        void Show();

        /// <summary>
        /// Makes this form visible to the user, but not as a modal dialog box.
        /// </summary>
        /// <param name="owner">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see cref="T:System.Windows.Forms.IWin32Window" /> interface.
        /// <para />
        /// This object plays the role of the form's parent window.
        /// </param>
        void Show(IWin32Window owner);

        /// <summary>
        /// Shows the form as a modal dialog box and returns a
        /// <see cref="T:System.Windows.Forms.DialogResult" /> value that corresponds to
        /// the action the user took in order to dismiss the form.
        /// </summary>
        /// <returns>
        /// One of the <see cref="T:System.Windows.Forms.DialogResult" /> values
        /// that indicates how the user dismissed this form.
        /// </returns>
        DialogResult ShowDialog();

        /// <summary>
        /// Shows the form as a modal dialog box and returns a
        /// <see cref="T:System.Windows.Forms.DialogResult" /> value that corresponds to
        /// the action the user took in order to dismiss the form.
        /// </summary>
        /// <param name="owner">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see cref="T:System.Windows.Forms.IWin32Window" /> interface.
        /// <para />
        /// <returns>
        /// One of the <see cref="T:System.Windows.Forms.DialogResult" /> values
        /// that indicates how the user dismissed this form.
        /// </returns>
        DialogResult ShowDialog(IWin32Window owner);
    }
}