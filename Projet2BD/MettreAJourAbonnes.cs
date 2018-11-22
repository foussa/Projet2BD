using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Projet2BD
{
    public partial class MettreAJourAbonnes : Form
    {
        private DataClasses1DataContext dataContext = new DataClasses1DataContext();

        public MettreAJourAbonnes()
        {
            InitializeComponent();
        }

        private void MettreAJourAbonnes_Load(object sender, EventArgs e)
        {
            List<Sexe> sexes = new List<Sexe>();
            sexes.Add(new Sexe("H", "Homme"));
            sexes.Add(new Sexe("F", "Femme"));

            sexeBindingSource.DataSource = sexes;
            provincesBindingSource.DataSource = dataContext.Provinces;
            typesAbonnementBindingSource.DataSource = dataContext.TypesAbonnement;
            abonnementsBindingSource.DataSource = dataContext.Abonnements;
        }

        private void dgAbonnes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null)
            {
                if (dgAbonnes.Columns[e.ColumnIndex].Name == "tbCodePostal_dgAbonnes")
                {
                    e.Value = e.Value.ToString().Insert(3, " ");
                    e.FormattingApplied = true;
                }
                else if (dgAbonnes.Columns[e.ColumnIndex].Name == "tbTelephone_dgAbonnes")
                {
                    e.Value = string.Format("({0}) {1}-{2}",
                                                e.Value.ToString().Substring(0, 3),
                                                e.Value.ToString().Substring(3, 3),
                                                e.Value.ToString().Substring(6, 4));
                    e.FormattingApplied = true;
                }
            }
        }

        private void dgAbonnes_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            dgAbonnes.Rows[e.RowIndex].ErrorText = "";

            if (dgAbonnes.Columns[e.ColumnIndex].Name == "tbCodePostal_dgAbonnes")
            {
                Regex exprCodePostal = new Regex("^[a-zA-Z]\\d[a-zA-Z] ?\\d[a-zA-Z]\\d$");
                if (!exprCodePostal.IsMatch(e.FormattedValue.ToString()))
                {
                    dgAbonnes.Rows[e.RowIndex].ErrorText = "Le code postal doit respecter le format @#@ #@# ou @#@#@#";
                    e.Cancel = true;
                }
            }
            else if (dgAbonnes.Columns[e.ColumnIndex].Name == "tbTelephone_dgAbonnes")
            {
                Regex exprTelephone = new Regex("^(\\(\\d{3}\\) \\d{3}-\\d{4}|\\d{3}-\\d{3}-\\d{4}|\\d{10})$");
                if (!exprTelephone.IsMatch(e.FormattedValue.ToString()))
                {
                    dgAbonnes.Rows[e.RowIndex].ErrorText = "Le téléphone doit respecter le format (###) ###-### ou ###-###-#### ou ##########";
                    e.Cancel = true;
                }
            }
        }

        private void dgAbonnes_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            if (e.Value != null)
            {
                if (dgAbonnes.Columns[e.ColumnIndex].Name == "tbCodePostal_dgAbonnes")
                {
                    if (e.Value.ToString().Count() == 6)
                    {
                        e.ParsingApplied = true;
                    }
                    else if (e.Value.ToString().Count() == 7)
                    {
                        e.Value = e.Value.ToString().Remove(3, 1);
                        e.ParsingApplied = true;
                    }
                }
                else if (dgAbonnes.Columns[e.ColumnIndex].Name == "tbTelephone_dgAbonnes")
                {
                    if (e.Value.ToString().Count() == 10)
                    {
                        e.ParsingApplied = true;
                    }
                    else if (e.Value.ToString().Count() == 12)
                    {
                        e.Value = e.Value.ToString().Remove(3, 1).Remove(6, 1);
                        e.ParsingApplied = true;
                    }
                    else if (e.Value.ToString().Count() == 14)
                    {
                        e.Value = e.Value.ToString().Remove(0, 1).Remove(3, 2).Remove(6, 1);
                        e.ParsingApplied = true;
                    }
                }
            }
        }

        private void dgAbonnes_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dgAbonnes.Rows[e.RowIndex].ErrorText = "";
        }
    }
}
