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

namespace WindowsFormsApp1.views.Secret
{
    public partial class frmListerAgenda : Form
    {
        bdRdvMedicalContext bd = new bdRdvMedicalContext();
        
        public frmListerAgenda()
        {
            InitializeComponent();
            LoadAgendas();
        }

        private void LoadAgendas()
        {
           //TODO for cheikh enlever  l'affichage de lheure
          var agendas = bd.Agenda
    .Where(ag => ag.Statut.Equals("dispo"))
    .Select(agenda => new
    {
        agenda.DataPlanifier ,
        agenda.Medecin.NomPrenom,
        agenda.HeureDebut,
        agenda.HeureFin,
    })
    .ToList();

dgAgendas.DataSource = agendas;

            
        }

        private void frmListerAgenda_Load(object sender, EventArgs e)
        {

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
