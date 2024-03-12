using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1.Helper
{
    public class ActionFormHelper
    {
        public ActionFormHelper() { }

        public static void nevigationForm(Form current, Form next)
        {
            current.Visible = false;
            next.Show();
            
        }

        public static void backPreviousForm(Form current)
        {
            current.Hide();
            // current.Visible = false;
            IndexForm indexForm = new IndexForm();
            indexForm.ShowDialog();
        }

        public static void backPreviousForm(Form current, Form previous)
        {
            current.Hide();

            previous.ShowDialog();

            // current.Show();
        }

    }
}
