using Microsoft.AspNetCore.Mvc;
using Template_Design_Pattern_UpSchool.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Template_Design_Pattern_UpSchool.Models;
using System.Threading.Tasks;

namespace Template_Design_Pattern_UpSchool.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserLoginViewModel model)
        {
            var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, false, false);// 1. cookie e kaydetmesin, 2. hatalı girişi saymasın
            if(result.Succeeded)
            {
                return RedirectToAction("Index", "Default");
            }
            return View();
        }

    }
}
