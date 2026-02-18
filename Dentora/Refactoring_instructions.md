# Refactoring Instructions: Finalizing "Dentora" Migration

## Context
We are migrating an existing application ("ThrillX" - Extreme Sports Manager) to a new domain ("Dentora" - Dental Clinic Management).
Much of the work is done, but there are critical artifacts (class names, file names, and UI labels) that still refer to the old project.

**Goal:** Strictly enforce dental terminology and remove all references to "ThrillX", "Adventures", and "Gear".

---

## Task 1: Database Context Renaming (CRITICAL)
The main DbContext is still named incorrectly.
* **Target File:** `Dentora/Models/DbConfiguration/ThrillXDbContext.cs`
* **Action:** 1. Rename the class `ThrillXDbContext` to `DentoraDbContext`.
    2. Rename the file to `DentoraDbContext.cs`.
    3. Update `Program.cs` and `ServiceRegistration.cs` to inject `DentoraDbContext`.

---

## Task 2: Domain Model Refactoring
We need to rename the core entities to match the Dental domain. Use IDE Refactoring tools to ensure all references (Controllers, Services, Views) are updated automatically.

### A. Experience -> Treatment
* **Target Files:** `Models/Experience.cs`, `Services/ExperienceService.cs`, `Forms/ManageExperiences.cs`
* **Action:**
    1. Rename class `Experience` to `Treatment`.
    2. Rename `ExperienceService` to `TreatmentService`.
    3. Rename `ManageExperiences` Form to `ManageTreatments`.
    4. **Properties:** Ensure `Treatment` has `DurationMinutes` (int) and `Price` (decimal).

### B. Gear -> InventoryItem
* **Target Files:** `Models/Gear.cs`, `Services/GearService.cs`, `Forms/ManageGear.cs`
* **Action:**
    1. Rename class `Gear` to `InventoryItem`.
    2. Rename `GearService` to `InventoryService`.
    3. Rename `ManageGear` Form to `ManageInventory`.
    4. **UI:** Update the form title to "Clinic Inventory".

### C. Booking -> Appointment (Optional but Recommended)
* **Target Files:** `Models/Booking.cs`, `Services/BookingService.cs`
* **Action:** 1. Rename class `Booking` to `Appointment`.
    2. Rename `BookingService` to `AppointmentService`.

---

## Task 3: UI & String Cleanup
Iterate through all Forms (`.Designer.cs` and `.cs`) and clean up static text.

* **Search for:** "ThrillX", "Adventure", "Extreme", "Instructor".
* **Replace with:** "Dentora", "Treatment", "Dental", "Dentist".
* **Specific Targets:**
    * `MainForm` / `Dashboard`: Title should be "Dentora Management System".
    * `InvoiceHelper.cs`: Header text must say "DENTORA CLINIC" instead of "ThrillX Adventure".
    * `Login.cs`: Ensure the window title is "Dentora Login".

---

## Task 4: Seed Data Update
* **Target File:** `Models/DbConfiguration/SeedAdmin.cs`
* **Action:**
    1. Ensure the default admin user has realistic data (e.g., `Email = "admin@dentora.com"`, `FullName = "Dr. Petrov"`).
    2. Ensure the role assigned is "Dentist" or "Admin".

---

## Task 5: Namespace Consistency
* **Action:** Perform a global search for `namespace ThrillX`. Replace all occurrences with `namespace Dentora`.
* **Note:** Ensure `using` statements in all files are updated to `using Dentora.Models;`, `using Dentora.Services;`, etc.