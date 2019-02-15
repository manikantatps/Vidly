namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirthdateToCustomer1 : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.Customers", "Birthdate", c => c.DateTime());
            AlterColumn("dbo.MembershipTypes", "Name", c => c.String(nullable: false));
            //Sql("UPDATE Customers SET Birthdate = CAST('1980-01-01' AS DATETIME) WHERE Id = 1");
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MembershipTypes", "Name", c => c.String());
            DropColumn("dbo.Customers", "Birthdate");
        }
    }
}
