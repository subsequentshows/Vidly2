namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipTypeDatas : DbMigration
    {
        public override void Up()
        {
            
      Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonth, DiscountRate) VALUES (1, 0, 0, 0) ");
      Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonth, DiscountRate) VALUES (2, 30, 1, 10) ");
      Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonth, DiscountRate) VALUES (3, 90, 3, 15) "); 
      Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonth, DiscountRate) VALUES (4, 300, 12, 20) ");
      DropColumn("dbo.Customers", "TestProp");
    }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "TestProp", c => c.Int(nullable: false));
        }
    }
}
