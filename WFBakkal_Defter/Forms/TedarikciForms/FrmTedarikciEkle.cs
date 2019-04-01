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
    public partial class FrmTedarikciEkle : Form
    {
        public FrmTedarikciEkle()
        {
            InitializeComponent();
            Araclar.frmTedarikciEkle = this;
        }

        SqlRepository<Tedarikci> repoTedarikci = new SqlRepository<Tedarikci>();

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                repoTedarikci.Insert(new Tedarikci {
                    Aciklama = txtAciklama.Text,
                    Ad = txtTedarikciAd.Text,
                    Adres = txtAdres.Text,
                    CepTelefon = msktxtCep.Text,
                    Email = txtEmail.Text,
                    EvTelefon = msktxtTelefon.Text,
                    Fax = msktxtFax.Text,
                    Sektor = txtTSektor.Text,
                    VergiDairesi = txtVergiDairesi.Text,
                    VergiNo = txtVergiNo.Text,
                    YetkiliAd = txtYetkiliAd.Text,
                    YetkiliSoyad = txtYetkiliSoyad.Text
                });
                Temizle();
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
