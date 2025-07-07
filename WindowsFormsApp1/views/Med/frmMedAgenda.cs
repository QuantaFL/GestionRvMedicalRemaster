using System;
using System.Windows.Forms;
using MetierRvMedical2.Services;
using Serilog;
using WindowsFormsApp1.ApiConsumer.Models;
using WindowsFormsApp1.ApiConsumer.Requests;
using WindowsFormsApp1.CustomControls;

namespace WindowsFormsApp1.views.Med
{
    public partial class frmMedAgenda : Form
    {
        private readonly AgendaService _agendaService;
        private readonly MedecinService _medecinService;
        private readonly User medecinActuelle = FrmConnexion.user.User;

        public frmMedAgenda()
        {
            InitializeComponent();
            txtHeureDebut.Mask = "00:00";
            txtHeureFin.Mask = "00:00";
            txtHeureDebut.ValidatingType = typeof(DateTime);
            txtHeureFin.ValidatingType = typeof(DateTime);
            //_agendaService = new AgendaService();
            //_medecinService = new MedecinService();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnValiderAjoutUtilisateur_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                Log.Information("Tentative de connexion a la base");

                    Log.Information("Tentative de recuperation des informations medecin");


                    var medecin =  await ApiConsumer.ApiClientContainer.UserService.GetUserAsync(medecinActuelle.Id);

                    if (medecin == null)
                    {
                        new frmInformation("Medecin introuvable.").ShowDialog();
                        Log.Warning("Medecin introuvable avec l'ID specifie.");
                        return;
                    }

                    Log.Information("Verification des champs obligatoires");

                    if (string.IsNullOrEmpty(txtTitreAgenda.Text) || string.IsNullOrEmpty(txtLieu.Text) ||
                        string.IsNullOrEmpty(txtCrenneau.Text) || string.IsNullOrEmpty(txtHeureDebut.Text) ||
                        string.IsNullOrEmpty(txtHeureFin.Text))
                    {
                        new frmInformation("Tous les champs doivent etre remplis.").ShowDialog();
                        Log.Warning("Des champs obligatoires sont vides.");
                        return;
                    }

                    if (!int.TryParse(txtCrenneau.Text, out int creneau) || creneau <= 0)
                    {
                        new frmInformation("Veuillez entrer un creneau valide.").ShowDialog();
                        Log.Warning("Creneau invalide ou non numérique.");
                        return;
                    }

                    Log.Information("Creation de l'agenda");

                    try
                    {

                        Log.Information("Tentative d'enregistrement de l'agenda");

                     CreateAgendaRequest request = new CreateAgendaRequest { 
                    HeureDebut = txtHeureDebut.Text,
                    HeureFin = txtHeureFin.Text,
                        DataPlanifier = txtDateAgenda.Value.ToString("yyyy-MM-dd"),
                    MedecinId = medecin.Id,
                    Lieu = txtLieu.Text,
                    Titre = txtTitreAgenda.Text,
                    Statut= "DISPONIBLE",
                    Creneau = creneau
                    };
                    MessageBox.Show($"{medecin.Id}");
                   var response =  await ApiConsumer.ApiClientContainer.AgendaService.CreateAgendaAsync(request);
                    if(response == null)
                    {

                        resetForm();

                        new frmInformation("Erreur lors de lajour !").ShowDialog();
                        Log.Information($"Erreur durant la creation de agenda {response}");
                    }
               
                    Log.Debug($"{response}");


                    resetForm();

                        new frmInformation("L'ajout a ete effectue avec succes !").ShowDialog();
                        Log.Information("Agenda ajouter avec succes.");
                    }
                    catch (Exception ex)
                    {
                        Log.Fatal($"Echec de l'action lors de l'ajout de l'agenda: {ex.Message} - {ex.Source}");
                    }
                
            }
            catch (Exception ex)
            {
                new frmInformation("Erreur durant la creation").ShowDialog();
                Log.Fatal($"Erreur generale lors de la tentative de creation: {ex.Message} {ex.InnerException}");
            }
        }



        private void resetForm()
        {
            txtTitreAgenda.Text = "";
            txtLieu.Text = "";
            txtHeureDebut.Text = "";
            txtHeureFin.Text = "";
            txtCrenneau.Text = "";
            txtDateAgenda.Value = DateTime.Now;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void heureDebutChanged(object sender, EventArgs e)
        {
            if (txtHeureDebut.Text.Length > 1)
            {
                txtHeureDebut.Text += ":";
            }else if (txtHeureDebut.Text.Length == 2)
            {

            }
        }

        private void heureFinChanged(object sender, EventArgs e)
        {
            if (txtHeureFin.Text.Length > 1)
            {
                txtHeureFin.Text += ":";
            }
            else if (txtHeureFin.Text.Length == 2)
            {

            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmMedAgenda_Load(object sender, EventArgs e)
        {

        }
    }
}
