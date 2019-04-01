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
using System.Xml;

namespace WFBakkal_Defter.Forms
{
    public partial class FrmMusteriListele : Form
    {
        public FrmMusteriListele()
        {
            InitializeComponent();
            Araclar.frmMstrListele = this;
        }

        SqlRepository<Musteri> repoMusteri = new SqlRepository<Musteri>();

        private void FrmMusteriListele_Load(object sender, EventArgs e)
        {
            Yukle();
        }
        void Yukle()
        {
            dataGridView1.DataSource = repoMusteri.Listele().ToList();
            dataGridView1.Columns[0].Visible = false;
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int m_id = Convert.ToInt16(dataGridView1.CurrentRow.Cells["ID"].Value);
            Musteri musteri = repoMusteri.Listele(w => w.ID == m_id).FirstOrDefault();
            MusteriDuzenle musteriDuzenle = new MusteriDuzenle();
            Araclar.frmMusteriDuzenle = musteriDuzenle;
            musteriDuzenle.mstri = musteri;
            musteriDuzenle.Show();
            this.Close();
        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = repoMusteri.Listele(w => w.Ad.Contains(txtAd.Text)
                                                             && w.Soyad.Contains(txtSoyad.Text)
                                                             && w.Lakap.Contains(txtUnvanLakap.Text)).ToList();
        }

        private void btnXmlOlustur_Click(object sender, EventArgs e)
        {
            XmlTextWriter xmldosyasi = new XmlTextWriter("Musteriler.xml", System.Text.UTF8Encoding.UTF8);
            xmldosyasi.Formatting = Formatting.Indented;

            try
            {
                xmldosyasi.WriteStartDocument();
                xmldosyasi.WriteStartElement("Musteris");
                foreach (Musteri herbirMusteri in repoMusteri.Listele().ToList())
                {
                    xmldosyasi.WriteStartElement("Musteri");
                    xmldosyasi.WriteAttributeString("ID", herbirMusteri.ID.ToString());
                    xmldosyasi.WriteElementString("Ad", herbirMusteri.Ad);
                    xmldosyasi.WriteElementString("Soyad", herbirMusteri.Soyad);
                    xmldosyasi.WriteElementString("Lakap", herbirMusteri.Lakap);
                    xmldosyasi.WriteElementString("CepTelefon", herbirMusteri.CepTelefon);
                    xmldosyasi.WriteElementString("Adres", herbirMusteri.Adres);
                    xmldosyasi.WriteEndElement();
                }
                xmldosyasi.WriteEndElement();
                xmldosyasi.Close();

                MessageBox.Show("XML Dosyası Oluşturuldu!","Bilgilendirme.!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: açıklama:" + ex.Message);
            }
        }
    }
}
