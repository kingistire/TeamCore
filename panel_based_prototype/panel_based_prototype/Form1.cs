﻿using System;
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
