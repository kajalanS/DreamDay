using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DreamDay.Models
{
  /// <summary>
  /// Represents a relationship between a planner and a vendor.
  /// </summary>
  public class PlannerVendor
  {
    /// <summary>
    /// Gets or sets the unique identifier for the planner-vendor relationship.
    /// </summary>
    [Key]
    public Guid Id { get; set; }

    /// <summary>
    /// Gets or sets the foreign key to the planner.
    /// </summary>
    [Required]
    public Guid PlannerId { get; set; }

    /// <summary>
    /// Gets or sets the foreign key to the vendor.
    /// </summary>
    [Required]
    public Guid VendorId { get; set; }

    /// <summary>
    /// Navigation property to the associated planner.
    /// </summary>
    [ForeignKey(nameof(PlannerId))]
    public Planner Planner { get; set; } = default!;

    /// <summary>
    /// Navigation property to the associated vendor.
    /// </summary>
    [ForeignKey(nameof(VendorId))]
    public Vendor Vendor { get; set; } = default!;
  }
}
