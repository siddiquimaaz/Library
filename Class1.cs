using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public static class FormManager
    {
        private static Form currentForm;

        public static void Show(Form newForm)
        {
            if (currentForm != null)
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
                currentForm.Close();
                currentForm = null;
            }
        }
    }

}
