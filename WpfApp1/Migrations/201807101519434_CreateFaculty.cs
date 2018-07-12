namespace WpfApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateFaculty : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Faculties",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Subject = c.String(),
                        Name = c.String(),
                        Age = c.Int(nullable: false),
                        Gender = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Students", "Address", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "Address");
            DropTable("dbo.Faculties");
        }
    }
}
