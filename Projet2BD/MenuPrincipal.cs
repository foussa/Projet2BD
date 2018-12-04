using System;
using System.Linq;
using System.Windows.Forms;

namespace Projet2BD
{
    public partial class MenuPrincipal : Form
    {
        private int noEmploye;
        private int noTypeEmploye;
        private DataClasses1DataContext dataContext = new DataClasses1DataContext();

        public MenuPrincipal(int noEmploye, int noTypeEmploye)
        {
            InitializeComponent();
            this.noEmploye = noEmploye;
            this.noTypeEmploye = noTypeEmploye;
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            switch (noTypeEmploye)
            {
                case 1:
                    btnGererEmployes.Enabled = true;
                    btnAjouterAbonnement.Enabled = true;
                    btnRenouvellerAbonnement.Enabled = true;
                    btnMettreAJourAbonnes.Enabled = true;
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
                    btnMettreAJourAbonnes.Enabled = true;
                    btnModifierPrixEtDepensesObligatoires.Enabled = true;
                    btnInscrirePartie.Enabled = true;
                    btnVisualiserRapports.Enabled = true;
                    btnVisualiserStatistiques.Enabled = true;
                    break;
                case 4:
                    btnAjouterAbonnement.Enabled = true;
                    btnRenouvellerAbonnement.Enabled = true;
                    btnMettreAJourAbonnes.Enabled = true;
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
            new AjouterAbonnement().ShowDialog();
        }

        private void btnRenouvellerAbonnement_Click(object sender, EventArgs e)
        {
            if ((from abonnement in dataContext.Abonnements
                 where !abonnement.Reabonnements.Any()
                 where DateTime.Today > abonnement.DateAbonnement.AddYears(1)
                 select abonnement).Union(from abonnement in dataContext.Abonnements
                                          where abonnement.Reabonnements.Any()
                                          where abonnement.Reabonnements.All(reabonnement =>
                                          DateTime.Today > reabonnement.DateRenouvellement.AddYears(1))
                                          select abonnement).Any())
                new RenouvellerAbonnement().ShowDialog();
            else
                MessageBox.Show("Aucun abonnement ne peut être renouvelé.", "Renouvellement");
        }

        private void btnMettreAJourAbonnes_Click(object sender, EventArgs e)
        {
            if (dataContext.Abonnements.Any())
                new MettreAJourAbonnes().ShowDialog();
        }

        private void btnModifierPrixEtDepensesObligatoires_Click(object sender, EventArgs e)
        {
            if (dataContext.PrixDepensesAbonnements.
                     Max(prixDepensesAbonnement =>
                         prixDepensesAbonnement.Annee) < DateTime.Today.Year)
                new ModifierPrixEtDepensesObligatoires().ShowDialog();
            else
                MessageBox.Show("Les derniers prix et dépenses obligatoires ont été insérés " +
                                "cette année. Vous devez attendre l'année prochaine pour " +
                                "modifier ces montants.",
                                "Modification des prix et dépenses obligatoires");
        }

        private void btnInscrirePartie_Click(object sender, EventArgs e)
        {

        }

        private void btnInscrireDepense_Click(object sender, EventArgs e)
        {

        }

        private void btnVisualiserRapports_Click(object sender, EventArgs e)
        {
            new VisualiserRapports().ShowDialog();
        }

        private void btnVisualiserStatistiques_Click(object sender, EventArgs e)
        {
            new VisualiserStatistiques().ShowDialog();
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