namespace stock_div.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("public.Users", "first_name", c => c.String());
            AddColumn("public.Users", "last_name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("public.Users", "last_name");
            DropColumn("public.Users", "first_name");
        }
    }
}
