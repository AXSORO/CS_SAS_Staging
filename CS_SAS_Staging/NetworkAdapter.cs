using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_SAS_Staging
{
    public class NetworkAdapter
    {
        public string Name { get; set; }
        public string ActName { get; set; }
        public string IPAddress { get; set; }
        public string SubnetMask { get; set; }
        public string DefaultGateway { get; set; }
        public string PrimaryDNS { get; set; }
        public string SecondaryDNS { get; set; }
        public string InternalAdapterName { get; set; }
        public override string ToString()
        {
            return Name; // Display the adapter name when ToString is called
        }
    }
}
