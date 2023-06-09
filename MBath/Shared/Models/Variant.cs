using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MBath.Shared.Models
{
    public class Variant
    {

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        [ForeignKey("ProductId")]
        public int ProductId { get; set; }
        [JsonIgnore]
        public Product? Product { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }



    }
}
