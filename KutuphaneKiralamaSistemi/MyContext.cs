using KutuphaneKiralamaSistemi.Entities;
using System.Data.Entity;

namespace KutuphaneKiralamaSistemi
{
    public class MyContext : DbContext
    {
        public MyContext() : base("name=MyLib")
        {
        }

        public virtual DbSet<Uye> Uyeler { get; set; }
        public virtual DbSet<Kitap> Kitaplar { get; set; }
        public virtual DbSet<Yazar> Yazarlar { get; set; }
        public virtual DbSet<KiralamaBilgisi> KiralamaBilgileri { get; set; }
    }
}