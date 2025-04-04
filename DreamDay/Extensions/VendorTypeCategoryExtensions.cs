using DreamDay.Models;

namespace DreamDay.Extensions
{
    public static class VendorTypeCategoryExtensions
    {
        public static string ToDisplayName(this VendorTypeCategory category)
        {
            return category switch
            {
                VendorTypeCategory.PhotoAndVideo => "Photo & Video",
                //VendorTypeCategory.Entertainment => "Entertainment",
                VendorTypeCategory.WeddingEssentials => "Wedding Essentials",
                VendorTypeCategory.FashionAndJewelry => "Fashion & Jewelry",
                VendorTypeCategory.HealthAndBeauty => "Health & Beauty",
                VendorTypeCategory.FoodAndBeverage => "Food & Beverage",
                VendorTypeCategory.Transportation => "Transportation",
                VendorTypeCategory.Decoration => "Decoration",
                VendorTypeCategory.CakeAndCatering => "Cake & Catering",
                VendorTypeCategory.PlannerAndCoordinator => "Planner & Coordinator",
                VendorTypeCategory.MusicAndPerformance => "Music & Performance",
                VendorTypeCategory.LightingAndSound => "Lighting & Sound",
                VendorTypeCategory.SecurityAndSafety => "Security & Safety",
                VendorTypeCategory.RentalServices => "Rental Services",
                VendorTypeCategory.OtherVenue => "Other Venue",
                _ => category.ToString()
            };
        }
    }
}
