using KutuphaneKiralamaSistemi.ViewModels;
using System.Data.Entity.Validation;
using System.Linq;
using System.Windows.Forms;

namespace KutuphaneKiralamaSistemi.Heşpers
{
    public class EntityHelper
    {
        public static string ValidationMessage(DbEntityValidationException ex)
        {
            var result = ex.EntityValidationErrors.Aggregate(string.Empty, (accumulator2, validationErrors) => validationErrors.ValidationErrors.Aggregate(accumulator2, (accumulator, validationError) => accumulator += $"Property: {validationError.PropertyName} Error: {validationError.ErrorMessage}\n"));
            return result + "\n";
        }

        public static void Kiralamamessage(KiralamaViewModel x)
        {
            MessageBox.Show($"{x.verilenKitapAdi.ToUpper()}'isimli kitap {x.UyeAdi} {x.UyeSoyadi.ToUpper()} adli Uyemize\n{x.VerilecekZaman}'ine kadar  Kiralanmıştır.\n ", "Kirama Yapıldı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}