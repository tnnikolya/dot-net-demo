using dot_net_demo.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dot_net_demo.Business.Repositories
{
    public interface IRepository
    {
        Task<bool> CreateUpdateOrganizationsAsync(List<Organization> organizations);
        List<Organization> GetOrganizations();
        Task<bool> CreateUpdateLicensesAsync(List<License> licenses);
        List<License> GetLicenses();
    }
}
