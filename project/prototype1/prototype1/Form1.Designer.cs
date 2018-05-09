namespace prototype1
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
            this.button1 = new System.Windows.Forms.Button();
<<<<<<< HEAD
            this.loading_panel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loadingTOlogin = new System.Windows.Forms.Button();
            this.login_panel = new System.Windows.Forms.Panel();
            this.loading_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
=======
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
>>>>>>> 8ad00678e8e2fab84d0fff9bdc904bdfdf53151a
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(964, 449);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
<<<<<<< HEAD
            // loading_panel
            // 
            this.loading_panel.Controls.Add(this.loadingTOlogin);
            this.loading_panel.Controls.Add(this.pictureBox1);
            this.loading_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loading_panel.Location = new System.Drawing.Point(0, 0);
            this.loading_panel.Name = "loading_panel";
            this.loading_panel.Size = new System.Drawing.Size(1142, 638);
            this.loading_panel.TabIndex = 2;
=======
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(643, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
>>>>>>> 8ad00678e8e2fab84d0fff9bdc904bdfdf53151a
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::prototype1.Properties.Resources._1_Loading_Screen;
<<<<<<< HEAD
            this.pictureBox1.Location = new System.Drawing.Point(5, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1134, 636);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // loadingTOlogin
            // 
            this.loadingTOlogin.Location = new System.Drawing.Point(319, 438);
            this.loadingTOlogin.Name = "loadingTOlogin";
            this.loadingTOlogin.Size = new System.Drawing.Size(510, 103);
            this.loadingTOlogin.TabIndex = 1;
            this.loadingTOlogin.Text = "button2";
            this.loadingTOlogin.UseVisualStyleBackColor = true;
            this.loadingTOlogin.Click += new System.EventHandler(this.loadingTOlogin_Click);
            // 
            // login_panel
            // 
            this.login_panel.Location = new System.Drawing.Point(0, 0);
            this.login_panel.Name = "login_panel";
            this.login_panel.Size = new System.Drawing.Size(1139, 639);
            this.login_panel.TabIndex = 2;
=======
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(837, 501);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::prototype1.Properties.Resources._2_Login;
            this.pictureBox2.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(860, 516);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
>>>>>>> 8ad00678e8e2fab84d0fff9bdc904bdfdf53151a
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(1142, 638);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.loading_panel);
            this.Controls.Add(this.login_panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.loading_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
=======
            this.ClientSize = new System.Drawing.Size(870, 553);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
>>>>>>> 8ad00678e8e2fab84d0fff9bdc904bdfdf53151a
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
<<<<<<< HEAD
        private System.Windows.Forms.Panel loading_panel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button loadingTOlogin;
        private System.Windows.Forms.Panel login_panel;
=======
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
>>>>>>> 8ad00678e8e2fab84d0fff9bdc904bdfdf53151a
    }
}

