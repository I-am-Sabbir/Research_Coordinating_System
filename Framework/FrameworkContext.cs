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

            base.OnModelCreating(builder);

            builder.Entity<PaperDetails>(PD =>
            {
                PD.HasKey(rc => new { rc.Id, rc.ResearchCollaborationId });

                PD.HasOne(pd => pd.ResearchCollaboration)
                .WithOne()
                .HasForeignKey<PaperDetails>(pd => pd.ResearchCollaborationId);
            });

            builder.Entity<PaperDetails>(PD =>
            {
                PD.HasKey(rc => new { rc.Id, rc.ResearchSeminarId });

                PD.HasOne(pd => pd.ResearchSeminar)
                .WithOne()
                .HasForeignKey<PaperDetails>(pd => pd.ResearchSeminarId);
            });

            builder.Entity<ResearchCollaboration>(RC =>
            {
                RC.HasKey(rc => new { rc.Id, rc.PaperDetailsId });

                RC.HasOne(rc => rc.PaperDetails)
                .WithOne()
                .HasForeignKey<ResearchCollaboration>(rc => rc.PaperDetailsId)
                .IsRequired();
            });

            builder.Entity<ResearchSeminar>(RS => 
            {
                RS.HasKey(rs => new { rs.Id, rs.PaperDetailsId });

                RS.HasOne(rs => rs.PaperDetails)
                .WithOne()
                .HasForeignKey<ResearchSeminar>(rs => rs.PaperDetailsId)
                .IsRequired();
            });

            builder.Entity<Task>(Task =>
            {
                Task.HasKey(t => new { t.Id, t.UserId });

                Task.HasOne(t => t.ApplicationUser);
                //.WithMany(au => au.Task);
            });

        }

        public DbSet<PaperCategory> PaperCategories { get; set; }
        public DbSet<PaperDetails> PaperDetails { get; set; }
        public DbSet<ResearchSeminar> ResearchSeminars { get; set; }
        public DbSet<ResearchCollaboration> ResearchCollaborations { get; set; }
        public DbSet<Task> Tasks { get; set; }

    }
}
