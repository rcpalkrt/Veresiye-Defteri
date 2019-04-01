using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace BAKKAL_BOL.Entities
{
    [Table("Musteri")]
    public class Musteri
    {
        public int ID { get; set; }
        [Column(TypeName = "varchar"), StringLength(30)]
        public string Ad { get; set; }
        [Column(TypeName = "varchar"), StringLength(30)]
        public string Soyad { get; set; }
        [Column(TypeName = "varchar"), StringLength(30)]
        public string Lakap { get; set; }
        [Column(TypeName = "varchar"), StringLength(20)]
        public string EvTelefon { get; set; }
        [Column(TypeName = "varchar"), StringLength(20)]
        public string CepTelefon { get; set; }
        [Column(TypeName = "varchar"), StringLength(20)]
        public string Fax { get; set; }
        [Column(TypeName = "varchar"), StringLength(20)]
        public string Email { get; set; }
        [Column(TypeName = "char"), StringLength(11)]
        public string TC { get; set; }
        [Column(TypeName = "varchar"), StringLength(150)]
        public string Aciklama { get; set; }
        [Column(TypeName = "varchar"), StringLength(150)]
        public string Adres { get; set; }
    }
}
