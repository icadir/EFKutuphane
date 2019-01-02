using KutuphaneKiralamaSistemi.Business;
using KutuphaneKiralamaSistemi.DataHelper;
using KutuphaneKiralamaSistemi.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace KutuphaneKiralamaSistemi
{
    public partial class TeslilmAl : Form
    {
        public TeslilmAl()
        {
            InitializeComponent();
        }

        private void TeslilmAl_Load(object sender, EventArgs e)
        {
            lstKitabıOlanUyeler.DataSource = VeriGetirHelper.VeriDoldur();
        }

        private void teslimAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstKitabıOlanUyeler.SelectedItem == null) return;
            MyContext db = new MyContext();
            try
            {
                var Teslim = new TeslimAlBussinessX();
                var TModel = lstKitabıOlanUyeler.SelectedItem as TeslimAlViewModel;
                var KayitNo = Teslim.TeslimAl(TModel);
                MessageBox.Show($"{KayitNo} Kayit Guncellendi\nTeslim Alindi.", "Teslim Alindi.", MessageBoxButtons.OK, MessageBoxIcon.None);
                lstKitabıOlanUyeler.DataSource = VeriGetirHelper.VeriDoldur();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); ;
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            string ara = textBox1.Text.ToLower();
            MyContext db = new MyContext();
            List<TeslimAlViewModel> bulunanlar = new List<TeslimAlViewModel>();
            db.KiralamaBilgileri
                .Where(x => x.Uye.Name.ToLower().Contains(ara) || x.Uye.Surname.ToLower().Contains(ara) || x.Uye.TCKN.ToLower().Contains(ara) || x.Kitap.Adi.ToLower().Contains(ara)).ToList()
                .ForEach(x => bulunanlar.Add(new TeslimAlViewModel()
                {
                    KitapId = x.KitapId,
                    Uyeıd = x.UyeId,
                    KitapAdi = x.Kitap.Adi,
                    UyeAdi = x.Uye.Name,
                    UyeSoyadi = x.Uye.Surname,
                    Ucret = (decimal)x.Ucret
                }));
            lstKitabıOlanUyeler.DataSource = bulunanlar;
        }
    }
}