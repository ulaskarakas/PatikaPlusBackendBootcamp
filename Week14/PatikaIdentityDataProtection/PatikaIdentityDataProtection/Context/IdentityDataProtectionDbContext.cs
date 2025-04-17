using Microsoft.EntityFrameworkCore;
using PatikaIdentityDataProtection.Entities;

namespace PatikaIdentityDataProtection.Context
{
    public class IdentityDataProtectionDbContext : DbContext
    {
        public IdentityDataProtectionDbContext(DbContextOptions<IdentityDataProtectionDbContext> options) : base(options) 
        { 
        
        }

        public DbSet<User> Users { get; set; }
    }
}