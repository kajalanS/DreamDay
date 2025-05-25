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
    public class VenueController(ApplicationDbContext context) : Controller
    {
        public ApplicationDbContext Context { get; } = context;

        [HttpGet]
        public IActionResult Index(string? searchQuery, string? SelectedCategories, string? SelectedCapacity)
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

            var venuesCapacity = new List<string> { "1-50", "51-100", "101-200", "201-300", "301-400", "401-500", "501-600", "601-700", "701-800", "801-900", "901-1000", "1001+" };
            venuesCapacity.Insert(0, "All Capacities");


            // Filtering by search query
            if (!string.IsNullOrWhiteSpace(searchQuery))
            {
                venueData = venueData
                    .Where(v => v.VenueName.Contains(searchQuery, StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }

            // Filtering by selected categories
            if (!string.IsNullOrWhiteSpace(SelectedCategories))
            {
                if (SelectedCategories.Trim().ToLowerInvariant() == "all venues")
                {
                    SelectedCategories = null; // Reset to null to include all venues
                }
                venueData = venueData
                    .Where(v => v.VenueType != null && v.VenueType.Trim().ToLowerInvariant() == SelectedCategories)
                    .ToList();
            }

            // Filtering by capacity
            if (!string.IsNullOrWhiteSpace(SelectedCapacity) && SelectedCapacity.Trim().ToLowerInvariant() != "all capacities")
            {
                var capacity = SelectedCapacity.Trim().ToLowerInvariant();
                int capacityMinValue = 0;
                int capacityMaxValue = 0;

                // Determine the capacity value based on the selected option
                if (capacity.Contains("+"))
                {
                    // For options like "1001+" or "501+"
                    capacityMaxValue = int.Parse(capacity.Replace("+", ""));
                }
                else if (capacity.Contains("-"))
                {
                    // For ranges like "1-50", "51-100", etc.
                    var parts = capacity.Split('-');
                    if (parts.Length == 2 && int.TryParse(parts[1], out int maxCapacity))
                    {
                        capacityMaxValue = maxCapacity;
                    }
                    if (parts.Length == 2 && int.TryParse(parts[0], out int minCapacity))
                    {
                        capacityMinValue = minCapacity;
                    }
                }

                venueData = venueData
                    .Where(v => v.Capacity >= capacityMinValue && v.Capacity <= capacityMaxValue)
                    .ToList();
            }

            ViewBag.SelectedCategories = SelectedCategories ?? "All Venues";
            ViewBag.SelectedCapacity = SelectedCapacity ?? "All Capacities";
            ViewBag.SearchQuery = searchQuery ?? "";

            return View(new VenuePageModel
            {
                Authenticated = User.Identity?.IsAuthenticated ?? false,
                UserRole = User.IsInRole(UserType.Admin.ToString()) ? UserType.Admin : User.IsInRole(UserType.Couple.ToString()) ? UserType.Couple : UserType.Vendor,
                CurrentUser = Context.Users.FirstOrDefault(u => u.UserName == User.Identity!.Name),
                Venues = venueData,
                VenuesCategory = venuesCategory,
                VenuesCapacity = venuesCapacity,
                RequestId = HttpContext.TraceIdentifier
            });
        }

        [HttpGet]
        [Route("Venue/{id:guid}")]
        public IActionResult Details(Guid id)
        {
            var venue = Context.Venues.FirstOrDefault(w => w.Id == id);
            if (venue == null)
            {
                return NotFound();
            }
            return View(venue);
        }

        [HttpGet]
        [Route("Venue/Create")]
        public IActionResult SetupVenue()
        {
            return View(new VenueCreateModel());
        }

        [HttpPost]
        [Route("Venue/Create")]
        public IActionResult SetupVenue(VenueCreateModel model)
        {
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

            if (ModelState.IsValid)
            {
                var venue = new Venue
                {
                    Id = Guid.NewGuid(),
                    VenueName = model.VenueName,
                    VenueType = model.VenueType,
                    Capacity = model.Capacity,
                    Address = model.Address,
                    Description = model.Description,
                    ImageURL = model.ImageURL,
                    ContactInfo = model.ContactInfo,
                    PriceRange = model.PriceRange,
                    VendorId = user.Vendor?.Id ?? Guid.Empty,
                };

                Context.Venues.Add(venue);
                Context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(model);
        }
    }
}
