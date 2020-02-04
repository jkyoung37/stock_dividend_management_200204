namespace stock_div.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.Stocks",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        symbol = c.String(nullable: false),
                        price = c.Int(nullable: false),
                        shares = c.String(nullable: false),
                        user = c.String(),
                        create_at = c.DateTime(nullable: false),
                        delete_at = c.DateTime(),
                        delete_flag = c.Int(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "public.Users",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        email = c.String(),
                        password = c.String(),
                        create_at = c.DateTime(nullable: false),
                        delete_at = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("public.Users");
            DropTable("public.Stocks");
        }
    }
}
