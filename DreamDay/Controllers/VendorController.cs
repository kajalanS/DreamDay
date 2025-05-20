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

                CompanyName = vendor.VendorName,
                Description = vendor.Description,
                ContactEmail = vendor.User.Email,
                PhoneNumber = vendor.User.PhoneNumber,
                WebsiteURL = vendor.WebsiteURL,

                Vendor = vendor,
                RequestId = HttpContext.TraceIdentifier
            });
        }

        [HttpPost]
        [Route("Vendor/Profile/{id:guid}")]
        public IActionResult UpdateProfile(Guid id, VendorProfilePageModel model)
        {
            var vendor = Context.Vendors
                .Include(v => v.User) // Ensure User is included
                .FirstOrDefault(v => v.Id == id);

            if (vendor == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                vendor.VendorName = model.CompanyName!;
                vendor.Description = model.Description;
                vendor.User.Email = model.ContactEmail!;
                vendor.User.PhoneNumber = model.PhoneNumber!;
                vendor.WebsiteURL = model.WebsiteURL;

                Context.SaveChanges();
                return RedirectToAction("ManageProfile", new { id = vendor.Id });
            }

            // If ModelState is not valid, return the view with the model
            model.Vendor = vendor; // Pass the vendor object back to the view
            return View("ManageProfile", model);
        }
    }
}
