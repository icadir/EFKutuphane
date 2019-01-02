namespace Ef_CF1.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class a1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kategoriler",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    KategoriAdi = c.String(nullable: false, maxLength: 20),
                    Aciklama = c.String(maxLength: 200),
                    EklenmeZamani = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .Index(t => t.KategoriAdi, unique: true);
        }

        public override void Down()
        {
            DropIndex("dbo.Kategoriler", new[] { "KategoriAdi" });
            DropTable("dbo.Kategoriler");
        }
    }
}