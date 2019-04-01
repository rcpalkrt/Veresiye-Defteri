using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAKKAL_BOL.Entities
{
    [Table("MBorc")]
   public class MBorc
    {
        public int ID { get; set; }
        public int UrunMiktar { get; set; }
        public EBirim eBirim { get; set; }
        public decimal BorcMiktar { get; set; }
        public decimal Tahsilat { get; set; }
        public EOdemeTur eOdemeTur { get; set; }
        public DateTime VadeTarih { get; set; }
        public DateTime IslemTarih { get; set; }
        [Column(TypeName = "varchar"), StringLength(150)]
        public string Aciklama { get; set; }
        public int UrunID { get; set; }
        public Urun Urun { get; set; }
        public int MusteriID { get; set; }
        public Musteri Musteri { get; set; }
    }
}
