namespace KutuphaneKiralamaSistemi.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class x : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KiralamaDetaylar",
                c => new
                {
                    KitapId = c.Int(nullable: false),
                    UyeId = c.Int(nullable: false),
                    KiralandıgıTarih = c.DateTime(nullable: false, storeType: "date"),
                    TeslimEtti = c.Boolean(nullable: false),
                })
                .PrimaryKey(t => new { t.KitapId, t.UyeId })
                .ForeignKey("dbo.Kitaplar", t => t.KitapId, cascadeDelete: true)
                .ForeignKey("dbo.Uyes", t => t.UyeId, cascadeDelete: true)
                .Index(t => t.KitapId)
                .Index(t => t.UyeId);

            CreateTable(
                "dbo.Kitaplar",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Adi = c.String(nullable: false, maxLength: 50),
                    Ozet = c.String(maxLength: 2000),
                    Adet = c.Decimal(nullable: false, precision: 18, scale: 2),
                    YazarId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Yazarlar", t => t.YazarId, cascadeDelete: true)
                .Index(t => t.YazarId);

            CreateTable(
                "dbo.Yazarlar",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false, maxLength: 20),
                    Surname = c.String(nullable: false, maxLength: 50),
                    TCKN = c.String(nullable: false, maxLength: 11),
                })
                .PrimaryKey(t => t.Id)
                .Index(t => t.TCKN, unique: true);

            CreateTable(
                "dbo.Uyes",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false, maxLength: 20),
                    Surname = c.String(nullable: false, maxLength: 50),
                    TCKN = c.String(nullable: false, maxLength: 11),
                    KitabıVarmı = c.Boolean(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .Index(t => t.TCKN, unique: true);
        }

        public override void Down()
        {
            DropForeignKey("dbo.KiralamaDetaylar", "UyeId", "dbo.Uyes");
            DropForeignKey("dbo.Kitaplar", "YazarId", "dbo.Yazarlar");
            DropForeignKey("dbo.KiralamaDetaylar", "KitapId", "dbo.Kitaplar");
            DropIndex("dbo.Uyes", new[] { "TCKN" });
            DropIndex("dbo.Yazarlar", new[] { "TCKN" });
            DropIndex("dbo.Kitaplar", new[] { "YazarId" });
            DropIndex("dbo.KiralamaDetaylar", new[] { "UyeId" });
            DropIndex("dbo.KiralamaDetaylar", new[] { "KitapId" });
            DropTable("dbo.Uyes");
            DropTable("dbo.Yazarlar");
            DropTable("dbo.Kitaplar");
            DropTable("dbo.KiralamaDetaylar");
        }
    }
}