using dot_net_demo.Models.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dot_net_demo.Business.Repositories
{
    public class Repository: IRepository
    {
        public async Task<bool> CreateUpdateOrganizationsAsync(List<Organization> organizations)
        {
            using (var context = new DotNetDemoContext())
            {
                context.Database.ExecuteSqlCommand("TRUNCATE TABLE [Organizations]");
                ((DbSet<Organization>)context.Organizations).AddRange(organizations);
                await context.SaveChangesAsync();
                return true;
            }
        }

        public List<Organization> GetOrganizations()
        {
            using (var context = new DotNetDemoContext())
            {
                var organizations = context.Organizations.ToList();
                return organizations;
            }
        }

        public async Task<bool> CreateUpdateLicensesAsync(List<License> licenses)
        {
            using (var context = new DotNetDemoContext())
            {
                try
                {
                    context.Database.ExecuteSqlCommand("TRUNCATE TABLE [Licenses]");
                    ((DbSet<License>)context.Licenses).AddRange(licenses);
                    await context.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    throw;
                }
                return true;
            }
        }

        public List<License> GetLicenses()
        {
            using (var context = new DotNetDemoContext())
            {
                var licenses = context.Licenses.ToList();
                return licenses;
            }
        }
    }
}
