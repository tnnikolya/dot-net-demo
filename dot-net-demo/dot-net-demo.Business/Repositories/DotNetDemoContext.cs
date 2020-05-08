using dot_net_demo.Models.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dot_net_demo.Business.Repositories
{
    public class DotNetDemoContext : DbContext
    {
        public DotNetDemoContext() : base("name=DotNetDemoContext")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<DotNetDemoContext>(new CreateDatabaseIfNotExists<DotNetDemoContext>());
            base.OnModelCreating(modelBuilder);
        }

        public IDbSet<Organization> Organizations { get; set; }
        public IDbSet<License> Licenses { get; set; }
    }
}
