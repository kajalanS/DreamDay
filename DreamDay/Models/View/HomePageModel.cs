namespace DreamDay.Models.View
{
    public class HomePageModel : BaseViewModel
    {
        public GuestListViewModel GuestList { get; set; } = new();
    }
}
