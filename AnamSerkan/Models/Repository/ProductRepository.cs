using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnamSerkan.Models.Repository
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
                ProductName = "نفت بهران",
                ProductType = ProductType.Internal
            });
            productList.Add(new Product()
                {
                ProductDetailUrl = "/Resources/Pdf/Products/Oil/iranOil.pdf",
                    ImagePath = "/Resources/Images/Products/Oil/iranOil.png",
                    ProductName = "نفت ایرانول",
                    ProductType = ProductType.Internal
            });
            productList.Add(new Product()
                {
                    ProductDetailUrl = "/Resources/Pdf/Products/Oil/parsOil.pdf",
                    ImagePath = "/Resources/Images/Products/Oil/parsOil.png",
                    ProductName = "نفت پارس",
                    ProductType = ProductType.Internal
                });
            productList.Add(new Product()
                {
                    ProductDetailUrl = "/Resources/Pdf/Products/Oil/sepahanOil.pdf",
                    ImagePath = "/Resources/Images/Products/Oil/sepahanOil.png",
                    ProductName = "نفت سپاهان",
                    ProductType = ProductType.Internal
                });

            productList.Add(new Product()
                {
                    ProductDetailUrl = "/Resources/Pdf/Products/Oil/shellOil.pdf",
                    ImagePath = "/Resources/Images/Products/Oil/shellOil.png",
                    ProductName = "شل",
                    ProductType = ProductType.External
                });
            productList.Add(new Product()
                {
                    ProductDetailUrl = "/Resources/Pdf/Products/Oil/mobilOil.pdf",
                    ImagePath = "/Resources/Images/Products/Oil/mobilOil.png",
                    ProductName = "موبیل",
                    ProductType = ProductType.External
                });
            productList.Add(new Product()
                {
                    ProductDetailUrl = "/Resources/Pdf/Products/Oil/castrolOil.pdf",
                    ImagePath = "/Resources/Images/Products/Oil/castrolOil.png",
                    ProductName = "کاسترول",
                    ProductType = ProductType.External
                });
            productList.Add(new Product()
                {
                    ProductDetailUrl = "/Resources/Pdf/Products/Oil/totalOil.pdf",
                    ImagePath = "/Resources/Images/Products/Oil/totalOil.png",
                    ProductName = "توتال",
                    ProductType = ProductType.External
                });
            productList.Add(new Product()
                {
                    ProductDetailUrl = "#",
                    ImagePath = "/Resources/Images/Products/Oil/fuchsOil.png",
                    ProductName = "فوچز",
                    ProductType = ProductType.External
                });
            productList.Add(new Product()
                {
                    ProductDetailUrl = "#",
                    ImagePath = "/Resources/Images/Products/Oil/elfOil.png",
                    ProductName = "الف",
                    ProductType = ProductType.External
                });
            productList.Add(new Product()
                {
                    ProductDetailUrl = "#",
                    ImagePath = "/Resources/Images/Products/Oil/liquiMolyOil.png",
                    ProductName = "لیکی مولی",
                    ProductType = ProductType.External
                });
            productList.Add(new Product()
                {
                    ProductDetailUrl = "#",
                    ImagePath = "/Resources/Images/Products/Oil/bpOil.png",
                    ProductName = "بی پی",
                    ProductType = ProductType.External
                });
        }
        public static List<Product> GetAllProducts()
        {
            return productList;
        }
    }
}
