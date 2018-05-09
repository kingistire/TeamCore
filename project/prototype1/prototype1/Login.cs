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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            button2.Visible = false;
            button3.Visible = false;
            LoadImage();
        }

        private void LoadImage()
        {
            pictureBox1.Load("https://ih0.redbubble.net/image.363915459.3586/flat,800x800,075,f.u2.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox2.Load("https://is2-ssl.mzstatic.com/image/thumb/Purple118/v4/68/e2/b3/68e2b301-a83a-7f8f-bd49-7b3397999e50/AppIcon-1x_U007emarketing-85-220-6.png/246x0w.jpg");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox3.Load("https://ih0.redbubble.net/image.363915459.3586/flat,800x800,075,f.u2.jpg");
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox4.Load("https://is2-ssl.mzstatic.com/image/thumb/Purple118/v4/68/e2/b3/68e2b301-a83a-7f8f-bd49-7b3397999e50/AppIcon-1x_U007emarketing-85-220-6.png/246x0w.jpg");
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox1.Load("https://ih0.redbubble.net/image.363915459.3586/flat,800x800,075,f.u2.jpg");
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox5.Load("https://is2-ssl.mzstatic.com/image/thumb/Purple118/v4/68/e2/b3/68e2b301-a83a-7f8f-bd49-7b3397999e50/AppIcon-1x_U007emarketing-85-220-6.png/246x0w.jpg");
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox6.Load("https://ih0.redbubble.net/image.363915459.3586/flat,800x800,075,f.u2.jpg");
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox7.Load("https://is2-ssl.mzstatic.com/image/thumb/Purple118/v4/68/e2/b3/68e2b301-a83a-7f8f-bd49-7b3397999e50/AppIcon-1x_U007emarketing-85-220-6.png/246x0w.jpg");
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox8.Load("https://ih0.redbubble.net/image.363915459.3586/flat,800x800,075,f.u2.jpg");
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            button3.Visible = true;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            MessageBox.Show("Glimlag");
        }
    }
}
