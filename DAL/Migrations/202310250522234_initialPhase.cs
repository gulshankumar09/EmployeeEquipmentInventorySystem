namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialPhase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeID = c.Int(nullable: false, identity: true),
                        EmployeeFirstName = c.String(nullable: false, maxLength: 50),
                        EmployeeLastName = c.String(nullable: false, maxLength: 50),
                        EmployeeEmail = c.String(),
                        EmployeePhone = c.String(),
                        EmployeeDapartMent = c.String(),
                        Request_RequestID = c.Int(),
                    })
                .PrimaryKey(t => t.EmployeeID)
                .ForeignKey("dbo.Requests", t => t.Request_RequestID)
                .Index(t => t.Request_RequestID);
            
            CreateTable(
                "dbo.Requests",
                c => new
                    {
                        RequestID = c.Int(nullable: false, identity: true),
                        MyProperty = c.Int(nullable: false),
                        RequestDate = c.DateTime(nullable: false),
                        EmployeeID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RequestID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "Request_RequestID", "dbo.Requests");
            DropIndex("dbo.Employees", new[] { "Request_RequestID" });
            DropTable("dbo.Requests");
            DropTable("dbo.Employees");
        }
    }
}
