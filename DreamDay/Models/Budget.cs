using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DreamDay.Models
{
    /// <summary>
    /// Represents a budget item for a wedding.
    /// </summary>
    public class Budget
    {
        /// <summary>
        /// Gets or sets the unique identifier for the budget item.
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the foreign key to the associated wedding.
        /// </summary>
        [Required]
        public Guid WeddingId { get; set; }

        /// <summary>
        /// Gets or sets the budget category.
        /// </summary>
        [Required]
        [MaxLength(255)]
        public string Category { get; set; } = default!;

        /// <summary>
        /// Gets or sets the allocated amount.
        /// </summary>
        [Column(TypeName = "decimal(18, 2)")]
        public decimal AllocatedAmount { get; set; } = 0.00M;

        /// <summary>
        /// Gets or sets the actual amount spent.
        /// </summary>
        [Column(TypeName = "decimal(18, 2)")]
        public decimal ActualAmount { get; set; } = 0.00M;

        /// <summary>
        /// Gets or sets a description for the budget item.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Navigation property to the associated wedding.
        /// </summary>
        [ForeignKey(nameof(WeddingId))]
        public Wedding Wedding { get; set; } = default!;
    }
}
