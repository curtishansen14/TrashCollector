namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedidtoint : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.CustomerModels");
            AlterColumn("dbo.CustomerModels", "ID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.CustomerModels", "ID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.CustomerModels");
            AlterColumn("dbo.CustomerModels", "ID", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.CustomerModels", "ID");
        }
    }
}
