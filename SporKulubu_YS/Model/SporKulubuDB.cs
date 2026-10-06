using Microsoft.EntityFrameworkCore;

namespace SporKulubuYS_Service.Model
{
    public class SporKulubuDB : DbContext
    {
        /// <summary>
        /// Bağlantı cümlesi. "." bu bilgisayardaki SQL Server Express anlamına gelir,
        /// böylece proje farklı bilgisayarlarda da değişiklik yapmadan çalışır.
        /// </summary>
        public static string ConnectionString { get; set; } =
            @"Server=.\SQLEXPRESS;Database=SporKulubuYS;Trusted_Connection=True;TrustServerCertificate=True";

        public DbSet<Antrenor> Antrenorler { get; set; }
        public DbSet<Brans> Branslar { get; set; }
        public DbSet<BransAntrenor> BransAntrenorler { get; set; }
        public DbSet<Etkinlik> Etkinlikler { get; set; }
        public DbSet<Salon> Salonlar { get; set; }
        public DbSet<Sporcu> Sporcular { get; set; }
        public DbSet<SporcuBrans> SporcuBranslar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionString);
            }
        }
    }
}
