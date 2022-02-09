namespace Technovert.BankApp.CLI_Migrations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        AccId = c.String(nullable: false, maxLength: 128),
                        AccName = c.String(),
                        BankId = c.String(),
                        Banks_BankId = c.Int(),
                    })
                .PrimaryKey(t => t.AccId)
                .ForeignKey("dbo.Banks", t => t.Banks_BankId)
                .Index(t => t.Banks_BankId);
            
            CreateTable(
                "dbo.Banks",
                c => new
                    {
                        BankId = c.Int(nullable: false, identity: true),
                        BankName = c.String(),
                    })
                .PrimaryKey(t => t.BankId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Accounts", "Banks_BankId", "dbo.Banks");
            DropIndex("dbo.Accounts", new[] { "Banks_BankId" });
            DropTable("dbo.Banks");
            DropTable("dbo.Accounts");
        }
    }
}
