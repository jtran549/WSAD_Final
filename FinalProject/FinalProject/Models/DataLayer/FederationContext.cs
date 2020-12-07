using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Models.DataLayer
{
    public class FederationContext : DbContext
    {
        public FederationContext(DbContextOptions<FederationContext> options) : base(options) { }
        public DbSet<Federation> Federations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Federation>().HasData(
                new Federation
                {
                    FederationID = 1,
                    Name = "USAPL",
                    WeighIn = "24 Hours",
                    Tested = "Drug tested",
                    Cost = 45
                });
            base.OnModelCreating(modelBuilder);
        }
    }
}
