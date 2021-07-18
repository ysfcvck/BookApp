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
    [Authorize(Roles = "Admin")] //Bu controller a sadece Admin rolündeki kullanıcılar erişebilmektedir
    public class RoleController : Controller
    {
        readonly RoleManager<AppRole> _roleManager;
        readonly UserManager<AppUser> _userManager;
        public RoleController(RoleManager<AppRole> roleManager, UserManager<AppUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        // ROL LİSTELEME
        public IActionResult Index()
        {
            return View(_roleManager.Roles.ToList()); //Roles tablosundaki tüm rolleri listeliyoruz
        }

        // ROL ATAMA-YETKİ VERME
        public async Task<IActionResult> RoleAssign(string id) //Rol atama için View > User > Index'ten gelen id'ye göre işlem yapmaktayız
        {
            AppUser user = await _userManager.FindByIdAsync(id); //Id'ye göre kullanıcı bilgilerini alıyoruz
            List<AppRole> allRoles = _roleManager.Roles.ToList(); //Tüm rolleri listeliyoruz
            List<string> userRoles = await _userManager.GetRolesAsync(user) as List<string>; //user değişkenindeki kullanıcının rollerini listeliyoruz
            List<RoleAssignViewModel> assignRoles = new List<RoleAssignViewModel>();
            allRoles.ForEach(role => assignRoles.Add(new RoleAssignViewModel
            {
                HasAssign = userRoles.Contains(role.Name),
                RoleId = role.Id,
                RoleName = role.Name
            }));

            return View(assignRoles);
        }
        [HttpPost]
        public async Task<ActionResult> RoleAssign(List<RoleAssignViewModel> modelList, string id)
        {
            AppUser user = await _userManager.FindByIdAsync(id); // idye göre kullanıcı bilgilerini alıyoruz

            foreach (RoleAssignViewModel role in modelList)
            {
                if (role.HasAssign) 
                    await _userManager.AddToRoleAsync(user, role.RoleName); // İşaretlenen rolleri kullanıcının rol listesine ekliyoruz
                else
                    await _userManager.RemoveFromRoleAsync(user, role.RoleName); // İşaretlenen rolleri kullanıcının rol listesinden çıkartıyoruz
            }

            return RedirectToAction("index", "user");
        }

        // ROL EKLEME
        public async Task<IActionResult> CreateRole(string id)
        {
            if (id != null)
            {
                AppRole role = await _roleManager.FindByIdAsync(id);

                return View(new RoleViewModel
                {
                    Name = role.Name
                });
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateRole(RoleViewModel model, string id)
        {
            IdentityResult result = null;
            if (id != null)
            {
                AppRole role = await _roleManager.FindByIdAsync(id);
                role.Name = model.Name;
                result = await _roleManager.UpdateAsync(role);
            }
            else
                result = await _roleManager.CreateAsync(new AppRole { Name = model.Name, OlusturulmaTarihi = DateTime.Now });

            if (result.Succeeded)
            {
                //Başarılı...
                return RedirectToAction("index");
            }
            else
            {
                return View();
            }
        }
    }
}
