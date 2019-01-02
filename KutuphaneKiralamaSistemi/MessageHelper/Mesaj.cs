using KutuphaneKiralamaSistemi.Entities;
using KutuphaneKiralamaSistemi.ViewModels;
using System.Windows.Forms;

namespace KutuphaneKiralamaSistemi.MessageHelper
{
    public class Mesaj
    {
        public static void KiralamaTamamlandi(KiralamaViewModel Bilgi)
        {
            MessageBox.Show($"{Bilgi.verilenKitapAdi.ToUpper()}'isimli kitap {Bilgi.UyeAdi} {Bilgi.UyeSoyadi.ToUpper()} adli Uyemize\n{Bilgi.VerilecekZaman}'ine kadar  Kiralanmıştır.\n ", "Kirama Yapıldı", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        public static void UyeEklendi(Uye Uye)
        {
            MessageBox.Show($"{Uye.Name} {Uye.Surname.ToUpper()} isimli uye sisteme eklenmistir.", "Uye Eklendi", MessageBoxButtons.OK);
        }

        public static void KitapEklendi(Kitap Kitap)
        {
            MessageBox.Show($"{Kitap.Adi} isimli kitap sisteme eklenmistir.", "Kitap Eklendi", MessageBoxButtons.OK);
        }

        public static void YazarEklendi(Yazar Yazar)
        {
            MessageBox.Show($"{Yazar.Name} {Yazar.Surname} isimli yazar sisteme eklenmistir.", "Yazar Eklendi", MessageBoxButtons.OK);
        }
    }
}