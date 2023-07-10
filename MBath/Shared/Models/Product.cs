using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBath.Shared.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ImgURL { get; set; } = string.Empty;
        public List<Image> Images { get; set; }= new List<Image>();
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        public List<ProductVariantInfo> ProductVariants { get; set; } = new List<ProductVariantInfo>();

        public bool Visible { get; set; } = true;
        public bool Deleted { get; set; } = false;
        [NotMapped]
        public bool Editing { get; set; } = false;
        [NotMapped]
        public bool IsNew { get; set; } = false;

    }
}
