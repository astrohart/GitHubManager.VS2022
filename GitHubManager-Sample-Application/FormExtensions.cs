using System;

namespace GitHubManagerSampleApplication
{
    /// <summary>
    /// Helper methods for working with Windows Forms and their child
    /// controls.
    /// </summary>
    public static class FormExtensions
    {
        /// <summary>
        /// Carries out the action called for by the specified
        /// <paramref name="delegate" /> if the <paramref name="form" /> is not disposed.
        /// <para />
        /// Performs cross-thread invocation as necessary.
        /// </summary>
        /// <param name="form">
        /// (Required.) Reference to an instance of an object that
        /// implements the <see cref="T:GitHubManagerSampleApplication.IForm" /> interface.
        /// </param>
        /// <param name="delegate">
        /// (Required.) Reference to a
        /// <see cref="T:System.Delegate" /> that specifies the action(s) to be taken.
        /// </param>
        /// <param name="args">
        /// (Optional.) Zero or more arguments to pass to the
        /// <paramref name="delegate" />.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required
        /// parameter, <paramref name="delegate" />, is passed a <see langword="null" />
        /// value.
        /// </exception>
        public static void DoIfNotDisposed(
            this IForm form,
            Delegate @delegate,
            params object[] args
        )
        {
            if (form == null || !form.IsHandleCreated || form.IsDisposed)
                return;

            if (@delegate == null)
                throw new ArgumentNullException(nameof(@delegate));

            if (form.InvokeRequired)
                form.BeginInvoke(@delegate, args);
            else
                @delegate.DynamicInvoke(args);
        }

        /// <summary>
        /// Uses cross-thread synchronization and method invocation to carry out
        /// the action(s) directed by the provided <paramref name="delegate" /> on the
        /// specified <paramref name="control" />, if such an action is required to be
        /// invoked across threads.
        /// </summary>
        /// <param name="control">
        /// (Required.) Reference to the
        /// <see cref="T:System.Windows.Forms.Control" /> on whose UI thread the specified
        /// action(s) should be invoked.
        /// </param>
        /// <param name="delegate">
        /// (Required.) A <see cref="T:System.Delegate" /> instance
        /// that specifies the action(s) to be taken.
        /// </param>
        /// <param name="args">
        /// (Optional.) Zero or more arguments to be passed to the
        /// delegate invocation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if either of the
        /// required parameters, <paramref name="control" />, or
        /// <paramref name="delegate" />, are passed a <see langword="null" /> value.
        /// </exception>
        public static void InvokeIfRequired(
            this Control control,
            Delegate @delegate,
            params object[] args
        )
        {
            if (control == null)
                throw new ArgumentNullException(nameof(control));
            if (@delegate == null)
                throw new ArgumentNullException(nameof(@delegate));

            if (control.InvokeRequired)
                control.BeginInvoke(@delegate, args);
            else
                @delegate.DynamicInvoke(args);
        }
    }
}