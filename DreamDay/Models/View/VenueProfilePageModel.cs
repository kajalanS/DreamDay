
namespace DreamDay.Models.View
{
    public class VenueProfilePageModel : BaseViewModel
    {
        public Venue? Venue { get; set; }
        public List<Venue> VenuesList = [];
        public List<string> VenuesCategory = [];
        public List<string> VenuesCapacity = [];
    }
}
