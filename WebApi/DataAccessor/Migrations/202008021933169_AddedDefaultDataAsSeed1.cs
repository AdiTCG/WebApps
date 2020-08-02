namespace DataAccessor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDefaultDataAsSeed1 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Students", name: "Department_Id", newName: "DepartmentId");
            RenameIndex(table: "dbo.Students", name: "IX_Department_Id", newName: "IX_DepartmentId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Students", name: "IX_DepartmentId", newName: "IX_Department_Id");
            RenameColumn(table: "dbo.Students", name: "DepartmentId", newName: "Department_Id");
        }
    }
}
