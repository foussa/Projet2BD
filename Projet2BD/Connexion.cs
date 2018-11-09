using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Projet2BD
{
    public partial class Connexion : Form
    {
        public bool reussi = false;
        public int noEmploye;
        public int noTypeEmploye;

        DataClasses1DataContext dataContext = new DataClasses1DataContext();

        public Connexion()
        {
            InitializeComponent();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            string strNoEmploye = tbNomUtilisateur.Text.Trim();
            string strMotDePasse = tbMotDePasse.Text.Trim();
            
            if (string.IsNullOrEmpty(strNoEmploye))
            {
                MessageBox.Show("Vous n'avez pas tapé votre numéro d'employé.");
                tbNomUtilisateur.Focus();
            }
            else if (!int.TryParse(strNoEmploye, out noEmploye))
            {
                MessageBox.Show("Le numéro d'employe ne peut contenir que des chiffres.");
                tbNomUtilisateur.Focus();
            }
            else if (!dataContext.Employes.Any(employe => employe.No == noEmploye))
            {
                tbNomUtilisateur.Clear();
                tbMotDePasse.Clear();
                MessageBox.Show("Le numéro d'employé que vous avez tapé est invalide.");
                tbNomUtilisateur.Focus();
            }
            else if (string.IsNullOrEmpty(strMotDePasse))
            {
                MessageBox.Show("Vous n'avez pas tapé votre mot de passe.");
                tbMotDePasse.Focus();
            }
            else
            {
                var employe = dataContext.Employes.Where(emp => emp.No == noEmploye).Single();

                if (employe.MotDePasse != strMotDePasse)
                {
                    tbMotDePasse.Clear();
                    MessageBox.Show("Le mot de passe que vous avez tapé est invalide.");
                    tbMotDePasse.Focus();
                }
                else
                {
                    reussi = true;
                    noTypeEmploye = employe.NoTypeEmploye;

                    Close();
                }
            }
        }
    }
}