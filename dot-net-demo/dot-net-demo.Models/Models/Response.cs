using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dot_net_demo.Models.Models
{
    public class Response<T>
    {
        public bool Success { get; set; }
        public string Error { get; set; }
        public T Result { get; set; }
    }
}
