using BAKKAL_BLL.SqlRepostories;
using BAKKAL_BOL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFBakkal_Defter.Forms.UrunForms
{
    public partial class FrmUrunDuzenle : Form
    {
        public FrmUrunDuzenle()
        {
            InitializeComponent();
        }

        SqlRepository<Urun> repoUrun = new SqlRepository<Urun>();
        int urunID = 0;

        private void FrmUrunDuzenle_Load(object sender, EventArgs e)
        {
            Yukle();
        }
        void Yukle()
        {
            dataGridView1.DataSource = repoUrun.Listele().ToList();
            dataGridView1.Columns[0].Visible = false;
            cmbBirim.DataSource = Enum.GetValues((typeof(EBirim)));
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            urunID = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            Urun urun = repoUrun.Listele(w => w.ID == urunID).FirstOrDefault();
            if (urun != null)
            {
                panel1.Enabled = true;
                txtAd.Text = urun.Ad;
                txtBarkod.Text = urun.Barkod;
                txtAlisFiyat.Text = urun.AFiyat.ToString();
                txtSatisFiyat.Text = urun.SFiyat.ToString();
                numMiktar.Value = urun.Miktar;
                chSinirsiz.Checked = urun.Sinirsiz;
                cmbBirim.Text = Enum.GetName(typeof(EBirim), urun.Birim);
                dateAlisTarih.Text = urun.ATarih.ToString();
                dateSonKullanma.Text = urun.SKTarih.ToString();
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                Urun urun = repoUrun.Listele(w => w.ID == urunID).FirstOrDefault();

                urun.Ad = txtAd.Text;
                urun.Barkod = txtBarkod.Text;
                urun.AFiyat = Convert.ToDecimal(txtAlisFiyat.Text);
                urun.SFiyat = Convert.ToDecimal(txtSatisFiyat.Text);
                urun.Miktar = Convert.ToInt32(numMiktar.Value);
                urun.Sinirsiz = chSinirsiz.Checked;
                urun.Birim = (EBirim)Enum.Parse(typeof(EBirim), cmbBirim.Text);
                urun.ATarih = Convert.ToDateTime(dateAlisTarih.Text);
                urun.SKTarih = Convert.ToDateTime(dateSonKullanma.Text);

                panel1.Enabled = false;
                repoUrun.Update(urun);

                Temizle();
                Yukle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void Temizle()
        {
            txtAd.Clear();
            txtBarkod.Clear();
            txtAlisFiyat.Clear();
            txtSatisFiyat.Clear();
            numMiktar.Value = 1;
            chSinirsiz.Checked = false;
            cmbBirim.Text = "";
            dateAlisTarih.Text = DateTime.Now.ToString();
            dateSonKullanma.Text = DateTime.Now.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                Urun urun = repoUrun.Listele(w => w.ID == urunID).FirstOrDefault();
                if (urun != null)
                {
                    panel1.Enabled = false;
                    repoUrun.Delete(urun);
                    Temizle();
                    Yukle();
                }
                else
                {
                    MessageBox.Show("Boyle Bir Ürün Yok", "UYARI!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAdAra_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = repoUrun.Listele(w => w.Ad.Contains(txtAdAra.Text) && w.Barkod.Contains(txtBarkodAra.Text)).ToList();
        }
    }
}
