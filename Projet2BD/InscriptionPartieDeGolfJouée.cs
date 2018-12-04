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
    public partial class InscriptionPartieDeGolfJouée : Form
    {
        DataClasses1DataContext dataContext = new DataClasses1DataContext();

        public InscriptionPartieDeGolfJouée()
        {
            InitializeComponent();
        }

        private void InscriptionPartieDeGolfJouée_Load(object sender, EventArgs e)
        {
            noNomEtPrenomAbonneBindingSource.DataSource = from unAbonne in dataContext.Abonnements
                                                          select new
                                                          {
                                                              noAbonne = unAbonne.Id,
                                                              nomEtPrenomAbonne = unAbonne.Nom + ", " + unAbonne.Prenom
                                                          };
            noEtNomTerrainsBindingSource.DataSource = from unTerrain in dataContext.Terrains
                                                      select new
                                                      {
                                                          noTerrains = unTerrain.No,
                                                          nomTerrains = unTerrain.Nom
                                                      };

            partieDeGolfJoueeBindingSource.DataSource = from unePartie in dataContext.PartiesJouees
                                                        select new
                                                        {
                                                            strIdAbonnement = unePartie.IdAbonnement,
                                                            intNoTerrains = unePartie.NoTerrain,
                                                            strDatePartie = unePartie.DatePartie.ToShortDateString(),
                                                            dblPointage = unePartie.Pointage,
                                                            strRemarque = unePartie.Remarque
                                                        };
            if (noNomEtPrenomAbonneBindingSource.Count < 1)
            {
                btnInscription.Enabled = false;
            }

        }

        private void btnInscription_Click(object sender, EventArgs e)
        {
            DateTime dtDateAbonnement = new DateTime();
            DateTime dtDateReabonnement = new DateTime();
            var abonnement = from unAbonnement in dataContext.Abonnements
                             where unAbonnement.Id.Equals(cbNomEtPrenomAbonne.SelectedValue)
                             select unAbonnement.DateAbonnement;

            foreach (var c in abonnement)
            {
                dtDateAbonnement = c;
            }

            if (dtDateAbonnement.Year < DateTime.Now.Year)
            {
                var reabonnement = from unReabonnement in dataContext.Reabonnements
                                   where unReabonnement.IdAbonnement.Equals(cbNomEtPrenomAbonne.SelectedValue)
                                   select unReabonnement.DateRenouvellement;
                foreach (var c in reabonnement)
                {
                    dtDateReabonnement = c;
                }
                if (dtDateReabonnement.Year == DateTime.Now.Year)
                {
                    PartiesJouees partieJouee = new PartiesJouees
                    {
                        Remarque = tbRemarque.Text,
                        IdAbonnement = cbNomEtPrenomAbonne.SelectedValue.ToString(),
                        DatePartie = DateTime.Now,
                        Pointage = int.Parse(nupPointage.Value.ToString()),
                        NoTerrain =int.Parse(cbTerrains.SelectedValue.ToString())
                    };
                    dataContext.PartiesJouees.InsertOnSubmit(partieJouee);
                    try
                    {
                        dataContext.SubmitChanges();
                        partieDeGolfJoueeBindingSource.DataSource = from unePartie in dataContext.PartiesJouees
                                                                    select new
                                                                    {
                                                                        strIdAbonnement = unePartie.IdAbonnement,
                                                                        intNoTerrains = unePartie.NoTerrain,
                                                                        strDatePartie = unePartie.DatePartie.ToShortDateString(),
                                                                        dblPointage = unePartie.Pointage,
                                                                        strRemarque = unePartie.Remarque
                                                                    };
                        this.partieDeGolfJoueeDataGridView.Refresh();
                        MessageBox.Show("La partie a été ajoutée.", "Ajout de la partie");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Impossible de modifier la base de données");
                    }
                }
                else MessageBox.Show("Une partie de golf ne peut pas être inscrite si l'abonné principal est désabonné");
              



            }
            else
            {
                PartiesJouees partieJouee = new PartiesJouees
                {
                    Remarque = tbRemarque.Text,
                    IdAbonnement = cbNomEtPrenomAbonne.SelectedValue.ToString(),
                    DatePartie = DateTime.Now,
                    Pointage = int.Parse(nupPointage.Value.ToString()),
                    NoTerrain = int.Parse(cbTerrains.SelectedValue.ToString())
                };
                dataContext.PartiesJouees.InsertOnSubmit(partieJouee);
                try
                {
                    dataContext.SubmitChanges();
                    MessageBox.Show("La partie a été ajoutée.", "Ajout de la partie");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Impossible de modifier la base de données");
                }

            }
        }
    }
}
