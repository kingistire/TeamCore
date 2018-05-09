using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prototype1
{
    public partial class _1loading : UserControl
    {
        public _1loading()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form myForm = button1.FindForm();
            // Set the text and color of the form containing the Button.

            myForm.BackColor = Color.Red;

            

        }
    }
}
