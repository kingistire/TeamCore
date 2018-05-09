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
            LoadImage();
        }

        private void LoadImage()
        {
            pictureBox1.Load("https://ih0.redbubble.net/image.363915459.3586/flat,800x800,075,f.u2.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Glimlag");
        }
    }
}
