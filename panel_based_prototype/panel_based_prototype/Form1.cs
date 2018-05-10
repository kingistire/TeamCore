using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace panel_based_prototype
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadingPanel.BringToFront();
        }

        private void loadingTOlogin_Click(object sender, EventArgs e)
        {
            loginPanel2no1.BringToFront();
        }

        private void loginPassEnterLabel_Click(object sender, EventArgs e)
        {
            loginPassEnterLabel.Text = "*******************";
        }

        private void loginLoginButton_Click(object sender, EventArgs e)
        {
            allProfilePage1no1.BringToFront();
        }

        private void profilePageOpenJD_Click(object sender, EventArgs e)
        {
            intervieweeProfilePageJD1.BringToFront();
        }

        private void JDView1032018test1_Click(object sender, EventArgs e)
        {
            JDTestResultsPanel.BringToFront();
        }

        private void JD27042018testCompleteButton1_Click(object sender, EventArgs e)
        {
            generalTestPanel.BringToFront();
            aLittle.Hide();
            aLot.Hide();
            Form3 f3 = new Form3();
            f3.Show();
            Button button = new Button();
            button.Text = "Select The Image Above";
            selectImage.BringToFront();
            selectImage.Controls.Add(button);
            button.Click += new EventHandler(selectImage_Click);
            button.Dock = DockStyle.Fill;
            MessageBox.Show("Glimglag");
        }

        private void selectImage_Click(object sender, EventArgs e)
        {
            Button aLittleBtn = new Button();
            Button aLotBtn = new Button();
            aLotBtn.Text = "A Lot";
            aLittleBtn.Text = "A Little";
            aLittle.Show();
            aLot.Show();
            aLittleBtn.Visible = true;
            aLotBtn.Visible = true;
            aLittleBtn.Dock = DockStyle.Fill;
            aLotBtn.Dock = DockStyle.Fill;
            aLot.Controls.Add(aLotBtn);
            aLittle.Controls.Add(aLittleBtn);
        }

        private void JDBackButton_Click(object sender, EventArgs e)
        {
            allProfilePage1no1.BringToFront();
        }

        private void JDTestReturnToProfileButton_Click(object sender, EventArgs e)
        {
            intervieweeProfilePageJD1.BringToFront();
        }
    }
}
