using DreamDay.Data;
using DreamDay.Database.Core.Enum;
using DreamDay.Models.View;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DreamDay.Controllers
{
    public class VendorController(ApplicationDbContext context) : Controller
    {
        public ApplicationDbContext Context { get; } = context;

        [HttpGet]
        public IActionResult Index()
        {
            var venueData = Context
                .Vendors
                .Include(x => x.User)
                .Include(x => x.Venues)
                .Include(x => x.PlannerVendors)
                // .Include(x => x.ContactInfo)
                .Include(x => x.VendorType)
                .Include(x => x.WeddingVendors)
                // .Include(x => x.Planner)
                .ToList();

            return View(new VendorPageModel
            {
                Authenticated = User.Identity?.IsAuthenticated ?? false,
                UserRole = User.IsInRole(UserType.Admin.ToString()) ? UserType.Admin : User.IsInRole(UserType.Couple.ToString()) ? UserType.Couple : UserType.Vendor,
                CurrentUser = Context.Users.FirstOrDefault(u => u.UserName == User.Identity!.Name),
                Vendors = venueData,
                RequestId = HttpContext.TraceIdentifier
            });
        }

        [HttpGet]
        [Route("Vendor/Profile/{id:guid}")]
        public IActionResult ManageProfile(Guid id)
        {
            var vendor = Context.Vendors
                .Include(x => x.User)
                .Include(x => x.Venues)
                .Include(x => x.PlannerVendors)
                // .Include(x => x.ContactInfo)
                .Include(x => x.VendorType)
                .Include(x => x.WeddingVendors)
                // .Include(x => x.Planner)
                .FirstOrDefault(v => v.Id == id);

            if (vendor == null)
            {
                return NotFound();
            }

            // return View(vendor);
            return View(new VendorProfilePageModel
            {
                Authenticated = User.Identity?.IsAuthenticated ?? false,
                UserRole = User.IsInRole(UserType.Admin.ToString()) ? UserType.Admin : User.IsInRole(UserType.Couple.ToString()) ? UserType.Couple : UserType.Vendor,
                CurrentUser = Context.Users.FirstOrDefault(u => u.UserName == User.Identity!.Name),
                Vendor = vendor,
                Vendors = Context.Vendors.ToList(),
                Weddings = Context.Weddings.ToList(),
                Venues = Context.Venues.ToList(),
                PlannerVendors = Context.PlannerVendors.ToList(),
                RequestId = HttpContext.TraceIdentifier
            });
        }
    }
}
