using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draka_Antivirus
{
    internal class Client2
    {
        public int id { get; set; }
        public string name_surname { get; set; }
        public string company_name { get; set; }
        public string country { get; set; }
        public string street_adress { get; set; }
        public string town { get; set; }
        public string postal_code { get; set; }
        public string phone_number { get; set; }
        public string email { get; set; }
        public IList<string> stripe_id { get; set; }
        public DateTime creation_date { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}
