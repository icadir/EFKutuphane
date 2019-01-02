namespace KutuphaneKiralamaSistemi.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class a1 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Kitaplar", "Adi", unique: true);
        }

        public override void Down()
        {
            DropIndex("dbo.Kitaplar", new[] { "Adi" });
        }
    }
}