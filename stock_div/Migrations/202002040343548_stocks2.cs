namespace stock_div.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class stocks2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("public.Stocks", "user", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("public.Stocks", "user");
        }
    }
}
