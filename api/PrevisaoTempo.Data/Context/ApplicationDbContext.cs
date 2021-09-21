using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using PrevisaoTempo.Domain.Entities;

namespace PrevisaoTempo.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

         public virtual DbSet<SearchUser> search_user { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {                
                optionsBuilder.UseNpgsql("Host=localhost;Database=postgres;Username=postgres;Password=password");
            }

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<SearchUser>(entity =>
            {
                entity.ToTable("search_user");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.Temp)
                    .IsRequired()
                    .HasColumnName("temp");

                entity.Property(e => e.Weather)
                    .IsRequired()
                    .HasColumnName("weather");

                entity.Property(e => e.Icon)
                    .IsRequired()
                    .HasColumnName("icon");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.CreationDate)
                    .IsRequired()
                    .HasColumnName("creationDate");                
            });
          
        }        
    }
}