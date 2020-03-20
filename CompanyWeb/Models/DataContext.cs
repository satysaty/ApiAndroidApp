using CompanyWeb.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CompanyWeb.Models
{
    public class DataContext : DbContext
    {
        public DataContext() : base("localhost")
        {
            Database.SetInitializer<DataContext>(new DBInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Work>()
                .HasMany(p => p.Categories)
                .WithMany(c => c.Works);
            modelBuilder.Entity<Work>()
                .HasMany(p => p.Masters)
                .WithMany(c => c.Works);
            modelBuilder.Entity<Repair>()
                .HasMany(p => p.Options)
                .WithMany(c => c.Repairs);
            modelBuilder.Entity<WorkOption>()
                .HasMany(p => p.Options)
                .WithMany(c => c.WorkOptions);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Work> Works { get; set; }

        public DbSet<Master> Masters { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<Repair> Repairs { get; set; }

        public DbSet<Option> Options { get; set; }

        public DbSet<WorkOption> WorkOptions { get; set; }

        //public DbSet<RepairOption> RepairOptions { get; set; }
    }
}