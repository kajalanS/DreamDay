using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DreamDay.Models
{
  /// <summary>
  /// Represents a wedding guest.
  /// </summary>
  public class Guest
  {
    /// <summary>
    /// Gets or sets the unique identifier for the guest.
    /// </summary>
    [Key]
    public Guid Id { get; set; }

    /// <summary>
    /// Gets or sets the foreign key to the wedding.
    /// </summary>
    [Required]
    public Guid WeddingId { get; set; }

    /// <summary>
    /// Gets or sets the guest's name.
    /// </summary>
    [Required]
    [MaxLength(255)]
    public string GuestName { get; set; } = default!;

    /// <summary>
    /// Gets or sets the RSVP status.
    /// </summary>
    [Required]
    [MaxLength(50)]
    public string Status { get; set; } = GuestStatus.Invited.ToString();

    /// <summary>
    /// Gets or sets the meal preference.
    /// </summary>
    [MaxLength(255)]
    public string? MealPreference { get; set; }

    /// <summary>
    /// Gets or sets the seating arrangement.
    /// </summary>
    [MaxLength(255)]
    public string? SeatingArrangement { get; set; }

    /// <summary>
    /// Gets or sets the phone number.
    /// </summary>
    [MaxLength(20)]
    public string? PhoneNumber { get; set; }

    /// <summary>
    /// Gets or sets the guest's email.
    /// </summary>
    [MaxLength(255)]
    public string? Email { get; set; }

    /// <summary>
    /// Navigation property to the associated wedding.
    /// </summary>
    [ForeignKey(nameof(WeddingId))]
    public Wedding Wedding { get; set; } = default!;
  }
}
