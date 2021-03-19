﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

namespace Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200803124159_JAN")]
    partial class JAN
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Domain.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Detail")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Gerne")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("JAN")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Other")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Title")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Title = "First"
                        },
                        new
                        {
                            Id = 2,
                            Title = "Second"
                        },
                        new
                        {
                            Id = 3,
                            Title = "Third"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}