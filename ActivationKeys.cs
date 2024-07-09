using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draka_Antivirus
{
    internal class ActivationKeys
    {
        public string message { get; set; }
        public client client { get; set; } = new client();
        public key key { get; set; } = new key();
        public payment payment { get; set; } = new payment();        
        public string[] error { get; set; }         

    }
}
