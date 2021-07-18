using BookApp.Models.Context;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApp.ViewComponents
{
    public class GenreGetList:ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            var genres = c.Genres.ToList();
            return View(genres);
        }
    }
}
