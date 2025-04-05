using System.Security.Claims;
using DreamDay.Database.Core.Enum;
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

        // public static string ToGetEnum<T>(this T enumData) where T : Enum
        // {
        //     var enumType = typeof(T);
        //     if (enumType.IsEnum && Enum.IsDefined(enumType, enumData))
        //     {
        //         return enumData.ToString();
        //     }
        //     return string.Empty;
        // }

        // public static T ToEnum<T>(this string enumData) where T : Enum
        // {
        //     var enumType = typeof(T);
        //     if (enumType.IsEnum && Enum.IsDefined(enumType, enumData))
        //     {
        //         return (T)Enum.Parse(enumType, enumData);
        //     }
        //     return default!;
        // }

        public static string ToDisplayName(this ClaimsPrincipal user)
        {
            var userTypeClaim = user.FindFirst(ClaimTypes.Role)?.Value;
            if (Enum.TryParse(userTypeClaim, out UserType userType))
            {
                return userType switch
                {
                    UserType.Admin => UserType.Admin.ToString(),
                    UserType.Couple => UserType.Couple.ToString(),
                    UserType.Vendor => UserType.Vendor.ToString(),
                    _ => userType.ToString()
                };
            }
            return string.Empty;
        }
    }
}
