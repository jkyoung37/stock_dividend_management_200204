namespace stock_div.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class databases1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("public.Stocks", "delete_flag", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("public.Stocks", "delete_flag");
        }
    }
}
