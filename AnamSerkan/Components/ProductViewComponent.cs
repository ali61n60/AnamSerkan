using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnamSerkan.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace AnamSerkan.Components
{
    public class ProductViewComponent:ViewComponent
    {

        public IViewComponentResult Invoke(Product product)
        {
            return View(product);
        }
    }
}
