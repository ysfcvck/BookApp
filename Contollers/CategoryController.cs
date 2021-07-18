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
    public class CategoryController : Controller
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

        // KATEGORİ LİSTELE
        public IActionResult Index()
        {
            var category = c.Categories.ToList();
            return View(category);
        }

        // KATEGORİ EKLE
        [HttpGet]
        public IActionResult CategoryAdd()
        {
            Statuses();
            return View();
        }
        [HttpPost]
        public IActionResult CategoryAdd(CategoryViewModel cv)
        {
            Statuses();//Controller'ın başında yazmış olduğumuz fonksiyonu çağırıyoruz
            
            if (TryValidateModel(cv, nameof(cv)))// Veri türü kontrolü 
            {
                c.Categories.Add(cv); // Kullanıcının belirleyeceği modeldeki bilgileri Category tablosuna ekliyoruz
                c.SaveChanges();
                ModelState.Clear(); // Form verilerini temizliyoruz
                return RedirectToAction("CategoryAdd");
            }
            else
                return View();
        }

        // KATEGORİ BİLGİSİ GETİR
        public IActionResult CategoryGet(int id) // Kategori bilgini güncelleyebilmemiz için View > Category > Index'teki actionlink'ten gelen id değerine göre işlem yapacağız
        {
            var x = c.Categories.Find(id);// Id'ye göre Category tablosundan kategori bilgilerini alıyoruz
            return View("CategoryGet", x);
        }

        // KATEGORİ GÜNCELLE
        public IActionResult CategoryUpdate(CategoryViewModel cv)
        {
            var x = c.Categories.Find(cv.CategoryId); // CategoryId'ye göre veri tabanından kategori bilgilerini alıyoruz
            if (TryValidateModel(cv, nameof(cv))) //Model veri türü kontrolü
            {
                x.CategoryId = cv.CategoryId;
                x.CategoryName = cv.CategoryName;
                x.Status = cv.Status;
                c.SaveChanges();

                return RedirectToAction("index");
            }
            return View("CategoryGet", x);
        }

        //Kategori aktif hale getir
        public IActionResult CategoryActive(int id) // View > Category > Index'teki actionlink'ten  gelen id değerine göre işlem yapacağız
        {
            var x = c.Categories.Find(id); //Id'ye göre Categories tablosundan kategori bilgilerini alıyoruz
            x.Status = true; // Alınan bilgilerdeki Status değerini true yapıyoruz
            c.SaveChanges();
            return RedirectToAction("index");
        }

        //Kategori pasif hale getir
        public IActionResult CategoryInactive(int id) // View > Category > Index'teki actionlink'ten  gelen id değerine göre işlem yapacağız
        {
            var x = c.Categories.Find(id); //Id'ye göre Categories tablosundan kategori bilgilerini alıyoruz
            x.Status = false; // Alınan bilgilerdeki Status değerini false yapıyoruz
            c.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
