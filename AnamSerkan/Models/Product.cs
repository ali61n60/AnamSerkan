using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnamSerkan.Models
{
    public class Product
    {
        public string ImagePath { get; set; }
        public string ProductDetailUrl { get; set; }
        public string ProductName { get; set; }
        public ProductType ProductType { get; set; }
    }

    public enum ProductType
    {
        Internal,
        External
    }
}
