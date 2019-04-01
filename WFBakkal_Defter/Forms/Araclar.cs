using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFBakkal_Defter.Forms.HesapForms;
using WFBakkal_Defter.Forms.TedarikciForms;

namespace WFBakkal_Defter.Forms
{
    public class Araclar
    {
        public static MusteriDuzenle frmMusteriDuzenle { get; set; }
        public static FrmMusteriListele frmMstrListele { get; set; }
        public static FrmMusteri frmMusteri { get; set; }
        public static FrmVadeliSatis frmVadeliSatis { get; set; }
        public static FrmMusteriBul frmMusteriBul { get; set; }
        public static FrmMBorcEkle frmMBorcEkle { get; set; }
        public static FrmMTahsilatEkle FrmMTahsilatEkle { get; set; }
        public static FrmTedarikciEkle frmTedarikciEkle { get; set; }
        public static FrmTedarikciDuzenle frmTedarikciDuzenle { get; set; }
        public static FrmTedarikciListele frmTedarikciListele { get; set; }
        public static FrmPesinSatis frmPesinSatis { get; set; }
        public static FrmPesinMusteriListele frmPesinMusteriListele { get; set; }
    }
}
