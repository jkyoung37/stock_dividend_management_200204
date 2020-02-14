namespace stock_div.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class databases : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.Stocks",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        symbol = c.String(nullable: false),
                        price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        shares = c.Decimal(nullable: false, precision: 18, scale: 2),
                        user = c.String(),
                        create_at = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "public.Users",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        email = c.String(),
                        password = c.String(),
                        first_name = c.String(),
                        last_name = c.String(),
                        create_at = c.DateTime(nullable: false),
                        delete_at = c.DateTime(),
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
