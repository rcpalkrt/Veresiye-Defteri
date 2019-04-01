
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFBakkal_Defter.Forms;
using WFBakkal_Defter.Forms.HesapForms;
using WFBakkal_Defter.Forms.TedarikciForms;
using WFBakkal_Defter.Forms.UrunForms;

namespace WFBakkal_Defter
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            FrmMusteri frmMusteri = new FrmMusteri();
            frmMusteri.ShowDialog();
        }

        private void btn_MusteriDuzenle_Click(object sender, EventArgs e)
        {
            MusteriDuzenle musteriDuzenle = new MusteriDuzenle();
            musteriDuzenle.ShowDialog();
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            FrmUrunEkleme frmUrunEkleme = new FrmUrunEkleme();
            frmUrunEkleme.ShowDialog();
        }

        private void btnUrunDuzenleSil_Click(object sender, EventArgs e)
        {
            FrmUrunDuzenle frmUrunDuzenle = new FrmUrunDuzenle();
            frmUrunDuzenle.ShowDialog();
        }

        private void btnZamUygula_Click(object sender, EventArgs e)
        {
            FrmUrunZam frmUrunZam = new FrmUrunZam();
            frmUrunZam.ShowDialog();
        }

        private void btnVadeliSatis_Click(object sender, EventArgs e)
        {
            FrmVadeliSatis frmVadeliSatis = new FrmVadeliSatis();
            FrmMusteriBul frmMusteriBul = new FrmMusteriBul();
            Araclar.frmVadeliSatis = frmVadeliSatis;
            frmVadeliSatis.Show();
            frmMusteriBul.ShowDialog();
        }

        private void btnPesinSatis_Click(object sender, EventArgs e)
        {
            FrmPesinSatis frmPesinSatis = new FrmPesinSatis();
            Araclar.frmPesinSatis = frmPesinSatis;
            frmPesinSatis.ShowDialog();
        }

        private void btnTedarikciEkle_Click(object sender, EventArgs e)
        {
            FrmTedarikciEkle frmTedarikciEkle = new FrmTedarikciEkle();
            Araclar.frmTedarikciEkle = frmTedarikciEkle;
            frmTedarikciEkle.ShowDialog();
        }

        private void btnTedarikciDuzenle_Click(object sender, EventArgs e)
        {
            FrmTedarikciDuzenle frmTedarikciDuzenle = new FrmTedarikciDuzenle();
            Araclar.frmTedarikciDuzenle = frmTedarikciDuzenle;
            frmTedarikciDuzenle.ShowDialog();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
