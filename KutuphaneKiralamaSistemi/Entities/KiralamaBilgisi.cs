using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KutuphaneKiralamaSistemi.Entities
{
    [Table("KiralamaDetaylar")]
    public class KiralamaBilgisi
    {
        [Key]
        [Column(Order = 1)]
        public int KitapId { get; set; }

        [Key]
        [Column(Order = 2)]
        public int UyeId { get; set; }

        [Column("KiralandıgıTarih", TypeName = "date")]
        public DateTime KiraladigiTarih { get; set; } = DateTime.Now;

        public bool TeslimEtti { get; set; } = false;

        public decimal? Ucret { get; set; } = 0;

        [ForeignKey("KitapId")]
        public virtual Kitap Kitap { get; set; }

        [ForeignKey("UyeId")]
        public virtual Uye Uye { get; set; }
    }
}