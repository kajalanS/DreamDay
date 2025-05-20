using DreamDay.Database.Core.Enum;
using DreamDay.Models;
using DreamDay.Models.View;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DreamDay.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;

        public HomeController(ILogger<HomeController> logger, SignInManager<User> SignInManager, UserManager<User> userManager)
        {
            _logger = logger;
            _signInManager = SignInManager;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var authenticated = _signInManager.IsSignedIn(User);
            var user = _userManager.GetUserAsync(User).Result;
            if (user == null)
            {
                return View(null);
            }

            ViewBag.Authenticated = authenticated;
            var currentUser = _userManager.GetRolesAsync(user).Result.FirstOrDefault();
            var userRole = Enum.Parse(typeof(UserType), currentUser, true);

            return View(new HomePageModel
            {
                Authenticated = authenticated,
                UserRole = (UserType?)userRole,
                CurrentUser = user,
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier,
                ErrorMessage = null
            });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
