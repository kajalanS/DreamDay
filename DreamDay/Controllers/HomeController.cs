using DreamDay.Data;
using DreamDay.Database.Core.Enum;
using DreamDay.Models;
using DreamDay.Models.View;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Security.Claims;

namespace DreamDay.Controllers
{
    public class HomeController(ApplicationDbContext context, ILogger<HomeController> logger, SignInManager<User> SignInManager, UserManager<User> userManager) : Controller
    {
        public ApplicationDbContext Context { get; } = context;
        private readonly ILogger<HomeController> _logger = logger;
        private readonly SignInManager<User> _signInManager = SignInManager;
        private readonly UserManager<User> _userManager = userManager;

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

            var isSetupCoupleAccount = Context.Couples.Any(c => c.UserId == user.Id);
            ViewBag.isSetup = isSetupCoupleAccount;

            user = Context.Users
                .Include(u => u.Profile)
                .Include(u => u.Couple)?.ThenInclude(c => c.Weddings)
                .Include(u => u.Planner)
                .Include(u => u.Vendor)
                .FirstOrDefault(u => u.Id == user.Id);

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
