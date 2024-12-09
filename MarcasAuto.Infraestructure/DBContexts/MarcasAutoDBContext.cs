using MarcasAuto.Domain.Entities;
using MarcasAuto.Infraestructure.Seeds;
using Microsoft.EntityFrameworkCore;

namespace MarcasAuto.Infraestructure.DBContexts
{
    public class MarcasAutoDBContext(DbContextOptions<MarcasAutoDBContext> options) : DbContext(options)
    {
        public DbSet<MarcasAutoEntity> MarcasAuto { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // MarcasAutoEntity
            builder.Entity<MarcasAutoEntity>().ToTable("MarcasAuto");
            builder.Entity<MarcasAutoEntity>().HasIndex(e => e.Id);
            builder.Entity<MarcasAutoEntity>().Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Entity<MarcasAutoEntity>().Property(e => e.Make).IsRequired();

            // Seed
            builder.Entity<MarcasAutoEntity>().HasData(MarcasSeed.Items);
        }
    }
}
