namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyAnnotationsToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "PhoneNumber", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "Province", c => c.String());
            AddColumn("dbo.Customers", "ReferralCode", c => c.String(maxLength: 50));
            AddColumn("dbo.Customers", "RegisterdTime", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "RegisterdDate", c => c.Int(nullable: false));
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Name", c => c.String());
            DropColumn("dbo.Customers", "RegisterdDate");
            DropColumn("dbo.Customers", "RegisterdTime");
            DropColumn("dbo.Customers", "ReferralCode");
            DropColumn("dbo.Customers", "Province");
            DropColumn("dbo.Customers", "PhoneNumber");
        }
    }
}
