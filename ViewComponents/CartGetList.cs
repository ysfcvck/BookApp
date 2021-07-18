using BookApp.Models.Authentication;
using BookApp.Models.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApp.ViewComponents
{
    public class CartGetList : ViewComponent
    {
        readonly UserManager<AppUser> _userManager;
        Context c = new Context();
        public CartGetList(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public IViewComponentResult Invoke()
        {
            var userId = _userManager.GetUserId(HttpContext.User).ToString(); //Giriş yapan kullanıcı id sini alıyoruz.
            ViewBag.userId = userId;
            var cart = c.Carts.Where(x => x.UserId == Int32.Parse(userId)).ToList();//Giriş yapan kullanıcının id sine göre sepetteki ürünleri listeye alıyoruz.
            return View(cart);
        }
    }
}
