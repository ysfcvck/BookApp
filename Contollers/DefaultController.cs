using BookApp.Models.Authentication;
using BookApp.Models.Context;
using BookApp.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApp.Contollers
{
    public class DefaultController : Controller
    {
        readonly UserManager<AppUser> _userManager;
        Context c = new Context();
        public DefaultController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        // Kullanıcının sepetindeki ürün sayısı
        public void CartCount()
        {
            if (User.Identity.IsAuthenticated)
            {
                var userId = _userManager.GetUserId(HttpContext.User).ToString(); //Giriş yapan kullanıcı id sini alıyoruz.
                var cart = c.Carts.Where(x => x.UserId == Int32.Parse(userId)).ToList();//Giriş yapan kullanıcının id sine göre sepetteki ürünleri listeye alıyoruz.
                ViewBag.CartCount = cart.Count(); //Liste uzunluğunu viewbag de tutuyoruz.
            }
        }
        
        public IActionResult Index()
        {
            CartCount(); 
            var books = c.Books.ToList();
            return View(books);
        }

        //Kitap listeleme - Kitap adına ve yazara göre arama
        public IActionResult Books(string searchBook, string searchWriter) // View > Shared > _Layout'taki Html.TextBox'tan gelen değerler (searckBook,searchWriter)
        {
            CartCount();
            var categories = c.Categories.ToList(); // Categories tablosundaki tüm kategorileri listeliyoruz
            var genres = c.Genres.ToList(); // Genres tablosundaki tüm türleri listeliyoruz
            var books = c.Books.ToList(); // Books tablosundaki tüm kitapları listeliyoruz

            if (!string.IsNullOrEmpty(searchBook))//parametreden gelen değer boş değilse
            {
                books = books.Where(x => x.Name.ToLower().Contains(searchBook)).ToList();//parametreden gelen değerle kitaplar tablosunda kitap adına göre listeleme yapıyoruz
            }
            if (!string.IsNullOrEmpty(searchWriter))//parametreden gelen değer boş değilse
            {
                books = books.Where(x => x.Writer.ToLower().Contains(searchWriter)).ToList();//parametreden gelen değerle kitaplar tablosunda yazar adına göre listeleme yapıyoruz
            }
            return View(books);
        }

        // Kategoriye göre listeleme
        public IActionResult BookCategory(int id) // View > Default > Component > CategoryGetList > Default'taki linkten gelen Id değerine göre işlem yapıyoruz
        {
            CartCount();
            var category = c.Categories.ToList(); 
            var books = c.Books.ToList();
            var categoryName = c.Categories.Where(x => x.CategoryId == id).Select(x => x.CategoryName).SingleOrDefault(); //Id'ye göre Categories tablosundan kategori adlarını listeliyoruz

            ViewBag.categoryName = categoryName; // Listelediğimiz kategorileri adlarını viewBag aracılığıyla View > Default > BookCategory'de başlık olarak kullanıyoruz
            ViewBag.x = id;
            return View(books);
        }

        // Türe göre kitap listeleme
        public IActionResult BookGenre(int id) // View > Default > Component > GenreGetList > Default'taki linkten gelen Id değerine göre işlem yapıyoruz
        {
            CartCount();
            var genre = c.Genres.ToList();
            var books = c.Books.ToList();
            var genreName = c.Genres.Where(x => x.GenreId == id).Select(x => x.GenreName).SingleOrDefault(); //Id'ye göre Genres tablosundan tür adlarını listeliyoruz

            ViewBag.genreName = genreName; // Listelediğimiz tür adlarını viewBag aracılığıyla View > Default > BookGenre'de başlık olarak kullanıyoruz
            ViewBag.x = id;
            return View(books);
        }

        // Kitap detayı
        public IActionResult BookDetails(int id) //Listelenen kitapların isim ya da resim üzerindeki linten gelen id ile kitabın tetaylarına ulaşıyoruz
        {
            CartCount();
            var categories = c.Categories.ToList();
            var genres = c.Genres.ToList();
            var books = c.Books.ToList();

            ViewBag.x = id;
            return View(books);
        }      
    }
}
