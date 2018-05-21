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
        private bool aLittleButton = false;
        private bool aLotButton = false;
        private bool aLittleButton2 = false;
        private bool aLotButton2 = false;
        private bool aLittleButton3 = false;
        private bool aLotButton3 = false;
        private Button aLittleBtn;
        private Button aLotBtn;

        public Form1()
        {
            InitializeComponent();
            loginPanel2no1.BringToFront();
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
            //Image Panel 1
            Button button = new Button();
            button.BackgroundImage = Image.FromFile(@"C:\Users\Jason Tam\Pictures\Holden-VY-SS-Commodore-2002-10-.jpg");
            button.BackgroundImageLayout = ImageLayout.Stretch;
            imagePanel1.Controls.Add(button);
            button.Click += new EventHandler(imagePanel1_Click);
            button.Dock = DockStyle.Fill;
            //Image Panel 2
            Button button1 = new Button();
            button1.BackgroundImage = Image.FromFile(@"C:\Users\Jason Tam\Pictures\Holden-VY-SS-Commodore-2002-10-.jpg");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            test1imagePanel2.Controls.Add(button1);
            button1.Click += new EventHandler(test1imagePanel2_Click);
            button1.Dock = DockStyle.Fill;
            //Image Panel 3
            Button button2 = new Button();
            button2.BackgroundImage = Image.FromFile(@"C:\Users\Jason Tam\Pictures\Holden-VY-SS-Commodore-2002-10-.jpg");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            test1ImagePanel3.Controls.Add(button2);
            button2.Click += new EventHandler(test1ImagePanel3_Click);
            button2.Dock = DockStyle.Fill;
        }

        //private void selectImage_Click(object sender, EventArgs e)
        //{
            
        //}

        private void aLot_Click(object sender, EventArgs e) {
            if (aLotButton) {
                imagePanel1.BorderStyle = BorderStyle.Fixed3D;
            }
        }

        private void aLittle_Click(object sender, EventArgs e) {
            if (aLittleButton) {
                imagePanel1.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        private void JDBackButton_Click(object sender, EventArgs e)
        {
            allProfilePage1no1.BringToFront();
        }

        private void JDTestReturnToProfileButton_Click(object sender, EventArgs e)
        {
            intervieweeProfilePageJD1.BringToFront();
        }

        private void imagePanel1_Click(object sender, EventArgs e) {
            aLittleBtn = new Button();
            aLotBtn = new Button();
            aLotBtn.Text = "A Lot";
            aLittleBtn.Text = "A Little";
            //aLittleBtn.Visible = true;
            //aLotBtn.Visible = true;
            //aLittleBtn.Show();
            //aLotBtn.Show();
            aLittleBtn.Dock = DockStyle.Fill;
            aLotBtn.Dock = DockStyle.Fill;
            //Adding controls to buttons
            aLot.Visible = true;
            aLittle.Visible = true;
            aLot.Controls.Add(aLotBtn);
            aLittle.Controls.Add(aLittleBtn);
            aLotBtn.Click += new EventHandler(aLot_Click);
            aLittleBtn.Click += new EventHandler(aLittle_Click);
            aLittleButton = true;
            aLotButton = true;
        }

        private void test1imagePanel2_Click(object sender, EventArgs e) {
            aLittleBtn = new Button();
            aLotBtn = new Button();
            aLotBtn.Text = "A Lot";
            aLittleBtn.Text = "A Little";
            test1aLittle2.Visible = true;
            test1aLot2.Visible = true;
            test1aLot2.Controls.Add(aLotBtn);
            test1aLittle2.Controls.Add(aLittleBtn);
            aLotBtn.Click += new EventHandler(aLot_Click);
            aLittleBtn.Click += new EventHandler(aLittle_Click);
            aLittleButton2 = true;
            aLotButton2 = true;
        }

        private void test1ImagePanel3_Click(object sender, EventArgs e) {
            aLittleBtn = new Button();
            aLotBtn = new Button();
            aLotBtn.Text = "A Lot";
            aLittleBtn.Text = "A Little";
            test1aLittle3.Visible = true;
            test1aLot3.Visible = true;
            test1aLot3.Controls.Add(aLotBtn);
            test1aLittle3.Controls.Add(aLittleBtn);
            aLotBtn.Click += new EventHandler(aLot_Click);
            aLittleBtn.Click += new EventHandler(aLittle_Click);
            aLotButton3 = true;
            aLittleButton3 = true;
        }
    }
}
