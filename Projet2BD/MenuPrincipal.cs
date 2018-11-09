using System;
using System.Windows.Forms;

namespace Projet2BD
{
    public partial class MenuPrincipal : Form
    {
        public int noEmploye;
        public int noTypeEmploye;

        DataClasses1DataContext dataContext = new DataClasses1DataContext();

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            switch (noTypeEmploye)
            {
                case 1:
                    btnGererEmployes.Enabled = true;
                    btnAjouterAbonnement.Enabled = true;
                    btnRenouvellerAbonnement.Enabled = true;
                    btnMettreAJourAbonnés.Enabled = true;
                    btnModifierPrixEtDepensesObligatoires.Enabled = true;
                    btnInscrirePartie.Enabled = true;
                    btnVisualiserRapports.Enabled = true;
                    btnVisualiserStatistiques.Enabled = true;
                    break;
                case 2:
                    btnGererEmployes.Enabled = true;
                    btnModifierPrixEtDepensesObligatoires.Enabled = true;
                    btnVisualiserRapports.Enabled = true;
                    btnVisualiserStatistiques.Enabled = true;
                    break;
                case 3:
                    btnAjouterAbonnement.Enabled = true;
                    btnRenouvellerAbonnement.Enabled = true;
                    btnMettreAJourAbonnés.Enabled = true;
                    btnModifierPrixEtDepensesObligatoires.Enabled = true;
                    btnInscrirePartie.Enabled = true;
                    btnVisualiserRapports.Enabled = true;
                    btnVisualiserStatistiques.Enabled = true;
                    break;
                case 4:
                    btnAjouterAbonnement.Enabled = true;
                    btnRenouvellerAbonnement.Enabled = true;
                    btnMettreAJourAbonnés.Enabled = true;
                    btnInscrirePartie.Enabled = true;
                    break;
                case 5:
                    btnGererEmployes.Enabled = false;
                    btnAjouterAbonnement.Enabled = false;
                    btnInscrirePartie.Enabled = true;
                    btnInscrireDepense.Enabled = true;
                    break;
                case 6:
                    btnGererEmployes.Enabled = false;
                    btnAjouterAbonnement.Enabled = false;
                    btnInscrirePartie.Enabled = true;
                    btnInscrireDepense.Enabled = true;
                    break;
                case 7:
                    btnGererEmployes.Enabled = false;
                    break;
            }
        }

        private void btnGererEmployes_Click(object sender, EventArgs e)
        {
            new GestionEmploye().ShowDialog();
        }

        private void btnAjouterAbonnement_Click(object sender, EventArgs e)
        {
            new Abonnement().ShowDialog();
        }

        private void btnRenouvellerAbonnement_Click(object sender, EventArgs e)
        {

        }

        private void btnMettreAJourAbonnés_Click(object sender, EventArgs e)
        {

        }

        private void btnModifierPrixEtDepensesObligatoires_Click(object sender, EventArgs e)
        {

        }

        private void btnInscrirePartie_Click(object sender, EventArgs e)
        {

        }

        private void btnInscrireDepense_Click(object sender, EventArgs e)
        {

        }

        private void btnVisualiserRapports_Click(object sender, EventArgs e)
        {

        }

        private void btnVisualiserStatistiques_Click(object sender, EventArgs e)
        {

        }

        private void btnDeconnecter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Program.quitter = true;
            Close();
        }
    }
}