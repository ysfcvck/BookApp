using BookApp.Models.Context;
using BookApp.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApp.Contollers
{
    [Authorize(Roles = "Admin,Moderator")]
    public class BillboardController : Controller
    {
        Context c = new Context();

        // Reklam Listesi
        public IActionResult Index()
        {
            var billboard = c.Billboards.ToList();
            return View(billboard);
        }

        // Reklam ekle
        [HttpGet]
        public IActionResult BillboardAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult BillboardAdd(BillboardViewModel b)
        {
            /* Veri türü kontrolü */
            if (TryValidateModel(b, nameof(b)))
            {
                c.Billboards.Add(b);
                c.SaveChanges();
                ModelState.Clear();
                return RedirectToAction("BillboardAdd");
            }
            else
                return View();
        }

        // Reklam Sil
        public IActionResult BillboardRemove(int id)
        {
            var billboard = c.Billboards.Find(id);
            c.Billboards.Remove(billboard);
            c.SaveChanges();
            return RedirectToAction("index");
        }

        // Reklam bilgisi getirme
        public IActionResult BillboardGet(int id)
        {
            var billboard = c.Billboards.Find(id);
            return View("BillboardGet", billboard);
        }

        //Reklam Güncelle
        [HttpPost]
        public IActionResult BillboardUpdate(BillboardViewModel b)
        {
            var billboard = c.Billboards.Find(b.Id);

            if (TryValidateModel(b, nameof(b)))
            {
                billboard.Id = b.Id;
                billboard.MainTitle1 = b.MainTitle1;
                billboard.MainTitle2 = b.MainTitle2;
                billboard.Title = b.Title;
                billboard.Description = b.Description;
                billboard.ImageURL = b.ImageURL;
                c.SaveChanges();
                return RedirectToAction("index");
            }
            return View("BillboardGet", billboard);
        }
    }
}
