using DreamDay.Database.Core.Enum;
using DreamDay.Models;

namespace DreamDay.Models.View
{
    public class VendorCreateModel
    {
        public string VendorName { get; set; } = default!;
        public bool IsPlanner { get; set; } = false;
        public string? Description { get; set; }
        public string? WebsiteURL { get; set; }
        public string ImageURL { get; set; } = "/img/vendor-default.png";
        public VendorTypeCategory Category { get; set; } = default!;
        public decimal PriceRange { get; set; }
    }

    public class VendorProfilePageModel : BaseViewModel
    {
        public new bool Authenticated { get; set; }
        public new UserType UserRole { get; set; }
        public new User? CurrentUser { get; set; }
        public Vendor Vendor { get; set; } = default!;
        public new string? RequestId { get; set; } = default!;

        public VendorCreateModel VendorCreateModel { get; set; } = new();

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
