namespace WFBakkal_Defter.Forms.HesapForms
{
    partial class FrmPesinSatis
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbPesinMusteri = new System.Windows.Forms.RadioButton();
            this.rdbKayitliMusteri = new System.Windows.Forms.RadioButton();
            this.txtMusteri = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBarkodAra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUrunAdAra = new System.Windows.Forms.TextBox();
            this.btnSepetEkle = new System.Windows.Forms.Button();
            this.dataGridUrunler = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridSepet = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnToplamTutar = new System.Windows.Forms.Button();
            this.dataGridMusteriler = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMusteriAra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtToplamTutar = new System.Windows.Forms.TextBox();
            this.dataGridSatilanUrunler = new System.Windows.Forms.DataGridView();
            this.btnSatisOnay = new System.Windows.Forms.Button();
            this.btnSeciliSil = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUrunler)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSepet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMusteriler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSatilanUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(890, 544);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(882, 515);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Peşin Satış Ekranı";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Controls.Add(this.dataGridSatilanUrunler);
            this.tabPage2.Controls.Add(this.txtToplamTutar);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtMusteriAra);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.dataGridMusteriler);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(882, 515);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Peşin Yapılan Satışlar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.txtMusteri);
            this.groupBox1.Controls.Add(this.rdbKayitliMusteri);
            this.groupBox1.Controls.Add(this.rdbPesinMusteri);
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(876, 72);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            // 
            // rdbPesinMusteri
            // 
            this.rdbPesinMusteri.AutoSize = true;
            this.rdbPesinMusteri.Checked = true;
            this.rdbPesinMusteri.Location = new System.Drawing.Point(18, 31);
            this.rdbPesinMusteri.Name = "rdbPesinMusteri";
            this.rdbPesinMusteri.Size = new System.Drawing.Size(119, 20);
            this.rdbPesinMusteri.TabIndex = 0;
            this.rdbPesinMusteri.TabStop = true;
            this.rdbPesinMusteri.Text = "Peşin Müşteri";
            this.rdbPesinMusteri.UseVisualStyleBackColor = true;
            // 
            // rdbKayitliMusteri
            // 
            this.rdbKayitliMusteri.AutoSize = true;
            this.rdbKayitliMusteri.Location = new System.Drawing.Point(153, 31);
            this.rdbKayitliMusteri.Name = "rdbKayitliMusteri";
            this.rdbKayitliMusteri.Size = new System.Drawing.Size(122, 20);
            this.rdbKayitliMusteri.TabIndex = 1;
            this.rdbKayitliMusteri.Text = "Kayıtlı Müşteri";
            this.rdbKayitliMusteri.UseVisualStyleBackColor = true;
            this.rdbKayitliMusteri.CheckedChanged += new System.EventHandler(this.rdbKayitliMusteri_CheckedChanged);
            // 
            // txtMusteri
            // 
            this.txtMusteri.Location = new System.Drawing.Point(313, 30);
            this.txtMusteri.Name = "txtMusteri";
            this.txtMusteri.Size = new System.Drawing.Size(221, 22);
            this.txtMusteri.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(595, 28);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(258, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridUrunler);
            this.groupBox2.Controls.Add(this.btnSepetEkle);
            this.groupBox2.Controls.Add(this.txtUrunAdAra);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtBarkodAra);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(3, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(876, 191);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün Bilgileri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Barkoduna Göre Ara";
            // 
            // txtBarkodAra
            // 
            this.txtBarkodAra.Location = new System.Drawing.Point(170, 24);
            this.txtBarkodAra.Name = "txtBarkodAra";
            this.txtBarkodAra.Size = new System.Drawing.Size(170, 22);
            this.txtBarkodAra.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Adına Göre Ara";
            // 
            // txtUrunAdAra
            // 
            this.txtUrunAdAra.Location = new System.Drawing.Point(466, 24);
            this.txtUrunAdAra.Name = "txtUrunAdAra";
            this.txtUrunAdAra.Size = new System.Drawing.Size(144, 22);
            this.txtUrunAdAra.TabIndex = 1;
            // 
            // btnSepetEkle
            // 
            this.btnSepetEkle.Location = new System.Drawing.Point(641, 22);
            this.btnSepetEkle.Name = "btnSepetEkle";
            this.btnSepetEkle.Size = new System.Drawing.Size(139, 27);
            this.btnSepetEkle.TabIndex = 2;
            this.btnSepetEkle.Text = "Sepete Ekle";
            this.btnSepetEkle.UseVisualStyleBackColor = true;
            this.btnSepetEkle.Click += new System.EventHandler(this.btnSepetEkle_Click);
            // 
            // dataGridUrunler
            // 
            this.dataGridUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridUrunler.BackgroundColor = System.Drawing.Color.White;
            this.dataGridUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUrunler.Location = new System.Drawing.Point(6, 52);
            this.dataGridUrunler.Name = "dataGridUrunler";
            this.dataGridUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridUrunler.Size = new System.Drawing.Size(864, 133);
            this.dataGridUrunler.TabIndex = 3;
            this.dataGridUrunler.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridUrunler_MouseDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSatisOnay);
            this.groupBox3.Controls.Add(this.btnSeciliSil);
            this.groupBox3.Controls.Add(this.btnToplamTutar);
            this.groupBox3.Controls.Add(this.dataGridSepet);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(3, 281);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(876, 228);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sepet";
            // 
            // dataGridSepet
            // 
            this.dataGridSepet.BackgroundColor = System.Drawing.Color.White;
            this.dataGridSepet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSepet.Location = new System.Drawing.Point(6, 21);
            this.dataGridSepet.Name = "dataGridSepet";
            this.dataGridSepet.Size = new System.Drawing.Size(604, 201);
            this.dataGridSepet.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(696, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "TOPLAM";
            // 
            // btnToplamTutar
            // 
            this.btnToplamTutar.Enabled = false;
            this.btnToplamTutar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnToplamTutar.FlatAppearance.BorderSize = 2;
            this.btnToplamTutar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnToplamTutar.Location = new System.Drawing.Point(616, 41);
            this.btnToplamTutar.Name = "btnToplamTutar";
            this.btnToplamTutar.Size = new System.Drawing.Size(254, 73);
            this.btnToplamTutar.TabIndex = 1;
            this.btnToplamTutar.Text = "0,00";
            this.btnToplamTutar.UseVisualStyleBackColor = true;
            // 
            // dataGridMusteriler
            // 
            this.dataGridMusteriler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridMusteriler.BackgroundColor = System.Drawing.Color.White;
            this.dataGridMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMusteriler.Location = new System.Drawing.Point(7, 47);
            this.dataGridMusteriler.Name = "dataGridMusteriler";
            this.dataGridMusteriler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridMusteriler.Size = new System.Drawing.Size(868, 224);
            this.dataGridMusteriler.TabIndex = 0;
            this.dataGridMusteriler.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridMusteriler_MouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Müşteri Adına Göre Ara";
            // 
            // txtMusteriAra
            // 
            this.txtMusteriAra.Location = new System.Drawing.Point(182, 19);
            this.txtMusteriAra.Name = "txtMusteriAra";
            this.txtMusteriAra.Size = new System.Drawing.Size(199, 22);
            this.txtMusteriAra.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(532, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Liste Toplam Tutar";
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Location = new System.Drawing.Point(676, 277);
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.Size = new System.Drawing.Size(199, 22);
            this.txtToplamTutar.TabIndex = 2;
            // 
            // dataGridSatilanUrunler
            // 
            this.dataGridSatilanUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridSatilanUrunler.BackgroundColor = System.Drawing.Color.White;
            this.dataGridSatilanUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSatilanUrunler.Location = new System.Drawing.Point(6, 305);
            this.dataGridSatilanUrunler.Name = "dataGridSatilanUrunler";
            this.dataGridSatilanUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSatilanUrunler.Size = new System.Drawing.Size(868, 204);
            this.dataGridSatilanUrunler.TabIndex = 3;
            // 
            // btnSatisOnay
            // 
            this.btnSatisOnay.FlatAppearance.BorderSize = 0;
            this.btnSatisOnay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSatisOnay.Image = global::WFBakkal_Defter.Properties.Resources.ok_appproval_acceptance;
            this.btnSatisOnay.Location = new System.Drawing.Point(750, 131);
            this.btnSatisOnay.Name = "btnSatisOnay";
            this.btnSatisOnay.Size = new System.Drawing.Size(120, 63);
            this.btnSatisOnay.TabIndex = 2;
            this.btnSatisOnay.Text = "\r\nSatışı Onayla";
            this.btnSatisOnay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSatisOnay.UseVisualStyleBackColor = true;
            this.btnSatisOnay.Click += new System.EventHandler(this.btnSatisOnay_Click);
            // 
            // btnSeciliSil
            // 
            this.btnSeciliSil.FlatAppearance.BorderSize = 0;
            this.btnSeciliSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeciliSil.Image = global::WFBakkal_Defter.Properties.Resources.recycle_bin;
            this.btnSeciliSil.Location = new System.Drawing.Point(616, 131);
            this.btnSeciliSil.Name = "btnSeciliSil";
            this.btnSeciliSil.Size = new System.Drawing.Size(128, 63);
            this.btnSeciliSil.TabIndex = 2;
            this.btnSeciliSil.Text = "\r\nSeçili Ürünü Sil";
            this.btnSeciliSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSeciliSil.UseVisualStyleBackColor = true;
            this.btnSeciliSil.Click += new System.EventHandler(this.btnSeciliSil_Click);
            // 
            // FrmPesinSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(891, 548);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmPesinSatis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Peşin Satış";
            this.Load += new System.EventHandler(this.FrmPesinSatis_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUrunler)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSepet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMusteriler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSatilanUrunler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridUrunler;
        private System.Windows.Forms.Button btnSepetEkle;
        private System.Windows.Forms.TextBox txtUrunAdAra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBarkodAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtMusteri;
        private System.Windows.Forms.RadioButton rdbKayitliMusteri;
        private System.Windows.Forms.RadioButton rdbPesinMusteri;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSatisOnay;
        private System.Windows.Forms.Button btnSeciliSil;
        private System.Windows.Forms.Button btnToplamTutar;
        private System.Windows.Forms.DataGridView dataGridSepet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridSatilanUrunler;
        private System.Windows.Forms.TextBox txtToplamTutar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMusteriAra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridMusteriler;
    }
}