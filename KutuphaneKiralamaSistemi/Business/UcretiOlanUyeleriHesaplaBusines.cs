using System;
using System.Linq;

namespace KutuphaneKiralamaSistemi.Business
{
    public class UcretiOlanUyeleriHesaplaBusines
    {
        public int UyeId { get; set; }
        public int KitapId { get; set; }
        public string UyeAdi { get; set; }
        public string UyeSoyadi { get; set; }
        public string AldıgıKtap { get; set; }

        public DateTime SimdikiTarih { get; set; } = DateTime.Now.Date;

        public DateTime VerilenTarih { get; set; }

        public decimal UcretX;

        public decimal HesaplaUcretx()
        {
            TimeSpan Gun = SimdikiTarih - VerilenTarih;
            double gSayi = Gun.TotalMinutes;
            if (gSayi >= 8)
            {
                UcretX = (decimal)(gSayi - 7) * 5;
            }
            else
            {
                UcretX = 0;
            }
            MyContext db = new MyContext();
            var sorgux = db.KiralamaBilgileri
                 .Where(x => x.KitapId == this.KitapId && x.UyeId == this.UyeId)
                 .FirstOrDefault();
            sorgux.Ucret = UcretX;
            db.SaveChanges();
            return UcretX;
        }

        public override string ToString() => $"{UyeAdi} {UyeSoyadi} Kiraladığı kitap :  {AldıgıKtap} Ödemesi Gereken Ücret : {HesaplaUcretx():c2} ";
    }
}