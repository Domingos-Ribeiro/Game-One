using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstApp
{
    public partial class FirstApp : Form
    {
        public FirstApp()
        {
            InitializeComponent();
        }

        private void btn_Welcome_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome")
        }
    }
}
