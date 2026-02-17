# Project Specification: Dentora (Dental Clinic Manager)

## 1. Project Overview
**Dentora** is a Windows Forms desktop application for managing a dental clinic. It connects Patients (Clients) and Dentists (Admins).
* **Reference Project:** The agent must strictly follow the architecture and patterns of the provided **"ThrillX"** project.
* **Goal:** Re-skin and adapt ThrillX into a Dental Clinic system without adding unnecessary external dependencies.

---

## 2. Technical Constraints
* **Framework:** .NET 8 (Windows Forms).
* **Database:** MS SQL Server + Entity Framework Core.
* **Architecture:** N-Layer (UI -> Services -> Data Access).
* **Dependency Injection:** Use the existing `ServiceLocator` pattern from ThrillX.
* **External Libraries:** **STRICTLY FORBIDDEN** (except EF Core). Do not use PDF libraries (like iText or QuestPDF).
    * *Solution for Documents:* Use the native `.NET System.Drawing.Printing` class to generate simple receipts/prescriptions.

---

## 3. Data Model Mapping (ThrillX -> Dentora)
The agent must rename and adapt the existing entities to fit the dental domain:

| ThrillX Entity | Dentora Entity | Changes Required |
| :--- | :--- | :--- |
| `Experience` | `Treatment` | Represents a dental service (Cleaning, Extraction). Add `DurationMinutes`. |
| `Booking` | `Appointment` | Represents a visit. Connects `User` (Patient) and `Treatment`. |
| `Gear` | `InventoryItem` | Represents clinic materials (Gloves, Anesthesia). Fields: `Name`, `Quantity`, `Price`. |
| `User` | `User` | Add `FullName`, `Phone`. Role 1 = Admin (Dentist), Role 2 = Client (Patient). |
| `Order` | *N/A* or `UsageLog` | (Optional) Simplified tracking of used materials. |
| *New* | `Review` | A new table for rating doctors (Stars 1-5 + Comment). |

---

## 4. Functional Requirements (The "6 Forms" Rule)

### A. Authentication
1. **LoginForm:** Clone of `ThrillX/Forms/Login`.
2. **RegisterForm:** Clone of `ThrillX/Forms/Register`.

### B. Admin UI (The Dentist)
3. **AdminDashboard:**
    * **Navigation Menu:** (Schedule, Treatments, Inventory, Patients).
    * **Schedule View:** A grid showing today's appointments.
4. **ManageTreatments:** (Clone of `ManageExperiences`) - Add/Edit services.
5. **ManageInventory:** (Clone of `ManageGear`) - Simple table to Add/Edit material quantities.

### C. Client UI (The Patient)
6. **ClientDashboard:**
    * **Navigation Menu:** (Book Appointment, My History, Leave Review).
7. **BookAppointment:** (Clone of `BookExperience`) - Select Service -> Select Date -> Confirm.
8. **FeedbackForm:** A simple form to save a `Review` for a past appointment.

---

## 5. Step-by-Step Implementation Plan

### Phase 1: Database & Models
1.  Create `DentoraDbContext` (copy `ThrillXDbContext`).
2.  Define entities: `User`, `Role`, `Treatment`, `Appointment`, `InventoryItem`, `Review`.
3.  **Important:** Ensure `Appointment` has a `Status` (Pending, Completed, Cancelled).

### Phase 2: Services Logic
Copy `BaseService` structure. Implement:
* `AuthService`: Login/Register logic.
* `TreatmentService`: CRUD for treatments.
* `InventoryService`: CRUD for materials (Keep it simple: just quantity +/-).
* `AppointmentService`: Logic to check if a time slot is free before booking.

### Phase 3: Printing Feature (No 3rd Party Libs)
Create a `DocumentHelper` class.
* Method: `GeneratePrescription(string patientName, string treatmentName)`
* Logic: Use `PrintDocument` to draw a simple string on a graphic canvas:
    * "DENTORA CLINIC" (Header)
    * "Patient: [Name]"
    * "Treatment: [Treatment]"
    * "Date: [Now]"
* Action: Open a `PrintPreviewDialog` so the user can see/print it.

### Phase 4: User Interface
1.  **Main Navigation:** Use a `MenuStrip` or a Side Panel (Buttons) to navigate between views.
2.  **Design:** Keep the `ThrillX` aesthetic (Flat buttons, simple colors).
3.  **Responsiveness:** Do not implement complex resizing. Use standard `Anchor` properties.

---

## 6. Deliverables
* A functional Visual Studio Solution.
* Code must be clean and resemble the reference `ThrillX` project structure.
* **Credentials:** Seed an admin user (`admin` / `password123`).