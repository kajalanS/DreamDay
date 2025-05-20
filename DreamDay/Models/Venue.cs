using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DreamDay.Models
{
  /// <summary>
  /// Represents a wedding venue.
  /// </summary>
  public class Venue
  {
    /// <summary>
    /// Gets or sets the unique identifier for the venue.
    /// </summary>
    [Key]
    public Guid Id { get; set; }

    /// <summary>
    /// Gets or sets the optional vendor identifier managing the venue.
    /// </summary>
    public Guid? VendorId { get; set; }

    /// <summary>
    /// Gets or sets the name of the venue.
    /// </summary>
    [Required]
    [MaxLength(255)]
    public string VenueName { get; set; } = default!;

    /// <summary>
    /// Gets or sets the venue address.
    /// </summary>
    [MaxLength(255)]
    public string? Address { get; set; }

    /// <summary>
    /// Gets or sets the capacity of the venue.
    /// </summary>
    public int? Capacity { get; set; }

    /// <summary>
    /// Gets or sets the contact information.
    /// </summary>
    [MaxLength(255)]
    public string? ContactInfo { get; set; }

    /// <summary>
    /// Gets or sets the price range.
    /// </summary>
    [MaxLength(50)]
    public string? PriceRange { get; set; }

    /// <summary>
    /// Gets or sets the description.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Gets or sets the venue type.
    /// </summary>
    [MaxLength(100)]
    public string? VenueType { get; set; }

    /// <summary>
    /// Gets or sets the URL for the venue image.
    /// </summary>
    [MaxLength(255)]
    public string? ImageURL { get; set; }

    /// <summary>
    /// Navigation property to the managing vendor.
    /// </summary>
    [ForeignKey(nameof(VendorId))]
    public Vendor? Vendor { get; set; }

    /// <summary>
    /// Navigation property for weddings booked at this venue.
    /// </summary>
    public ICollection<Wedding>? Weddings { get; set; }
  }
}
