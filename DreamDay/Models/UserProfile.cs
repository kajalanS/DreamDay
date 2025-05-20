using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DreamDay.Models
{
    /// <summary>
    /// Represents a user profile.
    /// </summary>
    public class UserProfile
    {
        /// <summary>
        /// Gets or sets the unique identifier for the user profile.
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the foreign key to the associated user.
        /// </summary>
        [Required]
        public Guid UserId { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        [MaxLength(255)]
        public string? FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        [MaxLength(255)]
        public string? LastName { get; set; }

        /// <summary>
        /// Gets or sets the URL to the profile picture.
        /// </summary>
        [MaxLength(255)]
        public string? ProfilePictureURL { get; set; }

        /// <summary>
        /// Gets or sets the phone number.
        /// </summary>
        [MaxLength(20)]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        [MaxLength(255)]
        public string? Address { get; set; }

        /// <summary>
        /// Navigation property to the associated user.
        /// </summary>
        [ForeignKey(nameof(UserId))]
        public User User { get; set; } = default!;
    }
}
