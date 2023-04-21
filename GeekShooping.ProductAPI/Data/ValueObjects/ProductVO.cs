using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeekShooping.ProductAPI.Data.ValueObjects
{
    public class ProductVO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }
        public string ImageUrl { get; set; }
    }
}
