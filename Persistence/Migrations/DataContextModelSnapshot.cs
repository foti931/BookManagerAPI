﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

namespace Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<DateTime>("InsTime")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsRental")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("JAN")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Other")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Title")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("UpdTime")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            InsTime = new DateTime(2020, 8, 9, 17, 14, 18, 179, DateTimeKind.Local).AddTicks(2161),
                            IsRental = false,
                            JAN = "1",
                            Title = "First",
                            UpdTime = new DateTime(2020, 8, 9, 17, 14, 18, 180, DateTimeKind.Local).AddTicks(4589)
                        },
                        new
                        {
                            Id = 2,
                            InsTime = new DateTime(2020, 8, 9, 17, 14, 18, 180, DateTimeKind.Local).AddTicks(5277),
                            IsRental = false,
                            JAN = "2",
                            Title = "Second",
                            UpdTime = new DateTime(2020, 8, 9, 17, 14, 18, 180, DateTimeKind.Local).AddTicks(5291)
                        },
                        new
                        {
                            Id = 3,
                            InsTime = new DateTime(2020, 8, 9, 17, 14, 18, 180, DateTimeKind.Local).AddTicks(5325),
                            IsRental = false,
                            JAN = "3",
                            Title = "Third",
                            UpdTime = new DateTime(2020, 8, 9, 17, 14, 18, 180, DateTimeKind.Local).AddTicks(5326)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
