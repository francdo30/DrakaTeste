using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Draka_Antivirus
{
    internal class MessagesShow
    {
        public static string Langues = targetPath + "Draka_Shiel\\Debug\\lang.txt";
        public static string MessageOK = targetPath + "Draka_Shiel\\Debug\\MessageOK.txt";
        public static string targetPath = AppDomain.CurrentDomain.BaseDirectory;
        public static string AutoMessageOK = targetPath + "Draka_Shiel\\Debug\\AutoClosing.txt";
        private static System.Timers.Timer aTimer;

        public MessagesShow(string tt)
        {
            //TimeInstant();
            using (StreamWriter sw = new StreamWriter(AutoMessageOK))
            {
                sw.WriteLine(tt);
            }
            
            MessagessBoxx toto = new MessagessBoxx();
            //toto.LocalisationForme();
            
        }

        public MessagesShow(string tt, string bol)
        {
            MessagessBoxx toto = new MessagessBoxx(tt, bol);
            toto.LocalisationForme();
            toto.ShowDialog();
        }

        public MessagesShow(string tt, string bol, string name) 
        {
            MessagessBoxx toto = new MessagessBoxx(tt, bol, name);
            toto.LocalisationForme();
            toto.ShowDialog();
        }


    }
}
