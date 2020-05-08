using dot_net_demo.Models.DTO.data;
using dot_net_demo.Models.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace dot_net_demo.Business.Services
{
    public class DataService : IDataService
    {
        private string _url { get; set; }
        public DataService()
        {
            this._url = ConfigurationManager.AppSettings["data_url"];
        }

        public async Task<Response<T>> GetDataAsync<T>(string action){
            var httpClient = new HttpClient();
            var url = $"{this._url}/{action}";
            var result = await httpClient.GetAsync(url);
            if (!result.IsSuccessStatusCode)
            {
                return new Response<T>
                {
                    Success = false,
                    Error = "Something happened with connection to Data server."
                };
            }
            var serializeResponse = await result.Content.ReadAsStringAsync();
            var responseData = JsonConvert.DeserializeObject<ResponseData<T>>(serializeResponse);
            if (responseData.success)
            {
                return new Response<T>
                {
                    Success = responseData.success,
                    Result = responseData.result
                };
            }
            else
            {
                return new Response<T>
                {
                    Success = false,
                    Error = "Something happened with Data server."
                };
            }
        }
    }
}
