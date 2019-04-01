using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAKKAL_BOL.Entities
{
    [Table("SepetMusteri")]
    public class SepetMusteri
    {
        public int ID { get; set; }
        [Column(TypeName = "varchar"), StringLength(30)]
        public string MusteriAd { get; set; }
        public DateTime Tarih { get; set; }
        public DateTime Saat { get; set; }
    }
}
