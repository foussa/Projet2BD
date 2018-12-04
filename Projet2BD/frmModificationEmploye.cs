using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet2BD
{
    public partial class frmModificationEmploye : Form
    {
        int intNoEmp = 0;
        string strMDP = "";
        string strNom = "";
        string strPrenom = "";
        int intAge = 0;
        string strTel = "";
        string strCel = "";
        string strCodePostal = "";
        string strCourriel = "";
        string strRemarque = "";
        string strRue = "";
        string strProvince = "";
        int intNocivique = 0;
        decimal intSalaire = 0;
        string charSexe = "";
        string strVille = "";

        public static DataClasses1DataContext dataContext = new DataClasses1DataContext();
        public frmModificationEmploye()
        {
            InitializeComponent();
        }

        private void frmModificationEmploye_Load(object sender, EventArgs e)
        {
            idEtNomProvinceBindingSource.DataSource = from uneProvince in dataContext.Provinces
                                                      select new
                                                      {
                                                          idProvince = uneProvince.Id,
                                                          nomProvince = uneProvince.Nom
                                                      };


            // GestionEmploye fGestionEmploye = new GestionEmploye();
          //  MessageBox.Show(GestionEmploye.noEmploye);
            var employe = from unEmploye in dataContext.Employes
                          where unEmploye.No.Equals(GestionEmploye.noEmploye)
                          select unEmploye;



            foreach (var c in employe)
            {
                intNoEmp = c.No;
                strMDP = c.MotDePasse;
                strNom = c.Nom;
                strPrenom = c.Prenom;
                intAge = c.Age;
                strTel = c.Telephone;
                strCel = c.Cellulaire;
                strCodePostal = c.CodePostal;
                strCourriel = c.Courriel;
                strRemarque = c.Remarque;
                strRue = c.Rue;
                strProvince = c.Provinces.Id;
                intNocivique = c.NoCivique;
                intSalaire = c.SalaireHoraire;
                charSexe = c.Sexe;
                strVille = c.Ville;
            }





            tbMDP.Text = strMDP;
            tbNom.Text = strNom;
            tbPrenom.Text = strPrenom;
            nupAge.Value = intAge;
            tbCel.Text = strCel;
            tbCodePostal.Text = strCodePostal;
            tbCourriel.Text = strCourriel;
            tbRemarque.Text = strRemarque;
            tbTel.Text = strTel;
            tbRue.Text = strRue;
            cbProvince.SelectedValue = strProvince;
            nupNoCivique.Value = intNocivique;
            nupSalaire.Value = intSalaire;
            if (charSexe == "H") cbSexe.SelectedText = "Homme";
            else cbSexe.SelectedText = "Femme";
            tbVille.Text = strVille;


        }

        private void btnModification_Click(object sender, EventArgs e)
        {
            Boolean booOK = true;
            var exprCodePostal = new Regex(@"^[A-Za-z][0-9][A-Za-z] ?[0-9][A-Za-z][0-9]$");
            var exprTel = new Regex(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$");
            var expCourriel = new Regex("^[_a-z0-9-]+(\\.[_a-z0-9-]+)*@[a-z0-9-]+(\\.[a-z0-9-]+)+$");

            if (tbMDP.Text == "")
            {
                booOK = false;
                errMessage.SetError(tbMDP, "Le mot de passe ne peut être vide");
            }
            else errMessage.SetError(tbMDP, "");

            if (tbNom.Text == "")
            {
                booOK = false;
                errMessage.SetError(tbNom, "Le nom ne peut être vide");
            }
            else errMessage.SetError(tbNom, "");

            if (tbPrenom.Text == "")
            {
                booOK = false;
                errMessage.SetError(tbPrenom, "Le prénom ne peut être vide");
            }
            else errMessage.SetError(tbPrenom, "");

            if (cbSexe.Text.Equals(""))
            {
                booOK = false;
                errMessage.SetError(cbSexe, "Le sexe ne peut être vide");
            }
            else errMessage.SetError(cbSexe, "");

            if (tbRue.Text == "")
            {
                booOK = false;
                errMessage.SetError(tbRue, "La rue ne peut être vide");
            }
            else errMessage.SetError(tbRue, "");

            if (tbVille.Text == "")
            {
                booOK = false;
                errMessage.SetError(tbVille, "La ville ne peut être vide");
            }
            else errMessage.SetError(tbVille, "");

            if (!exprCodePostal.IsMatch(tbCodePostal.Text))
            {
                booOK = false;
                errMessage.SetError(tbCodePostal, "Le code postal n'est pas dans un format valide");
            }
            else errMessage.SetError(tbCodePostal, "");

            if (!exprTel.IsMatch(tbTel.Text))
            {
                booOK = false;
                errMessage.SetError(tbTel, "Le téléphonne n'est pas dans un format valide");
            }
            else errMessage.SetError(tbTel, "");

            if (!exprTel.IsMatch(tbCel.Text))
            {
                booOK = false;
                errMessage.SetError(tbCel, "Le céllulaire n'est pas dans un format valide");
            }
            else errMessage.SetError(tbCel, "");


            if (!expCourriel.IsMatch(tbCourriel.Text))
            {
                booOK = false;
                errMessage.SetError(tbCourriel, "Le courriel n'est pas dans un format valide");
            }
            else errMessage.SetError(tbCourriel, "");



            if (booOK)
            {
                var employe = from unEmploye in dataContext.Employes
                              where unEmploye.No.Equals(GestionEmploye.noEmploye)
                              select unEmploye;



                foreach (var c in employe)
                {
                    c.MotDePasse = tbMDP.Text;
                    c.Nom = tbNom.Text;
                    c.Prenom = tbPrenom.Text;
                    c.Age = (int)nupAge.Value;
                    c.Telephone = strTel;
                    c.Cellulaire = tbCel.Text;
                    c.CodePostal = tbCodePostal.Text;
                    c.Courriel = tbCourriel.Text;
                    c.Remarque = tbRemarque.Text;
                    c.Telephone = tbTel.Text;
                    c.Rue = tbRue.Text;
                    c.Provinces.Id = cbProvince.SelectedValue.ToString();
                    c.NoCivique = int.Parse(nupNoCivique.Value.ToString());
                    c.SalaireHoraire = nupSalaire.Value;
                    c.Sexe = cbSexe.Text.Substring(0, 1);
                    c.Ville = tbVille.Text;
                }
                try
                {
                    dataContext.SubmitChanges();
                    MessageBox.Show("L'employé " + GestionEmploye.noEmploye.ToString() + " a été modifié.", "Modification de l'employé");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Impossible de modifier la base de données");
                }
               
                this.Close();
            }
        }

        private void tbRemarque_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
