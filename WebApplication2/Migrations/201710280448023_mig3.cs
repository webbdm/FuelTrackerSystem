namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FuelEvents",
                c => new
                    {
                        EventID = c.Int(nullable: false, identity: true),
                        FuelUsed = c.Int(nullable: false),
                        Truck = c.Int(nullable: false),
                        Order = c.Int(nullable: false),
                        Location = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EventID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderID = c.Int(nullable: false, identity: true),
                        StopLocation = c.Int(nullable: false),
                        Region = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderID);
            
            CreateTable(
                "dbo.Regions",
                c => new
                    {
                        RegionID = c.Int(nullable: false, identity: true),
                        RegionName = c.String(),
                    })
                .PrimaryKey(t => t.RegionID);
            
            CreateTable(
                "dbo.Stops",
                c => new
                    {
                        StopID = c.Int(nullable: false, identity: true),
                        ReFuel = c.Boolean(nullable: false),
                        Region = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StopID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Stops");
            DropTable("dbo.Regions");
            DropTable("dbo.Orders");
            DropTable("dbo.FuelEvents");
        }
    }
}
