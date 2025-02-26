using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmChangerIdentifiants : Form
    {
        public string NouvelIdentifiant { get; set; }
        public string NouveauMotDePasse { get; set; }
        public frmChangerIdentifiants()
        {
            InitializeComponent();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
           NouvelIdentifiant = txtIdentifiantC.Text;
            NouveauMotDePasse = txtMotDePasseC.Text;


            if (string.IsNullOrEmpty(NouvelIdentifiant) || string.IsNullOrEmpty(NouveauMotDePasse))
            {
                MessageBox.Show("Veuillez entrer un nouvel identifiant et un mot de passe.");
                return;
            }
            this.DialogResult = DialogResult.OK; // Indiquer que les informations sont valides
            this.Close();
        }
    }
}
