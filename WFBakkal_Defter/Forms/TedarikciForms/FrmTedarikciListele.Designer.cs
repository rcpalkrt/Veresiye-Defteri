namespace WFBakkal_Defter.Forms.TedarikciForms
{
    partial class FrmTedarikciListele
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtTedarikciAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSektor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYetkiliAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtYetkiliSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(837, 314);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // txtTedarikciAd
            // 
            this.txtTedarikciAd.Location = new System.Drawing.Point(12, 38);
            this.txtTedarikciAd.Name = "txtTedarikciAd";
            this.txtTedarikciAd.Size = new System.Drawing.Size(188, 22);
            this.txtTedarikciAd.TabIndex = 0;
            this.txtTedarikciAd.TextChanged += new System.EventHandler(this.txtTedarikciAd_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Firma Adına Göre Ara";
            // 
            // txtSektor
            // 
            this.txtSektor.Location = new System.Drawing.Point(206, 38);
            this.txtSektor.Name = "txtSektor";
            this.txtSektor.Size = new System.Drawing.Size(187, 22);
            this.txtSektor.TabIndex = 1;
            this.txtSektor.TextChanged += new System.EventHandler(this.txtTedarikciAd_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sektörüne Göre Ara";
            // 
            // txtYetkiliAd
            // 
            this.txtYetkiliAd.Location = new System.Drawing.Point(399, 38);
            this.txtYetkiliAd.Name = "txtYetkiliAd";
            this.txtYetkiliAd.Size = new System.Drawing.Size(187, 22);
            this.txtYetkiliAd.TabIndex = 2;
            this.txtYetkiliAd.TextChanged += new System.EventHandler(this.txtTedarikciAd_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(399, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yetkili Adına Göre Ara";
            // 
            // txtYetkiliSoyad
            // 
            this.txtYetkiliSoyad.Location = new System.Drawing.Point(592, 38);
            this.txtYetkiliSoyad.Name = "txtYetkiliSoyad";
            this.txtYetkiliSoyad.Size = new System.Drawing.Size(187, 22);
            this.txtYetkiliSoyad.TabIndex = 3;
            this.txtYetkiliSoyad.TextChanged += new System.EventHandler(this.txtTedarikciAd_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(592, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Yetkili Soyadına Göre Ara";
            // 
            // btnSec
            // 
            this.btnSec.Location = new System.Drawing.Point(785, 37);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(64, 23);
            this.btnSec.TabIndex = 4;
            this.btnSec.Text = "Seç";
            this.btnSec.UseVisualStyleBackColor = true;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // FrmTedarikciListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(861, 392);
            this.Controls.Add(this.btnSec);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtYetkiliSoyad);
            this.Controls.Add(this.txtYetkiliAd);
            this.Controls.Add(this.txtSektor);
            this.Controls.Add(this.txtTedarikciAd);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmTedarikciListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tedarikçi Bul";
            this.Load += new System.EventHandler(this.FrmTedarikciListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtTedarikciAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSektor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYetkiliAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtYetkiliSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSec;
    }
}