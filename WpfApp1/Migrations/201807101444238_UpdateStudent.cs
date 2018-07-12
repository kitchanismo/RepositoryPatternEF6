namespace WpfApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateStudent : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "Year", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "Year", c => c.DateTime(nullable: false));
        }
    }
}
