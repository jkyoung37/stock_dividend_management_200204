namespace stock_div.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class database2 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "public.Dividend", name: "user", newName: "users");
        }
        
        public override void Down()
        {
            RenameColumn(table: "public.Dividend", name: "users", newName: "user");
        }
    }
}
