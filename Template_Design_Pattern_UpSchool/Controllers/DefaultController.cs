using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Template_Design_Pattern_UpSchool.DAL.Entities;

namespace Template_Design_Pattern_UpSchool.Controllers
{
    public class DefaultController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public DefaultController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _userManager.Users.ToListAsync();
            return View(values);
        }
    }
}
