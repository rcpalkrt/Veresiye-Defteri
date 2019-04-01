using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAKKAL_BOL.Entities
{
    [Table("Urun")]
    public class Urun
    {
        public int ID { get; set; }
        [Column(TypeName = "varchar"), StringLength(30)]
        public string Ad { get; set; }
        [Column(TypeName = "varchar"), StringLength(30)]
        public string Barkod { get; set; }
        public EBirim Birim { get; set; }
        public int Miktar { get; set; }
        public bool Sinirsiz { get; set; }
        public decimal AFiyat { get; set; }
        public decimal SFiyat { get; set; }
        public DateTime ATarih { get; set; }
        public DateTime SKTarih { get; set; }
    }
    public enum EBirim
    {
        ADET=1,
        KUTU,
        GRAM,
        KİLO,
        TON,
        METRE,
        ÇUVAL,
        KOLİ,
        PAKET
    }
}
