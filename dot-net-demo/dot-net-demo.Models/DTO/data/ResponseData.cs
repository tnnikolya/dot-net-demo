using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dot_net_demo.Models.DTO.data
{
    public class ResponseData<T>
    {
        public string help { get; set; }
        public bool success { get; set; }
        public T result { get; set; }
    }
}