using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApp.Contollers
{
    public class AuthorityController : Controller
    {
        // Erişim yetkisi olmayan kullanıcıların yönlendirileceği sayfa
        public IActionResult Page()
        {
            return View();
        }
    }
}
