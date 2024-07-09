using Draka_Antivirus.DAO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draka_Antivirus
{
    internal class Activation
    {
        public Activation() { }

        private System.Threading.ManualResetEvent _busy = new System.Threading.ManualResetEvent(false);
        public static string targetPath = AppDomain.CurrentDomain.BaseDirectory;
        public static string name_db = "ScanDataBase.db";
        public static string sourceFile = targetPath + name_db;
        Database db1 = new Database();
        

        private void roundedButton1_Click(object sender, EventArgs e)
        {

            //Console.WriteLine("rounderbutton => " + textkey);
            /* string key = DecryptString(textkey);*/
            /*Console.WriteLine(key);*/
            //registercle(textkey);
        }

        public void ActivateProduct(String textkey)
        {
            Console.WriteLine("Activation key => " + textkey);
            registercle(textkey);

        }

        public static string DecryptString(string cipherText)
        {
            string key = "b06ca5898a4e4124bbce2ea2315a1990";
            byte[] iv = new byte[16];
            byte[] buffer = Convert.FromBase64String(cipherText);

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;
                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream(buffer))
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader streamReader = new StreamReader((Stream)cryptoStream))
                        {
                            return streamReader.ReadToEnd();
                        }
                    }
                }
            }
        }

        public void registercle(string key)
        {
            if (getkeycreationdate(key) == "no date")
            {
                MessageBox.Show("Keys not registed ", "Registration Key", MessageBoxButtons.OK);
            }
            else if (getstatuskey(key) == "NOTACTIF")
            {
                MessageBox.Show("Keys Canceled \n Please register again  ", "Registration Key", MessageBoxButtons.OK);
            }
            else
            {
                DateTime dat = Convert.ToDateTime(getkeycreationdate(key));
                DateTime expirationdate = Convert.ToDateTime(getkeyexpirationate(key));
                string sql = "insert into keyregister (key,dateregist,expiration) values(";
                sql = sql + "'" + key + "', ";
                sql = sql + "'" + dat.ToString() + "', ";
                sql = sql + "'" + expirationdate.ToString() + "');";
                Boolean error = db1.insertData(sourceFile, sql);
                if (error == true)
                {
                    MessageBox.Show("Cles enregistrer avec success", "Registration Key", MessageBoxButtons.OK);
                    Index ine = new Index();
                    ine.controlkey();
                }
                else
                {
                    MessageBox.Show("Cles Non enregistrer ", "Registration Key", MessageBoxButtons.OK);
                }
            }
        }

        public MySqlConnection getdistantconnexion()
        {

            string host = "localhost";
            int port = 3306;
            string database = "keygen";
            string username = "root";
            string password = "";

            string connString = "server=" + host + ";port=" + port + ";database=" + database + ";uid=" + username;
            MySqlConnection conn = new MySqlConnection(connString);
            return conn;

        }

        public string getkeycreationdate(string key)
        {
            string date = "";
            try
            {

                /*string sql = "SELECT `creationdate` FROM `keys` WHERE `keyslicence` = '" + key + "'";*/
                /*string sql = "SELECT `id`, `keyslicence`, `agentid`, `clientid`, `paymentsid`, `ipadress`, `keystatus`, `creationdate`, `end_date`, `created_at`, `updated_at` FROM `keys` WHERE `keyslicence` = '" + key + "'";
                MySqlConnection con = getdistantconnexion();*/

                MySqlConnection con = getdistantconnexion();
                string sql = "SELECT `creationdate` FROM `keys` WHERE `keyslicence` = '" + key + "'";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.CommandTimeout = 60;
                MySqlDataReader reader;

                con.Open();
                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        date = reader.GetString(0);

                    }
                }
                else
                {
                    date = "no date";
                }

                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                date = "no date";
            }

            return date;
        }

        public string getkeyexpirationate(string key)
        {
            string date = "";
            try
            {
                MySqlConnection con = getdistantconnexion();

                /*string sql = "SELECT `id`, `keyslicence`, `agentid`, `clientid`, `paymentsid`, `ipadress`, `keystatus`, `creationdate`, `end_date`, `created_at`, `updated_at` FROM `keys` WHERE `keyslicence` = '" + key + "'";*/

                string sql = "SELECT `end_date` FROM `keys` WHERE `keyslicence` = '" + key + "'";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.CommandTimeout = 60;
                MySqlDataReader reader;

                con.Open();
                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        date = reader.GetString(0);
                    }
                }
                else
                {
                    date = "no date";
                }

                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                date = "no date";
            }

            return date;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public string getstatuskey(string key)
        {
            string date = "";
            try
            {
                MySqlConnection con = getdistantconnexion();
                string sql = "Select keystatus FROM keys where keyslicence = '" + key + "'";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.CommandTimeout = 60;
                MySqlDataReader reader;

                con.Open();
                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        date = reader.GetString(0);
                    }
                }
                else
                {
                    date = "no date";
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                date = "no date";
            }

            return date;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public string GetDateExpiration(string tt)
        {
            return tt;
        }

        public string GetDateExpiration()
        {
            return "";
        }

        public string LoadServer(string tt)
        {
            return tt;
        }

        public Boolean GetMacAdress(string tt)
        {
            return true;
        }

    }
}
