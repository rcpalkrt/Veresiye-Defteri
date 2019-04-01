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

namespace WFBakkal_Defter.Forms.UrunForms
{
    public partial class FrmUrunZam : Form
    {
        public FrmUrunZam()
        {
            InitializeComponent();
        }

        SqlRepository<Urun> repoUrun = new SqlRepository<Urun>();
        SQLDbContext db = new SQLDbContext();

        private void FrmUrunZam_Load(object sender, EventArgs e)
        {
            Yukle();
        }

        void Yukle()
        {
            var urunler = from u in db.uruns
                          orderby u.Ad ascending
                          select new { u.ID, u.Ad };
            cmbUrun.DataSource = urunler.ToList();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int u_id = Convert.ToInt16(cmbUrun.SelectedValue);
                
                Urun urun = repoUrun.Listele(w => w.ID == u_id).FirstOrDefault();
                if(urun != null)
                {
                    int zam = Convert.ToInt16(txtZamOrani.Text);
                    decimal eskiFiyat = urun.SFiyat;
                    decimal yenifiyat = eskiFiyat + (eskiFiyat * zam) / 100;
                    urun.SFiyat = yenifiyat;

                    repoUrun.Update(urun);
                    txtZamOrani.Clear();

                    MessageBox.Show("Fiyatı " + eskiFiyat + " olan " + urun.Ad + " ürünün yeni fiyatı : " + yenifiyat,"BİLGİLENDİRME!");
                }
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
