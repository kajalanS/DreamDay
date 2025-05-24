using System.ComponentModel.DataAnnotations;

namespace DreamDay.Models
{
    public class GuestListViewModel
    {
        public Guid WeddingId { get; set; } // Added WeddingId
        // public List<GuestViewModel> Guests { get; set; } = new List<GuestViewModel>();
        public List<GuestViewModel> Guests { get; set; } = new List<GuestViewModel>();
        public GuestStatsViewModel GuestStats { get; set; } = new GuestStatsViewModel();
        public string SearchQuery { get; set; } = string.Empty;
        public string SelectedGroup { get; set; } = "all";
        public List<string> AllGroups { get; set; } = new List<string> { "Family", "Friends", "Work", "Other" };
        public NewGuestInputModel NewGuest { get; set; } = new NewGuestInputModel { Name = string.Empty, Email = string.Empty };
    }

    public class GuestViewModel
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public string? Phone { get; set; }
        public required string RsvpStatus { get; set; } = "pending";
        public bool PlusOne { get; set; }
        public int? TableAssignment { get; set; }
        public string? Group { get; set; }
    }

    public class GuestStatsViewModel
    {
        public int Total { get; set; }
        public int Confirmed { get; set; }
        public int Pending { get; set; }
        public int Declined { get; set; }
    }

    public class NewGuestInputModel
    {
        public Guid WeddingId { get; set; } // Added WeddingId
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string? Phone { get; set; }
        public string? Group { get; set; }
        public bool PlusOne { get; set; }
    }
}
