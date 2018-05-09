using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prototype1
{
    public partial class _1login : UserControl
    {
        public _1login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            Button button = new Button();
            button.Location = new Point (50, 50);
        }
    }
}
