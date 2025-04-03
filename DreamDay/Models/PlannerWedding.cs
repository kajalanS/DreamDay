using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DreamDay.Models
{
  /// <summary>
  /// Represents a relationship between a planner and a wedding.
  /// </summary>
  public class PlannerWedding
  {
    /// <summary>
    /// Gets or sets the unique identifier for the planner-wedding relationship.
    /// </summary>
    [Key]
    public Guid Id { get; set; }

    /// <summary>
    /// Gets or sets the foreign key to the planner.
    /// </summary>
    [Required]
    public Guid PlannerId { get; set; }

    /// <summary>
    /// Gets or sets the foreign key to the wedding.
    /// </summary>
    [Required]
    public Guid WeddingId { get; set; }

    /// <summary>
    /// Navigation property to the associated planner.
    /// </summary>
    [ForeignKey(nameof(PlannerId))]
    public Planner Planner { get; set; } = default!;

    /// <summary>
    /// Navigation property to the associated wedding.
    /// </summary>
    [ForeignKey(nameof(WeddingId))]
    public Wedding Wedding { get; set; } = default!;
  }
}
