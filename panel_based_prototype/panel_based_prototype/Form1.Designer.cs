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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loadingTOlogin = new System.Windows.Forms.Button();
            this.loginPanel2no1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.loadingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.loginPanel2no1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            // loginPanel2no1
            // 
            this.loginPanel2no1.Controls.Add(this.pictureBox2);
            this.loginPanel2no1.Location = new System.Drawing.Point(0, 0);
            this.loginPanel2no1.Name = "loginPanel2no1";
            this.loginPanel2no1.Size = new System.Drawing.Size(1143, 745);
            this.loginPanel2no1.TabIndex = 1;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 744);
            this.Controls.Add(this.loginPanel2no1);
            this.Controls.Add(this.loadingPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.loadingPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.loginPanel2no1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loadingPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button loadingTOlogin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel loginPanel2no1;
    }
}

