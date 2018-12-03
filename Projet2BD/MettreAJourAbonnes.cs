using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Transactions;
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
            dependantsBindingSource.DataSource =
                ((Abonnements)abonnementsBindingSource.Current).Dependants;
        }


        private void dgAbonnes_SelectionChanged(object sender, EventArgs e)
        {
            dependantsBindingSource.DataSource =
                ((Abonnements)abonnementsBindingSource.Current).Dependants;
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
                else if (dgAbonnes.Columns[e.ColumnIndex].Name == "tbCellulaire_dgAbonnes")
                {
                    e.Value = e.Value.ToString() != "" ?
                              string.Format("({0}) {1}-{2}",
                                            e.Value.ToString().Substring(0, 3),
                                            e.Value.ToString().Substring(3, 3),
                                            e.Value.ToString().Substring(6, 4)) :
                              e.Value.ToString();
                    e.FormattingApplied = true;
                }
            }
        }

        private void dgAbonnes_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            dgAbonnes.Rows[e.RowIndex].ErrorText = "";

            if (dgAbonnes.Columns[e.ColumnIndex].Name == "tbPrenom_dgAbonnes")
            {
                if (string.IsNullOrEmpty(e.FormattedValue.ToString().Trim()))
                {
                    dgAbonnes.Rows[e.RowIndex].ErrorText = "Le prénom ne peut pas être vide";
                    e.Cancel = true;
                }
                else if (!Regex.IsMatch(e.FormattedValue.ToString().Trim(),
                                        "^\\p{L}+(([-' ]\\p{L})|\\p{L})*$"))
                {
                    dgAbonnes.Rows[e.RowIndex].ErrorText =
                        "Le prénom doit débuter par une lettre suivi d'un tiret, apostrophe, " +
                        "espace ou lettre et se terminer par une lettre";
                    e.Cancel = true;
                }
            }
            else if (dgAbonnes.Columns[e.ColumnIndex].Name == "tbNoCivique_dgAbonnes")
            {
                if (string.IsNullOrEmpty(e.FormattedValue.ToString().Trim()))
                {
                    dgAbonnes.Rows[e.RowIndex].ErrorText =
                        "Le numéro civique ne peut pas être vide";
                    e.Cancel = true;
                }
                else
                {
                    try
                    {
                        int.Parse(e.FormattedValue.ToString().Trim());
                    }
                    catch
                    {
                        dgAbonnes.Rows[e.RowIndex].ErrorText =
                            "Le numéro civique doit être un nombre entier";
                        e.Cancel = true;
                    }
                }
            }
            else if (dgAbonnes.Columns[e.ColumnIndex].Name == "tbRue_dgAbonnes")
            {
                if (string.IsNullOrEmpty(e.FormattedValue.ToString().Trim()))
                {
                    dgAbonnes.Rows[e.RowIndex].ErrorText = "La rue ne peut pas être vide";
                    e.Cancel = true;
                }
                else if (!Regex.IsMatch(e.FormattedValue.ToString().Trim(),
                                        "^(\\d{1,3}(e|th) )?\\p{L}+(([-' ]\\p{L})|\\p{L})*$"))
                {
                    dgAbonnes.Rows[e.RowIndex].ErrorText =
                        "La rue doit débuter par une lettre suivi d'un tiret, apostrophe, " +
                        "espace ou lettre et se terminer par une lettre";
                    e.Cancel = true;
                }
            }
            else if (dgAbonnes.Columns[e.ColumnIndex].Name == "tbVille_dgAbonnes")
            {
                if (string.IsNullOrEmpty(e.FormattedValue.ToString().Trim()))
                {
                    dgAbonnes.Rows[e.RowIndex].ErrorText = "La ville ne peut pas être vide";
                    e.Cancel = true;
                }
                else if (!Regex.IsMatch(e.FormattedValue.ToString().Trim(),
                                        "^\\p{L}+(([-' ]\\p{L})|\\p{L})*$"))
                {
                    dgAbonnes.Rows[e.RowIndex].ErrorText =
                        "La ville doit débuter par une lettre suivi d'un tiret, apostrophe, " +
                        "espace ou lettre et se terminer par une lettre";
                    e.Cancel = true;
                }
            }
            else if (dgAbonnes.Columns[e.ColumnIndex].Name == "tbCodePostal_dgAbonnes")
            {
                if (string.IsNullOrEmpty(e.FormattedValue.ToString().Trim()))
                {
                    dgAbonnes.Rows[e.RowIndex].ErrorText = "Le code postal ne peut pas être vide";
                    e.Cancel = true;
                }
                else if (!Regex.IsMatch(e.FormattedValue.ToString().Trim(),
                                        "^[a-zA-Z]\\d[a-zA-Z] ?\\d[a-zA-Z]\\d$"))
                {
                    dgAbonnes.Rows[e.RowIndex].ErrorText =
                        "Le code postal doit respecter le format @#@ #@# ou @#@#@#";
                    e.Cancel = true;
                }
            }
            else if (dgAbonnes.Columns[e.ColumnIndex].Name == "tbTelephone_dgAbonnes")
            {
                if (string.IsNullOrEmpty(e.FormattedValue.ToString().Trim()))
                {
                    dgAbonnes.Rows[e.RowIndex].ErrorText = "Le téléphone ne peut pas être vide";
                    e.Cancel = true;
                }
                else if (!Regex.IsMatch(e.FormattedValue.ToString().Trim(),
                                        "^(\\(\\d{3}\\) ?\\d{3}-\\d{4}|\\d{3}-\\d{3}-\\d{4}|" +
                                        "\\d{10})$"))
                {
                    dgAbonnes.Rows[e.RowIndex].ErrorText =
                        "Le téléphone doit respecter le format (###) ###-### ou (###)###-### " +
                        "ou ###-###-#### ou ##########";
                    e.Cancel = true;
                }
            }
            else if (dgAbonnes.Columns[e.ColumnIndex].Name == "tbCellulaire_dgAbonnes")
            {
                if (!string.IsNullOrEmpty(e.FormattedValue.ToString().Trim()))
                {
                    if (!Regex.IsMatch(e.FormattedValue.ToString().Trim(),
                                       "^(\\(\\d{3}\\) ?\\d{3}-\\d{4}|\\d{3}-\\d{3}-\\d{4}|" +
                                       "\\d{10})$"))
                    {
                        dgAbonnes.Rows[e.RowIndex].ErrorText =
                            "Le cellulaire doit respecter le format (###) ###-### " +
                            "ou (###)###-### ou ###-###-#### ou ##########";
                        e.Cancel = true;
                    }
                }
            }
            else if (dgAbonnes.Columns[e.ColumnIndex].Name == "tbCourriel_dgAbonnes")
            {
                try
                {
                    new MailAddress(e.FormattedValue.ToString().Trim());
                }
                catch (ArgumentException)
                {
                    dgAbonnes.Rows[e.RowIndex].ErrorText = "Le courriel ne peut pas être vide";
                    e.Cancel = true;
                }
                catch (FormatException)
                {
                    dgAbonnes.Rows[e.RowIndex].ErrorText =
                        "Le courriel n'est pas dans un format valide";
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
                else if (dgAbonnes.Columns[e.ColumnIndex].Name == "tbTelephone_dgAbonnes" ||
                         dgAbonnes.Columns[e.ColumnIndex].Name == "tbCellulaire_dgAbonnes")
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
                    else if (e.Value.ToString().Count() == 13)
                    {
                        e.Value = e.Value.ToString().Remove(0, 1).Remove(3, 1).Remove(6, 1);
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

        private void dgDependants_CellValidating(object sender,
                                                 DataGridViewCellValidatingEventArgs e)
        {
            dgAbonnes.Rows[e.RowIndex].ErrorText = "";

            if (dgAbonnes.Columns[e.ColumnIndex].Name == "tbPrenom_dgDependants")
            {
                if (string.IsNullOrEmpty(e.FormattedValue.ToString().Trim()))
                {
                    dgAbonnes.Rows[e.RowIndex].ErrorText = "Le prénom ne peut pas être vide";
                    e.Cancel = true;
                }
                else if (!Regex.IsMatch(e.FormattedValue.ToString().Trim(),
                                        "^\\p{L}+(([-' ]\\p{L})|\\p{L})*$"))
                {
                    dgAbonnes.Rows[e.RowIndex].ErrorText =
                        "Le prénom doit débuter par une lettre suivi d'un tiret, apostrophe, " +
                        "espace ou lettre et se terminer par une lettre";
                    e.Cancel = true;
                }
            }
            else if (dgAbonnes.Columns[e.ColumnIndex].Name == "tbNom_dgDependants")
            {
                if (string.IsNullOrEmpty(e.FormattedValue.ToString().Trim()))
                {
                    dgAbonnes.Rows[e.RowIndex].ErrorText = "Le nom ne peut pas être vide";
                    e.Cancel = true;
                }
                else if (!Regex.IsMatch(e.FormattedValue.ToString().Trim(),
                                        "^\\p{L}+(([-' ]\\p{L})|\\p{L})*$"))
                {
                    dgAbonnes.Rows[e.RowIndex].ErrorText =
                        "Le nom doit débuter par une lettre suivi d'un tiret, apostrophe, " +
                        "espace ou lettre et se terminer par une lettre";
                    e.Cancel = true;
                }
            }
        }

        private void dgDependants_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dgDependants.Rows[e.RowIndex].ErrorText = "";
        }

        private void btnMettreAJourAbonnes_Click(object sender, EventArgs e)
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                try
                {
                    dataContext.SubmitChanges(ConflictMode.ContinueOnConflict);
                    transaction.Complete();
                    MessageBox.Show("Les modifications ont été enregistrés " +
                                    "dans la base de données.", "Enregistrement des données");
                }
                catch (ChangeConflictException)
                {
                    dataContext.ChangeConflicts.ResolveAll(RefreshMode.KeepChanges);
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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur lors de l'enregistrement des données");
                }
            }
        }
    }
}