using KutuphaneKiralamaSistemi.Entities;
using KutuphaneKiralamaSistemi.ViewModels;
using System;
using System.Windows.Forms;

namespace KutuphaneKiralamaSistemi.Business
{
    public class KiralamaBusines
    {
        public int KiralamaYap(KiralamaViewModel KModel)
        {
            MyContext db = new MyContext();
            using (var tran = db.Database.BeginTransaction())
            {
                try
                {
                    var BilgiEkle = new KiralamaBilgisi()
                    {
                        KitapId = KModel.KitapId,
                        UyeId = KModel.UyeId,
                        KiraladigiTarih = KModel.SimdikiZaman,
                        TeslimEtti = false
                    };
                    db.KiralamaBilgileri.Add(BilgiEkle);
                    db.SaveChanges();

                    var uye = db.Uyeler.Find(KModel.UyeId);
                    uye.KitabıVarmı = true;
                    var kitap = db.Kitaplar.Find(KModel.KitapId);
                    kitap.Adet--;
                    db.SaveChanges();
                    tran.Commit();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show(ex.Message); ;
                }
            }
            return 1;
        }
    }
}