using KutuphaneKiralamaSistemi.ViewModels;
using System;
using System.Linq;
using System.Windows.Forms;

namespace KutuphaneKiralamaSistemi.Business
{
    public class TeslimAlBussinessX
    {
        public int TeslimAl(TeslimAlViewModel TModel)
        {
            MyContext db = new MyContext();
            using (var tran = db.Database.BeginTransaction())
            {
                try
                {
                    var Duzelt = db.KiralamaBilgileri
                    .Where(x => x.KitapId == TModel.KitapId && x.UyeId == TModel.Uyeıd)
                    .FirstOrDefault();
                    //var bul = db.KiralamaBilgileri.fi(TModel.KitapId);
                    //bul.Ucret = (decimal)0;
                    //bul.Uye.KitabıVarmı = false;
                    //bul.TeslimEtti = true;
                    //Duzelt.
                    Duzelt.Ucret = (decimal)0;
                    Duzelt.TeslimEtti = true;
                    Duzelt.Uye.KitabıVarmı = false;
                    db.SaveChanges();

                    tran.Commit();
                    MessageBox.Show("Oldu Bu iş");
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show(ex.Message); ;
                }
            }
            return 1;
        }
    }
}