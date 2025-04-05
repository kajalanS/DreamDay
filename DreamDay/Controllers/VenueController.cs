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
        public IActionResult Index()
        {
            var venueData = Context
                .Venues
                .Include(x => x.Weddings)
                .Include(x => x.Vendor)
                .ToList();

            return View(new VenuePageModel
            {
                Authenticated = User.Identity?.IsAuthenticated ?? false,
                UserRole = User.IsInRole(UserType.Admin.ToString()) ? UserType.Admin : User.IsInRole(UserType.Couple.ToString()) ? UserType.Couple : UserType.Vendor,
                CurrentUser = Context.Users.FirstOrDefault(u => u.UserName == User.Identity!.Name),
                Venues = venueData,
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
