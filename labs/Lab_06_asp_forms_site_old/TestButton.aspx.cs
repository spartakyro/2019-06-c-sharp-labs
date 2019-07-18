using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab_06_asp_forms_site_old
{
    public partial class TestButton : System.Web.UI.Page
    {
        public static int counter = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "welcome";
        }

        

        protected void Button2_Click(object sender, EventArgs e)
        {
            
            counter++;
            Label1.Text = $"Welcome, {TextBox1.Text} you've clicked test {counter} times";

            if(counter > 5)
            {
                Label1.Text = $"{TextBox1.Text} chill you've clicked test {counter} times";
            }

        }

        
    }
}