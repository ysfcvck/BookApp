using BookApp.Models.Authentication;
using BookApp.Models.Context;
using BookApp.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApp.Contollers
{
    [Authorize]
    public class CartController : Controller
    {
        readonly UserManager<AppUser> _userManager;
        Context c = new Context();
        public CartController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
      
        public void Cart()
        {
            var userId = _userManager.GetUserId(HttpContext.User).ToString(); //Giriş yapan kullanıcı id sini alıyoruz.
            var cart = c.Carts.Where(x => x.UserId == Int32.Parse(userId)).ToList();//Giriş yapan kullanıcının id sine göre sepetteki ürünleri listeye alıyoruz.
            ViewBag.userId = userId;
            ViewBag.CartCount = cart.Count(); //Liste uzunluğunu viewbag de tutuyoruz.

            if (cart.Count() > 0) //Sepette ürün varsa..
            {
                var totalPrice = Math.Round(cart.Sum(x => x.TotalPrice), 2); //Sepetteki ürünlerin fiyatını topluyoruz.
                ViewBag.totalPrice = totalPrice;
            }
            else
                ViewBag.totalPrice = 0;
        }

        //Sepet listesi
        public IActionResult Index()
        {
            var userId = _userManager.GetUserId(HttpContext.User).ToString(); //Giriş yapan kullanıcı id sini alıyoruz.
            ViewBag.userId = userId;
            var cart = c.Carts.Where(x => x.UserId == Int32.Parse(userId)).ToList();//Giriş yapan kullanıcının id sine göre sepetteki ürünleri listeye alıyoruz.
            ViewBag.CartCount = cart.Count(); //Liste uzunluğunu viewbag de tutuyoruz.

            if (cart.Count() > 0) //Sepette ürün varsa..
            {
                var totalPrice = Math.Round(cart.Sum(x => x.TotalPrice), 2); //Sepetteki ürünlerin fiyatını topluyoruz.
                ViewBag.totalPrice = totalPrice;
            }
            else
                ViewBag.totalPrice = 0;

            return View(cart);
        }

        //Sepete ekle
        public IActionResult CartAdd(int id)
        {
            var userID = _userManager.GetUserId(HttpContext.User).ToString();
            var book = c.Books.Find(id); // Id ye göre kitabı seçiyoruz.
            var crt = new CartViewModel
            {
                UserId = Int32.Parse(userID),
                BookId = book.BookId,
                BookName = book.Name,
                Quantity = 1,
                Price = book.Price,
                TotalPrice = book.Price,
                ImageURL = book.ImageURL
            };
            c.Carts.Add(crt);
            c.SaveChanges();
            return Redirect("/Default/BookDetails/" + id);
        }
        public IActionResult CartAddd(int id)
        {
            var userID = _userManager.GetUserId(HttpContext.User).ToString(); //Giriş yapan kullanıcı id sini alıyoruz.
            var book = c.Books.Find(id); // Id ye göre kitabı seçiyoruz.
            var crt = new CartViewModel
            {
                UserId = Int32.Parse(userID),
                BookId = book.BookId,
                BookName = book.Name,
                Quantity = 1,
                Price = book.Price,
                TotalPrice = book.Price,
                ImageURL = book.ImageURL
            };
            c.Carts.Add(crt);
            c.SaveChanges();
            return Redirect("/Cart/Index/");
        }

        // Sepetteki ürünü silme
        public IActionResult CartRemove(int Id) // View > Cart > Index'teki actionlink'ten gelen Id değerine göre işlem yapacağız
        {
            var cart = c.Carts.Find(Id); //Id'ye göre Carts tablosundan verileri çekiyoruz
            c.Carts.Remove(cart); //Sepetteki seçili ürünü siliyoruz
            c.SaveChanges();
            return RedirectToAction("index");
        }

        //Ürün bilgisi getir
        public IActionResult CartGet(int id) // View > Cart > Index'teki link'ten gelen Id değerine göre işlem yapacağız
        {
            var product = c.Carts.Find(id); //Idye göre Carts tablosundaki ürün bilgilerini alıyoruz 
            return View("CartGet", product);
        }

        public IActionResult CartUpdate(CartViewModel crt)
        {
            var x = c.Carts.Find(crt.Id);
            if (TryValidateModel(crt,nameof(crt)))
            {
                x.Id = crt.Id;
                x.UserId = crt.UserId;
                x.BookId = crt.BookId;
                x.BookName = crt.BookName;
                x.Quantity = crt.Quantity;
                x.Price = crt.Price;
                x.TotalPrice = Math.Round(crt.Quantity * crt.Price,2); // Girilen adet ile ürün fiyatını çarpıyoruz ve virgülden sonraki 2 haneyi alıyoruz.
                x.ImageURL = crt.ImageURL;
                c.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("CartGet", x);
        }

        public IActionResult Checkout()
        {
            var userId = _userManager.GetUserId(HttpContext.User).ToString(); //Giriş yapan kullanıcı id sini alıyoruz.
            var cart = c.Carts.Where(x => x.UserId == Int32.Parse(userId)).ToList();//Giriş yapan kullanıcının id sine göre sepetteki ürünleri listeye alıyoruz.
            ViewBag.CartCount = cart.Count(); //Sepet uzunluğunu viewBag'te tutuyoruz. View > Shared > _Layout'ta sepet içerisinde kullanacağız
            if (cart.Count() > 0)
            {
                var totalPrice = Math.Round(cart.Sum(x => x.TotalPrice), 2); //Sepetteki ürünlerin fiyatını topluyoruz.
                ViewBag.totalPrice = totalPrice;
            }
            else
                ViewBag.totalPrice = 0;
            return View();
        }

        // Sipariş oluşturma
        [HttpPost]
        public IActionResult Checkout(OrderViewModel o,string CardNo)
        {
            if (ModelState.IsValid)
            {
                //kart numarasının 16 haneli olup olmadığını buluyoruz.
                static bool cardLength(string CardNo)
                {
                    if (CardNo.Length == 16)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

                // Luhn algoritması ile kredi kartı doğrulaması
                // Geçerli kart numarası :  4508034508034509

                // Tek haneli basamakların hesaplanması
                static int digits(int p)
                {
                    int sum = 0;
                    while (p > 0)
                    {
                        sum += p % 10;
                        p /= 10;
                    }
                    return sum;
                }

                if (CardNo!=null)
                {
                    if (cardLength(CardNo) == true) //Kart numarası 16 haneliyse..
                    {
                        int odd, even;
                        odd = 0; //Tek hanelerin toplamını tutacağız.
                        even = 0; //Çift hanelerin toplamını tutacağız.

                        for (int i = 0; i < CardNo.Length; i++) // Kart numarasındaki tüm haneleri döndürüyoruz
                        {
                            int number = Int32.Parse(CardNo[i].ToString()); //Kart numarasındaki 'i'nci rakamı tutuyoruz.

                            if (i % 2 == 0) //Kart numarasının hane sayısı tekse..
                            {
                                odd += digits(number * 2);
                            }
                            else // Kart numarasının basamak sayısı çiftse..
                            {
                                even += number;
                            }
                        }

                        int result = odd + even; // Çift ve tek hanelerin toplamını buluyoruz.
                        if (result % 10 == 0) // Toplamın 10'a bölümünden kalan 0(sıfır) ise kart geçerlidir..
                        {
                            //kart geçerliyse
                            var userId = _userManager.GetUserId(HttpContext.User).ToString(); //Giriş yapan kullanıcı id sini alıyoruz.
                            var cart = c.Carts.Where(x => x.UserId == Int32.Parse(userId)).ToList();//Giriş yapan kullanıcının id sine göre sepetteki ürünleri listeye alıyoruz.
                            Random random = new Random();
                            int orderNo = random.Next(12345678, 99999999); // Belirtilen sayılar arasında rastgele sipariş numarası oluşturuyoruz.
                            TempData["orderNo"] = orderNo; // Sipariş numarasını taşımak için tempdata içerisinde oluşturulan sayıyı tutuyoruz.
                            int row = 0;

                            foreach (var item in cart) //Sepetteki kullanıcıya ait ürünleri orders tablosuna taşıyoruz
                            {
                                var order = new OrderViewModel
                                {
                                    BookId = cart[row].BookId,
                                    OrderDate = DateTime.Now,
                                    State = false,
                                    Price = cart[row].TotalPrice,
                                    Quantity = cart[row].Quantity,
                                    UserId = cart[row].UserId,
                                    Name = o.Name,
                                    Adress = o.Adress,
                                    City = o.City,
                                    Phone = o.Phone,
                                    Email = o.Email,
                                    Note = o.Note,
                                    OrderNo = orderNo
                                };
                                c.Orders.Add(order);
                                row++;
                            }

                            foreach (var item in cart) //Books tablosundaki ürünün stok değerini sepetteki değer kadar azaltıyoruz
                            {
                                var product = c.Books.FirstOrDefault(x => x.BookId == item.BookId); //Kitap id'sine göre kitapları listeye alıyoruz.

                                if (product != null)
                                {
                                    product.Stock = product.Stock - item.Quantity; //Listeye aldığımız kitapların stoklarını sepetteki miktara göre azaltıyoruz.
                                }
                            }

                            c.Carts.RemoveRange(cart); // Sepetteki kullanıcıya ait ürünleri siliyoruz
                            c.SaveChanges();
                            return RedirectToAction("OrderSummary","Order");
                        }

                        else
                        {
                            TempData["CardError"] = "Lütfen geçerli bir kart numarası giriniz."; //Geçersiz kart
                        }
                    }
                    else
                    {
                        TempData["CardError"] = "Kart numarası 16 haneli olmalıdır."; //Kart numarası 16 hane değil.
                    } 
                }
            }
            Cart();
            return View();
        }
    }
}