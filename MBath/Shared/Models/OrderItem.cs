using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBath.Shared.Models
{
    public class OrderItem
    {
        public Order Order { get; set; }
        public int OrderId { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }    
        public Variant Variant { get; set; }
        public int VariantId { get; set; }
        public int Quantity { get; set; }

        [Column(TypeName ="decimal(18,2)")]
        public decimal TotalPrice { get; set; }
        

    }
}
