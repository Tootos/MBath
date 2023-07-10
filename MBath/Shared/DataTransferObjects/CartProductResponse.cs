using MBath.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBath.Shared.DataTransferObjects
{
    public class CartProductResponse
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; } = string.Empty;
        public int VariantId { get; set; }
        public string VariantName { get; set; } = string.Empty;
        public string ImgUrl { get; set; } = string.Empty;
        public List<Image> Images { get; set; } = new List<Image>();
        public decimal Price { get; set; }

        public int Quantity { get; set; }
    }
}

