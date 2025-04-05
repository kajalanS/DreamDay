-- Dummy Data for DreamDay Database (MySQL)

-- Note:  This script is designed for MySQL. Replace UUID() with a consistent GUID generator if needed for your testing.
-- Also replace the placeholder PasswordHash values with correctly hashed values for your system.

-- Roles
INSERT INTO `Roles` (`Id`, `Name`, `NormalizedName`, `ConcurrencyStamp`) VALUES
(UUID(), 'Admin', 'ADMIN', UUID()),
(UUID(), 'Couple', 'COUPLE', UUID()),
(UUID(), 'Planner', 'PLANNER', UUID()),
(UUID(), 'Vendor', 'VENDOR', UUID());

-- Users
SET @adminUserId = UUID();
SET @coupleUserId = UUID();
SET @plannerUserId = UUID();
SET @vendorUserId = UUID();

INSERT INTO `Users` (`Id`, `RegistrationDate`, `Status`, `UserName`, `NormalizedUserName`, `Email`, `NormalizedEmail`, `EmailConfirmed`, `PasswordHash`, `SecurityStamp`, `ConcurrencyStamp`, `PhoneNumber`, `PhoneNumberConfirmed`, `TwoFactorEnabled`, `LockoutEnd`, `LockoutEnabled`, `AccessFailedCount`) VALUES
(@adminUserId, NOW(), 1, 'admin@dreamday.com', 'ADMIN@DREAMDAY.COM', 'admin@dreamday.com', 'ADMIN@DREAMDAY.COM', 1, 'AQAAAAEAACcQAAAAEFSADF...', UUID(), UUID(), '123-456-7890', 1, 0, NULL, 0, 0),
(@coupleUserId, NOW(), 1, 'couple@dreamday.com', 'COUPLE@DREAMDAY.COM', 'couple@dreamday.com', 'COUPLE@DREAMDAY.COM', 1, 'AQAAAAEAACcQAAAAEFSADF...', UUID(), UUID(), '234-567-8901', 1, 0, NULL, 0, 0),
(@plannerUserId, NOW(), 1, 'planner@dreamday.com', 'PLANNER@DREAMDAY.COM', 'planner@dreamday.com', 'PLANNER@DREAMDAY.COM', 1, 'AQAAAAEAACcQAAAAEFSADF...', UUID(), UUID(), '345-678-9012', 1, 0, NULL, 0, 0),
(@vendorUserId, NOW(), 1, 'vendor@dreamday.com', 'VENDOR@DREAMDAY.COM', 'vendor@dreamday.com', 'VENDOR@DREAMDAY.COM', 1, 'AQAAAAEAACcQAAAAEFSADF...', UUID(), UUID(), '456-789-0123', 1, 0, NULL, 0, 0);

-- UserRoles (Assign Users to Roles)
SET @adminRoleId = (SELECT Id FROM Roles WHERE Name = 'Admin');
SET @coupleRoleId = (SELECT Id FROM Roles WHERE Name = 'Couple');
SET @plannerRoleId = (SELECT Id FROM Roles WHERE Name = 'Planner');
SET @vendorRoleId = (SELECT Id FROM Roles WHERE Name = 'Vendor');

INSERT INTO UserRoles (UserId, RoleId) VALUES
(@adminUserId, @adminRoleId),
(@coupleUserId, @coupleRoleId);
-- Adding more default roles
INSERT INTO UserRoles (UserId, RoleId) VALUES
(@plannerUserId, (SELECT Id FROM Roles WHERE Name = 'Planner')),
(@vendorUserId, (SELECT Id FROM Roles WHERE Name = 'Vendor'));

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
(UUID(), 'Venue',1),
(UUID(), 'Caterer',2),
(UUID(), 'Photographer',3);

-- Vendors
SET @venueVendorId = UUID();
SET @catererVendorId = UUID();
SET @photographerVendorId = UUID();

INSERT INTO `Vendors` (`Id`, `UserId`, `VendorTypeId`, `PlannerId`, `VendorName`, `IsPlanner`, `Description`, `WebsiteURL`, `ImageURL`, `Status`) VALUES
(@venueVendorId, @vendorUserId, @venueTypeId, NULL, 'Elegant Venues', 0, 'Beautiful venues for your special day.', 'www.elegantvenues.com', 'elegantvenues.jpg', 1),
(@catererVendorId, @vendorUserId, @catererTypeId, NULL, 'Delicious Catering', 0, 'Exquisite catering services.', 'www.deliciouscatering.com', 'deliciouscatering.jpg', 1),
(@photographerVendorId, @vendorUserId, @photographerTypeId, NULL, 'Stunning Photography', 0, 'Capturing your memories with stunning photos.', 'www.stunningphotography.com', 'stunningphotography.jpg', 1);

-- Venues
INSERT INTO `Venues` (`Id`, `VendorId`, `VenueName`, `Address`, `Capacity`, `ContactInfo`, `PriceRange`, `Description`, `VenueType`, `ImageURL`) VALUES
(UUID(), @venueVendorId, 'Grand Ballroom', '123 Main St, Cityville', 300, 'Contact: Jane Doe, (555) 123-4567', '$$$$', 'A luxurious ballroom for large events.', 'Ballroom', 'grand_ballroom.jpg');

-- Weddings
SET @weddingId = UUID();
INSERT INTO `Weddings` (`Id`, `CoupleId`, `VenueId`, `BudgetId`, `WeddingName`, `WeddingDate`, `Theme`, `NumberOfGuests`, `Status`) VALUES
(@weddingId, @coupleId, (SELECT Id FROM Venues WHERE VendorId = @venueVendorId), NULL, 'John and Jane''s Wedding', '2026-06-15', 'Classic', 200, 'Planning');

-- WeddingVendors
INSERT INTO `WeddingVendors` (`Id`, `WeddingId`, `VendorId`) VALUES
(UUID(), @weddingId, @venueVendorId),
(UUID(), @weddingId, @catererVendorId),
(UUID(), @weddingId, @photographerVendorId);

-- Budgets
INSERT INTO `Budgets` (`Id`, `WeddingId`, `Category`, `AllocatedAmount`, `ActualAmount`, `Description`) VALUES
(UUID(), @weddingId, 'Venue', 10000.00, 9500.00, 'Venue rental and associated costs.'),
(UUID(), @weddingId, 'Catering', 8000.00, 7800.00, 'Food and beverage catering.'),
(UUID(), @weddingId, 'Photography', 5000.00, 5200.00, 'Wedding photography services.');

-- Guests
INSERT INTO `Guests` (`Id`, `WeddingId`, `GuestName`, `Status`, `MealPreference`, `SeatingArrangement`, `PhoneNumber`, `Email`) VALUES
(UUID(), @weddingId, 'Guest One', 'Attending', 'Chicken', 'Table 1', '555-111-2222', 'guest1@example.com'),
(UUID(), @weddingId, 'Guest Two', 'Attending', 'Vegetarian', 'Table 2', '555-333-4444', 'guest2@example.com'),
(UUID(), @weddingId, 'Guest Three', 'Declined', NULL, NULL, '555-555-6666', 'guest3@example.com');

-- PlannerVendors (Example of linking planner and vendor)
SET @plannerVendorId = UUID();

INSERT INTO Planners (`Id`, `UserId`, `PlannerName`, `ContactPerson`, `PhoneNumber`, `WebsiteURL`, `Description`) VALUES
(@plannerVendorId, @plannerUserId, 'Dream Weaver Planners', 'Carol Planner', '555-777-8888', 'www.dreamweaverplanners.com', 'Experienced wedding planners making dreams come true');
INSERT INTO `PlannerVendors` (`Id`, `PlannerId`, `VendorId`) VALUES (UUID(), @plannerVendorId, @venueVendorId);

-- More Planners with descriptions
INSERT INTO Planners (`Id`, `UserId`, `PlannerName`, `ContactPerson`, `PhoneNumber`, `WebsiteURL`, `Description`)
VALUES
(UUID(), UUID(), 'Elegant Events', 'Emily Carter', '555-987-6543', 'www.elegantevents.com', 'Specializing in sophisticated and memorable wedding experiences.'),
(UUID(), UUID(), 'Blissful Beginnings', 'Sophia Miller', '555-234-5678', 'www.blissfulbeginnings.com', 'Creating personalized and joyful celebrations for every couple.');

-- Venues and their Descriptions
INSERT INTO Venues (`Id`, `VendorId`, `VenueName`, `Address`, `Capacity`, `ContactInfo`, `PriceRange`, `Description`, `VenueType`, `ImageURL`)
VALUES
(UUID(), UUID(), 'Rustic Barn', '456 County Rd, Ruralville', 150, 'Contact: Tom Smith, (555) 555-7777', '$$', 'A charming barn venue for a rustic-themed wedding.', 'Barn', 'rustic_barn.jpg'),
(UUID(), UUID(), 'Oceanview Terrace', '789 Beach Ave, Coastaltown', 200, 'Contact: Lisa Johnson, (555) 222-3333', '$$$', 'Stunning ocean views for a romantic beach wedding.', 'Outdoor Terrace', 'oceanview_terrace.jpg');
