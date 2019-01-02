using Ef_CF1.Entities;
using System.Data.Entity;

namespace Ef_CF1
{
    internal class MyContext : DbContext
    {
        public MyContext() : base("name=MyCon")
        {
        }

        //Not:Kod iyileştirilirken (optimize) işe ilk önce kullanılmayan kod parçalarını silmekle başlayabiliriz. Peki her zaman değil de ara sıra kullanılan kodu iyileştirirken ne yapmalıyız? Sacece kullanılacağı zaman çalışmasını sağlamak! Bunun anlamı da Lazy Loading.O yüzden virtual.
        public virtual DbSet<Kategori> Kategoriler { get; set; }

        public virtual DbSet<Urun> Urunler { get; set; }
    }
}