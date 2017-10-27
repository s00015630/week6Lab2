namespace S00015630Rad2017Mvc1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class names : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String());
            AddColumn("dbo.AspNetUsers", "Surname", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Surname");
            DropColumn("dbo.AspNetUsers", "FirstName");
        }
    }
}
