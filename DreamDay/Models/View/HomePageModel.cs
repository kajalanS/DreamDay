namespace DreamDay.Models.View
{
    public class HomePageModel : BaseViewModel
    {
        public GuestListViewModel GuestList { get; set; } = new();
        public VendorPageModel VendorPage { get; set; } = new();
    }
}
