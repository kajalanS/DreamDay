namespace DreamDay.Models.View
{
    public class AdminStates
    {
        public int Couples { get; set; } = 0;
        public int VerifiedVendor { get; set; } = 0;
        public int WeddingThisMonth { get; set; } = 0;
        public int PendingVendors { get; set; } = 0;
    }

    public class HomePageModel : BaseViewModel
    {
        // public Vendor VendorData { get; set; } = new();
        public GuestListViewModel GuestList { get; set; } = new();
        public VendorPageModel VendorPage { get; set; } = new();
        public AdminStates AdminStates { get; set; } = new();

    }
}
