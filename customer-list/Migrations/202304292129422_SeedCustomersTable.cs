namespace customer_list.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SeedCustomersTable : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers (CustomerName, Address)Values('Ahmed', 'Cairo')");
            Sql("UPDATE Customers (CustomerName, Address)Values('Ali', 'ALX')");
        }

        public override void Down()
        {
        }
    }
}
