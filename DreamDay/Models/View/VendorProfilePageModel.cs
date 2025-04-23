
namespace DreamDay.Models.View
{
  public class VendorProfilePageModel : BaseViewModel
  {
    public Vendor Vendor = default!;
    public List<Vendor> Vendors = [];
    public List<Wedding> Weddings = [];
    public List<Venue> Venues = [];
    public List<PlannerVendor> PlannerVendors = [];
  }
}
