using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Projet2BD
{
    public partial class VisualiserStatistiques : Form
    {
        private DataClasses1DataContext dataContext = new DataClasses1DataContext();

        public VisualiserStatistiques()
        {
            InitializeComponent();
        }

        private void VisualiserStatistiques_Load(object sender, EventArgs e)
        {
            TypeAbonnementAnneeNbAbonnementBindingSource.DataSource =
                from typeAbonnement in dataContext.TypesAbonnement
                from annee
                    in dataContext.Abonnements.Select(abonnement =>
                                                      abonnement.DateAbonnement.Year).Distinct()
                select new TypeAbonnementAnneeNbAbonnements
                {
                    no = typeAbonnement.No,
                    description = typeAbonnement.Description,
                    annee = annee,
                    nbAbonnements =
                        typeAbonnement.Abonnements.
                            Where(abonnement =>
                                  abonnement.DateAbonnement.Year == annee).Count()
                };
            TypeAbonnementMoisNbAbonnementsBindingSource.DataSource =
                from typeAbonnement in dataContext.TypesAbonnement.AsEnumerable()
                from mois in Enumerable.Range(1, 12)
                select new TypeAbonnementMoisNbAbonnements
                {
                    no = typeAbonnement.No,
                    description = typeAbonnement.Description,
                    mois = mois,
                    nbAbonnements =
                        typeAbonnement.Abonnements.
                            Where(abonnement =>
                                  abonnement.DateAbonnement.Year == DateTime.Today.Year &&
                                  abonnement.DateAbonnement.Month == mois).Count()
                };
            TerrainAnneeNbPartiesJoueesBindingSource.DataSource =
                from terrain in dataContext.Terrains
                from annee
                    in dataContext.PartiesJouees.Select(partieJouee =>
                                                        partieJouee.DatePartie.Year).Distinct()
                select new TerrainAnneeNbPartiesJouees
                {
                    no = terrain.No,
                    nom = terrain.Nom,
                    annee = annee,
                    nbPartiesJouees =
                        terrain.PartiesJouees.Where(partieJouee =>
                                                    partieJouee.DatePartie.Year == annee).Count()
                };
            TerrainMoisNbPartiesJoueesBindingSource.DataSource =
                from terrain in dataContext.Terrains.AsEnumerable()
                from mois in Enumerable.Range(1, 12)
                select new TerrainMoisNbPartiesJouees
                {
                    no = terrain.No,
                    nom = terrain.Nom,
                    mois = mois,
                    nbPartiesJouees =
                        terrain.PartiesJouees.
                            Where(partieJouee =>
                                  partieJouee.DatePartie.Year == DateTime.Today.Year &&
                                  partieJouee.DatePartie.Month == mois).Count()
                };
            AbonnementAnneeSumDepensesBindingSource.DataSource =
                from abonnement in dataContext.Abonnements
                from annee
                    in dataContext.Depenses.Select(depense => depense.DateDepense.Year).Distinct()
                select new AbonnementAnneeSumDepenses
                {
                    no = int.Parse(Regex.Match(abonnement.Id, "\\d+").Value),
                    idEtNomComplet = abonnement.IdEtNomComplet,
                    annee = annee,
                    sumDepenses =
                        abonnement.Depenses.Where(depense =>
                                                  depense.DateDepense.Year == annee).Any() ?
                                                  abonnement.Depenses.
                                                      Where(depense =>
                                                            depense.DateDepense.Year == annee).
                                                                Sum(depense => depense.Montant) :
                                                  0
                };
            AbonnementMoisSumDepensesBindingSource.DataSource =
                from abonnement in dataContext.Abonnements.AsEnumerable()
                from mois in Enumerable.Range(1, 12)
                select new AbonnementMoisSumDepenses
                {
                    no = int.Parse(Regex.Match(abonnement.Id, "\\d+").Value),
                    idEtNomComplet = abonnement.IdEtNomComplet,
                    mois = mois,
                    sumDepenses =
                        abonnement.Depenses.
                            Where(depense =>
                                  depense.DateDepense.Year ==
                                  DateTime.Today.Year &&
                                  depense.DateDepense.Month == mois).Any() ?
                                  abonnement.Depenses.Where(depense =>
                                                            depense.DateDepense.Year ==
                                                            DateTime.Today.Year &&
                                                            depense.DateDepense.Month == mois).
                                                                Sum(depense => depense.Montant) :
                                  0
                };
            reportViewer1.RefreshReport();
            reportViewer2.RefreshReport();
            reportViewer3.RefreshReport();
            reportViewer4.RefreshReport();
            reportViewer5.RefreshReport();
            reportViewer6.RefreshReport();
        }
    }
}