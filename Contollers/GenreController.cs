using BookApp.Models.Authentication;
using BookApp.Models.Context;
using BookApp.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApp.Contollers
{
    [Authorize(Roles = "Admin,Moderator")]
    public class GenreController : Controller
    {
        Context c = new Context();
       
        public void Statuses() // Durumları listelemek için metot
        {
            //Veritabanından durumları listeye alıyoruz.
            List<SelectListItem> Statuses = (from x in c.Statuses.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.Status,
                                                 Value = x.Status
                                             }).ToList();
            ViewBag.Statuses = Statuses; // Listeyi viewbag e aktarıyoruz.
        }

        // TÜR LİSTELE
        public IActionResult Index()
        {
            var genres = c.Genres.ToList();
            return View(genres);
        }

        // TÜR EKLE
        [HttpGet]
        public IActionResult GenreAdd()
        {
            Statuses();
            return View();
        }
        [HttpPost]
        public IActionResult GenreAdd(GenreViewModel g)
        {
            Statuses();//Controller'ın başında yazmış olduğumuz fonksiyonu çağırıyoruz
            
            if (TryValidateModel(g, nameof(g)))// Veri türü kontrolü 
            {
                c.Genres.Add(g); // Kullanıcının belirleyeceği modeldeki bilgileri Genres tablosuna ekliyoruz
                c.SaveChanges();
                ModelState.Clear(); // Form verilerini temizliyoruz
                return RedirectToAction("GenreAdd");
            }
            else
                return View();
        }

        // TÜR BİLGİSİ GETİR
        public IActionResult GenreGet(int id) // Tür bilgini güncelleyebilmemiz için View > Genre > Index'teki actionlink'ten gelen id değerine göre işlem yapacağız
        {
            var x = c.Genres.Find(id); // Id'ye göre Genres tablosundan tür bilgilerini alıyoruz
            return View("GenreGet", x);
        }

        // TÜR GÜNCELLE
        public IActionResult GenreUpdate(GenreViewModel g)
        {
            var x = c.Genres.Find(g.GenreId); // GenreId'ye göre veri tabanından tür bilgilerini alıyoruz
            if (TryValidateModel(g, nameof(g))) //Model veri türü kontrolü
            {
                x.GenreId = g.GenreId;
                x.GenreName = g.GenreName;
                x.Status = g.Status;
                c.SaveChanges();

                return RedirectToAction("index");
            }
            return View("GenreGet", x);
        }

        //Türü aktif hale getir
        public IActionResult GenreActive(int id) // View > Genre > Index'teki actionlink'ten  gelen id değerine göre işlem yapacağız
        {
            var x = c.Genres.Find(id); //Id'ye göre Genres tablosundan tür bilgilerini alıyoruz 
            x.Status = true; // Alınan bilgilerdeki Status değerini true yapıyoruz
            c.SaveChanges();
            return RedirectToAction("index");
        }

        //Türü inaktif hale getir
        public IActionResult GenreInactive(int id) // View > Genre > Index'teki actionlink'ten  gelen id değerine göre işlem yapacağız
        {
            var x = c.Genres.Find(id); 
            x.Status = false; // Alınan bilgilerdeki Status değerini false yapıyoruz
            c.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
