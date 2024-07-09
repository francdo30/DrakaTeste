using MySql.Data.MySqlClient.Memcached;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Draka_Antivirus
{
    internal class ActivationKeys2
    {
        public string message { get; set; }
        public Client2 client { get; set; }
        public Key2 key { get; set; }
        public Payment2 payment { get; set; }
        public IList<string> errors { get; set; }

    }
}
