using DreamDay.Attributes;
using DreamDay.Data;
using DreamDay.Database.Core.Enum;
using DreamDay.Models.View;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DreamDay.Controllers
{
    [FullUserAuthorize]
    public class VenueController(ApplicationDbContext context) : Controller
    {
        public ApplicationDbContext Context { get; } = context;

        [HttpGet]
        public IActionResult Index(string? searchQuery, List<string>? SelectedCategories)
        {
            var venueData = Context
                .Venues
                .Include(x => x.Weddings)
                .Include(x => x.Vendor)
                .ToList();
            var venuesCategoryHashSet = new HashSet<string> { "Banquet Hall", "Beach", "Garden", "Hotel", "Restaurant", "Outdoor", "Indoor", "Other" };
            venuesCategoryHashSet.UnionWith([.. venueData.Select(v => v.VenueType).Where(v => !string.IsNullOrEmpty(v)).Cast<string>().Distinct()]);
            var venuesCategory = new List<string>(venuesCategoryHashSet);
            venuesCategory.Insert(0, "All Venues");


            // Filtering by search query
            if (!string.IsNullOrWhiteSpace(searchQuery))
            {
                venueData = venueData
                    .Where(v => v.VenueName.Contains(searchQuery, StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }

            // Filtering by selected categories
            if (SelectedCategories != null && SelectedCategories.Any())
            {
                venueData = venueData
                    .Where(v => v.VenueType != null)
                    // .Where(v=> )
                    .Where(v => v.VenueType != null && SelectedCategories.Contains(v.VenueType.ToString()))
                    .ToList();
            }

            ViewBag.SelectedCategories = SelectedCategories ?? new List<string>();
            ViewBag.SearchQuery = searchQuery ?? "";

            return View(new VenuePageModel
            {
                Authenticated = User.Identity?.IsAuthenticated ?? false,
                UserRole = User.IsInRole(UserType.Admin.ToString()) ? UserType.Admin : User.IsInRole(UserType.Couple.ToString()) ? UserType.Couple : UserType.Vendor,
                CurrentUser = Context.Users.FirstOrDefault(u => u.UserName == User.Identity!.Name),
                Venues = venueData,
                VenuesCategory = venuesCategory,
                RequestId = HttpContext.TraceIdentifier
            });
        }

        [HttpGet]
        [Route("Venue/{id:guid}")]
        public IActionResult Details(Guid id)
        {
            var wedding = Context.Venues.FirstOrDefault(w => w.Id == id);
            if (wedding == null)
            {
                return NotFound();
            }
            return View(wedding);
        }
    }
}
