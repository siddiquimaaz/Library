using System;
using System.Windows.Forms;

namespace Library
{
    public static class FormManager
    {
        private static Form currentForm;

        public static void Show(Form newForm)
        {
            if (currentForm != null && currentForm != newForm)
            {
                currentForm.Close();
            }

            currentForm = newForm;
            currentForm.FormClosed += (sender, e) => currentForm = null;
            newForm.Show();
        }

        public static void CloseCurrentForm()
        {
            if (currentForm != null)
            {
                var tempForm = currentForm;
                currentForm = null;
                tempForm.Close();
            }
        }
    }
}
