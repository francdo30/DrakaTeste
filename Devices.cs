using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draka_Antivirus
{
    internal class Devices
    {
        public int id { get; set; }
        public string key_id { get; set; }
        public string mac { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}
