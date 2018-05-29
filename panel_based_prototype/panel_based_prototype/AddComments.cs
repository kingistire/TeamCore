using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Controls;

namespace panel_based_prototype {
    public partial class AddComments : Form {
        private Form1 form1;

        public AddComments(Form1 form1) {
            InitializeComponent();
            this.form1 = form1;
            if(MessageBox.Show("You have completed the interview!", "Completed the interview!", MessageBoxButtons.OK) == DialogResult.OK) {
                button1.Visible = true;
                textBox1.Visible = true;
            }
        }

        public string getText() {
            return this.textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e) {
            label2.Text = textBox1.Text;
            label2.Visible = true;
            label3.Visible = true;
            pictureBox1.BringToFront();
            pictureBox1.Visible = true;
            label2.BringToFront();
            label3.BringToFront();
            form1.SetLabelText(textBox1.Text);
        }
    }
}
