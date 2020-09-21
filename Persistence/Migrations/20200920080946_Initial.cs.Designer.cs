﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

namespace Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200920080946_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Domain.Book", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");





                b.Property<string>("JanCode1")
                    .HasColumnType("varchar(13) CHARACTER SET utf8mb4")
                    .HasMaxLength(13);

                b.Property<string>("JanCode2")
                    .HasColumnType("varchar(13) CHARACTER SET utf8mb4")
                    .HasMaxLength(13);

                b.Property<string>("IsbnCode")
                 .HasColumnType("varchar(15) CHARACTER SET utf8mb4")
                 .HasMaxLength(15);

                b.Property<string>("Title")
                    .HasColumnType("varchar(200) CHARACTER SET utf8mb4")
                    .HasMaxLength(200);

                b.Property<DateTime>("InsTime")
.HasColumnType("datetime(6)");
                b.Property<DateTime>("UpdTime")
                    .HasColumnType("datetime(6)");

                b.HasKey("Id");

                b.ToTable("Books");

                b.HasData(
                    new
                    {
                        Id = 1,
                        InsTime = new DateTime(2020, 9, 20, 17, 9, 45, 891, DateTimeKind.Local).AddTicks(4106),
                        IsbnCode = "987-4-12354-123",
                        JanCode1 = "1234567890123",
                        JanCode2 = "1234567890123",
                        Title = "テスト本１",
                        UpdTime = new DateTime(2020, 9, 20, 17, 9, 45, 892, DateTimeKind.Local).AddTicks(3275)
                    },
                    new
                    {
                        Id = 2,
                        InsTime = new DateTime(2020, 9, 20, 17, 9, 45, 892, DateTimeKind.Local).AddTicks(3649),
                        IsbnCode = "986-4-12354-123",
                        JanCode1 = "2345678901234",
                        JanCode2 = "2345678901234",
                        Title = "テスト本２",
                        UpdTime = new DateTime(2020, 9, 20, 17, 9, 45, 892, DateTimeKind.Local).AddTicks(3661)
                    });
            });

            modelBuilder.Entity("Domain.OwnedBookInfo", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                b.Property<int>("BookId")
                    .HasColumnType("int");
                b.Property<int>("UserId")
                    .HasColumnType("int");

                b.Property<DateTime>("InsTime")
                      .HasColumnType("datetime(6)");

                b.Property<DateTime>("UpdTime")
                    .HasColumnType("datetime(6)");

                b.HasKey("Id");

                b.HasIndex("BookId");

                b.HasIndex("UserId");

                b.ToTable("OwnedBookInfos");

                b.HasData(
                    new
                    {
                        Id = 1,
                        BookId = 1,
                        InsTime = new DateTime(2020, 9, 20, 17, 9, 45, 893, DateTimeKind.Local).AddTicks(7171),
                        UpdTime = new DateTime(2020, 9, 20, 17, 9, 45, 893, DateTimeKind.Local).AddTicks(7433),
                        UserId = 1
                    });
            });

            modelBuilder.Entity("Domain.User", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                b.Property<string>("FirstName")
                    .HasColumnType("longtext CHARACTER SET utf8mb4");

                b.Property<string>("LastName")
                    .HasColumnType("longtext CHARACTER SET utf8mb4");
                b.Property<string>("UserName")
                    .IsRequired()
                    .HasColumnType("longtext CHARACTER SET utf8mb4");

                b.Property<string>("UserPass")
                    .IsRequired()
                    .HasColumnType("longtext CHARACTER SET utf8mb4");

                b.Property<DateTime?>("LastLoggedIn")
                    .HasColumnType("datetime(6)");
                b.Property<DateTime>("InsTime")
                    .HasColumnType("datetime(6)");

                b.Property<DateTime>("UpdTime")
                    .HasColumnType("datetime(6)");

                b.HasKey("Id");

                b.ToTable("Users");

                b.HasData(
                    new
                    {
                        Id = 1,
                        FirstName = "たくや",
                        InsTime = new DateTime(2020, 9, 20, 17, 9, 45, 893, DateTimeKind.Local).AddTicks(5317),
                        LastName = "たなか",
                        UpdTime = new DateTime(2020, 9, 20, 17, 9, 45, 893, DateTimeKind.Local).AddTicks(5627),
                        UserName = "TAKUYA",
                        UserPass = "TEST"
                    },
                    new
                    {
                        Id = 2,
                        FirstName = "ころ",
                        InsTime = new DateTime(2020, 9, 20, 17, 9, 45, 893, DateTimeKind.Local).AddTicks(5935),
                        LastName = "ころ",
                        UpdTime = new DateTime(2020, 9, 20, 17, 9, 45, 893, DateTimeKind.Local).AddTicks(5943),
                        UserName = "koro",
                        UserPass = "koro"
                    });
            });

            modelBuilder.Entity("Domain.OwnedBookInfo", b =>
            {
                b.HasOne("Domain.Book", "Book")
                    .WithMany("OwnedBooks")
                    .HasForeignKey("BookId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("Domain.User", "User")
                    .WithMany()
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });
#pragma warning restore 612, 618
        }
    }
}