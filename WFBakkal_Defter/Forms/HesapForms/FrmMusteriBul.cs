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
    public partial class FrmMusteriBul : Form
    {
        public FrmMusteriBul()
        {
            InitializeComponent();
            Araclar.frmMusteriBul = this;
        }

        SqlRepository<Musteri> repoMusteri = new SqlRepository<Musteri>();

        private void FrmMusteriBul_Load(object sender, EventArgs e)
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
            Araclar.frmVadeliSatis.mstri = musteri;
            Araclar.frmVadeliSatis.FrmVadeliSatis_Load(null, null);
            Araclar.frmVadeliSatis.Show();
            this.Close();
        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = repoMusteri.Listele(w => w.Ad.Contains(txtAd.Text) 
                                                             && w.Soyad.Contains(txtSoyad.Text)
                                                             && w.Lakap.Contains(txtUnvanLakap.Text)).ToList();
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            int m_id = Convert.ToInt16(dataGridView1.CurrentRow.Cells["ID"].Value);
            Musteri musteri = repoMusteri.Listele(w => w.ID == m_id).FirstOrDefault();
            FrmVadeliSatis frmVadeliSatis = new FrmVadeliSatis();
            Araclar.frmVadeliSatis = frmVadeliSatis;
            frmVadeliSatis.mstri = musteri;
            frmVadeliSatis.Show();
            this.Close();
        }

    }
}
