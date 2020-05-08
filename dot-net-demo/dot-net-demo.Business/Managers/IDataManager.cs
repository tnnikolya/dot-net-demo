using dot_net_demo.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dot_net_demo.Business.Managers
{
    public interface IDataManager
    {
        Task<bool> CreateUpdateOrganizationDataAsync(string action);

        Task<bool> CreateUpdateLicenseDataAsync(string action);

        List<OrganizationDto> GetOrganizations();

        List<LicenseDto> GetLicense();
    }
}
