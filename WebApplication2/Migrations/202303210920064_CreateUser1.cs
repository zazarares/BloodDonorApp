namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateUser1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        CNP = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Donators",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        CNP = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        BloodType = c.String(),
                        Zona = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Donators");
            DropTable("dbo.Doctors");
            DropTable("dbo.Admins");
        }
    }
}
