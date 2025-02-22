using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.views.Admin;

namespace WindowsFormsApp1.views
{
    public partial class frmAccueilAdmin : Form
    {
        public frmAccueilAdmin()
        {
            InitializeComponent();
        }

        private void btnAjouterUtilisateur_Click(object sender, EventArgs e)
        {
            frmAdminAjouterUtilisateur ajouterUtilisateur = new frmAdminAjouterUtilisateur();
            ajouterUtilisateur.Show();
        }

        private void frmAccueilAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
