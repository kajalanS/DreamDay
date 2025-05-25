
namespace DreamDay.Models.View
{

    public class VenueCreateModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid? VendorId { get; set; }
        public string VenueName { get; set; } = default!;
        public string? Address { get; set; }
        public int Capacity { get; set; }
        public string? ContactInfo { get; set; }
        public decimal PriceRange { get; set; }
        public string? Description { get; set; }
        public string? VenueType { get; set; }
        public string? ImageURL { get; set; }
    }
    public class VenuePageModel : BaseViewModel
    {
        public List<Venue> Venues = [];
        public List<string> VenuesCategory = [];
        public List<string> VenuesCapacity = [];
    }
}
