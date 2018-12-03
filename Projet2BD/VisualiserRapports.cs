using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Projet2BD
{
    public partial class VisualiserRapports : Form
    {
        private DataClasses1DataContext dataContext = new DataClasses1DataContext();

        public VisualiserRapports()
        {
            InitializeComponent();
        }

        private void VisualiserRapports_Load(object sender, EventArgs e)
        { 
            DepenseBindingSource.DataSource =
                from depense in dataContext.Depenses
                select new Depense
                {
                    montant = depense.Montant,
                    date = depense.DateDepense,
                    typeService = depense.Services.TypeService,
                    nomCompletEmploye = depense.Services.Employes.Prenom + " " +
                                        depense.Services.Employes.Nom,
                    nomCompletAbonne = depense.Abonnements.Prenom + " " + depense.Abonnements.Nom,
                    annee = depense.DateDepense.Year
                };
            PartieJoueeBindingSource.DataSource =
                from partieJouee in dataContext.PartiesJouees
                select new PartieJouee
                {
                    pointage = partieJouee.Pointage,
                    date = partieJouee.DatePartie,
                    nomTerrain = partieJouee.Terrains.Nom,
                    nomCompletAbonne = partieJouee.Abonnements.Prenom + " " +
                                       partieJouee.Abonnements.Nom,
                    annee = partieJouee.DatePartie.Year
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