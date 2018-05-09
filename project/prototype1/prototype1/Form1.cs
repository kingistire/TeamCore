using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace prototype1
{
    public partial class Form1 : Form
    {
        // create an instance for all of the prototype pages
        // public UserControl loadingPage = new _1loading();
        // public UserControl loginPage = new _1login();

        public Form1()
        {
            InitializeComponent();
<<<<<<< HEAD
            loading_panel.BringToFront();
            
=======
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Hide();
>>>>>>> 8ad00678e8e2fab84d0fff9bdc904bdfdf53151a
        }

        

        private void HideAllPanels()
        {
            loading_panel.Visible = false;

        }
<<<<<<< HEAD
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        



        private void button1_Click(object sender, EventArgs e)
=======

        private void Button1_Click(object sender, EventArgs e)
>>>>>>> 8ad00678e8e2fab84d0fff9bdc904bdfdf53151a
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

<<<<<<< HEAD
        private void loadingTOlogin_Click(object sender, EventArgs e)
        {
            login_panel.BringToFront();
=======
        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox1.Hide();
>>>>>>> 8ad00678e8e2fab84d0fff9bdc904bdfdf53151a
        }
    }
}
