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
    public partial class FrmMTahsilatEkle : Form
    {
        public FrmMTahsilatEkle()
        {
            InitializeComponent();
        }

        SqlRepository<MBorc> repoMTahsilat = new SqlRepository<MBorc>();
        SqlRepository<Musteri> repoMusteri = new SqlRepository<Musteri>();
        public int musteriID;

        private void FrmMTahsilatEkle_Load(object sender, EventArgs e)
        {
            cmbOdemeTur.DataSource = Enum.GetValues(typeof(EOdemeTur));
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                repoMTahsilat.Insert(new MBorc {
                    Aciklama = txtAciklama.Text,
                    IslemTarih = Convert.ToDateTime(dtIslemTarihi.Text),
                    MusteriID = musteriID,
                    Tahsilat = Convert.ToDecimal(txtTutar.Text),
                    eOdemeTur = (EOdemeTur)Enum.Parse(typeof(EOdemeTur),cmbOdemeTur.Text)
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
