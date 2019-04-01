using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAKKAL_BOL.Entities
{
    [Table("Tedarikci")]
    public class Tedarikci
    {
        public int ID { get; set; }
        [Column(TypeName = "varchar"), StringLength(30)]
        public string Ad { get; set; }
        [Column(TypeName = "varchar"), StringLength(30)]
        public string Sektor { get; set; }
        [Column(TypeName = "varchar"), StringLength(30)]
        public string YetkiliAd { get; set; }
        [Column(TypeName = "varchar"), StringLength(30)]
        public string YetkiliSoyad { get; set; }
        [Column(TypeName = "varchar"), StringLength(30)]
        public string EvTelefon { get; set; }
        [Column(TypeName = "varchar"), StringLength(20)]
        public string CepTelefon { get; set; }
        [Column(TypeName = "varchar"), StringLength(20)]
        public string Fax { get; set; }
        [Column(TypeName = "varchar"), StringLength(20)]
        public string Email { get; set; }
        [Column(TypeName = "varchar"), StringLength(20)]
        public string VergiDairesi { get; set; }
        [Column(TypeName = "varchar"), StringLength(20)]
        public string VergiNo { get; set; }
        [Column(TypeName = "varchar"), StringLength(150)]
        public string Aciklama { get; set; }
        [Column(TypeName = "varchar"), StringLength(150)]
        public string Adres { get; set; }
    }
}
