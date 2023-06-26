using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBath.Shared.DataTransferObjects
{
    public class OrderDetailsProductResponse
    {

        public int ProductId { get; set; }

        public string ProductName { get; set; }=string.Empty;

        public string VariantName { get; set; }=string.Empty;

        public string ImgUrl { get;set; }=string.Empty;

        public int Quantity { get; set; }

        public decimal TotalPrice { get; set; }

    }
}
