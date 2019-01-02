using System;

namespace KutuphaneKiralamaSistemi.ViewModels
{
    public class KiralamaViewModel
    {
        public int UyeId { get; set; }
        public int KitapId { get; set; }
        public bool UyeKitapAldi { get; set; }
        public decimal Adet { get; set; }
        public DateTime SimdikiZaman { get; set; } = DateTime.Now;
        public string UyeAdi { get; set; }
        public string UyeSoyadi { get; set; }
        public string VerilecekZaman { get; set; }
        public bool TesilEdildi { get; set; } = true;
        public string verilenKitapAdi { get; set; }
    }
}