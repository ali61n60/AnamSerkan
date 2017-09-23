using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnamSerkan.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AnamSerkan.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Products()
        {
            List<Product> productList=new List<Product>();
            productList.Add(new Product()
            {
                ProductDetailUrl = "/Resources/Pdf/Products/Oil/behranOil.pdf",
                ImagePath = "/Resources/Images/Products/Oil/behranOil.png",
                ProductName = "22نفت بهران"
            });
            
            return View(productList.ToArray());
        }

        public IActionResult Equivalent()
        {
            return View();
        }

        
    }
}
