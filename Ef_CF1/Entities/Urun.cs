using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ef_CF1.Entities
{
    [Table("Urunler")]
    public class Urun
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        [Required]
        [Index(IsUnique = true)]
        public string ProductName { get; set; }

        public decimal UnitPrice { get; set; }

        [Column("Eklenme", TypeName = "smalldatetime")]
        public DateTime EklenmeZamani { get; set; } = DateTime.Now;

        public int KategoriId { get; set; }

        [ForeignKey("KategoriId")]
        public virtual Kategori Kategori { get; set; }
    }
}