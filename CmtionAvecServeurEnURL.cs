using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using System.Text.Json;
using System.Net.Http;
using System.Collections.Specialized;
using System.Collections;
using System.Net.Security;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Security.Policy;

namespace Draka_Antivirus
{
    internal class CmtionAvecServeurEnURL
    {
        public static string targetPath = AppDomain.CurrentDomain.BaseDirectory;
        string url = "http://webcode.me";
        string url1 = "https://httpbin.org/post";
        string Activation = targetPath + "\\Videos\\Activation.json";

        public CmtionAvecServeurEnURL()
        {
            // ici je suis le construteur.
            
            //SaveSiteWeb(url1);
            //LoadSiteWeb(url);
            //LoadWebSiteAsync(url);
            //PostHttpClient(url1);
        }


        // copier le site web
        public void LoadSiteWeb(string url)
        {
            var request = WebRequest.Create(url);
            request.Method = "GET";

            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();

            var reader = new StreamReader(webStream);
            var data = reader.ReadToEnd();
            MessageBox.Show(data);
            Console.WriteLine(data);
        }
        // ici on envois un fichier json au serveur

        public void SaveSiteWeb(string url22, string key33, string adressemac)
        {
            //User user = new User("enable", key33, adressemac);
            var user1 = new Dictionary<string, string>
            {
                { "action", "enable" },
                { "key", key33 },
                { "mac", adressemac }
            };
            User user = new User("enable", key33, adressemac);
            var request = WebRequest.Create(url22);
            request.Method = "POST";
           
            var json = System.Text.Json.JsonSerializer.Serialize(user);

            byte[] byteArray = Encoding.UTF8.GetBytes(json);

            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteArray.Length;

            var reqStream = request.GetRequestStream();
            reqStream.Write(byteArray, 0, byteArray.Length);

            var response = request.GetResponse();
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);

            var respStream = response.GetResponseStream();

            var reader = new StreamReader(respStream);
            string data = reader.ReadToEnd();
            MessageBox.Show(data);
            File.WriteAllText(Activation, data);  // ici on écris le retour dans un fichier json
            Console.WriteLine(data);

            //record User(string Name, string Occupation);
        }

        // ces méthodes de façon asynchrone
        public async Task LoadWebSiteAsync(string url)
        {
            var client = new HttpClient();
            var content = await client.GetStringAsync(url);
            MessageBox.Show(content);
            Console.WriteLine(content);
        }

        public async Task PostHttpClient(string url, string key, string adressemac)
        {
            var user = new Dictionary<string, string>
            {
                { "action", "enable" },
                { "key", key },
                { "mac", adressemac }
            };
            //User user = new User("enable",key, adressemac);

            var data = new FormUrlEncodedContent(user);
            var client = new HttpClient();

            var response = await client.PostAsync(url, data);

            string result = response.Content.ReadAsStringAsync().Result;
            //MessageBox.Show(result);
            File.WriteAllText(Activation, result);  // ici on écris le retour dans un fichier json
            Console.WriteLine(result);
        }

        // ici j'upload un fichier sur le serveur distant

        public async Task UploadUserWebsiteAsync(string a, string b, string c)
        {
            //User user = new User("enable", b, c);

            var user = new Dictionary<string, string>
            {
                { "action", "enable" },
                { "key", b },
                { "mac", c }
            };

            var json = System.Text.Json.JsonSerializer.Serialize(user);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var url = a;
            var client = new HttpClient();

            var response = await client.PostAsync(url, data);

            string result = response.Content.ReadAsStringAsync().Result;
            MessageBox.Show(result);
            Console.WriteLine(result);


            //record User(string Name, string Occupation);
        }

        // ici on envoi une liste de valeur au serveur
        //Methode 1
        public void GetPOSTResponse(string url, string key, string mac)
        {
            try
            {
                var searchResults = url + key.Trim() + mac;
                MessageBox.Show("Etape1 = ");
                HttpWebResponse response = null;
                var request = (HttpWebRequest)WebRequest.Create(searchResults);
                request.Method = "POST";
                MessageBox.Show("Etape2 = ");
                response = (HttpWebResponse)request.GetResponse();
                MessageBox.Show("Etape3 = " );
                var respStream = response.GetResponseStream();
                MessageBox.Show("Etape4 = ");
                var reader = new StreamReader(respStream);
                string data = reader.ReadToEnd();

                MessageBox.Show(data);

            }
            catch(Exception ex)
            {
                MessageBox.Show("Etape0 = "+ex.Message);
                Console.WriteLine(ex);
            }
        }
        //Methode2

        public void EnvoiValeurEnPost(string url, string key, string mac)
        {
            
            try
            {
                WebClient myWebClient = new WebClient();
                NameValueCollection myNameValueCollection = new NameValueCollection(); ;

                string address = Console.ReadLine();

                // Add necessary parameter/value pairs to the name/value container.
                myNameValueCollection.Add("action", "enable");
                myNameValueCollection.Add("key", key);
                myNameValueCollection.Add("mac", mac);

                // 'The Upload(String,NameValueCollection)' implicitly method sets HTTP POST as the request method.            
                byte[] responseArray = myWebClient.UploadValues(url, myNameValueCollection);
                MessageBox.Show("OUFF.");
                // Decode and display the response.
                string reponse = Encoding.UTF8.GetString(responseArray);
                MessageBox.Show(reponse);
                Console.WriteLine("\nResponse received was :\n{0}", Encoding.ASCII.GetString(responseArray));
            }catch(Exception ex)
            {
                MessageBox.Show(""+ex);
                Console.WriteLine("" + ex);
            }
        }

        public async Task MakeHttpClientRequestASync (string requestUrl, string key, string mac)
        {
            var requestContent = new Dictionary<string, string>
            {
                { "action", "enable" },
                { "key", key },
                { "mac", mac }
            };

            var httpClient = new HttpClient();

            httpClient.DefaultRequestHeaders.CacheControl = new CacheControlHeaderValue() { NoCache = true };
           
            HttpResponseMessage response;

            var returnVal = "";

            try
            {
                response = await httpClient.PostAsync(requestUrl, new FormUrlEncodedContent(requestContent));

                var resultString = await response.Content.ReadAsStringAsync();
                returnVal = JsonConvert.DeserializeObject<string>(resultString);
            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex);
            }
            MessageBox.Show("" + returnVal);
            //return returnVal;
        }


    }
}
