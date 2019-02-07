namespace DemocracyLab.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bills",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Title = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        Votes_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Votes", t => t.Votes_Id)
                .Index(t => t.Votes_Id);
            
            CreateTable(
                "dbo.Votes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Value = c.Int(nullable: false),
                        BillId = c.Int(nullable: false),
                        VoterId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Content = c.String(nullable: false),
                        VoterId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Voters",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(nullable: false),
                        Password = c.String(nullable: false, maxLength: 18),
                        Comments_Id = c.Guid(),
                        Votes_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Comments", t => t.Comments_Id)
                .ForeignKey("dbo.Votes", t => t.Votes_Id)
                .Index(t => t.Comments_Id)
                .Index(t => t.Votes_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Voters", "Votes_Id", "dbo.Votes");
            DropForeignKey("dbo.Voters", "Comments_Id", "dbo.Comments");
            DropForeignKey("dbo.Bills", "Votes_Id", "dbo.Votes");
            DropIndex("dbo.Voters", new[] { "Votes_Id" });
            DropIndex("dbo.Voters", new[] { "Comments_Id" });
            DropIndex("dbo.Bills", new[] { "Votes_Id" });
            DropTable("dbo.Voters");
            DropTable("dbo.Comments");
            DropTable("dbo.Votes");
            DropTable("dbo.Bills");
        }
    }
}
