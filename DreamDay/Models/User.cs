using DreamDay.Database.Core.Enum;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace DreamDay.Models
{
    /// <summary>
    /// Represents a system user.
    /// </summary>
    public class User : IdentityUser<Guid>
    {
        /// <summary>
        /// Gets or sets the type of the user.
        /// </summary>
        [Required]
        public UserType UserType { get; set; }

        /// <summary>
        /// Gets or sets the registration date.
        /// </summary>
        public DateTime RegistrationDate { get; set; } = DateTime.Now;

        /// <summary>
        /// Gets or sets the account status.
        /// </summary>
        [Required]
        public UserStatus Status { get; set; } = UserStatus.Active;

        /// <summary>
        /// Navigation property to the user profile.
        /// </summary>
        public UserProfile? Profile { get; set; }

        /// <summary>
        /// Navigation property to the couple details.
        /// </summary>
        public Couple? Couple { get; set; }

        /// <summary>
        /// Navigation property to the planner details.
        /// </summary>
        public Planner? Planner { get; set; }

        /// <summary>
        /// Navigation property to the vendor details.
        /// </summary>
        public Vendor? Vendor { get; set; }
    }
}
