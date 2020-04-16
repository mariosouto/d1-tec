namespace Ejemplo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MaxLengthRestriction : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Devices", "Name", c => c.String(maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Devices", "Name", c => c.String());
        }
    }
}
