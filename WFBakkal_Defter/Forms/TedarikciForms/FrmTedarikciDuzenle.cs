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

namespace WFBakkal_Defter.Forms.TedarikciForms
{
    public partial class FrmTedarikciDuzenle : Form
    {
        public FrmTedarikciDuzenle()
        {
            InitializeComponent();
            Araclar.frmTedarikciDuzenle = this;
        }

        SqlRepository<Tedarikci> repoTedarikci = new SqlRepository<Tedarikci>();
        public Tedarikci tedarikci;
        int secilenTedarikciID = 0;

        public void FrmTedarikciDuzenle_Load(object sender, EventArgs e)
        {
            if (tedarikci != null)
            {
                secilenTedarikciID = tedarikci.ID;
                txtAciklama.Text = tedarikci.Aciklama;
                txtAdres.Text = tedarikci.Adres;
                txtEmail.Text = tedarikci.Email;
                txtTedarikciAd.Text = tedarikci.Ad;
                txtTSektor.Text = tedarikci.Sektor;
                txtVergiDairesi.Text = tedarikci.VergiDairesi;
                txtVergiNo.Text = tedarikci.VergiNo;
                txtYetkiliAd.Text = tedarikci.YetkiliAd;
                txtYetkiliSoyad.Text = tedarikci.YetkiliSoyad;
                msktxtCep.Text = tedarikci.CepTelefon;
                msktxtFax.Text = tedarikci.Fax;
                msktxtTelefon.Text = tedarikci.EvTelefon;
            }
        }

        private void btnTedarikciBul_Click(object sender, EventArgs e)
        {
            FrmTedarikciListele frmTedarikciListele = new FrmTedarikciListele();
            Araclar.frmTedarikciListele = frmTedarikciListele;
            frmTedarikciListele.ShowDialog();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                Tedarikci tedarikci = repoTedarikci.Listele(w => w.ID == secilenTedarikciID).First();
                if (tedarikci != null)
                {
                    repoTedarikci.Delete(tedarikci);
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Boyle Bir Tedarikci Yok", "UYARI!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Tedarikci tedarikci = repoTedarikci.Listele(w => w.ID == secilenTedarikciID).First();
                if (tedarikci != null)
                {
                    tedarikci.Aciklama = txtAciklama.Text;
                    tedarikci.Adres = txtAdres.Text;
                    tedarikci.Email = txtEmail.Text;
                    tedarikci.Ad = txtTedarikciAd.Text;
                    tedarikci.Sektor = txtTSektor.Text;
                    tedarikci.VergiDairesi = txtVergiDairesi.Text;
                    tedarikci.VergiNo = txtVergiNo.Text;
                    tedarikci.YetkiliAd = txtYetkiliAd.Text;
                    tedarikci.YetkiliSoyad = txtYetkiliSoyad.Text;
                    tedarikci.CepTelefon = msktxtCep.Text;
                    tedarikci.Fax = msktxtFax.Text;
                    tedarikci.EvTelefon = msktxtTelefon.Text;

                    repoTedarikci.Update(tedarikci);
                    Temizle();
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

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void Temizle()
        {
            txtAciklama.Clear();
            txtAdres.Clear();
            txtEmail.Clear();
            txtTedarikciAd.Clear();
            txtTSektor.Clear();
            txtVergiDairesi.Clear();
            txtVergiNo.Clear();
            txtYetkiliAd.Clear();
            txtYetkiliSoyad.Clear();
            msktxtCep.Clear();
            msktxtFax.Clear();
            msktxtTelefon.Clear();
        }
    }
}
