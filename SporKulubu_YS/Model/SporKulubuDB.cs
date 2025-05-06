using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SporKulubuYS_Service.Model
{
    public class SporKulubuDB : DbContext
    {
       
            public DbSet<Antrenor> Antrenorler { get; set; }
            public DbSet<Brans> Branslar { get; set; }
            public DbSet<BransAntrenor> BransAntrenorler { get; set; }
            public DbSet<Etkinlik> Etkinlikler { get; set; }
            public DbSet<Salon> Salonlar { get; set; }
            public DbSet<Sporcu> Sporcular { get; set; }
            public DbSet<SporcuBrans> SporcuBranslar { get; set; }
            


            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("Server=GÜL\\SQLEXPRESS;Database=SporKulubuYS;Trusted_Connection=True;TrustServerCertificate=True");
            }
        }
}
