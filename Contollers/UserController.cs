using BookApp.Models.Authentication;
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
    public class UserController : Controller
    {
        readonly UserManager<AppUser> _userManager;
        readonly SignInManager<AppUser> _signInManager;
        readonly RoleManager<AppRole> _roleManager;
        public UserController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<AppRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        //Kullanıcı Kayıt
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(AppUserViewModel appUserViewModel)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = new AppUser
                {
                    UserName = appUserViewModel.UserName,
                    Email = appUserViewModel.Email,
                    NameSurname = appUserViewModel.NameSurname,
                    PhoneNumber = appUserViewModel.PhoneNumber,
                    Adress = appUserViewModel.Adress,

                };
                IdentityResult result = await _userManager.CreateAsync(appUser, appUserViewModel.Password);
                if (result.Succeeded)
                {
                    ModelState.Clear();
                    ViewBag.State = true;
                }
                else
                    result.Errors.ToList().ForEach(e => ModelState.AddModelError(e.Code, e.Description));
            }
            return View();
        }

        [Authorize(Roles = "Admin,Moderator")]
        //Kullanıcı Listeleme ve Arama
        public IActionResult Index()
        {
            return View(_userManager.Users); //Users tablosundaki tüm kullanıcıları listeliyoruz
        }

        // Giriş İşlemi
        public IActionResult Login(string ReturnUrl)
        {
            TempData["returnUrl"] = ReturnUrl;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)//model doğrulandıysa
            {
                AppUser user = await _userManager.FindByEmailAsync(model.Email);//kullanıcı epostasına göre kullanıcı bilgileri çekiyoruz.
                if (user != null)
                {
                    //İlgili kullanıcıya dair önceden oluşturulmuş bir Cookie varsa siliyoruz.
                    await _signInManager.SignOutAsync();
                    Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(user, model.Password, model.Persistent, model.Lock);

                    if (result.Succeeded) // Giriş başarılıysa..
                    {
                        await _userManager.ResetAccessFailedCountAsync(user); //Önceki hatalı girişler neticesinde +1 arttırılmış tüm değerleri 0(sıfır)a çekiyoruz.

                        return RedirectToAction("Index","Default");

                    }
                    else
                    {
                        await _userManager.AccessFailedAsync(user); //Eğer ki başarısız bir account girişi söz konusu ise AccessFailedCount kolonundaki değer +1 arttırılacaktır. 

                        int failcount = await _userManager.GetAccessFailedCountAsync(user); //Kullanıcının yapmış olduğu başarısız giriş deneme adedini alıyoruz.
                        if (failcount == 3)
                        {
                            await _userManager.SetLockoutEndDateAsync(user, new DateTimeOffset(DateTime.Now.AddMinutes(1))); //Eğer ki başarısız giriş denemesi 3'ü bulduysa ilgili kullanıcının hesabını 1 dakika kilitliyoruz.
                            ModelState.AddModelError("Locked", "Art arda 3 başarısız giriş denemesi yaptığınızdan dolayı hesabınız 1 dk kitlenmiştir.");
                        }
                        else
                        {
                            if (result.IsLockedOut)
                                ModelState.AddModelError("Locked", "Art arda 3 başarısız giriş denemesi yaptığınızdan dolayı hesabınız 1 dk kilitlenmiştir.");
                            else
                                ModelState.AddModelError("NotUser2", "E-posta veya şifre yanlış.");
                        }
                    }
                }
                else
                {
                    ModelState.AddModelError("NotUser", "Böyle bir kullanıcı bulunmamaktadır.");
                    ModelState.AddModelError("NotUser2", "E-posta veya şifre yanlış.");
                }
            }
            return View(model);
        }

        //Çıkış İşlemi
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync(); //Çerezleri temizleyerek kullanıcıyı oturumdan atıyoruz
            return RedirectToAction("Login");
        }

        //KULLANICI KAYIT SİLME
        [Authorize(Roles = "Admin,Moderator")]
        public async Task<IActionResult> DeleteUser(string id) // View > User > Index'teki actionlink'ten gönderilen id'ye göre işlem yapılıyor
        {
            var user = await _userManager.FindByIdAsync(id); // id parametresine göre kullanıcı bilgilerini alıyoruz
            List<string> userRoles = await _userManager.GetRolesAsync(user) as List<string>; //Seçilen kullanıcının rollerini listeliyoruz.

            if (userRoles.Contains("Admin")) //Eger userRoles listesinde Admin değeri varsa doğrudan index'e yönlendiriyoruz
            {
                TempData["ErrorMsg"] = "Admin yetkisi olan kullanıcı silinemez !";

                return RedirectToAction("index");
            }
            else
            {
                var result = await _userManager.DeleteAsync(user); // Kullanıcının rol listesinde Admin değeri yoksa kullanıcıyı veri tabanından siliyoruz
                if (result.Succeeded)
                {
                    //Başarılı..
                }
                return RedirectToAction("index");
            }
        }


    }
}
