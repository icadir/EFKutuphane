using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KutuphaneKiralamaSistemi.Entities
{
    [Table("Yazarlar")]
    public class Yazar
    {
        [Key]
        public int Id { get; set; }

        [StringLength(20, ErrorMessage = "20 Karakterden Fazla isim giremezsiniz.")]
        [Required]
        public string Name { get; set; }

        [StringLength(50)]
        [Required]
        public string Surname { get; set; }

        [StringLength(11, ErrorMessage = "TCKN 11 hane olmalidir."), MaxLength(11, ErrorMessage = "TCKN 11 hane olmalidir."), MinLength(11, ErrorMessage = "TCKN 11 hane olmalidir.")]
        [Required]
        [Index(IsUnique = true)]
        public string TCKN { get; set; }
    }
}