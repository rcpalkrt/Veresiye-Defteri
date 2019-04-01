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

namespace WFBakkal_Defter.Forms
{
    public partial class MusteriDuzenle : Form
    {
        public MusteriDuzenle()
        {
            InitializeComponent();
            Araclar.frmMusteriDuzenle = this;
        }

        SqlRepository<Musteri> repoMusteri = new SqlRepository<Musteri>();
        public Musteri mstri;
        int secilenMusteriID = 0;

        private void MusteriDuzenle_Load(object sender, EventArgs e)
        {
            if(mstri != null)
            {
                secilenMusteriID = mstri.ID;
                txtAd.Text = mstri.Ad;
                txtSoyad.Text = mstri.Soyad;
                txtLakap.Text = mstri.Lakap;
                msktxtTelefon.Text = mstri.EvTelefon;
                msktxtCep.Text = mstri.CepTelefon;
                msktxtFax.Text = mstri.Fax;
                txtEmail.Text = mstri.Email;
                txtTC.Text = mstri.TC;
                txtAdres.Text = mstri.Adres;
                txtAciklama.Text = mstri.Aciklama;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Musteri musteri = repoMusteri.Listele(w => w.ID == secilenMusteriID).First();
                if(musteri != null)
                {
                    musteri.Ad = txtAd.Text;
                    musteri.Soyad = txtSoyad.Text;
                    musteri.Lakap = txtLakap.Text;
                    musteri.EvTelefon = msktxtTelefon.Text;
                    musteri.CepTelefon = msktxtCep.Text;
                    musteri.Fax = msktxtFax.Text;
                    musteri.Email = txtEmail.Text;
                    musteri.TC = txtTC.Text;
                    musteri.Adres = txtAdres.Text;
                    musteri.Aciklama = txtAciklama.Text;

                    repoMusteri.Update(musteri);
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Boyle Bir Musteri Yok","UYARI!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void Temizle()
        {
            txtAciklama.Clear();
            txtAd.Clear();
            txtAdres.Clear();
            txtEmail.Clear();
            txtLakap.Clear();
            txtSoyad.Clear();
            txtTC.Clear();
            msktxtCep.Clear();
            msktxtFax.Clear();
            msktxtTelefon.Clear();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                Musteri musteri = repoMusteri.Listele(w => w.ID == secilenMusteriID).FirstOrDefault();
                if(musteri != null)
                {
                    repoMusteri.Delete(musteri);
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Boyle Bir Musteri Yok", "UYARI!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMusteriBul_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMusteriListele frmMusteriListele = new FrmMusteriListele();
            Araclar.frmMstrListele = frmMusteriListele;
            frmMusteriListele.Show();

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
