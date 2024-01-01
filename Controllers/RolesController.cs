using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace HastaneRandevuSistemi.Controllers
{
    public class RolesController : Controller
    {
         private readonly RoleManager<IdentityRole> _manager;
       public RolesController(RoleManager<IdentityRole> roleManager) 
        { 
            _manager = roleManager;
        }
        public IActionResult Index()
        {
            var roles=_manager.Roles;
            return View(roles);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var roles = _manager.Roles;
            return View();
        }

        public IActionResult Create(IdentityRole role)
        {
            // rol var mı kontrol et
            if(!_manager.RoleExistsAsync(role.Name).GetAwaiter().GetResult())
            {
                _manager.CreateAsync(new IdentityRole( role.Name)).GetAwaiter().GetResult();
            }

            return RedirectToAction("Index");
        }


  

    }
}
