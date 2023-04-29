namespace customer_list.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SeedCustomersTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Customers (CustomerName, Address)Values('Ahmed', 'Cairo')");
            Sql("INSERT INTO Customers (CustomerName, Address)Values('Ali', 'Alex')");
        }

        public override void Down()
        {
        }
    }
}
