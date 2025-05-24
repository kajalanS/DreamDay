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
            var userIdString = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
            if (string.IsNullOrEmpty(userIdString) || !Guid.TryParse(userIdString, out _))
            {
                return View(null);
            }

            var userId = Guid.Parse(userIdString);
            var user = Context.Users
                .Include(u => u.Profile)
                .Include(u => u.Couple)?.ThenInclude(c => c.Weddings)?.ThenInclude(w => w.Budget)
                .Include(u => u.Couple)?.ThenInclude(c => c.Weddings)?.ThenInclude(w => w.Venue)
                .Include(u => u.Couple)?.ThenInclude(c => c.Weddings)?.ThenInclude(w => w.WeddingVendors)
                .Include(u => u.Planner)
                .Include(u => u.Vendor)
                .Where(u => u.Id == userId)
                .FirstOrDefault();

            if (user == null)
            {
                return View(null);
            }

            ViewBag.Authenticated = authenticated;
            var currentUser = _userManager.GetRolesAsync(user).Result.FirstOrDefault();
            UserType userRole = currentUser != null
                ? (UserType)Enum.Parse(typeof(UserType), currentUser, true)
                : default;

            var isSetupCoupleAccount = Context.Couples.Any(c => c.UserId == user.Id);
            ViewBag.isSetup = isSetupCoupleAccount;

            user = Context.Users
                .Include(u => u.Profile)
                .Include(u => u.Couple)?.ThenInclude(c => c.Weddings)?.ThenInclude(w => w.Budget)
                .Include(u => u.Planner)
                .Include(u => u.Vendor)?.ThenInclude(v => v.WeddingVendors)?.ThenInclude(v => v.Wedding)?.ThenInclude(w => w.Vendors)
                .FirstOrDefault(u => u.Id == user.Id);

            var guestList = Context.Guests.Include(g => g.Wedding)
                .Where(g => g.Wedding!.Vendors!.Any(v => v.UserId == user.Id))
                .ToList().Select(x => new GuestViewModel()
                {
                    // Id = x.Id,
                    Name = x.GuestName,
                    Email = x.Email,
                    // PhoneNumber = x.PhoneNumber,
                    // RSVPStatus = x.RSVPStatus.ToString(),
                    RsvpStatus = x.Status,
                    // WeddingId = x.Wedding!.Id,
                    // WeddingDate = x.Wedding.Date.ToString("MMMM dd, yyyy", CultureInfo.InvariantCulture),
                    // WeddingVenue = x.Wedding.Venue?.Name ?? "No Venue Assigned"
                }).ToList();

            // if (user?.Couple != null && userRole == UserType.Couple)
            // {
            //     return View(new HomePageModel
            //     {
            //         Authenticated = authenticated,
            //         UserRole = (UserType?)userRole,
            //         CurrentUser = user,
            //         RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier,
            //         ErrorMessage = null
            //     });
            // }
            // else if (userRole == UserType.Vendor)
            // {


            //     return View(new HomePageModel
            //     {
            //         Authenticated = authenticated,
            //         UserRole = (UserType?)userRole,
            //         CurrentUser = user,
            //         VendorData = new(),
            //         RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier,
            //         ErrorMessage = null,
            //         GuestList = new GuestListViewModel()
            //         {
            //             Guests = guestList,
            //         }
            //     });
            // }

            return View(new HomePageModel
            {
                Authenticated = authenticated,
                UserRole = (UserType?)userRole,
                CurrentUser = user,
                GuestList = new GuestListViewModel()
                {
                    Guests = guestList,
                },
                // VendorData = vendorData,
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
