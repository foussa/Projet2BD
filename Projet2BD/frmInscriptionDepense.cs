using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet2BD
{
    public partial class frmInscriptionDepense : Form
    {
        int intNoTypeEmploye = 5;
        int intNoEmploye = 9;
        String strTypeService;

        DataClasses1DataContext dataContext = new DataClasses1DataContext();
        public frmInscriptionDepense()
        {
            InitializeComponent();
        }

        private void frmInscriptionDepense_Load(object sender, EventArgs e)
        {
            noNomEtPrenomAbonneBindingSource.DataSource = from unAbonne in dataContext.Abonnements
                                                          select new
                                                          {
                                                              noAbonne = unAbonne.Id,
                                                              nomEtPrenomAbonne = unAbonne.Nom + ", " + unAbonne.Prenom
                                                          };
            //MessageBox.Show(noNomEtPrenomAbonneBindingSource.Count.ToString());
            if (noNomEtPrenomAbonneBindingSource.Count < 1)
            {
                btnInscriptionDepense.Enabled = false;
            }
            if (intNoTypeEmploye != 1 && intNoTypeEmploye != 2 && intNoTypeEmploye != 3)
            {
                lblService.Visible = false;
                tbService.Visible = false;
            }
            else
            {
                lblService.Visible = true;
                tbService.Visible = true;
            }
            if (intNoTypeEmploye == 5)
            {
                strTypeService = "Magasin Pro Shop";
            }
            else if (intNoTypeEmploye == 6)
            {
                strTypeService = "Restaurant";
            }
            else if (intNoTypeEmploye == 7)
            {
                strTypeService = "Leçon de golf";
            }

        }

        private void btnInscriptionDepense_Click(object sender, EventArgs e)
        {
            var toutesLesDepense = from uneDepense in dataContext.Depenses
                                   select uneDepense.No;
            int noDepense = toutesLesDepense.Max() + 1;

            if (intNoTypeEmploye == 5)
            {
                strTypeService = "Magasin Pro Shop";
            }
            else if (intNoTypeEmploye == 6)
            {
                strTypeService = "Restaurant";
            }
            else if (intNoTypeEmploye == 7)
            {
                strTypeService = "Leçon de golf";
            }
            else strTypeService = tbService.Text;


            var service = from unService in dataContext.Services
                          where unService.TypeService.Equals(strTypeService) && unService.NoEmploye.Equals(intNoEmploye)
                          select unService.No;

            var tousLesServices = from unService in dataContext.Services
                                  select unService.No;
            int noService = tousLesServices.Max() + 1;
            // MessageBox.Show("Nombre de service " + service.Count());
            if (service.Count() <= 0)
            {
                //   MessageBox.Show("Rien");
                Services insertionService = new Services
                {
                    No = noService,
                    TypeService = strTypeService,
                    Remarque = "",
                    NoEmploye = intNoEmploye
                };
                dataContext.Services.InsertOnSubmit(insertionService);

                // Submit the change to the database.
                try
                {
                    // MessageBox.Show("No service " + insertionService.No + "\nType service " + insertionService.TypeService + "\nRemarque " + insertionService.Remarque + "\nNo employé " + insertionService.NoEmploye);
                    dataContext.SubmitChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Impossible de modifier la base de données (Service)");
                }
            }


            int intNoServiceDepense = 0;
            foreach (int c in service)
            {
                intNoServiceDepense = c;
            }
            MessageBox.Show("noDepense  =  " + intNoServiceDepense);


            Depenses insertionDepense = new Depenses
            {
                Remarque = tbRemarque.Text,
                IdAbonnement = cbNomEtPrenomAbonne.SelectedValue.ToString(),
                DateDepense = DateTime.Now,
                Montant = nupMontant.Value,
                No = noDepense,
                NoService = intNoServiceDepense
            };
            dataContext.Depenses.InsertOnSubmit(insertionDepense);

            // Submit the change to the database.
            try
            {
                //   MessageBox.Show("No depense " + insertionDepense.No + "\nId abonnement " + insertionDepense.IdAbonnement + "\nRemarque " + insertionDepense.Remarque + "\nNo service " + insertionDepense.NoService);
                dataContext.SubmitChanges();
                MessageBox.Show("La dépense " + noDepense.ToString() + " a été ajoutée avec succès");
                depenseEtTouteSesInformationsDataGridView.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Impossible de modifier la base de données");
            }
            depenseEtTouteSesInformationsBindingSource.DataSource = from uneDepense in dataContext.Depenses
                                                                    join unService in dataContext.Services on uneDepense.NoService equals unService.No
                                                                    join unAbonnement in dataContext.Abonnements on uneDepense.IdAbonnement equals unAbonnement.Id
                                                                    join unEmploye in dataContext.Employes on unService.NoEmploye equals unEmploye.No
                                                                    join unTypeAbonnement in dataContext.TypesAbonnement on unAbonnement.NoTypeAbonnement equals unTypeAbonnement.No
                                                                    join unPrixDepensesAbonnements in dataContext.PrixDepensesAbonnements on unTypeAbonnement.No equals unPrixDepensesAbonnements.NoTypeAbonnement
                                                                    where uneDepense.No.Equals(noDepense)
                                                                    select new
                                                                    {
                                                                        strNomCompletAbonne = unAbonnement.Nom + ", " + unAbonnement.Prenom,
                                                                        strDateDepense = uneDepense.DateDepense.ToShortDateString(),
                                                                        dcmMontant = uneDepense.Montant,
                                                                        strTypeService = unService.TypeService,
                                                                        strNomCompletEmploye = unEmploye.Nom + ", " + unEmploye.Prenom,
                                                                        dcmMontantDesDepenses = unPrixDepensesAbonnements.Prix,
                                                                        dcmMontantObligatoire = unPrixDepensesAbonnements.DepensesObligatoires
                                                                    };



        }
    }
}
