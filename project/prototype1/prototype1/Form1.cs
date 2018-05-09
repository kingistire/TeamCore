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
            loading_panel.BringToFront();
            
        }

        

        private void HideAllPanels()
        {
            loading_panel.Visible = false;

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        



        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void loadingTOlogin_Click(object sender, EventArgs e)
        {
            login_panel.BringToFront();
        }
    }
}
