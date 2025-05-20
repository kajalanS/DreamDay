using DreamDay.Database.Core.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DreamDay.Models
{
  /// <summary>
  /// Represents a wedding.
  /// </summary>
  public class Wedding
  {
    /// <summary>
    /// Gets or sets the unique identifier for the wedding.
    /// </summary>
    [Key]
    public Guid Id { get; set; }

    /// <summary>
    /// Gets or sets the foreign key to the couple.
    /// </summary>
    [Required]
    public Guid CoupleId { get; set; }

    /// <summary>
    /// Gets or sets the optional venue identifier.
    /// </summary>
    public Guid? VenueId { get; set; }

    /// <summary>
    /// Gets or sets the optional budget identifier.
    /// </summary>
    public Guid? BudgetId { get; set; }

    /// <summary>
    /// Gets or sets the wedding name.
    /// </summary>
    [Required]
    [MaxLength(255)]
    public string WeddingName { get; set; } = default!;

    /// <summary>
    /// Gets or sets the wedding date.
    /// </summary>
    [Required]
    public DateTime WeddingDate { get; set; }

    /// <summary>
    /// Gets or sets the wedding theme.
    /// </summary>
    [MaxLength(255)]
    public string? Theme { get; set; }

    /// <summary>
    /// Gets or sets the number of guests.
    /// </summary>
    public int? NumberOfGuests { get; set; }

    /// <summary>
    /// Gets or sets the wedding status.
    /// </summary>
    [Required]
    [MaxLength(50)]
    public string Status { get; set; } = WeddingStatus.Planning.ToString();

    /// <summary>
    /// Navigation property to the associated couple.
    /// </summary>
    [ForeignKey(nameof(CoupleId))]
    public Couple Couple { get; set; } = default!;

    /// <summary>
    /// Navigation property to the associated venue.
    /// </summary>
    [ForeignKey(nameof(VenueId))]
    public Venue? Venue { get; set; }

    /// <summary>
    /// Navigation property for wedding-vendor relationships.
    /// </summary>
    public ICollection<WeddingVendor>? WeddingVendors { get; set; }

    /// <summary>
    /// Navigation property for the wedding guests.
    /// </summary>
    public ICollection<Guest> Guests { get; set; } = new List<Guest>();

    /// <summary>
    /// Navigation property to the associated budget.
    /// </summary>
    public Budget? Budget { get; set; }

    /// <summary>
    /// Navigation property for planner-wedding relationships.
    /// </summary>
    public ICollection<PlannerWedding>? PlannerWeddings { get; set; }

    /// <summary>
    /// Navigation property for wedding tasks.
    /// </summary>
    public ICollection<WeddingTask> Tasks { get; set; } = new List<WeddingTask>();

    /// <summary>
    /// Navigation property for wedding vendors.
    /// </summary>
    public ICollection<Vendor> Vendors { get; set; } = new List<Vendor>();
  }

  /// <summary>
  /// Represents a wedding task.
  /// </summary>
  public class WeddingTask
  {
    /// <summary>
    /// Gets or sets the unique identifier for the task.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the title of the task.
    /// </summary>
    public required string Title { get; set; }

    /// <summary>
    /// Gets or sets the due date of the task.
    /// </summary>
    public DateTime? DueDate { get; set; }

    /// <summary>
    /// Gets or sets whether the task is completed.
    /// </summary>
    public bool IsCompleted { get; set; }

    /// <summary>
    /// Gets or sets the wedding identifier.
    /// </summary>
    public Guid WeddingId { get; set; }

    /// <summary>
    /// Navigation property to the associated wedding.
    /// </summary>
    public Wedding? Wedding { get; set; }
  }
}
