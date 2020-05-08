using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace dot_net_demo.Models.Models
{
    [Table("Organizations")]
    public class Organization
    {
        [Key]
        public long id { get; set; }
        public string name { get; set; }
    }
}