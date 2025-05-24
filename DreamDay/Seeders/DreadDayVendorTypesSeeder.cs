using System;
using DreamDay.Data;
using DreamDay.Models;
using Microsoft.EntityFrameworkCore;

namespace DreamDay.Seeders;

public static class DreadDayUserSeeder
{
    public static void SeedUsers(ModelBuilder modelBuilder)
    {
        // vender user
        var vendorUserId = Guid.NewGuid();

        // Couple user
        var coupleUserId = Guid.NewGuid();
    }
}

public static class DreadDayVendorTypesSeeder
{
    public static void SeedVendorTypes(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<VendorType>().HasData(
            new() { Id = Guid.NewGuid(), Category = VendorTypeCategory.PhotoAndVideo, VendorTypeName = "Photographer" },
            new() { Id = Guid.NewGuid(), Category = VendorTypeCategory.PhotoAndVideo, VendorTypeName = "Videographer" },
            new() { Id = Guid.NewGuid(), Category = VendorTypeCategory.PhotoAndVideo, VendorTypeName = "Drone Photographer" },

            // Entertainment (2)
            new() { Id = Guid.NewGuid(), Category = VendorTypeCategory.Entertainment, VendorTypeName = "DJ" },
            new() { Id = Guid.NewGuid(), Category = VendorTypeCategory.Entertainment, VendorTypeName = "Live Band" },

            // WeddingEssentials (3)
            new() { Id = Guid.NewGuid(), Category = VendorTypeCategory.WeddingEssentials, VendorTypeName = "Invitations & Stationery" },
            new() { Id = Guid.NewGuid(), Category = VendorTypeCategory.WeddingEssentials, VendorTypeName = "Favors & Gifts" },

            // FashionAndJewelry (4)
            new() { Id = Guid.NewGuid(), Category = VendorTypeCategory.FashionAndJewelry, VendorTypeName = "Bridal Gown Designer" },
            new() { Id = Guid.NewGuid(), Category = VendorTypeCategory.FashionAndJewelry, VendorTypeName = "Jewelry Boutique" },

            // HealthAndBeauty (5)
            new() { Id = Guid.NewGuid(), Category = VendorTypeCategory.HealthAndBeauty, VendorTypeName = "Makeup Artist" },
            new() { Id = Guid.NewGuid(), Category = VendorTypeCategory.HealthAndBeauty, VendorTypeName = "Hair Stylist" },

            // FoodAndBeverage (6)
            new() { Id = Guid.NewGuid(), Category = VendorTypeCategory.FoodAndBeverage, VendorTypeName = "Caterer" },
            new() { Id = Guid.NewGuid(), Category = VendorTypeCategory.FoodAndBeverage, VendorTypeName = "Open-Bar Service" },

            // Transportation (7)
            new() { Id = Guid.NewGuid(), Category = VendorTypeCategory.Transportation, VendorTypeName = "Limousine Service" },
            new() { Id = Guid.NewGuid(), Category = VendorTypeCategory.Transportation, VendorTypeName = "Vintage Car Rental" },

            // Decoration (8)
            new() { Id = Guid.NewGuid(), Category = VendorTypeCategory.Decoration, VendorTypeName = "Floral Arrangements" },
            new() { Id = Guid.NewGuid(), Category = VendorTypeCategory.Decoration, VendorTypeName = "Event Draping" },

            // CakeAndCatering (9)
            new() { Id = Guid.NewGuid(), Category = VendorTypeCategory.CakeAndCatering, VendorTypeName = "Wedding Cake Designer" },
            new() { Id = Guid.NewGuid(), Category = VendorTypeCategory.CakeAndCatering, VendorTypeName = "Dessert Station" },

            // PlannerAndCoordinator (10)
            new() { Id = Guid.NewGuid(), Category = VendorTypeCategory.PlannerAndCoordinator, VendorTypeName = "Day-Of Coordinator" },
            new() { Id = Guid.NewGuid(), Category = VendorTypeCategory.PlannerAndCoordinator, VendorTypeName = "Full-Service Planner" },

            // MusicAndPerformance (11)
            new() { Id = Guid.NewGuid(), Category = VendorTypeCategory.MusicAndPerformance, VendorTypeName = "String Quartet" },
            new() { Id = Guid.NewGuid(), Category = VendorTypeCategory.MusicAndPerformance, VendorTypeName = "Fire Dancers" },

            // LightingAndSound (12)
            new() { Id = Guid.NewGuid(), Category = VendorTypeCategory.LightingAndSound, VendorTypeName = "Lighting Designer" },
            new() { Id = Guid.NewGuid(), Category = VendorTypeCategory.LightingAndSound, VendorTypeName = "Sound Engineer" },

            // SecurityAndSafety (13)
            new() { Id = Guid.NewGuid(), Category = VendorTypeCategory.SecurityAndSafety, VendorTypeName = "Event Security" },
            new() { Id = Guid.NewGuid(), Category = VendorTypeCategory.SecurityAndSafety, VendorTypeName = "First-Aid Staff" },

            // RentalServices (14)
            new() { Id = Guid.NewGuid(), Category = VendorTypeCategory.RentalServices, VendorTypeName = "Chair & Table Rental" },
            new() { Id = Guid.NewGuid(), Category = VendorTypeCategory.RentalServices, VendorTypeName = "Tent Rental" },

            // OtherVenue (15)
            new() { Id = Guid.NewGuid(), Category = VendorTypeCategory.OtherVenue, VendorTypeName = "Banquet Hall" },
            new() { Id = Guid.NewGuid(), Category = VendorTypeCategory.OtherVenue, VendorTypeName = "Beachfront Venue" }
        );
    }
}
