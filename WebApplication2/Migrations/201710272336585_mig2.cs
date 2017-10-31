namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Trucks",
                c => new
                    {
                        TruckID = c.Int(nullable: false, identity: true),
                        CurrentStop = c.Int(nullable: false),
                        NextStop = c.Int(nullable: false),
                        DriverId = c.Int(nullable: false),
                        CurrentFuel = c.Int(nullable: false),
                        Region = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TruckID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Trucks");
        }
    }
}
