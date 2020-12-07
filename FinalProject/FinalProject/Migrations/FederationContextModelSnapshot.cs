﻿// <auto-generated />
using FinalProject.Models.DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FinalProject.Migrations
{
    [DbContext(typeof(FederationContext))]
    partial class FederationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("FinalProject.Models.Federation", b =>
                {
                    b.Property<int>("FederationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<double>("Cost")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tested")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WeighIn")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FederationID");

                    b.ToTable("Federations");

                    b.HasData(
                        new
                        {
                            FederationID = 1,
                            Cost = 45.0,
                            Name = "USAPL",
                            Tested = "Drug tested",
                            WeighIn = "24 Hours"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
