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
using System.Data.Linq;

namespace Projet2BD
{
    public partial class frmAjouterEmploye : Form
    {
        public Employes unEmploye;

        private DataClasses1DataContext dataContext = new DataClasses1DataContext();
        public Employes nouveauEmploye = null;
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

            if (cbTypeEmp.SelectedValue.ToString() == "1")
            {
                booOK = false;
                errMessage.SetError(cbTypeEmp, "On ne peut ajouter un administrateur (un seul administrateur pour le système)");
            }
            else errMessage.SetError(cbTypeEmp, "");

            if (!expCourriel.IsMatch(tbCourriel.Text))
            {
                booOK = false;
                errMessage.SetError(tbCourriel, "Le courriel n'est pas dans un format valide");
            }
            else errMessage.SetError(tbCourriel, "");
            /*   MessageBox.Show("Type employé selectionné " + cbTypeEmp.SelectedValue);
               MessageBox.Show(" selectionné " + int.Parse(nupNoCivique.Value.ToString()));*/
            if (booOK)
            {
               // MessageBox.Show("Toutes les données sont bonnes");
                var tousLesEmploye = from Employe in dataContext.Employes
                                     select Employe.No;
                decimal noEmploye = tousLesEmploye.Max() + 1;
                /*MessageBox.Show(cbProvince.SelectedValue.ToString());
                MessageBox.Show(nupNoCivique.Value.ToString());
                MessageBox.Show(cbSexe.SelectedValue.ToString());
                MessageBox.Show(cbTypeEmp.SelectedValue.ToString());*/


                nouveauEmploye = new Employes
                {
                    No = (int)noEmploye,
                    MotDePasse = tbMDP.Text,
                    Nom = tbNom.Text,
                    Prenom = tbPrenom.Text,
                    Age = (int)nupAge.Value,
                    Cellulaire = tbCel.Text,
                    CodePostal = tbCodePostal.Text,
                    Courriel = tbCourriel.Text,
                    Remarque = tbRemarque.Text,
                    Telephone = tbTel.Text,
                    Rue = tbRue.Text,
                    IdProvince = cbProvince.SelectedValue.ToString(),
                    NoCivique = int.Parse(nupNoCivique.Value.ToString()),
                    SalaireHoraire = nupSalaire.Value,
                    Sexe = cbSexe.Text.Substring(0, 1),
                    Ville = tbVille.Text,
                    NoTypeEmploye = int.Parse(cbTypeEmp.SelectedValue.ToString())
                };
                //  MessageBox.Show()
                /* unEmploye.No = (int)noEmploye;
                 unEmploye.MotDePasse = tbMDP.Text;
                 unEmploye.Nom = tbNom.Text;
                 unEmploye.Prenom = tbPrenom.Text;
                 unEmploye.Age = (int)nupAge.Value;
                 unEmploye.Cellulaire = tbCel.Text;
                 unEmploye.CodePostal = tbCodePostal.Text;
                 unEmploye.Courriel = tbCourriel.Text;
                 unEmploye.Remarque = tbRemarque.Text;
                 unEmploye.Telephone = tbTel.Text;
                 unEmploye.Rue = tbRue.Text;
                 unEmploye.IdProvince = cbProvince.SelectedValue.ToString();
                 unEmploye.NoCivique = int.Parse(nupNoCivique.Value.ToString());
                 unEmploye.SalaireHoraire = nupSalaire.Value;
                 unEmploye.Sexe = cbSexe.Text.Substring(0, 1);
                 unEmploye.Ville = tbVille.Text;
                 unEmploye.NoTypeEmploye = int.Parse(cbTypeEmp.SelectedValue.ToString());*/
                // dataContext.Employes.InsertOnSubmit(nouveauEmploye);


                /* try
                 {
                     dataContext.SubmitChanges();
                     MessageBox.Show("L'employé " + noEmploye + " a été ajouté.", "Ajout de l'employé");
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show(ex.Message, "Impossible de modifier la base de données");
                 }*/
                /* GestionEmploye fGestionEmploye = new GestionEmploye();
                 fGestionEmploye.ShowDialog();*/

                this.Close();
            }




        }

        /* private void provincesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
         {
             this.Validate();
             this.provincesBindingSource.EndEdit();
             this.tableAdapterManager.UpdateAll(this.bD5B6TP2_BrodeurKoumaDataSet);

         }*/

        private void frmAjouterEmploye_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD5B6TP2_BrodeurKoumaDataSet.TypesEmploye' table. You can move, or remove it, as needed.
            //  this.typesEmployeTableAdapter.Fill(this.bD5B6TP2_BrodeurKoumaDataSet.TypesEmploye);
            // TODO: This line of code loads data into the 'bD5B6TP2_BrodeurKoumaDataSet.Provinces' table. You can move, or remove it, as needed.
            //  this.provincesTableAdapter.Fill(this.bD5B6TP2_BrodeurKoumaDataSet.Provinces);
            idEtNomProvinceBindingSource.DataSource = from uneProvince in dataContext.Provinces
                                                      select new
                                                      {
                                                          idProvince = uneProvince.Id,
                                                          nomProvince = uneProvince.Nom
                                                      };

            noEtTypeEmployeBindingSource.DataSource = from unTypeEmploye in dataContext.TypesEmploye
                                                      select new
                                                      {
                                                          noTypeEmploye = unTypeEmploye.No,
                                                          typeEmploye = unTypeEmploye.Description
                                                      };

        }

        /*class IdEtNomProvince
        {
            public string idProvince { get; private set; }
            public string nomProvince { get; private set; }
        }


        class NoEtTypeEmploye
        {
            public int noTypeEmploye { get; private set; }
            public string typeEmploye { get; private set; }
        }*/
    }
}
