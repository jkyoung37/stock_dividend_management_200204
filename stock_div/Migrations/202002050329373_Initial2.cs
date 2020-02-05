namespace stock_div.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("public.Users", "delete_at", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("public.Users", "delete_at", c => c.DateTime(nullable: false));
        }
    }
}
