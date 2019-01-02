namespace KutuphaneKiralamaSistemi
{
    partial class RaporDetay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.btnKitabiOlmayanUyeler = new System.Windows.Forms.Button();
            this.lstUyeler = new System.Windows.Forms.ListBox();
            this.btnYazarlar = new System.Windows.Forms.Button();
            this.btnTumUyeler = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnUcretliUyeler = new System.Windows.Forms.Button();
            this.btnKayitliKitaplar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(52, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 77);
            this.button1.TabIndex = 1;
            this.button1.Text = "Kitabı Olan Üyeler";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnKitabiOlmayanUyeler
            // 
            this.btnKitabiOlmayanUyeler.BackColor = System.Drawing.Color.Gray;
            this.btnKitabiOlmayanUyeler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKitabiOlmayanUyeler.Location = new System.Drawing.Point(26, 127);
            this.btnKitabiOlmayanUyeler.Name = "btnKitabiOlmayanUyeler";
            this.btnKitabiOlmayanUyeler.Size = new System.Drawing.Size(129, 77);
            this.btnKitabiOlmayanUyeler.TabIndex = 3;
            this.btnKitabiOlmayanUyeler.Text = "Kitabı Olmayan Uyeler";
            this.btnKitabiOlmayanUyeler.UseVisualStyleBackColor = false;
            this.btnKitabiOlmayanUyeler.Click += new System.EventHandler(this.btnKitabiOlmayanUyeler_Click);
            // 
            // lstUyeler
            // 
            this.lstUyeler.FormattingEnabled = true;
            this.lstUyeler.Location = new System.Drawing.Point(421, 30);
            this.lstUyeler.Name = "lstUyeler";
            this.lstUyeler.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstUyeler.Size = new System.Drawing.Size(649, 290);
            this.lstUyeler.TabIndex = 4;
            this.lstUyeler.Visible = false;
            // 
            // btnYazarlar
            // 
            this.btnYazarlar.BackColor = System.Drawing.Color.Gray;
            this.btnYazarlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYazarlar.Location = new System.Drawing.Point(184, 30);
            this.btnYazarlar.Name = "btnYazarlar";
            this.btnYazarlar.Size = new System.Drawing.Size(129, 77);
            this.btnYazarlar.TabIndex = 5;
            this.btnYazarlar.Text = "Kayitli Yazarlar";
            this.btnYazarlar.UseVisualStyleBackColor = false;
            this.btnYazarlar.Click += new System.EventHandler(this.btnYazarlar_Click);
            // 
            // btnTumUyeler
            // 
            this.btnTumUyeler.BackColor = System.Drawing.Color.Gray;
            this.btnTumUyeler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTumUyeler.Location = new System.Drawing.Point(26, 30);
            this.btnTumUyeler.Name = "btnTumUyeler";
            this.btnTumUyeler.Size = new System.Drawing.Size(129, 77);
            this.btnTumUyeler.TabIndex = 6;
            this.btnTumUyeler.Text = "Kayitli Üyeler";
            this.btnTumUyeler.UseVisualStyleBackColor = false;
            this.btnTumUyeler.Click += new System.EventHandler(this.btnTumUyeler_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gray;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(26, 226);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 84);
            this.button3.TabIndex = 7;
            this.button3.Text = "Stokdaki Kitap Bilgisi";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnUcretliUyeler
            // 
            this.btnUcretliUyeler.BackColor = System.Drawing.Color.Gray;
            this.btnUcretliUyeler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUcretliUyeler.Location = new System.Drawing.Point(184, 226);
            this.btnUcretliUyeler.Name = "btnUcretliUyeler";
            this.btnUcretliUyeler.Size = new System.Drawing.Size(129, 84);
            this.btnUcretliUyeler.TabIndex = 8;
            this.btnUcretliUyeler.Text = "Ücreti Olan Üyeler";
            this.btnUcretliUyeler.UseVisualStyleBackColor = false;
            this.btnUcretliUyeler.Click += new System.EventHandler(this.btnUcretliUyeler_Click);
            // 
            // btnKayitliKitaplar
            // 
            this.btnKayitliKitaplar.BackColor = System.Drawing.Color.Gray;
            this.btnKayitliKitaplar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKayitliKitaplar.Location = new System.Drawing.Point(184, 127);
            this.btnKayitliKitaplar.Name = "btnKayitliKitaplar";
            this.btnKayitliKitaplar.Size = new System.Drawing.Size(129, 77);
            this.btnKayitliKitaplar.TabIndex = 9;
            this.btnKayitliKitaplar.Text = "Kayitli Kitaplar";
            this.btnKayitliKitaplar.UseVisualStyleBackColor = false;
            this.btnKayitliKitaplar.Click += new System.EventHandler(this.btnKayitliKitaplar_Click);
            // 
            // RaporDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1223, 493);
            this.Controls.Add(this.btnKayitliKitaplar);
            this.Controls.Add(this.btnUcretliUyeler);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnTumUyeler);
            this.Controls.Add(this.btnYazarlar);
            this.Controls.Add(this.lstUyeler);
            this.Controls.Add(this.btnKitabiOlmayanUyeler);
            this.Controls.Add(this.button1);
            this.Name = "RaporDetay";
            this.Text = "RaporDetay";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnKitabiOlmayanUyeler;
        private System.Windows.Forms.ListBox lstUyeler;
        private System.Windows.Forms.Button btnYazarlar;
        private System.Windows.Forms.Button btnTumUyeler;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnUcretliUyeler;
        private System.Windows.Forms.Button btnKayitliKitaplar;
    }
}