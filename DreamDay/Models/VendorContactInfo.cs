using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DreamDay.Models
{
  /// <summary>
  /// Represents vendor contact information.
  /// </summary>
  public class VendorContactInfo
  {
    /// <summary>
    /// Gets or sets the unique identifier for the vendor contact info.
    /// </summary>
    [Key]
    public Guid Id { get; set; }

    /// <summary>
    /// Gets or sets the foreign key to the associated vendor.
    /// </summary>
    [Required]
    public Guid VendorId { get; set; }

    /// <summary>
    /// Gets or sets the contact name.
    /// </summary>
    [MaxLength(255)]
    public string? ContactName { get; set; }

    /// <summary>
    /// Gets or sets the phone number.
    /// </summary>
    [MaxLength(20)]
    public string? PhoneNumber { get; set; }

    /// <summary>
    /// Gets or sets the email.
    /// </summary>
    [MaxLength(255)]
    public string? Email { get; set; }

    /// <summary>
    /// Gets or sets the address.
    /// </summary>
    [MaxLength(255)]
    public string? Address { get; set; }

    /// <summary>
    /// Navigation property to the associated vendor.
    /// </summary>
    [ForeignKey(nameof(VendorId))]
    public Vendor Vendor { get; set; } = default!;
  }
}
