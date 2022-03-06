using System;
using System.Windows.Forms;

namespace Fake_Ransomware
{
    static class MainProgram
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainScreenForm());
        }
    }
}
