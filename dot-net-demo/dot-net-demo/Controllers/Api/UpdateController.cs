using dot_net_demo.Business.Managers;
using dot_net_demo.Models.DTO;
using dot_net_demo.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace dot_net_demo.Controllers.Api
{
    public class UpdateController : ApiController
    {
        private IDataManager _dataManager { get; set; }
        private Dictionary<string, Nullable<TypeRequest>> _actions;
        public UpdateController(IDataManager dataManager)
        {
            this._dataManager = dataManager;
            this._actions = new Dictionary<string, Nullable<TypeRequest>>
            {
                { "organization_list", TypeRequest.Organization },
                { "license_list", TypeRequest.License }
            };
        }

        public async Task<Response<string>> Put(UpdateDto update)
        {
            if(update == null)
            {
                return new Response<string>
                {
                    Success = false,
                    Result = "Action is null"
                };
            }
            var action = _actions.SingleOrDefault(_action => _action.Key == update.Action);
            if (!action.Equals(default(KeyValuePair<string, Nullable<TypeRequest>>)))
            {
                var response = new Response<string>();
                switch (action.Value)
                {
                    case TypeRequest.Organization:

                        response.Success = await _dataManager.CreateUpdateOrganizationDataAsync(update.Action);
                        break;
                    case TypeRequest.License:
                        response.Success = await _dataManager.CreateUpdateLicenseDataAsync(update.Action);
                        break;
                    default:
                        response.Success = false;
                        response.Result = "Something is wrong!";
                        break;
                }
                return response;
            }
            else
            {
                return new Response<string>
                {
                    Success = false,
                    Result = "Action hasn't been found"
                };
            }
        }
    }
}
