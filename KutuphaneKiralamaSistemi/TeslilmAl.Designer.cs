namespace KutuphaneKiralamaSistemi
{
    partial class TeslilmAl
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
            this.components = new System.ComponentModel.Container();
            this.cmsGeriAl = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.teslimAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstKitabıOlanUyeler = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmsGeriAl.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsGeriAl
            // 
            this.cmsGeriAl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teslimAlToolStripMenuItem});
            this.cmsGeriAl.Name = "cmsGeriAl";
            this.cmsGeriAl.Size = new System.Drawing.Size(123, 26);
            // 
            // teslimAlToolStripMenuItem
            // 
            this.teslimAlToolStripMenuItem.Name = "teslimAlToolStripMenuItem";
            this.teslimAlToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.teslimAlToolStripMenuItem.Text = "Teslim Al";
            this.teslimAlToolStripMenuItem.Click += new System.EventHandler(this.teslimAlToolStripMenuItem_Click);
            // 
            // lstKitabıOlanUyeler
            // 
            this.lstKitabıOlanUyeler.ContextMenuStrip = this.cmsGeriAl;
            this.lstKitabıOlanUyeler.FormattingEnabled = true;
            this.lstKitabıOlanUyeler.Location = new System.Drawing.Point(141, 50);
            this.lstKitabıOlanUyeler.Name = "lstKitabıOlanUyeler";
            this.lstKitabıOlanUyeler.Size = new System.Drawing.Size(695, 368);
            this.lstKitabıOlanUyeler.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(195, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(641, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(141, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ara";
            // 
            // TeslilmAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1163, 480);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lstKitabıOlanUyeler);
            this.Name = "TeslilmAl";
            this.Text = "TeslilmAl";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TeslilmAl_Load);
            this.cmsGeriAl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip cmsGeriAl;
        private System.Windows.Forms.ToolStripMenuItem teslimAlToolStripMenuItem;
        private System.Windows.Forms.ListBox lstKitabıOlanUyeler;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}