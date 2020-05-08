using dot_net_demo.Business.Managers;
using dot_net_demo.Models.DTO;
using dot_net_demo.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace dot_net_demo.Controllers.Api
{
    public class LicenseController : ApiController
    {
        private IDataManager _dataManager { get; set; }
        public LicenseController(IDataManager dataManager)
        {
            this._dataManager = dataManager;
        }

        public Response<List<LicenseDto>> Get()
        {
            var licenses = _dataManager.GetLicense();
            return new Response<List<LicenseDto>>
            {
                Result = licenses,
                Success = true
            };
        }
    }
}
