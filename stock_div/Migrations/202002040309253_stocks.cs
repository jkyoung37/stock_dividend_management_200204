namespace stock_div.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class stocks : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.Stocks",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        symbol = c.String(),
                        price = c.String(),
                        shares = c.String(),
                        create_at = c.DateTime(nullable: false),
                        delete_at = c.DateTime(nullable: false),
                        delete_flag = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("public.Stocks");
        }
    }
}
