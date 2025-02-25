using Org.BouncyCastle.Security;
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

namespace WindowsFormsApp1.views.Med
{
    public partial class frmRdvMed : Form
    {
        public frmRdvMed()
        {
            InitializeComponent();
            loadRdv();
        }

        bdRdvMedicalContext bd = new bdRdvMedicalContext();

        private void frmRdvMed_Load(object sender, EventArgs e)
        {

        }

        private void loadRdv()
        {
            
           Medecin currentMedecin = (Medecin)FrmConnexion.user;
                dgRdvMedecin.DataSource = bd.RendezVous.Where(rdv => rdv.IdMedecin == currentMedecin.IdP).Select(rdv => new
                {
                    Heure = rdv.HeureRv,

                }).ToList();


                
           
         
        }
    }
}
