namespace PopsConfectionary14.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class staff : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Staffs",
                c => new
                    {
                        StaffID = c.Int(nullable: false, identity: true),
                        StaffType = c.String(),
                        Name = c.String(),
                        Surname = c.String(),
                        ID_Number = c.String(),
                        Email = c.String(),
                        Confirm_Email = c.String(),
                        Contact = c.String(),
                        Atype = c.String(),
                        Address = c.String(),
                        Suburb = c.String(),
                        City = c.String(),
                        PC = c.String(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.StaffID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Staffs");
        }
    }
}
