namespace dot_net_demo.Business.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Licenses",
                c => new
                    {
                        idLicense = c.Long(nullable: false, identity: true),
                        status = c.String(),
                        maintainer = c.String(),
                        family = c.String(),
                        title = c.String(),
                        domain_data = c.Boolean(nullable: false),
                        is_okd_compliant = c.Boolean(nullable: false),
                        is_generic = c.Boolean(nullable: false),
                        url = c.String(),
                        is_osi_compliant = c.Boolean(nullable: false),
                        domain_content = c.Boolean(nullable: false),
                        domain_software = c.Boolean(nullable: false),
                        id = c.String(),
                    })
                .PrimaryKey(t => t.idLicense);
            
            CreateTable(
                "dbo.Organizations",
                c => new
                    {
                        id = c.Long(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Organizations");
            DropTable("dbo.Licenses");
        }
    }
}
