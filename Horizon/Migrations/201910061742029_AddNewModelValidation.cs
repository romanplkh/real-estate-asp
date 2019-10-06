namespace Horizon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewModelValidation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "HomePhone", c => c.String(nullable: false, maxLength: 14));
            AlterColumn("dbo.Employees", "CellPhone", c => c.String(nullable: false, maxLength: 14));
            AlterColumn("dbo.Employees", "OfficePhone", c => c.String(nullable: false, maxLength: 14));
            AlterColumn("dbo.Employees", "OfficeEmail", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "OfficeEmail", c => c.String(maxLength: 50));
            AlterColumn("dbo.Employees", "OfficePhone", c => c.String(maxLength: 14));
            AlterColumn("dbo.Employees", "CellPhone", c => c.String(maxLength: 14));
            AlterColumn("dbo.Employees", "HomePhone", c => c.String(maxLength: 14));
        }
    }
}
