using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DreamDay.Models
{
    /// <summary>
    /// Represents a wedding planner.
    /// </summary>
    public class Planner
    {
        /// <summary>
        /// Gets or sets the unique identifier for the planner.
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the foreign key to the associated user.
        /// </summary>
        [Required]
        public Guid UserId { get; set; }

        /// <summary>
        /// Gets or sets the planner's name.
        /// </summary>
        [MaxLength(255)]
        public string? PlannerName { get; set; }

        /// <summary>
        /// Gets or sets the contact person's name.
        /// </summary>
        [MaxLength(255)]
        public string? ContactPerson { get; set; }

        /// <summary>
        /// Gets or sets the planner's phone number.
        /// </summary>
        [MaxLength(20)]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the planner's website URL.
        /// </summary>
        [MaxLength(255)]
        public string? WebsiteURL { get; set; }

        /// <summary>
        /// Gets or sets the planner's description.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Navigation property to the associated user.
        /// </summary>
        [ForeignKey(nameof(UserId))]
        public User User { get; set; } = default!;

        /// <summary>
        /// Navigation property for associated planner-vendor relationships.
        /// </summary>
        public ICollection<PlannerVendor>? PlannerVendors { get; set; }

        /// <summary>
        /// Navigation property for associated planner-wedding relationships.
        /// </summary>
        public ICollection<PlannerWedding>? PlannerWeddings { get; set; }
    }
}
