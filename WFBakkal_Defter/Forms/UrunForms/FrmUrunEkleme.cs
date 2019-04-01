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
    public partial class FrmUrunEkleme : Form
    {
        public FrmUrunEkleme()
        {
            InitializeComponent();
        }

        SqlRepository<Urun> repoUrun = new SqlRepository<Urun>();

        private void FrmUrunEkleme_Load(object sender, EventArgs e)
        {
            Yukle();
        }

        void Yukle()
        {
            dataGridView1.DataSource = repoUrun.Listele().ToList();
            dataGridView1.Columns[0].Visible = false;
            cmbBirim.DataSource = Enum.GetValues((typeof(EBirim)));
        }

        private void btnKayıt_Click(object sender, EventArgs e)
        {
            try
            {
                repoUrun.Insert(new Urun
                {
                    Ad = txtAd.Text,
                    Barkod = txtBarkod.Text,
                    Miktar = Convert.ToInt32(numMiktar.Value),
                    Birim = (EBirim)Enum.Parse(typeof(EBirim), cmbBirim.Text),
                    AFiyat = Convert.ToDecimal(txtAlisFiyat.Text),
                    SFiyat = Convert.ToDecimal(txtSatisFiyat.Text),
                    ATarih = Convert.ToDateTime(dateAlisTarih.Text),
                    SKTarih = Convert.ToDateTime(dateSonKullanma.Text),
                    Sinirsiz = chSinirsiz.Checked
                });
                Temizle();
                Yukle();
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
    }
}
