namespace KutuphaneKiralamaSistemi.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class xxxx : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.KiralamaDetaylar", "Ucret", c => c.Decimal(precision: 18, scale: 2));
        }

        public override void Down()
        {
            DropColumn("dbo.KiralamaDetaylar", "Ucret");
        }
    }
}