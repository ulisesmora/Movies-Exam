﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Movies_Exam.Persistence;

#nullable disable

namespace Movies_Exam.Migrations
{
    [DbContext(typeof(MoviesContext))]
    [Migration("20230614122349_MigrationSqlInitial6")]
    partial class MigrationSqlInitial6
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Movies_Exam.Model.Genre", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genre");
                });

            modelBuilder.Entity("Movies_Exam.Model.Language", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Language");
                });

            modelBuilder.Entity("Movies_Exam.Model.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("StaffId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("StaffId");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("Movies_Exam.Model.Stadistics", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Views")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Stadistics");
                });

            modelBuilder.Entity("Movies_Exam.Model.Staff", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("BornhDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Staff");
                });

            modelBuilder.Entity("Movies_Exam.Model.TypeContent", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("NameContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TypeContent");
                });

            modelBuilder.Entity("Movies_Exam.Model.VisualContent", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float?>("Rating")
                        .HasColumnType("real");

                    b.Property<int>("RealeseYear")
                        .HasColumnType("int");

                    b.Property<Guid>("StadisticId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("StadisticsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Synopsis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TypeContentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("StadisticsId");

                    b.HasIndex("TypeContentId");

                    b.ToTable("VisualContent");
                });

            modelBuilder.Entity("Movies_Exam.Model.VisualContentGenre", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GenreId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("VisualContentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.HasIndex("VisualContentId");

                    b.ToTable("VisualContentGenre");
                });

            modelBuilder.Entity("Movies_Exam.Model.VisualContentLanguage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LanguageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LanguageSubtitleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("VisualContentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.HasIndex("VisualContentId");

                    b.ToTable("VisualContentLanguage");
                });

            modelBuilder.Entity("Movies_Exam.Model.VisualContentStaff", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GenreId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("StaffId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("VisualContentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.HasIndex("StaffId");

                    b.HasIndex("VisualContentId");

                    b.ToTable("VisualContentStaff");
                });

            modelBuilder.Entity("Movies_Exam.Model.Role", b =>
                {
                    b.HasOne("Movies_Exam.Model.Staff", "Staff")
                        .WithMany("RoleList")
                        .HasForeignKey("StaffId");

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("Movies_Exam.Model.VisualContent", b =>
                {
                    b.HasOne("Movies_Exam.Model.Stadistics", "Stadistics")
                        .WithMany("VisualContent")
                        .HasForeignKey("StadisticsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Movies_Exam.Model.TypeContent", "TypeContent")
                        .WithMany("VisualContent")
                        .HasForeignKey("TypeContentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Stadistics");

                    b.Navigation("TypeContent");
                });

            modelBuilder.Entity("Movies_Exam.Model.VisualContentGenre", b =>
                {
                    b.HasOne("Movies_Exam.Model.Genre", "Genre")
                        .WithMany("GenreLink")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Movies_Exam.Model.VisualContent", "VisualContent")
                        .WithMany("GenreLink")
                        .HasForeignKey("VisualContentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");

                    b.Navigation("VisualContent");
                });

            modelBuilder.Entity("Movies_Exam.Model.VisualContentLanguage", b =>
                {
                    b.HasOne("Movies_Exam.Model.Language", "Language")
                        .WithMany("LanguageLink")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Movies_Exam.Model.VisualContent", "VisualContent")
                        .WithMany("LanguageLink")
                        .HasForeignKey("VisualContentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Language");

                    b.Navigation("VisualContent");
                });

            modelBuilder.Entity("Movies_Exam.Model.VisualContentStaff", b =>
                {
                    b.HasOne("Movies_Exam.Model.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Movies_Exam.Model.Staff", null)
                        .WithMany("StaffLink")
                        .HasForeignKey("StaffId");

                    b.HasOne("Movies_Exam.Model.VisualContent", "VisualContent")
                        .WithMany("StaffLink")
                        .HasForeignKey("VisualContentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");

                    b.Navigation("VisualContent");
                });

            modelBuilder.Entity("Movies_Exam.Model.Genre", b =>
                {
                    b.Navigation("GenreLink");
                });

            modelBuilder.Entity("Movies_Exam.Model.Language", b =>
                {
                    b.Navigation("LanguageLink");
                });

            modelBuilder.Entity("Movies_Exam.Model.Stadistics", b =>
                {
                    b.Navigation("VisualContent");
                });

            modelBuilder.Entity("Movies_Exam.Model.Staff", b =>
                {
                    b.Navigation("RoleList");

                    b.Navigation("StaffLink");
                });

            modelBuilder.Entity("Movies_Exam.Model.TypeContent", b =>
                {
                    b.Navigation("VisualContent");
                });

            modelBuilder.Entity("Movies_Exam.Model.VisualContent", b =>
                {
                    b.Navigation("GenreLink");

                    b.Navigation("LanguageLink");

                    b.Navigation("StaffLink");
                });
#pragma warning restore 612, 618
        }
    }
}