using System;
using System.Windows.Forms;

namespace GitHubManager
{
    /// <summary>
    /// Progress dialog for a long-running operation of indeterminate length.
    /// </summary>
    public partial class MarqueeProgressDialogBox : Form,
        IMarqueeProgressDialogBox
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:GitHubManager.MarqueeProgressDialogBox" /> and returns a reference
        /// to it.
        /// </summary>
        public MarqueeProgressDialogBox()
            => InitializeComponent();

        /// <summary>
        /// Gets or sets the text of the <strong>Message</strong> label.
        /// </summary>
        public string Message
        {
            get => messageLabel.Text;
            set
                => messageLabel.InvokeIfRequired(
                    new MethodInvoker(() => { messageLabel.Text = value; })
                );
        }

        /// <summary>
        /// Removes this dialog box from the screen and releases the associated system
        /// resources.
        /// </summary>
        /// <remarks>
        /// <strong>NOTE:</strong> This method is only to be called when this
        /// dialog box has been shown as a modeless window.
        /// </remarks>
        public void DestroyWindow()
            => this.DoIfNotDisposed(
                new MethodInvoker(
                    () =>
                    {
                        Hide();
                        Close();
                        Dispose();
                    }
                )
            );

        /// <summary>Raises the <see cref="E:System.Windows.Forms.Form.Load" /> event.</summary>
        /// <param name="e">
        /// An <see cref="T:System.EventArgs" /> that contains the event
        /// data.
        /// </param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Set the title bar text to the same as the name
            // of the application by default.
            Text = Application.ProductName;
        }
    }
}
