namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAttributesInCustomerModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Age", c => c.Int(nullable: true));
            AddColumn("dbo.Customers", "IsMale", c => c.Boolean(nullable: true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "IsMale");
            DropColumn("dbo.Customers", "Age");
        }
    }
}
