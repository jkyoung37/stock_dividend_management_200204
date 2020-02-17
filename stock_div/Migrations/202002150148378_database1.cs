namespace stock_div.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class database1 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "public.Stocks", name: "user", newName: "users");
        }
        
        public override void Down()
        {
            RenameColumn(table: "public.Stocks", name: "users", newName: "user");
        }
    }
}
