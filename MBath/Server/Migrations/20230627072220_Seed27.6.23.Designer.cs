﻿// <auto-generated />
using System;
using MBath.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MBath.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230627072220_Seed27.6.23")]
    partial class Seed27623
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MBath.Shared.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("MBath.Shared.Models.CartItem", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("VariantId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("UserId", "ProductId", "VariantId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("MBath.Shared.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ImgURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ParentId")
                        .HasColumnType("int");

                    b.Property<string>("URL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ImgURL = "\\Content\\Images\\Ύδρευση.jpg",
                            Name = "'Υδρευση",
                            ParentId = 0,
                            URL = "ydreusi"
                        },
                        new
                        {
                            Id = 2,
                            ImgURL = "\\Content\\Images\\Αποχέτευση.jpg",
                            Name = "Αποχέτευση",
                            ParentId = 0,
                            URL = "apoxeteusi"
                        },
                        new
                        {
                            Id = 3,
                            ImgURL = "\\Content\\Images\\Θερμοσίφωνα.jpg",
                            Name = "Θερμοσίφωνα",
                            ParentId = 0,
                            URL = "thermosifona"
                        },
                        new
                        {
                            Id = 4,
                            ImgURL = "\\Content\\Images\\Μπάνιο.jpg",
                            Name = "Μπάνιο",
                            ParentId = 0,
                            URL = "mpanio"
                        },
                        new
                        {
                            Id = 5,
                            ImgURL = "\\Content\\Images\\Κουζίνα.jpg",
                            Name = "Κουζίνα",
                            ParentId = 0,
                            URL = "kouzina"
                        },
                        new
                        {
                            Id = 100,
                            ImgURL = "\\Content\\Images\\Ύδρευση\\Εξαρτήματα.jpg",
                            Name = "Εξαρτήματα",
                            ParentId = 1,
                            URL = "eksartimata"
                        },
                        new
                        {
                            Id = 101,
                            ImgURL = "\\Content\\Images\\Ύδρευση\\Σωλήνες.jpg",
                            Name = "Σωλήνες",
                            ParentId = 1,
                            URL = "solines"
                        },
                        new
                        {
                            Id = 102,
                            ImgURL = "\\Content\\Images\\Ύδρευση\\Διακόπτες_Κάνουλες.jpg",
                            Name = "Διακόπτες - Κάνουλες",
                            ParentId = 1,
                            URL = "diakoptes"
                        },
                        new
                        {
                            Id = 103,
                            ImgURL = "\\Content\\Images\\Ύδρευση\\Στηρίγματα.jpg",
                            Name = "Στηρίγματα",
                            ParentId = 1,
                            URL = "stirigmata"
                        },
                        new
                        {
                            Id = 104,
                            ImgURL = "\\Content\\Images\\Ύδρευση\\Στηρίγματα.jpg",
                            Name = "Συλλέκτες",
                            ParentId = 100,
                            URL = "syllektes"
                        },
                        new
                        {
                            Id = 100001,
                            ImgURL = "\\Content\\Images\\Ύδρευση\\Εξαρτήματα\\Χάλκινα Εξαρτήματα.jpg",
                            Name = "Χάλκινα Εξαρτήματα",
                            ParentId = 100,
                            URL = "xalkina"
                        },
                        new
                        {
                            Id = 10002,
                            ImgURL = "\\Content\\Images\\Ύδρευση\\Εξαρτήματα\\Ορειχάλκινα Εξαρτήματα.jpg",
                            Name = "Ορειχάλκινα Εξαρτήματα",
                            ParentId = 100,
                            URL = "orihalkina"
                        },
                        new
                        {
                            Id = 10003,
                            ImgURL = "\\Content\\Images\\Ύδρευση\\Εξαρτήματα\\Σιδερένια εξαρτήματα.jpg",
                            Name = "Σιδερένια εξαρτήματα",
                            ParentId = 100,
                            URL = "siderenia"
                        },
                        new
                        {
                            Id = 100004,
                            ImgURL = "\\Content\\Images\\Ύδρευση\\Εξαρτήματα\\Εξαρτήματα Πολυαιθυλενίου.jpg",
                            Name = "Εξαρτήματα Πολυαιθυλενίου",
                            ParentId = 100,
                            URL = "polyethileniou"
                        },
                        new
                        {
                            Id = 100005,
                            ImgURL = "\\Content\\Images\\Ύδρευση\\Εξαρτήματα\\Εξαρτήματα Πολυπροπυλενίου.jpg",
                            Name = "Εξαρτήματα Πολυπροπυλενίου",
                            ParentId = 100,
                            URL = "polypropileniou"
                        },
                        new
                        {
                            Id = 100006,
                            ImgURL = "\\Content\\Images\\Ύδρευση\\Εξαρτήματα\\Εξαρτήματα Πολυστρωματικής.jpg",
                            Name = "Εξαρτήματα Πολυστρωματικής",
                            ParentId = 100,
                            URL = "polystromatikis"
                        },
                        new
                        {
                            Id = 200,
                            ImgURL = "http://www.m-bath.gr/wp-content/uploads/2014/06/types-of-plumbing-pipes.jpg",
                            Name = "Σωλήνες PVC",
                            ParentId = 2,
                            URL = "solinespvc"
                        },
                        new
                        {
                            Id = 201,
                            ImgURL = "http://www.m-bath.gr/wp-content/uploads/2014/06/types-of-plumbing-pipes.jpg",
                            Name = "Σιφώνια αποχέτευσης",
                            ParentId = 2,
                            URL = "sifoniaapoxeteusis"
                        },
                        new
                        {
                            Id = 300,
                            ImgURL = "http://www.m-bath.gr/wp-content/uploads/2014/06/types-of-plumbing-pipes.jpg",
                            Name = "Ηλεκτρομπόιλερ",
                            ParentId = 3,
                            URL = "hlectroboiler"
                        },
                        new
                        {
                            Id = 301,
                            ImgURL = "http://www.m-bath.gr/wp-content/uploads/2014/06/types-of-plumbing-pipes.jpg",
                            Name = "Ηλεκτρικά Θερμοσίφωνα",
                            ParentId = 3,
                            URL = "elektrikathermosifona"
                        },
                        new
                        {
                            Id = 500,
                            ImgURL = "\\Content\\Images\\Κουζίνα\\Ανοξείδωτοι Νεροχύτες.jpg",
                            Name = "Ανοξείδωτοι Νεροχύτες",
                            ParentId = 5,
                            URL = "anoksidotoi"
                        },
                        new
                        {
                            Id = 501,
                            ImgURL = "\\Content\\Images\\Κουζίνα\\Νεροχύτες Συνθετικοί.jpg",
                            Name = "Νεροχύτες Συνθετικοί",
                            ParentId = 5,
                            URL = "synthetikoi"
                        },
                        new
                        {
                            Id = 502,
                            ImgURL = "\\Content\\Images\\Κουζίνα\\Μπαταρίες.jpg",
                            Name = "Μπαταρίες",
                            ParentId = 5,
                            URL = "mpataries"
                        },
                        new
                        {
                            Id = 503,
                            ImgURL = "\\Content\\Images\\Κουζίνα\\Απορροφητήρες.jpg",
                            Name = "Απορροφητήρες",
                            ParentId = 5,
                            URL = "aporrofitires"
                        },
                        new
                        {
                            Id = 504,
                            ImgURL = "\\Content\\Images\\Κουζίνα\\Αξεσουάρ Κουζίνας ανταλλακτικά.jpg",
                            Name = "Αξεσουάρ Κουζίνας",
                            ParentId = 5,
                            URL = "aksesouar"
                        },
                        new
                        {
                            Id = 6,
                            ImgURL = "",
                            Name = "Θέρμανση",
                            ParentId = 0,
                            URL = "thermansi"
                        });
                });

            modelBuilder.Entity("MBath.Shared.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("MBath.Shared.Models.OrderItem", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("VariantId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderId", "VariantId", "ProductId");

                    b.HasIndex("ProductId");

                    b.HasIndex("VariantId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("MBath.Shared.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 500,
                            Description = "",
                            ImgURL = "\\Content\\Images\\Κουζίνα\\Ανοξείδωτοι Νεροχύτες\\Ανοξείδοτος νεροχύτης 86x50 VENEZIA 8310.jpg",
                            Name = "Ανοξείδοτος νεροχύτης 86x50 VENEZIA 8310"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 500,
                            Description = "",
                            ImgURL = "\\Content\\Images\\Κουζίνα\\Ανοξείδωτοι Νεροχύτες\\Ανοξείδοτος νεροχύτης 100x50 VENEZIA 8312.jpg",
                            Name = "Ανοξείδοτος νεροχύτης 100x50 VENEZIA 8312"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 500,
                            Description = "",
                            ImgURL = "\\Content\\Images\\Κουζίνα\\Ανοξείδωτοι Νεροχύτες\\Ανοξείδοτος νεροχύτης 116x50 VENEZIA 8316.jpg",
                            Name = "Ανοξείδοτος νεροχύτης 116x50 VENEZIA 8316"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 500,
                            Description = "",
                            ImgURL = "\\Content\\Images\\Κουζίνα\\Ανοξείδωτοι Νεροχύτες\\Ανοξείδοτος νεροχύτης 86x50 VENEZIA 8320.jpg",
                            Name = "Ανοξείδοτος νεροχύτης 86x50 VENEZIA 8320"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 500,
                            Description = "",
                            ImgURL = "\\Content\\Images\\Κουζίνα\\Ανοξείδωτοι Νεροχύτες\\Ανοξείδοτος νεροχύτης 86x50 VENEZIA 8330.jpg",
                            Name = "Ανοξείδοτος νεροχύτης 86x50 VENEZIA 8330"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 500,
                            Description = "",
                            ImgURL = "\\Content\\Images\\Κουζίνα\\Ανοξείδωτοι Νεροχύτες\\Ανοξείδοτος νεροχύτης 79x50 VENEZIA 8380.jpg",
                            Name = "Ανοξείδοτος νεροχύτης 79x50 VENEZIA 8380"
                        });
                });

            modelBuilder.Entity("MBath.Shared.Models.ProductVariant", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("VariantId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductId", "VariantId");

                    b.HasIndex("VariantId");

                    b.ToTable("ProductVariants");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            VariantId = 1,
                            Price = 145.00m
                        },
                        new
                        {
                            ProductId = 1,
                            VariantId = 2,
                            Price = 160.00m
                        },
                        new
                        {
                            ProductId = 2,
                            VariantId = 1,
                            Price = 145.00m
                        },
                        new
                        {
                            ProductId = 3,
                            VariantId = 1,
                            Price = 160.00m
                        },
                        new
                        {
                            ProductId = 3,
                            VariantId = 2,
                            Price = 175.00m
                        },
                        new
                        {
                            ProductId = 4,
                            VariantId = 1,
                            Price = 170.00m
                        },
                        new
                        {
                            ProductId = 4,
                            VariantId = 2,
                            Price = 185.00m
                        },
                        new
                        {
                            ProductId = 5,
                            VariantId = 1,
                            Price = 155.00m
                        },
                        new
                        {
                            ProductId = 5,
                            VariantId = 2,
                            Price = 165.00m
                        },
                        new
                        {
                            ProductId = 6,
                            VariantId = 1,
                            Price = 155.00m
                        },
                        new
                        {
                            ProductId = 6,
                            VariantId = 2,
                            Price = 165.00m
                        });
                });

            modelBuilder.Entity("MBath.Shared.Models.UserModels.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MBath.Shared.Models.Variant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Variants");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "",
                            Name = "Λεία επιφάνεια"
                        },
                        new
                        {
                            Id = 2,
                            Description = "",
                            Name = "Σαγρέ επιφάνεια"
                        });
                });

            modelBuilder.Entity("MBath.Shared.Models.Address", b =>
                {
                    b.HasOne("MBath.Shared.Models.UserModels.User", null)
                        .WithOne("Address")
                        .HasForeignKey("MBath.Shared.Models.Address", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MBath.Shared.Models.OrderItem", b =>
                {
                    b.HasOne("MBath.Shared.Models.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MBath.Shared.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MBath.Shared.Models.Variant", "Variant")
                        .WithMany()
                        .HasForeignKey("VariantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");

                    b.Navigation("Variant");
                });

            modelBuilder.Entity("MBath.Shared.Models.Product", b =>
                {
                    b.HasOne("MBath.Shared.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("MBath.Shared.Models.ProductVariant", b =>
                {
                    b.HasOne("MBath.Shared.Models.Product", "Product")
                        .WithMany("ProductVariant")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MBath.Shared.Models.Variant", "Variant")
                        .WithMany()
                        .HasForeignKey("VariantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Variant");
                });

            modelBuilder.Entity("MBath.Shared.Models.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("MBath.Shared.Models.Product", b =>
                {
                    b.Navigation("ProductVariant");
                });

            modelBuilder.Entity("MBath.Shared.Models.UserModels.User", b =>
                {
                    b.Navigation("Address")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
