using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.views
{
    public partial class frmRdv : Form
    {
        public frmRdv()
        {
            InitializeComponent();
        }
        public int idMedecinRdv;
        bdRdvMedicalContext db = new bdRdvMedicalContext();
        List<CrenneauViewModel> crenneauList = new List<CrenneauViewModel>();
        List<CrenneauViewModel> crenneauListIndsponible = new List<CrenneauViewModel>();
        public int idAgenda;
        public int crenneau;

        private void frmRdv_Load(object sender, EventArgs e)
        {
            var medecin = db.Medecins.Find(idMedecinRdv);
            lblMedecinRdv.Text = string.Format("N ordre {0},Nom Prenom {1},  ", medecin.NumeroOrdre, medecin.NomPrenom);


            lstCrenneau.Items.Clear();
            foreach (var i in crenneauList)
            {
                if(i.status ==true)
                {
                    lstCrenneau.Items.Add(i.HeureDebut);
                }
            }
        }
        
        

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstCrenneau_SelectedIndexChanged(object sender, EventArgs e)
        {
           // lstCrenneau = GenererCreneaux();
            if (lstCrenneau.SelectedItems != null) {
                int index = lstCrenneau.SelectedIndex;
                CrenneauViewModel cr = crenneauList[index];
                cr.status = false;
                crenneauListIndsponible.Add(cr);
                MessageBox.Show($"{cr.status}");
                crenneauList.RemoveAt(index);
                MessageBox.Show("hellp");
            }
        }

        private void lstCrenneauPrise_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
