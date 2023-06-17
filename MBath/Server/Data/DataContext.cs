using MBath.Shared.Models;
using MBath.Shared.Models.UserModels;

namespace MBath.Server.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options) { }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Variant> Variants { get; set; }

        public DbSet<User> Users { get; set; }

      
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Variant>().HasData(
                new Variant
                {
                    Id = 1,
                    ProductId = 1,
                    Name = "Λεία επιφάνεια",
                    Price = 145.00m
                },
                new Variant
                {
                    Id = 2,
                    ProductId = 1,
                    Name = "Σαγρέ επιφάνεια",
                    Price = 160.00m
                },
                new Variant
                {
                    Id = 3,
                    ProductId = 2,
                    Name = "Λεία επιφάνεια",
                    Price = 285.00m
                },
                new Variant
                {
                    Id = 4,
                    ProductId = 3,
                    Name = "Λεία επιφάνεια",
                    Price = 160.00m
                },
                new Variant
                {
                    Id = 5,
                    ProductId = 3,
                    Name = "Σαγρέ επιφάνεια",
                    Price = 175.00m
                },
                new Variant
                {
                    Id = 6,
                    ProductId = 4,
                    Name = "Λεία επιφάνεια",
                    Price = 170.00m
                },
                new Variant
                {
                    Id = 7,
                    ProductId = 4,
                    Name = "Λεία επιφάνεια",
                    Price = 185.00m
                },

                new Variant
                {
                    Id = 8,
                    ProductId = 5,
                    Name = "Λεία επιφάνεια",
                    Price = 155.00m
                },
                new Variant
                {
                    Id = 9,
                    ProductId = 5,
                    Name = "Σαγρέ επιφάνεια",
                    Price = 165.00m
                },
                new Variant
                {
                    Id = 10,
                    ProductId = 4,
                    Name = "Λεία επιφάνεια",
                    Price = 170.00m
                },
                new Variant
                {
                    Id = 11,
                    ProductId = 4,
                    Name = "Λεία επιφάνεια",
                    Price = 185.00m
                },

                 new Variant
                 {
                     Id = 12,
                     ProductId = 5,
                     Name = "Λεία επιφάνεια",
                     Price = 155.00m
                 },
                new Variant
                {
                    Id = 13,
                    ProductId = 5,
                    Name = "Σαγρέ επιφάνεια",
                    Price = 165.00m
                },
                new Variant
                {
                    Id = 14,
                    ProductId = 6,
                    Name = "Λεία επιφάνεια",
                    Price = 155.00m
                },
                new Variant
                {
                    Id = 15,
                    ProductId = 6,
                    Name = "Σαγρέ επιφάνεια",
                    Price = 165.00m
                },

                new Variant
                {
                    Id = 16,
                    ProductId = 7,
                    Name = "Λεία επιφάνεια",
                    Price = 75.00m
                },


                new Variant
                {
                    Id = 17,
                    ProductId = 8,
                    Name = "Λεία επιφάνεια",
                    Price = 100.00m
                },
                new Variant
                {
                    Id = 18,
                    ProductId = 8,
                    Name = "Σαγρέ επιφάνεια",
                    Price = 109.00m
                },
                new Variant
                {
                    Id = 19,
                    ProductId = 9,
                    Name = "Λεία επιφάνεια",
                    Price = 125.00m
                },
                new Variant
                {
                    Id = 20,
                    ProductId = 9,
                    Name = "Σαγρέ επιφάνεια",
                    Price = 145.00m
                },
                new Variant
                {
                    Id = 21,
                    ProductId = 10,
                    Name = "Λεία επιφάνεια",
                    Price = 50.00m
                },
                new Variant
                {
                    Id = 22,
                    ProductId = 11,
                    Name = "Λεία επιφάνεια",
                    Price = 50.00m
                },
                new Variant
                {
                    Id = 23,
                    ProductId = 12,
                    Name = "Λεία επιφάνεια",
                    Price = 60.00m
                },
                new Variant
                {
                    Id = 24,
                    ProductId = 13,
                    Name = "Λεία επιφάνεια",
                    Price = 72.00m
                },
                new Variant
                {
                    Id = 25,
                    ProductId = 14,
                    Name = "Λεία επιφάνεια",
                    Price = 70.00m
                },
                new Variant
                {
                    Id = 26,
                    ProductId = 15,
                    Name = "Λεία επιφάνεια",
                    Price = 80.00m
                },
                new Variant
                {
                    Id = 27,
                    ProductId = 15,
                    Name = "Σαγρέ επιφάνεια",
                    Price = 91.00m
                },
                new Variant
                {
                    Id = 28,
                    ProductId = 16,
                    Name = "Λεία επιφάνεια",
                    Price = 90.00m
                },
                new Variant
                {
                    Id = 29,
                    ProductId = 16,
                    Name = "Σαγρε επιφάνεια",
                    Price = 110.00m
                },
                new Variant
                {
                    Id = 30,
                    ProductId = 17,
                    Name = "Λεία επιφάνεια",
                    Price = 113.00m
                }
                ) ;
                
            modelBuilder.Entity<Product>().HasData(

                new Product
                {
                    Id = 1,
                    Name= "Ανοξείδοτος νεροχύτης 86x50 VENEZIA 8310",
                    CategoryId=500,
                    ImgURL= "\\Content\\Images\\Κουζίνα\\Ανοξείδωτοι Νεροχύτες\\Ανοξείδοτος νεροχύτης 86x50 VENEZIA 8310.jpg"

                },
                new Product
                {
                    Id = 2,
                    Name = "Ανοξείδοτος νεροχύτης 100x50 VENEZIA 8312",
                    CategoryId = 500,
                    ImgURL = "\\Content\\Images\\Κουζίνα\\Ανοξείδωτοι Νεροχύτες\\Ανοξείδοτος νεροχύτης 100x50 VENEZIA 8312.jpg"

                },
                new Product
                {
                    Id = 3,
                    Name = "Ανοξείδοτος νεροχύτης 116x50 VENEZIA 8316",
                    CategoryId = 500,
                    ImgURL = "\\Content\\Images\\Κουζίνα\\Ανοξείδωτοι Νεροχύτες\\Ανοξείδοτος νεροχύτης 116x50 VENEZIA 8316.jpg"

                },

                new Product
                {
                    Id =4,
                    Name = "Ανοξείδοτος νεροχύτης 86x50 VENEZIA 8320",
                    CategoryId = 500,
                    ImgURL = "\\Content\\Images\\Κουζίνα\\Ανοξείδωτοι Νεροχύτες\\Ανοξείδοτος νεροχύτης 86x50 VENEZIA 8320.jpg"

                },
                new Product
                {
                    Id =5,
                    Name = "Ανοξείδοτος νεροχύτης 86x50 VENEZIA 8330",
                    CategoryId = 500,
                    ImgURL = "\\Content\\Images\\Κουζίνα\\Ανοξείδωτοι Νεροχύτες\\Ανοξείδοτος νεροχύτης 86x50 VENEZIA 8330.jpg"

                },
                new Product
                {
                    Id = 6,
                    Name = "Ανοξείδοτος νεροχύτης 79x50 VENEZIA 8380",
                    CategoryId = 500,
                    ImgURL = "\\Content\\Images\\Κουζίνα\\Ανοξείδωτοι Νεροχύτες\\Ανοξείδοτος νεροχύτης 79x50 VENEZIA 8380.jpg"

                },

                new Product
                {
                    Id = 7,
                    Name = "Ανοξείδοτος νεροχύτης 78,5x44,5 SLENDER 24200",
                    CategoryId = 500,
                    ImgURL = "\\Content\\Images\\Κουζίνα\\Ανοξείδωτοι Νεροχύτες\\Ανοξείδοτος νεροχύτης 78,5x44,5 SLENDER 24200.jpg"

                },
                new Product
                {
                    Id = 8,
                    Name = "Ανοξείδοτος νεροχύτης 60x50 ARENA 22060",
                    CategoryId = 500,
                    ImgURL = "\\Content\\Images\\Κουζίνα\\Ανοξείδωτοι Νεροχύτες\\Ανοξείδοτος νεροχύτης 60x50 ARENA 22060.jpg"

                },
                new Product
                {
                    Id = 9,
                    Name = "Ανοξείδοτος νεροχύτης 80x50 ARENA 22080",
                    CategoryId = 500,
                    ImgURL = "\\Content\\Images\\Κουζίνα\\Ανοξείδωτοι Νεροχύτες\\Ανοξείδοτος νεροχύτης 80x50 ARENA 22080.jpg"

                },
                new Product
                {
                    Id = 10,
                    Name = "Ανοξείδοτος νεροχύτης 44,5x44,5 VALLEY 24050",
                    CategoryId = 500,
                    ImgURL = "\\Content\\Images\\Κουζίνα\\Ανοξείδωτοι Νεροχύτες\\Ανοξείδοτος νεροχύτης 44,5x44,5 VALLEY 24050.jpg"

                },
                new Product
                {
                    Id = 11,
                    Name = "Ανοξείδοτος νεροχύτης 38x38 VALLEY 25038",
                    CategoryId = 500,
                    ImgURL = "\\Content\\Images\\Κουζίνα\\Ανοξείδωτοι Νεροχύτες\\Ανοξείδοτος νεροχύτης 38x38 VALLEY 25038.jpg"

                },
                new Product
                {
                    Id = 12,
                    Name = "Ανοξείδοτος νεροχύτης 50x50 VALLEY 25050",
                    CategoryId = 500,
                    ImgURL = "\\Content\\Images\\Κουζίνα\\Ανοξείδωτοι Νεροχύτες\\Ανοξείδοτος νεροχύτης 50x50 VALLEY 25050.jpg"

                },
                new Product
                {
                    Id = 13,
                    Name = "Ανοξείδοτος νεροχύτης 60x50 VALLEY 25060",
                    CategoryId = 500,
                    ImgURL = "\\Content\\Images\\Κουζίνα\\Ανοξείδωτοι Νεροχύτες\\Ανοξείδοτος νεροχύτης 60x50 VALLEY 25060.jpg"

                },
                new Product
                {
                    Id = 14,
                    Name = "Ανοξείδοτος νεροχύτης 78x50 VALLEY 25100",
                    CategoryId = 500,
                    ImgURL = "\\Content\\Images\\Κουζίνα\\Ανοξείδωτοι Νεροχύτες\\Ανοξείδοτος νεροχύτης 78x50 VALLEY 25100.jpg"

                },
                new Product
                {
                    Id = 15,
                    Name = "Ανοξείδοτος νεροχύτης 78x50 VALLEY 25105",
                    CategoryId = 500,
                    ImgURL = "\\Content\\Images\\Κουζίνα\\Ανοξείδωτοι Νεροχύτες\\Ανοξείδοτος νεροχύτης 78x50 VALLEY 25105.jpg"

                },
                new Product
                {
                    Id = 16,
                    Name = "Ανοξείδοτος νεροχύτης 80x50 VALLEY 25200",
                    CategoryId = 500,
                    ImgURL = "\\Content\\Images\\Κουζίνα\\Ανοξείδωτοι Νεροχύτες\\Ανοξείδοτος νεροχύτης 80x50 VALLEY 25200.jpg"

                },
                new Product
                {
                    Id = 17,
                    Name = "Ανοξείδοτος νεροχύτης 126x50 VALLEY 25210",
                    CategoryId = 500,
                    ImgURL = "\\Content\\Images\\Κουζίνα\\Ανοξείδωτοι Νεροχύτες\\Ανοξείδοτος νεροχύτης 126x50 VALLEY 25210.jpg"

                }
                );
                
            modelBuilder.Entity<Category>().HasData(

                /* Υδρευση */
                new Category()
                {
                    Id = 1,
                    Name = "'Υδρευση",
                    URL = "ydreusi",
                    ImgURL = "\\Content\\Images\\Ύδρευση.jpg"

                },

                new Category()
                {
                    Id = 2,
                    Name = "Αποχέτευση",
                    URL = "apoxeteusi",
                    ImgURL = "\\Content\\Images\\Αποχέτευση.jpg"

                },

                new Category()
                {
                    Id = 3,
                    Name = "Θερμοσίφωνα",
                    URL = "thermosifona",
                    ImgURL = "\\Content\\Images\\Θερμοσίφωνα.jpg"

                },

                new Category()
                {
                    Id = 4,
                    Name = "Μπάνιο",
                    URL = "mpanio",
                    ImgURL = "\\Content\\Images\\Μπάνιο.jpg"

                },


                new Category()
                {
                    Id = 5,
                    Name = "Κουζίνα",
                    URL= "kouzina",
                    ImgURL = "\\Content\\Images\\Κουζίνα.jpg"

                },

                /* Υδρευση */
                new Category()
                {
                    Id = 100,
                    ParentId = 1,
                    URL = "eksartimata",
                    Name = "Εξαρτήματα",
                    ImgURL = "\\Content\\Images\\Ύδρευση\\Εξαρτήματα.jpg"
                },

                new Category()
                {
                    Id = 101,
                    ParentId = 1,
                    URL = "solines",
                    Name = "Σωλήνες",
                    ImgURL = "\\Content\\Images\\Ύδρευση\\Σωλήνες.jpg"
                },

                new Category()
                {
                    Id = 102,
                    ParentId = 1,
                    URL = "diakoptes",
                    Name = "Διακόπτες - Κάνουλες",
                    ImgURL = "\\Content\\Images\\Ύδρευση\\Διακόπτες_Κάνουλες.jpg"
                },
               
                new Category()
                 {
                     Id = 103,
                     ParentId = 1,
                     URL = "stirigmata",
                     Name = "Στηρίγματα",
                     ImgURL = "\\Content\\Images\\Ύδρευση\\Στηρίγματα.jpg"
                },

                new Category()
                {
                    Id = 104,
                    ParentId = 100,
                    URL = "syllektes",
                    Name = "Συλλέκτες",
                    ImgURL = "\\Content\\Images\\Ύδρευση\\Στηρίγματα.jpg"
                },

                new Category()
                {
                    Id = 100001,
                    ParentId = 100,
                    URL = "xalkina",
                    Name = "Χάλκινα Εξαρτήματα",
                    ImgURL = "\\Content\\Images\\Ύδρευση\\Εξαρτήματα\\Χάλκινα Εξαρτήματα.jpg"
                },

                new Category()
                {
                    Id = 10002,
                    ParentId = 100,
                    URL = "orihalkina",
                    Name = "Ορειχάλκινα Εξαρτήματα",
                    ImgURL = "\\Content\\Images\\Ύδρευση\\Εξαρτήματα\\Ορειχάλκινα Εξαρτήματα.jpg"
                },

                new Category()
                {
                    Id = 10003,
                    ParentId = 100,
                    URL = "siderenia",
                    Name = "Σιδερένια εξαρτήματα",
                    ImgURL = "\\Content\\Images\\Ύδρευση\\Εξαρτήματα\\Σιδερένια εξαρτήματα.jpg"
                },

                new Category()
                {
                    Id = 100004,
                    ParentId = 100,
                    URL = "polyethileniou",
                    Name = "Εξαρτήματα Πολυαιθυλενίου",
                    ImgURL = "\\Content\\Images\\Ύδρευση\\Εξαρτήματα\\Εξαρτήματα Πολυαιθυλενίου.jpg"
                },

                new Category()
                {
                    Id = 100005,
                    ParentId = 100,
                    URL = "polypropileniou",
                    Name = "Εξαρτήματα Πολυπροπυλενίου",
                    ImgURL = "\\Content\\Images\\Ύδρευση\\Εξαρτήματα\\Εξαρτήματα Πολυπροπυλενίου.jpg"
                },

                new Category()
                {
                    Id = 100006,
                    ParentId = 100,
                    URL = "polystromatikis",
                    Name = "Εξαρτήματα Πολυστρωματικής",
                    ImgURL = "\\Content\\Images\\Ύδρευση\\Εξαρτήματα\\Εξαρτήματα Πολυστρωματικής.jpg"
                },

                /* Αποχέτευση */                  

                 new Category()
                 {
                     Id = 200,
                     ParentId = 2,
                     URL = "solinespvc",
                     Name = "Σωλήνες PVC",
                     ImgURL = "http://www.m-bath.gr/wp-content/uploads/2014/06/types-of-plumbing-pipes.jpg"
                 },

                new Category()
                {
                    Id = 201,
                    ParentId = 2,
                    URL = "sifoniaapoxeteusis",
                    Name = "Σιφώνια αποχέτευσης",
                    ImgURL = "http://www.m-bath.gr/wp-content/uploads/2014/06/types-of-plumbing-pipes.jpg"
                },

                
                /* Θερμοσίφωνα */
                 new Category()
                 {
                     Id = 300,
                     ParentId = 3,
                     URL = "hlectroboiler",
                     Name = "Ηλεκτρομπόιλερ",
                     ImgURL = "http://www.m-bath.gr/wp-content/uploads/2014/06/types-of-plumbing-pipes.jpg"
                 },

                new Category()
                {
                    Id = 301,
                    ParentId = 3,
                    URL = "elektrikathermosifona",
                    Name = "Ηλεκτρικά Θερμοσίφωνα",
                    ImgURL = "http://www.m-bath.gr/wp-content/uploads/2014/06/types-of-plumbing-pipes.jpg"
                },
                /* Μπάνιο */




                /* Κουζίνα */
                 new Category()
                 {
                     Id = 500,
                     ParentId = 5,
                     URL = "anoksidotoi",
                     Name = "Ανοξείδωτοι Νεροχύτες",
                     ImgURL = "\\Content\\Images\\Κουζίνα\\Ανοξείδωτοι Νεροχύτες.jpg"
                 },

               new Category()
               {
                   Id = 501,
                   ParentId = 5,
                   URL = "synthetikoi",
                   Name = "Νεροχύτες Συνθετικοί",
                   ImgURL = "\\Content\\Images\\Κουζίνα\\Νεροχύτες Συνθετικοί.jpg"
               },
                new Category()
                {
                    Id = 502,
                    ParentId = 5,
                    URL = "mpataries",
                    Name = "Μπαταρίες",
                    ImgURL = "\\Content\\Images\\Κουζίνα\\Μπαταρίες.jpg"
                },

               new Category()
               {
                   Id = 503,
                   ParentId = 5,
                   URL = "aporrofitires",
                   Name = "Απορροφητήρες",
                   ImgURL = "\\Content\\Images\\Κουζίνα\\Απορροφητήρες.jpg"
               },
                new Category()
                {
                    Id = 504,
                    ParentId = 5,
                    URL = "aksesouar",
                    Name = "Αξεσουάρ Κουζίνας",
                    ImgURL = "\\Content\\Images\\Κουζίνα\\Αξεσουάρ Κουζίνας ανταλλακτικά.jpg"
                },

                new Category()
                {
                    Id = 6,
                    URL = "thermansi",
                    Name = "Θέρμανση",
                    ImgURL = ""
                }

                ) ;

            

        }
        
    }
}
