
namespace DreamDay.Models.View
{
  public class AdminPageModel : BaseViewModel
  {
    public List<Venue> Venues { get; set; } = [];
    public List<Vendor> Vendors { get; set; } = [];

  }
}
