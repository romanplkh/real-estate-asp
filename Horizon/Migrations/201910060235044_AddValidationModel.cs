namespace Horizon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddValidationModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "FirstName", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Employees", "LastName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Employees", "SIN", c => c.String(nullable: false, maxLength: 11));
            AlterColumn("dbo.Employees", "StreetAddress", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Employees", "City", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Employees", "PostalCode", c => c.String(nullable: false, maxLength: 6));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "PostalCode", c => c.String(maxLength: 6));
            AlterColumn("dbo.Employees", "City", c => c.String(maxLength: 50));
            AlterColumn("dbo.Employees", "StreetAddress", c => c.String(maxLength: 100));
            AlterColumn("dbo.Employees", "SIN", c => c.String(maxLength: 11));
            AlterColumn("dbo.Employees", "LastName", c => c.String(maxLength: 30));
            AlterColumn("dbo.Employees", "FirstName", c => c.String(maxLength: 20));
        }
    }
}
