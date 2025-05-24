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
    public class VendorController(ApplicationDbContext context) : Controller
    {
        public ApplicationDbContext Context { get; } = context;

        [HttpGet]
        public IActionResult Index()
        {
            List<Vendor> venueData = [];
            try
            {
                venueData = Context
                    .Vendors
                    .Include(x => x.User)
                    .Include(x => x.Venues)
                    // .Include(x => x.PlannerVendors)
                    // .Include(x => x.ContactInfo)
                    .Include(x => x.VendorType)
                    // .Include(x => x.WeddingVendors)
                    // .Include(x => x.Planner)
                    .ToList();
            }
            catch (FormatException ex)
            {
                // Log the error or handle it as needed
                // For now, return an error view or message
                return Content("Data error: One or more Vendor records have invalid GUIDs. Please check your database. " + ex.Message);
            }

            return View(new VendorPageModel
            {
                Authenticated = User.Identity?.IsAuthenticated ?? false,
                UserRole = User.IsInRole(UserType.Admin.ToString()) ? UserType.Admin : User.IsInRole(UserType.Couple.ToString()) ? UserType.Couple : UserType.Vendor,
                CurrentUser = Context.Users.FirstOrDefault(u => u.UserName == User.Identity!.Name),
                Vendors = venueData,
                VendorTypes = Context.VendorTypes.ToList(),
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

        [HttpGet]
        [Route("Vendor/Setup")]
        public IActionResult SetupVendor()
        {
            var user = Context.Users.FirstOrDefault(u => u.UserName == User.Identity!.Name);
            if (user == null)
            {
                return NotFound("User not found.");
            }

            var vendor = Context.Vendors.FirstOrDefault(v => v.UserId == user.Id);
            if (vendor != null)
            {
                return RedirectToAction("ManageProfile", new { id = vendor.Id });
            }

            return View(new VendorCreateModel());
        }

        [HttpPost]
        [Route("Vendor/Setup")]
        public IActionResult SetupVendor(VendorCreateModel model)
        {
            if (ModelState.IsValid)
            {
                var user = Context.Users.FirstOrDefault(u => u.UserName == User.Identity!.Name);
                if (user == null)
                {
                    return NotFound("User not found.");
                }

                var vendor = new Vendor
                {
                    UserId = user.Id,
                    VendorName = model.VendorName!,
                    Description = model.Description,
                    WebsiteURL = model.WebsiteURL,
                    ImageURL = model.ImageURL,
                    IsPlanner = model.IsPlanner,
                    VendorType = new VendorType
                    {
                        Category = model.Category,
                        VendorTypeName = model.Category.ToString()
                    },
                    PriceRange = model.PriceRange
                };

                Context.Vendors.AddRange(vendor);
                Context.SaveChanges();

                return RedirectToAction("ManageProfile", new { id = vendor.Id });
            }

            // If ModelState is not valid, return the view with the model
            return View(model);
        }
    }
}
