using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Projet2BD
{
    public partial class Connexion : Form
    {
        private int noEmploye;

        public bool Reussi { get; private set; } = false;
        public int NoEmploye { get { return noEmploye; } private set { noEmploye = value; } }
        public int NoTypeEmploye { get; private set; }

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
            else if (!dataContext.Employes.Any(employe => employe.No == NoEmploye))
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
                var employe = dataContext.Employes.Where(emp => emp.No == NoEmploye).Single();

                if (employe.MotDePasse != strMotDePasse)
                {
                    tbMotDePasse.Clear();
                    MessageBox.Show("Le mot de passe que vous avez tapé est invalide.");
                    tbMotDePasse.Focus();
                }
                else
                {
                    Reussi = true;
                    NoTypeEmploye = employe.NoTypeEmploye;

                    Close();
                }
            }
        }
    }
}