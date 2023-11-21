using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_SAS_Staging
{
    public class LocalUser
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsRdpEnabled { get; set; }
        public bool IsDisabled { get; set; }
    }
}
