namespace PIC_DATABASE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateUser : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                        Name = c.String(),
                        Email = c.String(),
                        Job = c.String(),
                        Departament = c.String(),
                        UserType = c.Int(nullable: false),
                        Active = c.Boolean(nullable: false),
                        Token = c.String(),
                        IP = c.String(),
                        RegisterDate = c.DateTime(nullable: false),
                        FirstLogin = c.DateTime(),
                        LastLogin = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("Users");
        }
    }
}
