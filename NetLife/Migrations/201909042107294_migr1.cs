namespace NetLife.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migr1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblNews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 200),
                        IdUser = c.Int(nullable: false),
                        Description = c.String(nullable: false, maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tblUsers", t => t.IdUser, cascadeDelete: true)
                .Index(t => t.IdUser);
            
            CreateTable(
                "dbo.tblUsers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 200),
                        Surname = c.String(),
                        Age = c.String(nullable: false, maxLength: 2),
                        Gender = c.String(nullable: false, maxLength: 10),
                        UserName = c.String(nullable: false, maxLength: 19),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblNews", "IdUser", "dbo.tblUsers");
            DropIndex("dbo.tblNews", new[] { "IdUser" });
            DropTable("dbo.tblUsers");
            DropTable("dbo.tblNews");
        }
    }
}
