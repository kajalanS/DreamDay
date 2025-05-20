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
        /// Gets or sets the budget category.
        /// </summary>
        [Required]
        [MaxLength(255)]
        public VendorTypeCategory Category { get; set; } = default!;

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

    public enum VendorTypeCategory
    {
        PhotoAndVideo = 1,
        Entertainment = 2,
        WeddingEssentials = 3,
        FashionAndJewelry = 4,
        HealthAndBeauty = 5,
        FoodAndBeverage = 6,
        Transportation = 7,
        Decoration = 8,
        CakeAndCatering = 9,
        PlannerAndCoordinator = 10,
        MusicAndPerformance = 11,
        LightingAndSound = 12,
        SecurityAndSafety = 13,
        RentalServices = 14,
        OtherVenue = 15
    }
}
