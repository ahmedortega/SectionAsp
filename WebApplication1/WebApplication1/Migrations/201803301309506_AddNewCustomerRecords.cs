namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewCustomerRecords : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO customers VALUES('Ahmed');");
            Sql("INSERT INTO customers VALUES('Ali');");
            Sql("INSERT INTO customers VALUES('Mohamed');");
            Sql("INSERT INTO customers VALUES('Reda');");
        }
        
        public override void Down()
        {
        }
    }
}
