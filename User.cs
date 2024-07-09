using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draka_Antivirus
{
    internal class User
    {
        public string action;
        public string key;
        public string mac;

        public User(string action, string key, string adressemac)
        {
            this.action = action;
            this.key = key;
            this.mac = adressemac;
        }
    }
}
