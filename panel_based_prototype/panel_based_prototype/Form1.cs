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
        private bool aLotButton = true;
        private Button aLittleBtn;
        private Button aLotBtn;

        public Form1()
        {
            InitializeComponent();
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
            soundTestPanel.BringToFront();
            aLittle.Hide();
            aLot.Hide();
            Button button = new Button();
            //button.BackgroundImage = Image.FromFile(@"C:\Users\Jason Tam\Pictures\Holden-VY-SS-Commodore-2002-10-.jpg");
            button.Dock = DockStyle.Fill;
            imagePanel1.Controls.Add(button);
            button.Click += new EventHandler(imagePanel1_Click);
            button.Dock = DockStyle.Fill;
            PictureBox carPb = new PictureBox();
            carPb.ImageLocation = "https://res.cloudinary.com/carsguide/image/upload/f_auto,fl_lossy,q_auto,t_cg_hero_large/v1/editorial/dp/albums/album-1327/lg/Holden-VY-SS-Commodore-2002-10-.jpg";
            carPb.Dock = DockStyle.Fill;
            imagePanel1.Controls.Add(carPb);
            carPb.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        //private void selectImage_Click(object sender, EventArgs e)
        //{
            
        //}

        private void aLot_Click(object sender, EventArgs e) {
            aLotButton = true;
            if (aLotButton) {
                imagePanel1.BorderStyle = BorderStyle.Fixed3D;
            }
        }

        private void aLittle_Click(object sender, EventArgs e) {
            aLittleButton = true;
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
            aLittle.Show();
            aLot.Show();
            aLittleBtn.Visible = true;
            aLotBtn.Visible = true;
            aLittleBtn.Dock = DockStyle.Fill;
            aLotBtn.Dock = DockStyle.Fill;
            //Adding controls to buttons
            aLot.Controls.Add(aLotBtn);
            aLittle.Controls.Add(aLittleBtn);
            aLotBtn.Click += new EventHandler(aLot_Click);
            aLittleBtn.Click += new EventHandler(aLittle_Click);
        }

        private void test1Btn_Click(object sender, EventArgs e) {
            sightTestPanel.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e) {
            sightPic1.BorderStyle = BorderStyle.Fixed3D;
            sightPic1.BackColor = Color.Tomato;
        }

        private void button3_Click(object sender, EventArgs e) {
            sightPic1.BorderStyle = BorderStyle.None;
            sightPic1.BackColor = Color.Red;
        }

        private void button7_Click(object sender, EventArgs e) {
            sightPic2.BorderStyle = BorderStyle.Fixed3D;
            sightPic2.BackColor = Color.Tomato;
        }

        private void button12_Click(object sender, EventArgs e) {
            sightPic2.BorderStyle = BorderStyle.None;
            sightPic2.BackColor = Color.Red;
        }

        private void button6_Click(object sender, EventArgs e) {
            sightPic3.BorderStyle = BorderStyle.Fixed3D;
            sightPic3.BackColor = Color.Tomato;
        }

        private void button11_Click(object sender, EventArgs e) {
            sightPic3.BorderStyle = BorderStyle.None;
            sightPic3.BackColor = Color.Red;
        }

        private void button8_Click(object sender, EventArgs e) {
            sightPic4.BorderStyle = BorderStyle.Fixed3D;
            sightPic4.BackColor = Color.Tomato;
        }

        private void button10_Click(object sender, EventArgs e) {
            sightPic4.BorderStyle = BorderStyle.None;
            sightPic4.BackColor = Color.Red;
        }

        private void button5_Click(object sender, EventArgs e) {
            sightPic5.BorderStyle = BorderStyle.Fixed3D;
            sightPic5.BackColor = Color.Tomato;
        }

        private void button9_Click(object sender, EventArgs e) {
            sightPic5.BorderStyle = BorderStyle.None;
            sightPic5.BackColor = Color.Red;
        }

        private void button4_Click(object sender, EventArgs e) {
            sightPic6.BorderStyle = BorderStyle.Fixed3D;
            sightPic6.BackColor = Color.Tomato;
        }

        private void button13_Click(object sender, EventArgs e) {
            sightPic6.BorderStyle = BorderStyle.None;
            sightPic6.BackColor = Color.Red;
        }
    }
}
