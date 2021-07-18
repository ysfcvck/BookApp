using BookApp.Models.Authentication;
using BookApp.Models.Context;
using BookApp.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApp.Contollers
{
    [Authorize]
    public class AccountController : Controller
    {
        Context c = new Context();
        readonly UserManager<AppUser> _userManager;
        public AccountController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public void CartCount()
        {
            if (User.Identity.IsAuthenticated)
            {
                var userId = _userManager.GetUserId(HttpContext.User).ToString(); //Giriş yapan kullanıcı id sini alıyoruz.
                var cart = c.Carts.Where(x => x.UserId == Int32.Parse(userId)).ToList();//Giriş yapan kullanıcının id sine göre sepetteki ürünleri listeye alıyoruz.
                ViewBag.CartCount = cart.Count(); //Liste uzunluğunu viewbag de tutuyoruz.
            }
        }

        // Kullanıcı bilgi getir
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            CartCount();
            var userId = _userManager.GetUserId(HttpContext.User).ToString(); // Giriş yapan kullanıcının id'sini alıyoruz
            var user = await _userManager.FindByIdAsync(userId); //Id'ye göre kullanıcı bilgilerini alıyoruz
            var model = new AppUserViewModel
            {
                Id = user.Id,
                UserName = user.UserName,
                NameSurname = user.NameSurname,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                Adress = user.Adress,
            };
            return View(model);
        }

        // Kullanıcı bilgi güncelle
        [HttpPost]
        public async Task<IActionResult> Index(AppUserViewModel model)
        {
            if (ModelState.IsValid) //Model veri türü doğruysa
            {
                var user = await _userManager.FindByIdAsync(model.Id.ToString()); //Modelden gelen id değerine göre kullanıcı bilgilerini alıyoruz

                user.UserName = model.UserName;
                user.NameSurname = model.NameSurname;
                user.Email = model.Email;
                user.PhoneNumber = model.PhoneNumber;
                user.Adress = model.Adress;

                var result = await _userManager.UpdateAsync(user); //Kullanıcı bilgilerini girilen bilgilerle güncelliyoruz
                if (result.Succeeded)
                {
                    return RedirectToAction("index");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(model);
            }
            return View();
        }

        // Kullanıcıya ait gönderilen siparişler
        public IActionResult MyShippedOrders()
        {
            CartCount();
            var userId = _userManager.GetUserId(HttpContext.User).ToString(); //Giriş yapan kullanıcının id sini alıyoruz
            var books = c.Books.ToList(); //Tüm kitapları listeliyoruz
            var orders = c.Orders.Where(x => x.UserId == Int32.Parse(userId) && x.State==true).ToList(); //Orders tablosundan giriş yapan kullanıcının id'sine göre ve state değeri true olan siparişleri listeliyoruz
            return View(orders);
        }

        // Kullanıcıya ait gönderilmeyen siparişler
        public IActionResult MyUnShippedOrders()
        {
            CartCount();
            var userId = _userManager.GetUserId(HttpContext.User).ToString(); //Giriş yapan kullanıcının id sini alıyoruz
            var books = c.Books.ToList(); //Tüm kitapları listeliyoruz
            var orders = c.Orders.Where(x => x.UserId == Int32.Parse(userId) && x.State==false).ToList(); //Orders tablosundan giriş yapan kullanıcının id'sine göre ve state değeri false olan siparişleri listeliyoruz
            return View(orders);
        }
    }
}
