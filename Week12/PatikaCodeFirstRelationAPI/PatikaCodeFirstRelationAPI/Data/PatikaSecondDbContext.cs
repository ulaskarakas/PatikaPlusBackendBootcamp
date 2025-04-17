using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using PatikaCodeFirstRelationAPI.Data.Entities;

namespace PatikaCodeFirstRelationAPI.Data
{
    public class PatikaSecondDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }

        public PatikaSecondDbContext(DbContextOptions<PatikaSecondDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS; Database=PatikaCodeFirstDb2; Trusted_Connection = true; TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("Users");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Username).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Email).IsRequired().HasMaxLength(50);

                entity.HasMany(e => e.Posts)
                      .WithOne(e => e.User)
                      .HasForeignKey(e => e.UserId)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.ToTable("Posts");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Title).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Content).IsRequired().HasMaxLength(500);
            });
        }
    }
}
