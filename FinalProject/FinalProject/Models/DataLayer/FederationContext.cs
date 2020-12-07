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
                    WeighIn = "2 Hours",
                    Tested = "Drug tested",
                    Cost = 45
                },
                new Federation
                {
                    FederationID = 2,
                    Name = "USPA",
                    WeighIn = "24 hours",
                    Tested = "Not drug tested",
                    Cost = 30
                },
                new Federation
                {
                    FederationID = 3,
                    Name = "APF",
                    WeighIn = "24 Hours",
                    Tested = "Tested and untested divisions",
                    Cost = 30
                },
                new Federation
                {
                    FederationID = 4,
                    Name = "RPS",
                    WeighIn = "24 hours",
                    Tested = "Not drug tested",
                    Cost = 0
                });
            base.OnModelCreating(modelBuilder);
        }
    }
}
