using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dot_net_demo.Models.Models
{
    [Table("Licenses")]
    public class License
    {
        [Key]
        public long idLicense { get; set; }
        public string status { get; set; }
        public string maintainer { get;set;}
        public string family { get; set; }
        public string title { get; set; }
        public bool domain_data { get; set; }
        public bool is_okd_compliant { get; set; }
        public bool is_generic { get; set; }
        public string url { get; set; }
        public bool is_osi_compliant { get; set; }
        public bool domain_content { get; set; }
        public bool domain_software { get; set; }
        public string id { get; set; }
    }
}
