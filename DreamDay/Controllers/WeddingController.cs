using DreamDay.Attributes;
using DreamDay.Data;
using DreamDay.Database.Core.Enum;
using DreamDay.Models;
using DreamDay.Models.View;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DreamDay.Controllers
{
    [FullUserAuthorize]
    public class WeddingController(ApplicationDbContext context) : Controller
    {
        public ApplicationDbContext Context { get; } = context;

        [HttpGet]
        public IActionResult Index()
        {
            var weddingData = Context
                .Weddings
                .Include(x => x.Couple)
                .Include(x => x.Venue)
                .Include(x => x.Budget)
                .ToList();

            return View(new WeddingPageModel
            {
                Authenticated = User.Identity?.IsAuthenticated ?? false,
                UserRole = User.IsInRole(UserType.Admin.ToString()) ? UserType.Admin : User.IsInRole(UserType.Couple.ToString()) ? UserType.Couple : UserType.Vendor,
                CurrentUser = Context.Users.FirstOrDefault(u => u.UserName == User.Identity!.Name),
                Weddings = weddingData,
                RequestId = HttpContext.TraceIdentifier
            });
        }

        [HttpGet]
        [Route("Wedding/{id:guid}")]
        public IActionResult Details(Guid id)
        {
            var wedding = Context.Weddings
                .Include(w => w.Guests)
                .Include(w => w.Venue)
                .Include(w => w.Tasks)
                .Include(w => w.Budget)
                    // .ThenInclude(b => b!.Items)
                .Include(w => w.Vendors)
                .AsNoTracking()
                .FirstOrDefault(w => w.Id == id);

            if (wedding == null)
            {
                return NotFound();
            }

            var guestStats = new
            {
                Total = wedding.Guests?.Count ?? 0,
                Attending = wedding.Guests?.Count(g => g.Status.Equals("confirmed", StringComparison.OrdinalIgnoreCase)) ?? 0,
                Pending = wedding.Guests?.Count(g => g.Status.Equals("pending", StringComparison.OrdinalIgnoreCase)) ?? 0,
                Declined = wedding.Guests?.Count(g => g.Status.Equals("declined", StringComparison.OrdinalIgnoreCase)) ?? 0
            };

            ViewBag.GuestStats = guestStats;

            return View(wedding);
        }

        [HttpGet]
        [Route("Wedding/GuestList/{id:guid}")]
        public IActionResult GestList(Guid id)
        {
            var model = new HomePageModel
            {
                GuestList = new GuestListViewModel
                {
                    Guests = new List<GuestViewModel>(),
                    GuestStats = new GuestStatsViewModel
                    {
                        Total = 0,
                        Confirmed = 0,
                        Pending = 0,
                        Declined = 0
                    },
                    AllGroups = new List<string> { "Family", "Friends", "Work", "Other" },
                    SearchQuery = "",
                    SelectedGroup = "all"
                }
            };

            return View(model);
        }

        [HttpGet]
        public IActionResult Setup(int step = 0)
        {
            ViewBag.CurrentStep = step;
            return View("WeddingSetup");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Setup(IFormCollection formData, int step)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.CurrentStep = step;
                return View("WeddingSetup", formData);
            }

            // Store form data in TempData
            foreach (var key in formData.Keys)
            {
                TempData[key] = formData[key];
            }

            if (step < 2)
            {
                return RedirectToAction("Setup", new { step = step + 1 });
            }
            else
            {
                var weddingData = new Dictionary<string, string>();
                foreach (var key in TempData.Keys)
                {
                    weddingData[key] = TempData[key]?.ToString() ?? "";
                }

                // Clear TempData
                TempData.Clear();

                // TODO: Save weddingData to database

                return RedirectToAction("Index", "Home");
            }
        }
    }
}
