namespace stock_div.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class stocks1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("public.Stocks", "symbol", c => c.String(nullable: false));
            AlterColumn("public.Stocks", "price", c => c.String(nullable: false));
            AlterColumn("public.Stocks", "shares", c => c.String(nullable: false));
            AlterColumn("public.Stocks", "delete_at", c => c.DateTime());
            AlterColumn("public.Stocks", "delete_flag", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("public.Stocks", "delete_flag", c => c.Int(nullable: false));
            AlterColumn("public.Stocks", "delete_at", c => c.DateTime(nullable: false));
            AlterColumn("public.Stocks", "shares", c => c.String());
            AlterColumn("public.Stocks", "price", c => c.String());
            AlterColumn("public.Stocks", "symbol", c => c.String());
        }
    }
}
