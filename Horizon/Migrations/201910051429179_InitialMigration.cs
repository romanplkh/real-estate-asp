namespace Horizon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        CountryId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.CountryId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 20),
                        LastName = c.String(maxLength: 30),
                        MiddleName = c.String(maxLength: 20),
                        SIN = c.String(maxLength: 11),
                        StreetAddress = c.String(maxLength: 100),
                        City = c.String(maxLength: 50),
                        PostalCode = c.String(maxLength: 6),
                        HomePhone = c.String(maxLength: 14),
                        CellPhone = c.String(maxLength: 14),
                        OfficePhone = c.String(maxLength: 14),
                        OfficeEmail = c.String(maxLength: 50),
                        DOB = c.DateTime(nullable: false),
                        AddedBy = c.Int(nullable: false),
                        HireDate = c.DateTime(nullable: false),
                        Country_CountryId = c.Int(),
                        Province_ProvinceId = c.Int(),
                    })
                .PrimaryKey(t => t.EmployeeId)
                .ForeignKey("dbo.Countries", t => t.Country_CountryId)
                .ForeignKey("dbo.Provinces", t => t.Province_ProvinceId)
                .Index(t => t.Country_CountryId)
                .Index(t => t.Province_ProvinceId);
            
            CreateTable(
                "dbo.Provinces",
                c => new
                    {
                        ProvinceId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ProvinceId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "Province_ProvinceId", "dbo.Provinces");
            DropForeignKey("dbo.Employees", "Country_CountryId", "dbo.Countries");
            DropIndex("dbo.Employees", new[] { "Province_ProvinceId" });
            DropIndex("dbo.Employees", new[] { "Country_CountryId" });
            DropTable("dbo.Provinces");
            DropTable("dbo.Employees");
            DropTable("dbo.Countries");
        }
    }
}
