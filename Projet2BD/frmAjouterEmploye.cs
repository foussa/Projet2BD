using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace Projet2BD
{
    public partial class frmAjouterEmploye : Form
    {
        public frmAjouterEmploye()
        {
            InitializeComponent();
        }

        public bool IsEmailValid(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            var exprCodePostal = new Regex("^[A-Za-z][0-9][A-Za-z] ?[0-9][A-Za-z][0-9]$");
            var exprTel = new Regex(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$");

            if (tbMDP.Text == "") errMessage.SetError(tbMDP, "Le mot de passe ne peut être vide");
            else errMessage.SetError(tbMDP, "");

            if (tbNom.Text == "") errMessage.SetError(tbNom, "Le nom ne peut être vide");
            else errMessage.SetError(tbNom, "");

            if (tbPrenom.Text == "") errMessage.SetError(tbPrenom, "Le prénom ne peut être vide");
            else errMessage.SetError(tbPrenom, "");

            if (!exprCodePostal.IsMatch(tbCodePostal.Text)) errMessage.SetError(tbCodePostal, "Le code postal n'est pas dans un format valide");
            else errMessage.SetError(tbCodePostal, "");

            if (!exprTel.IsMatch(tbTel.Text)) errMessage.SetError(tbTel, "Le téléphonne n'est pas dans un format valide");
            else errMessage.SetError(tbTel, "");

            if (!exprTel.IsMatch(tbCel.Text)) errMessage.SetError(tbCel, "Le céllulaire n'est pas dans un format valide");
            else errMessage.SetError(tbCel, "");

            if (cbTypeEmp.SelectedValue.ToString() == "1") errMessage.SetError(cbTypeEmp, "On ne peut ajouter un administrateur (un seul administrateur pour le système)");
            else errMessage.SetError(cbTypeEmp, "");


            MessageBox.Show("Toutes les données sont bonnes");
        }

        private void provincesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.provincesBindingSource.EndEdit();

        }

        private void frmAjouterEmploye_Load(object sender, EventArgs e)
        {

        }
    }
}
