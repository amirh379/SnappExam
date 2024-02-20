﻿// <auto-generated />
using System;
using Infrastructure.Persistence.Ef;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace SnappExam.Infrastructure.Persistence.EF.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SnappExam.Core.Domain.Models.Orders.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BuyerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("InsertionTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModificationTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BuyerId");

                    b.HasIndex("ProductId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("SnappExam.Core.Domain.Models.Products.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Discount")
                        .HasColumnType("int");

                    b.Property<DateTime>("InsertionTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("InventoryCount")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModificationTime")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,1)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("Id");

                    b.HasIndex("Title")
                        .IsUnique();

                    b.ToTable("Products");
                });

            modelBuilder.Entity("SnappExam.Core.Domain.Models.Users.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("InsertionTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModificationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            InsertionTime = new DateTime(1956, 12, 2, 18, 29, 13, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            IsDelete = false,
                            ModificationTime = new DateTime(2024, 2, 20, 17, 33, 36, 83, DateTimeKind.Local).AddTicks(6017),
                            Name = "case"
                        },
                        new
                        {
                            Id = 2,
                            InsertionTime = new DateTime(1957, 10, 8, 16, 36, 9, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            IsDelete = true,
                            ModificationTime = new DateTime(2024, 2, 20, 17, 33, 36, 83, DateTimeKind.Local).AddTicks(6731),
                            Name = "ennui"
                        },
                        new
                        {
                            Id = 3,
                            InsertionTime = new DateTime(1937, 4, 16, 16, 10, 19, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            IsDelete = false,
                            ModificationTime = new DateTime(2024, 2, 20, 17, 33, 36, 83, DateTimeKind.Local).AddTicks(7150),
                            Name = "future"
                        },
                        new
                        {
                            Id = 4,
                            InsertionTime = new DateTime(2015, 6, 15, 15, 24, 58, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            IsDelete = true,
                            ModificationTime = new DateTime(2024, 2, 20, 17, 33, 36, 83, DateTimeKind.Local).AddTicks(7601),
                            Name = "Gluten-free"
                        },
                        new
                        {
                            Id = 5,
                            InsertionTime = new DateTime(1941, 1, 28, 7, 43, 27, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            IsDelete = true,
                            ModificationTime = new DateTime(2024, 2, 20, 17, 33, 36, 83, DateTimeKind.Local).AddTicks(8032),
                            Name = "Vinyl"
                        },
                        new
                        {
                            Id = 6,
                            InsertionTime = new DateTime(1904, 2, 13, 18, 37, 40, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            IsDelete = false,
                            ModificationTime = new DateTime(2024, 2, 20, 17, 33, 36, 83, DateTimeKind.Local).AddTicks(8484),
                            Name = "gentrify"
                        },
                        new
                        {
                            Id = 7,
                            InsertionTime = new DateTime(2003, 12, 1, 20, 32, 28, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            IsDelete = true,
                            ModificationTime = new DateTime(2024, 2, 20, 17, 33, 36, 83, DateTimeKind.Local).AddTicks(8920),
                            Name = "haven't"
                        },
                        new
                        {
                            Id = 8,
                            InsertionTime = new DateTime(1956, 4, 3, 19, 33, 6, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            IsDelete = false,
                            ModificationTime = new DateTime(2024, 2, 20, 17, 33, 36, 83, DateTimeKind.Local).AddTicks(9347),
                            Name = "Gluten-free"
                        },
                        new
                        {
                            Id = 9,
                            InsertionTime = new DateTime(1945, 12, 17, 16, 30, 48, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            IsDelete = false,
                            ModificationTime = new DateTime(2024, 2, 20, 17, 33, 36, 83, DateTimeKind.Local).AddTicks(9774),
                            Name = "american"
                        },
                        new
                        {
                            Id = 10,
                            InsertionTime = new DateTime(1901, 10, 4, 18, 19, 59, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            IsDelete = false,
                            ModificationTime = new DateTime(2024, 2, 20, 17, 33, 36, 84, DateTimeKind.Local).AddTicks(171),
                            Name = "rights"
                        });
                });

            modelBuilder.Entity("SnappExam.Core.Domain.Models.Orders.Order", b =>
                {
                    b.HasOne("SnappExam.Core.Domain.Models.Users.User", "Buyer")
                        .WithMany("Orders")
                        .HasForeignKey("BuyerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SnappExam.Core.Domain.Models.Products.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Buyer");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("SnappExam.Core.Domain.Models.Users.User", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
