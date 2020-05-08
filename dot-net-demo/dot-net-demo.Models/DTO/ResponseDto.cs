using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dot_net_demo.Models.DTO
{
    public class ResponseDto
    {
        public bool success { get; set; }
        public object result { get; set; }
    }
}