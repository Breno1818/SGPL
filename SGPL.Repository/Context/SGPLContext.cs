using Microsoft.EntityFrameworkCore;
using SGPL.Domain.Entities;
using SGPL.Repository.Mapping;

namespace SGPL.Repository.Context
{
    public class SGPLContext : DbContext
    {
        public SGPLContext
            (DbContextOptions<SGPLContext>? op=null) : base()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseMySQL("server=localhost;database=sgpl;user=root;password=");
        }

        public DbSet<Animal> Animals { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Feed> Feeds { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleItem> SalesItems { get; set; }
        public DbSet<Production> Productions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new AnimalMap());
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new FeedMap());
            modelBuilder.ApplyConfiguration(new ProductionMap());
            modelBuilder.ApplyConfiguration(new SaleMap());
            modelBuilder.ApplyConfiguration(new SaleItemMap());
        }
    }
}
