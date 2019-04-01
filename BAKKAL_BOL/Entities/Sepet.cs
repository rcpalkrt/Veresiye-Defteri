using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAKKAL_BOL.Entities
{
    [Table("Sepet")]
    public class Sepet
    {
        public int ID { get; set; }
        public int UrunID { get; set; }
        public Urun Urun { get; set; }
        public int MusteriID { get; set; }
        public Musteri Musteri { get; set; }
    }
}
