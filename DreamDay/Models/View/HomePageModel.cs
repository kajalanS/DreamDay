namespace DreamDay.Models.View
{
    public class HomePageModel : BaseViewModel
    {
        // public Vendor VendorData { get; set; } = new();
        public GuestListViewModel GuestList { get; set; } = new();
        public VendorPageModel VendorPage { get; set; } = new();
    }
}
