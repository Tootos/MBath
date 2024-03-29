﻿// <auto-generated />
using System;
using MBath.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MBath.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<int?>("CategoriesId")
                        .HasColumnType("int");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<bool>("HasProducts")
                        .HasColumnType("bit");

                    b.Property<string>("ImgURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ParentId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Visible")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CategoriesId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Deleted = false,
                            HasProducts = false,
                            ImgURL = "\\Content\\Images\\Ύδρευση.jpg",
                            Name = "'Υδρευση",
                            ParentId = 0,
                            Url = "ydreusi",
                            Visible = true
                        },
                        new
                        {
                            Id = 2,
                            Deleted = false,
                            HasProducts = false,
                            ImgURL = "\\Content\\Images\\Αποχέτευση.jpg",
                            Name = "Αποχέτευση",
                            ParentId = 0,
                            Url = "apoxeteusi",
                            Visible = true
                        },
                        new
                        {
                            Id = 3,
                            Deleted = false,
                            HasProducts = false,
                            ImgURL = "\\Content\\Images\\Θερμοσίφωνα.jpg",
                            Name = "Θερμοσίφωνα",
                            ParentId = 0,
                            Url = "thermosifona",
                            Visible = true
                        },
                        new
                        {
                            Id = 4,
                            Deleted = false,
                            HasProducts = false,
                            ImgURL = "\\Content\\Images\\Μπάνιο.jpg",
                            Name = "Μπάνιο",
                            ParentId = 0,
                            Url = "mpanio",
                            Visible = true
                        },
                        new
                        {
                            Id = 5,
                            Deleted = false,
                            HasProducts = false,
                            ImgURL = "\\Content\\Images\\Κουζίνα.jpg",
                            Name = "Κουζίνα",
                            ParentId = 0,
                            Url = "kouzina",
                            Visible = true
                        },
                        new
                        {
                            Id = 100,
                            Deleted = false,
                            HasProducts = false,
                            ImgURL = "\\Content\\Images\\Ύδρευση\\Εξαρτήματα.jpg",
                            Name = "Εξαρτήματα",
                            ParentId = 1,
                            Url = "eksartimata",
                            Visible = true
                        },
                        new
                        {
                            Id = 101,
                            Deleted = false,
                            HasProducts = false,
                            ImgURL = "\\Content\\Images\\Ύδρευση\\Σωλήνες.jpg",
                            Name = "Σωλήνες",
                            ParentId = 1,
                            Url = "solines",
                            Visible = true
                        },
                        new
                        {
                            Id = 102,
                            Deleted = false,
                            HasProducts = false,
                            ImgURL = "\\Content\\Images\\Ύδρευση\\Διακόπτες_Κάνουλες.jpg",
                            Name = "Διακόπτες - Κάνουλες",
                            ParentId = 1,
                            Url = "diakoptes",
                            Visible = true
                        },
                        new
                        {
                            Id = 103,
                            Deleted = false,
                            HasProducts = false,
                            ImgURL = "\\Content\\Images\\Ύδρευση\\Στηρίγματα.jpg",
                            Name = "Στηρίγματα",
                            ParentId = 1,
                            Url = "stirigmata",
                            Visible = true
                        },
                        new
                        {
                            Id = 104,
                            Deleted = false,
                            HasProducts = false,
                            ImgURL = "\\Content\\Images\\Ύδρευση\\Στηρίγματα.jpg",
                            Name = "Συλλέκτες",
                            ParentId = 100,
                            Url = "syllektes",
                            Visible = true
                        },
                        new
                        {
                            Id = 100001,
                            Deleted = false,
                            HasProducts = true,
                            ImgURL = "\\Content\\Images\\Ύδρευση\\Εξαρτήματα\\Χάλκινα Εξαρτήματα.jpg",
                            Name = "Χάλκινα Εξαρτήματα",
                            ParentId = 100,
                            Url = "xalkina",
                            Visible = true
                        },
                        new
                        {
                            Id = 10002,
                            Deleted = false,
                            HasProducts = true,
                            ImgURL = "\\Content\\Images\\Ύδρευση\\Εξαρτήματα\\Ορειχάλκινα Εξαρτήματα.jpg",
                            Name = "Ορειχάλκινα Εξαρτήματα",
                            ParentId = 100,
                            Url = "orihalkina",
                            Visible = true
                        },
                        new
                        {
                            Id = 10003,
                            Deleted = false,
                            HasProducts = true,
                            ImgURL = "\\Content\\Images\\Ύδρευση\\Εξαρτήματα\\Σιδερένια εξαρτήματα.jpg",
                            Name = "Σιδερένια εξαρτήματα",
                            ParentId = 100,
                            Url = "siderenia",
                            Visible = true
                        },
                        new
                        {
                            Id = 100004,
                            Deleted = false,
                            HasProducts = false,
                            ImgURL = "\\Content\\Images\\Ύδρευση\\Εξαρτήματα\\Εξαρτήματα Πολυαιθυλενίου.jpg",
                            Name = "Εξαρτήματα Πολυαιθυλενίου",
                            ParentId = 100,
                            Url = "polyethileniou",
                            Visible = true
                        },
                        new
                        {
                            Id = 100005,
                            Deleted = false,
                            HasProducts = true,
                            ImgURL = "\\Content\\Images\\Ύδρευση\\Εξαρτήματα\\Εξαρτήματα Πολυπροπυλενίου.jpg",
                            Name = "Εξαρτήματα Πολυπροπυλενίου",
                            ParentId = 100,
                            Url = "polypropileniou",
                            Visible = true
                        },
                        new
                        {
                            Id = 100006,
                            Deleted = false,
                            HasProducts = true,
                            ImgURL = "\\Content\\Images\\Ύδρευση\\Εξαρτήματα\\Εξαρτήματα Πολυστρωματικής.jpg",
                            Name = "Εξαρτήματα Πολυστρωματικής",
                            ParentId = 100,
                            Url = "polystromatikis",
                            Visible = true
                        },
                        new
                        {
                            Id = 200,
                            Deleted = false,
                            HasProducts = false,
                            ImgURL = "",
                            Name = "Σωλήνες PVC",
                            ParentId = 2,
                            Url = "solinespvc",
                            Visible = true
                        },
                        new
                        {
                            Id = 201,
                            Deleted = false,
                            HasProducts = false,
                            ImgURL = "",
                            Name = "Σιφώνια αποχέτευσης",
                            ParentId = 2,
                            Url = "sifoniaapoxeteusis",
                            Visible = true
                        },
                        new
                        {
                            Id = 300,
                            Deleted = false,
                            HasProducts = false,
                            ImgURL = "",
                            Name = "Ηλεκτρομπόιλερ",
                            ParentId = 3,
                            Url = "hlectroboiler",
                            Visible = true
                        },
                        new
                        {
                            Id = 301,
                            Deleted = false,
                            HasProducts = false,
                            ImgURL = "",
                            Name = "Ηλεκτρικά Θερμοσίφωνα",
                            ParentId = 3,
                            Url = "elektrikathermosifona",
                            Visible = true
                        },
                        new
                        {
                            Id = 500,
                            Deleted = false,
                            HasProducts = true,
                            ImgURL = "\\Content\\Images\\Κουζίνα\\Ανοξείδωτοι Νεροχύτες.jpg",
                            Name = "Ανοξείδωτοι Νεροχύτες",
                            ParentId = 5,
                            Url = "anoksidotoi",
                            Visible = true
                        },
                        new
                        {
                            Id = 501,
                            Deleted = false,
                            HasProducts = false,
                            ImgURL = "\\Content\\Images\\Κουζίνα\\Νεροχύτες Συνθετικοί.jpg",
                            Name = "Νεροχύτες Συνθετικοί",
                            ParentId = 5,
                            Url = "synthetikoi",
                            Visible = true
                        },
                        new
                        {
                            Id = 502,
                            Deleted = false,
                            HasProducts = false,
                            ImgURL = "\\Content\\Images\\Κουζίνα\\Μπαταρίες.jpg",
                            Name = "Μπαταρίες",
                            ParentId = 5,
                            Url = "mpataries",
                            Visible = true
                        },
                        new
                        {
                            Id = 503,
                            Deleted = false,
                            HasProducts = false,
                            ImgURL = "\\Content\\Images\\Κουζίνα\\Απορροφητήρες.jpg",
                            Name = "Απορροφητήρες",
                            ParentId = 5,
                            Url = "aporrofitires",
                            Visible = true
                        },
                        new
                        {
                            Id = 504,
                            Deleted = false,
                            HasProducts = true,
                            ImgURL = "\\Content\\Images\\Κουζίνα\\Αξεσουάρ Κουζίνας ανταλλακτικά.jpg",
                            Name = "Αξεσουάρ Κουζίνας",
                            ParentId = 5,
                            Url = "aksesouar",
                            Visible = true
                        },
                        new
                        {
                            Id = 6,
                            Deleted = false,
                            HasProducts = false,
                            ImgURL = "",
                            Name = "Θέρμανση",
                            ParentId = 0,
                            Url = "thermansi",
                            Visible = true
                        });
                });

            modelBuilder.Entity("MBath.Shared.Models.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Images");
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

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Visible")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 500,
                            Deleted = false,
                            Description = "",
                            ImgURL = "\\Content\\Images\\Κουζίνα\\Ανοξείδωτοι Νεροχύτες\\Ανοξείδοτος νεροχύτης 86x50 VENEZIA 8310.jpg",
                            Name = "Ανοξείδοτος νεροχύτης 86x50 VENEZIA 8310",
                            Visible = true
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 500,
                            Deleted = false,
                            Description = "",
                            ImgURL = "\\Content\\Images\\Κουζίνα\\Ανοξείδωτοι Νεροχύτες\\Ανοξείδοτος νεροχύτης 100x50 VENEZIA 8312.jpg",
                            Name = "Ανοξείδοτος νεροχύτης 100x50 VENEZIA 8312",
                            Visible = true
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 500,
                            Deleted = false,
                            Description = "",
                            ImgURL = "\\Content\\Images\\Κουζίνα\\Ανοξείδωτοι Νεροχύτες\\Ανοξείδοτος νεροχύτης 116x50 VENEZIA 8316.jpg",
                            Name = "Ανοξείδοτος νεροχύτης 116x50 VENEZIA 8316",
                            Visible = true
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 500,
                            Deleted = false,
                            Description = "",
                            ImgURL = "\\Content\\Images\\Κουζίνα\\Ανοξείδωτοι Νεροχύτες\\Ανοξείδοτος νεροχύτης 86x50 VENEZIA 8320.jpg",
                            Name = "Ανοξείδοτος νεροχύτης 86x50 VENEZIA 8320",
                            Visible = true
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 500,
                            Deleted = false,
                            Description = "",
                            ImgURL = "\\Content\\Images\\Κουζίνα\\Ανοξείδωτοι Νεροχύτες\\Ανοξείδοτος νεροχύτης 86x50 VENEZIA 8330.jpg",
                            Name = "Ανοξείδοτος νεροχύτης 86x50 VENEZIA 8330",
                            Visible = true
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 500,
                            Deleted = false,
                            Description = "",
                            ImgURL = "\\Content\\Images\\Κουζίνα\\Ανοξείδωτοι Νεροχύτες\\Ανοξείδοτος νεροχύτης 79x50 VENEZIA 8380.jpg",
                            Name = "Ανοξείδοτος νεροχύτης 79x50 VENEZIA 8380",
                            Visible = true
                        });
                });

            modelBuilder.Entity("MBath.Shared.Models.ProductVariantInfo", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("VariantId")
                        .HasColumnType("int");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Visible")
                        .HasColumnType("bit");

                    b.HasKey("ProductId", "VariantId");

                    b.HasIndex("VariantId");

                    b.ToTable("ProductVariants");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            VariantId = 1,
                            Deleted = false,
                            Price = 145.00m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 1,
                            VariantId = 2,
                            Deleted = false,
                            Price = 160.00m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 2,
                            VariantId = 1,
                            Deleted = false,
                            Price = 145.00m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 3,
                            VariantId = 1,
                            Deleted = false,
                            Price = 160.00m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 3,
                            VariantId = 2,
                            Deleted = false,
                            Price = 175.00m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 4,
                            VariantId = 1,
                            Deleted = false,
                            Price = 170.00m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 4,
                            VariantId = 2,
                            Deleted = false,
                            Price = 185.00m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 5,
                            VariantId = 1,
                            Deleted = false,
                            Price = 155.00m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 5,
                            VariantId = 2,
                            Deleted = false,
                            Price = 165.00m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 6,
                            VariantId = 1,
                            Deleted = false,
                            Price = 155.00m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 6,
                            VariantId = 2,
                            Deleted = false,
                            Price = 165.00m,
                            Visible = true
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

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MBath.Shared.Models.Variant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Visible")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Variants");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Deleted = false,
                            Description = "",
                            Name = "Λεία επιφάνεια",
                            Visible = true
                        },
                        new
                        {
                            Id = 2,
                            Deleted = false,
                            Description = "",
                            Name = "Σαγρέ επιφάνεια",
                            Visible = true
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

            modelBuilder.Entity("MBath.Shared.Models.Category", b =>
                {
                    b.HasOne("MBath.Shared.Models.Category", "Categories")
                        .WithMany()
                        .HasForeignKey("CategoriesId");

                    b.Navigation("Categories");
                });

            modelBuilder.Entity("MBath.Shared.Models.Image", b =>
                {
                    b.HasOne("MBath.Shared.Models.Product", null)
                        .WithMany("Images")
                        .HasForeignKey("ProductId");
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

            modelBuilder.Entity("MBath.Shared.Models.ProductVariantInfo", b =>
                {
                    b.HasOne("MBath.Shared.Models.Product", "Product")
                        .WithMany("ProductVariants")
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
                    b.Navigation("Images");

                    b.Navigation("ProductVariants");
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
