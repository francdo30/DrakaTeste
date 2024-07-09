using Draka_Antivirus.Pages_Principales.Scan;
using IWshRuntimeLibrary;
using System;
using System.Windows.Forms;
using System;
using System.IO;
using IWshRuntimeLibrary;


namespace Draka_Antivirus
{
    static class Program
    {
        public static ScanPersonalise sp;
        public static bool isSp;
        public static ScanComplete sc;
        public static bool isSc;
        public static Scan s;
        public static bool scanRun;
        public static Home home;
        public static string targetPath = AppDomain.CurrentDomain.BaseDirectory;
        //public static string Langues = targetPath + "Draka_Shiel\\Debug\\lang.txt";
        
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            isSc = false;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            try
            {
                Application.Run(new Index());
            }catch(Exception ex)
            {
                // Message d'erreur
            }
        }
    }
}
