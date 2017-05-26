using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IpVault.Entities
{
    [Table("IpVault")]
    public class IpEntity
    {
        [Key]
        public int id { get; set; }

        public string IpProvider { get; set; }

        public string IpAddress { get; set; }

        public string AttachedSite { get; set; }
    }
}