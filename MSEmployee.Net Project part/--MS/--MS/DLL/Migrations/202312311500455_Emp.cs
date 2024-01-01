namespace DLL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Emp : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserQuestions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        Question = c.String(),
                        Answer = c.String(),
                        EmpId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Employees", "Email", c => c.String());
            AddColumn("dbo.Employees", "Password", c => c.String());
            AlterColumn("dbo.Employees", "Adress", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "Adress", c => c.Int(nullable: false));
            DropColumn("dbo.Employees", "Password");
            DropColumn("dbo.Employees", "Email");
            DropTable("dbo.UserQuestions");
        }
    }
}
