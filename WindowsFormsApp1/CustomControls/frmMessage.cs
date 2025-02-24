using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.views.Admin
{
    public partial class frmMessage : Form
    {
        public frmMessage()
        {
            InitializeComponent();
        }
        public frmMessage(string Message)
        {
            InitializeComponent();
            lblMessage.Text = Message;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public DialogResult CustomDialogResult { get; private set; }


        private   void frmMessage_Load(object sender, EventArgs e)
        {
            


        }
        public void resetValue()
        {
            CustomDialogResult = DialogResult.OK;
        }

        private void btnOui_Click(object sender, EventArgs e)
        {
            resetValue();
            CustomDialogResult = DialogResult.Yes;
            
        }

        private void btnNon_Click(object sender, EventArgs e)
        {
            resetValue();
            CustomDialogResult = DialogResult.No;
            this.Close();
        }
    }
}
