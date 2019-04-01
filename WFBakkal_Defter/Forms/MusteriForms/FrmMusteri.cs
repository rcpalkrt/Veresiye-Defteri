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

namespace WFBakkal_Defter
{
    public partial class FrmMusteri : Form
    {
        public FrmMusteri()
        {
            InitializeComponent();
        }

        SqlRepository<Musteri> repoMusteri = new SqlRepository<Musteri>();

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                repoMusteri.Insert(new Musteri
                {
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    Lakap = txtLakap.Text,
                    EvTelefon = msktxtTelefon.Text,
                    CepTelefon = msktxtCep.Text,
                    Fax = msktxtFax.Text,
                    Email = txtEmail.Text,
                    TC = txtTC.Text,
                    Adres = txtAdres.Text,
                    Aciklama = txtAciklama.Text
                });
                Temizle();
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

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
     
    }
}
