namespace stock_div.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class user : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.Users",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        email = c.String(),
                        password = c.String(),
                        createAt = c.DateTime(nullable: false),
                        deleteAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("public.Users");
        }
    }
}
