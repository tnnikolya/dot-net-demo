using dot_net_demo.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dot_net_demo.Business.Services
{
    public interface IDataService
    {
        Task<Response<T>> GetDataAsync<T>(string action);
    }
}
