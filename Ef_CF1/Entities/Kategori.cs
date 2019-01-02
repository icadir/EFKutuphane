using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ef_CF1.Entities
{
    [Table("Kategoriler")]
    public class Kategori
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Kategori adi 20 karakterden fazla olamaz.", MinimumLength = 2)]
        [Index(IsUnique = true)]
        public string KategoriAdi { get; set; }

        [StringLength(200)]
        public string Aciklama { get; set; }

        public DateTime EklenmeZamani { get; set; } = DateTime.Now;

        public virtual ICollection<Urun> Urunler { get; set; } = new HashSet<Urun>();
    }
}