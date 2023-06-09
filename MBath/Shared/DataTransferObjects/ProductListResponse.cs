using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MBath.Shared.Models;

namespace MBath.Shared.DataTransferObjects
{
    public class ProductListResponse
    {
        public List<Product> Products { get; set; } = new List<Product>();

        public int Pages { get; set; }

        public int CurrentPage { get; set; } 
    }
}
