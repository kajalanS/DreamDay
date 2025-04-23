Okay, here is a comprehensive Project Requirements Document for the DreamDay system based on your detailed prompt.

---

**DreamDay – Multi-Vendor Wedding Planning System**
**Project Requirements Document**

**Version:** 1.0
**Date:** October 26, 2023
**Status:** Draft

**Table of Contents**

1.  Introduction
    1.1 Purpose
    1.2 Scope
    1.3 Target Audience
    1.4 Definitions, Acronyms, and Abbreviations
2.  Overall Description
    2.1 Product Perspective
    2.2 User Characteristics
    2.3 General Constraints
    2.4 Assumptions and Dependencies
3.  System Features (Functional Requirements)
    3.1 User Roles
    3.2 Admin Role Features
    3.3 Couple Role Features
    3.4 Vendor (Planner) Role Features
    3.5 Common Features (Authentication & Authorization)
4.  Non-Functional Requirements
    4.1 Performance
    4.2 Security
    4.3 Usability
    4.4 Reliability
    4.5 Maintainability
5.  System Architecture
    5.1 Architectural Style
    5.2 Design Patterns
6.  Technology Stack
7.  Data Requirements
    7.1 Database System
    7.2 Key Data Entities (Conceptual)
    7.3 Data Management
8.  Implementation Plan (High-Level Phases)
9.  Deliverables
10. Future Considerations (Optional Extensions)

---

**1. Introduction**

**1.1 Purpose**
This document defines the requirements for the DreamDay system, a web-based multi-vendor wedding planning application. Its primary purpose is to provide a centralized platform for couples to plan their weddings, vendors to offer their services and manage events, and administrators to oversee the platform's operations.

**1.2 Scope**
The scope of the DreamDay project includes the design, development, testing, and documentation of a web application with the features outlined in Section 3 for Admin, Couple, and Vendor roles. Key functionalities include user registration and management, wedding plan creation and management, task and budget tracking, guest list management, vendor/venue search and booking, and collaborative planning features between couples and vendors.

*   **In Scope:** Features explicitly listed under Admin, Couple, and Vendor roles; core platform infrastructure (database, authentication, architecture); basic reporting for Admins; documentation as listed in Deliverables.
*   **Out of Scope (Initially):** Direct payment gateway integration, automated email/SMS notifications (beyond basic account actions like confirmation), advanced analytics dashboards, mobile application versions, direct integration with third-party calendars, complex vendor contract management.

**1.3 Target Audience**
This document is intended for:
*   Development Team: To understand the features and constraints for implementation.
*   Project Manager: To oversee the project scope and progress.
*   Testers: To define test cases and validate the system against requirements.
*   Stakeholders: To review and approve the project scope and functionalities.

**1.4 Definitions, Acronyms, and Abbreviations**
*   **Admin:** System Administrator role.
*   **Couple:** User role representing individuals planning their wedding.
*   **Vendor:** User role representing service providers (individuals or companies) offering wedding-related services. Can also act as a Planner.
*   **Planner:** A Vendor who has been invited by a Couple to help manage their wedding plan.
*   **RSVP:** Répondez s'il vous plaît (Please Respond) - used for guest attendance tracking.
*   **MVC:** Model-View-Controller architectural pattern.
*   **EF Core:** Entity Framework Core (Object-Relational Mapper).
*   **ORM:** Object-Relational Mapper.
*   **UI:** User Interface.
*   **UX:** User Experience.
*   **ERD:** Entity-Relationship Diagram.
*   **UML:** Unified Modeling Language.
*   **UoW:** Unit of Work pattern.
*   **DI:** Dependency Injection.
*   **CRUD:** Create, Read, Update, Delete.
*   **ASP.NET Identity:** Framework for authentication and user management in ASP.NET.

**2. Overall Description**

**2.1 Product Perspective**
DreamDay is a new, self-contained web application built using the ASP.NET MVC framework on .NET 8. It will function as a multi-tenant platform where multiple couples and vendors can interact independently while being managed by a central administration team. It relies on a SQL Server database for data persistence and ASP.NET Identity for user authentication and role management.

**2.2 User Characteristics**
*   **Admin:** Technically proficient individuals responsible for platform health, user management, and content moderation (venues, vendor approvals). They require access to overview reports and administrative controls.
*   **Couple:** Individuals or pairs planning a wedding. May have varying levels of technical skill. Need intuitive tools for planning (tasks, budget, guests), finding vendors/venues, and potentially collaborating with a chosen planner.
*   **Vendor (Planner):** Individuals or businesses offering wedding services. Need features to showcase their services, manage their profile, interact with potential clients (couples), and, if acting as a planner, collaborate on wedding details. They may manage sub-vendors/teams.

**2.3 General Constraints**
*   The system MUST be developed using ASP.NET MVC (C#) on the .NET 8 framework.
*   The database MUST be Microsoft SQL Server.
*   Entity Framework Core 8 MUST be used as the ORM.
*   ASP.NET Identity MUST be used for authentication and authorization.
*   A layered architecture (Presentation, Application, Domain, Data) MUST be implemented.
*   Repository and Unit of Work patterns MUST be used for data access.
*   Dependency Injection MUST be utilized for managing dependencies (e.g., services).
*   The frontend UI MUST use Razor Views with Bootstrap 5 for styling and responsiveness.
*   The system MUST be deployable on IIS or Azure Web Apps.
*   Password hashing MUST be implemented for secure password storage (handled by ASP.NET Identity).
*   Development MUST use Visual Studio 2022 or later.

**2.4 Assumptions and Dependencies**
*   Users will have access to a modern web browser (e.g., Chrome, Firefox, Edge, Safari).
*   The hosting environment (IIS/Azure) will be configured appropriately for .NET 8 applications and SQL Server connectivity.
*   Basic email sending capabilities are available on the server for account confirmation (if implemented).
*   PlantUML or a compatible tool is available for generating specified diagrams.

**3. System Features (Functional Requirements)**

**3.1 User Roles**
The system shall support three distinct user roles with different permissions:
*   Admin
*   Couple
*   Vendor (who can also be designated as a Planner for specific weddings)

**3.2 Admin Role Features**
*   **FEAT-ADM-01:** Ability to view a list of pending vendor registration applications.
*   **FEAT-ADM-02:** Ability to Approve or Reject pending vendor applications. Approved vendors become active; rejected applications are notified or marked appropriately.
*   **FEAT-ADM-03:** Ability to view a list of all registered users (Couples and Vendors).
*   **FEAT-ADM-04:** Ability to filter and search the user list (e.g., by role, status, name/email).
*   **FEAT-ADM-05:** Ability to manage user account status (Set to Active, Inactive, or Pending - primarily for Vendors).
*   **FEAT-ADM-06:** Ability to view individual user profiles (basic details).
*   **FEAT-ADM-07:** Ability to Create, Read, Update, and Delete (CRUD) venue details in the system.
*   **FEAT-ADM-08:** Ability to view basic system usage reports (e.g., total users by role, number of active weddings, number of vendors by category).

**3.3 Couple Role Features**
*   **FEAT-CPL-01:** Ability to register for a new Couple account.
*   **FEAT-CPL-02:** Ability to log in securely using email and password.
*   **FEAT-CPL-03:** Ability to manage their user profile (e.g., update name, password).
*   **FEAT-CPL-04:** Ability to create a new wedding plan.
*   **FEAT-CPL-05:** Ability to view and edit details of their wedding plan (e.g., names, date, estimated guest count, overall budget).
*   **FEAT-CPL-06:** Ability to manage the status of their wedding plan (e.g., Planning, Confirmed, Completed, Cancelled).
*   **FEAT-CPL-07:** Ability to create, update, delete, and mark tasks as complete within their wedding plan's task list. Assign due dates to tasks.
*   **FEAT-CPL-08:** Ability to create, update, and delete budget items within their wedding plan, tracking estimated vs. actual costs per category. View budget summary.
*   **FEAT-CPL-09:** Ability to create and manage a guest list for their wedding.
*   **FEAT-CPL-10:** Ability to track RSVP status for each guest (e.g., Pending, Attending, Declined). View RSVP summary.
*   **FEAT-CPL-11:** Ability to search for registered Vendors based on criteria (e.g., service category, location - if implemented).
*   **FEAT-CPL-12:** Ability to view Vendor profiles (details, services, portfolio).
*   **FEAT-CPL-13:** Ability to search and filter Venues based on criteria (e.g., location, capacity, type).
*   **FEAT-CPL-14:** Ability to view Venue details.
*   **FEAT-CPL-15:** Ability to "book" or associate a Venue with their wedding plan (basic linking, not financial transaction).
*   **FEAT-CPL-16:** Ability to send an invitation to a registered Vendor to act as the Planner for their specific wedding.

**3.4 Vendor (Planner) Role Features**
*   **FEAT-VDR-01:** Ability to register for a new Vendor account (as Company or Individual). Registration requires Admin approval (status set to Pending).
*   **FEAT-VDR-02:** Ability to log in securely using email and password (once approved).
*   **FEAT-VDR-03:** Ability to manage their profile: contact information, business description, service categories (e.g., photographer, florist, decorator), profile picture/logo, portfolio (images/description).
*   **FEAT-VDR-04:** (Optional/If Company) Ability to manage a list of sub-vendors or team members associated with their company account.
*   **FEAT-VDR-05:** (If permitted by Admin settings) Ability to create, update, and manage venue listings associated with their account.
*   **FEAT-VDR-06:** Ability to view invitations received from Couples to act as a Planner.
*   **FEAT-VDR-07:** Ability to Accept or Decline Planner invitations.
*   **FEAT-VDR-08:** (If Planner role accepted for a wedding) Ability to view the details of the Couple's wedding plan they are managing.
*   **FEAT-VDR-09:** (If Planner role accepted) Ability to collaboratively manage the wedding task list (add, edit, complete tasks).
*   **FEAT-VDR-10:** (If Planner role accepted) Ability to collaboratively manage the wedding budget breakdown (view, potentially add/edit items - specific permissions TBD).
*   **FEAT-VDR-11:** (If Planner role accepted) Ability to assist with venue arrangements and timelines associated with the wedding plan.

**3.5 Common Features (Authentication & Authorization)**
*   **FEAT-ALL-01:** Secure user registration with unique email addresses.
*   **FEAT-ALL-02:** Secure login using ASP.NET Identity, including password hashing.
*   **FEAT-ALL-03:** Password reset functionality (e.g., "Forgot Password").
*   **FEAT-ALL-04:** Role-based access control, ensuring users can only access features and data relevant to their assigned role (Admin, Couple, Vendor).
*   **FEAT-ALL-05:** Account status checks upon login (Active users can log in, Pending/Inactive cannot).
*   **FEAT-ALL-06:** (Optional) Email confirmation upon registration.

**4. Non-Functional Requirements**

**4.1 Performance**
*   **NFR-PERF-01:** Average page load times for common user actions should be under 3 seconds under typical load conditions.
*   **NFR-PERF-02:** Database queries should be optimized to ensure efficient data retrieval, especially for search and listing pages.
*   **NFR-PERF-03:** The application should be scalable to handle a growing number of users and data.

**4.2 Security**
*   **NFR-SEC-01:** All user authentication MUST use ASP.NET Identity mechanisms. Passwords MUST be securely hashed.
*   **NFR-SEC-02:** Role-based authorization MUST be enforced on all relevant controller actions and data access points.
*   **NFR-SEC-03:** The application MUST implement measures to prevent common web vulnerabilities, including Cross-Site Scripting (XSS) and Cross-Site Request Forgery (CSRF - ASP.NET MVC provides built-in support).
*   **NFR-SEC-04:** Entity Framework Core MUST be used correctly to prevent SQL Injection vulnerabilities.
*   **NFR-SEC-05:** Sensitive data (if any beyond passwords) should be handled appropriately.
*   **NFR-SEC-06:** HTTPS MUST be enforced for all communication.
*   **NFR-SEC-07:** Input validation MUST be performed on both client-side (JavaScript) and server-side (Model validation).

**4.3 Usability**
*   **NFR-USA-01:** The user interface MUST be responsive and adapt to various screen sizes (desktops, tablets, mobiles) using Bootstrap 5.
*   **NFR-USA-02:** Navigation MUST be clear, consistent, and intuitive for all user roles.
*   **NFR-USA-03:** Forms should be easy to understand and use, with clear labels and validation messages.
*   **NFR-USA-04:** The visual design should be clean, professional, and consistent across the application.

**4.4 Reliability**
*   **NFR-REL-01:** The system should be available during expected operational hours (aim for high availability).
*   **NFR-REL-02:** Proper error handling and logging mechanisms should be implemented to diagnose and recover from failures.
*   **NFR-REL-03:** Data integrity must be maintained through database constraints and validation rules. Regular database backups are recommended (operational procedure).

**4.5 Maintainability**
*   **NFR-MNT-01:** The codebase MUST adhere to the specified layered architecture.
*   **NFR-MNT-02:** Code should follow standard C# and .NET coding conventions and be well-commented where necessary.
*   **NFR-MNT-03:** Use of design patterns (Repository, UoW, DI) should promote loose coupling and testability.
*   **NFR-MNT-04:** Configuration settings (database connection strings, etc.) should be externalized (e.g., `appsettings.json`).

**5. System Architecture**

**5.1 Architectural Style**
The system MUST implement a **Layered Architecture** consisting of:
*   **Presentation Layer:** Handles user interface and interaction. (ASP.NET MVC Views - Razor, Controllers, ViewModels, Bootstrap, HTML/CSS/JS).
*   **Application Layer:** Orchestrates use cases and application logic. Contains Services that implement business rules, coordinating between the Presentation and Domain/Data layers.
*   **Domain Layer:** Contains core business entities, value objects, and domain logic. (C# Models/Entities like User, Wedding, Task, Vendor, Venue, etc.).
*   **Data Layer (Infrastructure):** Responsible for data persistence and retrieval. (Entity Framework Core DbContext, Repositories, Migrations, SQL Server interaction).

**5.2 Design Patterns**
*   **Model-View-Controller (MVC):** Framework's core pattern for UI separation.
*   **Repository Pattern:** Abstract data access logic, providing an interface for querying entities.
*   **Unit of Work (UoW) Pattern:** Manage transactions and coordinate changes across multiple repositories.
*   **Dependency Injection (DI):** Manage dependencies between components (e.g., injecting services into controllers, repositories into services). Provided natively by ASP.NET Core.

**6. Technology Stack**

| Component          | Technology / Specification          | Version/Details      |
| :----------------- | :---------------------------------- | :------------------- |
| Development Framework | ASP.NET Core MVC                    | .NET 8               |
| Backend Language   | C#                                  | Latest for .NET 8    |
| Database           | Microsoft SQL Server                | Version compatible with EF Core 8 |
| ORM                | Entity Framework Core               | 8.x                  |
| Authentication     | ASP.NET Identity                    | Included in .NET 8   |
| Frontend           | Razor Views, HTML5, CSS3, JavaScript |                      |
| UI Framework       | Bootstrap                           | 5.x                  |
| IDE                | Visual Studio                       | 2022 or later        |
| Web Server         | Kestrel (dev), IIS / Azure Web Apps | For deployment       |
| Source Control     | Git (Recommended)                   |                      |
| Diagramming        | PlantUML (or compatible)            | For required diagrams|

**7. Data Requirements**

**7.1 Database System**
Microsoft SQL Server will be used as the relational database management system.

**7.2 Key Data Entities (Conceptual)**
The database schema (`DreamDay.sql` and EF Core Migrations) will define tables based on the Domain models, including but not limited to:
*   **Users:** Core user information (leveraging ASP.NET Identity tables - AspNetUsers, AspNetRoles, etc.). Extended profile data specific to roles.
*   **Roles:** Admin, Couple, Vendor (using AspNetRoles).
*   **UserStatus:** Enum/Lookup for Active, Inactive, Pending.
*   **Wedding:** Details of a couple's wedding plan (CoupleID, Name, Date, Budget, GuestCount, Status, VenueID).
*   **Task:** Tasks associated with a Wedding (WeddingID, Description, DueDate, IsCompleted, AssignedToUserID - optional).
*   **BudgetItem:** Items in a wedding budget (WeddingID, Category, EstimatedCost, ActualCost).
*   **Guest:** Guests associated with a Wedding (WeddingID, Name, PartySize, RSVPStatus).
*   **RSVPStatus:** Enum/Lookup for Pending, Attending, Declined.
*   **Vendor:** Vendor profile information (UserID, CompanyName, Description, ContactInfo, Website, Address).
*   **VendorServiceCategory:** Links Vendors to service categories (VendorID, CategoryID).
*   **ServiceCategory:** Lookup table for categories (Photographer, Florist, etc.).
*   **SubVendor:** (If implemented) Links team members to a primary Vendor account.
*   **Venue:** Venue details (Name, Location, Capacity, Description, ContactInfo, AdminManaged/VendorManaged flag, VendorID - if vendor-managed).
*   **VendorApplication:** Stores details of pending vendor applications (linked to UserID).
*   **WeddingPlannerInvitation:** Tracks invitations sent from Couples to Vendors (WeddingID, VendorUserID, Status - Pending, Accepted, Declined).
*   **WeddingVendor:** Associates booked/involved vendors (non-planner) with a wedding (WeddingID, VendorID).

An Entity-Relationship Diagram (ERD) will be created to visualize the table structure and relationships.

**7.3 Data Management**
*   EF Core Migrations will be used to manage database schema changes.
*   A data seeding mechanism will be implemented to populate initial lookup data (e.g., Roles, Service Categories) and sample data for testing/demonstration.

**8. Implementation Plan (High-Level Phases)**

1.  **Phase 1: Design & Planning:** Finalize requirements, create ERD, Use Case, and Class diagrams (PlantUML). Plan project structure.
2.  **Phase 2: Database & Identity Setup:** Create SQL Server database, implement EF Core models and DbContext, scaffold ASP.NET Identity tables, configure Roles (Admin, Couple, Vendor). Apply initial migrations.
3.  **Phase 3: Authentication & Core Roles:** Implement Registration (Couple, Vendor - pending), Login, Logout, Password Management. Implement basic role checks and account status handling.
4.  **Phase 4: Core Feature Modules:** Develop modules sequentially or in parallel:
    *   Wedding Management (Couple: CRUD, Status; Planner: View/Limited Edit)
    *   Task Management (Couple: CRUD; Planner: Collaborative CRUD)
    *   Guest & RSVP Management (Couple: CRUD)
    *   Budget Tracking (Couple: CRUD; Planner: Collaborative View/Edit)
    *   Vendor Search & Profile (Public/Couple: Search/View; Vendor: Manage Profile)
    *   Venue Management & Booking (Admin: CRUD; Vendor: CRUD if permitted; Couple: Search/Book Link)
5.  **Phase 5: Admin Panel Development:** Implement Vendor application approval workflow, User management interface, Venue management (Admin section), Reporting dashboard.
6.  **Phase 6: Vendor as Planner Implementation:** Develop invitation system (Couple sends, Vendor Accepts/Declines), Implement collaborative features for accepted Planners on Tasks, Budget, etc.
7.  **Phase 7: Testing & Refinement:** Conduct unit testing, integration testing, and manual user acceptance testing (UAT). Seed comprehensive sample data. Refine UI/UX based on feedback.
8.  **Phase 8: Documentation & Deployment:** Write final documentation (User Guide, Installation Guide, Technical Documentation, Reflection). Prepare the application for deployment to IIS or Azure.

**9. Deliverables**

*   **Source Code:** Complete Visual Studio Solution containing the layered ASP.NET MVC (.NET 8) project.
*   **Database:** SQL Server database script (`DreamDay.sql`) for schema creation and potentially seeding essential lookup data. EF Core Migrations within the codebase.
*   **Diagrams:** PlantUML source and generated images for ERD, Use Case Diagram, and Class Diagram (key classes).
*   **Sample Data:** Seeding logic within the application or separate scripts to populate the system with sample users, weddings, vendors, etc., for demonstration.
*   **Documentation:**
    *   Project Requirements Document (this document).
    *   System Architecture Document (explaining layers, patterns, referencing diagrams).
    *   Database Design Document (including ERD and table descriptions).
    *   User Guide (explaining how to use the system for each role).
    *   Installation/Deployment Guide.
    *   Testing Report (summary of testing activities and results).
    *   Project Reflection/Conclusion Report.

**10. Future Considerations (Optional Extensions)**

*   Direct Payment Gateway Integration for booking services/venues.
*   Automated Email/SMS Notifications (RSVP reminders, task deadlines, invitations).
*   Advanced Reporting and Analytics Dashboards.
*   Calendar Integration (e.g., Google Calendar, Outlook Calendar).
*   Vendor Rating and Review System.
*   Messaging System between Couples and Vendors.
*   Mobile Application (Native or PWA).
*   Enhanced Sub-vendor/Team Management features.
*   Contract generation/management tools.

---
