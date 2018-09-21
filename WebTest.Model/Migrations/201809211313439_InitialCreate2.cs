namespace WebTest.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Person", "Alias");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Person", "Alias", c => c.String());
        }
    }
}
