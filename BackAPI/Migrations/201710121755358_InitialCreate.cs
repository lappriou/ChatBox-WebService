namespace BackAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RaclettePolls",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        User = c.String(),
                        Client = c.String(),
                        Like = c.Boolean(nullable: false),
                        Favorite = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.RaclettePolls");
        }
    }
}
