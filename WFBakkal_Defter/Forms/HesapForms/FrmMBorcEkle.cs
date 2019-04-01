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

namespace WFBakkal_Defter.Forms.HesapForms
{
    public partial class FrmMBorcEkle : Form
    {
        public FrmMBorcEkle()
        {
            InitializeComponent();
            Araclar.frmMBorcEkle = this;
        }

        SqlRepository<MBorc> repoMBorc = new SqlRepository<MBorc>();
        SqlRepository<Urun> repoUrun = new SqlRepository<Urun>();
        SqlRepository<Musteri> repoMusteri = new SqlRepository<Musteri>();
        public int musteriID;

        private void FrmMBorcEkle_Load(object sender, EventArgs e)
        {
            cmbUrunler.DataSource = repoUrun.Listele().Select(s => new { s.ID, s.Ad }).ToList();
            cmbBirim.DataSource = Enum.GetValues(typeof(EBirim));
        }

        private void numUrunMiktar_ValueChanged(object sender, EventArgs e)
        {
            int u_id = Convert.ToInt16(cmbUrunler.SelectedValue);
            int miktar = Convert.ToInt16(numUrunMiktar.Value);
            Urun urun = repoUrun.Listele(w => w.ID == u_id).FirstOrDefault();
            decimal fiyat = urun.SFiyat;
            txtBorcMiktar.Text = (fiyat * miktar).ToString();
        }

        private void cmbUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            int u_id = Convert.ToInt16(cmbUrunler.SelectedValue);
            Urun urun = repoUrun.Listele(w => w.ID == u_id).FirstOrDefault();
            txtUrunFiyat.Text = urun.SFiyat.ToString();
        }

        private void chOdemeVadeT_CheckedChanged(object sender, EventArgs e)
        {
            if (chOdemeVadeT.Checked)
                dtVadeTarihi.Enabled = true;
            else
                dtVadeTarihi.Enabled = false;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                repoMBorc.Insert(new MBorc {
                    Aciklama = txtAciklama.Text,
                    BorcMiktar = Convert.ToDecimal(txtBorcMiktar.Text),
                    eBirim = (EBirim)Enum.Parse(typeof(EBirim), cmbBirim.Text),
                    UrunMiktar = Convert.ToInt32(numUrunMiktar.Value),
                    IslemTarih = Convert.ToDateTime(dtIslemTarihi.Text),
                   // VadeTarih = chOdemeVadeT.Checked ? Convert.ToDateTime(dtVadeTarihi.Text): Convert.ToDateTime("01-01-2000"),
                    VadeTarih = Convert.ToDateTime(dtVadeTarihi.Text),
                    UrunID = Convert.ToInt16(cmbUrunler.SelectedValue),
                    MusteriID = musteriID
                    });
                Musteri musteri = repoMusteri.Listele(w => w.ID == musteriID).FirstOrDefault();
                Araclar.frmVadeliSatis.mstri = musteri;
                Araclar.frmVadeliSatis.FrmVadeliSatis_Load(null, null);
                Araclar.frmVadeliSatis.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
