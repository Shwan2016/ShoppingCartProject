namespace ShoppingCart.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateManufacturer : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Manufacturers (Name, PhoneNumber) VALUES ('Sony', 18002227669 )");
            Sql("INSERT INTO Manufacturers (Name, PhoneNumber) VALUES ('Samsung', 8886654228 )");
            Sql("INSERT INTO Manufacturers (Name, PhoneNumber) VALUES ('Nokia', 18002227669 )");
            Sql("INSERT INTO Manufacturers (Name, PhoneNumber) VALUES ('Apple', 18006927753 )");
        }
        
        public override void Down()
        {
        }
    }
}
