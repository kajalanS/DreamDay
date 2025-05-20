namespace DreamDay.Models
{
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
