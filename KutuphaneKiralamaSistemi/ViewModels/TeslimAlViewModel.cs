namespace KutuphaneKiralamaSistemi.ViewModels
{
    public class TeslimAlViewModel
    {
        public int KitapId { get; set; }
        public int Uyeıd { get; set; }
        public string UyeAdi { get; set; }
        public string KitapAdi { get; set; }
        public string UyeSoyadi { get; set; }
        public decimal Ucret { get; set; }
        public bool KitabiVerdi { get; set; }

        public override string ToString() => $"{UyeAdi} {UyeSoyadi.ToUpper()} kiraladıgı kitap: {KitapAdi} odemesi gereken Ucret : {Ucret:c2}";
    }
}