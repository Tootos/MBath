namespace MBath.Server.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options) { }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Variant> Variants { get; set; }

        public DbSet<ProductVariantInfo> ProductVariants { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Image> Images { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CartItem>()
                .HasKey(c => new { c.UserId, c.ProductId, c.VariantId });


            modelBuilder.Entity<OrderItem>()
                .HasKey(oi => new { oi.OrderId, oi.VariantId, oi.ProductId });

            modelBuilder.Entity<ProductVariantInfo>()
                .HasKey(pv => new { pv.ProductId, pv.VariantId });

            modelBuilder.Entity<Variant>().HasData(
                new Variant
                {
                    Id = 1,                   
                    Name = "Λεία επιφάνεια"                   
                },
                new Variant
                {
                    Id = 2,                   
                    Name = "Σαγρέ επιφάνεια"               
                }
                );

            modelBuilder.Entity<ProductVariantInfo>().HasData(
                
                new ProductVariantInfo
                {
                    ProductId= 1,
                    VariantId= 1,
                    Price= 145.00m
                },
                new ProductVariantInfo
                {
                    ProductId = 1,
                    VariantId = 2,
                    Price = 160.00m
                },
                new ProductVariantInfo
                {
                    ProductId = 2,
                    VariantId = 1,
                    Price = 145.00m
                },
                new ProductVariantInfo
                {
                    ProductId = 3,
                    VariantId = 1,
                    Price =160.00m
                }, new ProductVariantInfo
                {
                    ProductId = 3,
                    VariantId = 2,
                    Price = 175.00m
                }, new ProductVariantInfo
                {
                    ProductId = 4,
                    VariantId = 1,
                    Price =170.00m
                }, new ProductVariantInfo
                {
                    ProductId = 4,
                    VariantId = 2,
                    Price =185.00m
                },
                new ProductVariantInfo
                {
                    ProductId = 5,
                    VariantId = 1,
                    Price = 155.00m
                }, new ProductVariantInfo
                {
                    ProductId = 5,
                    VariantId = 2,
                    Price = 165.00m
                }, new ProductVariantInfo
                {
                    ProductId = 6,
                    VariantId = 1,
                    Price = 155.00m
                }, new ProductVariantInfo
                {
                    ProductId = 6,
                    VariantId = 2,
                    Price = 165.00m
                }

                );
                
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

                }
                );
                
            modelBuilder.Entity<Category>().HasData(

                /* Υδρευση */
                new Category()
                {
                    Id = 1,
                    Name = "'Υδρευση",
                    Url = "ydreusi",
                    ImgURL = "\\Content\\Images\\Ύδρευση.jpg"

                },

                new Category()
                {
                    Id = 2,
                    Name = "Αποχέτευση",
                    Url = "apoxeteusi",
                    ImgURL = "\\Content\\Images\\Αποχέτευση.jpg"

                },

                new Category()
                {
                    Id = 3,
                    Name = "Θερμοσίφωνα",
                    Url = "thermosifona",
                    ImgURL = "\\Content\\Images\\Θερμοσίφωνα.jpg"

                },

                new Category()
                {
                    Id = 4,
                    Name = "Μπάνιο",
                    Url = "mpanio",
                    ImgURL = "\\Content\\Images\\Μπάνιο.jpg"

                },


                new Category()
                {
                    Id = 5,
                    Name = "Κουζίνα",
                    Url= "kouzina",
                    ImgURL = "\\Content\\Images\\Κουζίνα.jpg"

                },

                /* Υδρευση */
                new Category()
                {
                    Id = 100,
                    ParentId = 1,
                    Url = "eksartimata",
                    Name = "Εξαρτήματα",
                    ImgURL = "\\Content\\Images\\Ύδρευση\\Εξαρτήματα.jpg"
                },

                new Category()
                {
                    Id = 101,
                    ParentId = 1,
                    Url = "solines",
                    Name = "Σωλήνες",
                    ImgURL = "\\Content\\Images\\Ύδρευση\\Σωλήνες.jpg"
                },

                new Category()
                {
                    Id = 102,
                    ParentId = 1,
                    Url = "diakoptes",
                    Name = "Διακόπτες - Κάνουλες",
                    ImgURL = "\\Content\\Images\\Ύδρευση\\Διακόπτες_Κάνουλες.jpg"
                },
               
                new Category()
                 {
                     Id = 103,
                     ParentId = 1,
                     Url = "stirigmata",
                     Name = "Στηρίγματα",
                     ImgURL = "\\Content\\Images\\Ύδρευση\\Στηρίγματα.jpg"
                },

                new Category()
                {
                    Id = 104,
                    ParentId = 100,
                    Url = "syllektes",
                    Name = "Συλλέκτες",
                    ImgURL = "\\Content\\Images\\Ύδρευση\\Στηρίγματα.jpg"
                },

                new Category()
                {
                    Id = 100001,
                    ParentId = 100,
                    Url = "xalkina",
                    Name = "Χάλκινα Εξαρτήματα",
                    ImgURL = "\\Content\\Images\\Ύδρευση\\Εξαρτήματα\\Χάλκινα Εξαρτήματα.jpg",
                    HasProducts = true
                },

                new Category()
                {
                    Id = 10002,
                    ParentId = 100,
                    Url = "orihalkina",
                    Name = "Ορειχάλκινα Εξαρτήματα",
                    ImgURL = "\\Content\\Images\\Ύδρευση\\Εξαρτήματα\\Ορειχάλκινα Εξαρτήματα.jpg",
                    HasProducts = true
                },

                new Category()
                {
                    Id = 10003,
                    ParentId = 100,
                    Url = "siderenia",
                    Name = "Σιδερένια εξαρτήματα",
                    ImgURL = "\\Content\\Images\\Ύδρευση\\Εξαρτήματα\\Σιδερένια εξαρτήματα.jpg",
                    HasProducts = true
                },

                new Category()
                {
                    Id = 100004,
                    ParentId = 100,
                    Url = "polyethileniou",
                    Name = "Εξαρτήματα Πολυαιθυλενίου",
                    ImgURL = "\\Content\\Images\\Ύδρευση\\Εξαρτήματα\\Εξαρτήματα Πολυαιθυλενίου.jpg"
                },

                new Category()
                {
                    Id = 100005,
                    ParentId = 100,
                    Url = "polypropileniou",
                    Name = "Εξαρτήματα Πολυπροπυλενίου",
                    ImgURL = "\\Content\\Images\\Ύδρευση\\Εξαρτήματα\\Εξαρτήματα Πολυπροπυλενίου.jpg",
                    HasProducts = true
                },

                new Category()
                {
                    Id = 100006,
                    ParentId = 100,
                    Url = "polystromatikis",
                    Name = "Εξαρτήματα Πολυστρωματικής",
                    ImgURL = "\\Content\\Images\\Ύδρευση\\Εξαρτήματα\\Εξαρτήματα Πολυστρωματικής.jpg",
                    HasProducts = true
                },

                /* Αποχέτευση */                  

                 new Category()
                 {
                     Id = 200,
                     ParentId = 2,
                     Url = "solinespvc",
                     Name = "Σωλήνες PVC",
                     ImgURL = ""
                 },

                new Category()
                {
                    Id = 201,
                    ParentId = 2,
                    Url = "sifoniaapoxeteusis",
                    Name = "Σιφώνια αποχέτευσης",
                    ImgURL = ""
                },

                
                /* Θερμοσίφωνα */
                 new Category()
                 {
                     Id = 300,
                     ParentId = 3,
                     Url = "hlectroboiler",
                     Name = "Ηλεκτρομπόιλερ",
                     ImgURL = ""
                 },

                new Category()
                {
                    Id = 301,
                    ParentId = 3,
                    Url = "elektrikathermosifona",
                    Name = "Ηλεκτρικά Θερμοσίφωνα",
                    ImgURL = ""
                },
                /* Μπάνιο */




                /* Κουζίνα */
                 new Category()
                 {
                     Id = 500,
                     ParentId = 5,
                     Url = "anoksidotoi",
                     Name = "Ανοξείδωτοι Νεροχύτες",
                     ImgURL = "\\Content\\Images\\Κουζίνα\\Ανοξείδωτοι Νεροχύτες.jpg",
                     HasProducts = true
                 },

               new Category()
               {
                   Id = 501,
                   ParentId = 5,
                   Url = "synthetikoi",
                   Name = "Νεροχύτες Συνθετικοί",
                   ImgURL = "\\Content\\Images\\Κουζίνα\\Νεροχύτες Συνθετικοί.jpg"
               },
                new Category()
                {
                    Id = 502,
                    ParentId = 5,
                    Url = "mpataries",
                    Name = "Μπαταρίες",
                    ImgURL = "\\Content\\Images\\Κουζίνα\\Μπαταρίες.jpg"
                },

               new Category()
               {
                   Id = 503,
                   ParentId = 5,
                   Url = "aporrofitires",
                   Name = "Απορροφητήρες",
                   ImgURL = "\\Content\\Images\\Κουζίνα\\Απορροφητήρες.jpg"
               },
                new Category()
                {
                    Id = 504,
                    ParentId = 5,
                    Url = "aksesouar",
                    Name = "Αξεσουάρ Κουζίνας",
                    ImgURL = "\\Content\\Images\\Κουζίνα\\Αξεσουάρ Κουζίνας ανταλλακτικά.jpg",
                    HasProducts = true
                },

                new Category()
                {
                    Id = 6,
                    Url = "thermansi",
                    Name = "Θέρμανση",
                    ImgURL = ""
                }

                ) ;

            

        }
        
    }
}
