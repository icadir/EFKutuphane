using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KutuphaneKiralamaSistemi.Entities
{
    [Table("Kitaplar")]
    public class Kitap
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        [Required]
        [Index(IsUnique = true)]
        public string Adi { get; set; }

        [StringLength(2000)]
        public string Ozet { get; set; }

        public decimal Adet { get; set; } = 0;
        public int YazarId { get; set; }

        [ForeignKey("YazarId")]
        public virtual Yazar Yazar { get; set; }

        public virtual ICollection<KiralamaBilgisi> KiralamaDetalari { get; set; } = new HashSet<KiralamaBilgisi>();
    }
}