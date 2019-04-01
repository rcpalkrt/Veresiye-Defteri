using BAKKAL_BLL.SqlRepostories;
using BAKKAL_BOL.Entities;
using BAKKAL_DAL.Contexts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFBakkal_Defter.Forms.HesapForms
{
    public partial class FrmVadeliSatis : Form
    {
        public FrmVadeliSatis()
        {
            InitializeComponent();
            Araclar.frmVadeliSatis = this;
        }

        SqlRepository<MBorc> repoMBorc = new SqlRepository<MBorc>();
        SQLDbContext db = new SQLDbContext();

        public Musteri mstri;
        public MBorc borc;
        int secilenMusteriID;

        public void FrmVadeliSatis_Load(object sender, EventArgs e)
        {
            if (mstri != null)
            {
                secilenMusteriID = mstri.ID;
                txtAd.Text = mstri.Ad;
                txtSoyad.Text = mstri.Soyad;
                msktxtTelefon.Text = mstri.EvTelefon;
                msktxtCep.Text = mstri.CepTelefon;
                msktxtFax.Text = mstri.Fax;
                txtEmail.Text = mstri.Email;
                txtTC.Text = mstri.TC;
                txtAdres.Text = mstri.Adres;
                txtAciklama.Text = mstri.Aciklama;
                Yukle();
            }
        }

        void Yukle()
        {
            dataGridView1.DataSource = db.mBorcs.Include("Urun").AsEnumerable().Where(w => w.MusteriID == secilenMusteriID).Select(s => new
            {
                s.Urun.Ad,
                s.Urun.SFiyat,
                s.UrunMiktar,
                Birim = Enum.GetName(typeof(EBirim), s.Urun.Birim),
                s.VadeTarih,
                s.BorcMiktar,
                s.Tahsilat,
                s.Aciklama,
                s.IslemTarih
            }).ToList();
            

            decimal toplamTutar = 0;
            decimal toplamTahsilEdilen = 0;
            int toplamBorcMiktar = 0;

            foreach (MBorc herbirMBorc in repoMBorc.Listele().Include("Urun").Where(w => w.MusteriID == secilenMusteriID).ToList())
            {
                toplamTutar += herbirMBorc.Urun.SFiyat * herbirMBorc.UrunMiktar;
                toplamBorcMiktar += herbirMBorc.UrunMiktar;
                if (herbirMBorc.Tahsilat != null)
                    toplamTahsilEdilen += herbirMBorc.Tahsilat;
            }

            txtTBorcMiktar.Text = toplamBorcMiktar.ToString();
            txtTBorcTutar.Text = toplamTutar.ToString();
            txtTahsilEdilen.Text = toplamTahsilEdilen.ToString();
            txtKalanBorc.Text = (toplamTutar - toplamTahsilEdilen).ToString();

        }

        private void btnMusteriBul_Click(object sender, EventArgs e)
        {
            FrmMusteriBul musteriBul = new FrmMusteriBul();
            Araclar.frmMusteriBul = musteriBul;
            musteriBul.ShowDialog();
        }

        private void btnBorcEkle_Click(object sender, EventArgs e)
        {
            FrmMBorcEkle frmMBorcEkle = new FrmMBorcEkle();
            Araclar.frmMBorcEkle = frmMBorcEkle;
            Araclar.frmMBorcEkle.musteriID = secilenMusteriID;
            frmMBorcEkle.ShowDialog();
        }

        private void btnTahsilat_Click(object sender, EventArgs e)
        {
            FrmMTahsilatEkle frmMTahsilatEkle = new FrmMTahsilatEkle();
            Araclar.FrmMTahsilatEkle = frmMTahsilatEkle;
            Araclar.FrmMTahsilatEkle.musteriID = secilenMusteriID;
            frmMTahsilatEkle.ShowDialog();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
