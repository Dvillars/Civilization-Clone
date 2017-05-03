using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Civilized.Models
{
    public class CivDbContext : IdentityDbContext<ApplicationUser>
    {
        public CivDbContext(DbContextOptions options) : base(options)
        {

        }

        public CivDbContext()
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public DbSet<Economy> Economies { get; set; }
        public DbSet<Civilization> Civilizations { get; set; }
        public DbSet<Geography> Geopgraphies { get; set; }
        public DbSet<Government> Governments { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Account> Accounts { get; set; }
    }
}
