namespace stock_div.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class user1 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "public.Users", name: "createAt", newName: "create_at");
            RenameColumn(table: "public.Users", name: "deleteAt", newName: "delete_at");
        }
        
        public override void Down()
        {
            RenameColumn(table: "public.Users", name: "delete_at", newName: "deleteAt");
            RenameColumn(table: "public.Users", name: "create_at", newName: "createAt");
        }
    }
}
