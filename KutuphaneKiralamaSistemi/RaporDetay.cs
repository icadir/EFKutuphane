using KutuphaneKiralamaSistemi.Business;
using KutuphaneKiralamaSistemi.ViewModels;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace KutuphaneKiralamaSistemi
{
    public partial class RaporDetay : Form
    {
        public RaporDetay()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyContext db = new MyContext();
            lstUyeler.DataSource = db.Uyeler
                .Where(x => x.KitabıVarmı == true)
                .OrderBy(x => x.Name).ThenBy(x => x.Surname)
                .Select(x => new UyeViewModel
                {
                    Name = x.Name,
                    Surname = x.Surname,
                }).ToList();
            lstUyeler.Visible = true;
        }

        private void btnKitabiOlmayanUyeler_Click(object sender, EventArgs e)
        {
            MyContext db = new MyContext();
            lstUyeler.DataSource = db.Uyeler
                .Where(x => x.KitabıVarmı == false)
                .OrderBy(x => x.Name).ThenBy(x => x.Surname)
                .Select(x => new UyeViewModel
                {
                    Name = x.Name,
                    Surname = x.Surname,
                }).ToList();
            lstUyeler.Visible = true;
        }

        private void btnTumUyeler_Click(object sender, EventArgs e)
        {
            MyContext db = new MyContext();
            lstUyeler.DataSource = db.Uyeler
                .OrderBy(x => x.Name).ThenBy(x => x.Surname)
                .Select(x => new UyeViewModel
                {
                    Name = x.Name,
                    Surname = x.Surname,
                }).ToList();
            lstUyeler.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MyContext db = new MyContext();
            var StokKitaplar = db.Kitaplar
               .Where(x => x.Adet >= 1)
               .OrderBy(x => x.Adi)
               .Select(x => new KitapViewModel
               {
                   Adi = x.Adi,
                   Adet = x.Adet,
               }).ToList();
            lstUyeler.DataSource = StokKitaplar;
            lstUyeler.Visible = true;
        }

        private void btnYazarlar_Click(object sender, EventArgs e)
        {
            MyContext db = new MyContext();
            lstUyeler.DataSource = db.Yazarlar
                .OrderBy(x => x.Name).ThenBy(x => x.Surname)
                .Select(x => new YazarViewModel
                {
                    Name = x.Name,
                    Surname = x.Surname,
                })
                .ToList();
            lstUyeler.Visible = true;
        }

        private void btnUcretliUyeler_Click(object sender, EventArgs e)
        {
            MyContext db = new MyContext();
            lstUyeler.DataSource = db.KiralamaBilgileri
                .Where(x => x.Ucret > 0)
                .Select(x => new UcretiOlanUyeleriHesaplaBusines
                {
                    KitapId = x.KitapId,
                    AldıgıKtap = x.Kitap.Adi,
                    UyeAdi = x.Uye.Name,
                    UyeSoyadi = x.Uye.Surname,
                    UyeId = x.UyeId,
                    VerilenTarih = x.KiraladigiTarih,
                    UcretX = (decimal)x.Ucret
                }).ToList();
            lstUyeler.Visible = true;
        }

        private void btnKayitliKitaplar_Click(object sender, EventArgs e)
        {
           lstUyeler.DataSource=DataHelper.VeriGetirHelper.KitabListesi();
          
            lstUyeler.Visible = true;
        }
    }
}