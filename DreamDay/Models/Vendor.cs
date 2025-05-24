using DreamDay.Database.Core.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DreamDay.Models
{
    /// <summary>
    /// Represents a vendor.
    /// </summary>
    public class Vendor
    {
        /// <summary>
        /// Gets or sets the unique identifier for the vendor.
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the foreign key to the associated user.
        /// </summary>
        [Required]
        public Guid UserId { get; set; }

        /// <summary>
        /// Gets or sets the foreign key to the vendor type.
        /// </summary>
        [Required]
        public Guid VendorTypeId { get; set; }

        /// <summary>
        /// Gets or sets the optional planner identifier.
        /// </summary>
        public Guid? PlannerId { get; set; }

        /// <summary>
        /// Gets or sets the vendor's name.
        /// </summary>
        [Required]
        [MaxLength(255)]
        public string VendorName { get; set; } = default!;

        /// <summary>
        /// Indicates whether the vendor is also a planner.
        /// </summary>
        [Required]
        public bool IsPlanner { get; set; } = false;

        /// <summary>
        /// Gets or sets the vendor's description.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Gets or sets the vendor's website URL.
        /// </summary>
        [MaxLength(255)]
        public string? WebsiteURL { get; set; }

        /// <summary>
        /// Gets or sets the vendor's image URL.
        /// </summary>
        [MaxLength(255)]
        public string? ImageURL { get; set; }

        /// <summary>
        /// Gets or sets the vendor's account status.
        /// </summary>
        [Required]
        public VendorStatus Status { get; set; } = VendorStatus.Active;

        /// <summary>
        /// Navigation property to the associated user.
        /// </summary>
        [ForeignKey(nameof(UserId))]
        public User User { get; set; } = default!;

        /// <summary>
        /// Navigation property to the associated vendor type.
        /// </summary>
        [ForeignKey(nameof(VendorTypeId))]
        public VendorType VendorType { get; set; } = default!;

        /// <summary>
        /// Navigation property to the associated planner.
        /// </summary>
        [ForeignKey(nameof(PlannerId))]
        public Planner? Planner { get; set; }

        /// <summary>
        /// Navigation property for wedding vendor relationships.
        /// </summary>
        public ICollection<WeddingVendor>? WeddingVendors { get; set; }

        /// <summary>
        /// Navigation property for vendor contact information.
        /// </summary>
        public VendorContactInfo? ContactInfo { get; set; }

        /// <summary>
        /// Navigation property for venues managed by the vendor.
        /// </summary>
        public ICollection<Venue>? Venues { get; set; }

        /// <summary>
        /// Navigation property for associated planner-vendor relationships.
        /// </summary>
        public ICollection<PlannerVendor>? PlannerVendors { get; set; }

        /// <summary>
        /// Gets or sets the price range for the vendor's services.
        /// </summary>
        [MaxLength(100)]
        public string? PriceRange { get; set; }
    }
}
