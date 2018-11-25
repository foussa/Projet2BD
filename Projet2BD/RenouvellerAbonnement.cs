using System;
using System.Data;
using System.Data.SqlClient;
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

            try
            {
                dataContext.SubmitChanges();
                MessageBox.Show("Le réabonnement a été enregistré dans la base de données.", "Enregistrement des données");
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                    MessageBox.Show("Le réabonnement existe déjà dans la base de données.", "Erreur lors de l'enregistrement des données");
                else
                    MessageBox.Show(ex.Message, "Erreur lors de l'enregistrement des données");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur lors de l'enregistrement des données");
            }

            Close();
        }
    }
}