using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AnamSerkan.Components
{
    public class ProductViewComponent:ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            //ViewBag.SelectedCategory = RouteData?.Values["category"];
            //return View(repository.GetProducts()
            //    .Select(x => x.Category)
            //    .Distinct()
            //    .OrderBy(x => x));
            return View();
        }
    }
}
