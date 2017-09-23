using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnamSerkan.Models
{
    public class ProductRepository
    {
        private static List<Product> productList;
        static ProductRepository()
        {
            productList = new List<Product>();
            productList.Add(new Product()
            {
                ProductDetailUrl = "/Resources/Pdf/Products/Oil/behranOil.pdf",
                ImagePath = "/Resources/Images/Products/Oil/behranOil.png",
                ProductName = "22نفت بهران"
            });
        }
        public static List<Product> GetAllProducts()
        {
            return productList;
        }
    }
}
