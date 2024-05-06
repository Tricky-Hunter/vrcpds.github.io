namespace VRCPS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialDataFiles : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BasicDataSet",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CreatorId = c.String(),
                        WorldId = c.String(),
                        AssociatedId = c.String(),
                        ObjectId = c.String(),
                        ObjectData = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BasicDataSet");
        }
    }
}
