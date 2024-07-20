namespace GitHubManager
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of the Marquee
    /// Progress Dialog Box.
    /// </summary>
    public interface IMarqueeProgressDialogBox : IForm
    {
        /// <summary> Gets or sets the text of the <strong>Message</strong> label. </summary>
        string Message { get; set; }

        /// <summary>
        /// Removes this dialog box from the screen and releases the associated
        /// system resources.
        /// </summary>
        /// <remarks>
        /// <strong>NOTE:</strong> This method is only to be called when this
        /// dialog box has been shown as a modeless window.
        /// </remarks>
        void DestroyWindow();
    }
}