namespace panel_based_prototype
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loadingPanel = new System.Windows.Forms.Panel();
            this.loadingTOlogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginPanel2no1 = new System.Windows.Forms.Panel();
            this.loginPassEnterLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.loginLoginButton = new System.Windows.Forms.Button();
            this.allProfilePage1no1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.loadingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.loginPanel2no1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.allProfilePage1no1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // loadingPanel
            // 
            this.loadingPanel.Controls.Add(this.loadingTOlogin);
            this.loadingPanel.Controls.Add(this.pictureBox1);
            this.loadingPanel.Location = new System.Drawing.Point(3, 0);
            this.loadingPanel.Name = "loadingPanel";
            this.loadingPanel.Size = new System.Drawing.Size(1143, 748);
            this.loadingPanel.TabIndex = 0;
            // 
            // loadingTOlogin
            // 
            this.loadingTOlogin.Location = new System.Drawing.Point(248, 114);
            this.loadingTOlogin.Name = "loadingTOlogin";
            this.loadingTOlogin.Size = new System.Drawing.Size(646, 473);
            this.loadingTOlogin.TabIndex = 1;
            this.loadingTOlogin.Text = "button1";
            this.loadingTOlogin.UseVisualStyleBackColor = true;
            this.loadingTOlogin.Click += new System.EventHandler(this.loadingTOlogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::panel_based_prototype.Properties.Resources._1_Loading_Screen;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1143, 748);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // loginPanel2no1
            // 
            this.loginPanel2no1.Controls.Add(this.loginLoginButton);
            this.loginPanel2no1.Controls.Add(this.loginPassEnterLabel);
            this.loginPanel2no1.Controls.Add(this.pictureBox2);
            this.loginPanel2no1.Location = new System.Drawing.Point(0, 0);
            this.loginPanel2no1.Name = "loginPanel2no1";
            this.loginPanel2no1.Size = new System.Drawing.Size(1143, 745);
            this.loginPanel2no1.TabIndex = 1;
            // 
            // loginPassEnterLabel
            // 
            this.loginPassEnterLabel.AutoSize = true;
            this.loginPassEnterLabel.Location = new System.Drawing.Point(653, 340);
            this.loginPassEnterLabel.Name = "loginPassEnterLabel";
            this.loginPassEnterLabel.Size = new System.Drawing.Size(269, 20);
            this.loginPassEnterLabel.TabIndex = 3;
            this.loginPassEnterLabel.Text = "                        Enter Password             ";
            this.loginPassEnterLabel.Click += new System.EventHandler(this.loginPassEnterLabel_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::panel_based_prototype.Properties.Resources._2_Login;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1146, 745);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // loginLoginButton
            // 
            this.loginLoginButton.Location = new System.Drawing.Point(646, 405);
            this.loginLoginButton.Name = "loginLoginButton";
            this.loginLoginButton.Size = new System.Drawing.Size(290, 39);
            this.loginLoginButton.TabIndex = 4;
            this.loginLoginButton.Text = "Log In Boi";
            this.loginLoginButton.UseVisualStyleBackColor = true;
            this.loginLoginButton.Click += new System.EventHandler(this.loginLoginButton_Click);
            // 
            // allProfilePage1no1
            // 
            this.allProfilePage1no1.Controls.Add(this.pictureBox3);
            this.allProfilePage1no1.Location = new System.Drawing.Point(0, 0);
            this.allProfilePage1no1.Name = "allProfilePage1no1";
            this.allProfilePage1no1.Size = new System.Drawing.Size(1146, 745);
            this.allProfilePage1no1.TabIndex = 5;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::panel_based_prototype.Properties.Resources._3_Profile_Screen;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1146, 742);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 744);
            this.Controls.Add(this.allProfilePage1no1);
            this.Controls.Add(this.loginPanel2no1);
            this.Controls.Add(this.loadingPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.loadingPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.loginPanel2no1.ResumeLayout(false);
            this.loginPanel2no1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.allProfilePage1no1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loadingPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button loadingTOlogin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel loginPanel2no1;
        private System.Windows.Forms.Label loginPassEnterLabel;
        private System.Windows.Forms.Button loginLoginButton;
        private System.Windows.Forms.Panel allProfilePage1no1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

