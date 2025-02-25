using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.CustomControls
{
    public partial class frmInformation : Form
    {
        public frmInformation()
        {
            InitializeComponent();
        }
        public frmInformation(string message)
        {
            InitializeComponent();
            lblMessage.Text = message;
        }

        private void btnOui_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
