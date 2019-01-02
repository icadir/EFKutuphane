using KutuphaneKiralamaSistemi.ViewModels;
using System;
using System.Linq;

namespace KutuphaneKiralamaSistemi.DataHelper
{
    public class VeriGetirHelper
    {
        public static object VeriDoldur()
        {
            MyContext db = new MyContext();
            var deger = db.KiralamaBilgileri
                .Where(x => x.TeslimEtti == false)
                 .Select(x => new TeslimAlViewModel
                 {
                     KitapId = x.KitapId,
                     Uyeıd = x.UyeId,
                     KitapAdi = x.Kitap.Adi,
                     UyeAdi = x.Uye.Name,
                     UyeSoyadi = x.Uye.Surname,
                     Ucret = (decimal)x.Ucret
                 }).ToList();
            return deger;
        }

        public static object YazarlarıGetir()
        {
            MyContext db = new MyContext();

            try
            {
                var YazarGetir = db.Yazarlar
                       .OrderBy(x => x.Name).ThenBy(x => x.Surname)
                       .Select(x => new YazarViewModel
                       {
                           YazarId = x.Id,
                           Name = x.Name,
                           Surname = x.Surname
                       })
                       .ToList();
                return YazarGetir;
            }
            catch (Exception ex)
            {
                throw new Exception("Kayit Bulunamadi ", ex);
            }
        }

        public static object KitabıOlmayanUyeleriGetir()
        {
            MyContext db = new MyContext();
            try
            {
                var KOUyeler = db.Uyeler
                       .OrderBy(x => x.Name).ThenBy(x => x.Surname)
                       .Where(x => x.KitabıVarmı == false)
                       .Select(x => new UyeViewModel
                       {
                           Id = x.Id,
                           Name = x.Name,
                           Surname = x.Surname
                       }).ToList();
                return KOUyeler;
            }
            catch (Exception ex)
            {
                throw new Exception("Kayıt Yoktur Öncelikle Kayit Ekleyiniz.", ex);
            }
        }
        public static object KitabListesi()
        {
            MyContext db = new MyContext();
            try
            {
                var kitap = db.Kitaplar
                       .Select(x => new KitapViewModel
                       {
                           Adi = x.Adi,
                           Adet = x.Adet
                       })
                       .ToList();
                return kitap;
            }
            catch (Exception ex)
            {

                throw new Exception("Bir Hata Oluştu\nKayıtlı Kitap Olmayabilir.", ex);
            }
          
        }
       
    }
}