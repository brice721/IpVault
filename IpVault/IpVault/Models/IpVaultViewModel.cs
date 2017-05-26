using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IpVault.Models
{
    public class IpVaultViewModel
    {
        public int id { get; set; }

        public string IpProvider { get; set; }

        public string IpAddress { get; set; }

        public string AttachedSite { get; set; }
    }
}