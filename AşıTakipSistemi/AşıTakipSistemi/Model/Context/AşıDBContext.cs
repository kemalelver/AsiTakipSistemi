using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using AşıTakipSistemi.Model.Entity;

namespace AşıTakipSistemi.Model.Context
{
     class AşıDBContext : DbContext
    {
        public DbSet<Çalışanlar> Çalışanlar { get; set; }
        public DbSet<Aşılar> Aşılar { get; set; }
        public DbSet<Hastalar> Hastalar { get; set; }
    }
}
