using Serilog;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1.config
{
    /// <summary>
    /// Une classe utilitaire pour gérer la navigation MDI (ouverture et fermeture de formulaires enfants)
    /// dans un formulaire parent MDI, incluant la journalisation des actions avec Serilog.
    /// </summary>
    class CustomNavigatorMdi
    {
        /// <summary>
        /// Ferme tous les formulaires enfants actuellement ouverts dans le formulaire parent MDI spécifié.
        /// Cette fonction est utile pour passer d'une vue à l'autre ou réinitialiser l'interface utilisateur.
        /// </summary>
        /// <param name="mdiParent">Le formulaire parent MDI contenant les formulaires enfants à fermer.</param>
        public static void fermer(Form mdiParent)
        {
            Log.Information("Fermeture de tous les formulaires enfants.");

            Form[] charr = mdiParent.MdiChildren;
            foreach (Form f in charr)
            {
                f.Close();
            }
        }

        /// <summary>
        /// Ouvre un formulaire enfant dans un parent MDI tout en désactivant un bouton spécifique.
        /// Ferme tous les autres formulaires enfants ouverts et ajuste l'état de la fenêtre du formulaire enfant.
        /// </summary>
        /// <param name="mdiParent">Le formulaire parent MDI dans lequel ouvrir le formulaire enfant.</param>
        /// <param name="buttonToDisable">Le bouton qui sera désactivé pendant l'ouverture du formulaire enfant.</param>
        /// <param name="mdiChild">Le formulaire enfant à ouvrir.</param>
        public static void push(Form mdiParent, Button buttonToDisable, Form mdiChild)
        {
            buttonToDisable.Enabled = false;

            fermer(mdiParent);

            mdiChild.MdiParent = mdiParent;

            mdiChild.Show();
            mdiChild.WindowState = FormWindowState.Maximized;

            mdiChild.FormClosed += (s, args) =>
            {
                buttonToDisable.Enabled = true;
            };

            Log.Information("Formulaire enfant '{0}' ouvert dans le parent MDI.", mdiChild.Name);
        }
    }
}
