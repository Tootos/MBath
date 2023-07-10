using MBath.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBath.Shared.DataTransferObjects
{
    public class OrderOverviewResponse
    {
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }

        public decimal TotalPrice { get; set; }

        public string ProductName { get; set; } = string.Empty;

        public string ProductImgUrl { get; set; } = string.Empty;

    }
}
