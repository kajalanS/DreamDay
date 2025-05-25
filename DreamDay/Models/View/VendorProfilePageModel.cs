using DreamDay.Database.Core.Enum;
using DreamDay.Models;

namespace DreamDay.Models.View
{
    public class VendorProfilePageModel : BaseViewModel
    {
        public bool Authenticated { get; set; }
        public UserType UserRole { get; set; }
        public User? CurrentUser { get; set; }
        public Vendor Vendor { get; set; } = default!;
        public string RequestId { get; set; } = default!;

        public List<Vendor> Vendors = [];
        public List<Wedding> Weddings = [];
        public List<Venue> Venues = [];
        public List<PlannerVendor> PlannerVendors = [];

        public string CompanyName { get; set; } = default!;
        public string? Description { get; set; }
        public string ContactEmail { get; set; } = default!;
        public string PhoneNumber { get; set; } = default!;
        public string? WebsiteURL { get; set; }
    }
}
