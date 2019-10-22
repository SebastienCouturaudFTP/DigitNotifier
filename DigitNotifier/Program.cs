using System;
using System.Configuration;
using System.Windows.Forms;

namespace TestNotify
{
    static class Program
    {
        public static string ConnexionBDD = ConfigurationManager.AppSettings["ConnexionBDD"];

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FicheListeFilms ficheMain = new FicheListeFilms();
            Application.Run();
            ficheMain.HideIconNotif();
        }
    }
}
