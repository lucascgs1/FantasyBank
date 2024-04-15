using FantasyBank.Model;
using Microsoft.EntityFrameworkCore;

namespace FantasyBank.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Trade>(
             entity =>
             {
                 entity.HasOne(s => s.Category);
             });
        }

        public DbSet<Trade> Trade { get; set; }
        public DbSet<TradeCategories> TradeCategories { get; set; }
    }
}