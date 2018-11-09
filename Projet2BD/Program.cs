using System;
using System.Windows.Forms;

namespace Projet2BD
{
    static class Program
    {
        public static bool quitter = false;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            while (!quitter)
            {
                Connexion connexion = new Connexion();
                Application.Run(connexion);

                if (connexion.reussi)
                {
                    MenuPrincipal menuPrincipal = new MenuPrincipal();
                    menuPrincipal.noEmploye = connexion.noEmploye;
                    menuPrincipal.noTypeEmploye = connexion.noTypeEmploye;
                    Application.Run(menuPrincipal);
                }
                else
                {
                    quitter = true;
                }
            }
        }
    }
}