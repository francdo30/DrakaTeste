using Draka_Antivirus.Pages_Principales.Scan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using Draka_Antivirus.DAO;
using Microsoft.VisualBasic.FileIO;
using System.Linq;
using System.Diagnostics;
using Guna.UI2.WinForms;
using Draka_Antivirus.Pages_Principales;
using System.Net.Http;
using Microsoft.Win32;
using System.Drawing;
using System.Threading;
using System.Management;
using System.Net.NetworkInformation;
using System.Net;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Activities.Statements;
using Shell32;
using WUApiLib;
//using WMPLib;
using System.Data.SQLite;
using Draka_Antivirus.Pages_Principales.Pages_Security;
using System.Net.Security;
using System.Xml;
using System.Data;
using Org.BouncyCastle.Asn1.Crmf;
using System.Windows.Documents;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Security.Policy;
using System.Security.RightsManagement;
using Azure;
using System.Web;
using System.Windows.Shapes;
using Path = System.IO.Path;
using static System.Windows.Forms.LinkLabel;
using Draka_Antivirus.Pages_Principales.Pages_Stability;
using System.Net.Mail;
using OpenFileDialog = System.Windows.Forms.OpenFileDialog;
using Org.BouncyCastle.Crypto.Macs;
using System.Security.Cryptography;
using System.Windows.Media;
using Color = System.Drawing.Color;
using static System.Net.WebRequestMethods;
using File = System.IO.File;
using System.Windows.Controls.Primitives;
using Google.Protobuf.WellKnownTypes;
using Draka_Antivirus.Pages_Principales.Pages_Maintenance;
using System.Runtime.InteropServices.ComTypes;
using System.Activities.Expressions;
using Draka_Antivirus.LoginData;
using System.Security.Cryptography.X509Certificates;
using HtmlAgilityPack;
using Activation1 = Draka_Antivirus.Pages_Principales.Activation1;
using MySql.Data.MySqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using Org.BouncyCastle.Utilities.Net;
using IPAddress = System.Net.IPAddress;
using Microsoft.Office.Interop.Outlook;
using Exception = System.Exception;
using Folder = Shell32.Folder;
using Application = System.Windows.Forms.Application;
using Attachment = System.Net.Mail.Attachment;
//using Aspose.Zip;
using System.IO.Compression;
using Aspose.Zip;
using System.Threading.Tasks;
using System.Text.Json;
using Newtonsoft.Json;
using System.Web.Script.Serialization;
using Google.Protobuf.Collections;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Collections;
using Timer = System.Windows.Forms.Timer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using IWshRuntimeLibrary;
//using Aspose.Zip.Rar;
using SharpCompress.Archives;
using SharpCompress.Archives.Rar;
using SharpCompress.Common;
using SharpCompress;
//using Windows.ApplicationModel.VoiceCommands;

namespace Draka_Antivirus
{
    public partial class Index : Form
    {
        private object obj;
        int virus;
        int files;
        int index = 0;
        int ich = 0;
        public static string targetPath = AppDomain.CurrentDomain.BaseDirectory;
        public static string Chrome = targetPath + "LoginsChrome";
        public static string Edge = targetPath + "LoginsEdge";
        public static string Opera = targetPath + "LoginsOpera";
        string PathDataVirale = targetPath + "viraldatabase.txt";
        public static string name_db = "ScanDataBase.db";
        public static string sourceFile = targetPath + name_db;
        public static string OuvrirRapport = targetPath + "OpenRepport.txt";
        public static string Langues = targetPath + "Draka_Shiel\\Debug\\lang.txt";
        public static string VirusBD = targetPath + "Draka_Shiel\\Debug\\MD5Base.txt";
        public static string Quarantaine2 = targetPath + "Draka_Shiel\\Debug\\QuarantaineTeste.txt";
        public static string VirusBD2 = targetPath + @"Draka_Shiel\Debug\MD5Base.txt";
        public static string Cb = targetPath + "corbeille.txt";
        public static string BDAutoScan = targetPath + @"Draka_Shiel\";
        public static string BDAutoScanVal = BDAutoScan + "Historique.txt";
        public static string HistoriqueScan = targetPath + @"Draka_Shiel\Debug\HistoriqueScan.txt";
        public static string MessageOK = targetPath + "Draka_Shiel\\Debug\\MessageOK.txt";
        public static string VersionBD_Viral = targetPath + "Draka_Shiel\\Debug\\Version.txt";
        public static string AjoutAuDemarage = targetPath + "Draka_Shiel\\Debug\\AjoutAuDemarage.txt";
        //public static string ProgramScanBDt = targetPath + @"Draka_Shiel\Debug\HistoScanTotal.txt";
        //string passeword = targetPath + "PWD.txt"; Debug
        Database db1 = new Database();
        ToolTip t1 = new ToolTip();
        Color[] colors = { Color.Aqua, Color.Green, Color.Blue, Color.Black, Color.DeepSkyBlue, Color.Red };
        String obt = "Pause";
        string bbt = "Pause";
        string OuvrirRapport22 = targetPath + "OpenRepport.txt";
        string[] SelectAll = { "SelQ", "SelH", "SelM" };
        string[] typeScan;
        string choix = "";
        string Enregistrer = "           ";
        string ControlParental = "";
        string jourEng = "";
        string chemin11 = "";
        string FichierHost = @"C:\Windows\System32\drivers\etc\hosts";
        string toto = "";
        //string FichierHost7 = File.AppendText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "drivers/etc/hosts"));                                
        string passeword = targetPath + "PWD.txt";
        string[] identifiants = { " ", " " };
        string Auto = "";
        string[] Partiel = {" ", " " };
        string path = targetPath + "Error_Log.txt";
        Boolean verif = true;
        Boolean verifTout = true;
        Boolean verif1 = false;
        Boolean verif2 = false;
        string QAutoManuel = "Manuel";
        string pathAutoScan = targetPath + @"\Draka_Shiel\DrakaScanAuto.exe";
        //string pathAutoScan = targetPath + @"\shiel\sartre\ScanAutomatique.exe";
        string VerifAutoScan = targetPath + @"\Draka_Shiel\ScanAuto.txt";
        string ProgramScan = targetPath + @"\Draka_Shiel\Debug\ProgramScan.txt";
        string ProgramPartiel = targetPath + @"\Draka_Shiel\Debug\PragramPartiel.txt";
        string ActivationDraka = targetPath + @"\Draka_Shiel\Debug\drakaKey.txt";
        string QuarantaineBD = targetPath + @"\Draka_Shiel\Debug\QuarantaineScan.txt";
        string AutoVVerif = targetPath + @"\Draka_Shiel\Debug\AutoVerif.txt";
        string HistoriqueViralBasis = targetPath + @"\Draka_Shiel\Debug\HistoriqueViralBasis.txt";
        string Datewebsite = targetPath + "Datewebsite.txt";
        string FichierUpdateData = targetPath + "FichierUpdate.txt";
        string ActivatonCP = targetPath + "ParentalControler.txt";
        string ProgrammerScan = targetPath + @"\Draka_Shiel\Debug\DrakaSchedScan.exe";
        //string BaseVirale = "https://keygen.drakashield.com/release-virus-database/MD5Base.zip";
        string BaseVirale = targetPath + "\\Videos\\DrakaShieldViralDatabase.";
        string BaseViraleJson = targetPath + "\\Videos\\release-virus-database.json"; ///release-virus-database
        string BaseViralDezip = targetPath + "\\Videos";
        string Activation = targetPath + "\\Videos\\Activation.json";
        //string BaseViralDezip = targetPath + "\\Videos\\MD5Base.txt";
        //string pathVideo = targetPath ;
        //**************************************************************************
        string html = "https://github.com/francdo30/francdo30/blob/main/Test.html"; // url site update viral basis
        //**************************************************************************
        //string path = targetPath + @"\Code\ConsoleApp2.exe";
        string pathVideo1 = targetPath + @"\Videos\LigneRouge.MP4";
        string pathVideo2 = targetPath + @"\Videos\ScreenJaune.MP4";
        string pathVideo3 = targetPath + @"\Videos\ScreenP.MP4";
        int virisScan = 0;  
        string programScan = "";
        string lang = "";
        string variable22 = "";
        string variable = "";
        string check12 = "";
        string checkViralBasis = "";
        public static string ActivationKey1 = targetPath + @"\Draka_Shiel\Debug\sdklmn.txt";
        public string VersionEssaie = targetPath + @"\Draka_Shiel\Debug\zzkfnvpuf.txt";
        static string TOTO = targetPath + @"\Draka_Shiel\HistoriqueTar.txt";
        static string QuarantaineScan = targetPath + "Debug\\QuarantaineScan.txt";
        static string UpdateAutoScan = targetPath + "Draka_Shiel\\MD5Base.txt"; //"Draka_Shiel\\Debug\\Version.txt";
        static string UpdateScanProg = targetPath + "Draka_Shiel\\Debug\\MD5Base.txt";
        //**************************************************************************
        //**************************************************************************
        int l = 0;
        int ll = 0;
        string vCnx = "enable";//"expired";
        string tache = "";
        string couleur = "";
        //string DrakaActif = "";
        string dateActive = "";
        string[] ValeurF = { "Journalier", "Hebdo" };  //Hebdomadaire
        string[] tableauMac = { "", "" };
        string Essai1 = "";
        string[] ValeurFS = { "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche" };
        string[] ValeurFA = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        string AutoVerif = "";
        string a = "";
        string akeys = "";
        string CodeCouleur = "";
        //MessagesShow yo = new MessagesShow("Votre produit à expirer .", "");
        const string userRoot = "HKEY_CURRENT_USER";
        const string subkey = "DrakaScheld_av";
        const string Software = "Software";
        const string keyName = userRoot + "\\" + Software + "\\" + subkey;
        string urlVal = "https://keygen.drakashield.com/api/set-key-state";
        string Acheter = "";
        string btnUpdate = "";
        string UpdateChemin = "";

        string[] formats = {"d", "D", "f", "F", "g", "G", "m", "o", "r",
                          "s", "t", "T", "u", "U", "Y", "dddd, MMMM dd yyyy hh:mm:ss"};
        // Create an array of four cultures.
        CultureInfo[] cultures = {CultureInfo.GetCultureInfo("de-DE"),
                                CultureInfo.GetCultureInfo("en-US"),
                                CultureInfo.GetCultureInfo("es-ES"),
                                CultureInfo.GetCultureInfo("fr-FR")};
        int abcd = 0;

        public Index()
        {
            // ici nous sommes dans le constructeur.
            this.lang = File.ReadAllText(Langues);
            string VDemarrage = LireEtEcrireFichier("popoi", AjoutAuDemarage);

            if (VDemarrage.Equals("001001"))
            {
                // ici l'application n;est pas ajoute au demarrage.
                //AjouterAuDemarrage22("Draka Antivirus", ChercherChemin());
                AjoutDemarrage();
                LireEtEcrireFichier("Ecrire", AjoutAuDemarage);

                if (lang.Equals("Anglais"))
                {
                    MessagesShow titi = new MessagesShow("Application added On startup with success", "");
                }
                else
                {
                    MessagesShow titi = new MessagesShow("Application ajoutée Au démarrage avec succès", "");
                }
            }
            else
            {
                // ici l'application a ete ajoute au demarrage
                //MessageBox.Show("l'application est deja au demarrage...");
            }
            //Verification des mises a jours disponible
            VerificationUpdate();
           
            // verifier si l'application est ajoute au demarrage.                 
            
            string LoadApp = VerifVersionApp();


            TableBD("Quarantaine");

            //CorbeilleListe();
            this.couleur = "";
            var liste = File.ReadAllLines(ActivationDraka);
            var AutoVerif = File.ReadAllText(AutoVVerif);

            this.variable22 = File.ReadAllText(FichierUpdateData);
            this.tableauMac = AdresseMac();

            this.a = File.ReadAllText(VersionBD_Viral);
            this.Acheter = LoadApp;
           
            if (LoadApp.Equals("Evaluation"))
            {
                // nous sommes dans la version d'évaluation
                // ici on va vérifier si la version d'évaluation est toujours à jour ou pas.
                //guna2Button41 button delete du controle parentale 
                string dateJour = DateTime.Today.ToString("dd/MM/yyyy");
                string val = ComparationDate(DeCryptoCode(LireDansRegistre()));
                int valj = CalculDateVal(val, dateJour);
                //MessageBox.Show("valeur registre = " + val);
                abcd = valj;
                
                ProduitNonActif(valj);
                //FinVersionEvaluation();
                //ProduitActivé(valj);
                //Pactivation();

            }
            if (LoadApp.Equals("Complete"))
            {
                // nous sommes dans une version complete
                // ici on va vérifier si la version d'Complete est toujours à jour ou pas.
                string dateJour = DateTime.Today.ToString("dd/MM/yyyy");
                string val = ComparationDate(DeCryptoCode(LireDansRegistre()));
                //MessagesShow to = new MessagesShow("Le produit Expire le = " + val, "");
                //int valj = CalculDate(val, dateJour);
                int valj = CalculDateP_Actived(val, dateJour);
                //MessagesShow top = new MessagesShow("il nous reste  = " + valj+ " jours", "");

                abcd = valj;
                ProduitActivé(valj);

            }
            else if (LoadApp.Equals("Rien"))
            {
                abcd = 15;
                // il s'agit de la première installation, donc la version d'évaluation
                // ici la version d'évaluation est toujours à jour.
                //on va prendre la date actuelle, l'augmenté de 14 jours et enregistré dans le régistré

                string dateJour = DateTime.Today.ToString("dd/MM/yyyy");
                string yos = CalculEval(dateJour, "E");
               
                try
                {
                    string dejaa = LireDansRegistre();
                    
                    if (dejaa.Equals(""))
                    {
                        EcrireDansRegistre(yos);
                        ProduitNonActif(15);
                    }
                    else
                    {
                        if (lang.Equals("Anglais"))
                        {
                            MessagesShow titi = new MessagesShow("Your trial period is over", "");
                        }
                        else
                        {
                            MessagesShow titi = new MessagesShow("Votre période d'essaie est terminé", "");
                        }
                        FinVersionEvaluation();
                    }

                }
                catch (Exception ex)
                {
                    EcrireDansRegistre(yos);
                    ProduitNonActif(15);
                    //ProduitNonActif(15);                    
                }
            }
        }

        // Ajouter l'application au demarrage

        public static void AddApplicationToStartup(string appName, string appPath)
        {
            try
            {
                // Ouvrir la clé de registre
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
                MessageBox.Show("key = " + key);
                // Ajouter ou mettre à jour l'entrée de l'application
                if (key != null)
                {
                    key.SetValue(appName, appPath);
                    key.Close();
                    MessageBox.Show("L'application a été ajoutée au démarrage de Windows. ");
                    Console.WriteLine("L'application a été ajoutée au démarrage de Windows.");
                }
                else
                {
                    Console.WriteLine("Erreur lors de l'ouverture de la clé de registre.");
                    MessageBox.Show("Erreur lors de l'ouverture de la clé de registre.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Une erreur s'est produite : {ex.Message}");
            }
        }
        static void AjouterAuDemarrage22(string nom, string cheminExe)
        {
            string sourceFilePath = @"C:\\Program Files (x86)\\Draka Shield Technology\\Draka Antivirus\\Draka Antivirus.exe";

            // Chemin du répertoire cible (StartUp)
            string targetDirectoryPath = @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\StartUp";
            
            // Chemin du fichier cible (dans le répertoire StartUp)

            string targetFilePath = Path.Combine(targetDirectoryPath, Path.GetFileName(sourceFilePath));
            
            try
            {
                //File.Copy(chemin, runKey, true);
                // Vérifie si le répertoire cible existe
                if (!Directory.Exists(targetDirectoryPath))
                {
                    throw new DirectoryNotFoundException($"Le répertoire cible n'existe pas : {targetDirectoryPath}");
                }

                // Copie le fichier vers le répertoire cible
                File.Copy(sourceFilePath, targetFilePath, true);

                Console.WriteLine("Fichier copié avec succès.");

                MessagesShow to = new MessagesShow("File copied successfully.", "");
                //MessageBox.Show("Fichier copié avec succès.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Erreur : Accès refusé. Essayez d'exécuter l'application en tant qu'administrateur.");
                //MessageBox.Show("Erreur : Accès refusé. Essayez d'exécuter l'application en tant qu'administrateur.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur : {ex.Message}");
                //MessageBox.Show(ex.Message);
            }
            
        }

        public static void AjoutDemarrage() //string name, string path
        {
            string appPath = "C:\\Program Files (x86)\\Draka Shield Technology\\Draka Antivirus\\Draka Antivirus.exe";
           
            string appName = "Draka Antivirus";

            // Ajouter l'application au démarrage de Windows
            AddApplicationToStartup(appName, appPath);
            
        }


        public string ChercherChemin()
        {
            //string appName = name;
            string appChemin = "C:\\Program Files (x86)";
            //string appChemin1 = "C:\\Program Files (x86)\\Draka Shield Technology\\Draka Antivirus\\Draka Antivirus.exe";
            string appChemin1 = "C:\\Program Files (x86)\\Draka Shield Technology\\Draka Antivirus";
            string chemin = "";
            string appName = "Draka Antivirus.exe";
            List<String> f = new List<String>();

            chemin = Path.Combine(appChemin1, appName);
            
            return chemin;
        }

        public static void CreateShortcut(string targetPath,
                                   string shortcutFile,
                                   string description,
                                   string arguments,
                                   string hotKey,
                                   string workingDirectory,
                                   string iconLocation)
        {
            if (String.IsNullOrEmpty(targetPath))
                throw new ArgumentNullException("targetPath");

            if (String.IsNullOrEmpty(shortcutFile))
                throw new ArgumentNullException("shortcutFile");

            WshShell wshShell = new WshShell();

            IWshRuntimeLibrary.IWshShortcut shortcut = (IWshRuntimeLibrary.IWshShortcut)wshShell.CreateShortcut(shortcutFile);

            shortcut.TargetPath = targetPath;

            shortcut.Description = description;

            if (!String.IsNullOrEmpty(arguments))
                shortcut.Arguments = arguments;

            if (!String.IsNullOrEmpty(hotKey))
                shortcut.Hotkey = hotKey;

            if (!String.IsNullOrEmpty(workingDirectory))
                shortcut.WorkingDirectory = workingDirectory;

            if (!String.IsNullOrEmpty(iconLocation))
                shortcut.IconLocation = iconLocation;

            shortcut.Save();
        }
        
        // ici on manipule l'affichage de la verion d'évaluation du produit

        public void ProduitNonActif(int valj)
        {
            if ((valj > 0) && (valj <= 15))
            {
                // version d'évaluation Active.
                //MessageBox.Show("lang = " + lang);
                if (valj <= 3)
                {
                    if (lang.Trim().Equals("Anglais"))
                    {
                        MessagesShow to = new MessagesShow("You still have " + valj + " Trial days", "");
                    }
                    else
                    {
                        MessagesShow to = new MessagesShow("Il vous reste " + valj + " Jours d'essaie", "");
                    }
                }
                //InitializeComponent();                    
                Pactivation();

                this.title3.Visible = true;
                if (lang.Equals("Anglais"))
                {
                    this.title3.Text = "Register your product!!!";
                }
                else
                {
                    this.title3.Text = "Enregistrez votre produit !!!";
                }
                this.title3.ForeColor = System.Drawing.Color.OrangeRed;
                //FinVersionEvaluation();
            }
            else
            {
                // version d'évaluation obsolette.
                if (lang.Equals("Anglais"))
                {
                    MessagesShow to = new MessagesShow("Please Activate your product", "");
                }
                else
                {
                    MessagesShow to = new MessagesShow("Veuillez Activer votre produit", "");
                }
                // ici on va ajouté le lien pour le site d'achat de la clé du produit.
                FinVersionEvaluation();
            }
        }
        // ici nous manipullons l'affichage du produit activé
        public void ProduitActivé(int valj)
        {
            if ((valj > 0) || (valj <= 365) )
            {
                if (valj < 6)
                {
                    if(valj == 2)
                    {
                        if (lang.Trim().Equals("Anglais"))
                        {
                            MessagesShow top = new MessagesShow("you still have  : " + valj * 24 + ", hours of use", "");
                        }
                        else
                        {
                            MessagesShow top = new MessagesShow("il vous reste  : " + valj * 24 + "heures d'utilisaton", "");
                        }
                    }
                    else if(valj == 1)
                    {
                        if (lang.Trim().Equals("Anglais"))
                        {
                            MessagesShow top = new MessagesShow("you still have  : " + valj * 24 + ", hours of use", "");
                        }
                        else
                        {
                            MessagesShow top = new MessagesShow("il vous reste  : " + valj * 24 + "heures d'utilisaton", "");
                        }
                    }
                    else if(valj > 2)
                    {
                        if (lang.Trim().Equals("Anglais"))
                        {
                            MessagesShow top = new MessagesShow("you still have  : " + valj + ", days of use", "");
                        }
                        else
                        {
                            MessagesShow top = new MessagesShow("il vous reste  : " + valj + ", jours d'activation", "");
                        }
                    }
                }
                
                Pactivation();
                //Remplir();
            }
            else
            {
                // clé d'activation obsolette. on met juste le lien du site d'activation
                FinVersionEvaluation();
            }
        }

        // ici nous avons la version d'évaluation
        public void FinVersionEvaluation()
        {
            // ful scan, performance et stability
            
            InitializeComponent();
            this.homeBtn.Enabled = false;
            this.securityBtn.Enabled = false;
            this.QuarantBtn.Enabled = false;
            this.historyBtn.Enabled = false;
            this.updateBtn.Enabled = false;
            this.maintainBtn.Enabled = false;
            this.performanceBtn.Visible = true;
            this.stabilityBtn.Visible = true;
            this.scanBtn.Visible = true;
            //this.scanBtn.Enabled = false;
            this.setting.Visible = false;
            this.guna2ImageButton10.Enabled = false;
        }
        // remplir un label
        public void TableBD(string ttr)
        {
            try
            {
                if (File.Exists(sourceFile))
                {
                    Boolean tar7j = db1.CreateTable(sourceFile, "Quarantaine");
                    if (tar7j == true)
                    {
                        if (lang.Equals("Anglais"))
                        {
                            //AutoClosingMessageBox.Show("empty quarantine. ");
                            MessagesShow yo = new MessagesShow("empty quarantine ", "");
                        }
                        else
                        {
                            //AutoClosingMessageBox.Show("Aucun Fichier en Quarantaine. ");
                            MessagesShow yo = new MessagesShow("Aucun Fichier en Quarantaine ", "");
                        }
                    }
                    else
                    {
                        if (lang.Trim().Equals("Anglais"))
                        {
                            //AutoClosingMessageBox.Show("Loading... ");
                            MessagesShow yo = new MessagesShow("Loading... ");
                        }
                        else
                        {
                            //AutoClosingMessageBox.Show("Chargement encours... ");
                            MessagesShow yo = new MessagesShow("Chargement encours... ");
                        }
                    }
                }
                else
                {
                    //MessageBox.Show("La base de données n'existe pas. ");
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Yosss = " + ex.Message);
            }
        }

        
        // quelle est la date du produit
        // comparation date
        public string ComparationDate(string ttr)
        {
            string dateJour = DateTime.Today.ToString("dd/MM/yyyy");
            char a ;
            string val = "";
            int i = 0;
            int j = 0;
            //MessageBox.Show("Chemin = " + ttr);
            
            foreach(char c in ttr)
            {
                if(i == 0)
                {
                    a = c;
                    i++;
                }
                else
                {
                    val += c;
                    if (i == 2)
                    {
                        val += "/";
                        j++;
                        i = 0;
                        if (j == 2)
                        {
                            i = 4;
                        }                       
                    }
                    i++;
                }                
            }
            //MessageBox.Show("Chemin = " + val);
            return val;
        }
        public void Fouille()
        {
            //***********************************************
            //*************Les variables*********************
            //***********************************************
            string etat = "";
            DateTime date = DateTime.Now;
            string date1 = "";
            if (lang.Trim().Equals("Anglais"))
            {
                date1 = date.ToString(formats[15], cultures[1]);
            }
            else
            {
                date1 = date.ToString("dddd, dd MMMM yyyy  hh:mm:ss");
            }
            /*DateTime date = DateTime.Now;
            string date1 = date.ToString("yyyy:MM:dd  hh:mm:ss");*/
            string duree = "00:10:00";
            string virus = "";
            string scantype = "";
            string totalAnalyser = "";
            string RepScan = "";

            try
            {
                var liste = File.ReadAllLines(HistoriqueScan);

                //var liste = File.ReadAllLines(BDAutoScanVal);
                //MessageBox.Show("Taille = " + liste.Length);
                if (liste.Length > 0)
                {
                    string[] tab = { "", "", "" };
                    List<string> liste1 = new List<string>();
                    int i = 0;
                    int j = 1;
                    int k = 2;
                    int s = 3;
                    int w = 4;
                    int x = 5;
                    int y = 6;

                    foreach (string str in liste)
                    {
                        if (i == j)
                        {
                            if (lang.Trim().Equals("Anglais"))
                            {
                                virus = str + " Viruses detected";
                            }
                            else
                            {
                                virus = str + " Virus détectés";
                            }
                            j = j + 7;
                        }
                        if (i == k)
                        {
                            scantype = str;
                            k = k + 7;
                        }
                        if (i == s)
                        {
                            totalAnalyser = str;
                            s = s + 7;
                        }
                        if (i == w)
                        {
                            etat = str;
                            w = w + 7;
                        }
                        if (i == x)
                        {
                            duree = str;
                            x = x + 7;
                        }
                        if (i == y)
                        {
                            //*******************************************************
                            //*********** insertion de données dans la BD ***********
                            //*******************************************************

                            RepScan = str;
                            this.ich = this.ich + 1;
                            string sql = "insert into HistoryScan  (date,duree,TotalVirus,totalAna,typescan,Etat, chemin) values(";
                            //sql = sql + "'" + ich + "', ";
                            sql = sql + "'" + date1 + "', ";
                            sql = sql + "'" + duree + "', ";
                            sql = sql + "'" + virus + "', ";
                            sql = sql + "'" + totalAnalyser + "', ";
                            sql = sql + "'" + scantype + "', ";
                            sql = sql + "'" + etat + "', ";
                            sql = sql + "'" + RepScan + "')";

                            try
                            {
                                Boolean error = db1.insertData(sourceFile, sql);
                                if (error == true)
                                {
                                   // MessageBox.Show("Ajout Effectué . ");
                                }
                            }
                            catch (Exception ex)
                            {
                               // MessageBox.Show(ex.Message);
                            }
                            y = y + 7;
                        }
                        i++;
                    }
                }
                else
                {
                    //MessageBox.Show("Repertoire Vide. ");
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("" + ex.Message);
                /*MessageBox.Show("KOKOKOKOKOK = " + ex.Message);*/
            }
            // éffacer le contenu du fichier scanAuto // ProgramScanBDp
            try
            {
                StreamWriter writer = new StreamWriter(HistoriqueScan, false);
                writer.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception " + ex.Message);
            }
        }

        // quelle est la date du produit
        public void FouilleScanProg()
        {
            //***********************************************
            //*************Les variables*********************
            //***********************************************
            string etat = "";
            DateTime date = DateTime.Now;
            string date1 = "";
            if (lang.Trim().Equals("Anglais"))
            {
                date1 = date.ToString(formats[15], cultures[1]);
            }
            else
            {
                date1 = date.ToString("dddd, dd MMMM yyyy  hh:mm:ss");
            }
            /*DateTime date = DateTime.Now;
            string date1 = date.ToString("yyyy:MM:dd  hh:mm:ss");*/
            string duree = "00:10:00";
            string virus = "";
            string scantype = "";
            string totalAnalyser = "";
            string RepScan = "";

            try
            {
                var liste = File.ReadAllLines(HistoriqueScan);
             
                string[] tab = { "", "", "" };
                List<string> liste1 = new List<string>();
                int i = 0;
                int j = 1;
                int k = 2;
                int s = 3;
                int w = 4;
                int x = 5;                
                int y = 6;                

                foreach (string str in liste)
                {
                    if (i == j)
                    {
                        if (lang.Trim().Equals("Anglais"))
                        {
                            virus = str + " Viruses detected";
                        }
                        else
                        {
                            virus = str + " Virus détectés";
                        }
                        j = j + 7;
                    }
                    if (i == k)
                    {
                        scantype = str;
                        k = k + 7;
                    }
                    if (i == s)
                    {
                        totalAnalyser = str;
                        s = s + 7;
                    }
                    if (i == w)
                    {
                        etat = str;
                        w = w + 7;
                    }
                    if (i == x)
                    {
                        duree = str;
                        x = x + 7;
                        //MessageBox.Show("Heure = " + str);
                    }
                    if (i == y)
                    {
                        //*******************************************************
                        //*********** insertion de données dans la BD ***********
                        //*******************************************************
                        RepScan = str;
                        this.ich = this.ich + 1;
                        string sql = "insert into HistoryScan  (date,duree,TotalVirus,totalAna,typescan,Etat, chemin) values(";
                        //sql = sql + "'" + ich + "', ";
                        sql = sql + "'" + date1 + "', ";
                        sql = sql + "'" + duree + "', ";
                        sql = sql + "'" + virus + "', ";
                        sql = sql + "'" + totalAnalyser + "', ";
                        sql = sql + "'" + scantype + "', ";
                        sql = sql + "'" + etat + "', ";
                        sql = sql + "'" + RepScan + "')";

                        try
                        {
                            Boolean error = db1.insertData(sourceFile, sql);
                            if (error == true)
                            {
                                //MessageBox.Show("Ajout Effectué . ");
                            }
                        }
                        catch (Exception ex)
                        {
                            //MessageBox.Show(ex.Message);
                        }
                        y = y + 7;
                    }
                    i++;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("" + ex.Message);
                /*MessageBox.Show("KOKOKOKOKOK = " + ex.Message);*/
            }
            // éffacer le contenu du fichier scanAuto // ProgramScanBDp --> HistoriqueScan
            try
            {
                StreamWriter writer = new StreamWriter(HistoriqueScan, false);
                writer.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception " + ex.Message);
            }
        }

        // verification de la version d'évaluation
        public string Validité()
        {
            var list = File.ReadAllLines(VersionEssaie);
            int i = 0;
            string date = "";
            foreach(string er in list)
            {
                if (i == 1)
                {
                    date = er;
                }
                i++;
            }

            return date;
        }
        
        public void EcrireFichier(string lg, string lg2, string chemin)
        {
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter(chemin);
                //Write a line of text
                sw.WriteLine(lg);
                sw.WriteLine(lg2);
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        // suivi chargement de fichier
        public void LoadFile()
        {
            var liste = File.ReadAllLines(QuarantaineBD);
            List<string> files = new List<string>();
            int i = 0;
            int j = 0;
            string[] tab1 = new string[] { "", "", "", "", "" };
            string[] tab2 = new string[] { "", "", "", "" };

            foreach (string file in liste)
            {
                if (i < 5)
                {
                    tab1[i] = file;
                    //MessageBox.Show("i = "+i+" Val = "+file);
                }
                else
                {
                    tab2[j] = file;
                    //MessageBox.Show("i = " + i + " Val = " + file);
                    j++;
                    if (j >= 4)
                    {
                        i = -1;
                        j = 0;
                        int a = 0;

                        for (int t = 0; t <= 8; t++)
                        {
                            if (t < 4)
                            {
                                files.Add(tab2[t]);
                            }
                            else
                            {
                                files.Add(tab1[a]);
                                a++;
                            }
                        }
                        a = 0;
                    }
                }
                i++;
            }
            // ici nous on écris dans un fichier.
            
            File.WriteAllLines(TOTO, files);            
        }
        public void RemplirQuarantaine()
        {
            LoadFile();
            var liste = File.ReadAllLines(TOTO);
            CleanFile(QuarantaineBD);
            
            int t = 0;
            int u = 0;
           
            string chemin = "";
            string fileName = "";
            string NewDirectory = "";
            DateTime date = DateTime.Now;
            //string date1 = date.ToString("dddd, dd MMMM yyyy  hh:mm:ss");
            string date1 = "";
            if (lang.Trim().Equals("Anglais"))
            {
                date1 = date.ToString(formats[15], cultures[1]);
            }
            else
            {
                date1 = date.ToString("dddd, dd MMMM yyyy  hh:mm:ss");
            }
            string taille = "200";
            string Etat = "";
            string editeur = "DrakaShield";
            string action = "Mettre en quarantaine";
            string detection = "" ;

            foreach (string ls in liste)
            {
                if (t == 0)
                {
                    Etat = "Infected";
                    //MessageBox.Show("Etat = " + Etat);
                }
                if (t == 3)
                {
                    detection = ls;
                    //MessageBox.Show("detection = " + detection);
                }
                if (t == 4)
                {
                    chemin = ls;
                    //MessageBox.Show("chemin = " + chemin);
                }
                if (t == 5)
                {
                    fileName = ls;
                    //MessageBox.Show("fileName = " + fileName);
                }
                if (t == 6)
                {
                    NewDirectory = ls;
                    //MessageBox.Show("NewDirectory = " + NewDirectory);
                }
                t++;
                u++;
                
                if(u == 9)
                {
                    try
                    {                        
                        //*******************************************************
                         //*********** insertion de données dans la BD ***********
                         //*******************************************************
                        
                        string sql = "insert into Quarantaine (chemin,nomfichier,nouveldirection,date,taille,etat,editeur,action,detection) values(";
                        //sql = sql + "'" + index + "', ";
                        sql = sql + "'" + chemin + "', ";
                        sql = sql + "'" + fileName + "', ";
                        sql = sql + "'" + NewDirectory + "', ";
                        sql = sql + "'" + date1 + "', ";
                        sql = sql + "'" + taille + "', ";
                        sql = sql + "'" + Etat + "', ";
                        sql = sql + "'" + editeur + "', ";
                        sql = sql + "'" + action + "', ";
                        sql = sql + "'" + detection + "')";

                        try
                        {
                            Boolean error = db1.insertData(sourceFile, sql);
                            if (error == true)
                            {
                                //MessageBox.Show("Ajout Effectué . ");
                            }
                        }
                        catch (Exception ex)
                        {
                            //AutoClosingMessageBox.Show(""+ex.Message);
                            MessagesShow yo = new MessagesShow(ex.Message, "");
                        }
                    }
                    catch(Exception e)
                    {
                        //AutoClosingMessageBox.Show(e.Message);
                        MessagesShow yo = new MessagesShow(e.Message, "");
                    }
                    u = 0;
                    t = 0;
                }
            }
            // éffacer le contenue d'un fichier
            try
            {
                CleanFile(TOTO);
            }
            catch(Exception ex)
            {
                //MessageBox.Show("" + ex.Message);
                MessagesShow yo = new MessagesShow(ex.Message, "");
            }            
        }

        //Ici on écrit beaucoup de recherche
        public void CleanFile(string rep)
        {
            // éffacer le contenu du fichier scanAuto // ProgramScanBDp
            try
            {
                StreamWriter writer = new StreamWriter(rep, false);
                writer.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception " + ex.Message);
            }
        }
        public void EcrireFichier2(string lg, string chemin)
        {
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter(chemin);
                //Write a line of text
                sw.WriteLine(lg);
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
        public string CalateDate(string date)
        {
            string str = "";
            int o = 0;
            int j = 0;
            int k = 0;
            string jour = "";
            string Mois = "";
            

            if((ConvDateJour(date)+15) < 31)
            {
                o = (ConvDateJour(date) + 15);
                j =  ConvDateMois(date) ;
               
                if (o < 10)
                {
                    jour = "0" + o;
                }
                if(j < 10)
                {
                    Mois = "0" + j;
                }
                if (o >= 10)
                {
                    jour = o.ToString();
                }
                if(j >= 10)
                {
                    Mois = j.ToString();
                }
                
                str = jour + "/" + Mois + "/" + (ConvDateAnnee(date));
            }
            else
            {
                o = (ConvDateJour(date) + 15);

                if((o - 30) > 0)
                {
                    j = (ConvDateMois(date) + 1);                    
                    o = (o - 30);

                    if(j >= 12)
                    {
                        j = (j - 12);

                        if (o < 10)
                        {
                            jour = "0" + o;
                        }
                        if (j < 10)
                        {
                            Mois = "0" + j;
                        }
                        if (o >= 10)
                        {
                            jour = o.ToString();
                        }
                        if (j >= 10)
                        {
                            Mois = j.ToString();
                        }

                        k = (ConvDateAnnee(date) + 1);

                        str = jour + "/" + Mois + "/" + (k);
                    }
                    else
                    {
                        if (o < 10)
                        {
                            jour = "0" + o;
                        }
                        if (j < 10)
                        {
                            Mois = "0" + j;
                        }
                        if (o >= 10)
                        {
                            jour = o.ToString();
                        }
                        if (j >= 10)
                        {
                            Mois = j.ToString();
                        }

                        str = jour + "/" + Mois + "/" + (ConvDateAnnee(date));
                    }
                }
            }

            return str;
        }
        
        // fonctions du produit Activé

        public void Pactivation()
        {
            // produit actif
            try
            {
                InitializeComponent();
                IntitialisationScan();

                Activation adr = new Activation();
                string rr = "";
                //MessageBox.Show("Etape1");

                this.lang = charge(Langues);
                this.ControlParental = charge(ActivatonCP);
                this.variable22 = charge(FichierUpdateData);

                // vérification de la recherche des mises à jour des bases de données virale

                if (variable22.Equals("Automatique"))
                {
                    guna2CustomCheckBox19.Checked = true;
                }
                else
                {
                    guna2CustomCheckBox18.Checked = true;
                }

                if (lang.Equals("Anglais"))
                {
                    LangueA();
                    guna2CustomCheckBox6.Checked = true;
                }
                else
                {
                    LangueF();
                    guna2CustomCheckBox8.Checked = true;
                }

                if (lang.Equals("Anglais"))
                {
                    //title3.Text = "Your product is activated . ";
                    title3.Text = " ";
                    title3.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    //title3.Text = "Votre produit est bien Activé . ";
                    title3.Text = " ";
                    title3.ForeColor = System.Drawing.Color.Green;
                }

                //MessageBox.Show("Etape2");
                choix = "";
                guna2CustomCheckBox4.Checked = verif;
                guna2CustomCheckBox7.Checked = true;

                this.l = 0;
                this.ll = 0;
                //MessageBox.Show("ControlParental = " + ControlParental);
                // activation désactivation controle parentale
                if (ControlParental.Equals("Activé"))
                {
                    guna2CustomCheckBox11.Checked = true;                    
                }
                else
                {
                    guna2CustomCheckBox10.Checked = true;                    
                }
                
                ChargementScan();
                
                // création ou vérification de l'existance de la base de données
                try
                {
                    sourceFile = db1.createDatabase(name_db);
                    //db1.CreateTable(sourceFile, "Chiarita");
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Exception : " + ex);
                }
                
                // démarrer l'application scan programmé
                
                if (variable22.Equals("Automatique"))
                {
                    string op = DaownloardServer(variable22);
                    MessageBox.Show("variable22 = " + variable22);
                    if (op.Equals("true"))
                    {
                        if (lang.Trim().Equals("Anglais"))
                        {
                            MessagesShow yop = new MessagesShow("Restarting in a moment", "", "Update");
                        }
                        else
                        {
                            MessagesShow yop = new MessagesShow("Redémarrage dans un instant", "", "Mise à jour");
                        }

                        //Application.Restart();
                    }
                    else
                    {
                        if (lang.Trim().Equals("Anglais"))
                        {
                            MessagesShow yoos = new MessagesShow("No update available", "", "Update");
                        }
                        else
                        {
                            MessagesShow yoos = new MessagesShow("Aucune mise à jour disponible", "", "Mise à jour");
                        }
                    }
                    //MessageBox.Show("je suis le verif de l'update virale.");
                }
                else
                {
                    //MessageBox.Show("toto");
                    //VerifUpdate();
                    //File.WriteAllText(VersionBD_Viral, this.a);
                }
                
                startHome(); 
         
                // lancement scanAutomatique
                /*if (verifTout == true)
                {
                    //ProcessStartInfo startInfo = new ProcessStartInfo(pathAutoScan);startInfo.Execute(pathAutoScan);
                    Process P1 = Process.Start(pathAutoScan); // Affichage3
                }*/
                //MessageBox.Show("Etape6");
                try
                {
                    foreach (string tt in tableauMac)
                    {
                        rr = adr.GetDateExpiration(tt);
                    }
                    EcrireFichier2(rr, ActivationKey1);
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                    MessagesShow yo = new MessagesShow(ex.Message, "");
                }
                //MessageBox.Show("Démarrage Terminé");
            }
            catch (Exception ex)
            {
                if (lang.Equals("Anglais"))
                {
                    //AutoClosingMessageBox.Show("Start in progress");
                    MessagesShow yo = new MessagesShow("Start in progress... ");
                }
                else
                {
                    //AutoClosingMessageBox.Show();
                    MessagesShow yo = new MessagesShow("Demarrage encours... ");
                }
            }
            
            // vérification des mises à jour disponible.
            //UpdateBasisViral(html);
        }

        // ici on recherche la clé d'activation du produit
        MessagesShow yo = new MessagesShow("Demarrage encours... ");
        public async void sendData(string URI, string myParameters)
        {
            using (HttpClient hc = new HttpClient())
            {
                var response = await hc.PostAsync(URI, new StringContent(myParameters));
            }
        }

        // Calcul de la version d'évaluation
        public string CalculEval(string dateJ, string top)
        {
            // j'ajoute à cette date 15 jours et j'obtient

            string str = "";
            string code = "";
           
            try
            {
                var date = dateJ.Split('/', '-', '.');

                if (date[0].Length <= 2)
                {
                    string val = date[0].ToString();
                    string Mois = date[1].ToString();
                    string Annee = date[2].ToString();
                    int jour = 0;

                    if (top.Equals("E"))
                    {
                        jour = Int32.Parse(val) + 15;
                    }
                    else if (top.Equals("C"))
                    {
                        //jour = Int32.Parse(val) + 5;
                        jour = Int32.Parse(val);
                    }

                    if (jour <= 31)
                    {
                        //str = jour.ToString() + date[1].ToString() + date[2].ToString();
                        string tot = "";
                        if (jour < 10)
                        {
                            tot = string.Concat("0", jour);
                        }
                        else
                        {
                            tot = jour.ToString();
                        }
                        str = string.Concat(tot, date[1].ToString(), date[2].ToString());
                    }
                    else
                    {
                        int jj = jour - 31;
                        int mm = (Int32.Parse(Mois) + 1);
                        string tot = "";
                        if (jj < 10)
                        {
                            tot = string.Concat("0", jj);
                        }
                        else
                        {
                            tot = jj.ToString();
                        }
                        if ((mm) <= 12)
                        {
                            if ((mm) < 10)
                            {
                                str = string.Concat(tot, "0" + mm.ToString(), Annee);
                            }
                            else
                            {
                                str = string.Concat(tot, mm.ToString(), Annee);
                            }
                        }
                        else
                        {
                            int YYYY = (Int32.Parse(Annee) + 1);

                            str = string.Concat(tot, "01", YYYY.ToString());
                        }
                    }
                    // je cripte le code et je retourne

                    str = string.Concat(top, str);
                    code = CryptoCode(str);
                }
                else
                {
                    string val = date[2].ToString();
                    string Mois = date[1].ToString();
                    string Annee = date[0].ToString();
                    int jour = 0;

                    if (top.Equals("E"))
                    {
                        jour = Int32.Parse(val) + 15;
                    }
                    else if (top.Equals("C"))
                    {
                        //jour = Int32.Parse(val) + 5;
                        jour = Int32.Parse(val) ;
                    }

                    if (jour <= 31)
                    {
                        string tot = "";
                        if (jour < 10)
                        {
                            tot = string.Concat("0", jour);
                        }
                        else
                        {
                            tot = jour.ToString();
                        }
                        str = string.Concat(tot, date[1].ToString(), date[2].ToString());
                 
                    }
                    else
                    {
                        int jj = jour - 31;
                        int mm = (Int32.Parse(Mois) + 1);
                        string tot = "";
                        if (jj < 10)
                        {
                            tot = string.Concat("0", jj);
                        }
                        else
                        {
                            tot = jj.ToString();
                        }
                        if ((mm) <= 12)
                        {
                            if((mm < 10))
                            {
                                str = string.Concat(tot, "0"+mm.ToString(), Annee);
                            }
                            else
                            {
                                str = string.Concat(tot, mm.ToString(), Annee);
                            }
                        }
                        else
                        {
                            int YYYY = (Int32.Parse(Annee) + 1);

                            str = string.Concat(tot, "01", YYYY.ToString());
                        }
                    }
                    // je cripte le code et je retourne

                    str = string.Concat(top, str);
                    //MessageBox.Show("strsup = " + str);
                    code = CryptoCode(str);
                }

            }
            catch(Exception ex)
            {
                //MessageBox.Show("Exception = " + ex);
                Console.WriteLine("Exception = " + ex);
            }
            return code;
        }

        // pour le produit activé
        public string CalculEvalProAct(string dateJ, string top)
        {
            // j'ajoute à cette date 15 jours et j'obtient
            string str = "";
            string code = "";

            try
            {
                var date = dateJ.Split('/');

                int a = 1;
                string tep = "";
                string[] tab = { "", "", "" };
                foreach (char toop in dateJ)
                {
                    a++;
                    tep = tep + toop;

                    if (a == 2)
                    {
                        tab[a] = tep;
                        tep = "";
                        a = 0;
                    }
                }
                string val = tab[0];
                string Mois = tab[1];
                string Annee = tab[2];

                int jour = Int32.Parse(val) + 5;
            
                if (jour <= 31)
                {
                    //str = jour.ToString() + date[1].ToString() + date[2].ToString();
                    string tot = "";
                    if (jour < 10)
                    {
                        tot = string.Concat("0", jour);
                    }
                    else
                    {
                        tot = jour.ToString();
                    }
                    str = string.Concat(tot, date[1].ToString(), date[2].ToString());
                   
                }
                else
                {
                    int jj = jour - 31;
                    int mm = (Int32.Parse(Mois) + 1);
                    string tot = "";
                    if (jj < 10)
                    {
                        tot = string.Concat("0", jj);
                    }
                    else
                    {
                        tot = jj.ToString();
                    }
                    if ((mm) <= 12)
                    {
                        str = string.Concat(tot, mm.ToString(), Annee);
                        //MessageBox.Show("LPD2 = " + str);
                    }
                    else
                    {
                        //int YYYY = int.Parse(Annee) + 1;
                        int YYYY = (Int32.Parse(Annee) + 1);

                        //str = jj + "01" + YYYY;
                        str = string.Concat(tot, "01", YYYY.ToString());
                        //MessageBox.Show("LPD3 = " + str);
                    }
                }
                // je cripte le code et je retourne

                str = string.Concat(top, str);
                //MessageBox.Show("strsup = " + str);
                code = CryptoCode(str);
            }
            catch(Exception ex)
            {
                //MessageBox.Show("Exception = " + ex);
                //Console.WriteLine("Exception = " + ex);
            }

            return code;
        }
        // crypter le string
        public string CryptoCode(string str)
        {
            string code = "";
            
            foreach (char c in str)
            {
                if (c.Equals('0'))
                {
                    code = code + "95";
                }
                if (c.Equals('1'))
                {
                    code = code + "06";
                }
                if (c.Equals('2'))
                {
                    code = code + "17";
                }
                if (c.Equals('3'))
                {
                    code = code + "28";
                }
                if (c.Equals('4'))
                {
                    code = code + "39";
                }
                if (c.Equals('5'))
                {
                    code = code + "40";
                }
                if (c.Equals('6'))
                {
                    code = code + "51";
                }
                if (c.Equals('7'))
                {
                    code = code + "62";
                }
                if (c.Equals('8'))
                {
                    code = code + "73";
                }
                if (c.Equals('9'))
                {
                    code = code + "84";
                }
                if (c.Equals('E'))
                {
                    code = code + "99";
                }
                if (c.Equals('C'))
                {
                    code = code + "88";
                }
            }
            return code;
        }

        // Décrypter le code reçu du régistre
        public string DeCryptoCode(string str)
        {
            string code = "";
            string to = "";
            int i = 0;  
            string[] tab = { "95", "06", "17", "28", "39", "40", "51", "62", "73", "84", "99", "88" };
            string[] tad = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "E", "C" };

            foreach (char c in str)
            {
                to = to + c;
                i++;
                if(i == 2)
                {
                    if (tab.Contains(to))
                    {
                        int index = Array.IndexOf(tab, to);
                        code = code + tad[index];
                        i = 0;
                        to = "";
                    }
                }
            }
                return code;
        }
        // écrire dans le régistre de ma machine

        public void EcrireDansRegistre(string str)
        {
            Int64 val = 0;
            val = Int64.Parse(str);
            Registry.SetValue(keyName, "Keys", val, RegistryValueKind.QWord);            
        }

        // lire dans le régistre
        public string ReadRegOwner(string dir)
        {
            string str = "Rien";

            RegistryKey key = Registry.CurrentUser.OpenSubKey(dir, false);

            if (key == null)
            {
                str = "Rien";
            }
            else
            {
                RegistrySecurity rs = key.GetAccessControl();
                IdentityReference owner = rs.GetOwner(typeof(System.Security.Principal.NTAccount));
                str = owner.ToString();
            }

            return str;
        }
        public string LireDansRegistre()
        {
            string val = "";

            string dir = @"Software\DrakaScheld_av";
            string owner = ReadRegOwner(dir);

            try
            {
                if (owner.Equals("Rien"))
                {
                    val = "";
                }
                else
                {
                    long tLong = (long)Registry.GetValue(keyName, "Keys", long.MinValue);
                    val = tLong.ToString();
                }

            }
            catch(Exception e)
            {
                val = "";
                //MessageBox.Show("exit = " + e.Message);
            }
            //MessageBox.Show("version = " + val);
            return (val);
        }

        // Version de l'application, d'évaluation et Activée
        public string VerifVersionApp()
        {
            string version = "";
            try
            {
                version = DeCryptoCode(LireDansRegistre());
                //MessageBox.Show("version = " + version);
                // on rentre dans le régistre cherché le code de l'application qu'on save dans version

                if (version.Equals(""))
                {
                    version = "Rien";
                }
                else
                {
                    foreach (char c in version)
                    {
                        if (c.Equals('E'))
                        {
                            version = "Evaluation";
                        }
                        if (c.Equals('C'))
                        {
                            version = "Complete";
                        }
                    }
                }

            }catch(Exception ex)
            {
                version = "Rien";
            }
           // MessageBox.Show("versionf = " + version);
            return (version);
        }

        //Connexion à internet
        public string VerifInternet()
        {
            Activation act = new Activation();
            string conn = act.LoadServer();          
            Boolean vef = act.GetMacAdress();
            string tatat = "";
            string clé = "";

            string[] valeur = { "", "" };
            //MessageBox.Show("Val vef = " + vef);
            // on prend la date du systeme encours

            string dateJour = DateTime.Today.ToString("dd/MM/yyyy");
            int a = ConvDateAnnee(dateJour);
            int aM = ConvDateMois(dateJour);
            int aJ = ConvDateJour(dateJour);

            //MessageBox.Show("Date Jour : "+dateJour);

            if ( vef == true)
            {                
                try
                {
                    // @mac existe dans le serveur distant
                    //MessageBox.Show("votre adresse mac est enrégistré dans le serveur distant.");
                    // - 1 - récupérer du serveur distant, la date d'activation et d'expiration du produit
                    valeur = act.GetDateActionClient();
                    clé = act.GetActivationKey();
                    // Ajouter ces valeurs au fichier ActivationKey1                    
                    //MessageBox.Show("Clé activation trouvé = "+clé);
                    if (clé.Equals(""))
                    {                        
                        var liste = File.ReadAllLines(VersionEssaie);
                        string dateE = "";
                        string[] date = { "", "" };
                        int i = 0;
                        //MessageBox.Show("Votre produit n'est pas activé, vous utilisez une version d'éssaie ");
                        foreach (string str in liste)
                        {
                            date[i] = str;

                            // ici on ne va chercher les valeur enrégistrés dans le navigateur.
                            if (i == 1)
                            {
                                dateE = str;
                                break;
                            }                           
                            i++;

                        }

                        // ici je vais validée la période d'essaie --> VersionEssaie

                        i = ConvDateMois(dateE);

                        if (a == ConvDateAnnee(dateE))
                        {
                            if (aM == i)
                            {
                                if (aJ < ConvDateJour(dateE))
                                {
                                    // nous somme dans la période d'essaie.
                                    tatat = "enableE";
                                    ChargementCP("enableE", ActivationDraka);
                                }
                                else
                                {
                                    // La période d'évaluation expirée
                                    tatat = "expiredE";
                                    ChargementCP("expiredE", ActivationDraka);
                                }
                            }
                            else
                            {
                                if ((ConvDateJour(date[1]) - aJ + 30) <= 14)
                                {
                                    // nous somme dans la période d'essaie
                                    tatat = "enableE";
                                    ChargementCP("enableE", ActivationDraka);
                                }
                                else
                                {
                                    // La période d'évaluation expirée
                                    tatat = "expiredE";
                                    ChargementCP("expiredE", ActivationDraka);
                                }
                            }
                        }
                        else
                        {
                            if (aM == i)
                            {
                                // La période d'évaluation expirée
                                tatat = "expiredE";
                                ChargementCP("expiredE", ActivationDraka);
                            }
                            else
                            {
                                if (ConvDateMois(date[0]) == 12 && i == 1)
                                {
                                    if (aM == 12)
                                    {
                                        if (aJ >= ConvDateJour(date[0]))
                                        {
                                            tatat = "enableE";
                                            ChargementCP("enableE", ActivationDraka);
                                        }
                                        else
                                        {
                                            tatat = "expiredE";
                                            ChargementCP("expiredE", ActivationDraka);
                                        }
                                    }
                                    else
                                    {
                                        if (aJ <= ConvDateJour(date[1]))
                                        {
                                            tatat = "enableE";
                                            ChargementCP("enableE", ActivationDraka);
                                        }
                                        else
                                        {
                                            tatat = "expiredE";
                                            ChargementCP("expiredE", ActivationDraka);
                                        }
                                    }
                                }
                                else
                                {
                                    tatat = "expiredE";
                                    ChargementCP("expiredE", ActivationDraka);
                                }
                            }
                        }
                    }
                    else
                    {
                        StreamWriter sw = new StreamWriter(ActivationKey1);

                        sw.WriteLine(valeur[0]);
                        sw.WriteLine(valeur[1]);

                        sw.Close();

                        int b = ConvDateAnnee(valeur[1]);
                        int bM = ConvDateMois(valeur[1]);
                        int bJ = ConvDateJour(valeur[1]);

                        int actA = ConvDateAnnee(valeur[0]);
                        int actM = ConvDateMois(valeur[0]);
                        // on vérifie la date de validité du produit

                        int validité = actM + 12;

                        if( (a - actA) == 1)
                        {
                            int c = validité - 12;

                            if(aM <= c)
                            {
                                // produit actif
                                tatat = "enable";
                                //ChargementCP("Activé", ActivationDraka);
                            }
                            else
                            {
                                // produit inactif
                                tatat = "expired";
                                ChargementCP("Expiré", ActivationDraka);
                            }
                        }
                        else if( (a - actA) == 0)
                        {                            
                            // produit actif
                            tatat = "enable";
                            //ChargementCP("Activé", ActivationDraka);
                        }

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                    // ici on ira faire la lecture du fichier interne pour verifier si l'activation du produit est fait.
                    var liste = File.ReadAllLines(ActivationKey1);

                    foreach(string str in liste)
                    {
                        if (str.Equals(dateJour))
                        {
                            // produit périmé
                            tatat = "expired";
                            ChargementCP("expired", ActivationDraka);
                        }
                        else
                        {
                            // produit toujours actif
                            tatat = "enable";
                            //ChargementCP("Activé", ActivationDraka);
                        }
                    }
                }                
            }
            else
            {
                // l'@ mac n'existe pas on va faire reference au fichier en local

                var liste = File.ReadAllLines(ActivationKey1);

                foreach (string str in liste)
                {
                    if (str.Equals(dateJour))
                    {
                        // produit périmé
                        tatat = "expiredE";
                        ChargementCP("", ActivationDraka);
                    }
                    else
                    {
                        // produit toujours actif
                        tatat = "enableE";
                    }
                }
            }          

            return tatat;
        }

        
        // recherche l'adresse mac

        public string[] AdresseMac()
        {
            string[] tab = { "", "" };

            System.Management.ManagementClass myManagementClass = new System.Management.ManagementClass("Win32_NetworkAdapterConfiguration");
            System.Management.ManagementObjectCollection moc = myManagementClass.GetInstances();
            
            int i = 0;

            foreach (System.Management.ManagementObject mo in moc)
            {
                if (mo["MacAddress"] != null)
                {
                    if (i == 2)
                    {
                        break;
                    }
                    //MessageBox.Show(": "+i);
                    tab[i] = mo["MacAddress"].ToString();
                    i++;
                    
                }
            }

            return (tab);
        }
        // End recherche activation key

        public void LangueChoix2(string lg)
        {
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter(Langues);
                //Write a line of text
                sw.WriteLine(lg);
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("ok");            
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            startHome();
            pagesView.SelectTab("home");
        }
        // démarrage application
        public void ChargementScan()
        {          
            foreach (var process in Process.GetProcesses())
            {
                if (process.ProcessName.Equals("DrakaScanAuto"))
                {
                    process.Kill();
                    //MessageBox.Show("Scan automatique arrêté ");
                }else if (process.ProcessName.Equals("DrakaSchedScan"))
                {
                    process.Kill(); 
                    //MessageBox.Show("Scan programmé arrêté ");
                }
                //MessageBox.Show($"{process.ProcessName}");
                /**/
            }
            // démarage de l'application
            try
            {
                foreach (var process in Process.GetProcesses())
                {
                    if (process.ProcessName.Equals("DrakaSchedScan"))
                    {
                        process.Kill();
                    }
                    //MessageBox.Show($"{process.ProcessName}");
                }
                Process P11 = Process.Start(ProgrammerScan);
               
                if(verifTout == true)
                {
                    Process P1 = Process.Start(pathAutoScan); // Affichage3
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Exception : " + ex);
            }
        }

        // chargement date
        public string charge(string rep)
        {
            string val = "";

            try
            {
                //Créez une instance de StreamReader pour lire à partir d'un fichier
                using (StreamReader sr = new StreamReader(rep))
                {
                    string line;
                    // Lire les lignes du fichier jusqu'à la fin.
                    while ((line = sr.ReadLine()) != null)
                    {
                        val = line.Trim();
                    }
                }
            }
            catch (Exception e)
            {
                //MessageBox.Show("Le fichier n'a pas pu être lu.");
                //MessageBox.Show(e.Message);
                MessagesShow yo = new MessagesShow(e.Message, "");
            }
            return val;
        }

        public void ChargementCP(string cp, string chemin)
        {
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter(chemin);//(ActivatonCP);
                //Write a line of text
                sw.WriteLine(cp);
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }


        // démarer le MediaPlayer
        private void startHome()
        {
            refreshData12();

            string date1 = DateTime.Today.ToString("dd/MM/yyyy");
            // l'heure Actuelle est :
            //string date1 = dateJour.ToString();
            //MessageBox.Show("Etape2 = "+ dateJour);
            // -1- rechercher l'heure du dernier site dansgeureux enregistré dans l'objectionalwebsite

            int temps = 0;
            int temps7= 0;
            string datep = "";

            virisScan = LectureScanAuto();          
            string date = charge(Datewebsite);
            //MessageBox.Show("date = " + date);
            foreach (char c in date)
            {
                datep += c;
                temps7 = temps7 + 1;
                if(temps7 == 10)
                {
                    break;
                }
            }
            //MessageBox.Show("datep = " + datep);
            // je fais la différence de date
            int val = CalculDateVal(datep, date1);
            int toto = 0;
            /*MessageBox.Show("date1 = " + datep);
            MessageBox.Show("date2 = " + date1);*/
            if (val < 0)
            {
                toto = val * (-1);
            }
            else
            {
                toto = val;
            }

            temps = toto*24;

            /*MessageBox.Show("temps = " + temps);
            MessageBox.Show("date = " + date);*/

            if (virisScan > 0)
            {
                if ( (temps <= 0 && (date.Equals(""))) || (temps > 72)  )
                {
                    this.guna2PictureBox1.Image = global::Draka_Antivirus.Properties.Resources.Red;

                    if (lang.Trim().Equals("Anglais"))
                    {
                        label1.Text = "Your pc  is infected".ToUpper();
                        label1.Location = new System.Drawing.Point(300, 360);
                    }
                    else
                    {
                        label1.Text = "Votre pc est infecté".ToUpper();
                        label1.Location = new System.Drawing.Point(300, 360);
                    }

                    label1.ForeColor = System.Drawing.Color.Red;
                }
                if ( (temps <= 0 && (!date.Equals(""))) || (temps > 0 && (temps <= 72)) || CodeCouleur.Equals("KO"))
                {
                    this.guna2PictureBox1.Image = global::Draka_Antivirus.Properties.Resources.Yellow;

                    if (lang.Trim().Equals("Anglais"))
                    {
                        label1.Text = "Potential threats".ToUpper();
                        label1.Location = new System.Drawing.Point(300, 360);
                    }
                    else
                    {
                        label1.Text = "Menaces potentielles".ToUpper();
                        label1.Location = new System.Drawing.Point(300, 360);
                    }

                    label1.ForeColor = System.Drawing.Color.Orange;
                }
                
            }
            else
            {
                if (temps <= 0 && (date.Equals("")) )
                {
                    this.guna2PictureBox1.Image = global::Draka_Antivirus.Properties.Resources.Screen;
                    if (lang.Trim().Equals("Anglais"))
                    {
                        label1.Text = "YOUR PC IS PROTECTED";
                        label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(177)))), ((int)(((byte)(76)))));
                        label1.Location = new System.Drawing.Point(300, 360);
                        //label1.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
                        //this.guna2GradientButton1.Location = new System.Drawing.Point(372, 398);
                    }
                    else
                    {
                        label1.Text = "VOTRE PC EST PROTÉGÉ";
                        label1.Location = new System.Drawing.Point(300, 360);
                    }
                    this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(254)))));
                    label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(177)))), ((int)(((byte)(76)))));
                    //label1.ForeColor = System.Drawing.Color.Aqua;

                }
                if (temps <= 0 && (!date.Equals("")) || CodeCouleur.Equals("KO"))
                {
                    this.guna2PictureBox1.Image = global::Draka_Antivirus.Properties.Resources.Yellow;

                    if (lang.Trim().Equals("Anglais"))
                    {
                        label1.Text = "Potential threats".ToUpper();
                        label1.Location = new System.Drawing.Point(300, 360);
                    }
                    else
                    {
                        label1.Text = "Menaces potentielles".ToUpper();
                        label1.Location = new System.Drawing.Point(300, 360);
                    }

                    label1.ForeColor = System.Drawing.Color.Orange;
                }
                if (temps > 0 && (temps <= 72) )
                {
                    this.guna2PictureBox1.Image = global::Draka_Antivirus.Properties.Resources.Yellow;

                    if (lang.Trim().Equals("Anglais"))
                    {
                        label1.Text = "Potential threats".ToUpper();
                        label1.Location = new System.Drawing.Point(300, 360);
                    }
                    else
                    {
                        label1.Text = "Menaces potentielles".ToUpper();
                        label1.Location = new System.Drawing.Point(300, 360);
                    }

                    label1.ForeColor = System.Drawing.Color.Orange;
                }
                /*if (temps > 72)
                {
                    this.guna2PictureBox1.Image = global::Draka_Antivirus.Properties.Resources.Red;

                    if (lang.Equals("Anglais"))
                    {
                        label1.Text = "Your pc  is infected".ToUpper();
                        label1.Location = new System.Drawing.Point(300, 360);
                    }
                    else
                    {
                        label1.Text = "Votre pc est infecté".ToUpper();
                        label1.Location = new System.Drawing.Point(300, 360);
                    }

                    label1.ForeColor = System.Drawing.Color.Red;
                }*/
            }


        }

        // Mise à jour de la base de données virale
        public void UpdateBasisViral(string url)
        {
            // -1- connexion au serveur distant

            Activation act = new Activation();
            int i = 0;
            var list = File.ReadAllLines(VirusBD);
            int bdTaille = list.Length;
            //MessageBox.Show("Taille Max = " + bdTaille);
            // -2- Récupération de la taille de la nouvelle base de données
            
            string taille = act.ChargementBddistante();
            //i = int.Parse(taille);
            i = 203897;
            
            // -3- Comparer la nouvelle taille à l'ancienne taille

            if(bdTaille >= i)
            {
                // aucune mise à jour disponible  variable
                //MessageBox.Show("Aucune mise à jour disponible");
            }
            else
            {
                // des mises à jours disponible de la base de données virale
                if (variable22.Equals("Automatique"))
                {
                    //MessageBox.Show("Ce message sera suprimé, car en Automatique la mise à jour virale est silencieuse.");
                    MessagesShow yo = new MessagesShow("Ce message sera suprimé, car en Automatique la mise à jour virale est silencieuse" +
                        "" +
                        "" +
                        "", "");
                    //UpdateViralBasis(url);
                }
                else
                {
                    if (lang.Trim().Equals("Anglais"))
                    {
                        //MessageBox.Show(" virus database updates available. ");
                        MessagesShow yo = new MessagesShow(" virus database updates available ", "");
                    }
                    else
                    {
                        //MessageBox.Show("des mises à jours de la base de données virale disponible.");
                        MessagesShow yo = new MessagesShow("des mises à jours de la base de données virale disponible", "");
                    }
                    //UpdateViralBasis(url);
                }
                
            }

        }
        public void UpdateViralBasis(string url)
        {         
            try
            {
                // 1 - charger le nouveau fichier de mise à jours de la base virale.

                UpdateViralBasis(html, VirusBD2);

                // 2 - Ajouter les valeur disponible dans la nouvelle mise à jour qui son absente dans l'ancienne base de données.

                List<string> list3 = new List<string>();

                var list = File.ReadAllLines(VirusBD);
                var list1 = File.ReadAllLines(VirusBD2);

                foreach(string str in list1)
                {
                    if (list.Contains(str.ToLower()))
                    {
                        // on passe
                    }
                    else
                    {
                        list3.Add(str.ToLower());
                    }
                    
                }

                File.AppendAllLines(VirusBD, list3);

            }catch(Exception ex)
            {
                MessagesShow to = new MessagesShow(ex.Message, "");

            }
        }

        //  lecture du contenu d'une balise

        public void UpdateViralBasis(string html, string chemin)
        {
            List<string> list = new List<string>();
            string documentPath = html;

            var web = new HtmlWeb();
            var doc = web.Load(documentPath);
            var Text = doc.DocumentNode.SelectNodes("//td");

            foreach (var node in Text)
            {
                if (node.InnerText.Equals(""))
                {
                    //MessageBox.Show(" : ");
                }
                else
                {
                    list.Add(node.InnerText);
                    //MessageBox.Show(" : "+node.InnerText);
                }
            }
            try
            {
                File.AppendAllLines(chemin, list);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            /*foreach (var nod in list)
            {
                MessageBox.Show(" : " + nod);
            }*/
        }

        // chemin corbeille 
        public string CheminCorbeille(string item)
        {
            string str = "";
            Shell Shl = new Shell();
            Folder Recycler = Shl.NameSpace(10);
            for (int i = 0; i < Recycler.Items().Count; i++)
            {
                FolderItem FI = Recycler.Items().Item(i);
                string FileName = Recycler.GetDetailsOf(FI, 0);
                if (FileName.Equals(item))
                {
                    if (Path.GetExtension(FileName) == "") FileName += Path.GetExtension(FI.Path);
                    //Necessary for systems with hidden file extensions.
                    string FilePath = Recycler.GetDetailsOf(FI, 1);
                    str = Path.Combine(FilePath, FileName);
                }
                                
            }
            return str;
        }
        public int LectureScanAuto()
        {
            string val = "";
            int k = 0;
            int k1 = 0;
            int t = TailleTable("Quarantaine");
            
            if(t <= 0)
            {
                try
                {
                    //Pass the filepath and filename to the StreamWriter Constructor
                    StreamWriter sw = new StreamWriter(VerifAutoScan);
                    //Write a line of text
                    sw.WriteLine(0);
                    sw.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
                k = int.Parse("0");
            }
            else
            {
                //MessageBox.Show("Oui ");
                try
                {
                    //Créez une instance de StreamReader pour lire à partir d'un fichier
                    using (StreamReader sr = new StreamReader(VerifAutoScan))
                    {
                        string line;
                        // Lire les lignes du fichier jusqu'à la fin.
                        while ((line = sr.ReadLine()) != null)
                        {
                            val = line.Trim();
                        }
                    }
                    k = int.Parse(val);
                }
                catch (Exception e)
                {
                    //MessageBox.Show("Le fichier n'a pas pu être lu.");
                    //MessageBox.Show(e.Message);
                    //MessagesShow to = new MessagesShow(e.Message, "");
                }
            }
            if(k == 0)
            {
                k1 = t;
            }
            else
            {
                k1 = k;
            }
            //MessageBox.Show("K = " + k1);
            return k1;
        }
        // calcul de la période d'activation du produit
        public int CalculDateP_Actived(string str, string date)
        {
            var dt = str.Split(new string[] { "/", ".", "-" }, StringSplitOptions.None);
            var dte = date.Split(new string[] { "/", ".", "-" }, StringSplitOptions.None);
            int val = 0;
            int valle = 0;

            if (dte[0].Length <= 2)
            {
                int[] tab2 = { Int32.Parse(dt[0]), Int32.Parse(dt[1]), Int32.Parse(dt[2]) };
                int[] tab1 = { Int32.Parse(dte[0]), Int32.Parse(dte[1]), Int32.Parse(dte[2]) };
                //MessageBox.Show("Sous Etape1.3 = " + (tab2[0] + 2) );

                DateTime date2 = new DateTime(tab1[2], tab1[1], tab1[0]);
                DateTime date1 = new DateTime(tab2[2], tab2[1], tab2[0]);

                TimeSpan Ts = date1 - date2;

                valle = (int)Ts.TotalDays;
            }
            else
            {
                int[] tab2 = { Int32.Parse(dt[0]), Int32.Parse(dt[1]), Int32.Parse(dt[2]) };
                int[] tab1 = { Int32.Parse(dte[2]), Int32.Parse(dte[1]), Int32.Parse(dte[0]) };
                //MessageBox.Show("Sous Etape1.3 = " + (tab2[0] + 2) );
                //
                DateTime date2 = new DateTime(tab1[2], tab1[1], tab1[0]);
                DateTime date1 = new DateTime(tab2[2], tab2[1], tab2[0]);

                TimeSpan Ts = date1 - date2;

                valle = (int)Ts.TotalDays;
            }

            if(valle < 0)
            {
                val = 0;
            }
            else
            {
                val = valle;
            }

            return val;
        }
        // comment faire le calcul de date.
        public int CalculDate(string str, string date)
        {
            //MessageBox.Show("Je suis la Methode de blocage ");
            var dt = str.Split(new string[] { "/", ".", "-" }, StringSplitOptions.None);
             var dte = date.Split(new string[] { "/", ".", "-" }, StringSplitOptions.None);
             //var dete; 23/03/2023 00:52:38
             int val = 0;

            try
            {
                //MessageBox.Show("Sous Etape1.2 ");
                int[] tab2 = { Int32.Parse(dt[0]), Int32.Parse(dt[1]), Int32.Parse(dt[2]) };
                int[] tab1 = { Int32.Parse(dte[0]), Int32.Parse(dte[1]), Int32.Parse(dte[2]) };
                //MessageBox.Show("Sous Etape1.3 = " + (tab2[0] + 2) );

                int[] tab3 = { (tab2[0] - tab1[0]), (tab2[1] - tab1[1]), (tab2[2] - tab1[2]) };

                if (tab2[2] == tab1[2])
                {
                    //MessageBox.Show("Sous Etape1.3.1 = " + (tab2[2]));
                    if (tab2[1] == tab1[1])
                    {
                        val = tab3[0];
                        //MessageBox.Show("val1 = " + val);
                    }
                    else
                    {
                        if ( (tab2[1] - 1) == tab1[1])
                        {
                            val = (tab2[0] + 31 - tab1[0]);
                            //MessageBox.Show("val2 = " + val);
                        }
                        else
                        {
                            val = 20;
                        }
                    }
                }
                else
                {
                    if ( (tab2[1] + 12 - tab1[1]) == tab2[1] )
                    {
                        val = ((tab2[0] + 31 - tab1[0]));
                        //MessageBox.Show("val3 = " + val);
                    }
                    else
                    {
                        val = 20;
                    }
                }

            }
            catch(Exception e)
            {
                //MessageBox.Show("Erreur Capturé et corrigé !");

                /*int a = (int)Convert.ChangeType(dt[0], typeof(int));
                int b = (int)Convert.ChangeType(dte[0], typeof(int));
                int val1 = (b - a);
                if (lang.Equals("Anglais"))
                    {
                        MessageBox.Show("This option is not possible");
                    }
                    else
                    {
                        MessageBox.Show("Cette option est impossible");
                    }
                 */
            }
            //MessageBox.Show("val = " + val);
            return val;
        }

        // calcul de date
        public int CalculDateVal(string str, string date)
        {
            //MessageBox.Show("Je suis la Methode de blocage ");
            var dt = str.Split(new string[] { "/", ".", "-" }, StringSplitOptions.None);
            var dte = date.Split(new string[] { "/", ".", "-" }, StringSplitOptions.None);
            //var dete; 23/03/2023 00:52:38
            int val = 0;
            string limite = dt[0];
            int Ltail = limite.Length;
            //MessageBox.Show("Taille Length = " + Ltail);
            
            if(Ltail == 2)
            {
                try
                {
                    //MessageBox.Show("Sous Etape1.2 ");
                    int[] tab2 = { Int32.Parse(dt[0]), Int32.Parse(dt[1]), Int32.Parse(dt[2]) };
                    int[] tab1 = { Int32.Parse(dte[0]), Int32.Parse(dte[1]), Int32.Parse(dte[2]) };
                    //MessageBox.Show("Sous Etape1.3 = " + (tab2[0] + 2) );

                    int[] tab3 = { (tab2[0] - tab1[0]), (tab2[1] - tab1[1]), (tab2[2] - tab1[2]) };

                    if (tab2[2] == tab1[2])
                    {
                        //MessageBox.Show("Sous Etape1.3.1 = " + (tab2[2]));
                        if (tab2[1] == tab1[1])
                        {
                            val = tab3[0];
                            //MessageBox.Show("val1 = " + val);
                        }
                        else
                        {
                            if ((tab2[1] - 1) == tab1[1])
                            {
                                val = (tab2[0] + 31 - tab1[0]);
                                //MessageBox.Show("val2 = " + val);
                            }
                            else
                            {
                                val = 20;
                            }
                        }
                    }
                    else
                    {
                        if ((tab2[1] + 12 - tab1[1]) == tab2[1])
                        {
                            val = ((tab2[0] + 31 - tab1[0]));
                            //MessageBox.Show("val3 = " + val);
                        }
                        else
                        {
                            val = 20;
                        }
                    }

                }
                catch (Exception e)
                {
                    // valeur.
                }
            }else if(Ltail == 3)
            {
                try
                {
                    //MessageBox.Show("Sous Etape1.2 ");
                    int[] tab2 = { Int32.Parse(dt[2]), Int32.Parse(dt[1]), Int32.Parse(dt[0]) };
                    int[] tab1 = { Int32.Parse(dte[2]), Int32.Parse(dte[1]), Int32.Parse(dte[0]) };
                    //MessageBox.Show("Sous Etape1.3 = " + (tab2[0] + 2) );

                    int[] tab3 = { (tab2[2] - tab1[2]), (tab2[1] - tab1[1]), (tab2[0] - tab1[0]) };

                    if (tab2[0] == tab1[0])
                    {
                        //MessageBox.Show("Sous Etape1.3.1 = " + (tab2[2]));
                        if (tab2[1] == tab1[1])
                        {
                            val = tab3[2];
                            //MessageBox.Show("val1 = " + val);
                        }
                        else
                        {
                            if ((tab2[1] - 1) == tab1[1])
                            {
                                val = (tab2[2] + 31 - tab1[2]);
                                //MessageBox.Show("val2 = " + val);
                            }
                            else
                            {
                                val = 20;
                            }
                        }
                    }
                    else
                    {
                        if ((tab2[1] + 12 - tab1[1]) == tab2[1])
                        {
                            val = ((tab2[2] + 31 - tab1[2]));
                            //MessageBox.Show("val3 = " + val);
                        }
                        else
                        {
                            val = 20;
                        }
                    }

                }
                catch (Exception e)
                {
                    // valeur.
                }
            }
          
            return val;
        }
        // chargement scan programme

        public void IntitialisationScan()
        {
            guna2comboBox4.Visible = false;
            guna2DateTimePicker4.Visible = false;
            guna2comboBox3.Visible = false;
            guna2DateTimePicker3.Visible = false;
        }
        // guna2comboBox2_Click
        private void guna2comboBox1_Click(object sender, EventArgs e)
        {
            verif1 = true;
            verif2 = false;
            chf(guna2comboBox1, 1);
        }

        public void chf(Guna2ComboBox cbx, int i)
        {
            if(i == 1)
            {
                string selected = guna2comboBox1.GetItemText(this.guna2comboBox1.SelectedItem);
                //MessageBox.Show("A : "+selected);
                if (selected == " ")
                {
                    guna2comboBox4.Visible = false;
                    guna2DateTimePicker4.Visible = false;
                    guna2CustomCheckBox1.Checked = false;
                    
                }
                else if (selected == "Daily" || selected == ValeurF[0])
                {
                    if (lang.Trim().Equals("Anglais"))
                    {
                        programScan = "Daily";
                        guna2comboBox4.Visible = false;
                        guna2DateTimePicker4.Visible = true;
                        guna2DateTimePicker4.Location = new Point(140, 65);
                    }
                    else
                    {
                        programScan = ValeurF[0];
                        guna2comboBox4.Visible = false;
                        guna2DateTimePicker4.Visible = true;
                        guna2DateTimePicker4.Location = new Point(140, 65);
                    }
                    
                }
                else if (selected == "Weekly" || selected == ValeurF[1])
                {
                    if (lang.Trim().Equals("Anglais"))
                    {
                        programScan = "Weekly";
                        guna2comboBox4.Visible = true;
                        guna2DateTimePicker4.Visible = true;
                        guna2DateTimePicker4.Location = new Point(262, 65);
                    }
                    else
                    {
                        programScan = ValeurF[1];
                        guna2comboBox4.Visible = true;
                        guna2DateTimePicker4.Visible = true;
                        guna2DateTimePicker4.Location = new Point(262, 65);
                    }
                    
                }
            }else if( i == 2)
            {
                string selected1 = guna2comboBox2.GetItemText(this.guna2comboBox2.SelectedItem);

                if (selected1 == " ")
                {
                    guna2comboBox3.Visible = false;
                    guna2DateTimePicker3.Visible = false;
                    guna2CustomCheckBox2.Checked = false;
                }
                else if (selected1 == "Daily" || selected1 == ValeurF[0])
                {
                    if (lang.Trim().Equals("Anglais"))
                    {
                        programScan = "Daily";
                    }
                    else
                    {
                        programScan = ValeurF[0];
                    }
                    guna2comboBox3.Visible = false;
                    guna2DateTimePicker3.Visible = true;
                    guna2DateTimePicker3.Location = new Point(230, 66);
                }
                else if (selected1 == "Weekly" || selected1 == ValeurF[1])
                {
                    if (lang.Trim().Equals("Anglais"))
                    {
                        programScan = "Weekly";
                    }
                    else
                    {
                        programScan = ValeurF[1];
                    }
                    guna2comboBox3.Visible = true;
                    guna2DateTimePicker3.Visible = true;
                    guna2DateTimePicker3.Location = new Point(357, 66);
                }
            }
        }
        private void guna2comboBox2_Click(object sender, EventArgs e)
        {
            verif1 = false;
            verif2 = true;
            chf(guna2comboBox2, 2);
        }

        private void guna2comboBox3_Click(object sender, EventArgs e)
        {
            string selected = guna2comboBox3.GetItemText(this.guna2comboBox3.SelectedItem);
            //MessageBox.Show(selected);
            jourEng = selected;
        }

        private void guna2comboBox4_Click(object sender, EventArgs e)
        {
            string selected = guna2comboBox4.GetItemText(this.guna2comboBox4.SelectedItem);
            //MessageBox.Show(selected);
            jourEng = selected;
        }
        private void ScanBtn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Ici la page scan ");
            variable = "ScanComplet";
            pagesView.SelectTab("scan");
            //MessageBox.Show("Ici la page scan ");
        }

        private void PerformanceBtn_Click(object sender, EventArgs e)
        {
            variable = "InfoSysteme";
            //MessagesShow yo = new MessagesShow("Ici la page performance.", "");
            // MessageBox.Show("Ici la page performance ");
            pagesView.SelectTab("performance");
            perfornancesview();
        }

        private void StabilityBtn_Click(object sender, EventArgs e)
        {
            variable = "Program";            
            pagesView.SelectTab("stabilite");
            ListProgram();
        }

        private void MaintainBtn_Click(object sender, EventArgs e)
        {
            variable = "Trash";
            //MessageBox.Show("Voilà ca qui commence comme les blague");
            try
            {
                pagesView.SelectTab("maintenance");
                //maintenanceViewCollection.SelectTab("fichier");
                maintenanceViewCollection.SelectTab("corbeille");
                //tempoFiles();
                recyclebin();
            }catch(Exception ex)
            {
                //MessagesShow poil = new MessagesShow(e.Messagex); 
            }
        }

        private void HistoryBtn_Click(object sender, EventArgs e)
        {
            pagesView.SelectTab("historique");
            Historicsloading7();
            //Fouille()
        }

        private void QuarantBtn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Ici la page Quarantine ");
            pagesView.SelectTab("quarant");
            QuarantaineHistoricsloading();
        }

        private void SecurityBtn_Click(object sender, EventArgs e)
        {
            variable = "AV";
            try
            {
                pagesView.SelectTab("securite");
                securityViewCollection.SelectTab("antivirus");
                //loadFirewall();
                antivirusDisplay();
            }catch(Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void Guna2Button1_Click(object sender, EventArgs e)
        {
            if (Acheter.Equals("Evaluation"))
            {
                //Remplir(abcd);
                EvaluationDraka(abcd);
            }
            else if (Acheter.Equals("Complete"))
            {
                Remplir(abcd);
            }else if (Acheter.Equals("Rien"))
            {
                EvaluationDraka(15);
            }
            //MessageBox.Show("Acheter");
            
        }

        private void Guna2ImageButton10_Click(object sender, EventArgs e)
        {
            try
            {
                var partiel = File.ReadAllLines(ProgramPartiel);
                var total = File.ReadAllLines(ProgramScan);
                int i = 0;
                int j = 0;

                if (partiel.Length != 0)
                {
                    // ici on affiche le scan partiel programmé

                    foreach (string o in partiel)
                    {
                        int index = guna2comboBox2.FindString(o);
                        int index1 = guna2comboBox3.FindString(o);
                        i++;

                        if (index != -1)
                        {
                            guna2comboBox2.Text = o;
                        }
                        if (index == -1 && index1 == -1)
                        {
                            j++;
                        }
                        if (index1 != -1)
                        {
                            guna2comboBox3.Text = o;
                        }
                        if (o.Contains(":"))
                        {
                            var val = o.Split('\\');

                            if (val.Length <= 1)
                            {
                                guna2DateTimePicker3.Text = o;
                            }
                            else
                            {
                                label104.Text = o;
                            }
                        }
                        if (j == partiel.Length)
                        {
                            if (lang.Trim().Equals("Anglais"))
                            {
                                if (partiel.Length >= 1)
                                {
                                    foreach (string oo in partiel)
                                    {
                                        if (oo.Equals("Journalier") || oo.Equals("Hebdo"))
                                        {
                                            if (oo.Equals("Journalier"))
                                            {
                                                guna2comboBox2.Text = "Daily";
                                            }
                                            if (oo.Equals("Hebdo"))
                                            {
                                                guna2comboBox2.Text = "Weekly";
                                            }
                                        }
                                        if (ValeurFS.Contains(oo))
                                        {
                                            int po = 0;

                                            foreach (string to in ValeurFS)
                                            {
                                                if (to.Equals(oo))
                                                {
                                                    guna2comboBox3.Text = ValeurFA[po];
                                                }
                                                po++;

                                            }
                                        }
                                    }

                                }
                                if (total.Length >= 1)
                                {
                                    // scan total programmé

                                    foreach (string ooo in total)
                                    {
                                        if (ooo.Equals("Journalier") || ooo.Equals("Hebdo"))
                                        {
                                            if (ooo.Equals("Journalier"))
                                            {
                                                guna2comboBox1.Text = "Daily";
                                            }
                                            if (ooo.Equals("Hebdo"))
                                            {
                                                guna2comboBox1.Text = "Weekly";
                                            }
                                        }
                                        if (ValeurFA.Contains(ooo))
                                        {
                                            int poo = 0;

                                            foreach (string to in ValeurFA)
                                            {
                                                if (to.Equals(ooo))
                                                {
                                                    guna2comboBox4.Text = ValeurFS[poo];
                                                }
                                                poo++;

                                            }
                                        }
                                    }
                                }


                            }
                            else
                            {
                                if (partiel.Length >= 1)
                                {
                                    if (partiel.Length >= 1)
                                    {
                                        foreach (string oo in partiel)
                                        {
                                            if (oo.Equals("Daily") || oo.Equals("Weekly"))
                                            {
                                                if (oo.Equals("Daily"))
                                                {
                                                    guna2comboBox2.Text = "Journalier";
                                                }
                                                if (oo.Equals("Weekly"))
                                                {
                                                    guna2comboBox2.Text = "Hebdo";
                                                }
                                            }
                                            if (ValeurFA.Contains(oo))
                                            {
                                                int poo = 0;

                                                foreach (string to in ValeurFA)
                                                {
                                                    if (to.Equals(oo))
                                                    {
                                                        guna2comboBox3.Text = ValeurFS[poo];
                                                    }
                                                    poo++;

                                                }
                                            }
                                        }

                                    }
                                    if (total.Length >= 1)
                                    {
                                        foreach (string oo in total)
                                        {
                                            if (oo.Equals("Daily") || oo.Equals("Weekly"))
                                            {
                                                if (oo.Equals("Daily"))
                                                {
                                                    guna2comboBox1.Text = "Journalier";
                                                }
                                                if (oo.Equals("Weekly"))
                                                {
                                                    guna2comboBox1.Text = "Hebdo";
                                                }
                                            }
                                            if (ValeurFA.Contains(oo))
                                            {
                                                int po = 0;

                                                foreach (string to in ValeurFA)
                                                {
                                                    if (to.Equals(oo))
                                                    {
                                                        guna2comboBox4.Text = ValeurFS[po];
                                                    }
                                                    po++;

                                                }
                                            }
                                        }

                                    }

                                }
                                // ici on change la langue
                            }

                        }

                    }
                    if (total.Length != 0)
                    {
                        // ici on affiche le scan total programmé
                        i = 0;
                        foreach (string o in total)
                        {
                            int index2 = guna2comboBox1.FindString(o);
                            int index22 = guna2comboBox4.FindString(o);

                            if (index2 != -1)
                            {
                                guna2comboBox1.Text = o;
                            }
                            if (index2 == -1 && index22 == -1)
                            {
                                i++;
                            }
                            if (index22 != -1)
                            {
                                guna2comboBox4.Text = o;
                            }
                            if (o.Contains(":"))
                            {
                                var val = o.Split('\\');

                                if (val.Length <= 1)
                                {
                                    guna2DateTimePicker4.Text = o;
                                }
                                else
                                {
                                    //label104.Text = o;
                                }
                            }
                            if (i == total.Length)
                            {
                                /*if (lang.Equals("Anglais"))
                                {
                                    MessagesShow toux = new MessagesShow("have you changed language, watch to reschedule your scan.", "");
                                    //label104.Text = "Path";
                                }
                                else
                                {
                                    MessagesShow toux = new MessagesShow("Vous avez changer de langue, veuillez programmer à nouveau votre Scan.", "");
                                    //label104.Text = "Chemin";
                                }*/
                            }

                        }

                    }

                    this.guna2Button250.Visible = false;
                    this.guna2Button60.Visible = false;
                    //MessageBox.Show("toto");
                    pagesView.SelectTab("setting");
                    // ici nous sommes dans le les programmes  
                }
                else
                {
                    //MessageBox.Show("toto");
                    this.guna2Button250.Visible = false;
                    this.guna2Button60.Visible = false;

                    pagesView.SelectTab("setting");
                }

            }
            catch(Exception) 
            {
                //MessageBox.Show("C'est ouff");
                pagesView.SelectTab("setting");;
                File.WriteAllText(ProgramPartiel, "");
                File.WriteAllText(ProgramScan, "");
            }
        }

        public void guna2CustomCheckBox4_Click(object sender, EventArgs e)
        {
            // Méthode de choix du scan automatique depuis les parametres de l'interface de l'av
            if (guna2CustomCheckBox4.Checked == true)
            {
                verif = true;
                verifTout = true;
                Process P1 = Process.Start(pathAutoScan);

                if (lang.Equals("Anglais"))
                {
                    MessagesShow to = new MessagesShow("Automatic scan Loading...", "");
                }
                else
                {
                    //MessageBox.Show("Scan automatique arrêté ");
                    MessagesShow to = new MessagesShow("Scan automatique en démarrage...", "");
                }
            }
            else
            {
                verif = false;
                verifTout = false;

                foreach (var process in Process.GetProcesses())
                {
                    if (process.ProcessName.Equals("DrakaScanAuto"))
                    {
                        process.Kill();
                        if (lang.Equals("Anglais"))
                        {
                            MessagesShow to = new MessagesShow("Auto scan stopped ", "");
                        }
                        else
                        {
                            //MessageBox.Show("Scan automatique arrêté ");
                            MessagesShow to = new MessagesShow("Scan automatique arrêté ", "");
                        }
                    }
                    //MessageBox.Show($"{process.ProcessName}");
                }

            }
        }
        private void Guna2ImageButton11_Click(object sender, EventArgs e)
        {
            pagesView.SelectTab("aide");
        }

        private void Guna2Button2_Click(object sender, EventArgs e)
        {
            variable = "ScanComplet";
            // ici on traite le scan Total            
            scanViewCollection.SelectTab("complet");
            
        }

        private void Guna2Button3_Click(object sender, EventArgs e)
        {
            variable = "CustomScan";
            // changer la couleur du bouton            
            scanViewCollection.SelectTab("personnalise");            
            // ici on traite le scan Personalisé
        }

        private void Guna2Button17_Click(object sender, EventArgs e)
        {
            variable = "InfoSysteme";
            performanceViewCollection.SelectTab("system");
            perfornancesview();
        }

        private void Guna2Button16_Click(object sender, EventArgs e)
        {
            variable = "Disk";
            guna2DataGridView3.Rows.Clear();
            performanceViewCollection.SelectTab("disque");
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            resizing();
            int count = 0;
            foreach (DriveInfo d in allDrives)
            {
                if (d.IsReady == true)
                {
                    double free, total;
                    free = d.TotalFreeSpace / Math.Pow(1024, 3);
                    total = d.TotalSize / Math.Pow(1024, 3);
                    guna2DataGridView3.Rows.Add(d.Name, d.DriveType.ToString(), d.VolumeLabel, d.DriveFormat, Math.Round(free, 2) + " GB", Math.Round(total, 2) + " GB");
                }

                count++;
            }
        }

        private void guna2CustomcheckBox4_Click(object sender, System.EventArgs e)
        {
            // The CheckBox control's Text property is changed each time the
            // control is clicked, indicating a checked or unchecked state.  
            if (guna2CustomCheckBox4.Checked == true)
            {
               // MessageBox.Show("je suis le premier choix");
            }
            else
            {
               // MessageBox.Show("je suis le deuxieme choix");
            }
        }
        private void Guna2Button19_Click(object sender, EventArgs e)
        {
            variable = "infomémoire";
            guna2DataGridView4.Rows.Clear();
            performanceViewCollection.SelectTab("memoire");
            //Part Information Memory
            resizing1();
            ManagementObjectSearcher physicalMemoryObject = new ManagementObjectSearcher("select * from Win32_PhysicalMemory ");
            int cpt = 0;
            foreach (ManagementObject obj in physicalMemoryObject.Get())
            {
                UInt64 capacity = 0;
                capacity += (UInt64)obj["Capacity"];
                guna2DataGridView4.Rows.Add(obj["BankLabel"].ToString(), obj["Speed"].ToString() + " MHz",
                    Math.Round(capacity / Math.Pow(1024, 3), 2) + " GB", obj["Name"].ToString(), obj["Manufacturer"].ToString());
                cpt++;
            }

            // End Part Information Memory 
        }

        private void Guna2Button18_Click(object sender, EventArgs e)
        {
            variable = "Reseau";
            performanceViewCollection.SelectTab("reseau");
            Network_Load();
        }

        private void Guna2Button13_Click(object sender, EventArgs e)
        {
            variable = "Program";
            stabiliteViewCollection.SelectTab("programs");
            ListProgram();
            //MessageBox.Show("ok");
        }

        private void Guna2Button12_Click(object sender, EventArgs e)
        {
            variable = "RestorPoint";
            stabiliteViewCollection.SelectTab("restaure");
            getRestorePoint();
        }

        private void Guna2Button11_Click(object sender, EventArgs e)
        {
            variable = "Crtl";
            stabiliteViewCollection.SelectTab("crashing");
            LogDisplay();
        }

        private void Guna2Button10_Click(object sender, EventArgs e)
        {
            variable = "Elogs";
            stabiliteViewCollection.SelectTab("alerts");
            EventLogAlert_Load();
        }

        private void Guna2Button25_Click(object sender, EventArgs e)
        {
            variable = "Trash";
            maintenanceViewCollection.SelectTab("corbeille");
            //MessageBox.Show("Je suis la corbeille");
            recyclebin();
        }

        private void Guna2Button28_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Je suis le boutton 28 c'est restaurer");

            if (guna2DataGridView9.CurrentRow != null)
            {
                int indice = guna2DataGridView9.CurrentRow.Index;
                //string NomFile = (string)guna2DataGridView9[0, indice].Value;
                string chemin = (string)guna2DataGridView9[2, indice].Value;
                
                try
                {
                    Restore(chemin);
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                    if (lang.Trim().Equals("Anglais"))
                    {
                        //MessageBox.Show("File restore encountered an error : \n" + ex.Message, "Clear recycle bin", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        MessagesShow to = new MessagesShow("File restore encountered an error : \n" + ex.Message, "Yes", "Clear recycle bin");
                    }
                    else
                    {
                        MessagesShow to = new MessagesShow("La restoration du fichier a rencontrer une erreur : \n" + ex.Message, "Oui", "Vider la corbeille");
                        //MessageBox.Show("La restoration du fichier a rencontrer une erreur : \n" + ex.Message, "Vider la corbeille", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }
            else
            {
                if (lang.Trim().Equals("Anglais"))
                {
                    //MessageBox.Show("Please select a line");
                    MessagesShow to = new MessagesShow("Please select a line", "");
                }
                else
                {
                    //MessageBox.Show("Veuillez selectionner une ligne");
                    MessagesShow to = new MessagesShow("Veuillez selectionner une ligne", "");
                }
            }
                
        }

        private void Guna2Button27_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Je suis le boutton 27 c'est vider la corbeille");
            /*DialogResult result;

            if (lang.Equals("Anglais"))
            {
                result = MessageBox.Show("Do you want to empty the Trash?", "Empty Trash", MessageBoxButtons.YesNo);
            }
            else
            {
                result = MessageBox.Show("Voullez-vous vider la Corbeille ?", "Vider la Corbeille", MessageBoxButtons.YesNo);
            }*/
            if (lang.Trim().Equals("Anglais"))
            {
                MessagesShow to = new MessagesShow("Do you want to empty the Trash?", "Yes");
            }
            else
            {
                MessagesShow to = new MessagesShow("Voullez-vous vider la Corbeille ?", "Oui");
            }
            var result = File.ReadAllText(MessageOK).ToString().Trim();
            //string result = "";

            /*foreach(string rtp in result1)
            {
                if (!rtp.Equals(""))
                {
                    result = rtp;
                }
            }*/
            // If accepted, continue with the cleaning
            //MessageBox.Show("Result = " + result);
            if (!result.Trim().Equals(""))
            {
                try
                {
                    //MessageBox.Show("Result1 = " + result);
                    // Execute the method with the required parameters
                    uint IsSuccess = SHEmptyRecycleBin(IntPtr.Zero, null, RecycleFlags.SHRB_NOCONFIRMATION);
                    if (lang.Trim().Equals("Anglais"))
                    {
                        MessagesShow to = new MessagesShow("The Trash has been emptied with Success", "Yes");
                    }
                    else
                    {
                        MessagesShow to = new MessagesShow("La Corbeille a ete vider avec Sucess", "Oui");
                    }
                    recyclebin();
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                    if (lang.Trim().Equals("Anglais"))
                    {
                        //MessagesShow to = new MessagesShow("The Trash is not empty due to an error: \n" + ex.Message, "Empty the trash", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        MessagesShow to = new MessagesShow("The Trash is not empty due to an error: \n" + ex.Message, "Yes", "Empty the trash");
                    }
                    else
                    {
                        //MessagesShow to = new MessagesShow("La Corbeille ne c'est pas vider suite a une erreur : \n" + ex.Message, "Vider la Corbeille", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        MessagesShow to = new MessagesShow("La Corbeille ne c'est pas vider suite a une erreur : \n" + ex.Message, "Oui", "Vider la Corbeille");
                    }
                }
            }
            else
            {
                //MessageBox.Show("Merci pour votre visite");
            }
        }

        private void Guna2Button26_Click(object sender, EventArgs e)
        {
            // DialogResult result;

            /*if (lang.Equals("Anglais"))
            {
                result = MessageBox.Show("Are you sure to delete this file : '" + "' \n in the basket ", "delete file", MessageBoxButtons.YesNo);
            }
            else
            {
                result = MessageBox.Show("Etes vous sur de supprimer ce fichier: '" + /*listView1.SelectedItems[0].SubItems[0].Text + *///"' \n dans la corbeille ", "Supprimer fichier", MessageBoxButtons.YesNo);
                                                                                                                                        //}*/
                                                                                                                                        // If accepted, continue with the cleaning
            if (lang.Trim().Equals("Anglais"))
            {
                MessagesShow to = new MessagesShow("Are you sure to delete this file : '" + "' \n in the basket ", "Yes", "delete file");
            }
            else
            {
                MessagesShow to = new MessagesShow("Etes vous sur de supprimer ce fichier: '" +"' \n dans la corbeille ", "Oui", "Supprimer fichier");
            }
            var result = File.ReadAllText(MessageOK).ToString().Trim();

            if (!result.ToString().Equals(""))
            {
                if (guna2DataGridView9.CurrentRow != null)
                {
                    int indice = guna2DataGridView9.CurrentRow.Index;
                    string chemin = (string)guna2DataGridView9[2, indice].Value;
                    //MessageBox.Show("chemin = " + chemin);

                    try
                    {
                        DeleteRecycle(chemin);
                    }
                    catch (Exception ex)
                    {
                        // Handle exceptions
                        if (lang.Trim().Equals("Anglais"))
                        {
                            MessagesShow to = new MessagesShow("Deleting the selected item encountered an error: \n", "");
                        }
                        else
                        {
                            MessagesShow to = new MessagesShow("La suppression de l'element selectionner a rencontrer une erreur : \n", "" );
                        }
                    }
                }
                
            }
        }

        private bool Restore(string Item)
        {
            Shell Shl = new Shell();
            Folder Recycler = Shl.NameSpace(10);

            for (int i = 0; i < Recycler.Items().Count; i++)
            {
                FolderItem FI = Recycler.Items().Item(i);
                string FileName = Recycler.GetDetailsOf(FI, 0);
                if (Path.GetExtension(FileName) == "") FileName += Path.GetExtension(FI.Path);
                //Necessary for systems with hidden file extensions.
                string FilePath = Recycler.GetDetailsOf(FI, 1);
                if (Item == Path.Combine(FilePath, FileName))
                {
                    DoVerb(FI, "ESTAURE");
                    return true;
                }
            }
            return false;
        }
        private bool DoVerb(FolderItem Item, string Verb)
        {
            foreach (FolderItemVerb FIVerb in Item.Verbs())
            {
                if (FIVerb.Name.ToUpper().Contains(Verb.ToUpper()))
                {
                    FIVerb.DoIt();
                    if (lang.Trim().Equals("Anglais"))
                    {
                        //MessageBox.Show("File Restore.");
                        MessagesShow to = new MessagesShow("File Restore", "");
                    }
                    else
                    {
                        //MessageBox.Show("Fichier Restaurer.");
                        MessagesShow to = new MessagesShow("Fichier Restaurer", "");
                    }
                    recyclebin();
                    return true;
                }
            }
            return false;
        }

        // supprimer un fichier de la corbeille
        private void DeleteRecycle(string Item)
        {
            //FileSystem.DeleteFile(Item, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
            RestoreSup(Item);

            if (File.Exists(Item)) 
            {
                FileSystem.DeleteFile(Item, Microsoft.VisualBasic.FileIO.UIOption.AllDialogs, Microsoft.VisualBasic.FileIO.RecycleOption.DeletePermanently);
            }
            else
            {
                FileSystem.DeleteDirectory(Item, Microsoft.VisualBasic.FileIO.UIOption.AllDialogs, Microsoft.VisualBasic.FileIO.RecycleOption.DeletePermanently, Microsoft.VisualBasic.FileIO.UICancelOption.ThrowException);
            }

            recyclebin();
            //Gives the most control of dialogs.
        }

        // pour supprimer un fichier 
        private string RestoreSup(string Item)
        {
            Shell Shl = new Shell();
            Folder Recycler = Shl.NameSpace(10);

            for (int i = 0; i < Recycler.Items().Count; i++)
            {
                FolderItem FI = Recycler.Items().Item(i);
                string FileName = Recycler.GetDetailsOf(FI, 0);
                if (Path.GetExtension(FileName) == "") FileName += Path.GetExtension(FI.Path);
                //Necessary for systems with hidden file extensions.
                string FilePath = Recycler.GetDetailsOf(FI, 1);
                if (Item == Path.Combine(FilePath, FileName))
                {
                    DoVerbSup(FI, "ESTAURE");
                    return Item;
                }
            }
            return Item;
        }

        private bool DoVerbSup(FolderItem Item, string Verb)
        {
            foreach (FolderItemVerb FIVerb in Item.Verbs())
            {
                if (FIVerb.Name.ToUpper().Contains(Verb.ToUpper()))
                {
                    FIVerb.DoIt();                    
                    recyclebin();
                    return true;
                }
            }
            return false;
        }
        private void Guna2Button24_Click(object sender, EventArgs e)
        {
            variable = "TemporalyFiles";
            maintenanceViewCollection.SelectTab("fichier");
            tempoFiles();
        }

        private void Guna2Button21_Click(object sender, EventArgs e)
        {
            variable = "StartupPrograms";
            maintenanceViewCollection.SelectTab("demarrage");
            startupPrograms();
        }

        private void Guna2Button15_Click(object sender, EventArgs e)
        {
            variable = "WindowsUpdate";
            maintenanceViewCollection.SelectTab("update");
            displayWindowsUpdates();
        }

        private void Guna2Button44_Click(object sender, EventArgs e)
        {
            securityViewCollection.SelectTab("firewall");
        }

        private void Guna2Button43_Click(object sender, EventArgs e)
        {
            variable = "AV"; 
            securityViewCollection.SelectTab("antivirus");
            antivirusDisplay();
        }

        private void Guna2Button37_Click(object sender, EventArgs e)
        {
            variable = "WiFiPassword"; 
            //MessageBox.Show("search for connected wifi networks ");
            securityViewCollection.SelectTab("wifi");
            get_Wifi_passwords();
        }

        private void Guna2Button36_Click(object sender, EventArgs e)
        {
            variable = "SavBrowser"; 
            securityViewCollection.SelectTab("password");
            getPassword();
        }

        private void Guna2Button45_Click(object sender, EventArgs e)
        {
            variable = "ParentalControl"; 
            securityViewCollection.SelectTab("control");
            refreshData1();
        }

        private void Guna2Button46_Click(object sender, EventArgs e)
        {
            variable = "Objectwebsite";
            //MessageBox.Show("tttttttttttttt");
            securityViewCollection.SelectTab("website");
        }

        private void Guna2GradientButton1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Je suis là comme ça.");
            variable = "fullScan";
            //this.pagesView.SelectTab("scan");
            //this.pagesView.SelectTab("complet");
            //scanViewCollection.SelectTab("complet");
        }

        private void Guna2PictureBox1_Click(object sender, EventArgs e)
        {
            // ici on manipule l'image pictureBox1
        }

        private void Guna2PictureBox55_Click(object sender, EventArgs e)
        {
            // ici on manipule l'image Guna2PictureBox55
        }

        private void Guna2Button48_Click(object sender, EventArgs e)
        {
            try
            {
                akeys = guna2TextBox8.Text;
                string myParameters = "action=enable&key=" + akeys + "&mac=" + tableauMac[0];
                //ici nous allons envoyés les données sur le serveur distant et obtenir un fichier json
                CmtionAvecServeurEnURL Activation1 = new CmtionAvecServeurEnURL();

                //2- ici le fichier json va nous donné la clé d'activation et la date d'expiration du produit
                try
                {
                    Activation1.PostHttpClient(urlVal, akeys, tableauMac[0]);

                    Thread.Sleep(5000);

                    if (lang.Trim().Equals("Anglais"))
                    {
                        MessagesShow yo = new MessagesShow("Activation In progress...");
                    }
                    else
                    {
                        MessagesShow yo = new MessagesShow("Activation Encours... ");
                    }
                    //Thread.Sleep(5000);
                }
                catch (Exception ex)
                {
                    //MessagesShow yo = new MessagesShow(ex.Message);
                }
                
                var json = File.ReadAllText(Activation);
                string msg = "";
                string statutkey = "";
                string[] error;
                client client = new client();
                key key = new key();
                payment payment = new payment();

               try 
                {
                    //ActivationKeys json_Dictionary = (new JavaScriptSerializer()).Deserialize<ActivationKeys>(json);
                    //ActivationKeys json_Dictionary = (new JavaScriptSerializer()).Deserialize<ActivationKeys>(json);

                    var serializer = new JavaScriptSerializer();
                    //var json_Dictionar = serializer.Serialize(ActivationKeys);
                    //Dictionary<string, object> json_Dictionary = (new JavaScriptSerializer()).Deserialize<Dictionary<string, object>>(json);
                    ActivationKeys2 json_Dictionary = serializer.Deserialize<ActivationKeys2>(json);
                    // enrégistrement de la version de la base de donnée virale.
                    // File.WriteAllText(VersionBD_Viral, json_Dictionary.latest.version);
                   
                    /*string end_date = json_Dictionary.key.end_date;
                    msg = json_Dictionary.message;
                    statutkey = json_Dictionary.key.keystatus;*/
                    string end_date = json_Dictionary.key.end_date.ToString();
                    msg = json_Dictionary.message;
                    statutkey = json_Dictionary.key.keystatus;

                    // puis nous allons éffacés le fichier .JSON telecharger
                    // File.Delete(BaseViraleJson);

                    string[] tab = { "", "", "" };
                    string interm = "";
                    int i = 0;

                    // ici j'ajoute la clé au régistre.

                    if (msg.Equals("success") && statutkey.Equals("ACTIVE"))
                    {
                        string date_fin = "";
                        var date = end_date.Split(' ');

                        if (date[0].Contains('-'))
                        {
                            // ici il y'a séparation avec tiret
                            var date1 = date[0].Split('-');

                            foreach (string tt in date1)
                            {
                                if (i == 0)
                                {
                                    tab[2 - i] = tt;
                                }
                                if (i == 1)
                                {
                                    tab[2 - i] = tt + "/";
                                }
                                if (i == 2)
                                {
                                    tab[2 - i] = tt + "/";
                                }
                                i++;
                            }

                            /*date1[0] = tab[0];
                            date1[1] = tab[1];
                            date1[2] = tab[2];*/

                            foreach (string tt in tab)
                            {
                                //date_fin += tt;
                                interm += tt;
                            }
                        }
                        else
                        {
                            // ici la date est normale

                            //date_fin = date[0];
                            interm = date[0];
                        }
                        //..

                        date_fin = interm;                        
                        string yos = CalculEval(date_fin, "C");
                        
                        EcrireDansRegistre(yos);

                        // le bloque clé change et devient produit bien activé avec le nombre de jours restant

                        // puis je vide le fichier json
                        File.WriteAllText(Activation, "");
                        CléDrakaActivé();

                        if (lang.Trim().Equals("Anglais"))
                        {
                            MessagesShow yo = new MessagesShow("The application will restart in a moment");
                        }
                        else
                        {
                            MessagesShow yo = new MessagesShow("L'application va redémarrer dans un instant ");
                        }
                        Thread.Sleep(5000);
                        Application.Restart();
                    }
                    else
                    {
                        // ici on note que la clé n'est pas activé. donc on déclenche la version d'essaie terminé.
                        if (lang.Trim().Equals("Anglais"))
                        {
                            MessagesShow yo = new MessagesShow("Sorry your keys is not actived", "");
                        }
                        else
                        {
                            MessagesShow yo = new MessagesShow("Désolé votre clé n'est pas active", "");
                        }
                        guna2TextBox8.Text = "XXXX - XXXX - XXXX - XXXX - XXXX - XXXX - XXXX - XXXX - XXXX";
                    }
                }
                catch(Exception ex)
                {
                    //MessageBox.Show("Errerrrrrrr = " + ex.Message);
                    Console.WriteLine(ex.StackTrace);
                }
               
                

            }
            catch(Exception ex)
            {
                MessagesShow yo = new MessagesShow("Echec de l'activation", "");
            }
            //MessageBox.Show("Toto ");
        }

        // ComparativeDataTime

        public int DuréeProduit()
        {
            int i = 0;

            Activation active = new Activation(); ;
            string str = "";
            var liste = File.ReadAllLines(VersionEssaie);
            DateTime thisDay = DateTime.Today;
            Boolean val;
            int ii = 0;
            string j = "";

            foreach(string st in liste)
            {
                if(ii == 1)
                {
                    j = st;
                }
                ii++;
            }
            str = j;
            try
            {
                DateTime dt1 = DateTime.Parse(str);

                if ((dt1 - thisDay).TotalDays <= 15)
                {
                    if ((dt1 - thisDay).TotalDays < 0)
                    {
                        val = false;
                    }
                    else
                    {
                        i = (int)(dt1 - thisDay).TotalDays;
                    }
                }
                else
                {
                    val = false;
                }
            }
            catch (Exception e)
            {
                val = false;
            }

            return i;
        }

        // renvoyer la date d'expiration du produit
        public int DuréeCompleteProduit()
        {
            int i = 0;

            Activation active = new Activation();
            string str = "";
            var liste = File.ReadAllLines(ActivationKey1);            
            DateTime thisDay = DateTime.Today;
            Boolean val;
            int ii = 0;
            string j = "";

            foreach (string st in liste)
            {
                if (ii == 0)
                {
                    j = st;
                }
                ii++;
            }
            str = j;
            //MessageBox.Show("Turbo = "+str);
            try
            {
                DateTime dt1 = DateTime.Parse(str);
               
                if ((dt1 - thisDay).TotalDays <= 365)
                {
                    if ((dt1 - thisDay).TotalDays < 0)
                    {
                        i = 500;
                    }
                    else
                    {
                        i = (int)(dt1 - thisDay).TotalDays;
                    }
                }
                else
                {
                    val = false;
                }
            }
            catch (Exception e)
            {
                val = false;
            }
            //MessageBox.Show("TurboVal = " + i);
            return i;
        }
        public Boolean EvalTestPeriod(string s)
        {
            Activation active = new Activation();          ;
            string str = s;
            
            DateTime thisDay = DateTime.Today;           
            Boolean val;

            try
            {
                DateTime dt1 = DateTime.Parse(str);
                
                if ((dt1 - thisDay).TotalDays <= 15)
                {
                    if ((dt1 - thisDay).TotalDays < 0)
                    {
                        val = false;
                    }
                    else
                    {
                        val = true;
                    }
                }
                else
                {
                    val = false;
                }
            }catch(Exception e)
            {
                val = false;
            }

            return val;
        }

        public Boolean EvalActivePeriode()
        {
            Activation active = new Activation();
            //string[] tab = active.GetDateActionClient();
            string str = active.GetDateExpiration("");
            
            DateTime thisDay = DateTime.Today;

            Boolean val;
            try
            {
                DateTime dt1 = DateTime.Parse(str);
                
                if ((dt1 - thisDay).TotalDays <= 365 )
                {
                    if( (dt1 -  thisDay).TotalDays < 0)
                    {
                        val = false;
                    }
                    else
                    {
                        val = true;
                    }
                }
                else
                {
                    val = false;
                }
            }
            catch (Exception e)
            {
                val = false;
            }
            //MessageBox.Show("val =  "+val);
            return val;
        }

       
        public string LoadKeys(string val)
        {
            var vval = val.ToCharArray();
            int i = 1;
            int j = 1;
            string c = "";
            string chaine = "";

            foreach (char ch in vval)
            {
                c += ch;
                j++;
                if (i == 4)
                {
                    chaine += c;
                    i = 0;
                    c = "";
                }
                i++;
                if (j == 5)
                {
                    chaine += " - ";
                    j = 0;
                }
            }

            return chaine;
        }

        public void Remplir(int valjj)
        {
            try
            {
                guna2Panel12.Visible = false;
                linkLabel1.Visible = false;
                guna2Button48.Visible = false;
                label96.Visible = false;
                label97.Visible = false;
                label99.Visible = false;
                guna2TextBox88.Visible = false;
                guna2TextBox888.Visible = true;
                guna2TextBox888.Visible = true;

                if (lang.Trim().Equals("Anglais"))
                {
                    guna2TextBox888.PlaceholderText = "you still have  : " + valjj + "  days of use";
                }
                else
                {                    
                    guna2TextBox888.PlaceholderText = "il vous reste : " + valjj + " jours d'utilisation";
                }
             
                guna2TextBox888.PlaceholderForeColor = System.Drawing.Color.Gray;
                //MessageBox.Show("Activation terminé");
                pagesView.SelectTab("activate");
            }catch(Exception ex)
            {
                MessagesShow to = new MessagesShow(ex.Message, "");
            }            
        }

        public void EvaluationDraka(int valj)
        {
            try
            {
                guna2Panel12.Visible = true;
                linkLabel1.Visible = true;
                guna2Button48.Visible = true;
                label96.Visible = true;
                label97.Visible = true;
                label99.Visible = true;
                guna2TextBox88.Visible = true;
                guna2TextBox8.Text = "";
                guna2TextBox888.Visible = false;

                
                //label96.Visible = true;
                if (valj < 15)
                {
                    if (lang.Trim().Equals("Anglais"))
                    {
                        label96.Text = " you still have  : " + valj + " trial days     ";
                    }
                    else
                    {
                        label96.Text = "    il vous reste : " + valj + " jours d'essaie     ";
                    }
                    this.label96.Location = new System.Drawing.Point(320, 75);
                }
                else
                {
                    if (lang.Trim().Equals("Anglais"))
                    {
                        label96.Text = "You have activated your 15-day trial period";
                    }
                    else
                    {
                        label96.Text = "Vous avez activer votre periode de 15 jours d'essaie";
                        this.label96.Location = new System.Drawing.Point(215, 75);
                    }
                }
                
                if(valj < 5)
                {
                    label96.ForeColor = Color.OrangeRed;
                    label96.BackColor = Color.Gray;
                }
                else
                {
                    label96.ForeColor = Color.Gray;
                    label96.BackColor = Color.LightGray;
                }
                pagesView.SelectTab("activate");
            }
            catch (Exception ex)
            {
                MessagesShow to = new MessagesShow(ex.Message,"");
            }
        }

        public void EvaluationDraka()
        {
            try
            {
                /*guna2Panel12.Visible = true;
                linkLabel1.Visible = true;
                guna2Button48.Visible = true;
                label96.Visible = true;
                label97.Visible = true;
                label99.Visible = true;
                guna2TextBox88.Visible = false;
                guna2TextBox8.Visible = true;
                guna2TextBox888.Visible = false; */               
                pagesView.SelectTab("activate");
            }
            catch (Exception ex)
            {
                MessagesShow to = new MessagesShow(ex.Message, "");
            }
        }

        // la page clé activée

        public void CléDrakaActivé()
        {
            try
            {
                guna2Panel12.Visible = false;
                linkLabel1.Visible = false;
                guna2Button48.Visible = false;
                label96.Visible = false;
                label97.Visible = false;
                label99.Visible = false;
                //title3.Visible = true;
                guna2TextBox8.Visible = false;
                guna2TextBox88.Visible = true;
                guna2TextBox88.PlaceholderForeColor = System.Drawing.Color.Green;
                title3.Visible = false;
                /*if (lang.Equals("Anglais"))
                {
                    title3.Text = "Enabled";
                }
                else
                {
                    title3.Text = "Activé";
                }
                title3.ForeColor = Color.Green;*/
                
                pagesView.SelectTab("activate");
            }
            catch (Exception ex)
            {
                //MessagesShow to = new MessagesShow(ex.Message, "");
            }
        }
        public int ConvDateAnnee(string s)
        {
            int a = 0;
            int i = 0;
            try
            {
                if(i == 0)
                {
                    char[] arr;
                    arr = s.ToCharArray(0, 10);
                    string yyyy = "";

                    foreach (char c in arr)
                    {
                        a++;
                        if (a > 6)
                        {
                            yyyy += c;
                        }
                    }

                    a = Int32.Parse(yyyy.ToString());
                }
                else
                {
                    //MessageBox.Show(""+i);
                }
               
            }catch(Exception ex)
            {
                MessagesShow to = new MessagesShow("" + ex.Message, "");
            }
            return a;
        }

        public int ConvDateMois(string s)
        {
            int a = 0;
            try
            {
                char[] arr;
                arr = s.ToCharArray(0, 10);
                string mm = "";

                foreach (char c in arr)
                {
                    if (a > 2)
                    {
                        if (a == 5)
                        {
                            break;
                        }
                        mm += c;
                    }
                    a++;
                }
                //MessageBox.Show("Mois : " + mm);
                a = Int32.Parse(mm.ToString());
            }catch(Exception ex)
            {
                MessagesShow to = new MessagesShow(ex.Message, "");
            }

            return a;
        }

        public int ConvDateJour(string s)
        {
            int a = 0;
            try
            {
                char[] arr;
                arr = s.ToCharArray(0, 10);
                string dd = "";

                foreach (char c in arr)
                {
                    dd += c;
                    a++;
                    if (a == 2)
                    {
                        break;
                    }
                }
                //MessageBox.Show("Jour : " + dd);
                a = Int32.Parse(dd.ToString());
            }catch(Exception ex)
            {
                MessagesShow to = new MessagesShow(ex.Message, "");
            }

            return a;
        }


        private void guna2Button52_Click(object sender, EventArgs e)
        {
            if (guna2TextBox3.Text != null && guna2TextBox4.Text != null && guna2TextBox5.Text != null && guna2TextBox6.Text != null && guna2TextBox7.Text != null)
            {
                if (guna2TextBox3.Text.ToLower() == guna2TextBox4.Text.ToLower())
                {
                    var datas = new Dictionary<string, string>
                    {
                        {"Email", guna2TextBox3.Text.ToLower() },
                        {"Name", guna2TextBox5.Text.ToLower() },
                        {"Phone", guna2TextBox6.Text.ToLower() },
                        {"Message", guna2TextBox7.Text.ToLower() }
                    };

                    var dats = new FormUrlEncodedContent(datas);
                    var url = "https://keygen.drakashield.com/clientdatas";
                    var client = new HttpClient();
                    var response = client.PostAsync(url, dats);
                    string result = response.ToString();
                    Console.WriteLine("http response => " + result);

                    if (lang.Trim().Equals("Anglais"))
                    {
                        MessagesShow to = new MessagesShow("Thanks for your informations \n Admin will respond in 48h", "");
                    }
                    else
                    {
                        MessagesShow to = new MessagesShow("Merci pour vos informations \n L'administrateur répondra dans 48h","");
                    }                    
                }
                else
                {
                    if (lang.Trim().Equals("Anglais"))
                    {
                        MessagesShow to = new MessagesShow("Emails not the same please try again", "");
                    }
                    else
                    {
                        MessagesShow to = new MessagesShow("Les e-mails ne sont pas les mêmes, veuillez réessayer", "");
                    }
                }
            }
            else
            {
                if (lang.Trim().Equals("Anglais"))
                {
                    MessagesShow to = new MessagesShow("Some information was not completed", "");
                }
                else
                {
                    MessagesShow to = new MessagesShow("Certaines informations n'ont pas été complétées", "");
                }
            }

        }
        //popopopopopop
        private string FreeMessage()
        {
            Activation activation = new Activation();
            string key = guna2TextBox8.Text;
            activation.ActivateProduct(key);

            return key;
        }

        private void Guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Guna2ProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        //******************************************************************************************************************************
        // Scan perso worker 
        //******************************************************************************************************************************
        int j;
        int count;
        int i;
        
        private System.Threading.ManualResetEvent _busy = new System.Threading.ManualResetEvent(false);

        private string BytesToHex(byte[] bytes)
        {
            // write each byte as two char hex output.
            return String.Concat(Array.ConvertAll(bytes, x => x.ToString("X2")));
        }

        private void backgroundWorkerPerso_DoWork_1(object sender, DoWorkEventArgs e)
        {
            //List<String> search = Directory.GetFiles(@custom_FolderPicker.SelectedPath, "*.*", System.IO.SearchOption.AllDirectories).ToList();  //, System.IO.SearchOption.AllDirectories
            List<String> search = new List<String>();
            search.AddRange(fichiers(custom_FolderPicker.SelectedPath));
            toto = custom_FolderPicker.SelectedPath;
         
            custom_progressBar.Maximum = search.Count;
            Scancp perso = new Scancp();
            perso.filesCount = search.Count;

            int max = search.Count;
            int Tempmax = max;
            var md5signatures = File.ReadAllLines(VirusBD);

            foreach (string item in search)
            {
                try
                {
                    files += 1;
                    string chemin = item;
                    Console.WriteLine(chemin);

                    if (backgroundWorkerPerso.CancellationPending)
                    {
                        search.Clear();
                        custom_dureeAnalyse.Text = "00h:00mm:00s";
                        
                        e.Cancel = true;
                        pictureBox1.Visible = false;
                        break;

                    }
                    else if (obt == "Continue")
                    {
                        do
                        {
                            Thread.Sleep(500);
                        } while (obt == "Continue");
                    }
                    else
                    {
                        // read all bytes of file so we can send them to the MD5 hash algo
                        Byte[] allBytes = File.ReadAllBytes(item);
                        System.Security.Cryptography.HashAlgorithm md5Algo = null;
                        md5Algo = new System.Security.Cryptography.MD5CryptoServiceProvider();
                        // compute the Hash (MD5) on the bytes we got from the file
                        byte[] hash = md5Algo.ComputeHash(allBytes);
                        Console.WriteLine(BytesToHex(hash));

                        perso.file = files;
                        //var md5signatures = File.ReadAllLines(VirusBD);
                        if (md5signatures.Contains(BytesToHex(hash)))
                        {
                            perso.statut = "Infected";
                            virus += 1;
                            perso.virus = virus;
                            string detection = BytesToHex(hash);
                            MoveItem(chemin, perso.statut, detection);
                        }
                        else
                        {
                            perso.statut = "Clean";
                        }

                        perso.item = item;
                        backgroundWorkerPerso.ReportProgress(0, perso);
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    /*MessageBox.Show("Error : " + ex.ToString());*/
                }
            }
            //
        }

        private void backgroundWorkerPerso_ProgressChanged_1(object sender, ProgressChangedEventArgs e)
        {
            int scanend, intervale, time, days, hours, minutes, seconds;
            Scancp scan = (Scancp)e.UserState;
            custom_ProgressIndicator.Visible = false;
            custom_progressBar.Visible = true;
            complet_viewList.Visible = true;
            custom_progressBar.Maximum = scan.filesCount;
            custom_progressBar.Increment(1);
            custom_progressBar.Update();

            if (lang.Trim().Equals("Anglais"))
            {
                custom_detection.Text = scan.virus.ToString() + " Virus detected";
                custom_totalObject.Text = "Files Scanned : " + scan.file.ToString();
            }
            else
            {
                custom_detection.Text = scan.virus.ToString() + " Virus détectés";
                custom_totalObject.Text = "Fichiers scannés : " + scan.file.ToString();

            }
            complet_viewList.Rows.Add(scan.item);
            label3.Text = scan.item;

            scanend = scan.filesCount;
            intervale = 1;
            time = (scanend * intervale) / 4;
            days = time / 86400;
            hours = time / 3600;
            minutes = time / 60 % 60;
            seconds = time % 60;
            custom_dureeAnalyse.Text = hours + "h :" + minutes + "mm :" + seconds + "s";
        }

        // Ajout des virus détectés dans le fichier virus
        public void Charger(int k)
        {
            //MessageBox.Show("kk : " + k);
            if (k == 0)
            {
                int heing = TailleTable("Quarantaine");
                //MessageBox.Show("rr : " + heing);
                if(heing <= 0)
                {
                    try
                    {
                        //Pass the filepath and filename to the StreamWriter Constructor
                        StreamWriter sw = new StreamWriter(VerifAutoScan);
                        //Write a line of text
                        sw.WriteLine(0);
                        sw.Close();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Exception: " + e.Message);
                    }
                }
            }
            else
            {
                try
                {
                    //Pass the filepath and filename to the StreamWriter Constructor
                    StreamWriter sw = new StreamWriter(VerifAutoScan);
                    //Write a line of text
                    sw.WriteLine(k);
                    sw.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
            }
        }
        private void backgroundWorkerPerso_RunWorkerCompleted_1(object sender, RunWorkerCompletedEventArgs e)
        {
            string vol = "";
            string typeS = "";

            if (e.Cancelled)
            {
                if (lang.Trim().Equals("Anglais"))
                {
                    MessagesShow to = new MessagesShow("Scan stopped", "");
                    vol = "Scan stopped";
                    typeS = "Partial Scan ";
                }
                else
                {
                    MessagesShow to = new MessagesShow("Analyse arrêté","");
                    vol = "Analyse arrêtée";
                    typeS = "Scan Partiel ";
                }
                PartialScan(vol, custom_dureeAnalyse.Text, custom_totalObject.Text, typeS, custom_detection.Text, toto);
                Charger(virus);
                custom_folderPickerText.Text = "Chemin";
                custom_progressBar.Value = 0;
                custom_runScan.Visible = true;
                custom_cancelScan.Visible = false;
                custom_pauseScan.Visible = false;
            }
            else if (e.Error != null)
            {

                if (lang.Trim().Equals("Anglais"))
                {
                    MessagesShow to = new MessagesShow("Scan stopped", "");
                    vol = "Scan stopped";
                    typeS = "Partial Scan ";
                }
                else
                {
                    MessagesShow to = new MessagesShow("Analyse arrêtée", "");
                    vol = "Analyse arrêtée";
                    typeS = "Scan partiel ";
                }
                complet_viewList.ClearSelection();
                label3.Text = "";
                // dureeAnalyse = custom_dureeAnalyse.Text;
                //string totalObject = custom_totalObject.Text;

                Charger(virus);
                PartialScan(vol, custom_dureeAnalyse.Text, custom_totalObject.Text, typeS, custom_detection.Text, toto);
                custom_folderPickerText.Text = "Chemin";
                custom_progressBar.Value = 0;
                custom_runScan.Visible = true;
                custom_cancelScan.Visible = false;
                custom_pauseScan.Visible = false;
            }
            else
            {
                if (lang.Trim().Equals("Anglais"))
                {
                    MessagesShow to = new MessagesShow("Scan Completed", "");
                    vol = "Scan Completed";
                    typeS = "Partial Scan ";
                }
                else
                {
                    MessagesShow to = new MessagesShow("Scan terminé", "");
                    vol = "Scan terminé";
                    typeS = "Scan partiel ";
                }
                custom_FolderPicker.SelectedPath.Trim();
                // ici nous allons prendre les informations de l'historique de scan                
                
                Charger(virus);
                PartialScan(vol, custom_dureeAnalyse.Text, custom_totalObject.Text, typeS, custom_detection.Text, toto);
                custom_folderPickerText.Text = "Chemin";
                custom_progressBar.Value = 0;
                custom_runScan.Visible = true;
                custom_cancelScan.Visible = false;
                custom_pauseScan.Visible = false;
            }
            complet_viewList.Rows.Clear();
            custom_runScan.Enabled = true;
            Program.scanRun = false;
            Program.isSp = false;
        }

        public string TraductionDate(string str)
        {
            String[] MoiF = { "Janvier", "Fevrier", "Mars", "Avril", "Mai", "Juin", "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Décembre" };
            String[] MoiA = { "January", "Fevrier", "Mars", "Avril", "Mai", "Juin", "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Décembre" };
            
            return str;
        }
        private void PartialScan(string Etat, string dureeAnalyse, string totalObj, string typescan, string totalVirus, string toto)
        {
            try
            {
                if (db1.CreateTable(sourceFile, "HistoryScan") == true)
                {
                    //MessageBox.Show("Table historique de scan bien créer");
                }
                else
                {
                    // MessageBox.Show("Table historique de scan Existe deja");
                }
            }
            catch (Exception ex)
            {
                MessagesShow to = new MessagesShow(ex.Message, "");
            }
            string etat = Etat;
            DateTime date = DateTime.Now;
            string date1 = "";
            if (lang.Trim().Equals("Anglais"))
            {
                date1 = date.ToString(formats[15], cultures[1]);
            }
            else
            {
                date1 = date.ToString("dddd, dd MMMM yyyy  hh:mm:ss");
            }
            string duree = dureeAnalyse;
            string totalAnalyser = totalObj;
            string virus = totalVirus;
            //MessageBox.Show("date1 = " + date1);
            string scantype = "";
            /*if (lang.Trim().Equals("Anglais"))
            {
                scantype = "Partial scan";
            }
            else
            {
                scantype = "Scan partiel";
            }*/
            this.ich = this.ich + 1;
            string sql = "insert into HistoryScan  (date,duree,TotalVirus,totalAna,typescan,Etat, chemin ) values(";
            //sql = sql + "'" + ich + "', ";
            sql = sql + "'" + date1 + "', ";
            sql = sql + "'" + duree + "', ";
            sql = sql + "'" + virus + "', ";
            sql = sql + "'" + totalAnalyser + "', ";
            sql = sql + "'" + typescan + "', ";
            sql = sql + "'" + etat + "', ";
            sql = sql + "'" + toto + "')";

            try
            {
                Boolean error = db1.insertData(sourceFile, sql);

                if (error == true)
                {
                    if (lang.Trim().Equals("Anglais"))
                    {
                        Console.WriteLine("Good Scan");
                        //AutoClosingMessageBox.Show("Scan saved successfully");
                        MessagesShow to = new MessagesShow("Scan saved successfully");
                    }
                    else
                    {
                        Console.WriteLine("Good Scan");
                        //AutoClosingMessageBox.Show("Scan Enrégistré avec succes");
                        MessagesShow to = new MessagesShow("Scan enrégistré avec succes");
                    }
                }
                else
                {
                    Console.WriteLine("Bad no completed scan");
                }
            }
            catch (Exception ex)
            {
                if (!File.Exists(path))
                {
                    File.Create(path);
                    TextWriter tw = new StreamWriter(path, true);
                    tw.WriteLine(DateTime.Now.ToString() + " " + "Request:" + " " + sql + " " + "Error_Message:" + ex);
                    tw.Close();
                }

                else if (File.Exists(path))
                {
                    TextWriter tw = new StreamWriter(path, true);
                    tw.WriteLine(DateTime.Now.ToString() + " " + "Request:" + " " + sql + " " + "Error_Message:" + ex);
                    tw.Close();
                }
            }
        }

        private void MoveItem(string directory, string etat, string hash)
        {
            string root = @"C:\Program Files(x86)\Default Company Name\Setup1\Quarantaine\";
            string subdir = @"Draka Antivirus\Draka Antivirus\Draka Antivirus\bin\Debug\Quarantaine\";

            try
            {
                Boolean create = db1.CreateTable(sourceFile, "Quarantaine");
                if (create == true)
                {
                    // MessageBox.Show("Table quantaine créer ");
                }
                else
                {
                    // AutoClosingMessageBox.Show("la table quarantaine Existe deja ");
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Exception : " + ex);
            }

            try
            {
                string file = Path.GetFileName(directory);
                root = root + file;

                if (FileSystem.FileExists(directory))
                {
                    if (Directory.Exists(subdir))
                    {
                        Directory.CreateDirectory(subdir);
                        string chemin = directory;
                        string fileName = file;
                        string NewDirectory = root;
                        DateTime date = DateTime.Now;
                        string date1 = "";
                        if (lang.Trim().Equals("Anglais"))
                        {
                            date1 = date.ToString(formats[15], cultures[1]);
                        }
                        else
                        {
                            date1 = date.ToString("dddd, dd MMMM yyyy  hh:mm:ss");
                        }
                        string taille = "";
                        string Etat = etat;
                        string editeur = "DrakaShield";
                        string action = "Mettre en quarantaine";
                        string detection = file + " -> " + hash;
                        index++;

                        string sql = "insert into Quarantaine (chemin,nomfichier,nouveldirection,date,taille,etat,editeur,action,detection) values(";
                        //sql = sql + "'" + index + "', ";
                        sql = sql + "'" + chemin + "', ";
                        sql = sql + "'" + fileName + "', ";
                        sql = sql + "'" + NewDirectory + "', ";
                        sql = sql + "'" + date1 + "', ";
                        sql = sql + "'" + taille + "', ";
                        sql = sql + "'" + Etat + "', ";
                        sql = sql + "'" + editeur + "', ";
                        sql = sql + "'" + action + "', ";
                        sql = sql + "'" + detection + "')";

                        try
                        {
                            if (QAutoManuel.Equals("Auto"))
                            {

                                if (lang.Trim().Equals("Anglais"))
                                {
                                    //AutoClosingMessageBox.Show("Viruses detected", " Draka Quarantine ", 3000);
                                    MessagesShow yo = new MessagesShow("Viruses detected");
                                }
                                else
                                {
                                    //AutoClosingMessageBox.Show("Virus detectees", " Draka Quarantaine ", 3000);
                                    MessagesShow yo = new MessagesShow("Virus détectés");
                                }
                                File.Delete(directory);
                            }
                            else
                            {
                                Boolean error = db1.insertData(sourceFile, sql);
                                if (error == true)
                                {
                                    if (lang.Trim().Equals("Anglais"))
                                    {
                                        MessagesShow yo = new MessagesShow("Viruses detected and saved in quarantine");
                                        //AutoClosingMessageBox.Show("Viruses detected and saved in quarantine", " Draka Quarantine ", 3000);
                                    }
                                    else
                                    {
                                        MessagesShow yo = new MessagesShow("Virus détectés et enregistrés en quarantaine");
                                        //AutoClosingMessageBox.Show("Virus détectés et enregistrés en quarantaine", " Draka Quarantaine ", 3000);
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Virus détectés", " Draka Quarantaine ", 3000);
                                }

                                FileSystem.MoveFile(directory, root, true);

                            } //QAutoManuel
                        }
                        catch (Exception ex)
                        {
                            //AutoClosingMessageBox.Show(ex.Message);
                            MessagesShow yo = new MessagesShow(ex.Message);
                        }
                    }
                    else
                    {
                        if (QAutoManuel.Equals("Auto"))
                        {
                            if (lang.Trim().Equals("Anglais"))
                            {
                                MessagesShow yo = new MessagesShow("Viruses detected");
                                //AutoClosingMessageBox.Show("Viruses detected", " Draka Quarantine ", 3000);
                            }
                            else
                            {
                                MessagesShow yo = new MessagesShow("Virus détectés");
                                //AutoClosingMessageBox.Show("Virus detectees", " Draka Quarantaine ", 3000);
                            }
                            File.Delete(directory);
                        }
                        else
                        {
                            Directory.CreateDirectory(subdir);
                            string chemin = directory;
                            string fileName = file;
                            string NewDirectory = root;
                            DateTime date = DateTime.Now;
                            string date1 = "";
                            if (lang.Trim().Equals("Anglais"))
                            {
                                date1 = date.ToString(formats[15], cultures[1]);
                            }
                            else
                            {
                                date1 = date.ToString("dddd, dd MMMM yyyy  hh:mm:ss");
                            }
                            string taille = "";
                            string Etat = etat;
                            string editeur = "DrakaShield";
                            string action = "Mettre en quarantaine";
                            string detection = file + " -> " + hash;
                            index++;

                            string sql = "insert into Quarantaine (chemin,nomfichier,nouveldirection,date,taille,etat,editeur,action,detection) values(";
                            //sql = sql + "'" + index + "', ";
                            sql = sql + "'" + chemin + "', ";
                            sql = sql + "'" + fileName + "', ";
                            sql = sql + "'" + NewDirectory + "', ";
                            sql = sql + "'" + date1 + "', ";
                            sql = sql + "'" + taille + "', ";
                            sql = sql + "'" + Etat + "', ";
                            sql = sql + "'" + editeur + "', ";
                            sql = sql + "'" + action + "', ";
                            sql = sql + "'" + detection + "')";

                            FileSystem.MoveFile(directory, root, true);
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Le fichier n'existe pas dans le repertoire : " + directory);
                    if (lang.Trim().Equals("Anglais"))
                    {
                        MessagesShow yo = new MessagesShow("The file does not exist in the directory: " + directory);
                        //AutoClosingMessageBox.Show("The file does not exist in the directory: " + directory, " Draka Quarantaine ", 3000);
                    }
                    else
                    {
                        MessagesShow yo = new MessagesShow("Le fichier n'existe pas dans le répertoire: " + directory);
                        //AutoClosingMessageBox.Show("Le fichier n'existe pas dans le répertoire: " + directory, " Draka Quarantine ", 3000);
                    }
                }
            }
            catch (Exception ex)
            {
                if (!File.Exists(path))
                {
                    File.Create(path);
                    TextWriter tw = new StreamWriter(path, true);
                    tw.WriteLine(DateTime.Now.ToString() + " " + "Error_Message:" + ex);
                    tw.Close();
                }

                else if (File.Exists(path))
                {
                    TextWriter tw = new StreamWriter(path, true);
                    tw.WriteLine(DateTime.Now.ToString() + " " + "Error_Message:" + ex);
                    tw.Close();
                }
            }
        }

        public void startbtnclick(string directory)
        {
            custom_folderPickerText.Text = @"" + directory;
            custom_FolderPicker.SelectedPath = @"" + directory;

            if (!backgroundWorkerPerso.IsBusy)
            {
                custom_pauseScan.Enabled = true;
                custom_cancelScan.Visible = true;
                custom_runScan.Visible = false;
                custom_progressBar.Value = 0;
                custom_progressBar.Update();
                custom_dureeAnalyse.Text = "00h:00mm:00s";
                //label11.Text = "00h:00mm:00000000000s";
                custom_totalObject.Text = "0";
                custom_detection.Text = "0";

                backgroundWorkerPerso.RunWorkerAsync();

                if (label8.Text == "Initiailisation...")
                {
                    custom_progressBar.Visible = false;
                    complet_viewList.Visible = false;
                    custom_progressBar.Visible = true;
                }

                Program.scanRun = true;
                Program.isSp = true;
            }
        }

        private void Custom_folderPickerBtn_Click(object sender, EventArgs e)
        {
            custom_FolderPicker.ShowDialog();
            custom_folderPickerText.Text = custom_FolderPicker.SelectedPath;
            virus = 0;
            files = 0;
            //*****************************************
            custom_progressBar.Value = 0;
            complet_viewList.ClearSelection();
            label3.Text = "";
            custom_dureeAnalyse.Text = "00h:00mm:00s";
            complet_viewList.Visible = false;
            custom_progressBar.Visible = true;
            custom_cancelScan.Visible = false;
            custom_runScan.Visible = true;
            custom_pauseScan.Visible = false;
        }
        private void Custom_runScan_Click(object sender, EventArgs e)
        {
            if (custom_folderPickerText.Text.Equals("Chemin") || custom_folderPickerText.Text.Equals("Path") )
            {
                if (lang.Trim().Equals("Anglais"))
                {
                    MessagesShow to = new MessagesShow("Please select a good directory", "");
                }
                else
                {
                    MessagesShow to = new MessagesShow("Veuillez sélectionner un bon répertoire", "");
                }

            }
            else
            {
                if (!backgroundWorkerPerso.IsBusy)
                {
                    custom_ProgressIndicator.Visible = true;
                    custom_progressBar.Value = 0;
                    custom_progressBar.Update();
                    pictureBox1.Visible = true;

                    custom_cancelScan.Visible = true;
                    custom_pauseScan.Visible = true;
                    custom_runScan.Visible = false;
                    backgroundWorkerPerso.RunWorkerAsync();

                    /*if (lang.Equals("Anglais"))
                    {
                        AutoClosingMessageBox.Show("Loading files in progress");
                    }
                    else
                    {
                        AutoClosingMessageBox.Show("Chargement des fichiers en cours");
                    }*/
                }

            }

            

        }
        private void custom_cancelScan_Click(object sender, EventArgs e)
        {

            if (backgroundWorkerPerso.IsBusy)
            {
                if (lang.Equals("Anglais"))
                {
                    if (MessageBox.Show("Do yo want to stop scan .... ", " Custon Scan ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        custom_pauseScan.Visible = true; custom_cancelScan.Visible = true; custom_runScan.Visible = true;
                        pictureBox1.Visible = false;
                        backgroundWorkerPerso.CancelAsync();
                        complet_viewList.Rows.Clear();
                    }
                }
                else
                {
                    if (MessageBox.Show("Voulez-vous arrêter l'analyse .... ", " Analyse personnalisée ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        custom_pauseScan.Visible = true; custom_cancelScan.Visible = true; custom_runScan.Visible = true;
                        pictureBox1.Visible = false;
                        backgroundWorkerPerso.CancelAsync();
                        complet_viewList.Rows.Clear();
                    }
                }
            }
        }

        private void custom_pauseScan_Click(object sender, EventArgs e)
        {
            if (backgroundWorkerPerso.IsBusy)
            {
                if (obt == "Continue")
                {
                    obt = "Pause";
                    custom_pauseScan.Text = obt;
                    custom_pauseScan.Visible = true;
                    custom_cancelScan.Visible = true;
                    custom_runScan.Visible = false;
                }
                else
                {
                    obt = "Continue";
                    custom_pauseScan.Text = obt;
                    custom_pauseScan.Visible = true;
                    custom_cancelScan.Visible = false;
                    custom_runScan.Visible = false;
                }
            }

        }
        //******************************************************************************************************************************
        // End scan Perso
        //******************************************************************************************************************************


        //******************************************************************************************************************************
        // Full Scan Start
        //******************************************************************************************************************************    
        public List<String> fichiers(string dir)
        {
            List<String> f = new List<String>();
            List<string> dirs = Directory.GetDirectories(dir.ToString()).ToList();

            if (dirs.Count > 0)
            {
                foreach (string item in dirs)
                {
                    try
                    {
                        f.AddRange(fichiers(item));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }

                }
            }

            try
            {
                f.AddRange(Directory.GetFiles(dir.ToString(), "*.*", System.IO.SearchOption.TopDirectoryOnly).ToList());
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                Console.WriteLine(ex.ToString());
            }

            return f;
        }

        private void backgroundWorkerComplet_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                List<String> search = new List<String>();
                DriveInfo[] allDrives = DriveInfo.GetDrives();

                foreach (DriveInfo d in allDrives)
                {
                    if (d.IsReady == true)
                    {
                        /*search.AddRange(fichiers(d.RootDirectory.ToString() + "\\"));*/
                        search.AddRange(fichiers(@"C:\Users\"));
                    }
                }

                Scancp complet = new Scancp();
                /*complet.isInit = true;*/
                complet.filesCount = search.Count;
                var md5signatures = File.ReadAllLines("MD5Base.txt");
                /*backgroundScanPersonaliser.ReportProgress(0, complet);*/
                /*complet.isInit = false;*/

                foreach (String item in search)
                {
                    try
                    {
                        files += 1;
                        string chemin = item;
                        if (backgroundWorkerComplet.CancellationPending)
                        {
                            e.Cancel = true;
                            search.Clear();
                            //custom_dureeAnalyse.Text = "00h:00mm:00s";
                            pictureBox1.Visible = false;
                            break;
                        }
                        else if (bbt == "Continue")
                        {
                            do
                            {
                                Thread.Sleep(500);
                            } while (bbt == "Continue");
                        }
                        else
                        {
                            // read all bytes of file so we can send them to the MD5 hash algo
                            Byte[] allBytes = File.ReadAllBytes(item);
                            System.Security.Cryptography.HashAlgorithm md5Algo = null;
                            md5Algo = new System.Security.Cryptography.MD5CryptoServiceProvider();
                            // compute the Hash (MD5) on the bytes we got from the file
                            byte[] hash = md5Algo.ComputeHash(allBytes);
                            /*Console.WriteLine(BytesToHex(hash));*/

                            complet.file = files;
                           // var md5signatures = File.ReadAllLines("MD5Base.txt");
                            if (md5signatures.Contains(BytesToHex(hash)))
                            {
                                //Console.WriteLine("Infected");
                                complet.statut = "Infected";
                                virus += 1;
                                complet.virus = virus;
                                string detection = BytesToHex(hash);
                                MoveItem(chemin, complet.statut, detection);
                            }
                            else
                            {
                                complet.statut = "Clean";
                            }

                            complet.item = item;
                            backgroundWorkerComplet.ReportProgress(0, complet);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                /*MessageBox.Show("Error : " + ex.ToString());*/
            }
        }

        private void backgroundWorkerComplet_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int scanend, intervale, time, days, hours, minutes, seconds;
            Scancp scan = (Scancp)e.UserState;

            complet_ProgressIndicator.Visible = false;
            complet_progressbar.Visible = true;
            complet_listView.Visible = true;
            complet_progressbar.Maximum = scan.filesCount;
            complet_progressbar.Increment(1);
            complet_progressbar.Update();
            if (lang.Trim().Equals("Anglais"))
            {
                label5.Text = scan.virus.ToString() + " Virus detected";
                label6.Text = "Files Scanned : " + scan.file.ToString() + " ";
            }
            else
            {
                label6.Text = "Fichiers scannés : " + scan.file.ToString() + " ";
                label5.Text = scan.virus.ToString() + " Virus détectés";
            }
            
            CompletFileRoute.Text = scan.item;
            complet_listView.Rows.Add(scan.item);
            complet_repertoireText.Text = @"C:\Users\";

            scanend = scan.file;
            intervale = 1;
            time = (scanend * intervale) / 4;
            days = time / 86400;
            hours = time / 3600;
            minutes = time / 60 % 60;
            seconds = time % 60;
            label8.Text = hours + "h:" + minutes + "mm:" + seconds + "s";
        }

        private void backgroundWorkerComplet_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            string vol = "";
            string typeS = "";

            if (e.Cancelled)
            {
                if (lang.Trim().Equals("Anglais"))
                {
                    MessagesShow to = new MessagesShow("Scan stopped","");
                    vol = "Scan stopped";
                    typeS = "Global Scan";
                }
                else
                {
                    MessagesShow to = new MessagesShow("Scan annulé","");
                    vol = "Scan annulé";
                    typeS = "Scan Global";
                }
                //MessageBox.Show("Toooooo = " + typeS);
                Charger(virus);
                PartialScan(vol, label8.Text, label6.Text, typeS, label5.Text, toto);
                //PartialScan(typeS, label8.Text, label6.Text, vol, label5.Text, toto);

                complet_progressbar.Value = 0;
                complet_runScanBtn.Visible = true;
                complet_cancelScanBtn.Visible = false;
                complet_pauseScanBtn.Visible = false;
            }
            else if (e.Error != null)
            {
                if (lang.Trim().Equals("Anglais"))
                {
                    MessagesShow to = new MessagesShow("Scan stopped ","");
                    vol = "Scan stopped";
                    typeS = "Global Scan";
                }
                else
                {
                    MessagesShow to = new MessagesShow("Scanne Annulé", "");
                    vol = "Scanne Annulé";
                    typeS = "Scan Global";
                }
               
                Charger(virus);
                PartialScan(vol, label8.Text, label6.Text, typeS, label5.Text, toto);

                complet_progressbar.Value = 0;
                complet_runScanBtn.Visible = true;
                complet_cancelScanBtn.Visible = false;
                complet_pauseScanBtn.Visible = false;
            }
            else
            {
                if (lang.Trim().Equals("Anglais"))
                {
                    MessagesShow to = new MessagesShow("Scan Completed", "");
                    vol = "Scan Completed";
                    typeS = "Global Scan";
                }
                else
                {
                    MessagesShow to = new MessagesShow("Anayse terminer ", "");
                    vol = "Anayse terminer";
                    typeS = "Scan Global";
                }
                Charger(virus);
                PartialScan(vol, label8.Text, label6.Text, typeS, label5.Text, toto);

                complet_progressbar.Value = 0;
                complet_runScanBtn.Visible = true;
                complet_cancelScanBtn.Visible = false;
                complet_pauseScanBtn.Visible = false;
            }
            complet_listView.Rows.Clear();
            //complet_viewList.ClearSelection();
            Program.scanRun = false;
            Program.isSp = false;
        }
        private void Guna2Button5_Click(object sender, EventArgs e)
        {
            //  complet_pauseScanBtn
            if (backgroundWorkerComplet.IsBusy)
            {
                if (bbt == "Continue")
                {
                    bbt = "Pause";
                    complet_pauseScanBtn.Text = bbt;
                    complet_pauseScanBtn.Visible = true;
                    complet_cancelScanBtn.Visible = true;
                    complet_runScanBtn.Visible = false;

                }
                else
                {
                    bbt = "Continue";
                    complet_pauseScanBtn.Text = bbt;
                    complet_pauseScanBtn.Visible = true;
                    complet_cancelScanBtn.Visible = false;
                    complet_runScanBtn.Visible = false;
                }
            }
        }

        private void Guna2Button4_Click(object sender, EventArgs e)
        {
            // run button
            complet_repertoireText.Text = @"C:\Users\";
            //CompletfolderBrowserDialog.SelectedPath = @"C:\Users\";

            if (!backgroundWorkerComplet.IsBusy)
            {
                complet_pauseScanBtn.Visible = true;
                complet_cancelScanBtn.Visible = true;
                complet_runScanBtn.Visible = false;
                complet_progressbar.Value = 0;
                complet_progressbar.Update();
                complet_ProgressIndicator.Visible = true;
                pictureBox1.Visible = true;
                label8.Text = "00h:00mm:00s";
                label6.Text = "0";
                label5.Text = "0";
                backgroundWorkerComplet.RunWorkerAsync();

                if (CompletFileRoute.Text == "Initiailisation...")
                {
                    complet_progressbar.Visible = false;
                    complet_listView.Visible = false;
                    complet_progressbar.Visible = true;
                }

                Program.scanRun = true;
                Program.isSp = true;
                if (lang.Trim().Equals("Anglais"))
                {
                    MessagesShow yos = new MessagesShow("Loading files in progress...");
                    //AutoClosingMessageBox.Show("Loading files in progress");
                }
                else
                {
                    MessagesShow yos = new MessagesShow("Chargement des fichiers en cours...");
                    //AutoClosingMessageBox.Show("Chargement des fichiers en cours");
                }
            }
        }
        private void Guna2Button6_Click(object sender, EventArgs e)   // complet_cancelScanBtn
        {
            if (backgroundWorkerComplet.IsBusy)
            {
                if (lang.Equals("Anglais"))
                {
                    if (MessageBox.Show("Do yo want to stop scan .... ", " Custon Scan ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        complet_pauseScanBtn.Visible = true;
                        complet_cancelScanBtn.Visible = true;
                        complet_runScanBtn.Visible = true;
                        backgroundWorkerComplet.CancelAsync();
                        complet_listView.Rows.Clear();
                        pictureBox1.Visible = false;
                    }
                }
                else
                {
                    if (MessageBox.Show("Voulez-vous arrêter l'analyse .... ", " Analyse personnalisée ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        complet_pauseScanBtn.Visible = true;
                        complet_cancelScanBtn.Visible = true;
                        complet_runScanBtn.Visible = true;
                        backgroundWorkerComplet.CancelAsync();
                        complet_listView.Rows.Clear();
                        pictureBox1.Visible = false;
                    }
                }
            }
        }

        //******************************************************************************************************************************
        // End Full Scan Start
        //******************************************************************************************************************************


        //******************************************************************************************************************************
        // Performances
        //******************************************************************************************************************************
        private void perfornancesview()
        {
            // Part Infos System 
            RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows NT\\CurrentVersion");
            string pathName = (string)registryKey.GetValue("productName");
            labelOperatingSystem.Text = pathName;


            label38.Text = Environment.MachineName;

            label37.Text = Environment.UserName;


            ManagementObjectSearcher myProcessorObject = new ManagementObjectSearcher("select * from Win32_Processor");

            foreach (ManagementObject obj in myProcessorObject.Get())
            {
                label34.Text = obj["Name"].ToString();
                label25.Text = obj["NumberOfCores"].ToString();
                label23.Text = obj["MaxClockSpeed"].ToString() + "MHz";

            }

            ManagementObjectSearcher myVideoObject = new ManagementObjectSearcher("select * from Win32_VideoController");

            foreach (ManagementObject obj in myVideoObject.Get())
            {
                label22.Text = obj["Name"].ToString();

            }

            ManagementObjectSearcher mos =
            new ManagementObjectSearcher(@"root\CIMV2", @"SELECT * FROM Win32_ComputerSystem");
            foreach (ManagementObject mo in mos.Get())
            {
                label36.Text = mo["Workgroup"].ToString();
            }


            ManagementObjectSearcher operatinSystem = new ManagementObjectSearcher("select * from Win32_OperatingSystem ");
            double res;
            foreach (ManagementObject obj in operatinSystem.Get())
            {
                label24.Text = obj["OSArchitecture"].ToString();

                res = Convert.ToDouble(obj["TotalVisibleMemorySize"]);
                double fres = Math.Round((res / (1024 * 1024)), 2);
                label35.Text = fres.ToString() + "Gb";
            }


            var cpuUsage = new PerformanceCounter("Processor", "% Processor Time", "_Total");

            for (int i = 0; i < 5; i++)
            {
                label21.Text = cpuUsage.NextValue() + "%";
            }

            var search = new ManagementObjectSearcher("SELECT * FROM Win32_baseboard");
            var mobos = search.Get();

            foreach (var m in mobos)
            {
                var serial = m["SerialNumber"]; // ProcessorID if you use Win32_CPU
                label18.Text = serial.ToString();
            }
            // End Part infos System
        }  // Performances view and button
        public void resizing()
        {
            float totalColumnWidth = 0;

            // Get the sum of all column tags
            for (int i = 0; i < guna2DataGridView3.Columns.Count; i++)
                totalColumnWidth += Convert.ToInt32(guna2DataGridView3.Columns[i].Tag);

            // Calculate the percentage of space each column should 
            // occupy in reference to the other columns and then set the 
            // width of the column to that percentage of the visible space.
            for (int i = 0; i < guna2DataGridView3.Columns.Count; i++)
            {
                float colPercentage = (Convert.ToInt32(guna2DataGridView3.Columns[i].Tag) / totalColumnWidth);
                guna2DataGridView3.Columns[i].Width = (int)(colPercentage * guna2DataGridView3.ClientRectangle.Width);
            }
        }  // Performances elements
        public void resizing1()
        {
            float totalColumnWidth = 0;

            // Get the sum of all column tags
            for (int i = 0; i < guna2DataGridView4.Columns.Count; i++)
                totalColumnWidth += Convert.ToInt32(guna2DataGridView4.Columns[i].Tag);

            // Calculate the percentage of space each column should 
            // occupy in reference to the other columns and then set the 
            // width of the column to that percentage of the visible space.
            for (int i = 0; i < guna2DataGridView4.Columns.Count; i++)
            {
                float colPercentage = (Convert.ToInt32(guna2DataGridView4.Columns[i].Tag) / totalColumnWidth);
                guna2DataGridView4.Columns[i].Width = (int)(colPercentage * guna2DataGridView4.ClientRectangle.Width);
            }
        } // disk elements

        // Network Methode
        private void Network_Load()
        {
            CultureInfo provider = CultureInfo.InvariantCulture;
            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
            Console.WriteLine(adapters.Length);

            foreach (NetworkInterface adapter in adapters)
            {
                if (adapter.GetIPStatistics().BytesSent > 0)
                {
                    System.Net.IPAddress ipv4 = adapter.GetIPProperties().UnicastAddresses[1].Address;
                    IPInterfaceProperties adapterProperties = adapter.GetIPProperties();
                    DateTime today = DateTime.Now;
                    label74.Text = adapter.Name;
                    label58.Text = adapter.Description;
                    label57.Text = adapter.Id;
                    label56.Text = adapter.GetIPProperties().GetIPv4Properties().IsDhcpEnabled.ToString();
                    label55.Text = adapter.GetIPProperties().UnicastAddresses[1].Address.ToString();
                    label54.Text = adapter.GetIPProperties().UnicastAddresses[1].IPv4Mask.ToString();
                    label53.Text = today.ToString("yyyy:MM:dd hh:mm:ss");
                    label52.Text = today.ToString("yyyy:MM:dd hh:mm:ss");
                    label51.Text = getwayaddress();
                    label50.Text = DHCPAddress();
                    label28.Text = GetDnsAdress();
                    label29.Text = "";
                    label30.Text = ipv4.IsIPv6LinkLocal.ToString();
                    label31.Text = getipv6address();
                    label32.Text = "";
                    label33.Text = "";
                }
                else
                {
                    continue;
                }

            }

            foreach (NetworkInterface ni in adapters)
            {
                if (ni.GetIPStatistics().BytesSent > 0)
                {
                    label26.Text = "Bytes Send: " + (ni.GetIPv4Statistics().BytesSent / 1024) + " Mbps" + "      Bytes Receive: " + (ni.GetIPv4Statistics().BytesReceived / 1024) + " Mbps";
                }

            }
        }
        public string DHCPAddress()
        {
            string address1 = "";
            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in adapters)
            {

                IPInterfaceProperties adapterProperties = adapter.GetIPProperties();
                IPAddressCollection addresses = adapterProperties.DhcpServerAddresses;
                if (addresses.Count > 0)
                {
                    Console.WriteLine(adapter.Description);
                    foreach (IPAddress address in addresses)
                    {
                        address1 = address.ToString();
                    }
                }
            }

            return address1;
        }
        public string getwayaddress()
        {
            string address2 = "";
            foreach (NetworkInterface f in NetworkInterface.GetAllNetworkInterfaces())
                if (f.OperationalStatus == OperationalStatus.Up)
                    foreach (GatewayIPAddressInformation d in f.GetIPProperties().GatewayAddresses)

                        if (d.Address.ToString().Trim().Length > 2)//ignore ::
                            address2 = d.Address.ToString();
            return address2;
        }
        private string GetDnsAdress()
        {

            NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();

            foreach (NetworkInterface networkInterface in networkInterfaces)
            {
                if (networkInterface.OperationalStatus == OperationalStatus.Up)
                {
                    IPInterfaceProperties ipProperties = networkInterface.GetIPProperties();
                    IPAddressCollection dnsAddresses = ipProperties.DnsAddresses;

                    foreach (IPAddress dnsAdress in dnsAddresses)
                    {
                        return dnsAdress.ToString();
                    }
                }
            }

            throw new InvalidOperationException("Unable to find DNS Address");
        }
        public string getipv6address()
        {
            string address3 = "";
            string strHostName = System.Net.Dns.GetHostName(); ;
            IPHostEntry ipEntry = System.Net.Dns.GetHostEntry(strHostName);
            IPAddress[] addr = ipEntry.AddressList;
            Console.WriteLine(addr[addr.Length - 1].ToString());
            if (addr[0].AddressFamily == System.Net.Sockets.AddressFamily.InterNetworkV6)
            {
                address3 = addr[0].ToString(); //ipv6
            }

            return address3;
        }
        public string NetWorkSpeed()
        {
            string speed = "";
            PerformanceCounterCategory pcg = new PerformanceCounterCategory("Network Interface");
            string instance = pcg.GetInstanceNames()[0];
            PerformanceCounter pcsent = new PerformanceCounter("Network Interface", "Bytes Sent/sec", instance);
            PerformanceCounter pcreceived = new PerformanceCounter("Network Interface", "Bytes Received/sec", instance);

            speed = "Bytes Sent: " + pcsent.NextValue() / 1024 + "   Bytes Received: " + pcreceived.NextValue() / 1024;

            return speed;
        }

        //******************************************************************************************************************************
        // End Performances
        //******************************************************************************************************************************


        //******************************************************************************************************************************
        // Start stability
        //******************************************************************************************************************************
        public const string SYSTEM_RESTORE = "SystemRestore";
        public const string CREATE_SYSTEM_RESTORE_POINT = "CreateRestorePoint";
        public const string SYSTEM_RESTORE_POINT_DESCRIPTION = "Description";
        public const string SYSTEM_RESTORE_POINT_TYPE = "RestorePointType";
        public const string SYSTEM_RESTORE_EVENTTYPE = "EventType";

        // List of programs
        private void ListProgram()
        {
            //singleTable.Rows = View.Details;
            singleTable.Visible = true;
            //singleTable.Rows.Clear();
            //MessageBox.Show("Je suis appelé");

            try
            {
                string displayName;
                string editName;
                string version;
                RegistryKey key;
                int i = 0;
                // search in: CurrentUser
                key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall");
                /*new DataGridViewColumn(new String[] { "Name", "Publisher", "Version" })*/
                foreach (String keyName in key.GetSubKeyNames())
                {
                    RegistryKey subkey = key.OpenSubKey(keyName);
                    displayName = subkey.GetValue("DisplayName") as string;
                    editName = subkey.GetValue("Publisher") as string;
                    version = subkey.GetValue("DisplayVersion") as string;
                    try
                    {
                        if (displayName == null)
                        {
                            singleTable.Rows.RemoveAt(i);
                        }
                        else
                        {
                            singleTable.Rows.Add(new string[] { displayName, editName, version });
                        }
                    }
                    catch (Exception ex)
                    {
                        //MessagesShow yos = new MessagesShow(ex.Message);
                        //AutoClosingMessageBox.Show(ex.Message);
                    }
                    //Console.WriteLine(displayName);
                    i = i + 1;
                    /*new ListViewItem(new string[] { displayName, editName, version })*/
                }

                // search in: LocalMachine_32
                key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall");
                foreach (String keyName in key.GetSubKeyNames())
                {
                    RegistryKey subkey = key.OpenSubKey(keyName);
                    displayName = subkey.GetValue("DisplayName") as string;
                    editName = subkey.GetValue("Publisher") as string;
                    version = subkey.GetValue("DisplayVersion") as string;
                    //Console.WriteLine(displayName);
                    try
                    {
                        if (displayName == null)
                        {
                            //singleTable.Rows.RemoveAt(i);
                            //MessageBox.Show("okkk = " + i);
                        }
                        else
                        {
                            singleTable.Rows.Add(new string[] { displayName, editName, version });
                        }
                    }
                    catch (Exception ex)
                    {
                        //AutoClosingMessageBox.Show(ex.Message);
                        //MessagesShow yos = new MessagesShow(ex.Message);
                    }
                    //Console.WriteLine(displayName);
                    i = i + 1;
                    /*new ListViewItem(new string[] { displayName, editName, version })*/
                }
            }catch(Exception ex)
            {
                //MessageBox.Show();
            }
        }

        // Restoration point
        public void getRestorePoint()
        {
            try
            {
                guna2DataGridView5.Visible = false;
                guna2WinProgressIndicator1.Visible = true;
                label79.Visible = true;
                label78.Visible = false;
                bool iscreated1 = false;
                if (iscreated1 != CreateRestorePoint())
                {
                    if (lang.Trim().Equals("Anglais"))
                    {
                        MessagesShow yos = new MessagesShow("restore point create : " + DateTime.Now.ToString(), "Yes", "Restore Point");
                        //AutoClosingMessageBox.Show("restore point create : " + DateTime.Now.ToString(), "Restore Point", 10000);
                    }
                    else
                    {
                        MessagesShow yos = new MessagesShow("Point de restauration creer le : " + DateTime.Now.ToString(), "Oui", "Point de Restauration");
                        //AutoClosingMessageBox.Show("Point de restauration creer le : " + DateTime.Now.ToString(), "Point de Restauration", 10000);
                    }
                    getRestorePoint();
                    guna2DataGridView5.Visible = true;
                    guna2WinProgressIndicator1.Visible = false;
                    label78.Visible = false;
                    label79.Visible = false;
                }
                else
                {
                    guna2DataGridView5.Visible = false;
                    guna2WinProgressIndicator1.Visible = true;
                    label79.Visible = true;
                    label78.Visible = false;
                    if (CreateRestorePoint() == true)
                    {
                        if (lang.Trim().Equals("Anglais"))
                        {
                            MessagesShow yos = new MessagesShow("restore point create : " + DateTime.Now.ToString(), "Yes", "Restore Point");
                            //AutoClosingMessageBox.Show("restore point create : " + DateTime.Now.ToString(), "Restore Point", 10000);
                        }
                        else
                        {
                            MessagesShow yos = new MessagesShow("Point de restauration creer le : " + DateTime.Now.ToString(), "Oui", "Point de Restauration");
                            //AutoClosingMessageBox.Show("Point de restauration creer le : " + DateTime.Now.ToString(), "Point de Restauration", 10000);
                        }
                        getRestorePoint();
                        guna2DataGridView5.Visible = true;
                        guna2WinProgressIndicator1.Visible = false;
                        label78.Visible = false;
                        label79.Visible = false;
                    }
                    else
                    {
                        guna2DataGridView5.Visible = false;
                        guna2WinProgressIndicator1.Visible = false;
                        label78.Visible = false;
                        label79.Visible = true;
                        this.label79.Location = new System.Drawing.Point(150, 220);
                        if (lang.Trim().Equals("Anglais"))
                        {
                            label79.Text = "Unable to create a restore point";
                        }
                        else
                        {
                            label79.Text = "Impossible de creer un point de restoration";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
            }

            ManagementClass c = new ManagementClass("root/default:SystemRestore");
            Console.WriteLine(c.ToString());
            try
            {
                foreach (ManagementObject o in c.GetInstances())
                {
                    guna2DataGridView5.Rows.Add(o["Description"].ToString(), o["RestorePointType"].ToString(), o["EventType"].ToString(), o["SequenceNumber"].ToString(), getDate(o["CreationTime"].ToString()));
                }
            }
            catch (Exception e)
            {
                //Console.WriteLine(e.Message.ToString());
            }
        }
        public String getDate(String d)
        {
            String date = d.Remove(4);
            d = d.Remove(0, 4);
            date += "/" + d.Remove(2);
            d = d.Remove(0, 2);
            date += "/" + d.Remove(2);
            d = d.Remove(0, 2);
            date += " " + d.Remove(2);
            d = d.Remove(0, 2);
            date += ":" + d.Remove(2);
            d = d.Remove(0, 2);
            date += ":" + d.Remove(2);
            return date;
        }
        //Create restore point
        public static bool CreateRestorePoint()
        {
            bool isCreated = true;
            try
            {
                ManagementObject classInstance =
                   new ManagementObject(@"root\DEFAULT",
                   "SystemRestore.ReplaceKeyPropery='ReplaceKeyPropertyValue'",
                   null);

                // Obtain in-parameters for the method
                ManagementBaseObject inParams =
                    classInstance.GetMethodParameters("CreateRestorePoint");

                // Add the input parameters.
                inParams["Description"] = "My test restore point";
                inParams["EventType"] = 100;
                inParams["RestorePointType"] = 0;

                // Execute the method and obtain the return values.
                ManagementBaseObject outParams =
                    classInstance.InvokeMethod("CreateRestorePoint", inParams, null);

                // List outParams
                Console.WriteLine("Out parameters:");
                Console.WriteLine("Return Value restore point => " + outParams["ReturnValue"]);

                isCreated = (outParams == null) ? !isCreated : isCreated;
            }
            catch (ManagementException me)
            {
                //handle the error.
                Console.WriteLine("Return Value restore point2 => " + me.Message);
                isCreated = !isCreated;

            }
            return isCreated;
        }
        // Delete restore Point
        [DllImport("Srclient.dll")]
        public static extern int SRRemoveRestorePoint(int index);
        public static int DeleteRestorePoint(int SequenceNumber)
        {
            int intReturn = SRRemoveRestorePoint(SequenceNumber);
            return intReturn;
        }

        //Frequently crash program
        public void LogDisplay()
        {
            guna2DataGridView6.Rows.Clear();
            EventLog[] eventLogs = EventLog.GetEventLogs();
            try
            {
                foreach (EventLog e in eventLogs)
                {
                    Int64 sizeKB = 0;
                    string logfile = "";
                    string currentsize = "";
                    string creationdatetime = "";
                    Console.WriteLine();
                    Console.WriteLine("{0}:", e.LogDisplayName.ToString());
                    Console.WriteLine("  Log name = \t\t {0}", e.Log.ToString());

                    Console.WriteLine("  Number of event log entries = {0}", e.Entries.Count.ToString());

                    // Determine if there is an event log file for this event log.
                    RegistryKey regEventLog = Registry.LocalMachine.OpenSubKey("System\\CurrentControlSet\\Services\\EventLog\\" + e.Log.ToString());
                    if (regEventLog != null)
                    {
                        Object temp = regEventLog.GetValue("File");
                        if (temp != null)
                        {
                            Console.WriteLine("  Log file path = \t {0}", temp.ToString());
                            logfile = temp.ToString();
                            FileInfo file = new FileInfo(temp.ToString());
                            creationdatetime = file.CreationTime.ToString();

                            // Get the current size of the event log file.
                            if (file.Exists)
                            {
                                sizeKB = file.Length / 1024;
                                if ((file.Length % 1024) != 0)
                                {
                                    sizeKB++;
                                }
                                Console.WriteLine("  Current size = \t {0} kilobytes", sizeKB.ToString());
                                currentsize = sizeKB.ToString();
                            }
                        }
                        else
                        {
                            Console.WriteLine("  Log file path = \t <not set>");
                        }
                    }

                    // Display the maximum size and overflow settings.

                    sizeKB = e.MaximumKilobytes;
                    Console.WriteLine("  Maximum size = \t {0} kilobytes", sizeKB.ToString());
                    Console.WriteLine("  Overflow setting = \t {0}", e.OverflowAction.ToString());

                    /*switch (e.OverflowAction)
                    {
                        case OverflowAction.OverwriteOlder:
                            Console.WriteLine("\t Entries are retained a minimum of {0} days.",
                                e.MinimumRetentionDays);
                            break;
                        case OverflowAction.DoNotOverwrite:
                            Console.WriteLine("\t Older entries are not overwritten.");
                            break;
                        case OverflowAction.OverwriteAsNeeded:
                            Console.WriteLine("\t If number of entries equals max size limit, a new event log entry overwrites the oldest entry.");
                            break;
                        default:
                            break;
                    }*/

                    guna2DataGridView6.Rows.Add(
                    e.Log.ToString(), e.Entries.Count.ToString(),
                    logfile,
                    sizeKB.ToString() + " KB",
                    e.OverflowAction.ToString(),
                    creationdatetime);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Crasher log => " + ex.Message);
            }
        }

        // Event Log
        /*public void EventLogAlert()
        {
            GetSystemLogs();
            GetSecurityLogs();
            GetApplicationLogs();
        }

        public void GetSystemLogs()
        {
            if (!EventLog.Exists("System", Environment.MachineName))
            {
                labelSystemCount.Text = "0";
                return;
            }
            else
            {
                EventLog myLog = new EventLog("System", Environment.MachineName);
                labelSystemCount.Text = myLog.Entries.Count.ToString();
            }
        }
        public void GetSecurityLogs()
        {
            try
            {
                if (!EventLog.Exists("Security", Environment.MachineName))
                {
                    labelSecurityCount.Text = "0";
                    return;
                }
                else
                {
                    EventLog myLog = new EventLog("Security", Environment.MachineName);
                    labelSecurityCount.Text = myLog.Entries.Count.ToString();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public void GetApplicationLogs()
        {
            if (!EventLog.Exists("Application", Environment.MachineName))
            {
                labelAppCount.Text = "0";
                return;
            }
            else
            {
                EventLog myLog = new EventLog("Application", Environment.MachineName);
                labelAppCount.Text = myLog.Entries.Count.ToString();
            }
        }*/

        private void EventLogAlert_Load()
        {
            /*guna2DataGridView8.FullRowSelect = true;*/
            guna2DataGridView8.Rows.Clear();
            EventLog[] remoteEventLogs;

            remoteEventLogs = EventLog.GetEventLogs();

            Console.WriteLine("Number of logs on computer: " + remoteEventLogs.Length);
            try
            {
                foreach (EventLog log in remoteEventLogs)
                {
                    Console.WriteLine("Log: " + log.Log);
                    guna2DataGridView8.Rows.Add(log.Log.ToString(), log.OverflowAction.ToString(), log.Entries.Count.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Crasher log => " + ex.Message);
            }
        }

        //******************************************************************************************************************************
        // End stability
        //******************************************************************************************************************************

        //******************************************************************************************************************************
        // Start maintain 
        //******************************************************************************************************************************
        // reclycle bin display
        private void recyclebin()
        {
            // Recycle bin content Begin 
            Shell shell = new Shell();
            Folder folder = shell.NameSpace(0x000a);

            resizing3();

            double taille = 0;
            try
            {
                guna2DataGridView9.Rows.Clear();
                foreach (FolderItem2 item in folder.Items())
                {
                    string chemin = CheminCorbeille(item.Name);
                    Console.WriteLine("FileName:{0}     Size:{1} bytes    path : {2}", item.Name, CalculateSize(item), chemin);

                    guna2DataGridView9.Rows.Add(item.Name.ToString(), CalculateSize(item).ToString() + " Mo", chemin, item.ModifyDate.ToString());

                    taille = taille + CalculateSize(item);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Recycle Bin Error => " + e.Message);
            }
            /*label1.Text = " Taille du contenu de la Corbeille : " + taille + " Mo";*/


            Marshal.FinalReleaseComObject(shell);
            Console.ReadLine();

            // End Recycle bin content
            // create shell
            //var shell = new Shell();

            // get recycler folder
            /*var recyclerFolder = shell.NameSpace(10);

            double taille = 0;
            // for each files
            try
            {
                guna2DataGridView9.Rows.Clear();
                foreach (FolderItem2 item in recyclerFolder.Items())
                {
                    // get the folder item
                    //var folderItems = recyclerFolder.Items().Item(i);

                    // get file name
                    //var filename = recyclerFolder.GetDetailsOf(folderItems, 0);
                    //string chemin = CheminCorbeille(filename);
                    // write file path to console
                    string chemin = CheminCorbeille(item.Name);
                    Console.WriteLine("FileName:{0}     Size:{1} bytes    path : {2}", item.Name, CalculateSize(item), chemin);

                    guna2DataGridView9.Rows.Add(item.Name.ToString(), CalculateSize(item).ToString() + " Mo", chemin, item.ModifyDate.ToString());

                    taille = taille + CalculateSize(item);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        public void CorbeilleListe()
        {
            // create shell
            var shell = new Shell();

            // get recycler folder
            var recyclerFolder = shell.NameSpace(10);

            // for each files
            for (int i = 0; i < recyclerFolder.Items().Count; i++)
            {
                // get the folder item
                var folderItems = recyclerFolder.Items().Item(i);

                // get file name
                var filename = recyclerFolder.GetDetailsOf(folderItems, 0);
                string chemin = CheminCorbeille(filename);
                // write file path to console
                //MessageBox.Show("fileName = "+filename+" taille = "+10+" Chemin = "+chemin);
            }
        }

        // temporaly files
        private void tempoFiles()
        {
            guna2DataGridView10.Rows.Clear();
            // Temporary Files Begin
            DirectoryInfo Dir = new DirectoryInfo(System.IO.Path.GetTempPath());
            string tempFile = Path.GetTempPath();

            FileInfo[] Files = Dir.GetFiles();
            int i = 0;
            int taill = 0;
            resizing4();
            try
            {
                foreach (FileInfo file in Files)
                {
                    //Console.WriteLine((int)file.Length);
                    /* taill = taill + (int)file.Length;*/
                    taill = (int)file.Length;
                    guna2DataGridView10.Rows.Add(file.Name, taill + " Bytes", i.ToString());
                    i++;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Tempo Files Error => " + e.Message);
            }
            // End Temporary File 
        }
        //delete temporaly files 
        private void deleteTempoFiles()
        {
            DirectoryInfo Dir1 = new DirectoryInfo(System.IO.Path.GetTempPath());
            string tempFile1 = Path.GetTempPath();

            FileInfo[] Files1 = Dir1.GetFiles();
            int i1 = 0;
            resizing4();
            try
            {
                foreach (FileInfo file1 in Files1)
                {
                    File.Delete(file1.ToString());
                    i1++;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Tempo Files Deteleted Error message => " + e.Message);
            }
            guna2DataGridView10.Rows.Clear();
        }
        private void guna2Button22_Click(object sender, EventArgs e)
        {
            deleteTempoFiles();
        }
        // Startup Programs
        private void startupPrograms()
        {
            // Startup Software Begin
            ManagementClass mangnmt = new ManagementClass("Win32_StartupCommand");
            ManagementObjectCollection mcol = mangnmt.GetInstances();
            resizing5();
            foreach (ManagementObject strt in mcol)
            {
                guna2DataGridView11.Rows.Add(strt["Name"].ToString(), strt["Location"].ToString(), strt["Command"].ToString(), strt["User"].ToString());
                //Console.WriteLine("User: " + strt["User"].ToString());
            }

            // End Startup Software 
        }
        // Display windows Update
        private void displayWindowsUpdates()
        {
            guna2WinProgressIndicator2.Visible = false;
            /*label84.Visible = true;
            label90.Visible = true;*/
            label91.Visible = true;
            label92.Visible = true;

            // Windows Update Begin

            var AUC = new AutomaticUpdatesClass();
            try
            {
                bool isWUEnabled = AUC.ServiceEnabled;

                if (isWUEnabled)
                {
                    //Console.WriteLine("Windows Update is Enabled");
                    label90.Text = "Enabled";
                }
                else
                {
                    //Console.WriteLine("Windows Update is Disabled");
                    label90.Text = "Disabled";
                }

                DateTime? lastInstallationSuccessDateUtc = null;
                if (AUC.Results.LastInstallationSuccessDate is DateTime)
                {
                    lastInstallationSuccessDateUtc = new DateTime(((DateTime)AUC.Results.LastInstallationSuccessDate).Ticks, DateTimeKind.Utc);
                    label92.Text = lastInstallationSuccessDateUtc.ToString();
                }

                DateTime? lastSearchSuccessDateUtc = null;
                if (AUC.Results.LastSearchSuccessDate is DateTime)
                {
                    lastSearchSuccessDateUtc = new DateTime(((DateTime)AUC.Results.LastSearchSuccessDate).Ticks, DateTimeKind.Utc);
                    label91.Text = lastSearchSuccessDateUtc.ToString();
                }
            }
            catch(Exception ex)
            {
                MessagesShow to = new MessagesShow(ex.Message, "");
            }

            // End Windows update 
        }
        // get windows Update
        private void GetSystemUpdate()
        {
            guna2DataGridView12.Rows.Clear();
            label89.Visible = false;
            label84.Visible = false;
            label90.Visible = false;
            label91.Visible = false;
            label92.Visible = false;

            /*
             var auc = new AutomaticUpdatesClass();

             DateTime? lastInstallationSuccessDateUtc = null;
             if (auc.Results.LastInstallationSuccessDate is DateTime)
                lastInstallationSuccessDateUtc = new DateTime(((DateTime)auc.Results.LastInstallationSuccessDate).Ticks, DateTimeKind.Utc);

             DateTime? lastSearchSuccessDateUtc = null;
             if (auc.Results.LastSearchSuccessDate is DateTime)
             lastSearchSuccessDateUtc = new DateTime(((DateTime)auc.Results.LastSearchSuccessDate).Ticks, DateTimeKind.Utc);
             */


            // Now, we need to search the Microsoft updates
            //MessageBox.Show("Etape 1");
            try
            {
                UpdateSessionClass uSession = new UpdateSessionClass();
                IUpdateSearcher uSearcher = uSession.CreateUpdateSearcher();
                ISearchResult uResult = uSearcher.Search("IsInstalled=0 and Type = 'Software'");
                if (uResult.Updates.Count < 1)
                {
                    var auc = new AutomaticUpdatesClass();

                    DateTime? lastInstallationSuccessDateUtc = null;
                    if (auc.Results.LastInstallationSuccessDate is DateTime)
                        lastInstallationSuccessDateUtc = new DateTime(((DateTime)auc.Results.LastInstallationSuccessDate).Ticks, DateTimeKind.Utc);
                        label92.Text = lastInstallationSuccessDateUtc.ToString();
                    DateTime? lastSearchSuccessDateUtc = null;
                    if (auc.Results.LastSearchSuccessDate is DateTime)
                        lastSearchSuccessDateUtc = new DateTime(((DateTime)auc.Results.LastSearchSuccessDate).Ticks, DateTimeKind.Utc);
                    label91.Text = lastSearchSuccessDateUtc.ToString();
                    if (lang.Trim().Equals("Anglais"))
                    {
                        MessagesShow yos = new MessagesShow("No new updates available ");
                        //AutoClosingMessageBox.Show("No new updates available");
                    }
                    else
                    {
                        MessagesShow yos = new MessagesShow("Aucune nouvelle mise à jour disponible ");
                        //AutoClosingMessageBox.Show("Aucune nouvelle mise à jour disponible");
                    }
                }
                else
                {
                    foreach (IUpdate update in uResult.Updates)
                    {
                        if (lang.Trim().Equals("Anglais"))
                        {
                            Console.WriteLine("Update Message => " + update.Title);
                            MessagesShow to = new MessagesShow("Update Message => " + update.Title, "");
                        }
                        else
                        {
                            Console.WriteLine("Update Message => " + update.Title);
                            MessagesShow to = new MessagesShow("Message de mise à jour => " + update.Title, "");
                        }
                    }
                    //MessageBox.Show("Etape 2");
                    //Now we have to create an UpdateDownloader class object to download the updates
                    try
                    {
                        UpdateDownloader downloader = uSession.CreateUpdateDownloader();
                        downloader.Updates = uResult.Updates;
                        downloader.Download();
                    }
                    catch (Exception ex)
                    {
                        MessagesShow to = new MessagesShow("No Update available ", "");
                    }

                    //Now, as we have completed the download of the required updates, we have to install the
                    //downloaded updates by checking its IsDownloaded property is true.
                    int i = 0;
                    int size = 0;
                    UpdateCollection updatesToInstall = new UpdateCollection();
                    foreach (IUpdate update in uResult.Updates)
                    {
                        //MessageBox.Show("No : " + update);
                        try
                        {
                            if (update.IsDownloaded)
                                updatesToInstall.Add(update);
                            i++;
                            size = size + (int)update.MaxDownloadSize;
                            if (guna2DataGridView12.Rows.Count == 0)
                            {
                                guna2DataGridView12.Visible = false;
                                guna2WinProgressIndicator2.Visible = false;
                            }
                            else
                            {
                                guna2DataGridView12.Rows.Add(update.Title, update.MaxDownloadSize.ToString() + " KB");
                            }
                        }
                        catch (Exception ex)
                        {
                            //MessageBox.Show("Exception 10 : " + ex.Message);
                            Console.WriteLine($"{ex.Message}");
                        }

                    }
                    //MessageBox.Show("Etape 3");
                    label90.Visible = true;
                    label91.Visible = true;
                    label92.Visible = true;

                    label89.Text = i.ToString();
                    label84.Text = size.ToString() + " KB";
                    //Now assign the update collection of to be installed updates to the installer class
                    IUpdateInstaller installer = uSession.CreateUpdateInstaller();
                    installer.Updates = updatesToInstall;
                    //MessageBox.Show("Etape 4 : "+ installer);
                    //Now, call the install method of the IUpdateInstaller object and result of which will be stored in
                    //IInstallationResult object installationRes.
                    IInstallationResult installationRes = installer.Install();

                    //Now as all updates will be installed sequentally by the WUAPI
                    int k = 0, l = 0;
                    for (int i1 = 0; i1 < updatesToInstall.Count; i1++)
                    {
                        if (installationRes.GetUpdateResult(i1).HResult == 0)
                        {
                            Console.WriteLine("Installed : " + updatesToInstall[i1].Title);
                            k++;
                        }
                        else
                        {
                            Console.WriteLine("Failed : " + updatesToInstall[i1].Title);
                            l++;
                        }
                    }

                    if (!lang.Equals("Anglais"))
                    {
                        MessagesShow yos = new MessagesShow("Draka Antivirus a Intaller : " + k + " Mise a jour et : " + l + " Ne sont pas installer", "Oui", "Update");
                        //AutoClosingMessageBox.Show("Draka Antivirus a Intaller : " + k + " Mise a jour et : " + l + " Ne sont pas installer", "Update", 10000);
                    }
                    else
                    {
                        MessagesShow yos = new MessagesShow("Draka Antivirus has Intaller: " + k + " Update and: " + l + " Fail to install", "Yes", "Update");
                        //AutoClosingMessageBox.Show("Draka Antivirus has Intaller: " + k + " Update and: " + l + " Fail to install", "Update", 10000);
                    }
                    label90.Visible = true;
                    label91.Visible = true;
                    label92.Visible = true;

                    var AUC = new AutomaticUpdatesClass();
                    bool isWUEnabled = AUC.ServiceEnabled;
                    if (isWUEnabled)
                    {
                        //Console.WriteLine("Windows Update is Enabled");
                        label90.Text = "Enabled";
                    }
                    else
                    {
                        //Console.WriteLine("Windows Update is Disabled");
                        label90.Text = "Disabled";
                    }

                    DateTime? lastInstallationSuccessDateUtc = null;
                    if (AUC.Results.LastInstallationSuccessDate is DateTime)
                    {
                        lastInstallationSuccessDateUtc = new DateTime(((DateTime)AUC.Results.LastInstallationSuccessDate).Ticks, DateTimeKind.Utc);
                        label92.Text = lastInstallationSuccessDateUtc.ToString();
                    }

                    DateTime? lastSearchSuccessDateUtc = null;
                    if (AUC.Results.LastSearchSuccessDate is DateTime)
                    {
                        lastSearchSuccessDateUtc = new DateTime(((DateTime)AUC.Results.LastSearchSuccessDate).Ticks, DateTimeKind.Utc);
                        label91.Text = lastSearchSuccessDateUtc.ToString();
                    }
                }
            }catch(Exception ex)
            {
                //MessagesShow to = new MessagesShow(ex.Message, "");
                MessagesShow tos = new MessagesShow("Error while installing Updates");
                //AutoClosingMessageBox.Show("Error while installing Updates");
                //Console.WriteLine(installationRes.);
            }
        }
        
        private void guna2Button23_Click(object sender, EventArgs e)
        {
            MessagesShow to = new MessagesShow("Update en cours ...", "");
            GetSystemUpdate();
        }
        // update Btn
        // gestion des mises a jour.
        private void updateBtn_Click(object sender, EventArgs e)
        {
            // ici je vérifi la mise à jour de la base virale
            //MessageBox.Show("totoooooooooooooooooo");
            if (btnUpdate.Equals("Plusieurs"))
            {
                // des mises a jours sont disponibles
                if (lang.Equals("Anglais"))
                {
                    MessagesShow to = new MessagesShow("Do you want to update this application ?", "oui", "Update history");
                }
                else
                {
                    MessagesShow to = new MessagesShow("Voulez-vous mettre à jour cette application ?", "oui", "Historique de mise a jour");
                }
                var result = File.ReadAllText(MessageOK).ToString().Trim();
                //MessageBox.Show("result = " + result);
                if (result.ToString().Equals("non") || result.ToString().Equals("No"))
                {
                    //MessageBox.Show("non loin de la");
                    btnUpdate = "Plusieurs";
                    
                }
                else
                {
                    // ici on doit ajouter la methode de mise a jour                    
                    UpdateViralBasisFinal();
                    //-1- prendre l'heure des mises a jours.
                    // Obtenir la date et l'heure actuelles
                    DateTime currentDateTime = DateTime.Now;
                    //string heureJour = currentDateTime.ToString("HH:mm:ss");
                    string heureJour = currentDateTime.ToString("dddd, dd MMMM yyyy  hh:mm:ss");
                    //-2- Mise a jour viral
                    //UpdateChemin
                    
                    //-3- statut de la mise a jour
                    string statut = "";

                    if (lang.Equals("Anglais"))
                    {
                        statut = "Update ok";
                    }
                    else
                    {
                        statut = "Mise à jour ok";
                    }

                    // Connexion a la base de donnees. Update
                    if (db1.CreateTable(sourceFile, "UpdateTable") == true)
                    {
                        //MessageBox.Show("Table Update creer.");
                    }
                    else
                    {
                        string sql = "insert into UpdateTable (date, MJour, Statut) values(";
                        //sql = sql + "'" + index + "', ";
                        sql = sql + "'" + heureJour + "', ";
                        sql = sql + "'" + UpdateChemin + "', ";                        
                        sql = sql + "'" + statut + "')";

                        try
                        {
                            Boolean error = db1.insertData(sourceFile, sql);
                            if (error == true)
                            {
                                if (lang.Equals("Anglais"))
                                {
                                    MessagesShow yoos = new MessagesShow("Update completed successfully", "", "Update");
                                }
                                else
                                {
                                    MessagesShow yoos = new MessagesShow("Mise à jour terminée avec succès", "", "Mise à jour");
                                }
                            }
                            else
                            {
                                if (lang.Equals("Anglais"))
                                {
                                    MessagesShow yoos = new MessagesShow("Update not saved", "", "Update");
                                }
                                else
                                {
                                    MessagesShow yoos = new MessagesShow("Mise à jour non enregistrée", "", "Mise à jour");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            //AutoClosingMessageBox.Show(""+ex.Message);
                            MessagesShow yo = new MessagesShow(ex.Message, "");
                        }
                        btnUpdate = "Aucun";
                    }
                }
            }
            else
            {
                // aucune mise a jour disponible.
                if (lang.Equals("Anglais"))
                {
                    MessagesShow yoos = new MessagesShow("No update available", "", "Update");
                }
                else
                {
                    MessagesShow yoos = new MessagesShow("Aucune mise à jour disponible", "", "Mise à jour");
                }
                btnUpdate = "Aucun";
            }
            Updateloading();
            guna2DataGridView133.Visible = true;
            pagesView.SelectTab("histoHupdate");

            // methode de chargement des fichiers dans la grille.           

        }

        // chargement du datagrid
        private void Updateloading()
        {
            guna2DataGridView133.Rows.Clear();
            //int indice = guna2DataGridView14.CurrentCell.RowIndex;
            int i1 = 0;
            //string sql2 = "select date, MJour, Statut from UpdateTable where Id='" + i1 + "';";
           // string sql2 = "select * from UpdateTable;";
            string sql22 = "SELECT COUNT(*) FROM UpdateTable;";
            Object[] dburl1 = db1.searchData(sourceFile, sql22);
            string ii = dburl1[0].ToString();
            i1 = Int32.Parse(ii);
            int i = 1;
           
            while (i1 > 0)
            {
                //Object[] dburl = db1.searchData(sourceFile, sql2);
                /*if (dburl != null)
                {
                    guna2DataGridView133.Rows.Add(dburl[1].ToString(), dburl[2].ToString(), dburl[3].ToString());
                }*/
                string sql25 = "select * from UpdateTable where Id= " + i + ";";
                Object[] dburl = db1.searchData(sourceFile, sql25);

                if (dburl != null)
                {
                    guna2DataGridView133.Rows.Add(dburl[1].ToString(), dburl[2].ToString(), dburl[3].ToString());
                }
                i++;
                i1--;
            }
        }
        // Others Methods
        public void resizing4()
        {
            float totalColumnWidth = 0;

            // Get the sum of all column tags
            for (int i = 0; i < guna2DataGridView10.Columns.Count; i++)
                totalColumnWidth += Convert.ToInt32(guna2DataGridView10.Columns[i].Tag);

            // Calculate the percentage of space each column should 
            // occupy in reference to the other columns and then set the 
            // width of the column to that percentage of the visible space.
            for (int i = 0; i < guna2DataGridView10.Columns.Count; i++)
            {
                float colPercentage = (Convert.ToInt32(guna2DataGridView10.Columns[i].Tag) / totalColumnWidth);
                guna2DataGridView10.Columns[i].Width = (int)(colPercentage * guna2DataGridView10.ClientRectangle.Width);
            }
        }
        public void resizing5()
        {
            float totalColumnWidth = 0;

            // Get the sum of all column tags
            for (int i = 0; i < guna2DataGridView11.Columns.Count; i++)
                totalColumnWidth += Convert.ToInt32(guna2DataGridView11.Columns[i].Tag);

            // Calculate the percentage of space each column should 
            // occupy in reference to the other columns and then set the 
            // width of the column to that percentage of the visible space.
            for (int i = 0; i < guna2DataGridView11.Columns.Count; i++)
            {
                float colPercentage = (Convert.ToInt32(guna2DataGridView11.Columns[i].Tag) / totalColumnWidth);
                guna2DataGridView11.Columns[i].Width = (int)(colPercentage * guna2DataGridView11.ClientRectangle.Width);
            }
        }
        public static double CalculateSize(FolderItem obj)
        {

            if (!obj.IsFolder)
                return (double)Math.Round(obj.Size / Math.Pow(1024, 2), 2);

            Folder recycleBin = (Folder)obj.GetFolder;

            double size = 0;


            foreach (FolderItem2 item in recycleBin.Items())
                size += CalculateSize(item);

            return size;

        }
        enum RecycleFlags : int
        {
            SHRB_NOCONFIRMATION = 0x00000001, // Don't ask for confirmation
            SHRB_NOPROGRESSUI = 0x00000001, // Don't show progress
            SHRB_NOSOUND = 0x00000004 // Don't make sound when the action is executed
        }
        [DllImport("Shell32.dll", CharSet = CharSet.Unicode)]
        static extern uint SHEmptyRecycleBin(IntPtr hwnd, string pszRootPath, RecycleFlags dwFlags);
        public void resizing3()
        {
            float totalColumnWidth = 0;

            // Get the sum of all column tags
            for (int i = 0; i < guna2DataGridView9.Columns.Count; i++)
                totalColumnWidth += Convert.ToInt32(guna2DataGridView9.Columns[i].Tag);

            // Calculate the percentage of space each column should 
            // occupy in reference to the other columns and then set the 
            // width of the column to that percentage of the visible space.
            for (int i = 0; i < guna2DataGridView9.Columns.Count; i++)
            {
                float colPercentage = (Convert.ToInt32(guna2DataGridView9.Columns[i].Tag) / totalColumnWidth);
                guna2DataGridView9.Columns[i].Width = (int)(colPercentage * guna2DataGridView9.ClientRectangle.Width);
            }
        }
        //******************************************************************************************************************************
        // End maintain
        //******************************************************************************************************************************

        //******************************************************************************************************************************
        // Start Histroy
        //******************************************************************************************************************************

        private void Historicsloading7()
        {
            choix = "";
            Int32 selectedCellCount1 = 0;
            // ici nous allons lire le contenu des fichiers scan
            Fouille();
            FouilleScanProg();
            try
            {
                if (File.Exists(sourceFile))
                {
                    Boolean verif = db1.CreateTable(sourceFile, "HistoryScan");
                    if (verif == true)
                    {
                        //MessageBox.Show("La tale HistoryScan creer ");
                        pictureBox1.Visible = true;
                        label93.Visible = true;
                        guna2DataGridView13.Visible = false;
                        selectedCellCount1 = 0;
                    }
                    else
                    {
                        //MessageBox.Show("La tale HistoryScan Existe deja ");
                        selectedCellCount1 = guna2DataGridView13.Rows.Count;
                        //MessageBox.Show("Nous sommes dans la tale quarantaine : "+selectedCellCount1);

                        string sql2 = "";
                        int i1 = 1;
                        // acces à la as la valeur max de la table History
                        //string sql = "SELECT MAX(Id) FROM HistoryScan; ";

                        int LastRowID = NewTailleTableau("HistoryScan");
                        //MessageBox.Show("Taille tableau historyscan. "+ LastRowID);
                        pictureBox1.Visible = true;
                        label93.Visible = true;
                        guna2DataGridView13.Visible = false;

                        guna2DataGridView13.Rows.Clear();

                        try
                        {
                            if (LastRowID > 0)
                            {
                                pictureBox1.Visible = false;
                                label93.Visible = false;
                                guna2DataGridView13.Rows.Clear();

                                while (i1 <= LastRowID)
                                {
                                    sql2 = "select * from HistoryScan where Id= " + i1 + ";";
                                    Object[] dburl = db1.searchData(sourceFile, sql2);

                                    if (dburl != null)
                                    {
                                        guna2DataGridView13.Rows.Add(dburl[1].ToString(), dburl[3].ToString(), dburl[5].ToString());
                                    }

                                    i1++;
                                    guna2DataGridView13.Visible = true;
                                }
                            }
                            else
                            {
                                pictureBox1.Visible = true;
                                label93.Visible = true;
                                guna2DataGridView13.Visible = false;
                            }

                        }
                        catch (Exception ex)
                        {
                            if (!File.Exists(path))
                            {
                                File.Create(path);
                                TextWriter tw = new StreamWriter(path, true);
                                tw.WriteLine(DateTime.Now.ToString() + " " + "Request:" + " " + sql2 + " " + "Error_Message:" + ex);
                                tw.Close();
                            }

                            else if (File.Exists(path))
                            {
                                TextWriter tw = new StreamWriter(path, true);
                                tw.WriteLine(DateTime.Now.ToString() + " " + "Request:" + " " + sql2 + " " + "Error_Message:" + ex);
                                tw.Close();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //AutoClosingMessageBox.Show("Oups");
                //MessageBox.Show("An error has occurred, restart the application");
                guna2DataGridView13.Visible = false;
            }

        }

        //Open report
        private void guna2Button29_Click(object sender, EventArgs e)  // ici c'est open report
        {
            Int32 selectedCellCount = guna2DataGridView13.GetCellCount(DataGridViewElementStates.Selected);

            //MessageBox.Show("Je suis open repport " + selectedCellCount);
            int i1 = 0;
            if (guna2DataGridView13.CurrentRow == null)
            {
                if (lang.Equals("Anglais"))
                {
                    MessagesShow to = new MessagesShow("No line select  ", "");
                }
                else
                {
                    MessagesShow to = new MessagesShow("Aucune ligne selectionnée ", "");
                }
            }
            else
            {
                if(selectedCellCount > 0)
                {
                    if (guna2DataGridView13.CurrentRow != null)
                    {
                        int indice = guna2DataGridView13.CurrentCell.RowIndex;
                        i1 = indice + 1;
                        string date = (string)guna2DataGridView13[0, indice].Value;
                        //string sql8 = "select date, duree, TotalVirus, totalAna, TypeScan, Etat from HistoryScan where Id= " + date + ";";
                        string sql8 = "select * from HistoryScan where Id= " + i1 + ";";

                        try
                        {
                            Object[] dburl = db1.searchData(sourceFile, sql8);

                            if (dburl != null)
                            {
                                RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows NT\\CurrentVersion");
                                string pathName = (string)registryKey.GetValue("productName");
                                string strr = "";
                                string strrr = "";
                                ManagementObjectSearcher mos = new ManagementObjectSearcher(@"root\CIMV2", @"SELECT * FROM Win32_ComputerSystem");
                                foreach (ManagementObject mo in mos.Get())
                                {
                                    strr = mo["Workgroup"].ToString();
                                }

                                ManagementObjectSearcher myProcessorObject = new ManagementObjectSearcher("select * from Win32_Processor");

                                foreach (ManagementObject obj in myProcessorObject.Get())
                                {
                                    strrr = obj["Name"].ToString();
                                }

                                if (lang.Equals("Anglais"))
                                {
                                    string[] str = new string[]
                                    {
                                "Product Name       : Draka Shiel Antivirus",
                                "Analysis status    : " + dburl[6],
                                "Date of analysis   : " + dburl[1],
                                "Type of analysis   : " + dburl[5],
                                "Analysis Duration  : " + dburl[2],
                                "Scanned objects    : " + dburl[4],
                                "Viruses detected   : " + dburl[3],
                                "Object excluded    : 00",
                                "Auto send          : No",
                                "Operating system   : " + pathName,
                                "Processor          : " + strrr,
                                "Domain information : " + strr,
                                "Scanner Directory  : " + dburl[7],
                                "CUID               : " + "Ras"
                                    };

                                    using (StreamWriter sw = new StreamWriter(OuvrirRapport))
                                    {
                                        foreach (string s in str)
                                        {
                                            sw.WriteLine(s);
                                        }
                                    }
                                }
                                else
                                {
                                    string[] str = new string[]
                                    {
                                "Nom du produit         : Draka Shiel Antivirus",
                                "État de l'analyse      : " + dburl[6],
                                "Date de l'analyse      : " + dburl[1],
                                "Type d'analyse         : " + dburl[5],
                                "Durée de l'analyse     : " + dburl[2],
                                "Objets Scannés         : " + dburl[4],
                                "Virus Détectés         : " + dburl[3],
                                "Objet Exclu            : 00",
                                "Envoi Automatique      : No",
                                "Logiciel Base          : " + pathName,
                                "Processeur             : " + strrr,
                                "Information Domaine    : " + strr,
                                "Répertoire Scanné      : " + dburl[7],
                                "CUID                   : " + "Ras"
                                    };

                                    using (StreamWriter sw = new StreamWriter(OuvrirRapport))
                                    {
                                        foreach (string s in str)
                                        {
                                            sw.WriteLine(s);
                                        }
                                    }
                                }

                            }
                            else
                            {
                                if (lang.Equals("Anglais"))
                                {
                                    MessagesShow yos = new MessagesShow("Please check that the item chosen is correct", "Oui", "Details Historique");
                                    //AutoClosingMessageBox.Show("Please check that the item chosen is correct", "Details Historique", 10000);
                                }
                                else
                                {
                                    MessagesShow yos = new MessagesShow("Veuillez vérifier que l'article choisi est correct", "Oui", "Détails Historique");
                                    //AutoClosingMessageBox.Show("Veuillez vérifier que l'article choisi est correct", "Détails Historique", 10000);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //MessageBox.Show("Ligne séléctionnée : " +indice.ToString() +" Date : "+date);
                    }

                    // ouvrir le rapport
                    try
                    {
                        Process proc = new Process();
                        proc.StartInfo = new ProcessStartInfo(OuvrirRapport);
                        proc.Start();
                    }
                    catch (Win32Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
                       

        }

        // supprimer la ligne historique
        private void guna2Button30_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView13.CurrentRow == null)
            {
                if (lang.Equals("Anglais"))
                {
                    MessagesShow to = new MessagesShow("No line select ", "");
                }
                else
                {
                    MessagesShow to = new MessagesShow("Aucune ligne séléctionnée ", "");
                }
            }
            else
            {
                if (choix.Equals("SelH"))
                {
                    // ici on supprime tous le contenue de la table
                    string sql7 = "DROP TABLE HistoryScan";

                    /*DialogResult result;

                    if (lang.Equals("Anglais"))
                    {
                        result = MessageBox.Show("Do you really want to delete everything ?", "HistoryScan", MessageBoxButtons.YesNo);
                    }
                    else
                    {
                        result = MessageBox.Show("Voulez-vous vraiment tout supprimer ?", "HistoryScan", MessageBoxButtons.YesNo);*/
                    //}*/
                    if (lang.Equals("Anglais"))
                    {
                        MessagesShow to = new MessagesShow("Do you really want to delete everything ?", "oui", "History Scan");
                    }
                    else
                    {
                        MessagesShow to = new MessagesShow("Voulez-vous vraiment tout supprimer ?", "oui", "Historique de Scan");
                    }
                    var result = File.ReadAllText(MessageOK).ToString().Trim();

                    if (!result.ToString().Equals(""))
                    {
                        if (db1.deleteData(sourceFile, sql7) == true)
                        {
                            //AutoClosingMessageBox.Show("Successful deletion .");
                            if (lang.Equals("Anglais"))
                            {
                                MessagesShow to = new MessagesShow("Successful deletion ");
                            }
                            else
                            {
                                MessagesShow to = new MessagesShow("Virus détecté ");
                            }
                        }
                        else
                        {
                            if (lang.Equals("Anglais"))
                            {
                                MessagesShow to = new MessagesShow("Impossible to delete all this content ");
                            }
                            else
                            {
                                MessagesShow to = new MessagesShow("Suppression échoué ");
                            }
                            //MessageBox.Show(" .");
                        }
                        Historicsloading7();
                    }

                }
                else if (choix.Equals(""))
                {
                    int i1 = 0;

                    Int32 selectedCellCount1 = guna2DataGridView13.Rows.Count;
                    int taille = NewTailleTableau("HistoryScan");
                    /*DialogResult result;

                    if (lang.Equals("Anglais"))
                    {
                        result = MessageBox.Show("Do you want to restore this file?", "Quarantaine", MessageBoxButtons.YesNo);
                    }
                    else
                    {
                        result = MessageBox.Show("Voulez-vous restaurer ce fichier ?", "Quarantaine", MessageBoxButtons.YesNo);
                    }*/

                    if (lang.Equals("Anglais"))
                    {
                        MessagesShow to = new MessagesShow("Do you want to delete this file?", "oui", "History Scan");
                    }
                    else
                    {
                        MessagesShow to = new MessagesShow("Voulez-vous supprimer ce fichier?", "oui", "Historique de Scan");
                    }
                    var result = File.ReadAllText(MessageOK).ToString().Trim();

                    if (result.Equals("Oui") || result.Equals("Yes"))
                    {
                        if (taille > 0)
                        {
                            guna2DataGridView13.Visible = true;

                            if (guna2DataGridView13.CurrentRow != null)
                            {
                                int indice = guna2DataGridView13.CurrentCell.RowIndex;
                                i1 = indice + 1;
                                string date = (string)guna2DataGridView13[0, indice].Value;

                                string sql1 = "DELETE FROM HistoryScan where Id = '" + i1 + "';";

                                if (db1.deleteData(sourceFile, sql1) == true)
                                {
                                    //MessageBox.Show("Suppression réussite = "+i1);
                                    guna2DataGridView13.Rows.RemoveAt(indice);
                                }
                                else
                                {
                                    if (lang.Equals("Anglais"))
                                    {
                                        MessagesShow to = new MessagesShow("Delete Failed ", "", "History Scan");
                                    }
                                    else
                                    {
                                        MessagesShow to = new MessagesShow("Échec de la suppression ", "", "historique de Scan");
                                    }
                                }

                                // mise à jour de la table HistoryScan.
                                Historicsloading7();
                            }
                            else
                            {
                                if (lang.Equals("Anglais"))
                                {
                                    MessagesShow to = new MessagesShow("select a line to delete ", "");
                                }
                                else
                                {
                                    MessagesShow to = new MessagesShow("sélectionner une ligne à supprimer ", "");
                                }
                            }
                        }
                        else
                        {
                            guna2DataGridView13.Visible = false;
                            pictureBox1.Visible = true;
                            label93.Visible = true;

                            if (lang.Equals("Anglais"))
                            {
                                MessagesShow to = new MessagesShow("No line select ", "");
                            }
                            else
                            {
                                MessagesShow to = new MessagesShow("Aucune ligne séléctionnée ", "");
                            }
                        }
                    }
                    else
                    {
                        if (lang.Equals("Anglais"))
                        {
                            MessagesShow to = new MessagesShow("Deletion abandoned", "");
                        }
                        else
                        {
                            MessagesShow to = new MessagesShow("Suppression abandonnée ", "");
                        }
                    }

                }
            }

        }

        // Select all sur la table historique
        private void guna2Button31_Click(object sender, EventArgs e)
        {
            this.l = this.l + 1;
            int reste = this.l % 2;
            choix = "";
            if (reste == 0)
            {
                foreach (DataGridViewRow item in guna2DataGridView13.Rows)
                {
                    item.Selected = false;
                    item.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
            else
            {
                foreach (DataGridViewRow item in guna2DataGridView13.Rows)
                {
                    item.Selected = true;
                    item.DefaultCellStyle.ForeColor = Color.Aqua;
                }
                choix = SelectAll[1];
                // MessageBox.Show("je suis Selecte all dans l'historique : " + choix);
            }

        }
        // ici je cherche la derniere version de la base viral disponible
        public string Lire(string a)
        {
            string str = "";
            try
            {
                //MessageBox.Show("a = " + a);
                LoadJson();
                string version = File.ReadAllText(VersionBD_Viral).ToString().Trim();
                //MessageBox.Show("version = " + version);
                string toto = "";
                string tata = "";

                var val = a.Split('.');
                var val1 = version.Split('.');
                int i = 0;

                foreach (string r in val)
                {
                    toto = toto + r;
                    tata = tata + val1[i];
                    i++;
                }

                int valf = Int32.Parse(toto);
                int valf1 = Int32.Parse(tata);
                
                if (valf < valf1)
                {
                    str = "actif";                    
                }
                else
                {
                    str = "inactif";
                }

            }
            catch (Exception ex)
            {
                //MessagesShow uio = new MessagesShow(""+ex.Message);
            }

            this.checkViralBasis = str;

            return str;
        }
        public void TelechargerFileUrl()
        {            
            //MessageBox.Show("version Tel = " + btnUpdate);
            if (btnUpdate.Equals("Aucun") )
            {
                //MessageBox.Show("Aucune mise virale éffectué.");
                //MessagesShow tutu = new MessagesShow("Aucune mise virale éffectué.");
            }
            else
            {
                if (lang.Equals("Anglais"))
                {
                    MessagesShow to = new MessagesShow("Downloading updates in progress ");
                }
                else
                {
                    MessagesShow to = new MessagesShow("Telechargement des mises à jour encours ");
                }
                LoadJson();
                //TelechargerJson();


                string version = File.ReadAllText(VersionBD_Viral).ToString().Trim();
                //MessageBox.Show("Version = " + version.ToString());
                try
                {
                    using (WebClient client = new WebClient())
                    {
                        client.DownloadFile("https://keygen.drakashield.com/release/DrakaShieldViralDatabase." + version.ToString() + ".rar", BaseVirale);
                    }

                    Task task = Task.Delay(6000); // Crée une tâche asynchrone
                    task.Wait(); // Attendez la fin de la tâche (bloquant l'exécution)

                }
                catch (WebException ex)
                {
                    MessagesShow tutu = new MessagesShow(ex.Message, "");
                }
            }
            if (lang.Equals("Anglais"))
            {
                MessagesShow to = new MessagesShow("Download of updates completed ");
            }
            else
            {
                MessagesShow to = new MessagesShow("Téléchargement des mises à jour terminé ");
            }

        }      

        public void DecompresserZip()
        {
            //télécharger les fichiers en C#
            TelechargerFileUrl();
            //MessageBox.Show("Etape1");

            string zipPath = BaseVirale;
            string extractPath = BaseViralDezip;
           
            try
            {
                // Assurez-vous que le dossier d'extraction existe
                if (!Directory.Exists(extractPath))
                {
                    Directory.CreateDirectory(extractPath);
                }

                // Ouvrir l'archive .rar
                using (RarArchive archive = RarArchive.Open(zipPath))
                {
                    foreach (var entry in archive.Entries)
                    {
                        if (!entry.IsDirectory)
                        {
                            // Extraire chaque fichier dans le dossier d'extraction
                            entry.WriteToDirectory(extractPath, new ExtractionOptions()
                            {
                                ExtractFullPath = true,
                                Overwrite = true
                            });
                        }
                    }
                }
                //MessageBox.Show("Etape2");
                Console.WriteLine("Extraction terminée avec succès!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors de l'extraction de l'archive: {ex.Message}");
                //MessageBox.Show("Etape3 = "+ ex.Message);
            }         
        }

        // telecharger le fichoier Json
        static async Task TelechargerJson()
        {
            // URL du fichier JSON
            //string url = "https://example.com/data.json";
            //string apiUrl = "https://keygen.drakashield.com/api/release-virus-database";

            // Chemin où vous souhaitez sauvegarder le fichier localement
            //string filePath = "data.json";
            string filePath = targetPath + "\\Videos\\release-virus-database.json";
            
            // Remplacez par l'URL de la page que vous souhaitez télécharger
            string url = "https://keygen.drakashield.com/api/release-virus-database";

            /*using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Téléchargement du contenu de la page web
                    HttpResponseMessage response = await client.GetAsync(url);
                    //MessageBox.Show("Etape1 : contenue web telecharger");
                    response.EnsureSuccessStatusCode(); // Lance une exception si le code de statut HTTP est une erreur
                    
                    Task task = Task.Delay(5000); // Crée une tâche asynchrone
                    task.Wait(); // Attendez la fin de la tâche (bloquant l'exécution)
                    
                    //MessageBox.Show("telechargement termine");
                    string content = await response.Content.ReadAsStringAsync();

                    // Affiche le contenu téléchargé dans la console
                    Console.WriteLine(content);
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        writer.Write(content);
                    }
                    //MessageBox.Show("Contenu = \n\n"+content);

                }
                catch (HttpRequestException e)
                {
                    //MessageBox.Show("Exception = "+e.Message);
                    Console.WriteLine("Erreur lors du téléchargement de la page : " + e.Message);
                }
            }*/
            using (WebClient client = new WebClient())
            {
                client.DownloadFile(url, filePath);
            }
            Task task = Task.Delay(7000); // Crée une tâche asynchrone
            task.Wait(); // Attendez la fin de la tâche (bloquant l'exécution)

            //MessageBox.Show("Ici le telechargement est termine");

        }

        // methode pour verifier l'existance d'une mise a jour

        public void VerificationUpdate()
        {
            // telecharger le fichier .json

            string toto = "";
            string tata = "";

            TelechargerJson();
            
            Task task = Task.Delay(6000); // Crée une tâche asynchrone
            task.Wait(); // Attendez la fin de la tâche (bloquant l'exécution)

            // verifier et comparer les valeurs

            try
            {
                string json = File.ReadAllText(BaseViraleJson);
                string AncienneVersion = File.ReadAllText(VersionBD_Viral);
                LastTest liste = new LastTest();
                
                //Dictionary<string, object> json_Dictionary = (new JavaScriptSerializer()).Deserialize<Dictionary<string, object>>(json);
                MiseAJourViral json_Dictionary = (new JavaScriptSerializer()).Deserialize<MiseAJourViral>(json);
                ;
                // enrégistrement de la version de la base de donnée virale.
                //MessagesShow tutuy = new MessagesShow("latest = " + json_Dictionary.latest, "");
                if (json_Dictionary.latest == null)
                {
                    if (lang.Trim().Equals("Anglais"))
                    {
                        MessagesShow tutu = new MessagesShow("Checking for Updates...");
                    }
                    else
                    {
                        MessagesShow tutu = new MessagesShow("Vérification des Mises A jour...");
                    }
                }
                else
                {
                    //File.WriteAllText(VersionBD_Viral, json_Dictionary.latest.version);
                    string nouvelleVersion = json_Dictionary.latest.version;

                    // ici on doit verifier les mises a jour

                    var val = AncienneVersion.Split('.');
                    var val1 = nouvelleVersion.Split('.');
                    int i = 0;
                    
                    foreach (string r in val)
                    {
                        toto = toto + r;
                        tata = tata + val1[i];
                        i++;
                    }

                    int valf = Int32.Parse(toto);
                    int valf1 = Int32.Parse(tata);
                    
                    if (valf != valf1)   // valf > valf1
                    {
                        if (lang.Trim().Equals("Anglais"))
                        {
                            MessagesShow tutu = new MessagesShow("New updates are available", "");
                        }
                        else
                        {
                            MessagesShow tutu = new MessagesShow("De nouvelles mises à jour sont disponibles", "");
                        }
                        btnUpdate = "Plusieurs";
                    }
                    else
                    {
                        if (lang.Trim().Equals("Anglais"))
                        {
                            MessagesShow tutu = new MessagesShow("No updates found");
                        }
                        else
                        {
                            MessagesShow tutu = new MessagesShow("Aucune mise à jour trouvée");
                        }
                        btnUpdate = "Aucun";
                    }
                }               
                
                // puis nous allons éffacés le fichier .JSON telecharger
                File.Delete(BaseViraleJson);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("lang = " + lang);
                // Aucun fichier JSON disponible.
                btnUpdate = "Aucun";
                if (lang.Trim().Equals("Anglais"))
                {
                    MessagesShow tutu = new MessagesShow("No updates available. Check your internet connection.");
                }
                else
                {
                    MessagesShow tutu = new MessagesShow("Aucune mise à jour disponible. Vérifiez votre connexion internet.");
                }
            }
        }
        public void LoadJson()
        {
            // 1 - ici nous allons d'abord téléchargé le fichier .JSON
            try
            {
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile("https://keygen.drakashield.com/api/release-virus-database", BaseViraleJson);
                }
                Task task = Task.Delay(7000); // Crée une tâche asynchrone
                task.Wait(); // Attendez la fin de la tâche (bloquant l'exécution)

                if (lang.Trim().Equals("Anglais"))
                {
                    MessagesShow tutu = new MessagesShow("checking for updates");
                }
                else
                {
                    MessagesShow tutu = new MessagesShow("vérification des mises à jour");
                }
            }
            catch (WebException ex)
            {
                MessagesShow tutu = new MessagesShow(ex.Message);
            }

            // 2 - puis nous allons lire son contenue.  System.IO.FileNotFoundException : 

            try
            {
                string json = File.ReadAllText(BaseViraleJson);
                LastTest liste = new LastTest();

                //Dictionary<string, object> json_Dictionary = (new JavaScriptSerializer()).Deserialize<Dictionary<string, object>>(json);
                MiseAJourViral json_Dictionary = (new JavaScriptSerializer()).Deserialize<MiseAJourViral>(json);

                // enrégistrement de la version de la base de donnée virale.
                //MessagesShow tutuy = new MessagesShow("latest = " + json_Dictionary.latest, "");
                if (json_Dictionary.latest == null )
                {
                    if (lang.Trim().Equals("Anglais"))
                    {
                        MessagesShow tutu = new MessagesShow("Checking for Updates...");
                    }
                    else
                    {
                        MessagesShow tutu = new MessagesShow("Vérification des Mises A jour...");
                    }
                }
                else
                {
                    File.WriteAllText(VersionBD_Viral, json_Dictionary.latest.version);
                }
                
                // puis nous allons éffacés le fichier .JSON telecharger
                File.Delete(BaseViraleJson);
            }
            catch(Exception ex)
            {
                // Aucun fichier JSON disponible.
                //MessagesShow tutu = new MessagesShow(ex.Message);
            }
        }

        public void UpdateViralBasisFinal()
        {
            // Appeler la méthode pour décompresser le fichier zip
            
            DecompresserZip();
            
            // je combine le repertoire au fichier dézipé.  BaseViralDezip

            //BaseViralDezip = Path.Combine(Path.GetFileName(BaseVirale) + File.ReadAllText(VersionBD_Viral), "MD5Base.txt");
            string nomFichierTel = Path.GetFileName(BaseVirale) + File.ReadAllText(VersionBD_Viral) + ".txt";
            
            //BaseViralDezip = Path.GetFileName(BaseVirale) + File.ReadAllText(VersionBD_Viral) + ".txt";
            BaseViralDezip = Path.Combine(BaseViralDezip, nomFichierTel);
            UpdateChemin = nomFichierTel;           
            
            var liste1 = File.ReadAllLines(BaseViralDezip);
            //var liste2 = File.ReadAllLines(VirusBD2);

            File.AppendAllLines(VirusBD2, liste1);

            if (lang.Trim().Equals("Anglais"))
            {
                MessagesShow tutu = new MessagesShow("installing updates...");
            }
            else
            {
                MessagesShow tutu = new MessagesShow("installation de mises à jour...");
            }

            File.AppendAllLines(UpdateAutoScan, liste1);

            Task task = Task.Delay(6000); // Crée une tâche asynchrone
            task.Wait(); // Attendez la fin de la tâche (bloquant l'exécution)
            
            //if (liste1.Length > liste2.Length)
            //{
            //    try
            //    {
            //        //Pass the filepath and filename to the StreamWriter Constructor
            //        StreamWriter sw = new StreamWriter(VirusBD2);
            //        //Write a line of text
            //        foreach (string str in liste1)
            //        {
            //            sw.WriteLine(str);
            //        }
            //        sw.Close();
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine("Exception: " + e.Message);
            //    }        
            //    
            //}

            if (lang.Trim().Equals("Anglais"))
            {
                MessagesShow to = new MessagesShow("Virus database update Completed successfully ", "");
            }
            else
            {
                MessagesShow to = new MessagesShow("Mise à jour de la base virale Terminée avec succès ", "");
            }
            btnUpdate = "Aucun";
            File.Delete(BaseViralDezip);

        }
        public void VerifUpdate()
        {            
            if (Lire(a).Equals("actif"))
            {
                if (lang.Equals("Anglais"))
                {
                    MessagesShow pop = new MessagesShow("Updates are available, Click Update to update", "", "Viral update");
                }
                else
                {
                    MessagesShow pop = new MessagesShow("Des mises à jour sont disponibles, Cliquez sur Update pour faire la mise à jour ", "", "Mise à jour virale");
                }
                CodeCouleur = "KO";
            }
            else
            {
                CodeCouleur = "OK";
            }
        }
        // Doawlord file in server
        public string DaownloardServer(string variable1)
        {
            string toto = "";
           
            if (variable1.Equals("Automatique"))
            {
                // ici la mise à jour se déclenche Automatiquement.
                UpdateViralBasisFinal();
                toto = "true";
                btnUpdate = "Aucun";
            }
            else
            {
                // ici on demande la mise à jour pour la déclencher
                string ttr = "";
                //MessageBox.Show("checkViralBasis = " + checkViralBasis);
                if (btnUpdate.Equals("Plusieurs"))
                {
                    ttr = File.ReadAllText(MessageOK); // le repertoire
                    //MessageBox.Show("ttr = " + ttr);
                    if (ttr.Equals("Yes") || ttr.Equals("Oui"))
                    {
                        // on appel la méthode de mise à jour de la base virale
                        UpdateViralBasisFinal();
                        toto = "true";
                        btnUpdate = "Aucun";
                    }
                    else
                    {
                        toto = "false";
                        btnUpdate = "Plusieurs";

                        if (lang.Equals("Anglais"))
                        {
                            MessagesShow yop = new MessagesShow("You are using an obsolete version of the virus database");
                        }
                        else
                        {
                            MessagesShow yop = new MessagesShow("Vous utilisez une version obsolète de la base virale");
                        }
                    }

                }
                else
                {
                    //MessagesShow pop = new MessagesShow("Aucune mise à jour disponible", "");
                }
            }
            // je retourne
            //MessageBox.Show("" + toto);
            return (toto);
        }
        //******************************************************************************************************************************
        // End Histroy
        //******************************************************************************************************************************

        //******************************************************************************************************************************
        // Start Quarantine
        //******************************************************************************************************************************
        private void QuarantaineHistoricsloading()
        {
            //int indice = guna2DataGridView14.CurrentCell.RowIndex;
            RemplirQuarantaine();
            if (db1.CreateTable(sourceFile, "Quarantaine") == true)
            {
                //AutoClosingMessageBox.Show("quarantine table reset.");
                pictureBox2.Visible = true;
                label94.Visible = true;
                guna2DataGridView14.Visible = false;
            }
            else
            {
                pictureBox2.Visible = true;
                label94.Visible = true;
                guna2DataGridView14.Visible = false;

                string sql2 = "";
                int i1 = 1;

                try
                {
                    int LastRowID = NewTailleTableau("Quarantaine");

                    if (LastRowID > 0)
                    {
                        pictureBox2.Visible = false;
                        label94.Visible = false;
                        guna2DataGridView14.Rows.Clear();

                        while (i1 <= LastRowID)
                        {
                            sql2 = "select chemin, detection, date from Quarantaine where Id='" + i1 + "';";
                            Object[] dburl = db1.searchData(sourceFile, sql2);
                            if (dburl != null)
                            {
                                guna2DataGridView14.Rows.Add(dburl[0].ToString(), dburl[2].ToString(), dburl[1].ToString());
                            }

                            i1++;
                            guna2DataGridView14.Visible = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessagesShow to = new MessagesShow(ex.Message, "");
                }
            }
        }

        // Restore Element
        private void guna2Button34_Click(object sender, EventArgs e)
        {
            if (choix.Equals(SelectAll[0]))
            {
                int taille = NewTailleTableau("Quarantaine");

                for (int i = 1; i <= taille; i++)
                {
                    string sql = "SELECT nouveldirection FROM Quarantaine where Id = '" + i + "';";
                    int i1 = (i - 1);
                    try
                    {
                        Object[] dburl = db1.searchData(sourceFile, sql);
                        string chemin = (string)guna2DataGridView14[0, i1].Value;
                        if (File.Exists(dburl[0].ToString()))
                        {
                            FileSystem.MoveFile(dburl[0].ToString(), chemin, true);
                            //File.Move(dburl[0].ToString(), chemin);
                            if (lang.Equals("Anglais"))
                            {
                                MessagesShow yos = new MessagesShow("Successful restoration ");
                                //AutoClosingMessageBox.Show("Successful restoration ");
                            }
                            else
                            {
                                MessagesShow yos = new MessagesShow("Restauration réussie ");
                                //AutoClosingMessageBox.Show("Restauration réussie ");
                            }
                            // guna2DataGridView14.Rows.RemoveAt(indice);

                        }
                    }
                    catch (Exception ex)
                    {
                        MessagesShow yos = new MessagesShow("Erreur == " + ex.Message, "");
                        //MessageBox.Show("Erreur == " + ex.Message);
                    }
                }
                // on drop la table Quarantaine
                string sql7 = "DROP TABLE Quarantaine";
                if (db1.deleteData(sourceFile, sql7) == true)
                {
                    //AutoClosingMessageBox.Show("Quarantine Table Fully restored");
                    pictureBox2.Visible = true;
                    label94.Visible = true;
                    guna2DataGridView14.Visible = false;
                }
            }
            else
            {
                Int32 selectedCellCount1 = guna2DataGridView14.Rows.Count;
                //MessageBox.Show("Gooood = " + selectedCellCount1);
                int i1 = 0;
                if (guna2DataGridView14.CurrentRow != null)
                {
                    int indice = guna2DataGridView14.CurrentRow.Index;
                    string chemin = (string)guna2DataGridView14[0, indice].Value;
                    i1 = indice + 1;

                    string sql = "SELECT nouveldirection FROM Quarantaine where Id = '" + i1 + "';";
                    string sql1 = "DELETE FROM Quarantaine where Id = '" + i1 + "';";

                    Object[] dburl = db1.searchData(sourceFile, sql);

                    /* DialogResult result;

                     if (lang.Equals("Anglais"))
                     {
                         result = MessageBox.Show("Do you want to restore this file?", "Quarantaine", MessageBoxButtons.YesNo);
                     }
                     else
                     {
                         result = MessageBox.Show("Voulez-vous restaurer ce fichier ?", "Quarantaine", MessageBoxButtons.YesNo);
                     }*/

                    if (lang.Equals("Anglais"))
                    {
                        MessagesShow to = new MessagesShow("Do you want to restore this file ?", "oui", "Quarantaine");
                    }
                    else
                    {
                        MessagesShow to = new MessagesShow("Voulez - vous restaurer ce fichier ? ", "oui", "Quarantaine");
                    }
                    var result = File.ReadAllText(MessageOK).ToString().Trim();

                    if (result.Equals("Oui") || result.Equals("Yes") )
                    {
                        if (db1.deleteData(sourceFile, sql1) == true)
                        {
                            try
                            {
                                if (dburl != null)
                                {
                                    if (File.Exists(dburl[0].ToString()))
                                    {
                                        FileSystem.MoveFile(dburl[0].ToString(), chemin, true);
                                        //File.Move(dburl[0].ToString(), chemin);
                                        // mise à jour de la table Quarantaine.
                                        int x = i1 - 1;
                                        string sql8 = "UPDATE Quarantaine SET Id = (Id-1) where Id > '" + x + "';";

                                        if (db1.deleteData(sourceFile, sql8) == true)
                                        {                                            
                                            if (lang.Equals("Anglais"))
                                            {
                                                MessagesShow yos = new MessagesShow("Quarantine table successfully updated");
                                                //AutoClosingMessageBox.Show("Quarantine table successfully updated");
                                            }
                                            else
                                            {
                                                MessagesShow yos = new MessagesShow("Table de quarantaine mise à jour avec succès");
                                                //AutoClosingMessageBox.Show("Table de quarantaine mise à jour avec succès");
                                            }
                                            QuarantaineHistoricsloading();
                                        }
                                    }
                                    else
                                    {
                                        MessagesShow yos = new MessagesShow("File does not exist in quarantine ");
                                        //AutoClosingMessageBox.Show("File does not exist in quarantine ");
                                        guna2DataGridView14.Rows.RemoveAt(indice);
                                    }
                                }
                                else
                                {
                                    string sql7 = "DROP TABLE Quarantaine";
                                    if (db1.deleteData(sourceFile, sql7) == true)
                                    {
                                        //MessageBox.Show("Table Quarantaine creer");
                                    }
                                }

                            }
                            catch (Exception ex)
                            {
                                MessagesShow to = new MessagesShow("Exception  = " + ex.Message, "");
                            }
                        }
                        else
                        {
                            if (lang.Equals("Anglais"))
                            {
                                MessagesShow to = new MessagesShow("No line selected ", "");
                            }
                            else
                            {
                                MessagesShow to = new MessagesShow("Aucune ligne sélectionnée ", "");
                            }
                        }
                    }
                    else
                    {
                        if (lang.Equals("Anglais"))
                        {
                            MessagesShow to = new MessagesShow("You have chosen not to validate the quarantine of the file", "");
                        }
                        else
                        {
                            MessagesShow to = new MessagesShow("Vous avez choisi de ne pas valider la mise en quarantaine du fichier", "");
                        }
                    }

                }
                else if(guna2DataGridView14.CurrentRow == null)
                {
                    if (lang.Equals("Anglais"))
                    {
                        MessagesShow to = new MessagesShow("No line selected ", "");
                    }
                    else
                    {
                        MessagesShow to = new MessagesShow("Aucune Ligne Selectionnée ", "");
                    }
                    
                }
            }
        }
        // delete element quarantaine
        private void guna2Button33_Click(object sender, EventArgs e)
        {
            string root = @"C:\Program Files(x86)\Default Company Name\Setup1\Quarantaine\";

            if (choix.Equals(SelectAll[0]))
            {
                //string root = @"C:\Program Files(x86)\Default Company Name\Setup1\Quarantaine\";

                string sql7 = "DROP TABLE Quarantaine";

                /*DialogResult result;
                if (lang.Equals("Anglais"))
                {
                    result = MessageBox.Show("Do you all want to delete these files?", "Quarantaine", MessageBoxButtons.YesNo);
                }
                else
                {
                    result = MessageBox.Show("Voulez-vous tous supprimer ces fichiers ?", "Quarantaine", MessageBoxButtons.YesNo);
                }*/

                if (lang.Equals("Anglais"))
                {
                    MessagesShow to = new MessagesShow("Do you all want to delete these files?", "oui");
                }
                else
                {
                    MessagesShow to = new MessagesShow("Voulez-vous tous supprimer ces fichiers ?", "oui");
                }
                var result = File.ReadAllText(MessageOK).ToString().Trim();

                if (result.Equals("Oui") || result.Equals("Yes"))
                {
                    if (db1.deleteData(sourceFile, sql7) == true)
                    {
                        if (lang.Equals("Anglais"))
                        {
                            MessagesShow to = new MessagesShow("Delete success");
                            //AutoClosingMessageBox.Show("Delete success");
                        }
                        else
                        {
                            MessagesShow to = new MessagesShow("Suppression réussite");
                            //AutoClosingMessageBox.Show("Suppression réussite");
                        }
                        string[] files = Directory.GetFiles(root);
                        foreach (string file in files)
                        {
                            File.Delete(file);
                        }
                        pictureBox2.Visible = true;
                        label94.Visible = true;
                        guna2DataGridView14.Visible = false;
                    }
                }
                else
                {
                    if (lang.Equals("Anglais"))
                    {
                        MessagesShow to = new MessagesShow("Please choose a line to delete", "");
                    }
                    else
                    {
                        MessagesShow to = new MessagesShow("Veuillez choisir une ligne à supprimer", "");
                    }
                    QuarantaineHistoricsloading();
                }
            }
            else if (choix.Equals(""))
            {
                Int32 selectedCellCount1 = guna2DataGridView14.Rows.Count;

                if (selectedCellCount1 > 0)
                {
                    int taille = NewTailleTableau("Quarantaine");

                    //MessageBox.Show("Taille : " + taille);
                    int i1 = 0;

                    if (guna2DataGridView14.CurrentRow != null)
                    {
                        int indice = guna2DataGridView14.CurrentRow.Index;
                        string chemin = (string)guna2DataGridView14[0, indice].Value;
                        i1 = indice + 1;

                        string sql = "SELECT nouveldirection FROM Quarantaine where Id = '" + i1 + "';";
                        string sql1 = "DELETE FROM Quarantaine where Id = '" + i1 + "';";

                        /*DialogResult result;
                        if (lang.Equals("Anglais"))
                        {
                            result = MessageBox.Show("Do you want to delete this file?", "Quarantaine", MessageBoxButtons.YesNo);
                        }
                        else
                        {
                            result = MessageBox.Show("Voulez-vous supprimer ce fichier ?", "Quarantaine", MessageBoxButtons.YesNo);
                        }
                        if (result == DialogResult.Yes)*/
                        if (lang.Equals("Anglais"))
                        {
                            MessagesShow to = new MessagesShow("Do you want to delete this file?", "oui", "Quarantaine");
                        }
                        else
                        {
                            MessagesShow to = new MessagesShow("Voulez-vous supprimer ce fichier ?", "oui", "Quarantaine");
                        }
                        var result = File.ReadAllText(MessageOK).ToString().Trim();

                        if (result.Equals("Oui") || result.Equals("Yes"))
                        {
                            try
                            {
                                Object[] dburl = db1.searchData(sourceFile, sql);
                                if (db1.deleteData(sourceFile, sql1) == true)
                                {
                                    if (dburl != null)
                                    {
                                        if (File.Exists(dburl[0].ToString()))
                                        {
                                            File.Delete(dburl[0].ToString());
                                            if (lang.Equals("Anglais"))
                                            {
                                                MessagesShow to = new MessagesShow("Delete success ");
                                                //AutoClosingMessageBox.Show("Delete success ");
                                            }
                                            else
                                            {
                                                MessagesShow to = new MessagesShow("Suppression réussite ");
                                                //AutoClosingMessageBox.Show("Suppression réussite ");
                                            }
                                            guna2DataGridView14.Rows.RemoveAt(indice);

                                            // mise à jour de la table Quarantaine.
                                            int x = i1 - 1;
                                            string sql8 = "UPDATE Quarantaine SET Id = (Id-1) where Id > '" + x + "';";
                                            if (db1.deleteData(sourceFile, sql8) == true)
                                            {
                                                if (lang.Equals("Anglais"))
                                                {
                                                    MessagesShow to = new MessagesShow("Quarantine table successfully updated");
                                                    //AutoClosingMessageBox.Show("Quarantine table successfully updated");
                                                }
                                                else
                                                {
                                                    MessagesShow to = new MessagesShow("Table de quarantaine mise à jour avec succès");
                                                    //AutoClosingMessageBox.Show("Table de quarantaine mise à jour avec succès");
                                                }
                                                QuarantaineHistoricsloading();
                                            }
                                            else
                                            {
                                                if (lang.Equals("Anglais"))
                                                {
                                                    MessagesShow to = new MessagesShow("Update failed on quarantine table", "");
                                                }
                                                else
                                                {
                                                    MessagesShow to = new MessagesShow("La mise à jour a échoué sur la table de quarantaine", "");
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                MessagesShow toi = new MessagesShow(ex.Message, "");
                            }

                        }
                        else
                        {
                            if (lang.Equals("Anglais"))
                            {
                                MessagesShow to = new MessagesShow("You have chosen not to continue deleting", "");
                            }
                            else
                            {
                                MessagesShow to = new MessagesShow("Vous avez choisi de ne pas poursuivre la suppression", "");
                            }
                            QuarantaineHistoricsloading();
                        }

                    }
                    else if(guna2DataGridView14.CurrentRow == null)
                    {
                        if (lang.Equals("Anglais"))
                        {
                            MessagesShow to = new MessagesShow("No line selected", "");
                        }
                        else
                        {
                            MessagesShow to = new MessagesShow("Aucune Ligne séléctionnée", "");
                        }
                    }
                }
                else
                {
                    pictureBox2.Visible = true;
                    label94.Visible = true;
                    guna2DataGridView14.Visible = false;

                    if (lang.Equals("Anglais"))
                    {
                        MessagesShow to = new MessagesShow("No line selected", "");
                    }
                    else
                    {
                        MessagesShow to = new MessagesShow("Aucune Ligne séléctionnée", "");
                    }
                }
            }
        }

        // Report As safe 
        private void guna2Button35_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Jes suis le bouton report as safe");

            if (guna2DataGridView14.CurrentRow == null)
            {
                if (lang.Equals("Anglais"))
                {
                    MessagesShow to = new MessagesShow("No Line selected ", "");
                }
                else
                {
                    MessagesShow to = new MessagesShow("Aucune ligne sélectionnée ", "");
                }
            }
            else
            {
                if (db1.CreateTable(sourceFile, "Chiarita") == true)
                {
                    //MessageBox.Show("la table chiarita a été créer ");
                    pictureBox2.Visible = true;
                    label94.Visible = true;
                    guna2DataGridView14.Visible = false;
                }
                else
                {
                    if (choix.Equals(SelectAll[0]))
                    {
                        //MessageBox.Show("Je suis Choix : " + choix);

                        // report as safe all
                        int taille = NewTailleTableau("Quarantaine");
                        //MessageBox.Show("ici on doit tous report as safe = " + taille);

                        DateTime Date = DateTime.Now;
                        Date.ToString("dd/MM/yyyy HH:mm:ss");

                        Int32 select11 = guna2DataGridView14.Rows.Count;

                        List<string> SignatureV = new List<string>();
                        List<string> CheminV = new List<string>();
                        List<string> Autre = new List<string>();
                        List<string> AutreBD = new List<string>();
                        List<string> DetectionV = new List<string>();

                        int i1 = 0;
                        var md5signatures = File.ReadAllLines(VirusBD);

                        /*DialogResult result;
                        if (lang.Equals("Anglais"))
                        {
                            result = MessageBox.Show("Do you want to Restore this file ?", "Quarantaine", MessageBoxButtons.YesNo);
                        }
                        else
                        {
                            result = MessageBox.Show("Voulez-vous restaurer ce fichier ?", "Quarantaine", MessageBoxButtons.YesNo);
                        }
                        if (result == DialogResult.Yes)*/
                        if (lang.Equals("Anglais"))
                        {
                            MessagesShow to = new MessagesShow("Do you want to make this file safe ?", "oui");
                        }
                        else
                        {
                            MessagesShow to = new MessagesShow("Voulez-vous rendre sûr ce fichier ?", "oui");
                        }
                        var result = File.ReadAllText(MessageOK).ToString().Trim();

                        if (result.Equals("Oui") || result.Equals("Yes"))
                        {
                            // récupérons les signatures du dataGrid
                            foreach (string item in md5signatures)
                            {
                                Autre.Add(item.Trim());
                            }
                            //MessageBox.Show("Etape1 terminé");

                            for (int i = 0; i < taille; i++)
                            {
                                /*if (i > 4)
                                {
                                    break;
                                }*/
                                string detection = (string)guna2DataGridView14[2, i].Value;
                                // MessageBox.Show("oooooooooo : " + detection.ToString());
                                var dt = detection.Split(new string[] { "->" }, StringSplitOptions.None);
                                string chemin = (string)guna2DataGridView14[0, i].Value;

                                SignatureV.Add(dt[1].Trim());
                                //MessageBox.Show("Virus : " + dt[1]);
                                Autre.Add(dt[1].Trim());
                                CheminV.Add(chemin);
                                DetectionV.Add(detection);

                            }
                            //MessageBox.Show("Etape2 terminé");
                            foreach (string signature in SignatureV)
                            {
                                if (Autre.Contains(signature))
                                {
                                    //MessageBox.Show("En fin je réussi ");
                                    Autre.Remove(signature);
                                    //continue;
                                }

                            }
                            File.WriteAllLines(VirusBD, Autre);

                            string root = @"C:\Program Files(x86)\Default Company Name\Setup1\Quarantaine\";

                            string sql7 = "DROP TABLE Quarantaine";

                            if (db1.deleteData(sourceFile, sql7) == true)
                            {
                                int i = 0;
                                foreach (string item in CheminV)
                                {
                                    string sql10 = "INSERT INTO Chiarita (chemin, date, nomfichier)values(";
                                    sql10 = sql10 + "'" + item + "', ";
                                    sql10 = sql10 + "'" + Date + "', ";
                                    sql10 = sql10 + "'" + DetectionV[i] + "')";

                                    i++;

                                    try
                                    {
                                        Boolean error = db1.insertData(sourceFile, sql10);

                                        if (error == true)
                                        {
                                            Console.WriteLine("Good Scan");
                                            if (lang.Equals("Anglais"))
                                            {
                                                MessagesShow yes = new MessagesShow("Repport as safe are succesfully ");
                                                //AutoClosingMessageBox.Show("Repport as safe are succesfully ");
                                            }
                                            else
                                            {
                                                MessagesShow yes = new MessagesShow("Fichier sûr sauvegardé ");
                                                //AutoClosingMessageBox.Show("Signaler comme sûr sont réussis ");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Bad no complete scan");
                                            //MessageBox.Show("Repport as safe are bad ");
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        MessagesShow yes = new MessagesShow("EXCEPTION : " + ex.Message);
                                        //AutoClosingMessageBox.Show("EXCEPTION : " + ex.Message);
                                    }
                                }

                                if (lang.Equals("Anglais"))
                                {
                                    MessagesShow yes = new MessagesShow("Report As Safe success");
                                    //AutoClosingMessageBox.Show("Report As Safe success");
                                }
                                else
                                {
                                    MessagesShow yes = new MessagesShow("Fichier rendu sûr");
                                    //AutoClosingMessageBox.Show("Signaler comme sûr succès");
                                }
                                string[] files = Directory.GetFiles(root);
                                foreach (string file in files)
                                {
                                    File.Delete(file);
                                }
                            }
                            pictureBox2.Visible = true;
                            label94.Visible = true;
                            guna2DataGridView14.Visible = false;
                        }
                        else
                        {
                            if (lang.Equals("Anglais"))
                            {
                                MessagesShow to = new MessagesShow("You don't want to delete all files from Quarantine", "");
                            }
                            else
                            {
                                MessagesShow to = new MessagesShow("Vous ne voulez pas supprimer tous les fichiers de la quarantaine", "");
                            }
                        }

                    }
                    else
                    {
                        int i1 = 0;
                        // MessageBox.Show("Je suis le contraire de choix ");

                        if (guna2DataGridView14.CurrentRow != null)
                        {
                            int indice = guna2DataGridView14.CurrentRow.Index;
                            string detection = (string)guna2DataGridView14[2, indice].Value;
                            string chemin = (string)guna2DataGridView14[0, indice].Value;
                            i1 = indice + 1;

                            var chaine1 = detection.Split(new string[] { "->" }, StringSplitOptions.None);
                            List<string> AutreBD = new List<string>();

                            var md5signatures = File.ReadAllLines(VirusBD);
                            string signature = chaine1[1].Trim();

                            //recherche de la signature virale

                            foreach (string s in md5signatures)
                            {
                                AutreBD.Add(s);
                            }
                            //MessageBox.Show("Etape1 réussite ");

                            if (AutreBD.Contains(signature))
                            {
                                AutreBD.Remove(signature);
                                //MessageBox.Show("voilà c'est bon ");
                            }

                            File.WriteAllLines(VirusBD, AutreBD);
                            // Process P3 = Process.Start(VirusBD);

                            // 1- je restore le fichier nouvelle direction

                            string sql5 = "SELECT nouveldirection FROM Quarantaine where Id = '" + i1 + "';";

                            /*DialogResult result;
                            if (lang.Equals("Anglais"))
                            {
                                result = MessageBox.Show("Do you want to Restore this file ?", "Quarantaine", MessageBoxButtons.YesNo);
                            }
                            else
                            {
                                result = MessageBox.Show("Voulez-vous restaurer ce fichier ?", "Quarantaine", MessageBoxButtons.YesNo);
                            }
                            if (result == DialogResult.Yes)*/
                            if (lang.Equals("Anglais"))
                            {
                                MessagesShow to = new MessagesShow("Do you want to make this file safe ?", "oui", "Quarantaine");
                            }
                            else
                            {
                                MessagesShow to = new MessagesShow("Voulez-vous render sûr ce fichier ?", "oui", "Quarantaine");
                            }
                            var result = File.ReadAllText(MessageOK).ToString().Trim();
                            //MessageBox.Show("YO = " + result);
                            if (result.Equals("Oui") || result.Equals("Yes"))
                            {
                                try
                                {
                                    Object[] dburl5 = db1.searchData(sourceFile, sql5);

                                    DateTime Date = DateTime.Now;
                                    Date.ToString("dd/MM/yyyy HH:mm:ss");

                                    if (dburl5 != null)
                                    {
                                        if (File.Exists(dburl5[0].ToString()))
                                        {
                                            string sql10 = "INSERT INTO Chiarita (chemin, date, nomfichier)values(";
                                            sql10 = sql10 + "'" + chemin + "', ";
                                            sql10 = sql10 + "'" + Date + "', ";
                                            sql10 = sql10 + "'" + detection + "')";
                                            // );
                                            try
                                            {
                                                Boolean error = db1.insertData(sourceFile, sql10);
                                                if (error == true)
                                                {
                                                    Console.WriteLine("Good Scan");
                                                    if (lang.Equals("Anglais"))
                                                    {
                                                        MessagesShow to = new MessagesShow("Repport as safe are succesfully ");
                                                        //AutoClosingMessageBox.Show("Repport as safe are succesfully ");
                                                        FileSystem.MoveFile(dburl5[0].ToString(), chemin, true);
                                                        //File.Move(dburl5[0].ToString(), chemin);
                                                        MessagesShow toà = new MessagesShow("Files As Safe ");
                                                    }
                                                    else
                                                    {
                                                        MessagesShow to = new MessagesShow("Fichier rendu sûr ");
                                                        //AutoClosingMessageBox.Show("Repport as safe are succesfully ");
                                                        FileSystem.MoveFile(dburl5[0].ToString(), chemin, true);
                                                        //File.Move(dburl5[0].ToString(), chemin);
                                                        MessagesShow toà = new MessagesShow("Fichier Sauvegardé ");
                                                    }
                                                    //AutoClosingMessageBox.Show("Files As Safe ");

                                                    guna2DataGridView14.Rows.RemoveAt(indice);
                                                    // supprimer le fichier de la table quarantaine
                                                    string sql1 = "DELETE FROM Quarantaine where Id = '" + i1 + "';";

                                                    if (db1.deleteData(sourceFile, sql1) == true)
                                                    {

                                                    }
                                                    // 3- je met la table quarantaine à jour
                                                    QuarantaineHistoricsloading();

                                                }
                                                //Boolean error = db1.insertData(sourceFile, sql10);
                                            }
                                            catch (Exception ex)
                                            {
                                                MessagesShow toà = new MessagesShow(ex.Message);
                                                //MessageBox.Show(ex.Message);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        string sql7 = "DROP TABLE Quarantaine";
                                        if (db1.deleteData(sourceFile, sql7) == true)
                                        {
                                            //MessageBox.Show("Table Quarantaine creer");
                                        }
                                    }

                                }
                                catch (Exception ex)
                                {
                                    // MessageBox.Show("OK");
                                }
                            }
                            else
                            {
                                if (lang.Equals("Anglais"))
                                {
                                    MessagesShow to = new MessagesShow("You do not assert trust in this file", "");
                                }
                                else
                                {
                                    MessagesShow to = new MessagesShow("Vous ne faites pas confiance à ce fichier", "");
                                }

                            }
                        }
                        else
                        {
                            if (lang.Equals("Anglais"))
                            {
                                MessagesShow to = new MessagesShow("No Line selected ", "");
                            }
                            else
                            {
                                MessagesShow to = new MessagesShow("Aucune ligne sélectionnée ", "");
                            }
                        }
                    }
                }
            }

        }

        // Management Safe

        private void guna2Button53_Click(object sender, EventArgs e)
        {
            // ici nous somme dans le management Safe
            //MessageBox.Show("Le bouton Management safe a vu le jour");
            pagesView.SelectTab("ManageSafe");
            LoadManageSafe();
        }
        private void guna2Button54_Click(object sender, EventArgs e)
        {
            // ici nous somme dans le management Safe
            MessageBox.Show("Le bouton Management safe a vu le jour");
            //guna2DataGridView14.Visible = true;
            //pagesView.SelectTab("ManageSafe");
            MessageBox.Show("Le bouton Management safe a vu le jour");
        }
        // cette méthode retourne la taille du taleau
        private int TailleTable(string nomtable)
        {
            string sql4 = "SELECT MAX(Id) FROM '" + nomtable + "';";
            int dex = 0;
            try
            {
                Object[] dburl1 = db1.searchData(sourceFile, sql4);
                if (dburl1 != null)
                {
                    dex = Int32.Parse(dburl1[0].ToString());
                    //MessageBox.Show("La taille du tableau est  = " + dex);
                }
                else
                {
                    //MessageBox.Show("Echec Mise à jour d'Index ");
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Exception : " + ex.Message);
            }
            return dex;
        }
        // pour le source files3
        private int TailleTable3(string nomtable)
        {
            string sql44 = "SELECT MAX(Id) FROM '" + nomtable + "';";
            int dex = 0;
            try
            {
                Object[] dburl1 = db1.searchData(sourceFile3, sql44);
                if (dburl1 != null)
                {
                    dex = Int32.Parse(dburl1[0].ToString());
                    //MessageBox.Show("La taille du tableau est  = " + dex);
                }
                else
                {
                    //MessageBox.Show("Echec Mise à jour d'Index ");
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Exception : " + ex.Message);
            }
            string sql = "SELECT * FROM websites where Id = '" + (dex-1) + "'; ";
            try
            {
                Object[] dburl = db1.searchData(sourceFile3, sql);
                string val = dburl[2].ToString();
                //MessageBox.Show("Val = " + val);

            }catch(Exception ex)
            {
                //MessageBox.Show("TOTO = "+ex.Message);
            }
            return 0;
        }
        // Button supprimer du Management Safe
        private void guna2Button55_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView30.CurrentRow == null)
            {
                if (lang.Equals("Anglais"))
                {
                    MessagesShow to = new MessagesShow("No ligne selected", "");
                }
                else
                {
                    MessagesShow to = new MessagesShow("Aucune ligne séléctionnée", "");
                }
            }
            else
            {
                if (choix.Equals(SelectAll[2]))
                {
                    // ici on va faire une action globale
                    int taille = NewTailleTableau("Chiarita");
                    List<string> AutreBD = new List<string>();
                    /*DialogResult result;
                    if (lang.Equals("Anglais"))
                    {
                        result = MessageBox.Show("Do you want to delete this file ?", "ManageSafe", MessageBoxButtons.YesNo);
                    }
                    else
                    {
                        result = MessageBox.Show("Voulez-vous supprimer ce fichier ?", "ManageSafe", MessageBoxButtons.YesNo);
                    }
                    if (result == DialogResult.Yes)*/
                    if (lang.Equals("Anglais"))
                    {
                        MessagesShow to = new MessagesShow("Do you want to delete this file ?", "oui");
                    }
                    else
                    {
                        MessagesShow to = new MessagesShow("Voulez-vous supprimer ce fichier ?", "oui");
                    }
                    var result = File.ReadAllText(MessageOK).ToString().Trim();

                    if (result.Equals("Oui") || result.Equals("Yes"))
                    {
                        for (int i = 1; i <= taille; i++)
                        {
                            string sql = "SELECT nomfichier FROM Chiarita where Id = '" + i + "';";
                            string sql1 = "DELETE FROM Chiarita where Id = '" + i + "';";

                            try
                            {
                                Object[] dburl = db1.searchData(sourceFile, sql);

                                var tab = dburl[0].ToString().Split(new string[] { "->" }, StringSplitOptions.None);
                                string signature = tab[1].Trim();
                                int indice = (i - 1);
                                string chemin = (string)guna2DataGridView30[0, indice].Value;

                                AutreBD.Add(signature);
                                File.Delete(chemin);
                                if (lang.Equals("Anglais"))
                                {
                                    MessagesShow toà = new MessagesShow("Delete success ");
                                    //AutoClosingMessageBox.Show("Delete success ");
                                }
                                else
                                {
                                    MessagesShow toà = new MessagesShow("Suppression réussite ");
                                    //AutoClosingMessageBox.Show("Suppression réussite ");
                                }
                                //guna2DataGridView30.Rows.RemoveAt(indice);
                            }
                            catch (Exception ex)
                            {
                                MessagesShow toà = new MessagesShow("Exception : " + ex.Message);
                                //AutoClosingMessageBox.Show("Exception : " + ex.Message);
                                File.AppendAllLines(VirusBD, AutreBD);
                            }
                        }

                        File.AppendAllLines(VirusBD, AutreBD);
                        choix = "";
                        //***************************************
                        string sql70 = "DROP TABLE Chiarita";
                        if (db1.deleteData(sourceFile, sql70) == true)
                        {
                            //MessageBox.Show("Table Chiarita creer");
                            pictureBox55.Visible = true;
                            label150.Visible = true;
                            guna2DataGridView30.Visible = false;
                        }
                    }
                    else
                    {
                        if (lang.Equals("Anglais"))
                        {
                            MessagesShow to = new MessagesShow("You have chosen to keep all these files as safe", "");
                        }
                        else
                        {
                            MessagesShow to = new MessagesShow("Vous avez choisi de garder tous ces fichiers en sécurité", "");
                        }

                    }

                }
                else
                {
                    // ici on va faire une actigne par ligne
                    int taille = NewTailleTableau("Chiarita");
                    int i = 0;
                    int i1 = 0;

                    if (taille > 0)
                    {
                        if (guna2DataGridView30.CurrentRow != null)
                        {
                            int indice = guna2DataGridView30.CurrentRow.Index;
                            i1 = indice + 1;
                            string chemin = (string)guna2DataGridView30[0, indice].Value;
                            i1 = indice + 1;

                            string sql = "SELECT nomfichier FROM Chiarita where Id = '" + i1 + "';";
                            string sql1 = "DELETE FROM Chiarita where Id = '" + i1 + "';";

                            try
                            {
                                Object[] dburl = db1.searchData(sourceFile, sql);

                                /*DialogResult result;
                                result = MessageBox.Show("Do you want to delete this file ?", "ManageSafe", MessageBoxButtons.YesNo);*/
                                if (lang.Equals("Anglais"))
                                {
                                    MessagesShow to = new MessagesShow("Do you want to delete this file ?", "oui");
                                }
                                else
                                {
                                    MessagesShow to = new MessagesShow("Voulez-vous supprimé ce fichier ?", "oui");
                                }
                                var result = File.ReadAllText(MessageOK).ToString().Trim();

                                if (result.Equals("Oui") || result.Equals("Yes"))
                                {
                                    if (db1.deleteData(sourceFile, sql1) == true)
                                    {
                                        var tab = dburl[0].ToString().Split(new string[] { "->" }, StringSplitOptions.None);
                                        string signature = tab[1].Trim();
                                        //MessageBox.Show("suppression réussite : " + signature);
                                        if (dburl != null)
                                        {
                                            if (File.Exists(chemin))
                                            {
                                                //MessageBox.Show("fichier existe");
                                                List<string> AutreBD = new List<string>();
                                                var md5signatures = File.ReadAllLines(VirusBD);

                                                foreach (string s in md5signatures)
                                                {
                                                    AutreBD.Add(s);
                                                }
                                                AutreBD.Add(signature);
                                                //MessageBox.Show("ici tu as = " + signature);

                                                File.WriteAllLines(VirusBD, AutreBD);

                                                //suppression du fichier de l'ordinateur.

                                                File.Delete(chemin);
                                                if (lang.Equals("Anglais"))
                                                {
                                                    MessagesShow top = new MessagesShow("Delete success ");
                                                    //AutoClosingMessageBox.Show("Delete success ");
                                                }
                                                else
                                                {
                                                    MessagesShow top = new MessagesShow("Suppression réussite ");
                                                    //AutoClosingMessageBox.Show("Suppression réussite ");
                                                }
                                                //guna2DataGridView30.Rows.RemoveAt(indice);

                                                // mise à jour de la table Quarantaine.
                                                LoadManageSafe();
                                            }
                                            else
                                            {
                                                if (lang.Equals("Anglais"))
                                                {
                                                    MessagesShow to = new MessagesShow("The file no longer exists on this computer", "");
                                                }
                                                else
                                                {
                                                    MessagesShow to = new MessagesShow("Le fichier n'existe plus sur cet ordinateur", "");
                                                }
                                                LoadManageSafe();
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    if (lang.Equals("Anglais"))
                                    {
                                        MessagesShow to = new MessagesShow("You still consider this file safe", "");
                                    }
                                    else
                                    {
                                        MessagesShow to = new MessagesShow("Vous considérez toujours ce fichier comme sûr", "");
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                MessagesShow to = new MessagesShow(ex.Message, "");
                            }
                        }
                    }
                    else
                    {
                        choix = "";
                        //***************************************
                        string sql70 = "DROP TABLE Chiarita";
                        if (db1.deleteData(sourceFile, sql70) == true)
                        {
                            //MessageBox.Show("Table Chiarita creer");
                            pictureBox55.Visible = true;
                            label150.Visible = true;
                            guna2DataGridView30.Visible = false;
                        }
                    }
                }
            }
        }

        // ici je vais faire l'update d'une table
        public int UpdateTable(string nomtable)
        {
            int LastRowID = TailleTable(nomtable);


            for (int i = 1; i <= TailleTable(nomtable); i++)
            {
                string sql = "SELECT *FROM '" + nomtable + "' WHERE Id = '" + i + "';";
                string sql1 = "DROP TABLE '" + nomtable + "';";
                string sql2 = "DELETE FROM Quarantaine where Id = '" + i + "';";

                Object[] dburl1 = db1.searchData(sourceFile, sql);
                if (dburl1 != null)
                {
                    //MessageBox.Show("Valeur Existante");
                    LastRowID = LastRowID + 0;
                }
                else
                {
                    //MessageBox.Show("La valeur n'existe pas");
                    if (db1.deleteData(sourceFile, sql2) == true)
                    {
                        //MessageBox.Show("voilà c'est bon la valeur est là");
                        int x = i - 1;
                        string sql8 = "UPDATE '" + nomtable + "' SET Id = (Id-1) where Id > '" + x + "';";
                        if (db1.deleteData(sourceFile, sql8) == true)
                        {
                            // MessageBox.Show("Table mise à jour");                            
                        }
                    }
                    else
                    {
                        //MessageBox.Show("delete failling");
                        LastRowID = TailleTable(nomtable);
                    }
                }
                string sql9 = "SELECT MAX(Id) FROM '" + nomtable + "';";

                Object[] dburl9 = db1.searchData(sourceFile, sql9);

                string str = dburl9[0].ToString();
                int LastRowID1 = Int32.Parse(str);
                LastRowID = LastRowID1;
            }

            //MessageBox.Show("nouvelle taille tableau : " + LastRowID);
            return (LastRowID);
        }
        // nouvelle taille de tableau mise à jour        
        public int NewTailleTableau(string nomtable)
        {
            int ot = 0;
            try
            {
                int taille = TailleTable(nomtable);
                int newTaille = UpdateTable(nomtable);
                ot = newTaille;
            }
            catch(Exception ex)
            {
               // MessageBox.Show("Totototototot." + ex.Message);
            }
            return ot;
        }
        // select all pour le Management safe
        private void guna2Button56_Click(object sender, EventArgs e)
        {
            this.ll = this.ll + 1;
            int reste = this.ll % 2;
            choix = "";
            if (reste == 0)
            {
                foreach (DataGridViewRow item in guna2DataGridView30.Rows)
                {
                    item.Selected = false;
                    item.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
            else
            {
                foreach (DataGridViewRow item in guna2DataGridView30.Rows)
                {
                    item.Selected = true;
                    item.DefaultCellStyle.ForeColor = Color.Aqua;
                }
                choix = SelectAll[2];
                //MessageBox.Show("je suis Selecte all dans le Manage Safe : " + choix);
            }
        }

        // charger la tale management safe

        private void LoadManageSafe()
        {
            // vérifier que la tale quarantaine existe

            if (File.Exists(sourceFile))
            {
                Boolean verif = db1.CreateTable(sourceFile, "Chiarita");
                if (verif == true)
                {
                    pictureBox55.Visible = true;
                    label150.Visible = true;
                    guna2DataGridView30.Visible = false;
                    //selectedCellCount1 = 0;
                }
                else
                {
                    string sql2 = "";
                    int i1 = 1;
                    string signature = "";
                    //selectedCellCount1 = guna2DataGridView13.Rows.Count;
                    //MessageBox.Show("taille : ");
                    pictureBox55.Visible = true;
                    label150.Visible = true;
                    guna2DataGridView30.Visible = false;

                    try
                    {
                        int LastRowID = NewTailleTableau("Chiarita");

                        //MessageBox.Show("taille : " + LastRowID);
                        LastRowID = UpdateTable("Chiarita");
                        if (LastRowID > 0)
                        {
                            guna2DataGridView30.Rows.Clear();

                            while (i1 <= LastRowID)
                            {
                                sql2 = "select chemin, date, nomfichier from Chiarita where Id='" + i1 + "';";

                                try
                                {
                                    Object[] dburl = db1.searchData(sourceFile, sql2);
                                    /*List<Object[]> datas = db1.selectDatasAuto(sourceFile1, sql2);
                                    if (datas != null)
                                    {
                                        for (var i = 0; i < datas.Count; i++)
                                        {
                                            guna2DataGridView30.Rows.Add(datas[i]);
                                        }
                                    }
                                    else
                                    {
                                        AutoClosingMessageBox.Show("Fatal Error, reboot the application");

                                    }*/
                                    //MessageBox.Show("tttttttttttttttttttt");
                                    if (dburl != null)
                                    {
                                        var nomfichier = dburl[2].ToString().Split(new string[] { "->" }, StringSplitOptions.None);
                                        signature = nomfichier[1];

                                        guna2DataGridView30.Rows.Add(dburl[0].ToString(), dburl[1].ToString(), nomfichier[0]);

                                    }
                                    else
                                    {                                        
                                        if (lang.Equals("Anglais"))
                                        {
                                            MessagesShow top = new MessagesShow("Fatal Error, reboot the application");
                                            //AutoClosingMessageBox.Show("Fatal Error, reboot the application");
                                        }
                                        else
                                        {
                                            MessagesShow top = new MessagesShow("Erreur fatale, redémarrez l'application");
                                            //AutoClosingMessageBox.Show("Erreur fatale, redémarrez l'application");
                                        }
                                    }

                                    i1++;
                                    guna2DataGridView30.Visible = true;
                                    pictureBox55.Visible = false;
                                    label150.Visible = false;

                                }
                                catch (Exception ex)
                                {
                                    //MessageBox.Show("yyyyyyyy"+ex.Message);
                                }
                                //MessageBox.Show("ooooooooooooooooo : " + i1);

                            }
                        }
                        else
                        {
                            //AutoClosingMessageBox.Show("Manage Safe table is empty");
                            pictureBox55.Visible = true;
                            label150.Visible = true;
                            guna2DataGridView30.Visible = false;
                        }

                    }
                    catch (Exception ex)
                    {
                        if (!File.Exists(path))
                        {
                            File.Create(path);
                            TextWriter tw = new StreamWriter(path, true);
                            tw.WriteLine(DateTime.Now.ToString() + " " + "Request:" + " " + sql2 + " " + "Error_Message:" + ex);
                            tw.Close();
                        }

                        else if (File.Exists(path))
                        {
                            TextWriter tw = new StreamWriter(path, true);
                            tw.WriteLine(DateTime.Now.ToString() + " " + "Request:" + " " + sql2 + " " + "Error_Message:" + ex);
                            tw.Close();
                        }
                    }
                }
            }
            else
            {
                //AutoClosingMessageBox.Show("Manage Safe table is empty");
                pictureBox55.Visible = true;
                label150.Visible = true;
                guna2DataGridView30.Visible = false;
            }

        }
        // Select All pour la table quarantaine
        private void guna2Button32_Click(object sender, EventArgs e)
        {
            this.ll = this.ll + 1;
            int reste = this.ll % 2;
            choix = "";
            if (reste == 0)
            {
                foreach (DataGridViewRow item in guna2DataGridView14.Rows)
                {
                    item.Selected = false;
                    item.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
            else
            {
                foreach (DataGridViewRow item in guna2DataGridView14.Rows)
                {
                    item.Selected = true;
                    item.DefaultCellStyle.ForeColor = Color.Aqua;
                }
                choix = SelectAll[0];
                //MessageBox.Show("je suis Selecte all dans la quarantaine : " + choix);
            }
        }
        //******************************************************************************************************************************
        // End Quarantine
        //******************************************************************************************************************************

        //******************************************************************************************************************************
        // Start Security
        //******************************************************************************************************************************
        private void loadFirewall()
        {
            try
            {
                ManagementObjectSearcher wmiData = new ManagementObjectSearcher(@"root\SecurityCenter2", "SELECT * FROM AntiVirusProduct");
                ManagementObjectCollection data = wmiData.Get();
                ManagementObject firewall = data.OfType<ManagementObject>().First();
                labelFirewallName.Text = firewall["displayName"].ToString();
                String state = firewall["productState"].ToString();
                switch (state)
                {
                    case "397568": //Windows defender
                        labelFirewallSignature.Text = "Up to date";
                        labelFirewallStatut.Text = "True";
                        break;
                    case "397584"://Windows defender
                        labelFirewallSignature.Text = "Out to date";
                        labelFirewallStatut.Text = "True";
                        break;
                    case "393472"://Windows defender
                        labelFirewallSignature.Text = "Up to date";
                        labelFirewallStatut.Text = "False";
                        break;
                    case "397312"://Microsoft security essentials
                        labelFirewallSignature.Text = "Up to date";
                        labelFirewallStatut.Text = "True";
                        break;
                    case "393216"://Microsoft security essentials
                        labelFirewallSignature.Text = "Up to date";
                        labelFirewallStatut.Text = "False";
                        break;
                    case "266256"://AVG Internet Security 2012 firewall product
                        labelFirewallSignature.Text = "Firewall";
                        labelFirewallStatut.Text = "True";
                        break;
                    case "262160"://AVG Internet Security 2012 firewall product
                        labelFirewallSignature.Text = "Firewall";
                        labelFirewallStatut.Text = "False";
                        break;
                    case "262144"://AVG Internet Security 2012 antivirus product
                        labelFirewallSignature.Text = "Up to date";
                        labelFirewallStatut.Text = "False";
                        break;
                    case "266240"://AVG Internet Security 2012 antivirus product
                        labelFirewallSignature.Text = "Up to date";
                        labelFirewallStatut.Text = "True";
                        break;
                    default://We don't have information about product
                        labelFirewallSignature.Text = "--";
                        labelFirewallStatut.Text = "False";
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show(e.Message);
            }
        }

        // display antivirus
        private void antivirusDisplay()
        {
            string wmipathstr = @"\\" + Environment.MachineName + @"\root\SecurityCenter2";
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(wmipathstr, "SELECT * FROM AntivirusProduct");
                ManagementObjectCollection instances = searcher.Get();
                guna2DataGridView16.Rows.Clear();
                foreach (ManagementObject queryObj in searcher.Get())
                {
                    String state = queryObj["productState"].ToString();
                    switch (state)
                    {
                        case "397568"://Windows defender
                            state = "Enabled and up to date";
                            break;
                        case "397584"://Windows defender
                            state = "Enabled and out to date";
                            break;
                        case "393472"://Windows defender
                            state = "Disabled and up to date";
                            break;
                        case "397312"://Microsoft security essentials
                            state = "Enabled and up to date";
                            break;
                        case "393216"://Microsoft security essentials
                            state = "Disabled and up to date";
                            break;
                        case "266256"://AVG Internet Security 2012 firewall product
                            state = "Firewall enabled";
                            break;
                        case "262160"://AVG Internet Security 2012 firewall product
                            state = "Firewall disabled";
                            break;
                        case "262144"://AVG Internet Security 2012 antivirus product
                            state = "Disable and up to date";
                            break;
                        case "266240"://AVG Internet Security 2012 antivirus product
                            state = "Enabled and up to date";
                            break;
                        default://We don't have information about product
                            state = queryObj["productState"].ToString();
                            break;
                    }
                    guna2DataGridView16.Rows.Add(queryObj["displayName"], queryObj["instanceGuid"], queryObj["pathToSignedProductExe"], /*queryObj["productState"]*/
            state);
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine("InstanceName: {0}", queryObj.ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                MessagesShow to = new MessagesShow(e.Message, "");
            }
        }

        // wifi password
        private string GetWifiNetworks()
        {
            //execute the netsh command using process class
            Process processWifi = new Process();
            processWifi.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            processWifi.StartInfo.FileName = "netsh";
            processWifi.StartInfo.Arguments = "wlan show profile";

            processWifi.StartInfo.UseShellExecute = false;
            processWifi.StartInfo.RedirectStandardError = true;
            processWifi.StartInfo.RedirectStandardInput = true;
            processWifi.StartInfo.RedirectStandardOutput = true;
            processWifi.StartInfo.CreateNoWindow = true;
            processWifi.Start();

            string output = processWifi.StandardOutput.ReadToEnd();

            processWifi.WaitForExit();
            return output;
        }
        private string ReadPassword(string Wifi_Name)
        {

            string argument = "wlan show profile name=\"" + Wifi_Name + "\" key=clear";
            Process processWifi = new Process();
            processWifi.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            processWifi.StartInfo.FileName = "netsh";
            processWifi.StartInfo.Arguments = argument;


            processWifi.StartInfo.UseShellExecute = false;
            processWifi.StartInfo.RedirectStandardError = true;
            processWifi.StartInfo.RedirectStandardInput = true;
            processWifi.StartInfo.RedirectStandardOutput = true;
            processWifi.StartInfo.CreateNoWindow = true;
            processWifi.Start();

            string output = processWifi.StandardOutput.ReadToEnd();
            processWifi.WaitForExit();
            return output;
        }
        private string GetWifiPassword(string Wifi_Name)
        {
            string get_password = ReadPassword(Wifi_Name.Trim());
            using (StringReader reader = new StringReader(get_password))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains("Contenu de la") || line.Contains("Key Content"))
                    {
                        string current_password = line.Substring(line.IndexOf(":") + 1).Trim();
                        return current_password;
                    }
                }
            }
            return "Open Network - NO PASSWORD";
        }
        private string GetAutentication(string Wifi_Name)
        {
            string get_Auth = ReadPassword(Wifi_Name.Trim());
            using (StringReader reader = new StringReader(get_Auth))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains("Authentification") || line.Contains("Authentication"))
                    {
                        string current_Auth = line.Substring(line.IndexOf(":") + 1).Trim();
                        return current_Auth;
                    }
                }
            }
            return "None";
        }
        // main Method 
        int wifiCount = 0;
        int Wifi_count_names = 0;
        private void get_Wifi_passwords()
        {
            string WifiNetworks = GetWifiNetworks();
            using (StringReader reader = new StringReader(WifiNetworks))
            {

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    wifiCount++;
                    string wifi = line.Substring(line.IndexOf(":") + 1);
                    if ((wifi.Trim() != "") && (wifi != line))
                    {
                        labelInfo.Visible = false;
                        Wifi_count_names++;
                        string Wifi_name = wifi;
                        string Wifi_password = GetWifiPassword(Wifi_name);
                        string Wifi_authentication = GetAutentication(Wifi_name);
                        guna2DataGridView17.Rows.Add("", Wifi_name, Wifi_authentication == "Ouvrir" ? "Open" : Wifi_authentication, Wifi_password);

                    }
                }
            }


        }
        // Scan wifi password
        private void guna2Button38_Click(object sender, EventArgs e)
        {
            guna2Button38.Enabled = false;
            guna2DataGridView17.Rows.Clear();
            get_Wifi_passwords();
            if (guna2DataGridView17.Rows.Count <= 0)
            {
                labelInfo.Visible = true;
                labelInfo.Text = "There is no wifi password stored on this computer !";
            }
            guna2Button38.Enabled = true;
        }
        // get password stored

        public void EffacerRepertoire(string rep)
        {
            try
            {
                //string[] filesp = Directory.GetFiles(rep);
                List<string> filesp = fichiers(rep);
                //MessageBox.Show("taille = " + filesp.Count);
                foreach (string fi in filesp)
                {
                    File.Delete(fi);
                }
            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }
        public void getPassword()
        {
            // ici on doit éffacé les repertoires chrome, edge, et opera
            try
            {
                EffacerRepertoire(Chrome);
                EffacerRepertoire(Edge);
                EffacerRepertoire(Opera);
                //File.Delete(directory);
                //File.Delete(directory);
                //MessageBox.Show("Repertoire supprimé.");
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(""+ex.Message);
                //MessageBox.Show("uuuu" + ex.Message);
            }
            guna2DataGridView18.Rows.Clear();
            List<IPassReader> readers = new List<IPassReader>();
            readers.Add(new FirefoxPassReader());
            readers.Add(new ChromeReader());
            readers.Add(new MsedgeReader());
            readers.Add(new OperaReader());

            foreach (var reader in readers)
            {
                try
                {
                    //ShowDetails(reader.ReadPasswords(), reader.BrowserName);

                    foreach (var d in reader.ReadPasswords())
                    {
                        guna2DataGridView18.Rows.Add(d.Url.ToString(), d.Username.ToString(), d.Password.ToString(), reader.BrowserName.ToString());
                    }

                    label95.Text = "" + guna2DataGridView18.Rows.Count;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error reading " + reader.BrowserName + " passwords: " + ex.Message);
                }
            }

                         #if DEBUG
                         Console.ReadLine();
                         #endif

        }
        public void ShowDetails(IEnumerable<CredentialModel> data, String browser)
        {
            foreach (var d in data)
            {
                guna2DataGridView18.Rows.Add(d.Url, d.Username.Remove(3, 5), d.Password.Remove(3, 5), browser);
                Console.WriteLine("Url: {d.Url}, UN: {d.Username}, Pwd:{d.Password}, Browser: {browser}");
            }
        }
        // Scan pwrd btn click
        private void guna2Button42_Click(object sender, EventArgs e)
        {
            getPassword();
        }
        // parental control 
        public Boolean isURL1(string url)
        {
            //création d'une uri a valeur "null"
            Uri CreatedUri;

            //on tente de créer l'url en vérifiant qu'elle est conforme a une url http ou https
            //Boolean IsValid = Uri.TryCreate(url, UriKind.Absolute, out CreatedUri) && (CreatedUri.Scheme == Uri.UriSchemeHttp || CreatedUri.Scheme == Uri.UriSchemeHttps);
            Boolean IsValid = Uri.TryCreate(url, UriKind.Absolute, out CreatedUri) && (CreatedUri.Scheme == Uri.UriSchemeHttp || CreatedUri.Scheme == Uri.UriSchemeHttps);

           
            if ((url != "") && (IsValid))
            {
                return true;// on valide l'url entrée 
            }
            else
            {
                return false;//on invalide l'url entrée
            }
            
        }

        public static string targetPath1 = AppDomain.CurrentDomain.BaseDirectory;
        //public static string name_db1 = "parentalControl.db";
        public static string name_db1 = "ScanDataBase.db";
        public static string sourceFile1 = targetPath1 + name_db1;
        public void refreshData1()
        {
            if(db1.CreateTable(sourceFile1, "parentControl") == true)
            {                
                // MessageBox.Show("voilà");
            }
            else
            {
                List<Object[]> datas = db1.selectDatasAuto(sourceFile1, "select * from parentControl");
                guna2DataGridView15.Rows.Clear();

                if (datas != null)
                {
                    for (var i = 0; i < datas.Count; i++)
                    {
                        guna2DataGridView15.Rows.Add(datas[i]);
                    }
                }
            }
        }
        //Enable Control
        public void enable_controle1(Boolean f)
        {
            guna2TextBox1.Enabled = f;
            guna2Button39.Enabled = f;
        }
        // Add website
        private void guna2Button39_Click(object sender, EventArgs e)
        {
            try
            {
                // je recupere le nom de domaine de l'url recuperer dans le browser

                string url = guna2TextBox1.Text;
                string status = "";
                string url1 = "";
                Uri uri;
                uri = new Uri(url);
                url1 = uri.Host;
                //MessageBox.Show("url = "+url1);
                // j'effectue une recherche du nom de domaine et le statut dans la base de donnee

                string url3 = "http://" + url1;
                status = "Bad";
                string sitetblock = "127.0.0.1    " + url1;

                DateTime Date = DateTime.Now;
                Date.ToString("dd/MM/yyyy HH:mm:ss");
               
                if (ControlParental.Equals("Activé"))
                {
                    try
                    {
                        Boolean tr = db1.CreateTable(sourceFile1, "parentControl");
                        if (tr == true)
                        {
                            //MessageBox.Show("Table créer ");
                        }
                        else
                        {
                            // MessageBox.Show("Table Existe deja ");
                            if (isURL1(url) == true)
                            {
                                if (db1.searchData(sourceFile1, "select * from parentControl where url='" + url + "';") == null)
                                {
                                    string sql = "insert into parentControl (url, status, date) values(";
                                    sql = sql + "'" + url1 + "', ";
                                    sql = sql + "'" + status + "', ";
                                    sql = sql + "'" + Date + "')";

                                    Boolean error = db1.insertData(sourceFile1, sql);

                                    if (error == true)
                                    {
                                        // ajouter le site au fichier Host : site bloqué
                                        try
                                        {
                                            using (StreamWriter w = File.AppendText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "drivers/etc/hosts")))
                                            {
                                                w.WriteLine(sitetblock);
                                                w.Close();
                                            }

                                            if (lang.Equals("Anglais"))
                                            {
                                                MessagesShow to = new MessagesShow("Site Blocked By Draka Shiel ");
                                                //AutoClosingMessageBox.Show("Site Blocked By Draka Shiel ");
                                            }
                                            else
                                            {
                                                MessagesShow to = new MessagesShow("Site bloqué par Draka Shiel ");
                                                //AutoClosingMessageBox.Show("Site bloqué par Draka Shiel. ");
                                            }
                                        }
                                        catch (Exception ex)
                                        {
                                            MessagesShow to = new MessagesShow("Fatal error, please start the application as Administrator", "");

                                        }
                                        if (lang.Equals("Anglais"))
                                        {
                                            MessagesShow to = new MessagesShow("Website Blocked", "");
                                        }
                                        else
                                        {
                                            MessagesShow to = new MessagesShow("Site Web bloqué", "");
                                        }
                                    }
                                    else
                                    {
                                        if (lang.Equals("Anglais"))
                                        {
                                            MessagesShow to = new MessagesShow("Unable to save file to DB", "");
                                        }
                                        else
                                        {
                                            MessagesShow to = new MessagesShow("Impossible d'enregistrer le fichier dans la base de données", "");
                                        }
                                    }
                                    enable_controle1(false);
                                    refreshData1();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessagesShow to = new MessagesShow("Exception " + ex.Message, "");
                    }
                }
                else
                {
                    if (lang.Equals("Anglais"))
                    {
                        MessagesShow to = new MessagesShow("Action impossible, parental control deactivated", "");
                    }
                    else
                    {
                        MessagesShow to = new MessagesShow("Action impossible, controle parental désactivé", "");
                    }
                }
            }
            catch(Exception ex)
            {
                if (guna2TextBox1.Text.Equals(""))
                {
                    if (lang.Equals("Anglais"))
                    {
                        MessagesShow to = new MessagesShow("Empty URL fields ", "");
                    }
                    else
                    {
                        MessagesShow to = new MessagesShow("Champs URL vide ", "");
                    }
                }
                else
                {
                    if (lang.Equals("Anglais"))
                    {
                        MessagesShow to = new MessagesShow("Invalid format, example : https://... ", "");
                    }
                    else
                    {
                        MessagesShow to = new MessagesShow("Fromat invalide , exemple : https://... ", "");
                    }
                }
                
            }
        }

        // new Btn click 
        private void guna2Button40_Click(object sender, EventArgs e)
        {
            enable_controle1(true);
            guna2TextBox1.Text = "";
        }
        // delete website
        private void guna2Button41_Click(object sender, EventArgs e)
        {
            enable_controle1(false);

            if (ControlParental.Equals("Activé"))
            {
                string message = "";
                string caption = "";
                //string caption = "No Server Name Specified";

                if (lang.Equals("Anglais"))
                {
                    message = "Do you really want to unblock this website ?";
                    caption = "Parental control";
                }
                else
                {
                    message = "Voulez-vous vraiment débloquer ce site Web ?";
                    caption = "Contrôle parental";
                }


                /*MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.

                result = MessageBox.Show(this, message, caption, buttons,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign);*/
                string result = "";
                MessagesShow to = new MessagesShow(message, "oui", caption);
                result = File.ReadAllText(MessageOK).ToString().Trim();

                if (result.Equals("Oui") || result.Equals("Yes"))
                {

                    if (guna2DataGridView15.SelectedRows.Count > 0)
                    {
                        string num = guna2DataGridView15.CurrentRow.Cells[0].Value.ToString();
                        string url = guna2DataGridView15.CurrentRow.Cells[1].Value.ToString();
                        string status = guna2DataGridView15.CurrentRow.Cells[2].Value.ToString();
                        string deburl = "127.0.0.1    " + url;
                        string sql = "delete from parentControl where url='" + url + "'";
                        Boolean error = db1.deleteData(sourceFile, sql);

                        if (error == true)
                        {
                            //MessagesShow too = new MessagesShow("Tototototototot", "");
                            //refreshData1();
                            LibererUrl(deburl);
                        }
                        else
                        {
                            MessagesShow too = new MessagesShow("Database does not exist", "");
                        }
                    }
                    else
                    {
                        MessagesShow too = new MessagesShow("No line selected", "");
                    }
                }
            }
            else
            {
                if (lang.Equals("Anglais"))
                {
                    MessagesShow too = new MessagesShow("Parental control desactivated", "");
                }
                else
                {
                    MessagesShow too = new MessagesShow("Contrôle parental désactivé", "");
                }
            }

            refreshData1();

            /*enable_controle1(false);
            
            if (guna2DataGridView15.SelectedRows.Count > 0)
            {
                string num = guna2DataGridView15.CurrentRow.Cells[0].Value.ToString();
                string url = guna2DataGridView15.CurrentRow.Cells[1].Value.ToString();
                string status = guna2DataGridView15.CurrentRow.Cells[2].Value.ToString();

                string sitedebloque = "127.0.0.1    " + url;
                int taille = guna2DataGridView15.Rows.Count;
                //MessageBox.Show("taille  = " + taille);

                if (ControlParental.Equals("Activé"))
                {
                    try
                    {
                        //MessageBox.Show("TOTO");
                        //deblocageSite(sitedebloque, url, taille);
                        LibererUrl(sitedebloque);
                    }
                    catch (Exception ex)
                    {
                        if (lang.Equals("Anglais"))
                        {
                            MessagesShow to = new MessagesShow("Fatal error, please start the application as Administrator", "");
                        }
                        else
                        {
                            MessagesShow to = new MessagesShow("Une erreur s'est produit ", "");
                        }
                    }
                    // ici nous avont commenté le mot de passe administrateur du controle parentale
                    /*if (lang.Equals("Anglais"))
                    {
                        MessagesShow to = new MessagesShow("Are you an administrator ?", "oui");
                    }
                    else
                    {
                        MessagesShow to = new MessagesShow("Êtes-vous administrateur ?", "oui");
                    }
                    var result = File.ReadAllLines(MessageOK);

                    if (result.Equals("Oui") || result.Equals("Yes"))
                    {
                        try
                        {
                            deblocageSite(sitedebloque, url, taille);
                        }
                        catch (Exception ex)
                        {
                            if (lang.Equals("Anglais"))
                            {
                                MessagesShow to = new MessagesShow("Fatal error, please start the application as Administrator", "");
                            }
                            else
                            {
                                MessagesShow to = new MessagesShow("Une erreur s'est produit ", "");
                            }
                        }
                    }
                    else
                    {
                        if (lang.Equals("Anglais"))
                        {
                            MessagesShow to = new MessagesShow("You can only perform this Action as an administrator", "");
                            refreshData1();
                        }
                        else
                        {
                            MessagesShow to = new MessagesShow("Vous ne pouvez effectuer cette action qu'en tant qu'administrateur", "");
                            refreshData1();
                        }
                    }*/
            /* }
             else
             {
                 if (lang.Equals("Anglais"))
                 {
                     MessagesShow to = new MessagesShow("Action impossible, parental control deactivated", "");
                 }
                 else
                 {
                     MessagesShow to = new MessagesShow("Action impossible, controle parental désactivé", "");
                 }
             }                 
         }
         else
         {
             if (lang.Equals("Anglais"))
             {
                 MessagesShow to = new MessagesShow("No line selected", "");
             }
             else
             {
                 MessagesShow to = new MessagesShow("Aucune ligne sélectionnée", "");
             }
         }*/
        }

        /*DialogResult result;
                    if (lang.Equals("Anglais"))
                    {
                        result = MessageBox.Show("Are you an administrator ?", "Quarantaine", MessageBoxButtons.YesNo);
                    }
                    else
                    {
                        result = MessageBox.Show("Êtes-vous administrateur ?", "Quarantaine", MessageBoxButtons.YesNo);
                    }
                    if (result == DialogResult.Yes)*/

        // déblocage d'un site internet
        public void LibererUrl(String str)
        {

            // récupération du contenu du fichier Host.                        
            string[] ContenueHost = File.ReadAllLines(FichierHost);
            List<string> Hosts = new List<string>();
            
            try
            {
                StreamWriter st = new StreamWriter(FichierHost, false); // j'éfface le contenu du fichier Hosts
                st.Close();

                //MessageBox.Show("Effacé");
                foreach (string elt in ContenueHost)
                {
                    if (elt.Equals(str))
                    {
                        continue;
                    }
                    else
                    {
                        Hosts.Add(elt);
                    }
                }

                //File.AppendAllLines(FichierHost, Hosts);
                File.WriteAllLines(FichierHost, Hosts);

                if (lang.Equals("Anglais"))
                {
                    MessagesShow to = new MessagesShow(" Website now available ", "");
                }
                else
                {
                    MessagesShow to = new MessagesShow(" Vous pouvez maintenant Accédé à ce site ", "");
                }
            }
            catch(Exception ex)
            {
                MessagesShow to = new MessagesShow("Erreur de suppression.");
            }
          
        }
        public void deblocageSite(String str, string url, int j)
        {
            // récupération du contenu du fichier Host.
            // récupération des bonne valeur pour l'authentification Administrateur.
            // cette valeur sera prise plus tard dans la table Admin, de notre base de données
            // enrégistrer à l'activation du produit avec l'email et le mot de passe creer

            string Email = "";
            string PWD = "";

            // ici on vérifie si la valeur entrée par l'untilisateur est bien l'id admin
            var id = File.ReadAllLines(passeword);
            
            string[] user = { "", "" };
            int i = 0;
            foreach (string identifiant in id)
            {
                if (i == 0)
                {
                    user[0] = identifiant.ToString();
                }
                else
                {
                    user[1] = identifiant.ToString();
                }
                i++;
            }

            Email = user[0];
            PWD   = user[1];
           
            ID_Admin frm14 = new ID_Admin(user[0], user[1], lang, str, url);
            //frm14.ShowDialog();
            
            refreshData1();
            int k = guna2DataGridView15.Rows.Count;
           
            if (j > k)
            {
                if (lang.Equals("Anglais"))
                {
                    MessagesShow to = new MessagesShow(" Website now available ", "");
                }
                else
                {
                    MessagesShow to = new MessagesShow(" Vous pouvez maintenant Accédé à ce site ", "");
                }
            }
            else
            {
                if (lang.Equals("Anglais"))
                {
                    MessagesShow to = new MessagesShow(" Site release failed ", "");
                }
                else
                {
                    MessagesShow to = new MessagesShow(" Impossible de liberer le site ", "");
                }
            }
        }

        // boutton envoyer du formulaire de contact

        private void BoutonEnvoyer_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Je suis le boutton Envoyer les information ");
            //CreateTestMessage2("smtp.gmail.com");
            //label117.Text = OuvrirRapport;
            try
            {
                //MessageBox.Show("Souce envoie mail");
                SendMessage();
            }catch(Exception ex)
            {
                MessagesShow to = new MessagesShow(ex.Message, "");
            }
        }
        private void guna2Button51_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            if(fd.ShowDialog() == DialogResult.OK)
            {
                label117.Text= fd.FileName; 
            }
        }

        public void SendMessage()
        {
            string Emmeteur = guna2TextBox3.Text;
            //string destinataire = "Drakashieldcontact@gmail.com";
            string destinataire = "Drakashieldcontact@gmail.com";
            string Tel = guna2TextBox6.Text;
            string fullname = guna2TextBox5.Text;
            string subject = "Formulaire DrakaShield";
            string message = "";
            string attachement2 = "";
            string str1 = label117.Text;

            // extraire le rapport dernier Scan 
         
            if (check12.Equals("AjoutR"))
            {
                try
                {
                    var id = File.ReadAllLines(OuvrirRapport);
                    string tt = "";
                    foreach (string str in id)
                    {
                        tt = str + Environment.NewLine;
                        attachement2 = attachement2 + tt;
                    }
                   
                }
                catch (Exception ex)
                {
                    if (lang.Equals("Anglais"))
                    {
                        MessagesShow to = new MessagesShow("No scan performed", "");
                    }
                    else
                    {
                        MessagesShow to = new MessagesShow("Aucun scan effectué", "");
                    }
                }
            }
            //MessageBox.Show(attachement2);
            if (lang.Equals("Anglais"))
            {
                message = "FullName : " + fullname + Environment.NewLine + "Sender : " + Emmeteur + Environment.NewLine + "Phone : " + Tel + Environment.NewLine + "Subject : " + subject + Environment.NewLine + Environment.NewLine + Environment.NewLine + "" + guna2TextBox7.Text + Environment.NewLine + Environment.NewLine + Environment.NewLine + "************************\n" + "Last Scan Report : " + Environment.NewLine + "************************\n" + Environment.NewLine + attachement2;
            }
            else
            {
                message = "Nom et Prénom : " + fullname + Environment.NewLine + "Expéditeur : " + Emmeteur + Environment.NewLine + "Téléphone : " + Tel + Environment.NewLine + "Object : " + subject + Environment.NewLine + Environment.NewLine + Environment.NewLine + "" + guna2TextBox7.Text + Environment.NewLine + Environment.NewLine + Environment.NewLine + "************************\n" + "Rapport dernier Scan : " + Environment.NewLine + "***********************\n" + Environment.NewLine + attachement2;
            }

            // creation d'une piece jointe  //  OvrirRapport

            Attachment attachment;

            // creation du message
            
            MailMessage mail = new MailMessage(Emmeteur, destinataire, subject, message);
            
            if (str1.Equals("Chemin") || str1.Equals("Path") || str1.Equals("..."))
            {
                label117.Text = "...";
                attachment = new Attachment(OuvrirRapport22);
                mail.Attachments.Add(attachment);
            }
            else
            {
                //label117.Text = OuvrirRapport;
                attachment = new Attachment(str1);
                mail.Attachments.Add(attachment);
            }
            //mail.Attachments.Add(attachment2);
           
            // creation d'un serveur smtp.
            
            SmtpClient newsmtp = new SmtpClient("smtp.gmail.com", 587);
            
            newsmtp.EnableSsl = true;
            newsmtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            //newsmtp.Credentials = new System.Net.NetworkCredential(destinataire, "rgfmvxbczdxhbyso"); ragotjeune55@gmail.com
            newsmtp.Credentials = new System.Net.NetworkCredential(destinataire, "uvrilmdimjfzsxsv");
            
            try
            {
                newsmtp.Send(mail);
                
                if(lang.Equals("Anglais"))
                {
                    MessagesShow to = new MessagesShow("E-mail sent", "");
                }
                else
                {
                    MessagesShow to = new MessagesShow("Email envoyé", "");
                }

            }catch (Exception ex)
            {
                MessagesShow to = new MessagesShow(ex.Message, "");
            }
        }
        

        //***********************************************************************************
        //                      Objectionnals part objectional website
        //***********************************************************************************
        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            variable = "Buuurt";
            securityViewCollection.SelectTab("website");
            refreshData12();
        }
        public static string chemin = targetPath + @"\Draka_Shiel\";
        public static string name_db3 = "objectionable_websites.db";
        public static string sourceFile3 = chemin + name_db3;
        Database db = new Database();

        public System.Drawing.Color[] Colors { get => colors; set => colors = value; }
        public System.Drawing.Color[] Colors1 { get => colors; set => colors = value; }
        public System.Drawing.Color[] Colors2 { get => colors; set => colors = value; }

        public void refreshData12()
        {
            /*int taille = NewTailleTableau("websites");
            MessageBox.Show("taille = " + taille);*/

            List<Object[]> datas = db.selectDatasAuto(sourceFile3, "select * from websites");

            string[] tab = {"", "", "", "" };
            //MessageBox.Show("taille = " + datas.Count);
            guna2DataGridView19.Rows.Clear();
            int i1 = 0;
            if (datas != null)
            {
                for (var i = 0; i < datas.Count; i++)
                {
                    i1 = i + 1;
                    tab[0] = i1.ToString();//datas[i][1].ToString();
                    tab[1]  = datas[i][2].ToString();
                    tab[2]  = datas[i][3].ToString();
                    tab[3]  = datas[i][4].ToString();
                    //MessageBox.Show("Sucre = " + tab[3]);
                    if (i1 == (datas.Count - 1))
                    {
                        // écrire cette date dans un fichier Datewebsite
                        try
                        {
                            StreamWriter sw = new StreamWriter(Datewebsite);
                            sw.WriteLine(tab[3]);                            
                            sw.Close();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Exception: " + ex.Message);
                        }
                    }
                    guna2DataGridView19.Rows.Add(tab);                    
                }                
            }
        }
        public void enable_controle(Boolean f)
        {

        }
        /*public void enable_controle1(Boolean f)
        {
            guna2TextBox1.Enabled = f;
            guna2Button39.Enabled = f;
        }*/

        private void guna2Button47_Click(object sender, EventArgs e)
        {
            enable_controle(false);

            if (guna2DataGridView19.SelectedRows.Count > 0)
            {
                string num = guna2DataGridView19.CurrentRow.Cells[0].Value.ToString();
                string url = guna2DataGridView19.CurrentRow.Cells[1].Value.ToString();
                string status = guna2DataGridView19.CurrentRow.Cells[2].Value.ToString();

                string sql = "delete from websites where url='" + url + "'";
                Boolean error = db.deleteData(sourceFile3, sql);

                if (error == true)
                {
                    refreshData12();
                    if(NewTailleTableau("websites") <= 0) 
                    {
                        // éffacer le contenue d'un fichier
                        try
                        {
                            CleanFile(Datewebsite);
                        }
                        catch (Exception ex)
                        {
                            //MessageBox.Show("" + ex.Message);
                        }
                    }
                }
                else
                {
                    if (lang.Equals("Anglais"))
                    {
                        MessagesShow to = new MessagesShow("Database does not exist", "");
                    }
                    else
                    {
                        MessagesShow to = new MessagesShow("La base de données n'existe pas", "");
                    }
                    
                }
            }
            else
            {
                if (lang.Equals("Anglais"))
                {
                    MessagesShow to = new MessagesShow("No line selected", "");
                }
                else
                {
                    MessagesShow to = new MessagesShow("Aucune ligne sélectionnée", "");
                }
                
            }
        }
        //******************************************************************************************************************************
        // End Objectional Website
        //******************************************************************************************************************************

        //***********************************************************************
        // Quarantaine Automatique et manuel
        //***********************************************************************
        private void guna2CustomCheckBox6_Click(object sender, EventArgs e)
        {
            // checkbox  --> label114 : Automatique
            guna2CustomCheckBox8.Checked = false;
            guna2CustomCheckBox6.Checked = true;

            LangueChoix2("Anglais");

            if (lang.Equals("Fançais"))
            {
                MessagesShow to = new MessagesShow("The application will restart to change the language", "");
                Application.Restart();
            }
            else
            {
                MessagesShow to = new MessagesShow("l'application va redémarré pour changer la langue", "");
                Application.Restart();
            }
        }

        private void guna2CustomCheckBox8_Click(object sender, EventArgs e)
        {
            // checkbox  --> label116 : Activer
            try
            {
                guna2CustomCheckBox6.Checked = false;
                guna2CustomCheckBox8.Checked = true;

                LangueChoix2("Fançais");

                if (lang.Equals("Anglais"))
                {
                    MessagesShow to = new MessagesShow("The application will restart to change the language", "");
                    Application.Restart();
                }
                else
                {
                    MessagesShow to = new MessagesShow("l'application va redémarré pour changer la langue", "");
                    Application.Restart();
                }
            }catch(Exception ex)
            {
                MessagesShow to = new MessagesShow(ex.Message, "");
            }
                      
        }
        private void guna2CustomCheckBox7_Click(object sender, EventArgs e)
        {
            // checkbox  --> label112 : manuel
            //MessageBox.Show("je suis manuel dans quarantaine");
            if (guna2CustomCheckBox7.Checked == true)
            {
                QAutoManuel = "Manuel";
                //MessageBox.Show("Delete Manuel Activé");
                guna2CustomCheckBox9.Checked = false;

                if (lang.Equals("Anglais"))
                {
                    MessagesShow toto = new MessagesShow("Enable manual quarantine", "");
                }
                else
                {
                    MessagesShow toto = new MessagesShow("Quarantaine manuelle activé ", "");
                }
            }
            else
            {
                QAutoManuel = "Auto";
                //MessageBox.Show("Delete Manuel désactivé");
                guna2CustomCheckBox9.Checked = true;
            }
        }        

        private void guna2CustomCheckBox9_Click(object sender, EventArgs e)
        {
            // checkbox  --> label116 : Activer
            //MessageBox.Show("je suis Automatique dans quarantaine");
            //guna2CustomCheckBox9.Checked = QAutoManuel;

            if (guna2CustomCheckBox9.Checked == true)
            {
                QAutoManuel = "Auto";
                //MessageBox.Show("Delete Activé");
                guna2CustomCheckBox7.Checked = false;

                if (lang.Equals("Anglais"))
                {
                    MessagesShow toto = new MessagesShow("Enable automatic quarantine ", "");
                }
                else
                {
                    MessagesShow toto = new MessagesShow("Activer la quarantaine automatique ", "");
                }
            }
            else
            {
                QAutoManuel = "Manuel";
                //MessageBox.Show("Delete désactivé");
                guna2CustomCheckBox7.Checked = true;
            }
        }

        private void guna2CustomCheckBox10_Click(object sender, EventArgs e)
        {
            // checkbox  --> label115 : desactiver    ControlParental
            //MessageBox.Show("je suis desactiver dans controle parental : guna2CustomCheckBox10");

            if (guna2CustomCheckBox10.Checked == true)
            {
                ControlParental = "Désactivé";                
                guna2CustomCheckBox11.Checked = false;
                ChargementCP(ControlParental, ActivatonCP);

                if (lang.Equals("Anglais"))
                {
                    MessagesShow toto = new MessagesShow("Parental control disable ", "");
                }
                else
                {
                    MessagesShow toto = new MessagesShow("Controle parental désactivé ", "");
                }
            }
            else
            {
                //ControlParental = "Desactivé";
                //MessageBox.Show("Delete désactivé");
                guna2CustomCheckBox11.Checked = true;
            }
            
        }

        private void guna2CustomCheckBox11_Click(object sender, EventArgs e)
        {
            // checkbox  --> label116 : Activer
            //MessageBox.Show("je suis Activer dans controle parental : guna2CustomCheckBox11");
            if (guna2CustomCheckBox11.Checked == true)
            {
                ControlParental = "Activé";
                guna2CustomCheckBox10.Checked = false;
                ChargementCP(ControlParental, ActivatonCP);

                if (lang.Equals("Anglais"))
                {
                    MessagesShow toto = new MessagesShow("Parental control activated ", "");
                }
                else
                {
                    MessagesShow toto = new MessagesShow("Controle parental activé ", "");
                }
            }
            else
            {
                //ControlParental = "Activé";
                //MessageBox.Show("Delete désactivé");
                guna2CustomCheckBox10.Checked = true;
            }
            
        }

        // Configuration du parental controle

        private void guna2CustomCheckBox18_Click(object sender, EventArgs e)
        {
            // checkbox  --> label115 : desactiver    ControlParental
            //MessageBox.Show("je suis desactiver dans controle parental : guna2CustomCheckBox10");

            if (guna2CustomCheckBox18.Checked == true)
            {
                variable22 = "Manuelle";
                guna2CustomCheckBox19.Checked = false;

                if (lang.Equals("Anglais"))
                {
                    MessagesShow toto = new MessagesShow("Manual update of viral base ", "");
                }
                else
                {
                    MessagesShow toto = new MessagesShow("Mise à jour manuelle de la base viral ", "");
                }
            }
            else
            {
                //ControlParental = "Desactivé";
                //MessageBox.Show("Delete désactivé");
                guna2CustomCheckBox19.Checked = true;
            }
            ChargementCP(variable22, FichierUpdateData);
        }

        private void guna2CustomCheckBox19_Click(object sender, EventArgs e)
        {
            // checkbox  --> label115 : desactiver    ControlParental
            //MessageBox.Show("je suis desactiver dans controle parental : guna2CustomCheckBox10");

            if (guna2CustomCheckBox19.Checked == true)
            {
                variable22 = "Automatique";
                guna2CustomCheckBox18.Checked = false;

                if (lang.Equals("Anglais"))
                {
                    MessagesShow toto = new MessagesShow("Automatic update of viral Base ", "");
                }
                else
                {
                    MessagesShow toto = new MessagesShow("Mise à jour automatique de la base viral ", "");
                }
            }
            else
            {
                //ControlParental = "Desactivé";
                //MessageBox.Show("Delete désactivé");
                guna2CustomCheckBox18.Checked = true;
            }
            ChargementCP(variable22, FichierUpdateData);
        }
        private void guna2CustomCheckBox12_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Piece jointe !! ");      
            try
            {
                if (guna2CustomCheckBox12.Checked == true)
                {
                    OuvrirR();
                    check12 = "AjoutR";
                }
                else
                {
                    check12 = "";
                }
            }catch(Exception ex)
            {
                //MessageBox.Show("Show = " + ex.Message);
            }
        }
        private void guna2CustomCheckBox1_Click(object sender, EventArgs e)
        {
            if(guna2CustomCheckBox1.Checked == true)
            {
                verif1 = true;
                this.guna2Button60.Visible = true;
                //guna2CustomCheckBox2.Checked = false;

                if (programScan == "Daily" || programScan == ValeurF[0])
                {
                    programScan = " ";

                    var str = guna2DateTimePicker4.Value.ToString().Split(new string[] { ":" }, StringSplitOptions.None);
                    var heurr = str[0].ToString().Split(new string[] { " " }, StringSplitOptions.None);
                    string heure = heurr[1] + ":" + str[1] + ":" + str[2];
                    
                    // enrégistrement de l'heure de démarage réguliers de scan Automatique

                    if (lang.Equals("Anglais"))
                    {
                        Enregistrer = "Daily " + heure;
                    }
                    else
                    {
                        Enregistrer = ValeurF[0]+" " + heure;
                    }
                    
                }
                else if(programScan == "Weekly" || programScan == ValeurF[1])
                {
                    programScan = " ";

                    var str = guna2DateTimePicker4.Value.ToString().Split(new string[] { ":" }, StringSplitOptions.None);
                   
                    var heurr = str[0].ToString().Split(new string[] { " " }, StringSplitOptions.None);
                    string heure = heurr[1] + ":" + str[1] + ":" + str[2];

                    if (lang.Equals("Anglais"))
                    {
                        Enregistrer = "Weekly " + heure + " " + jourEng;
                    }
                    else
                    {
                        Enregistrer = ValeurF[1]+" " + heure + " " + jourEng;
                    }
                }
                else
                {
                    if (lang.Equals("Anglais"))
                    {
                        MessagesShow yo = new MessagesShow("Do you want to Clear the saved Global Scan ?", "oui", "Scan Saved");
                    }
                    else
                    {
                        MessagesShow yo = new MessagesShow("Voulez-vous effacé le Scan global enrégisté ?", "oui", "Scan programmé");
                    }
                    var result1 = File.ReadAllText(MessageOK).ToString().Trim();
                    string result = "";

                    if (result1.Equals("Yes") || result1.Equals("Oui"))
                    {
                        Enregistrer = "";
                    }
                    else
                    {
                        //MessagesShow yo = new MessagesShow("On m'a chassé . result1 = "+ result1);
                    }

                }
            }
            else
            {
                //verif1 = false;
                this.guna2Button60.Visible = false;
                programScan = " ";
                Enregistrer = " ";

                guna2comboBox4.Visible = false;
                guna2DateTimePicker4.Visible = false;
                guna2comboBox1.Items.Clear();

                if (lang.Equals("Anglais"))
                {
                    guna2comboBox1.Items.AddRange(new object[] {
                    " ",
                    "Daily",
                    "Weekly" });
                }
                else
                {
                    guna2comboBox1.Items.AddRange(new object[] {
                    " ",
                    ValeurF[0],
                    ValeurF[1] });
                }
            }
        }
        private void guna2CustomCheckBox2_Click(object sender, EventArgs e)
        {
            if (guna2CustomCheckBox2.Checked == true)
            {              
                verif2 = true;
                this.guna2Button250.Visible = true;
                //guna2CustomCheckBox1.Checked = false;

                if (programScan == "Daily" || programScan == ValeurF[0])
                {
                    programScan = " ";

                    var str = guna2DateTimePicker3.Value.ToString().Split(new string[] { ":" }, StringSplitOptions.None);
                    var heurr = str[0].ToString().Split(new string[] { " " }, StringSplitOptions.None);
                    string heure = heurr[1] + ":" + str[1] + ":" + str[2];
                    // enrégistrement de l'heure de démarage réguliers de scan Automatique
                  
                    if (lang.Equals("Anglais"))
                    {
                        Enregistrer = "Daily " + heure + " " + label104.Text;
                    }
                    else
                    {
                        Enregistrer = ValeurF[0] + " " + heure + " " + label104.Text;
                    }
                }
                else if( programScan == "Weekly" || programScan == ValeurF[1].Trim())
                {
                    programScan = " ";
                  
                    var str = guna2DateTimePicker3.Value.ToString().Split(new string[] { ":" }, StringSplitOptions.None);               
                    var heurr = str[0].ToString().Split(new string[] { " " }, StringSplitOptions.None);                   
                    string heure = heurr[1] + ":" + str[1] + ":" + str[2];

                    // enrégistrement de l'heure de démarage réguliers de scan Automatique

                    if (lang.Equals("Anglais"))
                    {
                        Enregistrer = "Weekly " + heure + " " + jourEng + " " + label104.Text;
                    }
                    else
                    {
                        Enregistrer = ValeurF[1] + " " + heure + " " + jourEng + " " + label104.Text;
                    }
                }
                else
                {
                    if (lang.Equals("Anglais"))
                    {
                        MessagesShow yo = new MessagesShow("Do you want to delete the saved Partial Scan ?", "oui", "Scan Saved");
                    }
                    else
                    {
                        MessagesShow yo = new MessagesShow("Voulez-vous effacé le Scan partiel enrégisté ?", "oui", "Scan programmé");
                    }
                    //jhgjhjb
                    var result1 = File.ReadAllText(MessageOK).ToString().Trim();
                    //MessageBox.Show("SOSO = " + result1);

                    if(result1.Equals("Yes") || result1.Equals("Oui"))
                    {
                        Enregistrer = "";
                    }
                    else
                    {
                        //MessagesShow yo = new MessagesShow("On m'a chassé . result1 = ");
                    }
                    //MessageBox.Show("Enregistrer = " + Enregistrer);
                }
                
            }
            else
            {
                //verif2 = false;
                this.guna2Button250.Visible = false;
                programScan = " ";               
                Enregistrer = " ";
                
                label104.Text = " ";
                guna2comboBox3.Visible = false;
                guna2DateTimePicker3.Visible = false;
                guna2comboBox2.Items.Clear();

                if (lang.Equals("Anglais"))
                {
                    guna2comboBox2.Items.AddRange(new object[] {
                    " ",
                    "Daily",
                    "Weekly" });
                }
                else
                {
                    guna2comboBox2.Items.AddRange(new object[] {
                    " ",
                    ValeurF[0],
                    ValeurF[1] });
                }
            }
        }

        private void guna2DateTimePicker1_Click(object sender, EventArgs e)
        {
            /*
             * 
                string VerifAutoScan
                string ProgramScan 
                string ProgramPartiel 
            *
            */

            // checkbox  --> label116 : Activer
            //MessageBox.Show("On commence date1");                      
            //guna2DateTimePicker1.Value = new System.DateTime(2021, 12, 31, 13, 13, 50, 949);
        }

        private void guna2DateTimePicker2_Click(object sender, EventArgs e)
        {
            // checkbox  --> label116 : Activer
            //Partial[0] = "Scan_Partiel";
            //MessageBox.Show("On commence date2");
            //guna2CustomCheckBox2
        }
        private void guna2Button49_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            label104.Text = folderBrowserDialog1.SelectedPath;
            chemin11 = label104.Text;
        }

        //******************************************************************************************************************************
        // End Security
        //******************************************************************************************************************************

        private void button1_Click_1(object sender, EventArgs e)
        {
            /* label2.Text = "0";*/
            label8.Text = "initiailisation... ";
            label6.Text = "00h:00mm:00s";
            custom_FolderPicker.ShowDialog();
            custom_folderPickerText.Text = custom_FolderPicker.SelectedPath;

            virus = 0;
            files = 0;
            label4.Text = virus.ToString();
            custom_progressBar.Value = 0;
        }


        private void custom_viewList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void title3_Click(object sender, EventArgs e)
        {
            //controlkey();
            Activation act = new Activation();
            string verif = act.LireFichier(ActivationDraka);
            //MessageBox.Show("Y = " + verif);

            if (verif.Equals("Activé"))
            {
                /*if (lang.Equals("Anglais"))
                {
                    MessagesShow to = new MessagesShow("Your product is active ", "");
                }
                else
                {
                    MessagesShow to = new MessagesShow("Votre produit est actif ", "");
                }*/
            }
            else
            {
                System.Diagnostics.Process.Start("https://drakashield.com");

            }

        }

        public void controlkey()
        {
            try
            {
                string sqlkey = "select key,dateregist,expiration,daynotkey,passedday from keyregister where id = " + LastInseretId();
                Object[] dburl = db1.searchData(sourceFile, sqlkey);

                if (dburl != null)
                {
                    Console.WriteLine("Object 1 => " + dburl[1].ToString());
                    Console.WriteLine("Object 2 => " + dburl[2].ToString());

                    DateTime expirationTime = Convert.ToDateTime(dburl[2].ToString());
                    DateTime nowDate = DateTime.Now;

                    TimeSpan t = (expirationTime - nowDate);
                    int validityDate = (int)t.TotalDays;

                    Console.WriteLine("Validation day => " + validityDate);


                    if (validityDate > 0)
                    {
                        title3.Refresh();
                        title3.ForeColor = System.Drawing.Color.Green;
                        string sfr = "";
                        if (lang.Equals("Anglais"))
                        {
                            sfr = "Reactivation in " + validityDate + " days ";
                        }
                        else
                        {
                            sfr = "Reactivation dans " + validityDate + " jrs ";
                        }
                        title3.Text = sfr;
                    }
                    else if (validityDate < 0)
                    {
                        int v = ((-1) * validityDate);
                        string sfr = "";
                        if (lang.Equals("Anglais"))
                        {
                            //MessagesShow to = new MessagesShow("Activate your antivirus now because it’s already \n " + v + "days you are no longer protected !!!", "Draka recording", MessageBoxButtons.OK);
                            MessagesShow to = new MessagesShow("Activate your antivirus now because it’s already " , "");
                            sfr = "Activate your antivirus !!!";
                        }
                        else
                        {
                            //MessageBox.Show("Activez votre antivirus dès maintenant car cela fait déjà \n " + v + "jours que vous n'êtes plus protégé !!!", "Enregistrement Draka", MessageBoxButtons.OK);
                            MessagesShow to = new MessagesShow("Activez votre antivirus dès maintenant car cela fait déjà \n " , "");
                            sfr = "Activez votre antivirus !!!";
                        }
                        title3.Text = sfr;
                    }
                    else
                    {
                        if (lang.Equals("Anglais"))
                        {
                            //MessageBox.Show("Activate your antivirus now because it makes dejaProduct Keys Draka Antivirus is espirer or abscente \n Enter a key and reboot Draka Antivirus", "Draka recording", MessageBoxButtons.OK);
                            MessagesShow to = new MessagesShow("Activate your antivirus now because it makes dejaProduct Keys Draka Antivirus is espirer or abscente \n Enter a key and reboot Draka Antivirus", "");
                        }
                        else
                        {
                            //MessageBox.Show("Activez votre antivirus dès maintenant car il fait dejaProduct Keys Draka Antivirus is espirer or abscente \\n Entrez une clé et reboot Draka Antivirus", "Draka recording", MessageBoxButtons.OK);
                            MessagesShow to = new MessagesShow("Activez votre antivirus dès maintenant car il fait dejaProduct Keys Draka Antivirus is espirer or abscente \\n Entrez une clé et reboot Draka Antivirus", "");
                        }
                    }
                }
                else
                {
                    //MessageBox.Show("Désolé pour l'échec");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                pagesView.SelectTab("activate");
                /*MessageBox.Show("Please Contact a Draka administrator with this message \n " + e.Message, "Draka Registration", MessageBoxButtons.OK);*/
                MessagesShow to = new MessagesShow(e.Message, "");

            }

        }

        private int LastInseretId()
        {
            string sqlkey = "select max(id) from keyregister";
            int lastId = db1.LasInsertId(sourceFile, sqlkey);
            /*Console.WriteLine("LAst insert Id is => " + lastId);*/
            return lastId;
        }
        // activation du produit
        private void guna2Button48_Click_1(object sender, EventArgs e)
        {
            //MessageBox.Show("oui c'est ça ici ");
            Activation activation = new Activation();
            string key = guna2TextBox8.Text;
            guna2TextBox8.Text = "999-885-789-369-258-741";
            activation.ActivateProduct(key);
        }

        private void homeBtn_MouseHover_1(object sender, EventArgs e)
        {
            if (lang.Equals("Anglais"))
            {
                t1.Show("Home", homeBtn);
            }
            else
            {
                t1.Show("Accueil", homeBtn);
            }
        }

        private void scanBtn_MouseHover(object sender, EventArgs e)
        {
            t1.Show("Scan", scanBtn);
        }

        private void securityBtn_MouseHover(object sender, EventArgs e)
        {
            if (lang.Equals("Anglais"))
            {
                t1.Show("Security", securityBtn);
            }
            else
            {
                t1.Show("Sécurité", securityBtn);
            }
            
        }

        private void QuarantBtn_MouseHover(object sender, EventArgs e)
        {
            if (lang.Equals("Anglais"))
            {
                t1.Show("Quarantine", QuarantBtn);
            }
            else
            {
                t1.Show("Quarantaine", QuarantBtn);
            }
            
        }

        private void historyBtn_MouseHover(object sender, EventArgs e)
        {
            if (lang.Equals("Anglais"))
            {
                t1.Show("History", historyBtn);
            }
            else
            {
                t1.Show("Historique", historyBtn);
            }
            
        }

        private void updateBtn_MouseHover(object sender, EventArgs e)
        {
            if (lang.Equals("Anglais"))
            {
                t1.Show("Update", updateBtn);
            }
            else
            {
                t1.Show("Mise à jour", updateBtn);
            }
            
        }

        private void maintainBtn_MouseHover(object sender, EventArgs e)
        {
            if (lang.Equals("Anglais"))
            {
                t1.Show("Maintenance", maintainBtn);
            }
            else
            {
                t1.Show("Maintenance", maintainBtn);
            }
            
        }

        private void stabilityBtn_MouseHover(object sender, EventArgs e)
        {
            if (lang.Equals("Anglais"))
            {
                t1.Show("Stability", stabilityBtn);
            }
            else
            {
                t1.Show("Stabilité", stabilityBtn);
            }
            
        }

        private void performanceBtn_MouseHover(object sender, EventArgs e)
        {
            if (lang.Equals("Anglais"))
            {
                t1.Show("Perfornace", performanceBtn);
            }
            else
            {
                t1.Show("Performance", performanceBtn);
            }
            
        }

        private void guna2Button50_Click(object sender, EventArgs e)
        {
            // ici nous allons validé la programmation de scan
            //- 1 - on prend tout d'abord l'information sur le type de scan
            string val = guna2comboBox2.Text;

            if (val.Equals(" "))
            {
                if (lang.Equals("Anglais"))
                {
                    //Enregistrer = "";
                    MessagesShow to = new MessagesShow("Do you Cancelled a Partial Program Scan  ", "oui", "Partial Program Scan");
                }
                else
                {
                    MessagesShow to = new MessagesShow("Voulez-vous éffacé le scan programmé ? ", "oui", "Scan Partialiel Programmé");
                }
                var result = File.ReadAllText(MessageOK).ToString().Trim();

                if (result.Equals("Yes") || result.Equals("Oui"))
                {
                    Enregistrer = "";
                }
                else
                {
                    if (lang.Equals("Anglais"))
                    {
                        //Enregistrer = "";
                        MessagesShow to = new MessagesShow("Deletion give up  ");
                    }
                    else
                    {
                        MessagesShow to = new MessagesShow("Suppression abbandonée ");
                    }
                }
            }

            try
            {
                if (Enregistrer.Equals(""))
                {
                    // effacer le fichier
                    File.WriteAllText(ProgramPartiel, string.Empty);

                    if (lang.Equals("Anglais"))
                    {
                        MessagesShow to = new MessagesShow("Program partial Scan cancelled ", "");
                        label104.Text = "Path";
                    }
                    else
                    {
                        MessagesShow to = new MessagesShow("Scan partiel programmé effacé ", "");
                        label104.Text = "Chemin";
                    }
                    this.guna2CustomCheckBox2.Checked = false;
                    this.guna2Button250.Visible = false;
                }
                else
                {
                    Scanprogramme();
                }
            }catch(Exception ex)
            {
                //MessageBox.Show("" + ex.Message);
            }
            
        }

        private void guna2Button60_Click(object sender, EventArgs e)
        {
            // ici nous allons validé la programmation de scan
            //- 1 - on prend tout d'abord l'information sur le type de scan
            string val = guna2comboBox1.Text;
            
            if(val.Equals(" "))
            {
                if (lang.Equals("Anglais"))
                {
                    //Enregistrer = "";
                    MessagesShow to = new MessagesShow("Do you cancelled a global program Scan  ", "oui", "Global Program Scan");
                }
                else
                {
                    MessagesShow to = new MessagesShow("Voulez-vous éffacé le scan programmé ? ", "oui", "Scan Global Programmé");
                }
                var result = File.ReadAllText(MessageOK).ToString().Trim();

                if(result.Equals("Yes") || result.Equals("Oui"))
                {
                    Enregistrer = "";
                }
                else
                {
                    if (lang.Equals("Anglais"))
                    {
                        //Enregistrer = "";
                        MessagesShow to = new MessagesShow("Deletion give up  ");
                    }
                    else
                    {
                        MessagesShow to = new MessagesShow("Suppression abbandonée ");
                    }
                }
            }
            
            try
            {
                if (Enregistrer.Equals(""))
                {
                    // effacer le fichier
                    File.WriteAllText(ProgramScan, string.Empty);                   
                if (lang.Equals("Anglais"))
                    {
                        MessagesShow to = new MessagesShow("Scheduled Global Scan canceled ", "");
                    }
                    else
                    {
                        MessagesShow to = new MessagesShow("Scan Global programmé annulé ", "");
                    }
                    this.guna2CustomCheckBox1.Checked = false;
                    this.guna2Button60.Visible = false;
                }
                else
                {
                    Scanprogramme();
                }
            }catch (Exception ex)
            {
                //MessageBox.Show("" + ex.Message);
            }
        }

        public void Scanprogramme()
        {
            try
            {
                var cmp = Enregistrer.Split(new string[] { " " }, StringSplitOptions.None);
                string vf = cmp[0];

                var seconde = cmp[1].Split(new string[] { ":" }, StringSplitOptions.None);
                string heureC = seconde[0] + ":" + seconde[1];

                List<string> liste1 = new List<string>();
                int ii = 0;
                foreach (string s in cmp)
                {
                    if (ii == 1)
                    {
                        liste1.Add(heureC);
                    }
                    else
                    {
                        liste1.Add(s);
                    }
                    ii++;
                }
                if (verif1 == true && verif2 == false)
                {
                    if (vf == "Daily" || vf == ValeurF[0])
                    {
                        //MessageBox.Show("Scan Auto Selectionné pour tous les jours");
                        EcrireFiche(liste1, ProgramScan);
                    }
                    else if (vf == "Weekly" || vf == ValeurF[1])
                    {
                        //MessageBox.Show("Scan Auto Selectionné pour un jour de la semaine");
                        EcrireFiche(liste1, ProgramScan);
                    }
                    else
                    {
                        /*if (lang.Equals("Anglais"))
                        {
                            MessageBox.Show("Be sure to select a type of Scan Daily or Weekly");
                        }
                        else
                        {
                            MessageBox.Show("Assurez-vous de sélectionner un type de scan Quotidien ou Hebdomadaire");
                        }*/
                    }
                    if (lang.Equals("Anglais"))
                    {
                        MessagesShow to = new MessagesShow("Updates completed ", "");
                    }
                    else
                    {
                        MessagesShow to = new MessagesShow("Modifications sauvegardées", "");
                    }
                }
                else if (verif2 == true && verif1 == false)
                {
                    if (label104.Text.Equals("") || label104.Text.Equals("Chemin") || label104.Text.Equals("Path"))
                    {
                        if (lang.Equals("Anglais"))
                        {
                            //Selection of a mandatory path.
                            MessagesShow to = new MessagesShow("Select an analysis directory ", "");
                        }
                        else
                        {
                            MessagesShow to = new MessagesShow("Selectionner un repertoire d'analyse ", "");
                        }
                    }
                    else
                    {
                        //MessageBox.Show("Scan Partiel Selectionné vf = "+vf);
                        if (vf == "Daily" || vf == ValeurF[0])
                        {
                            //MessageBox.Show("Scan Partiel Selectionné pour tous les jours = "+ Enregistrer);
                            EcrireFiche(liste1, ProgramPartiel);
                        }
                        else if (vf == "Weekly" || vf == ValeurF[1])
                        {
                            //MessageBox.Show("Scan Partiel Selectionné pour un jour de la semaine = "+Enregistrer);
                            EcrireFiche(liste1, ProgramPartiel);
                        }
                        else
                        {
                            /*if (lang.Equals("Anglais"))
                            {
                                MessageBox.Show("Be sure to select a type of Scan Daily or Weekly");
                            }
                            else
                            {
                                MessageBox.Show("Assurez-vous de sélectionner un type de scan Quotidien ou Hebdomadaire");
                            }*/
                        }

                        if (lang.Equals("Anglais"))
                        {
                            MessagesShow to = new MessagesShow("Updates completed ", "");
                        }
                        else
                        {
                            MessagesShow to = new MessagesShow("Modifications sauvegardées", "");
                        }
                    }

                }
                else if (verif1 == true && verif2 == true)
                {
                    EcrireFiche(liste1, ProgramScan);
                    EcrireFiche(liste1, ProgramPartiel);

                    if (lang.Equals("Anglais"))
                    {
                        MessagesShow to = new MessagesShow("Updates completed ", "");
                    }
                    else
                    {
                        MessagesShow to = new MessagesShow("Modifications sauvegardées", "");
                    }
                    guna2CustomCheckBox1.Checked = false;
                    guna2CustomCheckBox2.Checked = false;
                    
                }
                else
                {
                    if (lang.Equals("Anglais"))
                    {
                        MessagesShow to = new MessagesShow("No choice made ", "");
                    }
                    else
                    {
                        MessagesShow to = new MessagesShow("Aucun choix fait ", "");
                    }
                }

                if (verif1 == true)
                {
                    guna2comboBox1.Items.Clear();
                    guna2comboBox4.Visible = false;
                    guna2DateTimePicker4.Visible = false;
                    guna2CustomCheckBox1.Checked = false;
                    guna2Button60.Visible = false;
                    guna2Button250.Visible = false;

                    if (lang.Equals("Anglais"))
                    {
                        guna2comboBox1.Items.AddRange(new object[] {
                        " ",
                        "Daily",
                        "Weekly" });
                    }
                    else
                    {
                        guna2comboBox1.Items.AddRange(new object[] {
                        " ",
                        ValeurF[0],
                        ValeurF[1] });
                    }
                    //MessageBox.Show("Etape1");
                }
                if (verif2 == true)
                {
                    guna2comboBox3.Visible = false;
                    guna2DateTimePicker3.Visible = false;
                    guna2CustomCheckBox2.Checked = false;
                    label104.Text = "";
                    guna2comboBox2.Items.Clear();
                    guna2Button60.Visible = false;
                    guna2Button250.Visible = false;

                    if (lang.Equals("Anglais"))
                    {
                        guna2comboBox2.Items.AddRange(new object[] {
                        " ",
                        "Daily",
                        "Weekly" });
                    }
                    else
                    {
                        guna2comboBox2.Items.AddRange(new object[] {
                        " ",
                        ValeurF[0],
                        ValeurF[1] });
                    }
                    //MessageBox.Show("Etape2");
                }
            }
            catch (Exception ex)
            {
                /*if (lang.Equals("Anglais"))
                {
                    MessagesShow to = new MessagesShow("No Scheduled Scan. ", "");
                }
                else
                {
                    MessagesShow to = new MessagesShow("Aucune Analyse Programmée.", "");

                }*/
            }

        }
        public void EcrireFiche(List<string> Val, string fichier)
        {
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter(fichier);
                //Write a line of text
                foreach(string s in Val)
                {
                    sw.WriteLine(s);
                }
                //Write a second line of text
                //sw.WriteLine("From the StreamWriter class");
                //Close the file
                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }

        //lire et ecrire dans un fichier

        public string LireEtEcrireFichier(string dmde, string chemin)
        {
            // lire et ecrire dans un fichier.

            string str = "";

            if (dmde == "Ecrire")
            {
                // on ecris dans le fichier

                try
                {
                    //Pass the filepath and filename to the StreamWriter Constructor
                    StreamWriter sw = new StreamWriter(chemin);
                    //Write a line of text
                    sw.WriteLine("Application deja au demarrage...");
                    //Close the file
                    str = "Deja";
                    sw.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
                finally
                {
                    Console.WriteLine("Executing finally block.");
                }
            }
            else
            {
                // on lit le contenu d'un fichier
                //MessageBox.Show("toto = " + chemin);
                String line;
                try
                {
                    //Pass the file path and file name to the StreamReader constructor
                    StreamReader sr = new StreamReader(chemin);
                    //Read the first line of text
                    line = sr.ReadLine();
                    str = line;

                    sr.Close();
                    Console.ReadLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
                finally
                {
                    Console.WriteLine("Executing finally block.");
                }
            }

            return str;
        }
        private void guna2Button52_Click_1(object sender, EventArgs e)
        {
            //MessageBox.Show("SSAAAAA");
            if (guna2TextBox3.Text != null && guna2TextBox4.Text != null && guna2TextBox5.Text != null && guna2TextBox6.Text != null && guna2TextBox7.Text != null)
            {
                if (guna2TextBox3.Text.ToLower() == guna2TextBox4.Text.ToLower())
                {
                    var datas = new Dictionary<string, string>
                    {
                        {"Email", guna2TextBox3.Text.ToLower() },
                        {"Name", guna2TextBox5.Text.ToLower() },
                        {"Phone", guna2TextBox6.Text.ToLower() },
                        {"Message", guna2TextBox7.Text.ToLower() }
                    };

                    var dats = new FormUrlEncodedContent(datas);
                    var url = "https://keygen.drakashield.com/clientdatas";
                    var client = new HttpClient();
                    var response = client.PostAsync(url, dats);
                    string result = response.ToString();
                    Console.WriteLine("http response => " + result);
                    //MessageBox.Show("Thanks for your informations \n Admin will respond in 48h", " Client Complaint", MessageBoxButtons.OK);
                    MessagesShow to = new MessagesShow("Thanks for your informations \n Admin will respond in 48h","");
                }
                else
                {
                    //MessageBox.Show("Emails not the same please try again", " Client Complaint", MessageBoxButtons.OK);
                    MessagesShow to = new MessagesShow("Emails not the same please try again", "");
                }
            }
            else
            {
                //MessageBox.Show("Some information was not completed", " Client Complaint", MessageBoxButtons.OK);
                MessagesShow to = new MessagesShow("Some information was not completed", "");
            }
        }

        private void CompletfolderBrowserDialog_HelpRequest(object sender, EventArgs e)
        {

        }

        private void label71_Click(object sender, EventArgs e)
        {

        }

        private void label90_Click(object sender, EventArgs e)
        {

        }
        private void guna2DataGridView13_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView20_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button4_Click_1(object sender, EventArgs e)
        {

        }

        // changement de langue de l'application
        public void LangueA()
        {
            this.guna2GroupBox9.Text = "Update";
            this.title2.Text = "Solution";
            this.title1.Text = "Drakashield";
            this.title3.Text = "Register your product!!!";
            this.home.Text = "Home";
            this.guna2GradientButton1.Text = "Scan now";
            //this.guna2GradientButton1.Click += new
            this.label1.Text = "YOUR PC IS PROTECTED";
            this.scan.Text = "Scan";
            this.guna2HtmlLabel1.Text = "Base Directory : ";
            this.CompletFileRoute.Text = "Initiailisation...";
            this.label130.Text = "Files Classifications : ";
            this.label8.Text = "            00:00:00";
            this.label9.Text = "            Analysis Times";
            this.label6.Text = "   0";
            this.label7.Text = "   Total Objets";
            this.label7.Location = new System.Drawing.Point(255, 9);
            this.label5.Text = "0";
            this.label4.Text = "Malacious";
            this.complet_progressbar.Text = "guna2ProgressBar1";
            this.complet_cancelScanBtn.Text = "Stop";
            this.complet_pauseScanBtn.Text = "Pause";
            this.complet_runScanBtn.Text = "Start";
            this.complet_repertoireText.Text = "C:\\Users\\";
            this.personnalise.Text = "Custom Scan";
            this.label12.Text = "%";
            //this.label3.Location = new System.Drawing.Point(200, 77);
            this.label3.Text = "Initiailisation...";
            this.label16.Text = "Files Classifications : ";
            this.custom_folderPickerBtn.Text = "Select Folder";
            this.custom_folderPickerText.Text = "Path";            
            this.label8.Location = new System.Drawing.Point(540, 37);
            this.custom_dureeAnalyse.Text = "00:00:00";
            this.custom_dureeAnalyse.Location = new System.Drawing.Point(560, 37);
            this.label11.Text =             "            Analysis Times";
            this.custom_totalObject.Text = "   0";
            this.label13.Text = "   Total Objets";
            this.custom_detection.Text = "0";
            this.label15.Text = "Malacious";
            this.custom_progressBar.Text = "guna2ProgressBar2";
            this.custom_cancelScan.Text = "Stop";
            this.custom_pauseScan.Text = "Pause";
            this.custom_runScan.Text = "Start";
            this.guna2Button3.Text = "Custom Scan";
            this.guna2Button2.Text = "Full Scan";
            this.performance.Text = "Performance";
            this.system.Text = "Infos Système";
            this.label49.Text = "Operating System :";
            this.label48.Text = "Total Memory :";
            this.label18.Text = "label18";
            this.label19.Text = "Motherboard :";
            this.label20.Text = "SYSTEM INFORMATION";
            this.label47.Text = "DomainWorkgroup :";
            this.label21.Text = "label21";
            this.label46.Text = "User Name :";
            this.label22.Text = "label22";
            this.label45.Text = "Computer Name :";
            this.label44.Text = "Processor :";
            this.label23.Text = "label23";
            this.label43.Text = "Processor Load :";
            this.label25.Text = "label25";
            this.label42.Text = "Clock Speed :";
            this.label24.Text = "label24";
            this.label41.Text = "Number Of Cores :";
            this.label34.Text = "label34";
            this.label40.Text = "Architecture :";
            this.label35.Text = "label35";
            this.label39.Text = "Video Adapter :";
            this.label36.Text = "label36";
            this.label37.Text = "label37";
            this.label38.Text = "label38";
            this.labelOperatingSystem.Text = "label15";
            this.memoire.Text = "Memory Infos";
            this.reseau.Text = "Network";
            this.label77.Text = "label77";
            this.label26.Text = "label26";
            this.label27.Text = "Network Speed :";
            this.label33.Text = "label33";
            this.label32.Text = "label32";
            this.label31.Text = "label31";
            this.label30.Text = "label30";
            this.label29.Text = "label29";
            this.label28.Text = "label28";
            this.label50.Text = "label50";
            this.label51.Text = "label51";
            this.label52.Text = "label52";
            this.label53.Text = "label53";
            this.label54.Text = "label54";
            this.label55.Text = "label55";
            this.label56.Text = "label56";
            this.label57.Text = "label57";
            this.label58.Text = "label58";
            this.label59.Text = "IPV6 DNS Server :";
            this.label60.Text = "IPV6 Default Gateway : ";
            this.label61.Text = "Link-Local IPV6 Address :";
            this.label62.Text = "NetBIOS over TCPIP Enabled :";
            this.label63.Text = "IPV4 DNS Server :";
            this.label64.Text = "IPV4 WINS Server :";
            this.label65.Text = "IPV4 DHCP Server :";
            this.label66.Text = "IPV4 Default Gateway :";
            this.label67.Text = "Lease Expire :";
            this.label68.Text = "Lease Obtained :";
            this.label69.Text = "IPV4 SubMask :";
            this.label70.Text = "IPV4 Address :";
            this.label71.Text = "DHCP Enabled :";
            this.label72.Text = "Physical Address :";
            this.label73.Text = "Description :";
            this.label74.Text = "label74";
            this.label76.Text = "NETWORK CONNECTION DETAILS:";
            this.disque.Text = "Disk";
            this.guna2Button17.Text = "Systems Information";
            this.guna2Button16.Text = "Disk";
            this.guna2Button18.Text = "Network";
            this.guna2Button19.Text = "Memory Info";
            this.stabilite.Text = "Stability";
            this.programs.Text = "All Programs";
            this.restaure.Text = "restore point";
            this.label78.Text = "No restore point";
            this.label79.Text = "Restore point in creation";
            this.guna2Button14.Text = "Delete restore point";
            this.guna2Button20.Text = "Create a restore point";
            this.guna2Button20.Location = new System.Drawing.Point(55, 450);
            this.crashing.Text = "Crashing Programs";
            this.alerts.Text = "Event log alert";
            this.labelSystemCount.Text = "label5";
            this.label80.Text = "Application :";
            this.label81.Text = "System :";
            this.labelSecurityCount.Text = "label5";
            this.labelAppCount.Text = "label5";
            this.label82.Text = "Security :";
            this.guna2Button12.Text = "Restoration Point";
            this.guna2Button13.Text = "All Programs";
            this.guna2Button10.Text = "Event log alerts";
            this.guna2Button11.Text = "Crashing Programs event log alert";
            this.maintenance.Text = "Maintenance";
            this.corbeille.Text = "Basket";
            this.guna2Button28.Text = "Restore";
            this.guna2Button26.Text = "Delete";
            this.guna2Button27.Text = "Clear Trash";
            this.fichier.Text = "Temporary File";
            this.guna2Button22.Text = "Delete All";
            this.demarrage.Text = "Startup program";
            this.update.Text = "windows update";
            this.label92.Text = "label5";
            this.label91.Text = "label5";
            this.label90.Text = "label5";
            this.label88.Text = "Last Installation :";
            this.label87.Text = "Last Search :";
            this.label85.Text = "Windows Update :";
            this.label84.Text = "label5";
            this.label83.Text = "Total size :";
            this.guna2Button23.Text = "Download and install";
            this.label86.Text = "Nomber of element :";
            this.label89.Text = "label5";
            this.guna2Button24.Text = "Temporaly Files";
            this.guna2Button25.Text = "Trash";
            this.guna2Button15.Text = "Windows Update";
            this.guna2Button21.Text = "Startup Programs";
            this.historique.Text = "historical";
            this.guna2Button53.Text = "Manage safe";
            this.guna2Button35.Text = "Report as safe";
            //this.guna2Button35.Size = new System.Drawing.Size(165, 29);
            this.guna2Button30.Text = "Delete";
            this.guna2Button30.Size = new System.Drawing.Size(185, 29);
            this.label93.Text = "No scans available";
            this.guna2Button29.Text = "Open Report";
            this.quarant.Text = "Quarantine";
            this.guna2Button32.Text = "Select All";
            this.guna2Button33.Text = "Delete";
            this.label94.Text = "No items in quarantine";
            this.guna2Button34.Text = "Restore";
            this.securite.Text = "Security";
            this.guna2Button1.Text = "Objectionnale Website";
            this.guna2Button46.Text = "Objectionable website";
            this.labelFirewallStatut.Text = "label5";
            this.labelFirewallName.Text = "label5";
            this.label105.Text = "Signature :";
            this.label106.Text = "Enabled :";
            this.label107.Text = "Product Name :";
            this.antivirus.Text = "Antivirus";
            this.wifi.Text = "wifi password";
            this.labelInfo.Text = "Click on Scan to show stored wifi password";
            this.password.Text = "Passwords";
            this.label95.Text = "0";
            this.label98.Text = "Stored password :";
            this.guna2Button42.Text = "Scan";
            this.control.Text = "Parental Control";
            this.guna2Button41.Text = "Delete";
            this.guna2Button40.Text = "New";
            this.guna2Button39.Text = "Add";
            this.website.Text = "Objectionable website";
            this.guna2Button47.Text = "Delete";
            this.guna2Button45.Text = "Parental Control";
            this.guna2Button36.Text = "Saved Browser Password";
            this.guna2Button37.Text = "Wi-Fi Password";
            this.guna2Button43.Text = "Antivirus";
            this.activate.Text = "Activate key";
            this.linkLabel1.Text = "https://drakashield.com";
            this.guna2Button48.Text = "Enable";
            this.label96.Text = "Draka Antivirus Product Registration";
            this.label99.Text = "Enter registration key : ";
            this.label97.Text = "I don't have an activation key : ";
            this.setting.Text = "Settings";
            this.guna2GroupBox13.Text = "Viral Basis";
            this.label123.Text = "Manually";
            this.guna2CustomCheckBox19.Text = "Enable";
            this.label124.Text = "Automatic";
            this.guna2CustomCheckBox20.Text = "Enable";
            this.label125.Text = "Now";
            //this.guna2GroupBox12.Text = "Viral basis";
            this.guna2CustomCheckBox16.Text = "Enable";
            this.label121.Text = "Signature";
            this.guna2CustomCheckBox17.Text = "Enable";
            this.label122.Text = "Viral";
            this.guna2Button250.Text = "Register";
            this.guna2Button60.Text = "Register";
            this.guna2GroupBox4.Text = "Security and Language";
            this.guna2GroupBox6.Text = "AutoScan";
            this.guna2CustomCheckBox4.Text = "active";
            this.label111.Text = "Antivirus";
            this.guna2GroupBox5.Text = "Language";
            this.guna2CustomCheckBox6.Text = "Enable";
            this.label110.Text = "English";
            this.guna2CustomCheckBox8.Text = "Enable";
            this.label113.Text = "French";
            this.guna2GroupBox7.Text = "Quarantine";
            this.guna2CustomCheckBox7.Text = "Enable";
            this.label112.Text = "Manually";
            this.guna2CustomCheckBox9.Text = "Enable";
            this.label114.Text = "Automatic";
            this.guna2GroupBox8.Text = "Parental control";
            this.guna2CustomCheckBox10.Text = "Enable";
            this.label115.Text = "Disable";
            this.guna2CustomCheckBox11.Text = "Enable";
            this.label116.Text = "Enable";
            this.guna2GroupBox1.Text = "Scan";
            this.guna2GroupBox2.Text = "Full Scan";
            this.guna2CustomCheckBox1.Text = "Enable";
            this.label100.Text = "Scan :";
            this.label101.Text = "Select date :";
            this.guna2GroupBox3.Text = "Partial Scan";
            this.guna2CustomCheckBox2.Text = "Enable";
            this.label102.Text = "Scan :";
            this.label103.Text = "Select date : ";
            this.label104.Text = "Path";
            this.guna2Button49.Text = "Select file";
            this.aide.Text = "Help";
            this.guna2Button52.Text = "Send";
            this.guna2Button51.Text = "Select file";
            this.label117.Text = "Path";
            this.label129.Text = "Attach latest scan report and error information";
            this.label128.Text = "Message";
            this.label127.Text = "Attachment";
            this.label126.Text = "Phone";
            this.label120.Text = "Full name";
            this.label119.Text = "Password";
            this.label118.Text = "Email";
            this.ManageSafe.Text = "ManageSafe";
            this.guna2Button55.Text = "Delete";
            this.guna2Button56.Text = "Select all";
            this.guna2Button31.Text = "Select all";
            this.label150.Text = "No elements in repport as safe";
            this.label150.Location = new System.Drawing.Point(260, 200);
            this.guna2Button54.Text = "Restore";
            this.guna2CustomCheckBox5.Text = "Enable";
            this.label109.Text = "Real time";
            this.guna2CustomCheckBox3.Text = "Enable";
            this.label108.Text = "Anti Malware";
            this.dataGridViewTextBoxColumn133.HeaderText = "original path";
            this.dataGridViewTextBoxColumn134.HeaderText = "File size";
            this.buyNowBtn.Text = "Buy";
            this.guna2TextBox88.PlaceholderText = "Congratulations, Your Product is Activated";
            this.guna2TextBox888.PlaceholderText = "Congratulations, Your Product is Activated";
            this.guna2TextBox1111.PlaceholderText = "Oops your product activation is complete";
            this.guna2TextBox1.PlaceholderText = "Enter Url...Example : https://test.com ...";
        }
        public void LangueF()
        {
            //label1.Location = new System.Drawing.Point(295, 340); --> 
            //this.label94.Location = new System.Drawing.Point(302, 190);
            this.guna2TextBox1.PlaceholderText = "Enter Url...Example : https://test.com ...";
            this.guna2TextBox888.PlaceholderText = "Bravo vous avez bien acitvé DrakaSlied";
            this.guna2TextBox88.PlaceholderText = "Bravo vous avez bien acitvé DrakaSlied";
            this.guna2TextBox1111.PlaceholderText = "Oups, l'activation de votre produit est terminée";
            this.buyNowBtn.Text = "Acheter";
            this.label42.Location = new System.Drawing.Point(120, 340);            
            this.label49.Location = new System.Drawing.Point(100, 62);            
            this.label46.Location = new System.Drawing.Point(150, 127);            
            this.label43.Location = new System.Drawing.Point(105, 366);            
            this.label47.Location = new System.Drawing.Point(120, 155);            
            this.label39.Location = new System.Drawing.Point(150, 400);            
            this.label19.Location = new System.Drawing.Point(185, 215);            
            this.title2.Text = "Solution";//"";
            this.title1.Text = "Drakashield";//"";
            this.title3.Text = "Enregistrez votre produit !!!";//"";
            this.home.Text = "Acceuil";//"";
            this.guna2GradientButton1.Text = "Scan Immédiat";//"";            
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Text = "VOTRE PC EST PROTÉGÉ";//"";
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.scan.Text = "Scan";//"";
            this.guna2HtmlLabel1.Text = "Répertoire de base";//" : ";
            this.CompletFileRoute.Text = "Initiailisation";//"...";
            //this.CompletFileRoute.Location = new System.Drawing.Point(210, 77);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.label130.Text = "Classement des fichiers : ";
            this.label130.Location = new System.Drawing.Point(3, 73);
            this.label8.Text = "00:00:00";
            this.label9.Text = "Temps d'analyse";//"";
            this.label6.Text = "0";
            this.label7.Text = "Total Objets";//"";
            this.label13.Text = "Total Objets";//"";
            this.label5.Text = "0";
            this.label4.Text = "Malicieux";//"";
            this.complet_progressbar.Text = "guna2ProgressBar1";
            this.complet_cancelScanBtn.Text = "Arrêt";//"";
            this.complet_pauseScanBtn.Text = "Pause";//"";
            this.complet_runScanBtn.Text = "Démarrer";//"";
            this.complet_repertoireText.Text = "   C:\\Users\\";
            this.complet_repertoireText.Location = new System.Drawing.Point(131, 365);
            this.personnalise.Text = "Scan Personnalisé";//"";
            this.label12.Text = "%";
            this.label3.Text = "Initiailisation...";
            //this.label3.Location = new System.Drawing.Point(147, 77);
            this.label16.Text = "Classement des fichiers : ";
            this.custom_folderPickerBtn.Text = "Sélectionner le dossier";//"";
            this.custom_folderPickerText.Text = "Chemin";
            this.custom_dureeAnalyse.Text = "00:00:00";
            this.label11.Text = "Temps d'analyse";//"";
            this.custom_totalObject.Text = "0";
            this.label13.Text = "Total Objets";//"";
            this.custom_detection.Text = "0";
            this.label15.Text = "Malicieux";//"";
            this.custom_progressBar.Text = "guna2ProgressBar2";//"";
            this.custom_cancelScan.Text = "Arrêt";//"";
            this.custom_pauseScan.Text = "Pause";//"";
            this.custom_runScan.Text = "Démarrer";//"Start";
            this.guna2Button3.Text = "Scan personnalisé";//"";
            this.guna2Button2.Text = "Scan complet";//"";
            this.performance.Text = "Performance";//"";
            this.system.Text = "Infos Système";//"";
            this.label49.Text = "Système d'Exploitation :";//" :";
            this.label48.Text = "Mémoire totale :";//" :";
            this.label18.Text = "label18";
            this.label19.Text = "Carte mère :";
            this.label20.Text = "INFORMATIONS SYSTEMES";
            this.label47.Text = "Domaine de Travail :";
            this.label21.Text = "label21";
            this.label46.Text = "Nom Utilisateur :";
            this.label22.Text = "label22";
            this.label45.Text = "Nom Ordinateur :";
            this.label44.Text = "Processeur :";
            this.label23.Text = "label23";
            this.label43.Text = "Charge du processeur :";
            this.label25.Text = "label25";
            this.label42.Text = "Vitesse de l'horloge :";
            this.label24.Text = "label24";
            this.label41.Text = "Numbre de coeurs :";
            this.label34.Text = "label34";
            this.label40.Text = "Architecture :";
            this.label35.Text = "label35";
            this.label39.Text = "Carte graphique :";
            this.label36.Text = "label36";
            this.label37.Text = "label37";
            this.label38.Text = "label38";            
            this.labelOperatingSystem.Text = "label15";            
            this.memoire.Text = "Informations mémoire";//"";
            this.reseau.Text = "Réseau";//"";
            this.label77.Text = "label77";
            this.label26.Text = "label26";
            this.label27.Text = "Vitesse du réseau :"; //"";
            this.label33.Text = "label33";
            this.label32.Text = "label32";
            this.label31.Text = "label31";
            this.label30.Text = "label30";
            this.label29.Text = "label29";
            this.label28.Text = "label28";
            this.label50.Text = "label50";
            this.label51.Text = "label51";
            this.label52.Text = "label52";
            this.label53.Text = "label53";
            this.label54.Text = "label54";
            this.label55.Text = "label55";
            this.label56.Text = "label56";
            this.label57.Text = "label57";
            this.label58.Text = "label58";
            this.label59.Text = "Serveur DNS IPV6 :";
            this.label59.Location = new System.Drawing.Point(50, 392);
            this.label60.Text = "Passerelle par défaut IPV6 : ";
            this.label60.Location = new System.Drawing.Point(152, 364);
            this.label61.Text = "Adresse IPV6 lien-local :";
            this.label61.Location = new System.Drawing.Point(172, 344);
            this.label62.Text = "NetBIOS sur TCPIP activé :";
            this.label62.Location = new System.Drawing.Point(157, 323);
            this.label63.Text = "Serveur DNS IPV4 :";
            this.label63.Location = new System.Drawing.Point(205, 268);
            this.label64.Text = "Serveur WINS IPV4 :";
            this.label64.Location = new System.Drawing.Point(197, 298);
            this.label65.Text = "Serveur DHCP IPV4 :";
            this.label65.Location = new System.Drawing.Point(195, 248);
            this.label66.Text = "Passerelle par défaut IPV4 :";
            this.label66.Location = new System.Drawing.Point(153, 220);                           
            
            this.label75.Location = new System.Drawing.Point(86, 55);
            this.label59.Location = new System.Drawing.Point(215, 392);
            this.label67.Text = "Expiration du bail :";
            this.label67.Location = new System.Drawing.Point(208, 200);
            this.label68.Text = "Bail obtenu :";
            this.label68.Location = new System.Drawing.Point(250, 181);
            this.label69.Text = "Masque de sous-réseau IPV4 :";
            this.label69.Location = new Point(136, 153); 
            this.label70.Text = "Adresse IPV4 :";
            this.label71.Text = "DHCP activé :";
            this.label71.Location = new System.Drawing.Point(243, 114);
            this.label72.Text = "Adresse physique :";
            this.label72.Location = new Point(210, 95);
            this.label73.Text = "Description :";
            this.label74.Text = "label74";
            this.label76.Text = "DÉTAILS DE LA CONNEXION AU RÉSEAU :";
            this.disque.Text =  "Disque";
            this.guna2Button17.Text = "Informations Système";
            this.guna2Button16.Text = "Disque"; //"";
            this.guna2Button18.Text = "Réseau"; //"";
            this.guna2Button19.Text = "Informations Mémoire"; //"";
            this.stabilite.Text = "Stabilité"; //"";
            this.programs.Text = "Tout les programmes";
            this.restaure.Text = "Point de restauration";
            this.label78.Text = "Pas de point de restoration";
            this.label79.Text = "Point de restoration en creation";
            this.guna2Button14.Text = "Supprimer le point de restauration";
            this.guna2Button20.Text = "Créer un point de restauration";
            this.guna2Button20.Location = new System.Drawing.Point(50, 450);
            this.crashing.Text = "Programmes de plantage";
            this.alerts.Text = "Journal des événements"; //"";
            this.labelSystemCount.Text = "label5";
            this.label80.Text = "Application :";
            this.label81.Text = "Systéme :";
            this.labelSecurityCount.Text = "label5";
            this.labelAppCount.Text = "label5";
            this.label82.Text = "Sécurité"; //" :";
            this.guna2Button12.Text = "Point de restauration"; //"";
            this.guna2Button13.Text = "Tous les Programmes"; //"All Programs";
            this.guna2Button10.Text = "Journal des événements"; //"Event log alerts";
            this.guna2Button11.Text = "Journal programmes en panne"; //"";
            this.maintenance.Text = "Maintenance";
            this.corbeille.Text = "Corbeille";
            this.guna2Button28.Text = "Restaurer"; //"";
            this.guna2Button26.Text = "Supprimer"; //"Delete";
            this.guna2Button27.Text = "Vider Corbeille"; //"";
            this.fichier.Text = "Fichier temporaire";
            this.guna2Button22.Text = "Supprimer tout"; //"";
            //this.guna2Button22.Size = new System.Drawing.Size(160, 32);
            this.demarrage.Text = "Programme au demarrage";
            this.update.Text = "Mise à jour windows";
            this.label92.Text = "label5";
            this.label91.Text = "label5";
            this.label90.Text = "label5";
            this.label88.Text = "Dernière installation"; //":";
            this.label87.Text = "Dernière recherche"; //" :";
            this.label85.Text = "Mise à jour Windows"; //" :";
            this.label84.Text = "label5";
            this.label83.Text = "Taille totale"; //":";
            this.guna2Button23.Text = "Télécharger et installer";
            this.label86.Text = "Nombre de Coeurs :"; //"";
            this.label89.Text = "label5";
            this.guna2Button24.Text = "Fichiers temporaires"; //"";
            this.guna2Button25.Text = "Corbeille"; //"";
            this.guna2Button15.Text = "Mise à jour Windows"; //"Windows Update";
            this.guna2Button21.Text = "Programmes de démarrage"; //"";
            this.historique.Text =    "Historique";
            this.guna2Button53.Text = "Sûreté"; //"";
            this.guna2Button35.Text = "Rendre Sûr"; //"";
            this.guna2Button30.Text = "Supprimer"; //"Delete";
            this.label93.Text = "Aucun scan disponible";
            this.guna2Button29.Text = "Ouvrir le rapport"; //"";
            this.quarant.Text =       "Quarantaine";
            this.guna2Button32.Text = "Selectionner Tout"; //"Select All";
            this.guna2Button33.Text = "Supprimer"; //"Delete";
            this.label94.Text =       "Auccun élémént en quarantaine";
            this.guna2Button34.Text = "Restaurer"; //"Restore";
            this.securite.Text =      "Sécurité";
            this.guna2Button1.Text = "Objection Web"; //"";
            this.guna2Button46.Text = "Objection Web"; //"Objectionable website";
            this.labelFirewallStatut.Text = "label5";
            this.labelFirewallName.Text = "label5";
            this.label105.Text =     "Signature :";
            this.label106.Text =     "Activer :";
            this.label107.Text = "Nom du produit :"; //"Product Name :";
            this.antivirus.Text = "Antivirus";
            this.wifi.Text =      "Mot de passe Wi-Fi";
            this.labelInfo.Text = "Cliquez sur Scan pour afficher le mot de passe wifi stocké"; //"";
            this.password.Text =  "Mots de passe";
            this.label95.Location = new System.Drawing.Point(240, 30);
            this.label95.Text = "0";
            this.label98.Text = "Sauvegarde sur navigateur : "; //"";
            this.guna2Button42.Text = "Scan"; //"";
            this.control.Text =       "Contrôl parental";
            this.guna2Button41.Text = "Supprimer"; //"Delete";
            this.guna2Button40.Text = "Nouveau"; //"New";
            this.guna2Button39.Text = "Ajouter"; //"Add";
            this.website.Text = "Objection Web"; //"Objectionable website";
            this.guna2Button47.Text = "Supprimer";
            this.guna2Button45.Text = "Contrôl parental"; //"Parental Control";
            this.guna2Button36.Text = "Mots de passe sur navigateur"; //"";
            this.guna2Button37.Text = "Mot de passe Wifi"; //"Wi-Fi Password";
            this.guna2Button43.Text = "Antivirus";
            this.activate.Text = "Clé Activation"; //"";
            this.linkLabel1.Text = "https://drakashield.com";
            this.guna2Button48.Text = "Activer";
            this.label96.Text = "Enregistrement du produit Draka antivirus";
            this.label99.Text = "Entrer la clé d\'enregistrement : ";
            this.label97.Text = "Je n\'ai pas de clé d\'activation : ";
            this.setting.Text = "Paramètres";
            this.guna2GroupBox13.Text = "Base Virale";
            this.label123.Text = "Manuelle";
            this.guna2CustomCheckBox19.Text = "active";
            this.label124.Text = "Automatique";
            this.guna2CustomCheckBox20.Text = "active";
            this.label125.Text = "Maintenant";
            //this.guna2GroupBox12.Text = "Base virale";
            this.guna2CustomCheckBox16.Text = "active";
            this.label121.Text = "Signature";
            this.guna2CustomCheckBox17.Text = "active";
            this.label122.Text = "Virale";
            this.guna2Button250.Text = "Enregistrer";
            this.guna2GroupBox4.Text = "Sécurité et Langue";
            this.guna2GroupBox6.Text = "Scan Auto"; //"";
            this.guna2Button56.Text = "Selectionner Tout";
            this.guna2CustomCheckBox4.Text = "active";
            this.label111.Text = "Antivirus";
            this.guna2GroupBox5.Text = "Langue";
            this.guna2CustomCheckBox6.Text = "active";
            this.label110.Text = "Anglais";
            this.guna2CustomCheckBox8.Text = "active";
            this.label113.Text = "Français";
            this.guna2GroupBox7.Text = "Quarantaine";
            this.guna2CustomCheckBox7.Text = "active";
            this.label112.Text = "Manuelle";
            this.guna2CustomCheckBox9.Text = "active";
            this.label114.Text = "Automatique";
            this.guna2GroupBox8.Text = "Contrôl parental";
            this.guna2CustomCheckBox10.Text = "active";
            this.label115.Text = "Désactiver";
            this.guna2CustomCheckBox11.Text = "active";
            this.label116.Text = "Activer";
            this.guna2GroupBox1.Text = "Scan";
            this.guna2GroupBox2.Text = "Scan Complet";
            this.guna2CustomCheckBox1.Text = "active";
            this.label100.Text = "Scan :";
            this.label100.Location = new Point(8, 95);
            this.label101.Text = "Période :";
            this.label101.Location = new System.Drawing.Point(9, 40);
            this.guna2GroupBox3.Text = "Scan Partiel";
            this.guna2CustomCheckBox2.Text = "active";
            this.label102.Text = "Scan :";
            this.label103.Text = "Période : ";
            this.label104.Text = "Chemin";
            this.guna2Button49.Text = "Choix Fichier";
            this.aide.Text =     "Aide";
            this.guna2Button52.Text = "Envoyer";
            this.guna2Button51.Text = "Sélectionner fichier";
            this.label117.Text =      "Chemin";
            this.label129.Text =      "Annexer le dernier rapport d\'analyse et les informations sur l\'erreur";
            this.label128.Text =      "Message";
            this.label127.Text =      "Pièce jointe";
            this.label126.Text =      "Téléphone";
            this.label126.Location = new System.Drawing.Point(160, 180);
            this.label120.Text =      "Nom et Prénom";
            this.label120.Location = new System.Drawing.Point(130, 118);
            this.label119.Text =      "Mot de passe";
            this.label119.Location = new System.Drawing.Point(139, 101);
            this.label118.Text =      "Email";
            this.ManageSafe.Text = "Gérer Les Sûr"; //"";
            this.guna2Button55.Text = "Supprimer"; //"Delete";
            //this.guna2Button56.Text = "Tout Selectionner"; //"Select All";
            this.guna2Button31.Text = "Selectionner tout";
            this.label150.Text = "Aucun élément dans le rapport comme sûr"; //"";
            this.label150.Location = new System.Drawing.Point(250, 200);
            this.guna2Button54.Text = "Restorer"; //"Restore";
            this.guna2CustomCheckBox5.Text = "active";
            this.label109.Text = "Temps réel";
            this.guna2CustomCheckBox3.Text = "active";
            this.label108.Text = "Anti Malware";
            this.label150.Size = new System.Drawing.Size(252, 39);
            this.label150.Location = new System.Drawing.Point(200, 307);
            this.drive_type.HeaderText = "Type de lecteur";
            this.volume_label.HeaderText = "Étiquette de volume";
            this.file_system.HeaderText = "Système de fichiers";
            this.free_space.HeaderText = "Total Espace libre";
            this.name.HeaderText = "Nom";
            this.total_size.HeaderText = "Taille totale";
            this.dataGridViewTextBoxColumn11.HeaderText = "Fichiers de la corbeille";
            this.dataGridViewTextBoxColumn12.HeaderText = "Listes des fichiers temporels";
            this.dataGridViewTextBoxColumn13.HeaderText = "Nom";
            this.user.Name = "Utilisateur";
            this.dataGridViewTextBoxColumn14.HeaderText = "Titre";
            this.dataGridViewTextBoxColumn7.HeaderText = "Taille";
            this.dataGridViewTextBoxColumn9.HeaderText = "Date";
            this.dataGridViewTextBoxColumn999.HeaderText = "Date";
            this.virusdetect.HeaderText = "Virus Détectés";
            this.virusdetect1.HeaderText = "Mise a jour base virale";
            this.type.HeaderText = "Type de Scan";
            this.type.HeaderText = "Statut";
            this.dataGridViewTextBoxColumn10.HeaderText = "Itinéraire";
            this.date2.HeaderText = "Date";
            this.detection.HeaderText = "Detection";
            this.dataGridViewTextBoxColumn16.HeaderText = "Afficher un nom";
            this.guid.HeaderText = "GUID";
            this.product.HeaderText = "Chemin du produit";
            this.dataGridViewTextBoxColumn17.HeaderText = "Interface";
            this.ssid.HeaderText = "SSID";
            this.auth.HeaderText = "Authentication";
            this.pwd.HeaderText = "Mot de passe";
            this.dataGridViewTextBoxColumn21.HeaderText = "Url";
            this.user_name.HeaderText = "Nom Utilisateur";
            this.pwds.HeaderText = "Mot de passe";
            this.browser.HeaderText = "Navigateur";
            this.dataGridViewTextBoxColumn22.HeaderText = "Numéro";
            this.dataGridViewTextBoxColumn15.HeaderText = "Url";
            this.dataGridViewTextBoxColumn23.HeaderText = "Statut";
            this.dataGridViewTextBoxColumn24.HeaderText = "Date";
            this.dataGridViewTextBoxColumn26.HeaderText = "Url";
            this.dataGridViewTextBoxColumn27.HeaderText = "Statut";
            this.dataGridViewTextBoxColumn28.HeaderText = "Date";
            //***************************************************
            this.label93.Location = new System.Drawing.Point(350, 209);
            this.label150.Location = new System.Drawing.Point(200, 200);
            //***************************************************
            this.Number_Occurences.HeaderText = "NomJournal";
            this.LogFile.HeaderText = "Nombre";
            this.Size.HeaderText = "Chemin_fichier_journal";
            this.Actions.HeaderText = "Taille max";
            this.Creation_Date.HeaderText = "Paramètres_débordement";
            this.Creationdate.HeaderText = "Date";
            this.Number_Occurences.HeaderText = "NomJournal";
            this.LogFile.HeaderText = "Nombre";
            this.Size.HeaderText = "Chemin_fichier_journal";
            this.Actions.HeaderText = "Taille max";
            this.Creation_Date.HeaderText = "Paramètres_débordement";
            this.Creationdate.HeaderText = "Date";
            this.dataGridViewTextBoxColumn8.HeaderText = "Journaux";
            this.OverflowAction.HeaderText = "Action de débordement";
            this.Numbers.HeaderText = "Nombre_entrées";
            this.dataGridViewTextBoxColumn4.HeaderText = "Taille";
            this.dataGridViewTextBoxColumn5.HeaderText = "Type";
            this.dataGridViewTextBoxColumn6.HeaderText = "Manufacturer";
            this.dataGridViewTextBoxColumn3.HeaderText = "Vitesse";
            this.dataGridViewTextBoxColumn18.HeaderText = "Nom Apps";
            this.dataGridViewTextBoxColumn19.HeaderText = "Editeur Apps";
            this.dataGridViewTextBoxColumn20.HeaderText = "Version Apps";
            this.dataGridViewTextBoxColumn11.HeaderText = "Fichiers de la corbeille";

            //
            // Mise à zéro
            //
            this.guna2comboBox1.Items.Clear();
            this.guna2comboBox4.Items.Clear();
            this.guna2comboBox3.Items.Clear();
            this.guna2comboBox2.Items.Clear();


            this.guna2comboBox2.Items.AddRange(new object[] {
            " ",
            ValeurF[0],
            ValeurF[1]});

            this.guna2comboBox3.Items.AddRange(new object[] {
            " ",
            ValeurFS[0],
            ValeurFS[1],
            ValeurFS[2],
            ValeurFS[3],
            ValeurFS[4],
            ValeurFS[5],
            ValeurFS[6]});

            
            this.guna2comboBox1.Items.AddRange(new object[] {
            " ",
            ValeurF[0],
            ValeurF[1]});

            this.guna2comboBox4.Items.AddRange(new object[] {
            " ",
            ValeurFS[0],
            ValeurFS[1],
            ValeurFS[2],
            ValeurFS[3],
            ValeurFS[4],
            ValeurFS[5],
            ValeurFS[6]});
        }

        // Envoyer le dernier repport

        public void OuvrirR()
        {
            Historicsloading7();
            int i1 = 0;
            Int32 selectedCellCount = guna2DataGridView13.GetCellCount(DataGridViewElementStates.Selected);
            //MessageBox.Show("Taille : " + selectedCellCount);

            if (selectedCellCount > 0)
            {
                int indice = selectedCellCount;
                i1 = indice - 1;
                string date = (string)guna2DataGridView13[0, i1].Value;
                //string sql8 = "select date, duree, TotalVirus, totalAna, TypeScan, Etat from HistoryScan where Id= " + date + ";";
                string sql8 = "select * from HistoryScan where Id= " + i1 + ";";
                
                try
                {
                    Object[] dburl = db1.searchData(sourceFile, sql8);
                   
                    if (dburl != null)
                    {
                        RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows NT\\CurrentVersion");
                        string pathName = (string)registryKey.GetValue("productName");
                        string strr = "";
                        string strrr = "";
                        ManagementObjectSearcher mos = new ManagementObjectSearcher(@"root\CIMV2", @"SELECT * FROM Win32_ComputerSystem");
                        foreach (ManagementObject mo in mos.Get())
                        {
                            strr = mo["Workgroup"].ToString();
                        }

                        ManagementObjectSearcher myProcessorObject = new ManagementObjectSearcher("select * from Win32_Processor");

                        foreach (ManagementObject obj in myProcessorObject.Get())
                        {
                            strrr = obj["Name"].ToString();
                        }

                        string[] str = new string[]
                        {
                            "Product Name         : Draka Shiel Antivirus",
                            "Analysis status      : " + dburl[6],
                            "Date of analysis     : " + dburl[1],
                            "Type of analysis     : " + dburl[5],
                            "Analysis Duration    : " + dburl[2],
                            "Scanned objects      : " + dburl[4],
                            "Viruses detected     : " + dburl[3],
                            "Object excluded      : 00",
                            "Auto send            : No",
                            "Operating system     : " + pathName,
                            "Processor            : " + strrr,
                            "Domain information   : " + strr,
                            "scanner directory    : " + dburl[7],
                            "CUID                 : "
                        };
                        // ecrire dans le fichier du rapport de scan
                        using (StreamWriter sw = new StreamWriter(OuvrirRapport))
                        {
                            foreach (string s in str)
                            {
                                sw.WriteLine(s);
                            }
                        }


                    }
                    else
                    {
                        if (lang.Equals("Anglais"))
                        {
                            MessagesShow to = new MessagesShow("No data available", "");
                        }
                        else
                        {
                            MessagesShow to = new MessagesShow("Aucne donnée disponible", "");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessagesShow to = new MessagesShow(ex.Message, "");
                }
            }
            else
            {
                if (lang.Equals("Anglais"))
                {
                    MessagesShow to = new MessagesShow("No scan history performed", "");
                }
                else
                {
                    MessagesShow to = new MessagesShow("Aucun historique de scan effectué", "");
                }
            }
        }

        // les hover button et les mousshover        

        private void Load_Up(object sender, MouseEventArgs e)
        {
            if (variable.Equals("CustomScan"))
            {
                guna2Button3.ForeColor = System.Drawing.Color.White;
                guna2Button3.FillColor = System.Drawing.Color.LightSteelBlue;
            }
            else if (variable.Equals("ScanComplet") || variable.Equals("fullScan"))
            {
                guna2Button2.ForeColor = System.Drawing.Color.White;
                guna2Button2.FillColor = System.Drawing.Color.LightSteelBlue;
            }
            else if (variable.Equals("InfoSysteme"))
            {
                guna2Button17.ForeColor = System.Drawing.Color.White;
                guna2Button17.FillColor = System.Drawing.Color.LightSteelBlue;
            }
            else if (variable.Equals("Disk"))
            {
                guna2Button16.ForeColor = System.Drawing.Color.White;
                guna2Button16.FillColor = System.Drawing.Color.LightSteelBlue;
            }
            else if (variable.Equals("Reseau"))
            {
                guna2Button18.ForeColor = System.Drawing.Color.White;
                guna2Button18.FillColor = System.Drawing.Color.LightSteelBlue;
            }
            else if (variable.Equals("infomémoire"))
            {
                guna2Button19.ForeColor = System.Drawing.Color.White;
                guna2Button19.FillColor = System.Drawing.Color.LightSteelBlue;
            }
            else if (variable.Equals("Elogs"))
            {
                guna2Button10.ForeColor = System.Drawing.Color.White;
                guna2Button10.FillColor = System.Drawing.Color.LightSteelBlue;
            }
            else if (variable.Equals("Crtl"))
            {
                guna2Button11.ForeColor = System.Drawing.Color.White;
                guna2Button11.FillColor = System.Drawing.Color.LightSteelBlue;
            }
            else if (variable.Equals("RestorPoint"))
            {
                guna2Button12.ForeColor = System.Drawing.Color.White;
                guna2Button12.FillColor = System.Drawing.Color.LightSteelBlue;
            }
            else if (variable.Equals("Program"))
            {
                guna2Button13.ForeColor = System.Drawing.Color.White;
                guna2Button13.FillColor = System.Drawing.Color.LightSteelBlue;
            }
            else if (variable.Equals("WindowsUpdate"))
            {
                guna2Button15.ForeColor = System.Drawing.Color.White;
                guna2Button15.FillColor = System.Drawing.Color.LightSteelBlue;
            }
            else if (variable.Equals("StartupPrograms"))
            {
                guna2Button21.ForeColor = System.Drawing.Color.White;
                guna2Button21.FillColor = System.Drawing.Color.LightSteelBlue;
            }
            else if (variable.Equals("TemporalyFiles"))
            {
                guna2Button24.ForeColor = System.Drawing.Color.White;
                guna2Button24.FillColor = System.Drawing.Color.LightSteelBlue;
            }
            else if (variable.Equals("Trash"))
            {
                guna2Button25.ForeColor = System.Drawing.Color.White;
                guna2Button25.FillColor = System.Drawing.Color.LightSteelBlue;
            }
            else if (variable.Equals("Objectwebsite"))
            {
                guna2Button46.ForeColor = System.Drawing.Color.White;
                guna2Button46.FillColor = System.Drawing.Color.LightSteelBlue;
            }
            else if (variable.Equals("ParentalControl"))
            {
                guna2Button45.ForeColor = System.Drawing.Color.White;
                guna2Button45.FillColor = System.Drawing.Color.LightSteelBlue;
            }
            else if (variable.Equals("SavBrowser"))
            {
                guna2Button36.ForeColor = System.Drawing.Color.White;
                guna2Button36.FillColor = System.Drawing.Color.LightSteelBlue;
            }
            else if (variable.Equals("WiFiPassword"))
            {
                guna2Button37.ForeColor = System.Drawing.Color.White;
                guna2Button37.FillColor = System.Drawing.Color.LightSteelBlue;
            }
            else if (variable.Equals("AV"))
            {
                guna2Button43.ForeColor = System.Drawing.Color.White;
                guna2Button43.FillColor = System.Drawing.Color.LightSteelBlue;
            }
            else if (variable.Equals("Buuurt"))
            {
                guna2Button1.ForeColor = System.Drawing.Color.White;
                guna2Button1.FillColor = System.Drawing.Color.LightSteelBlue;
            }
            /*else if (variable.Equals("fullScan"))
            {
                guna2Button2.ForeColor = System.Drawing.Color.White;
                guna2Button2.FillColor = System.Drawing.Color.LightSteelBlue;
            }*/
        }
        private void LoadDown(object sender, EventArgs e)
        {
            if (variable.Equals("CustomScan"))
            {
                this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(225)))));
            }
            else if (variable.Equals("ScanComplet") || variable.Equals("fullScan"))
            {
                this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(225)))));
            }
            else if (variable.Equals("InfoSysteme"))
            {
                this.guna2Button17.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(225)))));
            }
            else if (variable.Equals("Disk"))
            {
                this.guna2Button16.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(225)))));
            }
            else if (variable.Equals("Reseau"))
            {
                this.guna2Button18.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(225)))));
            }
            else if (variable.Equals("infomémoire"))
            {
                this.guna2Button19.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(225)))));
            }
            else if (variable.Equals("Elogs"))
            {
                this.guna2Button10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(225)))));
            }
            else if (variable.Equals("Crtl"))
            {
                this.guna2Button11.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(225)))));
            }
            else if (variable.Equals("RestorPoint"))
            {
                this.guna2Button12.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(225)))));
            }
            else if (variable.Equals("Program"))
            {
                this.guna2Button13.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(225)))));
            }
            else if (variable.Equals("WindowsUpdate"))
            {
                this.guna2Button15.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(225)))));
            }
            else if (variable.Equals("StartupPrograms"))
            {
                this.guna2Button21.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(225)))));
            }
            else if (variable.Equals("TemporalyFiles"))
            {
                this.guna2Button24.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(225)))));
            }
            else if (variable.Equals("Trash"))
            {
                this.guna2Button25.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(225)))));
            }
            else if (variable.Equals("Objectwebsite"))
            {
                this.guna2Button46.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(225)))));
            }
            else if (variable.Equals("ParentalControl"))
            {
                this.guna2Button45.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(225)))));
            }
            else if (variable.Equals("SavBrowser"))
            {
                this.guna2Button36.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(225)))));
            }
            else if (variable.Equals("WiFiPassword"))
            {
                this.guna2Button37.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(225)))));
            }
            else if (variable.Equals("AV"))
            {
                this.guna2Button43.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(225)))));
            }
            else if (variable.Equals("Buuurt"))
            {
                this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(225))))); 
            }
            /*else if (variable.Equals("Program"))
            {
                this.guna2Button13.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(225)))));
            }*/

        }
    }
}
