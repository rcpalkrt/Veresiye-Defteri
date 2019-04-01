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
    public partial class FrmPesinMusteriListele : Form
    {
        public FrmPesinMusteriListele()
        {
            InitializeComponent();
            Araclar.frmPesinMusteriListele = this;
        }

        SqlRepository<Musteri> repoMusteri = new SqlRepository<Musteri>();

        private void FrmPesinMusteriListele_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = repoMusteri.Listele().ToList();
            dataGridView1.Columns[0].Visible = false;
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int m_id = Convert.ToInt16(dataGridView1.CurrentRow.Cells["ID"].Value);
            Musteri musteri = repoMusteri.Listele(w => w.ID == m_id).FirstOrDefault();
            Araclar.frmPesinSatis.mstri = musteri;
            Araclar.frmPesinSatis.FrmPesinSatis_Load(null, null);
            Araclar.frmPesinSatis.Show();
            this.Close();
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            int m_id = Convert.ToInt16(dataGridView1.CurrentRow.Cells["ID"].Value);
            Musteri musteri = repoMusteri.Listele(w => w.ID == m_id).FirstOrDefault();
            Araclar.frmPesinSatis.mstri = musteri;
            Araclar.frmPesinSatis.FrmPesinSatis_Load(null, null);
            Araclar.frmPesinSatis.Show();
            this.Close();
        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = repoMusteri.Listele(w => w.Ad.Contains(txtAd.Text)
                                                             && w.Soyad.Contains(txtSoyad.Text)
                                                             && w.Lakap.Contains(txtUnvanLakap.Text)).ToList();
        }
    }
}
