﻿using AFS_Visa_Application_REST_API.Entity;
using Microsoft.EntityFrameworkCore;

namespace AFS_Visa_Application_REST_API.Db
{
    public class VisaApplicationContext : DbContext
    {
        public VisaApplicationContext()
        {
            
        }

        public VisaApplicationContext(DbContextOptions<VisaApplicationContext> options) : base(options)
        {
        }

        public DbSet<Country> Country { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=AFSDatabase;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasMany(e => e.VisasExempt).WithMany(e => e.CountriesExempt).UsingEntity(join => join.ToTable("CountryExemption"));
            modelBuilder.Entity<Visa>().HasMany(e => e.DocumentationRequired).WithMany(e => e.Visa);
            modelBuilder.Entity<Country>().HasMany(e => e.VisasOffered).WithOne(e => e.OfferingCountry);
            modelBuilder.Entity<Visa>().Navigation(e => e.DocumentationRequired).AutoInclude();
        }
    }
}
