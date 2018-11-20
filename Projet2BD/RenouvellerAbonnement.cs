using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Projet2BD
{
    public partial class RenouvellerAbonnement : Form
    {
        private DataClasses1DataContext dataContext = new DataClasses1DataContext();

        public RenouvellerAbonnement()
        {
            InitializeComponent();
        }

        private void RenouvellerAbonnement_Load(object sender, EventArgs e)
        {           
            abonnementsBindingSource.DataSource =
                (from abonnement in dataContext.Abonnements
                 where !abonnement.Reabonnements.Any()
                 where DateTime.Today > abonnement.DateAbonnement.AddYears(1)
                 select abonnement).Union(from abonnement in dataContext.Abonnements
                                          where abonnement.Reabonnements.Any()
                                          where abonnement.Reabonnements.All(reabonnement =>
                                          DateTime.Today > reabonnement.DateRenouvellement.AddYears(1))
                                          select abonnement);
        }

        private void btnRenouvellerAbonnement_Click(object sender, EventArgs e)
        {
            Reabonnements reabonnement = new Reabonnements();
            reabonnement.IdAbonnement = ddlAbonnements.SelectedValue.ToString();
            reabonnement.DateRenouvellement = DateTime.Today;
            if (!string.IsNullOrEmpty(tbRemarque.Text.Trim())) reabonnement.Remarque = tbRemarque.Text.Trim();

            dataContext.Reabonnements.InsertOnSubmit(reabonnement);
            dataContext.SubmitChanges();

            MessageBox.Show("L'abonnement a été renouvellé.", "Renouvellement");
        }
    }
}