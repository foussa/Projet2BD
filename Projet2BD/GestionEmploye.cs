using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet2BD
{
    public partial class GestionEmploye : Form
    {
        private DataClasses1DataContext dataContext = new DataClasses1DataContext();
        public static string noEmploye = "";
        private int noEmployeConnecte;

        public GestionEmploye(int noEmploye)
        {
            InitializeComponent();
            noEmployeConnecte = noEmploye;
        }

        /*  private void employesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
          {
              this.Validate();
              this.employesBindingSource.EndEdit();
              this.tableAdapterManager.UpdateAll(this.bD5B6TP2_BrodeurKoumaDataSet);

          }*/

        public void GestionEmploye_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'bD5B6TP2_BrodeurKoumaDataSet.Employes' table. You can move, or remove it, as needed.
            this.employeBindingSource.DataSource = dataContext.Employes;

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Employes unEmploye = new Employes();

            frmAjouterEmploye fAjouterEmploye = new frmAjouterEmploye();
            fAjouterEmploye.ShowDialog();
            // this.Close();
            fAjouterEmploye.unEmploye = unEmploye;
            if (fAjouterEmploye.nouveauEmploye != null)
            {
                employeBindingSource.Add(fAjouterEmploye.nouveauEmploye);
                // bD5B6TP2_BrodeurKoumaDataSet.Employes.AddEmployesRow(fAjouterEmploye.nouveauEmploye);
                employeBindingSource.MoveLast();
                try
                {
                    // noEmploye = fAjouterEmploye.nouveauEmploye.No.ToString();
                    dataContext.SubmitChanges();
                    MessageBox.Show("L'employé " + fAjouterEmploye.nouveauEmploye.No.ToString() + " a été ajouté.", "Ajout de l'employé");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Impossible de modifier la base de données");
                }
            }
            //MessageBox.Show("La chambre a été ajoutée avec succès mais pas enrégistré. Pour enregistrer les modification dans la base de données, veuillez cliquer sur le bouton enregistrer.", "Confirmation d'ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgEmployes.CurrentRow.Cells[0].Value != null || int.Parse(dgEmployes.CurrentRow.Cells[0].Value.ToString()) > 0)
            {

                noEmploye = dgEmployes.CurrentRow.Cells[0].Value.ToString();
                // MessageBox.Show(noEmploye);
                frmModificationEmploye fModificationEmploye = new frmModificationEmploye();

                fModificationEmploye.ShowDialog();
                //   this.employeBindingSource.Clear();
                this.employeBindingSource.DataSource = frmModificationEmploye.dataContext.Employes;
                this.dgEmployes.Refresh();
                // employeBindingSource.RemoveAt(int.Parse(noEmploye));

            }
            else
            {
                MessageBox.Show("Veuillez sélectionner l'employé que vous désirez modifier", "Attention");
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgEmployes.CurrentRow.Cells[0].Value != null || int.Parse(dgEmployes.CurrentRow.Cells[0].Value.ToString()) > 0)
            {
                noEmploye = dgEmployes.CurrentRow.Cells[0].Value.ToString();
                var employe = from unEmploye in dataContext.Employes
                              where unEmploye.No.Equals(noEmploye)
                              select unEmploye;

                foreach (var c in employe)
                {
                    var servivce = from unService in dataContext.Services
                                   where unService.NoEmploye.Equals(noEmploye)
                                   select unService;
                    if (c.NoTypeEmploye == 1) MessageBox.Show("Impossible de supprimer un administrateur", "Erreur");
                    else if (servivce.Count() > 0) MessageBox.Show("Impossible de supprimer cet employé, car il donne des services", "Erreur");
                    else if (c.No == noEmployeConnecte) MessageBox.Show("Impossible de supprimer cet employé, car c'est vous", "Erreur");
                    else
                    {
                        DialogResult dr = MessageBox.Show("Êtes-vous sur de vouloir supprimer cet utilisateur ?.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (dr == DialogResult.Yes)
                        {
                            dataContext.Employes.DeleteOnSubmit(c);
                            try
                            {
                                // noEmploye = fAjouterEmploye.nouveauEmploye.No.ToString();
                                dataContext.SubmitChanges();
                                this.employeBindingSource.DataSource = frmModificationEmploye.dataContext.Employes;
                                this.dgEmployes.Refresh();
                                MessageBox.Show("L'employé " + noEmploye + " a été supprimé.", "Suppression de l'employé");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Impossible de modifier la base de données");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Suppression annulée");
                        }
                    }
                }
            }
        }



        /* class IdEtNomProvince { 
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
