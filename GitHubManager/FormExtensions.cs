using System;
using System.Windows.Forms;

namespace GitHubManager
{
    public static class FormExtensions
    {
        public static void DoIfNotDisposed(this IForm form, Delegate @delegate,
            params object[] args)
        {
            if (form == null || !form.IsHandleCreated || form.IsDisposed) return;

            if (@delegate == null)
                throw new ArgumentNullException(nameof(@delegate));

            if (form.InvokeRequired)
                form.BeginInvoke(@delegate, args);
            else
                @delegate.DynamicInvoke(args);
        }

        public static void InvokeIfRequired(this Control control,
            Delegate @delegate, params object[] args)
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