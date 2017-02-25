using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace dc_snoop_database_writer.Models
{
    public partial class dc_snoopContext : DbContext
    {
        public virtual DbSet<Addresses> Addresses { get; set; }
        public virtual DbSet<People> People { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json");
            var configuration = builder.Build();
            
            optionsBuilder.UseNpgsql(configuration.GetConnectionString("SnoopDatabase"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<People>(entity =>
            {
                entity.HasIndex(e => e.AddressId)
                    .HasName("IX_People_AddressId");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.People)
                    .HasForeignKey(d => d.AddressId);
            });
        }
    }
}