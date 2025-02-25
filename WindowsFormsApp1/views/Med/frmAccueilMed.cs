using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.views.Med
{
    public partial class frmAccueilMed : Form
    {
        public frmAccueilMed()
        {
            InitializeComponent();
            LoadAgenda();
        }

        bdRdvMedicalContext bd = new bdRdvMedicalContext();

        private void btnAjouterAgenda_Click(object sender, EventArgs e)
        {
            //TODO : Partir sur Agenda avec l'id du Medecin 
            frmMedAgenda frmMedAgenda = new frmMedAgenda();
            frmMedAgenda.ShowDialog();
        }
        public void LoadAgenda()

        {
            var medecin = bd.Personnes
                       .Where(p => p.IdP == FrmConnexion.user.IdP)
                       .OfType<Medecin>()
                       .FirstOrDefault();
            dgAgendaMedecin.DataSource = medecin.agenda.ToList();

        }

        private void btnVoirRdv_Click(object sender, EventArgs e)
        {

        }
    }

   
}
