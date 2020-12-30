using Framework.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Framework
{
    public class FrameworkContext : DbContext
    {
        private string _connectionString;
        private string _migrationAssemblyName;

        public FrameworkContext(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            if (!dbContextOptionsBuilder.IsConfigured)
            {
                dbContextOptionsBuilder.UseSqlServer(
                    _connectionString,
                    m => m.MigrationsAssembly(_migrationAssemblyName));
            }

            base.OnConfiguring(dbContextOptionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<PaperDetails>()
                .HasOne(p => p.PaperCategory)
                .WithMany(c => c.PaperDetails);

            builder.Entity<PaperDetails>()
                .HasOne(p => p.ResearchSeminar)
                .WithOne(r => r.PaperDetails)
                .HasForeignKey<ResearchSeminar>(r => r.PaperDetailsId);

            builder.Entity<PaperDetails>()
                .HasOne(p => p.ResearchCollaboration)
                .WithOne(c => c.PaperDetails)
                .HasForeignKey<ResearchCollaboration>(c => c.PaperDetailsId);

            base.OnModelCreating(builder);
        }

        public DbSet<PaperCategory> PaperCategories { get; set; }
        public DbSet<PaperDetails> PaperDetails { get; set; }
        public DbSet<ResearchSeminar> ResearchSeminars { get; set; }
        public DbSet<ResearchCollaboration> ResearchCollaborations { get; set; }
        public DbSet<Task> Tasks { get; set; }

    }
}
