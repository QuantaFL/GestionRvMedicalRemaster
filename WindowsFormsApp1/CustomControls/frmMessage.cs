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
           /// resetValue();
        }
        public frmMessage(string Message)
        {
            InitializeComponent();
            lblMessage.Text = Message;
           // resetValue();
        }
        public frmMessage(string Message,string titre)
        {
            InitializeComponent();
            lblMessage.Text = Message;
            lblTitre.Text = titre;
            // resetValue();
        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

         public DialogResult CustomDialogResult { get; set; }
      //  public int CustomDialogResult;


        public   void frmMessage_Load(object sender, EventArgs e)
        {
            


        }
        public void resetValue()
        {
           // CustomDialogResult = -1;
        }

        
       
        public int oui()
        {
            return 1;
        }

        public int non()
        {
            return 0;
        }
       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnOui_Click_1(object sender, EventArgs e)
        {
            CustomDialogResult = DialogResult.Yes; 
            this.DialogResult = DialogResult.Yes;  
            this.Close();
        }

        private void btnNon_Click(object sender, EventArgs e)
        {
            CustomDialogResult = DialogResult.No;  
            this.DialogResult = DialogResult.No;   
            this.Close();
        }
    }
}
