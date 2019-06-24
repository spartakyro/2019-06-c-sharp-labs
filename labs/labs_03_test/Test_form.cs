using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labs_03_test
{
    public partial class Test_form : Form
    {
        static int counter = 0;
        public Test_form()
        {
            InitializeComponent();
            initialise();


        }

        void initialise()
        {
            label1.Text = "welcome - what is your name";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Hi " + textBox1.Text;
            counter++;
            label2.Text = counter.ToString();


        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
