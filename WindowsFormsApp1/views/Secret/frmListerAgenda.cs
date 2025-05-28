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
using MetierRvMedical2.Interfaces;
using MetierRvMedical2.Models;
using MetierRvMedical2.Services;

namespace WindowsFormsApp1.views.Secret
{
    public partial class frmListerAgenda : Form
    {
        private readonly IAgendaService _agendaService = new AgendaService();

        public frmListerAgenda()
        {
            InitializeComponent();
            LoadAgendas();
        }

        private void LoadAgendas()
        {
            // Use AgendaService to get all agendas
            var agendas = _agendaService.GetAllAgendas()
                .Where(ag => ag.Statut.Equals("dispo"))
                .Select(agenda => new
                {
                    agenda.DataPlanifier,
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
