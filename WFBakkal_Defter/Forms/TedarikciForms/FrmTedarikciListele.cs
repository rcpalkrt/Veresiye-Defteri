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
    public partial class FrmTedarikciListele : Form
    {
        public FrmTedarikciListele()
        {
            InitializeComponent();
            Araclar.frmTedarikciListele = this;
        }

        SqlRepository<Tedarikci> repoTedarikci = new SqlRepository<Tedarikci>();

        private void FrmTedarikciListele_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = repoTedarikci.Listele().Select(s => new { s.ID, s.Ad, s.Sektor, s.YetkiliAd, s.YetkiliSoyad }).ToList();
            dataGridView1.Columns[0].Visible = false;
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int t_id = Convert.ToInt16(dataGridView1.CurrentRow.Cells["ID"].Value);
            Tedarikci tedarikci = repoTedarikci.Listele(w => w.ID == t_id).FirstOrDefault();
            Araclar.frmTedarikciDuzenle.tedarikci = tedarikci;
            Araclar.frmTedarikciDuzenle.FrmTedarikciDuzenle_Load(null, null);
            Araclar.frmTedarikciDuzenle.Show();
            this.Close();
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            int t_id = Convert.ToInt16(dataGridView1.CurrentRow.Cells["ID"].Value);
            Tedarikci tedarikci = repoTedarikci.Listele(w => w.ID == t_id).FirstOrDefault();
            Araclar.frmTedarikciDuzenle.tedarikci = tedarikci;
            Araclar.frmTedarikciDuzenle.FrmTedarikciDuzenle_Load(null, null);
            Araclar.frmTedarikciDuzenle.Show();
            this.Close();
        }

        private void txtTedarikciAd_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = repoTedarikci.Listele(w => w.Ad.Contains(txtTedarikciAd.Text)
                                                                && w.Sektor.Contains(txtSektor.Text)
                                                                && w.YetkiliAd.Contains(txtYetkiliAd.Text)
                                                                && w.YetkiliSoyad.Contains(txtYetkiliSoyad.Text)).Select(s => new
                                                                { s.ID, s.Ad, s.Sektor, s.YetkiliAd, s.YetkiliSoyad }).ToList();
        }
    }
}
