using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Draka_Antivirus
{
    public partial class MessagessBoxx : Form
    {
        public static string Langues = targetPath + "Draka_Shiel\\Debug\\lang.txt";
        public static string MessageOK = targetPath + "Draka_Shiel\\Debug\\MessageOK.txt";
        public static string targetPath = AppDomain.CurrentDomain.BaseDirectory;
        public static string AutoMessageOK = targetPath + "Draka_Shiel\\Debug\\AutoClosing.txt";
        private static System.Timers.Timer aTimer;
        //static System.Timers.Timer aTimer;
        string val = "";
        string lang = "";
        string glob = "";
        private System.Windows.Forms.Timer tmr;
        public MessagessBoxx()
        {
            InitializeComponent();
            
            lang = File.ReadAllText(Langues).ToString().Trim();
            string str = File.ReadAllText(AutoMessageOK).ToString().Trim();
           
            Chargement(str);
            affichageNomButton(1);

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 18, 18));

            tmr = new System.Windows.Forms.Timer();
            tmr.Tick += delegate {
                this.Close();
            };
            tmr.Interval = (int)TimeSpan.FromMinutes(0.025).TotalMilliseconds;//.FromSeconds(500).Seconds;//.FromMinutes(10).TotalMilliseconds;
            tmr.Start();
            
            this.ShowDialog();
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public MessagessBoxx(string tt, string bol)
        {
            InitializeComponent();
            lang = File.ReadAllText(Langues).ToString().Trim();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 18, 18));
            
            Chargement(tt);
            if (bol.Equals(""))
            {
                affichageNomButton(1);
            }
            else
            {
                affichageNomButton(2);
            }
        }

        public MessagessBoxx(string tt, string bol, string name)
        {
            InitializeComponent();
            lang = File.ReadAllText(Langues).ToString().Trim();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 18, 18));

            Chargement(tt);
            if (bol.Equals(""))
            {
                affichageNomButton(1);
                this.label3.Text = name;
            }
            else
            {
                affichageNomButton(2);
                this.label3.Text = name;
            }
        }

        public void LocalisationForme()
        {
            // ici on localise le Message box
            //MessageBox.Show("ici je localise le messageBox .");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("B = " + glob);
            if (glob.Equals("un"))
            {
                this.Close();
            }
            else
            {
                File.WriteAllText(MessageOK, button1.Text);
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("B = " + glob);
            if (glob.Equals("un"))
            {
                this.Close();
            }
            else
            {
                File.WriteAllText(MessageOK, button2.Text);
                this.Close();
            }
        }

        public void IntialTimer()
        {
            // Create a new Timer with Interval set to 1.5 seconds.
            double interval = 3500.0;
            aTimer = new System.Timers.Timer(interval);

            // Hook up the event handler for the Elapsed event.
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);

            // Only raise the event the first time Interval elapses.
            aTimer.AutoReset = false;
            aTimer.Enabled = true;

            // Ensure the event fires before the exit message appears.
            System.Threading.Thread.Sleep((int)interval * 2);

            this.Invoke(new EventHandler( delegate
                {
                     Close(); // Entering with a "Step Into" here it crashes.
                } ));
        }
        // Handle the Elapsed event.
        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            //
        }

        public void Chargement(string top)
        {
            string str = "";
           
            if(top.Length <= 35)
            {
                str = top;
            }
            else
            {
                
                string[] tab = top.Split(' ');
                string arr = "";
                string rr = "";
                int i = 0;
                int j = 0;
             
                foreach (string s in tab)
                {
                    arr += s + " ";
                    i = i + s.Length;
                    j++;
                  
                    if (i >= 30)
                    {
                        rr = rr + arr + "\n";
                        i = 0;
                        arr = "";
                    }else if(j == tab.Length)
                    {
                        rr = rr + arr + "\n";                        
                    }
                }
                str = rr;
            }

            val = str;
        }

        public void affichageNomButton(int er)
        {
            if (lang.Equals("Anglais"))
            {
                if(er == 1)
                {
                    this.button1.Text = "OK";
                    this.button1.Location = new System.Drawing.Point(117, 109);
                    this.button2.Visible = false;
                    this.label2.Visible = false;
                    this.label1.Text = val;
                    this.glob = "un";
                }
                else
                {
                    this.button1.Text = "Yes";
                    this.button2.Text = "No";
                    this.button1.Visible = true;
                    this.button2.Visible = true;
                    this.label1.Text = val;
                    this.label2.Visible = false;
                    glob = "deux";
                }
                label3.Text = "Informations";
            }
            else
            {
                if (er == 1)
                {
                    this.button1.Text = "OK";
                    this.button1.Location = new System.Drawing.Point(117, 109);
                    this.button2.Visible = false;
                    this.label2.Visible = false;
                    this.label1.Text = val;
                    glob = "un";
                }
                else
                {
                    this.button1.Text = "Oui";
                    this.button2.Text = "Non";
                    this.button1.Visible = true;
                    this.button2.Visible = true;
                    this.label1.Text = val;
                    this.label2.Visible = false;
                    glob = "deux";
                }
                label3.Text = "Informations";
            }
        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.Close();
        }
    }
}
