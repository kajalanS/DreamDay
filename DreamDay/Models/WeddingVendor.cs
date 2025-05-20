using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DreamDay.Models
{
  /// <summary>
  /// Represents a relationship between a wedding and a vendor.
  /// </summary>
  public class WeddingVendor
  {
    /// <summary>
    /// Gets or sets the unique identifier for the wedding-vendor relationship.
    /// </summary>
    [Key]
    public Guid Id { get; set; }

    /// <summary>
    /// Gets or sets the foreign key to the wedding.
    /// </summary>
    [Required]
    public Guid WeddingId { get; set; }

    /// <summary>
    /// Gets or sets the foreign key to the vendor.
    /// </summary>
    [Required]
    public Guid VendorId { get; set; }

    /// <summary>
    /// Navigation property to the associated wedding.
    /// </summary>
    [ForeignKey(nameof(WeddingId))]
    public Wedding Wedding { get; set; } = default!;

    /// <summary>
    /// Navigation property to the associated vendor.
    /// </summary>
    [ForeignKey(nameof(VendorId))]
    public Vendor Vendor { get; set; } = default!;
  }
}
