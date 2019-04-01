using BAKKAL_BOL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAKKAL_DAL.Contexts
{
    public class SQLDbContext : DbContext
    {
        public DbSet<Musteri> musteris { get; set; }
        public DbSet<Urun> uruns { get; set; }
        public DbSet<Tedarikci> tedarikcis { get; set; }
        public DbSet<MBorc> mBorcs { get; set; }
        public DbSet<TBorc> tBorcs { get; set; }
        public DbSet<Sepet> sepets { get; set; }
        public DbSet<SepetMusteri> sepetMusteris { get; set; }
    }
}



