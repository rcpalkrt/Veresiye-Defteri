namespace WFBakkal_Defter
{
    partial class AnaForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpHizliIslem = new System.Windows.Forms.TabPage();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnCekDefteri = new System.Windows.Forms.Button();
            this.btnKasaDefteri = new System.Windows.Forms.Button();
            this.btnTedarikDefter = new System.Windows.Forms.Button();
            this.btnPesinSatis = new System.Windows.Forms.Button();
            this.btnVadeliSatis = new System.Windows.Forms.Button();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.tpMusteriIslem = new System.Windows.Forms.TabPage();
            this.btn_MusteriDuzenle = new System.Windows.Forms.Button();
            this.btn_MusteriEkle = new System.Windows.Forms.Button();
            this.tpUrunIslem = new System.Windows.Forms.TabPage();
            this.btnZamUygula = new System.Windows.Forms.Button();
            this.btnUrunDuzenleSil = new System.Windows.Forms.Button();
            this.btn_UrunEkle = new System.Windows.Forms.Button();
            this.tpHesapIslem = new System.Windows.Forms.TabPage();
            this.btn_PesinSatis = new System.Windows.Forms.Button();
            this.btn_VadeliSatis = new System.Windows.Forms.Button();
            this.tpKasaIslem = new System.Windows.Forms.TabPage();
            this.btn_KasaDefteri = new System.Windows.Forms.Button();
            this.tpTedarikIslem = new System.Windows.Forms.TabPage();
            this.btnTedarikciDuzenle = new System.Windows.Forms.Button();
            this.btnTedarikciEkle = new System.Windows.Forms.Button();
            this.btn_TedarikciDefteri = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tpHizliIslem.SuspendLayout();
            this.tpMusteriIslem.SuspendLayout();
            this.tpUrunIslem.SuspendLayout();
            this.tpHesapIslem.SuspendLayout();
            this.tpKasaIslem.SuspendLayout();
            this.tpTedarikIslem.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpHizliIslem);
            this.tabControl1.Controls.Add(this.tpMusteriIslem);
            this.tabControl1.Controls.Add(this.tpUrunIslem);
            this.tabControl1.Controls.Add(this.tpHesapIslem);
            this.tabControl1.Controls.Add(this.tpKasaIslem);
            this.tabControl1.Controls.Add(this.tpTedarikIslem);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1388, 121);
            this.tabControl1.TabIndex = 0;
            // 
            // tpHizliIslem
            // 
            this.tpHizliIslem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tpHizliIslem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpHizliIslem.Controls.Add(this.btnKapat);
            this.tpHizliIslem.Controls.Add(this.btnCekDefteri);
            this.tpHizliIslem.Controls.Add(this.btnKasaDefteri);
            this.tpHizliIslem.Controls.Add(this.btnTedarikDefter);
            this.tpHizliIslem.Controls.Add(this.btnPesinSatis);
            this.tpHizliIslem.Controls.Add(this.btnVadeliSatis);
            this.tpHizliIslem.Controls.Add(this.btnUrunEkle);
            this.tpHizliIslem.Controls.Add(this.btnMusteriEkle);
            this.tpHizliIslem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tpHizliIslem.Location = new System.Drawing.Point(4, 22);
            this.tpHizliIslem.Name = "tpHizliIslem";
            this.tpHizliIslem.Padding = new System.Windows.Forms.Padding(3);
            this.tpHizliIslem.Size = new System.Drawing.Size(1380, 95);
            this.tpHizliIslem.TabIndex = 0;
            this.tpHizliIslem.Text = "Hızlı İşlemler";
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Image = global::WFBakkal_Defter.Properties.Resources.shut_down_icon;
            this.btnKapat.Location = new System.Drawing.Point(833, 0);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(113, 95);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "\r\nKapat";
            this.btnKapat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnCekDefteri
            // 
            this.btnCekDefteri.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCekDefteri.FlatAppearance.BorderSize = 0;
            this.btnCekDefteri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCekDefteri.Image = global::WFBakkal_Defter.Properties.Resources.checkbook;
            this.btnCekDefteri.Location = new System.Drawing.Point(714, 0);
            this.btnCekDefteri.Name = "btnCekDefteri";
            this.btnCekDefteri.Size = new System.Drawing.Size(113, 95);
            this.btnCekDefteri.TabIndex = 0;
            this.btnCekDefteri.Text = "\r\nÇek Defteri";
            this.btnCekDefteri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCekDefteri.UseVisualStyleBackColor = false;
            // 
            // btnKasaDefteri
            // 
            this.btnKasaDefteri.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKasaDefteri.FlatAppearance.BorderSize = 0;
            this.btnKasaDefteri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKasaDefteri.Image = global::WFBakkal_Defter.Properties.Resources.money_box;
            this.btnKasaDefteri.Location = new System.Drawing.Point(595, 0);
            this.btnKasaDefteri.Name = "btnKasaDefteri";
            this.btnKasaDefteri.Size = new System.Drawing.Size(113, 95);
            this.btnKasaDefteri.TabIndex = 0;
            this.btnKasaDefteri.Text = "\r\nKasa Defteri";
            this.btnKasaDefteri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnKasaDefteri.UseVisualStyleBackColor = false;
            // 
            // btnTedarikDefter
            // 
            this.btnTedarikDefter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTedarikDefter.FlatAppearance.BorderSize = 0;
            this.btnTedarikDefter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTedarikDefter.Image = global::WFBakkal_Defter.Properties.Resources.handshake;
            this.btnTedarikDefter.Location = new System.Drawing.Point(476, 0);
            this.btnTedarikDefter.Name = "btnTedarikDefter";
            this.btnTedarikDefter.Size = new System.Drawing.Size(113, 95);
            this.btnTedarikDefter.TabIndex = 0;
            this.btnTedarikDefter.Text = "\r\nTedarikçi Defteri";
            this.btnTedarikDefter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTedarikDefter.UseVisualStyleBackColor = false;
            // 
            // btnPesinSatis
            // 
            this.btnPesinSatis.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPesinSatis.FlatAppearance.BorderSize = 0;
            this.btnPesinSatis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesinSatis.Image = global::WFBakkal_Defter.Properties.Resources.price_tag;
            this.btnPesinSatis.Location = new System.Drawing.Point(357, 0);
            this.btnPesinSatis.Name = "btnPesinSatis";
            this.btnPesinSatis.Size = new System.Drawing.Size(113, 95);
            this.btnPesinSatis.TabIndex = 0;
            this.btnPesinSatis.Text = "\r\nPeşin Satış";
            this.btnPesinSatis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPesinSatis.UseVisualStyleBackColor = false;
            this.btnPesinSatis.Click += new System.EventHandler(this.btnPesinSatis_Click);
            // 
            // btnVadeliSatis
            // 
            this.btnVadeliSatis.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVadeliSatis.FlatAppearance.BorderSize = 0;
            this.btnVadeliSatis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVadeliSatis.Image = global::WFBakkal_Defter.Properties.Resources.property;
            this.btnVadeliSatis.Location = new System.Drawing.Point(238, 0);
            this.btnVadeliSatis.Name = "btnVadeliSatis";
            this.btnVadeliSatis.Size = new System.Drawing.Size(113, 95);
            this.btnVadeliSatis.TabIndex = 0;
            this.btnVadeliSatis.Text = "\r\nVadeli Satış";
            this.btnVadeliSatis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVadeliSatis.UseVisualStyleBackColor = false;
            this.btnVadeliSatis.Click += new System.EventHandler(this.btnVadeliSatis_Click);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUrunEkle.FlatAppearance.BorderSize = 0;
            this.btnUrunEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrunEkle.Image = global::WFBakkal_Defter.Properties.Resources.product;
            this.btnUrunEkle.Location = new System.Drawing.Point(119, 0);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(113, 95);
            this.btnUrunEkle.TabIndex = 0;
            this.btnUrunEkle.Text = "\r\nÜrün Ekle";
            this.btnUrunEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUrunEkle.UseVisualStyleBackColor = false;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMusteriEkle.FlatAppearance.BorderSize = 0;
            this.btnMusteriEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusteriEkle.Image = global::WFBakkal_Defter.Properties.Resources.add;
            this.btnMusteriEkle.Location = new System.Drawing.Point(0, 0);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(113, 95);
            this.btnMusteriEkle.TabIndex = 0;
            this.btnMusteriEkle.Text = "\r\nMüşteri Ekle";
            this.btnMusteriEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMusteriEkle.UseVisualStyleBackColor = false;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // tpMusteriIslem
            // 
            this.tpMusteriIslem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tpMusteriIslem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpMusteriIslem.Controls.Add(this.btn_MusteriDuzenle);
            this.tpMusteriIslem.Controls.Add(this.btn_MusteriEkle);
            this.tpMusteriIslem.Location = new System.Drawing.Point(4, 22);
            this.tpMusteriIslem.Name = "tpMusteriIslem";
            this.tpMusteriIslem.Padding = new System.Windows.Forms.Padding(3);
            this.tpMusteriIslem.Size = new System.Drawing.Size(1380, 95);
            this.tpMusteriIslem.TabIndex = 1;
            this.tpMusteriIslem.Text = "Müşteri İşlemleri";
            this.tpMusteriIslem.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // btn_MusteriDuzenle
            // 
            this.btn_MusteriDuzenle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_MusteriDuzenle.FlatAppearance.BorderSize = 0;
            this.btn_MusteriDuzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MusteriDuzenle.Image = global::WFBakkal_Defter.Properties.Resources.settings;
            this.btn_MusteriDuzenle.Location = new System.Drawing.Point(118, -1);
            this.btn_MusteriDuzenle.Name = "btn_MusteriDuzenle";
            this.btn_MusteriDuzenle.Size = new System.Drawing.Size(113, 95);
            this.btn_MusteriDuzenle.TabIndex = 1;
            this.btn_MusteriDuzenle.Text = "\r\nMüşteri Düzenle/Sil";
            this.btn_MusteriDuzenle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_MusteriDuzenle.UseVisualStyleBackColor = false;
            this.btn_MusteriDuzenle.Click += new System.EventHandler(this.btn_MusteriDuzenle_Click);
            // 
            // btn_MusteriEkle
            // 
            this.btn_MusteriEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_MusteriEkle.FlatAppearance.BorderSize = 0;
            this.btn_MusteriEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MusteriEkle.Image = global::WFBakkal_Defter.Properties.Resources.add;
            this.btn_MusteriEkle.Location = new System.Drawing.Point(-1, -1);
            this.btn_MusteriEkle.Name = "btn_MusteriEkle";
            this.btn_MusteriEkle.Size = new System.Drawing.Size(113, 95);
            this.btn_MusteriEkle.TabIndex = 1;
            this.btn_MusteriEkle.Text = "\r\nMüşteri Ekle";
            this.btn_MusteriEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_MusteriEkle.UseVisualStyleBackColor = false;
            this.btn_MusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // tpUrunIslem
            // 
            this.tpUrunIslem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tpUrunIslem.Controls.Add(this.btnZamUygula);
            this.tpUrunIslem.Controls.Add(this.btnUrunDuzenleSil);
            this.tpUrunIslem.Controls.Add(this.btn_UrunEkle);
            this.tpUrunIslem.Location = new System.Drawing.Point(4, 22);
            this.tpUrunIslem.Name = "tpUrunIslem";
            this.tpUrunIslem.Padding = new System.Windows.Forms.Padding(3);
            this.tpUrunIslem.Size = new System.Drawing.Size(1380, 95);
            this.tpUrunIslem.TabIndex = 2;
            this.tpUrunIslem.Text = "Ürün İşlemleri";
            // 
            // btnZamUygula
            // 
            this.btnZamUygula.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnZamUygula.FlatAppearance.BorderSize = 0;
            this.btnZamUygula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZamUygula.Image = global::WFBakkal_Defter.Properties.Resources.icons8_withdrawal_32;
            this.btnZamUygula.Location = new System.Drawing.Point(234, 0);
            this.btnZamUygula.Name = "btnZamUygula";
            this.btnZamUygula.Size = new System.Drawing.Size(113, 95);
            this.btnZamUygula.TabIndex = 1;
            this.btnZamUygula.Text = "\r\nZam Uygula";
            this.btnZamUygula.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnZamUygula.UseVisualStyleBackColor = false;
            this.btnZamUygula.Click += new System.EventHandler(this.btnZamUygula_Click);
            // 
            // btnUrunDuzenleSil
            // 
            this.btnUrunDuzenleSil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUrunDuzenleSil.FlatAppearance.BorderSize = 0;
            this.btnUrunDuzenleSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrunDuzenleSil.Image = global::WFBakkal_Defter.Properties.Resources.icons8_data_backup_32;
            this.btnUrunDuzenleSil.Location = new System.Drawing.Point(115, 0);
            this.btnUrunDuzenleSil.Name = "btnUrunDuzenleSil";
            this.btnUrunDuzenleSil.Size = new System.Drawing.Size(113, 95);
            this.btnUrunDuzenleSil.TabIndex = 1;
            this.btnUrunDuzenleSil.Text = "\r\nÜrün Düzenle/Sil";
            this.btnUrunDuzenleSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUrunDuzenleSil.UseVisualStyleBackColor = false;
            this.btnUrunDuzenleSil.Click += new System.EventHandler(this.btnUrunDuzenleSil_Click);
            // 
            // btn_UrunEkle
            // 
            this.btn_UrunEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_UrunEkle.FlatAppearance.BorderSize = 0;
            this.btn_UrunEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UrunEkle.Image = global::WFBakkal_Defter.Properties.Resources.product;
            this.btn_UrunEkle.Location = new System.Drawing.Point(-4, 0);
            this.btn_UrunEkle.Name = "btn_UrunEkle";
            this.btn_UrunEkle.Size = new System.Drawing.Size(113, 95);
            this.btn_UrunEkle.TabIndex = 1;
            this.btn_UrunEkle.Text = "\r\nÜrün Ekle";
            this.btn_UrunEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_UrunEkle.UseVisualStyleBackColor = false;
            this.btn_UrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // tpHesapIslem
            // 
            this.tpHesapIslem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tpHesapIslem.Controls.Add(this.btn_PesinSatis);
            this.tpHesapIslem.Controls.Add(this.btn_VadeliSatis);
            this.tpHesapIslem.Location = new System.Drawing.Point(4, 22);
            this.tpHesapIslem.Name = "tpHesapIslem";
            this.tpHesapIslem.Size = new System.Drawing.Size(1380, 95);
            this.tpHesapIslem.TabIndex = 3;
            this.tpHesapIslem.Text = "Hesap İşlemleri";
            // 
            // btn_PesinSatis
            // 
            this.btn_PesinSatis.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_PesinSatis.FlatAppearance.BorderSize = 0;
            this.btn_PesinSatis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PesinSatis.Image = global::WFBakkal_Defter.Properties.Resources.price_tag;
            this.btn_PesinSatis.Location = new System.Drawing.Point(115, 0);
            this.btn_PesinSatis.Name = "btn_PesinSatis";
            this.btn_PesinSatis.Size = new System.Drawing.Size(113, 95);
            this.btn_PesinSatis.TabIndex = 1;
            this.btn_PesinSatis.Text = "\r\nPeşin Satış";
            this.btn_PesinSatis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_PesinSatis.UseVisualStyleBackColor = false;
            this.btn_PesinSatis.Click += new System.EventHandler(this.btnPesinSatis_Click);
            // 
            // btn_VadeliSatis
            // 
            this.btn_VadeliSatis.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_VadeliSatis.FlatAppearance.BorderSize = 0;
            this.btn_VadeliSatis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VadeliSatis.Image = global::WFBakkal_Defter.Properties.Resources.property;
            this.btn_VadeliSatis.Location = new System.Drawing.Point(-4, 0);
            this.btn_VadeliSatis.Name = "btn_VadeliSatis";
            this.btn_VadeliSatis.Size = new System.Drawing.Size(113, 95);
            this.btn_VadeliSatis.TabIndex = 2;
            this.btn_VadeliSatis.Text = "\r\nVadeli Satış";
            this.btn_VadeliSatis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_VadeliSatis.UseVisualStyleBackColor = false;
            this.btn_VadeliSatis.Click += new System.EventHandler(this.btnVadeliSatis_Click);
            // 
            // tpKasaIslem
            // 
            this.tpKasaIslem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tpKasaIslem.Controls.Add(this.btn_KasaDefteri);
            this.tpKasaIslem.Location = new System.Drawing.Point(4, 22);
            this.tpKasaIslem.Name = "tpKasaIslem";
            this.tpKasaIslem.Size = new System.Drawing.Size(1380, 95);
            this.tpKasaIslem.TabIndex = 4;
            this.tpKasaIslem.Text = "Kasa İşlemleri";
            // 
            // btn_KasaDefteri
            // 
            this.btn_KasaDefteri.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_KasaDefteri.FlatAppearance.BorderSize = 0;
            this.btn_KasaDefteri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_KasaDefteri.Image = global::WFBakkal_Defter.Properties.Resources.money_box;
            this.btn_KasaDefteri.Location = new System.Drawing.Point(-4, 3);
            this.btn_KasaDefteri.Name = "btn_KasaDefteri";
            this.btn_KasaDefteri.Size = new System.Drawing.Size(113, 95);
            this.btn_KasaDefteri.TabIndex = 1;
            this.btn_KasaDefteri.Text = "\r\nKasa Defteri";
            this.btn_KasaDefteri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_KasaDefteri.UseVisualStyleBackColor = false;
            // 
            // tpTedarikIslem
            // 
            this.tpTedarikIslem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tpTedarikIslem.Controls.Add(this.btnTedarikciDuzenle);
            this.tpTedarikIslem.Controls.Add(this.btnTedarikciEkle);
            this.tpTedarikIslem.Controls.Add(this.btn_TedarikciDefteri);
            this.tpTedarikIslem.Location = new System.Drawing.Point(4, 22);
            this.tpTedarikIslem.Name = "tpTedarikIslem";
            this.tpTedarikIslem.Size = new System.Drawing.Size(1380, 95);
            this.tpTedarikIslem.TabIndex = 5;
            this.tpTedarikIslem.Text = "Tedarikçi İşlmeleri";
            // 
            // btnTedarikciDuzenle
            // 
            this.btnTedarikciDuzenle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTedarikciDuzenle.FlatAppearance.BorderSize = 0;
            this.btnTedarikciDuzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTedarikciDuzenle.Image = global::WFBakkal_Defter.Properties.Resources.settings;
            this.btnTedarikciDuzenle.Location = new System.Drawing.Point(119, 0);
            this.btnTedarikciDuzenle.Name = "btnTedarikciDuzenle";
            this.btnTedarikciDuzenle.Size = new System.Drawing.Size(113, 95);
            this.btnTedarikciDuzenle.TabIndex = 2;
            this.btnTedarikciDuzenle.Text = "\r\nTedarikçi Düzenle";
            this.btnTedarikciDuzenle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTedarikciDuzenle.UseVisualStyleBackColor = false;
            this.btnTedarikciDuzenle.Click += new System.EventHandler(this.btnTedarikciDuzenle_Click);
            // 
            // btnTedarikciEkle
            // 
            this.btnTedarikciEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTedarikciEkle.FlatAppearance.BorderSize = 0;
            this.btnTedarikciEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTedarikciEkle.Image = global::WFBakkal_Defter.Properties.Resources.add;
            this.btnTedarikciEkle.Location = new System.Drawing.Point(0, 0);
            this.btnTedarikciEkle.Name = "btnTedarikciEkle";
            this.btnTedarikciEkle.Size = new System.Drawing.Size(113, 95);
            this.btnTedarikciEkle.TabIndex = 2;
            this.btnTedarikciEkle.Text = "\r\nTedarikçi Ekle";
            this.btnTedarikciEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTedarikciEkle.UseVisualStyleBackColor = false;
            this.btnTedarikciEkle.Click += new System.EventHandler(this.btnTedarikciEkle_Click);
            // 
            // btn_TedarikciDefteri
            // 
            this.btn_TedarikciDefteri.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_TedarikciDefteri.FlatAppearance.BorderSize = 0;
            this.btn_TedarikciDefteri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TedarikciDefteri.Image = global::WFBakkal_Defter.Properties.Resources.handshake;
            this.btn_TedarikciDefteri.Location = new System.Drawing.Point(238, 0);
            this.btn_TedarikciDefteri.Name = "btn_TedarikciDefteri";
            this.btn_TedarikciDefteri.Size = new System.Drawing.Size(113, 95);
            this.btn_TedarikciDefteri.TabIndex = 2;
            this.btn_TedarikciDefteri.Text = "\r\nTedarikçi Defteri";
            this.btn_TedarikciDefteri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_TedarikciDefteri.UseVisualStyleBackColor = false;
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::WFBakkal_Defter.Properties.Resources.wallpaper;
            this.ClientSize = new System.Drawing.Size(1112, 507);
            this.Controls.Add(this.tabControl1);
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bakkal Defteri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.tpHizliIslem.ResumeLayout(false);
            this.tpMusteriIslem.ResumeLayout(false);
            this.tpUrunIslem.ResumeLayout(false);
            this.tpHesapIslem.ResumeLayout(false);
            this.tpKasaIslem.ResumeLayout(false);
            this.tpTedarikIslem.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpHizliIslem;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.TabPage tpMusteriIslem;
        private System.Windows.Forms.TabPage tpUrunIslem;
        private System.Windows.Forms.TabPage tpHesapIslem;
        private System.Windows.Forms.TabPage tpKasaIslem;
        private System.Windows.Forms.TabPage tpTedarikIslem;
        private System.Windows.Forms.Button btnPesinSatis;
        private System.Windows.Forms.Button btnVadeliSatis;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnCekDefteri;
        private System.Windows.Forms.Button btnKasaDefteri;
        private System.Windows.Forms.Button btnTedarikDefter;
        private System.Windows.Forms.Button btn_MusteriEkle;
        private System.Windows.Forms.Button btn_MusteriDuzenle;
        private System.Windows.Forms.Button btnZamUygula;
        private System.Windows.Forms.Button btnUrunDuzenleSil;
        private System.Windows.Forms.Button btn_UrunEkle;
        private System.Windows.Forms.Button btn_PesinSatis;
        private System.Windows.Forms.Button btn_VadeliSatis;
        private System.Windows.Forms.Button btn_KasaDefteri;
        private System.Windows.Forms.Button btnTedarikciDuzenle;
        private System.Windows.Forms.Button btnTedarikciEkle;
        private System.Windows.Forms.Button btn_TedarikciDefteri;
    }
}

