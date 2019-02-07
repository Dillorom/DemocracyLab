namespace DemocracyLab.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBillIdToComment : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Comments", "BillId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Comments", "BillId");
        }
    }
}
