namespace DataAccessor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Default_DepartmentAndStudent : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Hod = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Roll = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Department_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Roll)
                .ForeignKey("dbo.Departments", t => t.Department_Id, cascadeDelete: true)
                .Index(t => t.Department_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "Department_Id", "dbo.Departments");
            DropIndex("dbo.Students", new[] { "Department_Id" });
            DropTable("dbo.Students");
            DropTable("dbo.Departments");
        }
    }
}
