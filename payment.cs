using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draka_Antivirus
{
    internal class payment
    {
        public int id { get; set; }
        public string payment_id { get; set; }
        public string typeofpayment { get; set; }
        public string typeofpack { get; set; }
        public string paymentstatus { get; set; }
        public string numberofkeys { get; set; }
        public string checkout_session_id { get; set; }
        public string client_id { get; set; }
        public string user_id { get; set; }
        public string creationdate { get; set; }
        public string amount { get; set; }
        public string token { get; set; }
        public string paid { get; set; }
        public string retry_payment_url { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
    }
}
