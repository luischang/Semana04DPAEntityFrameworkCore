﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Semana04DPAConsole.CodeFirst.Models;

#nullable disable

namespace Semana04DPAConsole.CodeFirst.Migrations
{
    [DbContext(typeof(FPFDbContext))]
    [Migration("20220424190522_New table Team v2")]
    partial class NewtableTeamv2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Semana04DPAConsole.CodeFirst.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Dorsal")
                        .HasColumnType("int");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Player");
                });

            modelBuilder.Entity("Semana04DPAConsole.CodeFirst.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Team");
                });
#pragma warning restore 612, 618
        }
    }
}