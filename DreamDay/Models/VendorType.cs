using System.ComponentModel.DataAnnotations;

namespace DreamDay.Models
{
  /// <summary>
  /// Represents a vendor type.
  /// </summary>
  public class VendorType
  {
    /// <summary>
    /// Gets or sets the unique identifier for the vendor type.
    /// </summary>
    [Key]
    public Guid Id { get; set; }

    /// <summary>
    /// Gets or sets the name of the vendor type.
    /// </summary>
    [Required]
    [MaxLength(100)]
    public string VendorTypeName { get; set; } = default!;

    /// <summary>
    /// Navigation property for vendors of this type.
    /// </summary>
    public ICollection<Vendor>? Vendors { get; set; }
  }
}
