using System;
using System.Linq;
using System.Windows.Forms;

namespace Ef_CF1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MyContext db = new MyContext();
            this.Text = db.Kategoriler.Count() + "Adet Kategori bulunuyor";
        }
    }
}