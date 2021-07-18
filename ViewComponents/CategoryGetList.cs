using BookApp.Models.Context;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApp.ViewComponents
{
    public class CategoryGetList : ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            var categories = c.Categories.ToList();
            return View(categories);
        }
    }
}
