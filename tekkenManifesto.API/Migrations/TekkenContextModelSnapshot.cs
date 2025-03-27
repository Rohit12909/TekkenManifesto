﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using tekkenManifesto.API.Data;

#nullable disable

namespace tekkenManifesto.API.Migrations
{
    [DbContext(typeof(TekkenContext))]
    partial class TekkenContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("tekkenManifesto.API.Model.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FightingStyle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HighestRank")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("History")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Origin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Played")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Chars");
                });

            modelBuilder.Entity("tekkenManifesto.API.Model.Combo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CharacterId")
                        .HasColumnType("int");

                    b.Property<int>("Damage")
                        .HasColumnType("int");

                    b.Property<string>("TextNotation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VisualNotationURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.ToTable("Combos");
                });

            modelBuilder.Entity("tekkenManifesto.API.Model.HeatEngager", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CharacterId")
                        .HasColumnType("int");

                    b.Property<string>("FramesOB")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Input")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.ToTable("HeatEngager");
                });

            modelBuilder.Entity("tekkenManifesto.API.Model.Launcher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CharacterId")
                        .HasColumnType("int");

                    b.Property<string>("FramesOB")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Input")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.ToTable("Launcher");
                });

            modelBuilder.Entity("tekkenManifesto.API.Model.Punisher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CharacterId")
                        .HasColumnType("int");

                    b.Property<string>("EnemyIs")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Input")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.ToTable("Punisher");
                });

            modelBuilder.Entity("tekkenManifesto.API.Model.Stance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CharacterId")
                        .HasColumnType("int");

                    b.Property<string>("Input")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.ToTable("Stance");
                });

            modelBuilder.Entity("tekkenManifesto.API.Model.Combo", b =>
                {
                    b.HasOne("tekkenManifesto.API.Model.Character", null)
                        .WithMany("Combos")
                        .HasForeignKey("CharacterId");
                });

            modelBuilder.Entity("tekkenManifesto.API.Model.HeatEngager", b =>
                {
                    b.HasOne("tekkenManifesto.API.Model.Character", null)
                        .WithMany("HeatEngagers")
                        .HasForeignKey("CharacterId");
                });

            modelBuilder.Entity("tekkenManifesto.API.Model.Launcher", b =>
                {
                    b.HasOne("tekkenManifesto.API.Model.Character", null)
                        .WithMany("Launchers")
                        .HasForeignKey("CharacterId");
                });

            modelBuilder.Entity("tekkenManifesto.API.Model.Punisher", b =>
                {
                    b.HasOne("tekkenManifesto.API.Model.Character", null)
                        .WithMany("Punishers")
                        .HasForeignKey("CharacterId");
                });

            modelBuilder.Entity("tekkenManifesto.API.Model.Stance", b =>
                {
                    b.HasOne("tekkenManifesto.API.Model.Character", null)
                        .WithMany("Stances")
                        .HasForeignKey("CharacterId");
                });

            modelBuilder.Entity("tekkenManifesto.API.Model.Character", b =>
                {
                    b.Navigation("Combos");

                    b.Navigation("HeatEngagers");

                    b.Navigation("Launchers");

                    b.Navigation("Punishers");

                    b.Navigation("Stances");
                });
#pragma warning restore 612, 618
        }
    }
}
