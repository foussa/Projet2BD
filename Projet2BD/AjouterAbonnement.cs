using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Transactions;
using System.Windows.Forms;

namespace Projet2BD
{
    public partial class AjouterAbonnement : Form
    {
        private List<Control> lstControlesDynamiques = new List<Control>();
        private DataClasses1DataContext dataContext = new DataClasses1DataContext();

        public AjouterAbonnement()
        {
            InitializeComponent();
        }

        private void Abonnement_Load(object sender, EventArgs e)
        {
            ClientSize = new Size(368, 468);

            List<Sexe> sexes = new List<Sexe>();
            sexes.Add(new Sexe("H", "Homme"));
            sexes.Add(new Sexe("F", "Femme"));

            sexeBindingSource.DataSource = sexes;
            provincesBindingSource.DataSource = dataContext.Provinces;
            typesAbonnementBindingSource.DataSource = dataContext.TypesAbonnement;
        }

        private void ddlTypesAbonnement_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Control controle in lstControlesDynamiques)
            {
                Controls.Remove(controle);
                controle.Dispose();
            }

            lstControlesDynamiques.RemoveAll(controle => !Controls.Contains(controle));

            switch (ddlTypesAbonnement.SelectedValue)
            {
                case 1:
                case 2:
                    lblRemarque.Top = 352;
                    tbRemarque.Top = 349;
                    btnAjouterAbonnement.Location = new Point(113, 414);

                    ClientSize = new Size(368, 468);

                    break;
                case 3:
                    lblRemarque.Top = 352;
                    tbRemarque.Top = 349;
                    btnAjouterAbonnement.Location = new Point(281, 414);

                    lstControlesDynamiques.Add(new SaisieDependant(363, 20, 0));

                    ClientSize = new Size(704, 468);

                    break;
                case 4:
                    lblRemarque.Top = 352;
                    tbRemarque.Top = 349;
                    btnAjouterAbonnement.Location = new Point(281, 414);

                    lstControlesDynamiques.Add(new SaisieDependant(363, 20, 0));
                    lstControlesDynamiques.Add(new SaisieDependant(363, 223, 1));

                    ClientSize = new Size(704, 468);

                    break;
                case 5:
                    lblRemarque.Top = 352;
                    tbRemarque.Top = 349;
                    btnAjouterAbonnement.Location = new Point(449, 414);

                    lstControlesDynamiques.Add(new SaisieDependant(363, 20, 0));
                    lstControlesDynamiques.Add(new SaisieDependant(699, 20, 1));
                    lstControlesDynamiques.Add(new SaisieDependant(363, 223, 2));

                    ClientSize = new Size(1040, 468);

                    break;
                case 6:
                    lblRemarque.Top = 378;
                    tbRemarque.Top = 375;
                    btnAjouterAbonnement.Location = new Point(617, 440);

                    NumericUpDown numNbEnfants = new NumericUpDown();
                    numNbEnfants.Name = "numNbEnfants";
                    numNbEnfants.Value = 3;
                    numNbEnfants.Minimum = 3;
                    numNbEnfants.Maximum = 9;
                    numNbEnfants.ValueChanged += new EventHandler(numNbEnfants_ValueChanged);
                    numNbEnfants.Size = new Size(50, 20);
                    numNbEnfants.Location = new Point(133, 349);

                    Label lblNbEnfants = new Label();
                    lblNbEnfants.Name = "lblNbEnfants";
                    lblNbEnfants.Text = "Nombre d\'enfants :";
                    lblNbEnfants.Location = new Point(30, 351);
                    lstControlesDynamiques.Add(lblNbEnfants);
                    lstControlesDynamiques.Add(numNbEnfants);
                    lstControlesDynamiques.Add(new SaisieDependant(363, 20, 0));
                    lstControlesDynamiques.Add(new SaisieDependant(699, 20, 1));
                    lstControlesDynamiques.Add(new SaisieDependant(1035, 20, 2));
                    lstControlesDynamiques.Add(new SaisieDependant(363, 249, 3));

                    ClientSize = new Size(1376, 494);

                    break;
            }

            foreach (Control controle in lstControlesDynamiques)
                Controls.Add(controle);
        }

        private void numNbEnfants_ValueChanged(object sender, EventArgs e)
        {
            foreach (Control controle in lstControlesDynamiques)
            {
                if (controle is SaisieDependant)
                {
                    Controls.Remove(controle);
                    controle.Dispose();
                }
            }

            lstControlesDynamiques.RemoveAll(controle => !Controls.Contains(controle));

            decimal nbEnfants = ((NumericUpDown)Controls.Find("numNbEnfants", false).Single()).Value;

            lstControlesDynamiques.Add(new SaisieDependant(363, 20, 0));
            lstControlesDynamiques.Add(new SaisieDependant(699, 20, 1));
            lstControlesDynamiques.Add(new SaisieDependant(1035, 20, 2));
            lstControlesDynamiques.Add(new SaisieDependant(363, 249, 3));

            if (nbEnfants > 3)
            {
                lstControlesDynamiques.Add(new SaisieDependant(699, 249, 4));

                if (nbEnfants > 4)
                {
                    lstControlesDynamiques.Add(new SaisieDependant(1035, 249, 5));

                    if (nbEnfants > 5)
                    {
                        btnAjouterAbonnement.Location = new Point(617, 669);

                        lstControlesDynamiques.Add(new SaisieDependant(20, 478, 6));

                        if (nbEnfants > 6)
                        {
                            lstControlesDynamiques.Add(new SaisieDependant(363, 478, 7));

                            if (nbEnfants > 7)
                            {
                                lstControlesDynamiques.Add(new SaisieDependant(699, 478, 8));

                                if (nbEnfants > 8)
                                    lstControlesDynamiques.Add(new SaisieDependant(1035, 478, 9));
                            }
                        }

                        ClientSize = new Size(1376, 723);
                    }
                    else
                    {
                        btnAjouterAbonnement.Location = new Point(617, 440);

                        ClientSize = new Size(1376, 494);
                    }
                }
            }
            else
                ClientSize = new Size(1376, 494);

            foreach (Control controle in lstControlesDynamiques)
                if (controle is SaisieDependant)
                    Controls.Add(controle);
        }

        private void tbPrenom_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbPrenom.Text.Trim()))
            {
                errMessage.SetError(tbPrenom, "Le prénom ne peut pas être vide");
                e.Cancel = true;
            }
        }

        private void tbPrenom_Validated(object sender, EventArgs e)
        {
            errMessage.SetError(tbPrenom, string.Empty);
        }

        private void tbNom_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbNom.Text.Trim()))
            {
                errMessage.SetError(tbNom, "Le nom ne peut pas être vide");
                e.Cancel = true;
            }
        }

        private void tbNom_Validated(object sender, EventArgs e)
        {
            errMessage.SetError(tbNom, string.Empty);
        }

        private void dtpDateNaissance_Validating(object sender, CancelEventArgs e)
        {
            DateTime dateActuelle = DateTime.Today;
            DateTime dateNaissance = dtpDateNaissance.Value.Date;
            int age = dateActuelle.Year - dateNaissance.Year;
            if (dateNaissance > dateActuelle.AddYears(-age)) age--;

            if ((int)ddlTypesAbonnement.SelectedValue == 2)
            {
                if (age < 60)
                {
                    errMessage.SetError(dtpDateNaissance, "L’âge minimum de l’abonné principal est de 60 ans pour les personnes de l’âge d’or");
                    e.Cancel = true;
                }
            }
            else
            {
                if (age < 18)
                {
                    errMessage.SetError(dtpDateNaissance, "L’âge minimum de l’abonné principal est de 18 ans");
                    e.Cancel = true;
                }
            }
        }

        private void dtpDateNaissance_Validated(object sender, EventArgs e)
        {
            errMessage.SetError(dtpDateNaissance, string.Empty);
        }

        private void tbRue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbRue.Text.Trim()))
            {
                errMessage.SetError(tbRue, "La rue ne peut pas être vide");
                e.Cancel = true;
            }
        }

        private void tbRue_Validated(object sender, EventArgs e)
        {
            errMessage.SetError(tbRue, string.Empty);
        }

        private void tbVille_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbVille.Text.Trim()))
            {
                errMessage.SetError(tbVille, "La ville ne peut pas être vide");
                e.Cancel = true;
            }
        }

        private void tbVille_Validated(object sender, EventArgs e)
        {
            errMessage.SetError(tbVille, string.Empty);
        }

        private void mtbCodePostal_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(mtbCodePostal.Text.Trim()))
            {
                errMessage.SetError(mtbCodePostal, "Le code postal ne peut pas être vide");
                e.Cancel = true;
            }
            else if (!mtbCodePostal.MaskCompleted)
            {
                errMessage.SetError(mtbCodePostal, "Le code postal doit respecter le format");
                e.Cancel = true;
            }
        }

        private void mtbCodePostal_Validated(object sender, EventArgs e)
        {
            errMessage.SetError(mtbCodePostal, string.Empty);
        }

        private void mtbTelephone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(mtbTelephone.Text.Trim('(', ')', '-', ' ')))
            {
                errMessage.SetError(mtbTelephone, "Le téléphone ne peut pas être vide");
                e.Cancel = true;
            }
            else if (!mtbTelephone.MaskCompleted)
            {
                errMessage.SetError(mtbTelephone, "Le téléphone doit respecter le format");
                e.Cancel = true;
            }
        }

        private void mtbTelephone_Validated(object sender, EventArgs e)
        {
            errMessage.SetError(mtbTelephone, string.Empty);
        }

        private void mtbCellulaire_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(mtbCellulaire.Text.Trim('(', ')', '-', ' ')) && !mtbCellulaire.MaskCompleted)
            {
                errMessage.SetError(mtbCellulaire, "Le cellulaire doit respecter le format");
                e.Cancel = true;
            }
        }

        private void mtbCellulaire_Validated(object sender, EventArgs e)
        {
            errMessage.SetError(mtbCellulaire, string.Empty);
        }

        private void tbCourriel_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                new MailAddress(tbCourriel.Text.Trim());
            }
            catch (ArgumentException)
            {
                errMessage.SetError(tbCourriel, "Le courriel ne peut pas être vide");
                e.Cancel = true;
            }
            catch (FormatException)
            {
                errMessage.SetError(tbCourriel, "Le courriel doit respecter le format");
                e.Cancel = true;
            }
        }

        private void tbCourriel_Validated(object sender, EventArgs e)
        {
            errMessage.SetError(tbCourriel, string.Empty);
        }

        private void btnAjouterAbonnement_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                Abonnements abonnement = new Abonnements();
                abonnement.Id = $"{tbNom.Text.Trim()}{dataContext.Abonnements.Count() + 1}P";
                abonnement.DateAbonnement = DateTime.Today;
                abonnement.Nom = tbNom.Text.Trim();
                abonnement.Prenom = tbPrenom.Text.Trim();
                abonnement.Sexe = ddlSexes.SelectedValue.ToString();
                abonnement.DateNaissance = dtpDateNaissance.Value.Date;
                abonnement.NoCivique = (int)numNoCivique.Value;
                abonnement.Rue = tbRue.Text.Trim();
                abonnement.Ville = tbVille.Text.Trim();
                abonnement.IdProvince = ddlProvinces.SelectedValue.ToString();
                abonnement.CodePostal = mtbCodePostal.Text.Remove(3, 1);
                abonnement.Telephone = new string(mtbTelephone.Text.Where(c => c != '(' && c != ')' && c != ' ' && c != '-').ToArray());
                if (mtbCellulaire.MaskCompleted)
                    abonnement.Cellulaire = new string(mtbCellulaire.Text.Where(c => c != '(' && c != ')' && c != ' ' && c != '-').ToArray());
                abonnement.Courriel = tbCourriel.Text.Trim();
                abonnement.NoTypeAbonnement = (int)ddlTypesAbonnement.SelectedValue;
                if (!string.IsNullOrEmpty(tbRemarque.Text.Trim())) abonnement.Remarque = tbRemarque.Text.Trim();

                foreach (Control controle in lstControlesDynamiques)
                    if (controle is SaisieDependant)
                        abonnement.Dependants.Add(((SaisieDependant)controle).creerDependant(abonnement.Id));

                using (TransactionScope transaction = new TransactionScope())
                {
                    try
                    {
                        dataContext.Abonnements.InsertOnSubmit(abonnement);
                        dataContext.SubmitChanges();
                        transaction.Complete();
                        MessageBox.Show("L'abonnement a été enregistré dans la base de données.", "Enregistrement");
                    }
                    catch
                    {
                        MessageBox.Show("Une erreur est survenue. L'abonnement n'a pas été enregistré dans la base de données.", "Enregistrement");
                    }
                }

                Close();
            }
        }
    }
}