namespace MemberShipsPro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CancelUpdateUsers : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.UserViewModels");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.UserViewModels",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(nullable: false),
                        FirstName = c.String(maxLength: 30),
                        Password = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
