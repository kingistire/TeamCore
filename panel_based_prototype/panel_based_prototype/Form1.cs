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



        //private void selectImage_Click(object sender, EventArgs e)
        //{
            
        //}

        private void aLot_Click(object sender, EventArgs e) {
            imagePanel1.BorderStyle = BorderStyle.Fixed3D;
            imagePanel1.BackColor = Color.Tomato;
        }

        private void aLittle_Click(object sender, EventArgs e) {
            imagePanel1.BorderStyle = BorderStyle.FixedSingle;
            imagePanel1.BackColor = Color.Red;
        }

        private void aLot2_Click(object sender, EventArgs e)
        {
            test1imagePanel2.BorderStyle = BorderStyle.Fixed3D;
            test1imagePanel2.BackColor = Color.Tomato;
        }

        private void aLittle2_Click(object sender, EventArgs e)
        {
            test1imagePanel2.BorderStyle = BorderStyle.FixedSingle;
            test1imagePanel2.BackColor = Color.Red;
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
            sightPic1.BackColor = Color.Silver;
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

        private void pictureBox4_Click(object sender, EventArgs e) {
            testCompleteButton1.BringToFront();
            testViewButton1.BringToFront();
        }

        private void testCompleteButton1_Click(object sender, EventArgs e) {
            soundTestPanel.BringToFront();
            aLittle.Hide();
            aLot.Hide();
            Button button = new Button();
            var bmp = new Bitmap(panel_based_prototype.Properties.Resources.balloonPopping);
            button.BackgroundImage = bmp;
            button.Dock = DockStyle.Fill;
            imagePanel1.Controls.Add(button);
            button.Click += new EventHandler(imagePanel1_Click);
            button.Dock = DockStyle.Fill;

            Button button1 = new Button();
            var bmp1 = new Bitmap(panel_based_prototype.Properties.Resources.peopleTalking);
            button1.Show();
            button1.BackgroundImage = bmp1;
            button1.Dock = DockStyle.Fill;
            test1imagePanel2.Controls.Add(button1);
            button1.Click += new EventHandler(test1imagePanel2_Click);

            Button button2 = new Button();
            var bmp2 = new Bitmap(panel_based_prototype.Properties.Resources.vehicles);
            button2.Show();
            button2.BackgroundImage = bmp2;
            button2.Dock = DockStyle.Fill;
            test1ImagePanel3.Controls.Add(button2);
            button2.Click += new EventHandler(test1ImagePanel3_Click);
        }

        private void testViewButton1_Click(object sender, EventArgs e) {
            JDTestResultsPanel.BringToFront();
        }

        private void backButton_Click(object sender, EventArgs e) {
            soundTestPanel.BringToFront();
        }

        private void test1imagePanel2_Click(object sender, EventArgs e)
        {
            button16.Visible = true;
            button17.Visible = true;

        }

        private void button16_Click(object sender, EventArgs e)
        {
            test1imagePanel2.BorderStyle = BorderStyle.Fixed3D;
            test1imagePanel2.BackColor = Color.Tomato;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            test1imagePanel2.BorderStyle = BorderStyle.FixedSingle;
            test1imagePanel2.BackColor = Color.Red;
        }

        private void test1ImagePanel3_Click(object sender, EventArgs e)
        {
            button18.Visible = true;
            button19.Visible = true;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            test1ImagePanel3.BorderStyle = BorderStyle.Fixed3D;
            test1ImagePanel3.BackColor = Color.Tomato;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            test1ImagePanel3.BorderStyle = BorderStyle.FixedSingle;
            test1ImagePanel3.BackColor = Color.Red;
        }
    }
}
