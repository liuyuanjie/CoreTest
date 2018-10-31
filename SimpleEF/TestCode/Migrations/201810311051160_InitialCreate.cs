namespace TestCode.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Blog2",
                c => new
                    {
                        Blog2Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Blog2Id);
            
            CreateTable(
                "dbo.Post2",
                c => new
                    {
                        Post2Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Content = c.String(),
                        Blog2Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Post2Id)
                .ForeignKey("dbo.Blog2", t => t.Blog2Id, cascadeDelete: true)
                .Index(t => t.Blog2Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Post2", "Blog2Id", "dbo.Blog2");
            DropIndex("dbo.Post2", new[] { "Blog2Id" });
            DropTable("dbo.Post2");
            DropTable("dbo.Blog2");
        }
    }
}
