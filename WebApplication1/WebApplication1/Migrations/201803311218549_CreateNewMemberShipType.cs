namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateNewMemberShipType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MemberShipTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DurationInMonths = c.Int(nullable: false),
                        Discount = c.Int(nullable: false),
                        RentAmount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Customers", "MemberShipTypeID", c => c.Int());
            CreateIndex("dbo.Customers", "MemberShipTypeID");
            AddForeignKey("dbo.Customers", "MemberShipTypeID", "dbo.MemberShipTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "MemberShipTypeID", "dbo.MemberShipTypes");
            DropIndex("dbo.Customers", new[] { "MemberShipTypeID" });
            DropColumn("dbo.Customers", "MemberShipTypeID");
            DropTable("dbo.MemberShipTypes");
        }
    }
}
