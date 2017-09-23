using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnamSerkan.Models;
using Microsoft.AspNetCore.Mvc;

namespace AnamSerkan.Components
{
    public class ProductViewComponent:ViewComponent
    {

        public IViewComponentResult Invoke(Product product)
        {
            //ViewBag.SelectedCategory = RouteData?.Values["category"];
            //return View(repository.GetProducts()
            //    .Select(x => x.Category)
            //    .Distinct()
            //    .OrderBy(x => x));
            return View(product);
        }
    }
}
