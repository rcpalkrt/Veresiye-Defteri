namespace WFBakkal_Defter.Forms.HesapForms
{
    partial class FrmMBorcEkle
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbUrunler = new System.Windows.Forms.ComboBox();
            this.txtUrunFiyat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numUrunMiktar = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBirim = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBorcMiktar = new System.Windows.Forms.TextBox();
            this.chOdemeVadeT = new System.Windows.Forms.CheckBox();
            this.dtVadeTarihi = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtIslemTarihi = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUrunMiktar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Satılan Ürün/Yapılan İş";
            // 
            // cmbUrunler
            // 
            this.cmbUrunler.DisplayMember = "Ad";
            this.cmbUrunler.FormattingEnabled = true;
            this.cmbUrunler.Location = new System.Drawing.Point(182, 18);
            this.cmbUrunler.Name = "cmbUrunler";
            this.cmbUrunler.Size = new System.Drawing.Size(284, 23);
            this.cmbUrunler.TabIndex = 1;
            this.cmbUrunler.ValueMember = "ID";
            this.cmbUrunler.SelectedIndexChanged += new System.EventHandler(this.cmbUrunler_SelectedIndexChanged);
            // 
            // txtUrunFiyat
            // 
            this.txtUrunFiyat.Location = new System.Drawing.Point(182, 47);
            this.txtUrunFiyat.Name = "txtUrunFiyat";
            this.txtUrunFiyat.Size = new System.Drawing.Size(284, 21);
            this.txtUrunFiyat.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fiyatı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Miktarı";
            // 
            // numUrunMiktar
            // 
            this.numUrunMiktar.Location = new System.Drawing.Point(182, 75);
            this.numUrunMiktar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUrunMiktar.Name = "numUrunMiktar";
            this.numUrunMiktar.Size = new System.Drawing.Size(81, 21);
            this.numUrunMiktar.TabIndex = 3;
            this.numUrunMiktar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUrunMiktar.ValueChanged += new System.EventHandler(this.numUrunMiktar_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Birim";
            // 
            // cmbBirim
            // 
            this.cmbBirim.FormattingEnabled = true;
            this.cmbBirim.Location = new System.Drawing.Point(316, 74);
            this.cmbBirim.Name = "cmbBirim";
            this.cmbBirim.Size = new System.Drawing.Size(150, 23);
            this.cmbBirim.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Borç Miktarı";
            // 
            // txtBorcMiktar
            // 
            this.txtBorcMiktar.Location = new System.Drawing.Point(182, 102);
            this.txtBorcMiktar.Name = "txtBorcMiktar";
            this.txtBorcMiktar.Size = new System.Drawing.Size(284, 21);
            this.txtBorcMiktar.TabIndex = 2;
            // 
            // chOdemeVadeT
            // 
            this.chOdemeVadeT.AutoSize = true;
            this.chOdemeVadeT.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chOdemeVadeT.Location = new System.Drawing.Point(12, 134);
            this.chOdemeVadeT.Name = "chOdemeVadeT";
            this.chOdemeVadeT.Size = new System.Drawing.Size(149, 19);
            this.chOdemeVadeT.TabIndex = 4;
            this.chOdemeVadeT.Text = "Ödeme Sözü Tarihi";
            this.chOdemeVadeT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chOdemeVadeT.UseVisualStyleBackColor = true;
            this.chOdemeVadeT.CheckedChanged += new System.EventHandler(this.chOdemeVadeT_CheckedChanged);
            // 
            // dtVadeTarihi
            // 
            this.dtVadeTarihi.Enabled = false;
            this.dtVadeTarihi.Location = new System.Drawing.Point(182, 132);
            this.dtVadeTarihi.Name = "dtVadeTarihi";
            this.dtVadeTarihi.Size = new System.Drawing.Size(284, 21);
            this.dtVadeTarihi.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "İşlem Tarihi";
            // 
            // dtIslemTarihi
            // 
            this.dtIslemTarihi.Location = new System.Drawing.Point(182, 159);
            this.dtIslemTarihi.Name = "dtIslemTarihi";
            this.dtIslemTarihi.Size = new System.Drawing.Size(284, 21);
            this.dtIslemTarihi.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Açıklama";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(182, 186);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(284, 67);
            this.txtAciklama.TabIndex = 2;
            // 
            // btnKapat
            // 
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Image = global::WFBakkal_Defter.Properties.Resources.shut_down_icon;
            this.btnKapat.Location = new System.Drawing.Point(377, 259);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(89, 60);
            this.btnKapat.TabIndex = 6;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.FlatAppearance.BorderSize = 0;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Image = global::WFBakkal_Defter.Properties.Resources.ok_appproval_acceptance;
            this.btnKaydet.Location = new System.Drawing.Point(284, 259);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(87, 60);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // FrmMBorcEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(473, 329);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.dtIslemTarihi);
            this.Controls.Add(this.dtVadeTarihi);
            this.Controls.Add(this.chOdemeVadeT);
            this.Controls.Add(this.numUrunMiktar);
            this.Controls.Add(this.txtBorcMiktar);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtUrunFiyat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbBirim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbUrunler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmMBorcEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borç Ekle";
            this.Load += new System.EventHandler(this.FrmMBorcEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUrunMiktar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbUrunler;
        private System.Windows.Forms.TextBox txtUrunFiyat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numUrunMiktar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBirim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBorcMiktar;
        private System.Windows.Forms.CheckBox chOdemeVadeT;
        private System.Windows.Forms.DateTimePicker dtVadeTarihi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtIslemTarihi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnKaydet;
    }
}