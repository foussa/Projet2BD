using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Projet2BD
{
    public partial class SaisieDependant : UserControl
    {
        private int typeLien;

        public SaisieDependant(int left, int top, int typeLien)
        {
            InitializeComponent();
            Left = left;
            Top = top;
            this.typeLien = typeLien;
        }

        public Dependants creerDependant(string idAbonnement)
        {
            Dependants dependant = new Dependants();
            dependant.Id = idAbonnement.Substring(0, idAbonnement.Length - 1) + ((typeLien == 0) ? $"{ddlSexes.SelectedValue}0" : $"E{typeLien}");
            dependant.Nom = tbNom.Text.Trim();
            dependant.Prenom = tbPrenom.Text.Trim();
            dependant.Sexe = ddlSexes.SelectedValue.ToString();
            dependant.DateNaissance = dtpDateNaissance.Value.Date;
            dependant.IdAbonnement = idAbonnement;
            if (!string.IsNullOrEmpty(tbRemarque.Text.Trim())) dependant.Remarque = tbRemarque.Text.Trim();

            return dependant;
        }

        private void SaisieDependant_Load(object sender, EventArgs e)
        {
            if (typeLien == 0) lblDependant.Text = "Conjoint";
            else lblDependant.Text = $"Enfant {typeLien}";

            List<Sexe> sexes = new List<Sexe>();
            sexes.Add(new Sexe("H", "Homme"));
            sexes.Add(new Sexe("F", "Femme"));

            sexeBindingSource.DataSource = sexes;
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

            if (typeLien == 0)
            {
                if (age < 18)
                {
                    errMessage.SetError(dtpDateNaissance, "Le conjoint doit être âgé de 18 ans ou plus");
                    e.Cancel = true;
                }
            }
            else
            {
                if (age < 1 && age > 17)
                {
                    errMessage.SetError(dtpDateNaissance, "Chaque enfant doit avoir moins que 18 ans (mais plus que 0 ans)");
                    e.Cancel = true;
                }
            }
        }

        private void dtpDateNaissance_Validated(object sender, EventArgs e)
        {
            errMessage.SetError(dtpDateNaissance, string.Empty);
        }
    }
}