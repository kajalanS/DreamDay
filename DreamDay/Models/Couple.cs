using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DreamDay.Models
{
    /// <summary>
    /// Represents a couple.
    /// </summary>
    public class Couple
    {
        /// <summary>
        /// Gets or sets the unique identifier for the couple.
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the foreign key to the user.
        /// </summary>
        [Required]
        public Guid UserId { get; set; }

        /// <summary>
        /// Gets or sets the bride's name. [female]
        /// </summary>
        [Required]
        [MaxLength(255)]
        public string BrideName { get; set; } = default!;

        /// <summary>
        /// Gets or sets the groom's name. [male]
        /// </summary>
        [Required]
        [MaxLength(255)]
        public string GroomName { get; set; } = default!;

        /// <summary>
        /// Gets or sets the engagement date.
        /// </summary>
        public DateTime? EngagementDate { get; set; }

        /// <summary>
        /// Navigation property to the associated user.
        /// </summary>
        [ForeignKey(nameof(UserId))]
        public User User { get; set; } = default!;

        /// <summary>
        /// Navigation property for weddings associated with the couple.
        /// </summary>
        public ICollection<Wedding>? Weddings { get; set; }
    }
}
