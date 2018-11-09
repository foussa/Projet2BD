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
        public GestionEmploye()
        {
            InitializeComponent();
        }

        private void employesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employesBindingSource.EndEdit();

        }

        private void GestionEmploye_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD5B6TP2_BrodeurKoumaDataSet.Employes' table. You can move, or remove it, as needed.

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            frmAjouterEmploye fAjouterEmploye = new frmAjouterEmploye();
            fAjouterEmploye.ShowDialog();
        }
    }
}
