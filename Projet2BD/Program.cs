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

                if (connexion.Reussi)
                    Application.Run(new MenuPrincipal(connexion.NoEmploye, connexion.NoTypeEmploye));
                else
                    quitter = true;
            }
        }
    }
}