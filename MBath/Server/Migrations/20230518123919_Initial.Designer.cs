﻿// <auto-generated />
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
    [Migration("20230518123919_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MBath.Shared.Category", b =>
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
                            Id = 100,
                            ImgURL = "http://www.m-bath.gr/wp-content/uploads/2014/06/types-of-plumbing-pipes.jpg",
                            Name = "Εξαρτήματα",
                            ParentId = 1,
                            URL = "eksartimata"
                        },
                        new
                        {
                            Id = 101,
                            ImgURL = "http://www.m-bath.gr/wp-content/uploads/2014/06/types-of-plumbing-pipes.jpg",
                            Name = "Σωλήνες",
                            ParentId = 1,
                            URL = "solines"
                        },
                        new
                        {
                            Id = 102,
                            ImgURL = "http://www.m-bath.gr/wp-content/uploads/2014/06/types-of-plumbing-pipes.jpg",
                            Name = "Διακόπτες",
                            ParentId = 1,
                            URL = "diakoptes"
                        },
                        new
                        {
                            Id = 2,
                            ImgURL = "http://www.m-bath.gr/wp-content/uploads/2014/04/unisolsifoni.jpg",
                            Name = "Αποχέτευση",
                            ParentId = 0,
                            URL = "apoxeteusi"
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
                            Id = 3,
                            ImgURL = "http://www.m-bath.gr/wp-content/uploads/2014/04/unisolsifoni.jpg",
                            Name = "Θερμοσίφωνα",
                            ParentId = 0,
                            URL = "thermosifona"
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
                            Id = 4,
                            ImgURL = "http://www.m-bath.gr/wp-content/uploads/2014/04/unisolsifoni.jpg",
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
                            ImgURL = "\\Content\\Images\\Κουζίνα\\Αξεσουάρ Κουζίνας.jpg",
                            Name = "Αξεσουάρ Κουζίνας",
                            ParentId = 5,
                            URL = "aksesouar"
                        });
                });

            modelBuilder.Entity("MBath.Shared.Product", b =>
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
                });

            modelBuilder.Entity("MBath.Shared.Product", b =>
                {
                    b.HasOne("MBath.Shared.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
