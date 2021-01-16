﻿// <auto-generated />
using System;
using Framework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Research_Coordinating_System.Migrations.Framework
{
    [DbContext(typeof(FrameworkContext))]
    partial class FrameworkContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Framework.Entities.PaperCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PaperCategories");
                });

            modelBuilder.Entity("Framework.Entities.PaperDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuthorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConferenceLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Page")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PaperCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("PaperTilte")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ResearchCollaborationId")
                        .HasColumnType("int");

                    b.Property<int>("ResearchSeminarId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Submitdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Volume")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PaperCategoryId");

                    b.HasIndex("PaperTilte")
                        .IsUnique()
                        .HasFilter("[PaperTilte] IS NOT NULL");

                    b.ToTable("PaperDetails");
                });

            modelBuilder.Entity("Framework.Entities.ResearchCollaboration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PaperDetailsId")
                        .HasColumnType("int");

                    b.Property<string>("PartnerName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PaperDetailsId")
                        .IsUnique();

                    b.ToTable("ResearchCollaborations");
                });

            modelBuilder.Entity("Framework.Entities.ResearchSeminar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("NumberOfParticipants")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PaperDetailsId")
                        .HasColumnType("int");

                    b.Property<string>("ResourcePerson")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vanue")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PaperDetailsId")
                        .IsUnique();

                    b.ToTable("ResearchSeminars");
                });

            modelBuilder.Entity("Framework.Entities.Task", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AssignesTo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DeadLine")
                        .HasColumnType("datetime2");

                    b.Property<string>("File")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaskAuthor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaskName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("Framework.Entities.PaperDetails", b =>
                {
                    b.HasOne("Framework.Entities.PaperCategory", "PaperCategory")
                        .WithMany("PaperDetails")
                        .HasForeignKey("PaperCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Framework.Entities.ResearchCollaboration", b =>
                {
                    b.HasOne("Framework.Entities.PaperDetails", "PaperDetails")
                        .WithOne("ResearchCollaboration")
                        .HasForeignKey("Framework.Entities.ResearchCollaboration", "PaperDetailsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Framework.Entities.ResearchSeminar", b =>
                {
                    b.HasOne("Framework.Entities.PaperDetails", "PaperDetails")
                        .WithOne("ResearchSeminar")
                        .HasForeignKey("Framework.Entities.ResearchSeminar", "PaperDetailsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
