using KutuphaneKiralamaSistemi.Business;
using KutuphaneKiralamaSistemi.Entities;
using KutuphaneKiralamaSistemi.Heşpers;
using KutuphaneKiralamaSistemi.MessageHelper;
using KutuphaneKiralamaSistemi.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace KutuphaneKiralamaSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYazarPanel_Click(object sender, EventArgs e)
        {
            FormuTemizle(this.panelYazar);
            panelYazar.Visible = true;
            panelUyeKaydet.Visible = false;
            PanelKitapKaydet.Visible = false;
            PanelKiralama.Visible = false;
        }

        private void btnUyePanel_Click(object sender, EventArgs e)
        {
            FormuTemizle(this.panelUyeKaydet);
            panelUyeKaydet.Visible = true;
            PanelKitapKaydet.Visible = false;
            panelYazar.Visible = false;
            PanelKiralama.Visible = false;
        }

        private void btnKitapPanel_Click(object sender, EventArgs e)
        {
            MyContext db = new MyContext();
            FormuTemizle(this.PanelKitapKaydet);
            PanelKitapKaydet.Visible = true;
            panelYazar.Visible = false;
            panelUyeKaydet.Visible = false;
            cmbYazarSec.DataSource = db.Yazarlar
                .Select(x => new YazarViewModel
                {
                    YazarId = x.Id,
                    Name = x.Name,
                    Surname = x.Surname
                })
                .ToList();
            PanelKiralama.Visible = false;
            nuAdet.Value = 1;
        }

        private void FormuTemizle(Control Parent)
        {
            foreach (Control control in Parent.Controls)
            {
                if (control is TextBox)
                    control.Text = string.Empty;

                if (control is RichTextBox)
                    control.Text = string.Empty;
                if (control is ListBox lstBox)
                    lstBox.Items.Clear();
            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnKitapKiralaEkran_Click(object sender, EventArgs e)
        {
            lstYazarlar.DataSource = DataHelper.VeriGetirHelper.YazarlarıGetir();
            lstUyeler.DataSource = DataHelper.VeriGetirHelper.KitabıOlmayanUyeleriGetir();
            txtKitapAra.Visible = true;
            lstKitaplar.Visible = true;
            lstUyeler.Visible = true;
            txtUyeAra.Visible = true;
            lstYazarlar.Visible = true;
            txtYazarAra.Visible = true;
            panelUyeKaydet.Visible = false;
            PanelKitapKaydet.Visible = false;
            panelYazar.Visible = false;
            //VerileriDoldur();
            PanelKiralama.Visible = true;
        }

        private void txtYazarAra_KeyPress(object sender, KeyPressEventArgs e)
        {
            string ara = txtYazarAra.Text.ToLower();
            MyContext db = new MyContext();
            List<YazarViewModel> bulunanlar = new List<YazarViewModel>();
            db.Yazarlar
                .Where(x => x.Name.ToLower().Contains(ara) || x.Surname.ToLower().Contains(ara) || x.TCKN.ToLower().Contains(ara)).ToList()
                .ForEach(x => bulunanlar.Add(new YazarViewModel()
                {
                    Name = x.Name,
                    Surname = x.Surname
                }));
            lstYazarlar.DataSource = bulunanlar;
        }

        private void txtKitapAra_KeyUp(object sender, KeyEventArgs e)
        {
            string ara = txtKitapAra.Text.ToLower();

            MyContext db = new MyContext();
            List<KitapViewModel> bulunanalar = new List<KitapViewModel>();
            db.Kitaplar
                .Where(x => x.Adi.ToLower().Contains(ara) || x.Yazar.Name.ToLower().Contains(ara))
                .ToList()
                .ForEach(x => bulunanalar.Add(new KitapViewModel
                {
                    Adi = x.Adi,
                    YazarAdi = x.Yazar.Name,
                    Adet = x.Adet,
                    Id = x.Id
                }));
            lstKitaplar.DataSource = bulunanalar;
        }

        private void txtUyeAra_KeyUp(object sender, KeyEventArgs e)
        {
            string ara = txtUyeAra.Text.ToLower();
            MyContext db = new MyContext();
            List<UyeViewModel> bulunanlar = new List<UyeViewModel>();
            db.Uyeler
                .Where(x => x.Name.ToLower().Contains(ara) || x.Surname.ToLower().Contains(ara) || x.TCKN.ToLower().Contains(ara)).ToList()
                .ForEach(x => bulunanlar.Add(new UyeViewModel()
                {
                    Name = x.Name,
                    Surname = x.Surname
                }));
            lstUyeler.DataSource = bulunanlar;
        }

        private void btnYazarKaydet_Click(object sender, EventArgs e)
        {
            MyContext db = new MyContext();
            try
            {
                var yazar = new Yazar()
                {
                    Name = txtYazarAd.Text,
                    Surname = txtYazarSoyad.Text,
                    TCKN = txtYazarTckn.Text
                };
                db.Yazarlar.Add(yazar);
                db.SaveChanges();
                Mesaj.YazarEklendi(yazar);
                panelYazar.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUyeKaydet_Click(object sender, EventArgs e)
        {
            MyContext db = new MyContext();
            try
            {
                var uye = new Uye()
                {
                    Name = txtUyeAd.Text,
                    Surname = txtUyeSoyad.Text,
                    TCKN = txtUyeTCKN.Text
                };
                db.Uyeler.Add(uye);
                db.SaveChanges();
                Mesaj.UyeEklendi(uye);
                panelUyeKaydet.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnKitapKaydet_Click(object sender, EventArgs e)
        {
           
            MyContext db = new MyContext();
            try
            {
                var kitap = new Kitap()
                {
                    Adet = nuAdet.Value,
                    Adi = txtKitapAdi.Text,
                    Ozet = txtOzet.Text,
                    YazarId = (cmbYazarSec.SelectedItem as YazarViewModel).YazarId
                };
                //KontrolEt(kitap);
                db.Kitaplar.Add(kitap);

                db.SaveChanges();
                Mesaj.KitapEklendi(kitap);
                PanelKitapKaydet.Visible = false;
            }
            catch (Exception)
            {
                throw;
            }
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        //private void VerileriDoldur()
        //{
        //    MyContext db = new MyContext();
        //    lstYazarlar.DataSource = db.Yazarlar
        //        .OrderBy(x => x.Name).ThenBy(x => x.Surname)
        //        .Select(x => new YazarViewModel
        //        {
        //            YazarId = x.Id,
        //            Name = x.Name,
        //            Surname = x.Surname
        //        })
        //        .ToList();
        //    var tumuyeler = db.Uyeler
        //         .OrderBy(x => x.Name).ThenBy(x => x.Surname)
        //         .Where(x => x.KitabıVarmı == false)
        //         .Select(x => new UyeViewModel
        //         {
        //             Id = x.Id,
        //             Name = x.Name,
        //             Surname = x.Surname
        //         }).ToList();
        //    lstUyeler.DataSource = tumuyeler;
        //    //var tumKitaplar = db.Kitaplar
        //    //    .OrderBy(x => x.Adi)
        //    //    .Where(x => x.Adet >= 0)
        //    //    .Select(x => new KitapViewModel
        //    //    {
        //    //        Adi = x.Adi,
        //    //        Adet = x.Adet,
        //    //        Id = x.Id
        //    //    }).ToList();
        //    //var KitabıOlmayanUyeler = db.Uyeler
        //    //    .Where(x => x.KitabıVarmı == false)
        //    //    .Select(x => new UyeViewModel
        //    //    {
        //    //        Id=x.Id,
        //    //        Name = x.Name,
        //    //        Surname = x.Surname

        //    //    }).ToList();

        //    lstUyeler.DataSource = tumuyeler;
        //    //lstKitaplar.DataSource = tumKitaplar;
        //}

        private YazarViewModel seciliYazar;

        private void lstYazarlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstYazarlar.SelectedItem == null) return;
            MyContext db = new MyContext();
            seciliYazar = lstYazarlar.SelectedItem as YazarViewModel;
            var kitapsorgu = db.Kitaplar
                  .Where(x => x.YazarId == seciliYazar.YazarId && x.Adet >= 1)
                  .Select(x => new KitapViewModel
                  {
                      Adet = x.Adet,
                      Adi = x.Adi,
                      Id = x.Id
                  }).ToList();
            lstKitaplar.DataSource = kitapsorgu;
        }

       

        private void btnKirala_Click(object sender, EventArgs e)
        {
            if (lstUyeler.SelectedItem == null || lstKitaplar.SelectedItem == null || lstYazarlar.SelectedItem == null) return;
           
            try
            {
                var Kiralama = new KiralamaBusines();
                var Kmodel = new KiralamaViewModel()
                {
                    UyeId = (lstUyeler.SelectedItem as UyeViewModel).Id,
                    UyeSoyadi = (lstUyeler.SelectedItem as UyeViewModel).Surname,
                    UyeAdi = (lstUyeler.SelectedItem as UyeViewModel).Name,
                    UyeKitapAldi = (lstUyeler.SelectedItem as UyeViewModel).KitabıVarmı = true,
                    verilenKitapAdi = (lstKitaplar.SelectedItem as KitapViewModel).Adi,
                    Adet = (lstKitaplar.SelectedItem as KitapViewModel).Adet,
                    VerilecekZaman = DateTime.Now.AddDays(7).ToLongDateString(),
                    KitapId = (lstKitaplar.SelectedItem as KitapViewModel).Id,
                    SimdikiZaman = DateTime.Now.Date,
                    TesilEdildi = false
                };
                var Kayitno = Kiralama.KiralamaYap(Kmodel);
                EntityHelper.Kiralamamessage(Kmodel);

                lstYazarlar.DataSource = DataHelper.VeriGetirHelper.YazarlarıGetir();
                lstUyeler.DataSource = DataHelper.VeriGetirHelper.KitabıOlmayanUyeleriGetir();
                //VerileriDoldur();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); ;
            }
        }

        private void lstKitaplar_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            RaporDetay Form = new RaporDetay();
            Form.Show();
        }

        private void btnKiapTeslimAl_Click(object sender, EventArgs e)
        {
            TeslilmAl Form = new TeslilmAl();
            Form.Show();
        }

      
    }
}