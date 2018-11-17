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
    public partial class Abonnement : Form
    {
        DataClasses1DataContext dataContext = new DataClasses1DataContext();
        private int noLien;
        private List<Control> lstControlesDynamiques = new List<Control>();

        public Abonnement()
        {
            InitializeComponent();
            noLien = dataContext.Abonnements.Count() + 1;
        }

        private void Abonnement_Load(object sender, EventArgs e)
        {
            ClientSize = new Size(367, 468);

            ddlSexes.Items.Add(new { DisplayMember = "Homme", ValueMember = "H" });
            ddlSexes.Items.Add(new { DisplayMember = "Femme", ValueMember = "F" });
            ddlSexes.DisplayMember = "DisplayMember";
            ddlSexes.ValueMember = "ValueMember";
            ddlSexes.SelectedIndex = 0;

            provincesBindingSource.DataSource = from province in dataContext.Provinces
                                                select province;

            typesAbonnementBindingSource.DataSource = from typeAbonnement in dataContext.TypesAbonnement
                                                      select typeAbonnement;
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
                    btnAjouter.Location = new Point(113, 414);

                    ClientSize = new Size(367, 468);

                    break;
                case 3:
                    lblRemarque.Top = 352;
                    tbRemarque.Top = 349;
                    btnAjouter.Location = new Point(281, 414);

                    lstControlesDynamiques.Add(new SaisieDependant(362, 20, noLien, 0));

                    ClientSize = new Size(703, 468);

                    break;
                case 4:
                    lblRemarque.Top = 352;
                    tbRemarque.Top = 349;
                    btnAjouter.Location = new Point(281, 414);

                    lstControlesDynamiques.Add(new SaisieDependant(362, 20, noLien, 0));
                    lstControlesDynamiques.Add(new SaisieDependant(362, 223, noLien, 1));

                    ClientSize = new Size(703, 468);

                    break;
                case 5:
                    lblRemarque.Top = 352;
                    tbRemarque.Top = 349;
                    btnAjouter.Location = new Point(449, 414);

                    lstControlesDynamiques.Add(new SaisieDependant(362, 20, noLien, 0));
                    lstControlesDynamiques.Add(new SaisieDependant(698, 20, noLien, 1));
                    lstControlesDynamiques.Add(new SaisieDependant(362, 223, noLien, 2));

                    ClientSize = new Size(1039, 468);

                    break;
                case 6:
                    lblRemarque.Top = 378;
                    tbRemarque.Top = 375;
                    btnAjouter.Location = new Point(617, 440);

                    NumericUpDown numNbEnfants = new NumericUpDown();
                    numNbEnfants.Name = "numNbEnfants";
                    numNbEnfants.Value = 3;
                    numNbEnfants.Minimum = 3;
                    numNbEnfants.Maximum = 9;
                    numNbEnfants.ValueChanged += new EventHandler(numNbEnfants_ValueChanged);
                    numNbEnfants.Size = new Size(50, 20);
                    numNbEnfants.Location = new Point(132, 349);

                    Label lblNbEnfants = new Label();
                    lblNbEnfants.Name = "lblNbEnfants";
                    lblNbEnfants.Text = "Nombre d\'enfants :";
                    lblNbEnfants.Location = new Point(30, 351);
                    lstControlesDynamiques.Add(lblNbEnfants);
                    lstControlesDynamiques.Add(numNbEnfants);
                    lstControlesDynamiques.Add(new SaisieDependant(362, 20, noLien, 0));
                    lstControlesDynamiques.Add(new SaisieDependant(698, 20, noLien, 1));
                    lstControlesDynamiques.Add(new SaisieDependant(1034, 20, noLien, 2));
                    lstControlesDynamiques.Add(new SaisieDependant(362, 249, noLien, 3));
                    //lstControlesDynamiques.Add(new SaisieDependant(698, 223, noLien, 3));

                    ClientSize = new Size(1375, 494);

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

            lstControlesDynamiques.Add(new SaisieDependant(362, 20, noLien, 0));
            lstControlesDynamiques.Add(new SaisieDependant(698, 20, noLien, 1));
            lstControlesDynamiques.Add(new SaisieDependant(1034, 20, noLien, 2));
            lstControlesDynamiques.Add(new SaisieDependant(362, 249, noLien, 3));

            if (nbEnfants > 3)
            {
                lstControlesDynamiques.Add(new SaisieDependant(698, 249, noLien, 4));

                if (nbEnfants > 4)
                {
                    lstControlesDynamiques.Add(new SaisieDependant(1034, 249, noLien, 5));

                    if (nbEnfants > 5)
                    {
                        btnAjouter.Location = new Point(617, 669);

                        lstControlesDynamiques.Add(new SaisieDependant(20, 478, noLien, 6));

                        if (nbEnfants > 6)
                        {
                            lstControlesDynamiques.Add(new SaisieDependant(362, 478, noLien, 7));

                            if (nbEnfants > 7)
                            {
                                lstControlesDynamiques.Add(new SaisieDependant(698, 478, noLien, 8));

                                if (nbEnfants > 8)
                                    lstControlesDynamiques.Add(new SaisieDependant(1034, 478, noLien, 9));
                            }
                        }

                        ClientSize = new Size(1375, 723);
                    }
                    else
                    {
                        btnAjouter.Location = new Point(617, 440);

                        ClientSize = new Size(1375, 494);
                    }
                }
            }
            else
                ClientSize = new Size(1375, 494);

            foreach (Control controle in lstControlesDynamiques)
                if (controle is SaisieDependant)
                    Controls.Add(controle);
        }
    }
}
