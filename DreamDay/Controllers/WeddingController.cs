using System.Globalization;
using System.Security.Claims;
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
    public class WeddingController(ApplicationDbContext context, ILogger<WeddingController> logger) : Controller
    {
        public ApplicationDbContext Context { get; } = context;
        public ILogger<WeddingController> Logger { get; } = logger;

        public Dictionary<string, string> WeddingData = new Dictionary<string, string>();
        public List<string> FormDataList = ["date", "location", "totalBudget", "guestCount", "style", "color", "brideName", "groomName"];

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
            // Rebuild WeddingData from TempData for all keys

            foreach (var key in FormDataList)
            {
                if (TempData.ContainsKey(key))
                {
                    WeddingData[key] = TempData[key]?.ToString() ?? "";
                    // Re-store in TempData to persist for next request
                    TempData.Keep(key);
                }
            }

            ViewBag.CurrentStep = step;
            ViewBag.WeddingData = WeddingData;
            return View("WeddingSetup");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Setup(IFormCollection formData, int step)
        {
            foreach (var key in FormDataList)
            {
                if (TempData.ContainsKey(key))
                {
                    WeddingData[key] = TempData[key]?.ToString() ?? "";
                    TempData.Keep(key);
                }
            }

            if (!ModelState.IsValid)
            {
                ViewBag.CurrentStep = step;
                ViewBag.WeddingData = WeddingData;
                return View("WeddingSetup", formData);
            }

            // Store current step's form data in TempData and WeddingData
            foreach (var key in FormDataList)
            {
                Logger.LogInformation("TempData: {TempData}", TempData[key]);
                Logger.LogInformation("FormData: {FormData}", formData[key]);
                Logger.LogInformation("Form Key: {Key}", key);
                if (formData.ContainsKey(key) && !string.IsNullOrEmpty(formData[key]))
                {
                    TempData[key] = formData[key][0];

                    if (key == "date")
                    {
                        // In controller
                        if (DateTime.TryParse((string?)TempData[key], out DateTime parsedDate))
                        {
                            TempData["date"] = parsedDate.ToString("yyyy-MM-dd");
                        }

                        // DateTime date = DateTime.Parse((string)TempData[key]);
                        // string formatted = date.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
                        // TempData[key] = formatted;
                    }

                    WeddingData[key] = formData[key][0];
                }
            }

            if (step < 3)
            {
                return RedirectToAction("Setup", new { step = step + 1 });
            }
            else
            {
                // Rebuild WeddingData from TempData before final processing
                foreach (var key in TempData.Keys)
                {
                    WeddingData[key] = TempData[key]?.ToString() ?? "";
                }

                Logger.LogInformation("Wedding Data: {WeddingData}", WeddingData);

                Guid userId = Guid.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty);
                var CoupleId = new Guid();
                if (Context.Couples.Any(c => c.UserId == userId))
                {
                    CoupleId = Context.Couples.FirstOrDefault(c => c.UserId == userId)?.Id ?? Guid.NewGuid();
                }
                else
                {
                    CoupleId = Guid.NewGuid();
                }

                var couple = new Couple
                {
                    Id = CoupleId,
                    BrideName = WeddingData["brideName"],
                    GroomName = WeddingData["groomName"],
                    EngagementDate = DateTime.Parse(WeddingData["date"]),
                    UserId = userId
                };

                string weddingName = $"{WeddingData["brideName"]} & {WeddingData["groomName"]}'s Wedding";

                var wedding = new Wedding
                {
                    CoupleId = CoupleId,
                    WeddingName = weddingName,
                    Budget = new Budget
                    {
                        Category = "Wedding",
                        AllocatedAmount = decimal.Parse(WeddingData["totalBudget"]),
                        ActualAmount = 0.00M,
                        Description = "Total budget for the wedding"
                    },
                    WeddingDate = DateTime.Parse(WeddingData["date"]),
                    Theme = WeddingData["style"],
                    NumberOfGuests = int.Parse(WeddingData["guestCount"]),
                    Status = WeddingStatus.Planning.ToString(),
                    Couple = couple
                };


                // store wedding data in database
                if (Context.Weddings.Any(w => w.CoupleId == CoupleId))
                {
                    // Update existing wedding
                    var existingWedding = Context.Weddings.FirstOrDefault(w => w.CoupleId == CoupleId);
                    if (existingWedding != null)
                    {
                        existingWedding.WeddingName = weddingName;
                        existingWedding.WeddingDate = DateTime.Parse(WeddingData["date"]);
                        existingWedding.Theme = WeddingData["style"];
                        existingWedding.NumberOfGuests = int.Parse(WeddingData["guestCount"]);
                        Context.SaveChanges();
                    }
                }
                else
                {
                    // Add new wedding
                    Context.Couples.Add(couple);
                    Context.Weddings.AddRange(wedding);
                    Context.SaveChanges();
                }

                // Context.Couples.Add(couple);
                // Context.Weddings.Add(wedding);
                // Context.SaveChanges();

                // Clear TempData
                TempData.Clear();

                // TODO: Save WeddingData to database
                return RedirectToAction("Index", "Home");
            }
        }
    }
}
