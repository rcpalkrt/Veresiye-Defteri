using BAKKAL_BLL.SqlRepostories;
using BAKKAL_BOL.Entities;
using BAKKAL_DAL.Contexts;
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
    public partial class FrmPesinSatis : Form
    {
        public FrmPesinSatis()
        {
            InitializeComponent();
            Araclar.frmPesinSatis = this;
        }

        SqlRepository<Urun> repoUrunler = new SqlRepository<Urun>();
        SqlRepository<Sepet> repoSepet = new SqlRepository<Sepet>();
        SqlRepository<SepetMusteri> repoSMusteri = new SqlRepository<SepetMusteri>();
        SQLDbContext db = new SQLDbContext();
        public Musteri mstri;

        public void FrmPesinSatis_Load(object sender, EventArgs e)
        {
            dataGridUrunler.DataSource = db.uruns.AsEnumerable().Select(s => new {
                Barkodu = s.Barkod,
                UrunAdi = s.Ad,
                Birim = Enum.GetName(typeof(EBirim), s.Birim),
                s.Miktar,
                Fiyat = s.SFiyat
            }).ToList();
            Yukle();
        }
        void Yukle()
        {
            dataGridMusteriler.DataSource = repoSMusteri.Listele().ToList();
            if(mstri != null)
            {
                int m_id = mstri.ID;
                dataGridSatilanUrunler.DataSource = db.sepets.AsEnumerable().Where(w=>w.MusteriID==m_id).Select(s => new {
                    s.Urun.Barkod,
                    UrunAdi = s.Urun.Ad,
                    Birim = Enum.GetName(typeof(EBirim),s.Urun.Birim),
                    Fiyat = s.Urun.SFiyat,
                    Tutar = s.Urun.SFiyat
                }).ToList();
            }
        }

        private void rdbKayitliMusteri_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbKayitliMusteri.Checked)
            {
                FrmPesinMusteriListele frmPesinMusteriListele = new FrmPesinMusteriListele();
                Araclar.frmPesinMusteriListele = frmPesinMusteriListele;
                frmPesinMusteriListele.ShowDialog();
            }
        }

        private void dataGridMusteriler_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void dataGridUrunler_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void btnSepetEkle_Click(object sender, EventArgs e)
        {

        }

        private void btnSeciliSil_Click(object sender, EventArgs e)
        {

        }

        private void btnSatisOnay_Click(object sender, EventArgs e)
        {

        }
    }
}
