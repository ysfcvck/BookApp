using BookApp.Models.Authentication;
using BookApp.Models.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApp.Contollers
{
    [Authorize(Roles = "Admin,Moderator")] // Bu controller'a Admin veya Moderator rolu olan kullanıcılar erişebilir
    public class OrderController : Controller
    {
        readonly UserManager<AppUser> _userManager;
        Context c = new Context();
        public OrderController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        // Gönderilen sipariş listesi
        public IActionResult ShippedOrders()
        {
            var books = c.Books.ToList(); // Kitap adını çekebilmemiz için tüm kitapları listeye alıyoruz
            var orders = c.Orders.Where(x=>x.State==true).ToList(); // Orders tablosundaki State değeri true olan siparişleri listeliyoruz
            return View(orders);
        }

        // Gönderilmeyen sipariş listesi
        public  IActionResult UnShippedOrders()
        {
            var books = c.Books.ToList(); // Kitap adını çekebilmemiz için tüm kitapları listeye alıyoruz
            var orders = c.Orders.Where(x => x.State == false).ToList(); // Orders tablosundaki State değeri false olan siparişleri listeliyoruz
            return View(orders);
        }

        // Sipariş iptal et (sil)
        public IActionResult OrderRemove(int id) // View > Order > UnShippedOrders'taki actionlink'ten gelen id'ye göre işlem yapıyoruz
        {
            var order = c.Orders.Find(id); // Orders tablosundan id'ye göre siparişi listeliyoruz
            c.Orders.Remove(order); // Listelenen siparişi veri tabanından siliyoruz
            c.SaveChanges();
            return RedirectToAction("UnShippedOrders");
        }

        // Sipariş gönderildi
        public IActionResult SendOrder(int id) // View > Order > UnShippedOrders'taki actionlink'ten gelen id'ye göre işlem yapıyoruz
        {
            var order = c.Orders.Find(id); // Orders tablosundan id'ye göre siparişi listeliyoruz
            order.State = true; // Listeye alınan siparişin State değerini true yapıyoruz
            c.SaveChanges();
            return RedirectToAction("UnShippedOrders");
        }

        // Sipariş Detayı
        public IActionResult OrderDetail(int id) // View > Order > UnShippedOrders ya da ShippedOrders'taki actionlink'ten gelen id'ye göre işlem yapıyoruz
        {
            var orderDetail = c.Orders.Find(id); // Id'ye göre sipariş bilgilerini listeliyoruz
            return View("OrderDetail",orderDetail);
        }

        //Sipariş Özeti
        [AllowAnonymous]
        public IActionResult OrderSummary()
        {
            int orderNo =  (int)TempData["orderNo"]; // CartController, CheckOut action ında belirlemiş olduğumuz rastgele sipariş numarasını TempData ile burada da kullanıyoruz.
            var order = c.Orders.Where(x => x.OrderNo == orderNo).ToList(); // Orders tablosundan sipariş numarasına göre siparişleri listeye alıyoruz.
            var books = c.Books.ToList();

            return View(order);
        }
    }
}
