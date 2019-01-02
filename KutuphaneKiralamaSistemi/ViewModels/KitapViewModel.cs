namespace KutuphaneKiralamaSistemi.ViewModels
{
    public class KitapViewModel
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string YazarAdi { get; set; }
        public decimal Adet { get; set; }
        public int YazarId { get; set; }

        public override string ToString() => $"{Adi}+Stoktaki Adeti Sayisi --> ({Adet})";
    }
}