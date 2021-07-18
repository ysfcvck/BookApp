using BookApp.Models.Context;
using BookApp.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApp.Contollers
{
    [Authorize(Roles = "Admin,Moderator")]
    public class BookController : Controller
    {
        Context c = new Context();
        public void Genres()
        {
            //Veritabanından kategori id ve kategori adını listeliyoruz.
            List<SelectListItem> Categories = (from x in c.Categories.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = x.CategoryName,
                                                   Value = x.CategoryId.ToString()
                                               }).ToList();
            ViewBag.ctgry = Categories; //Listeyi viewbage atıyoruz.


            //Veritabanından Tür id ve Tür adını listeliyoruz.
            List<SelectListItem> Genres = (from x in c.Genres.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.GenreName,
                                               Value = x.GenreId.ToString()
                                           }).ToList();
            ViewBag.gnrs = Genres; //Listeyi viewbage atıyoruz.
        }

        // Kitap Listesi
        public IActionResult Index()
        {
            Genres();
            var books = c.Books.ToList();
            return View(books);
        }

        // Kitap Ekleme
        [HttpGet]
        public IActionResult BookAdd()
        {
            Genres();
            return View();
        }
        [HttpPost]
        public IActionResult BookAdd(BookViewModel b)
        {
            Genres();
            /* Veri türü kontrolü */
            if (TryValidateModel(b, nameof(b)))
            {
                c.Books.Add(b);
                c.SaveChanges();
                ModelState.Clear();
                return RedirectToAction("BookAdd");
            }
            else
                return View();
        }

        // Kitap Sil
        public IActionResult BookRemove(int id) //View > Book > Index'teki actionlink'ten gelen id değerine göre işlemleri yapacağız
        {
            var x = c.Books.Find(id); //Idye göre kitap bilgilerini alıyoruz
            c.Books.Remove(x); //Seçilen kitabı veri tabanından siliyoruz
            c.SaveChanges();
            return RedirectToAction("index");
        }

        // Kitap bilgisi getirme
        public IActionResult BookGet(int id) //View > Book > Index'teki actionlink'ten gelen id değerine göre işlemleri yapacağız
        {
            Genres();
            var x = c.Books.Find(id); //idye göre Books tablosundan kitap bilgilerini alıyoruz
            return View("BookGet", x);
        }

        //Kitap Güncelle
        [HttpPost]
        public IActionResult BookUpdate(BookViewModel b)
        {
            var x = c.Books.Find(b.BookId); //BookId ye göre books tablosundan kitap bilgilerini alıyoruz

            if (TryValidateModel(b, nameof(b)))//Model veri türü doğruysa modelden gelen bilgileri kaydediyoruz
            {
                x.BookId = b.BookId;
                x.Name = b.Name;
                x.Writer = b.Writer;
                x.Publisher = b.Publisher;
                x.TotalPages = b.TotalPages;
                x.PublishYear = b.PublishYear;
                x.Language = b.Language;
                x.CategoryId = b.CategoryId;
                x.GenreId = b.GenreId;
                x.Price = b.Price;
                x.Stock = b.Stock;
                x.Description = b.Description;
                x.ImageURL = b.ImageURL;
                c.SaveChanges();
                return RedirectToAction("index");
            }
            return View("BookGet", x);
        }
    }
}
