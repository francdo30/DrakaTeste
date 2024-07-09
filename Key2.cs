using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draka_Antivirus
{
    internal class Key2
    {
        public int id { get; set; }
        public string keyslicence { get; set; }
        public string user_id { get; set; }
        public string client_id { get; set; }
        public string payment_id { get; set; }
        public string ipadress { get; set; }
        public IList<string> device_mac { get; set; }
        public string keystatus { get; set; }
        public DateTime creationdate { get; set; }
        public DateTime activated_at { get; set; }
        public DateTime end_date { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public IList<Devices> devices { get; set; }
        public Payment2 payment { get; set; }
    }
}
