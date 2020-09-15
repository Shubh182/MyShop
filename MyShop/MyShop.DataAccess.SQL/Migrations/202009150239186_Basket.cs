namespace MyShop.DataAccess.SQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Basket : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BasketItems", "Quantity", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.BasketItems", "Quantity_HelpLink");
            DropColumn("dbo.BasketItems", "Quantity_Source");
            DropColumn("dbo.BasketItems", "Quantity_HResult");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BasketItems", "Quantity_HResult", c => c.Int(nullable: false));
            AddColumn("dbo.BasketItems", "Quantity_Source", c => c.String());
            AddColumn("dbo.BasketItems", "Quantity_HelpLink", c => c.String());
            AlterColumn("dbo.Products", "Price", c => c.String());
            DropColumn("dbo.BasketItems", "Quantity");
        }
    }
}
