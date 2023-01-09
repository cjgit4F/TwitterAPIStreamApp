using Microsoft.EntityFrameworkCore;

namespace TwitterAPIStreamApp.Models
{
    public class TweetsContext : DbContext
    {
        public TweetsContext(DbContextOptions<TweetsContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<public_metrics>()
                .HasMany(c => c.Tweets)
                .WithOne(a => a.Public_metrics1)
                .HasForeignKey(a => a.public_metricsid);

            modelBuilder.Seed();
        }

        public DbSet<public_metrics> public_metrics { get; set; }
        public DbSet<Tweet> Tweets { get; set; }
    }
}
