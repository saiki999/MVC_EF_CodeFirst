namespace MovieRentals_CFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update5 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FName = c.String(nullable: false),
                        LName = c.String(nullable: false),
                        EmailId = c.String(nullable: false),
                        Password = c.String(),
                        ConfirmPassword = c.String(),
                        Type = c.String(),
                        Gender = c.String(),
                        Age = c.Int(),
                        Phone = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
