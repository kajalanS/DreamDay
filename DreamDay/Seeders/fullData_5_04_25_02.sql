-- Dummy Data for DreamDay Database (MySQL) - WITH PLANNER ROLE

-- Note: This script is designed for MySQL. Replace UUID() with a consistent GUID generator if needed for your testing.
-- Also replace the placeholder PasswordHash values with correctly hashed values for your system.

-- -- Roles
INSERT INTO `Roles` (`Id`, `Name`, `NormalizedName`, `ConcurrencyStamp`) VALUES
(UUID(), 'Admin', 'ADMIN', UUID()),
(UUID(), 'Couple', 'COUPLE', UUID()),
(UUID(), 'Vendor', 'VENDOR', UUID());

-- Users
SET @adminUserId = UUID();
SET @coupleUserId = UUID();
SET @plannerUserId = UUID();
SET @vendorUserId = UUID();

INSERT INTO `Users` (`Id`, `RegistrationDate`, `Status`, `UserName`, `NormalizedUserName`, `Email`, `NormalizedEmail`, `EmailConfirmed`, `PasswordHash`, `SecurityStamp`, `ConcurrencyStamp`, `PhoneNumber`, `PhoneNumberConfirmed`, `TwoFactorEnabled`, `LockoutEnd`, `LockoutEnabled`, `AccessFailedCount`) VALUES
(@adminUserId, NOW(), 1, 'admin@dreamday.com', 'ADMIN@DREAMDAY.COM', 'admin@dreamday.com', 'ADMIN@DREAMDAY.COM', 1, 'AQAAAAIAAYagAAAAED7rbpYdwXyTPxQIby75+X5C6m64hhyeA4jTjQBKOHrRTvMflzfAHdhzTHyTO2f5lA==', UUID(), UUID(), '123-456-7890', 1, 0, NULL, 0, 0),
(@coupleUserId, NOW(), 1, 'couple@dreamday.com', 'COUPLE@DREAMDAY.COM', 'couple@dreamday.com', 'COUPLE@DREAMDAY.COM', 1, 'AQAAAAIAAYagAAAAED7rbpYdwXyTPxQIby75+X5C6m64hhyeA4jTjQBKOHrRTvMflzfAHdhzTHyTO2f5lA==', UUID(), UUID(), '234-567-8901', 1, 0, NULL, 0, 0),
(@plannerUserId, NOW(), 1, 'planner@dreamday.com', 'PLANNER@DREAMDAY.COM', 'planner@dreamday.com', 'PLANNER@DREAMDAY.COM', 1, 'AQAAAAIAAYagAAAAED7rbpYdwXyTPxQIby75+X5C6m64hhyeA4jTjQBKOHrRTvMflzfAHdhzTHyTO2f5lA==', UUID(), UUID(), '345-678-9012', 1, 0, NULL, 0, 0),
(@vendorUserId, NOW(), 1, 'vendor@dreamday.com', 'VENDOR@DREAMDAY.COM', 'vendor@dreamday.com', 'VENDOR@DREAMDAY.COM', 1, 'AQAAAAIAAYagAAAAED7rbpYdwXyTPxQIby75+X5C6m64hhyeA4jTjQBKOHrRTvMflzfAHdhzTHyTO2f5lA==', UUID(), UUID(), '456-789-0123', 1, 0, NULL, 0, 0);

-- UserRoles (Assign Users to Roles)
SET @adminRoleId = (SELECT Id FROM Roles WHERE Name = 'Admin');
SET @coupleRoleId = (SELECT Id FROM Roles WHERE Name = 'Couple');
SET @vendorRoleId = (SELECT Id FROM Roles WHERE Name = 'Vendor');

INSERT INTO UserRoles (UserId, RoleId) VALUES
(@adminUserId, @adminRoleId),
(@coupleUserId, @coupleRoleId),
(@plannerUserId, @vendorRoleId),
(@vendorUserId, @vendorRoleId);

-- UserProfiles
INSERT INTO `UserProfiles` (`Id`, `UserId`, `FirstName`, `LastName`, `ProfilePictureURL`, `PhoneNumber`, `Address`) VALUES
(UUID(), @adminUserId, 'Alice', 'Admin', 'admin.jpg', '123-456-7890', '122 Admin Street'),
(UUID(), @coupleUserId, 'Bob', 'Couple', 'couple.jpg', '234-567-8901', '123 Couple Street'),
(UUID(), @plannerUserId, 'Carol', 'Planner', 'planner.jpg', '345-678-9012', '124 Planner Street'),
(UUID(), @vendorUserId, 'Dave', 'Vendor', 'vendor.jpg', '456-789-0123', '125 Vendor Street');

-- Couples
SET @coupleId = UUID();
INSERT INTO `Couples` (`Id`, `UserId`, `BrideName`, `GroomName`, `EngagementDate`) VALUES
(@coupleId, @coupleUserId, 'Jane Bride', 'John Groom', NOW());

-- VendorTypes
SET @venueTypeId = UUID();
SET @catererTypeId = UUID();
SET @photographerTypeId = UUID();

INSERT INTO `VendorTypes` (`Id`, `VendorTypeName`, `Category`) VALUES
(@venueTypeId, 'Venue',11),
(@catererTypeId, 'Caterer',2),
(@photographerTypeId, 'Photographer',3);

-- Vendors
SET @venueVendorId = UUID();

INSERT INTO `Vendors` (`Id`, `UserId`, `VendorTypeId`, `PlannerId`, `VendorName`, `IsPlanner`, `Description`, `WebsiteURL`, `ImageURL`, `Status`) VALUES
(@venueVendorId, @vendorUserId, @venueTypeId, NULL, 'Elegant Venues', 0, 'Beautiful venues for your special day.', 'www.elegantvenues.com', 'elegantvenues.jpg', 1);

-- Venues
INSERT INTO `Venues` (`Id`, `VendorId`, `VenueName`, `Address`, `Capacity`, `ContactInfo`, `PriceRange`, `Description`, `VenueType`, `ImageURL`) VALUES
(UUID(), @venueVendorId, 'Grand Ballroom', '123 Main St, Cityville', 300, 'Contact: Jane Doe, (555) 123-4567', '$$$$', 'A luxurious ballroom for large events.', 'Ballroom', 'grand_ballroom.jpg');

-- Weddings
SET @weddingId = UUID();
INSERT INTO `Weddings` (`Id`, `CoupleId`, `VenueId`, `BudgetId`, `WeddingName`, `WeddingDate`, `Theme`, `NumberOfGuests`, `Status`) VALUES
(@weddingId, @coupleId, (SELECT Id FROM Venues WHERE VendorId = @venueVendorId), NULL, 'John and Jane''s Wedding', '2026-06-15', 'Classic', 200, 'Planning');

-- WeddingVendors
INSERT INTO `WeddingVendors` (`Id`, `WeddingId`, `VendorId`) VALUES
(UUID(), @weddingId, @venueVendorId);

-- Budgets
INSERT INTO `Budgets` (`Id`, `WeddingId`, `Category`, `AllocatedAmount`, `ActualAmount`, `Description`) VALUES
(UUID(), @weddingId, 'Venue', 10000.00, 9500.00, 'Venue rental and associated costs.');

-- Guests
INSERT INTO `Guests` (`Id`, `WeddingId`, `GuestName`, `Status`, `MealPreference`, `SeatingArrangement`, `PhoneNumber`, `Email`) VALUES
(UUID(), @weddingId, 'Guest One', 'Attending', 'Chicken', 'Table 1', '555-111-2222', 'guest1@example.com'),
(UUID(), @weddingId, 'Guest Two', 'Attending', 'Vegetarian', 'Table 2', '555-333-4444', 'guest2@example.com'),
(UUID(), @weddingId, 'Guest Three', 'Declined', NULL, NULL, '555-555-6666', 'guest3@example.com');

-- PlannerVendors (Example of linking planner and vendor)
SET @plannerId = UUID();

INSERT INTO Planners (`Id`, `UserId`, `PlannerName`, `ContactPerson`, `PhoneNumber`, `WebsiteURL`, `Description`)
VALUES (@plannerId, @plannerUserId, 'Dream Weaver Planners', 'Carol Planner', '555-777-8888', 'www.dreamweaverplanners.com', 'Experienced wedding planners making dreams come true');

INSERT INTO `PlannerVendors` (`Id`, `PlannerId`, `VendorId`)
VALUES (UUID(), @plannerId, @venueVendorId);

-- More Planners with descriptions
INSERT INTO Planners (`Id`, `UserId`, `PlannerName`, `ContactPerson`, `PhoneNumber`, `WebsiteURL`, `Description`)
VALUES
(UUID(), @adminUserId, 'Elegant Events', 'Emily Carter', '555-987-6543', 'www.elegantevents.com', 'Specializing in sophisticated and memorable wedding experiences.'),
(UUID(), @coupleUserId, 'Blissful Beginnings', 'Sophia Miller', '555-234-5678', 'www.blissfulbeginnings.com', 'Creating personalized and joyful celebrations for every couple.');

-- Venues and their Descriptions
INSERT INTO Venues (`Id`, `VendorId`, `VenueName`, `Address`, `Capacity`, `ContactInfo`, `PriceRange`, `Description`, `VenueType`, `ImageURL`)
VALUES
(UUID(), @venueVendorId, 'Rustic Barn', '456 County Rd, Ruralville', 150, 'Contact: Tom Smith, (555) 555-7777', '$$', 'A charming barn venue for a rustic-themed wedding.', 'Barn', 'rustic_barn.jpg'),
(UUID(), @venueVendorId, 'Oceanview Terrace', '789 Beach Ave, Coastaltown', 200, 'Contact: Lisa Johnson, (555) 222-3333', '$$$', 'Stunning ocean views for a romantic beach wedding.', 'Outdoor Terrace', 'oceanview_terrace.jpg');
