﻿using System;
using System.Data;
using System.Linq;
using System.Transactions;
using System.Windows.Forms;

namespace Projet2BD
{
    public partial class ModifierPrixEtDepensesObligatoires : Form
    {
        private DataClasses1DataContext dataContext = new DataClasses1DataContext();

        public ModifierPrixEtDepensesObligatoires()
        {
            InitializeComponent();
        }

        private void ModifierPrixEtDepensesObligatoires_Load(object sender, EventArgs e)
        {
            typesAbonnementBindingSource.DataSource = dataContext.TypesAbonnement;

            prixDepensesAbonnementsBindingSource.DataSource =
                from typeAbonnement in dataContext.TypesAbonnement.AsEnumerable()
                let anneeDerniersPrixDepensesAbonnements =
                    typeAbonnement.PrixDepensesAbonnements.Max(prixDepensesAbonnement =>
                                                               prixDepensesAbonnement.Annee)
                let prixDepensesAbonnement =
                    typeAbonnement.PrixDepensesAbonnements.
                        Where(prixDepensesAbonnement =>
                              prixDepensesAbonnement.Annee ==
                              anneeDerniersPrixDepensesAbonnements).Single()
                select new PrixDepensesAbonnements
                {
                    NoTypeAbonnement = prixDepensesAbonnement.NoTypeAbonnement,
                    Annee = DateTime.Today.Year,
                    Prix = prixDepensesAbonnement.Prix,
                    DepensesObligatoires = prixDepensesAbonnement.DepensesObligatoires,
                    TypesAbonnement = typeAbonnement
                };
        }

        private void dgPrixDepensesAbonnements_CellValidating(object sender,
            DataGridViewCellValidatingEventArgs e)
        {
            dgPrixDepensesAbonnements.Rows[e.RowIndex].ErrorText = "";

            if (dgPrixDepensesAbonnements.Columns[e.ColumnIndex].Name ==
                "tbPrix_PrixDepensesAbonnements")
            {
                if (string.IsNullOrEmpty(e.FormattedValue.ToString().Trim()))
                {
                    dgPrixDepensesAbonnements.Rows[e.RowIndex].ErrorText =
                        "Le prix de l'abonnement ne peut pas être vide";
                    e.Cancel = true;
                }
                else
                {
                    try
                    {
                        decimal.Parse(e.FormattedValue.ToString().Trim());
                    }
                    catch
                    {
                        dgPrixDepensesAbonnements.Rows[e.RowIndex].ErrorText =
                            "Le montant des dépenses obligatoires d'abonnement doit être un " +
                            "nombre";
                        e.Cancel = true;
                    }
                }
            }
            else if (dgPrixDepensesAbonnements.Columns[e.ColumnIndex].Name ==
                "tbDepensesObligatoires_PrixDepensesAbonnements")
            {
                if (string.IsNullOrEmpty(e.FormattedValue.ToString().Trim()))
                {
                    dgPrixDepensesAbonnements.Rows[e.RowIndex].ErrorText =
                        "Le montant des dépenses obligatoires d'abonnement ne peut pas être vide";
                    e.Cancel = true;
                }
                else
                {
                    try
                    {
                        decimal.Parse(e.FormattedValue.ToString().Trim());
                    }
                    catch
                    {
                        dgPrixDepensesAbonnements.Rows[e.RowIndex].ErrorText =
                            "Le montant des dépenses obligatoires d'abonnement doit être un " +
                            "nombre";
                        e.Cancel = true;
                    }
                }
            }
        }

        private void dgPrixDepensesAbonnements_CellEndEdit(object sender,
            DataGridViewCellEventArgs e)
        {
            dgPrixDepensesAbonnements.Rows[e.RowIndex].ErrorText = "";
        }

        private void btnModifierPrixEtDepensesObligatoires_Click(object sender, EventArgs e)
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                try
                {
                    dataContext.SubmitChanges();
                    transaction.Complete();
                    MessageBox.Show("Les modifications ont été enregistrés " +
                                    "dans la base de données.", "Enregistrement des données");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur lors de l'enregistrement des données");
                }
            }

            Close();
        }
    }
}