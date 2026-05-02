# ✈️ EgyptAir Flight Management System

![C#](https://img.shields.io/badge/C%23-.NET-blue) ![Windows Forms](https://img.shields.io/badge/UI-Windows%20Forms-blue) ![Oracle](https://img.shields.io/badge/DB-Oracle-teal) ![Crystal Reports](https://img.shields.io/badge/Reports-Crystal%20Reports-orange) ![Status](https://img.shields.io/badge/Status-Complete-brightgreen)

A desktop application for managing airline operations including users, bookings, passengers, and reports.

---

## 📑 Table of Contents

- [Phase 1 — Requirements & Design](#phase-1--requirements--design)
- [Phase 2 — Implementation](#phase-2--implementation)
  - [Database](#database--8-oracle-tables)
  - [Forms](#forms)
  - [Reports](#reports)
- [How to Run](#how-to-run)
- [Tech Stack](#tech-stack)

---

## Phase 1 — Requirements & Design

Full requirements specification and system design, delivered as an SRS document alongside Use Case and Sequence diagrams.

| File | Description |
|------|-------------|
| `SRS.pdf` | Introduction, User Requirements, Functional & Non-Functional Requirements |
| `Sequence Diagram.pdf` | Book Flight sequence diagram |
| `Use Case Diagram.pdf` | Both actors and all 9 use cases |

---

## Phase 2 — Implementation

Full implementation using C# .NET Windows Forms connected to an Oracle Database backend.

### Database — 8 Oracle Tables

| Table | Description |
|-------|-------------|
| `USERS` | System accounts with roles (admin, passenger, etc.) |
| `PASSENGERS` | Passenger personal details and travel preferences |
| `FLIGHTS` | Flight schedules, routes, and airline information |
| `SEATS` | Seat inventory linked to each flight |
| `BOOKINGS` | Reservation records linking users, flights, and seats |
| `PAYMENTS` | Payment records and statuses for each booking |
| `E_TICKETS` | Electronic ticket generation per booking |
| `NOTIFICATIONS` | System notifications sent to users |

> All tables are linked via foreign key constraints to ensure data integrity.

---

### Forms

| Form | Mode | Description |
|------|------|-------------|
| **Form 1** — Main Menu | — | Entry point. Navigation buttons to all forms and reports. |
| **Form 2** — Manage Users | ODP.NET Connected | View and insert user accounts. Duplicate ID and email validation before insert. |
| **Form 3** — Manage Bookings | ODP.NET Disconnected | Filter bookings by status (pending / confirmed / cancelled / checked_in). Edit records inline and save changes back to the database. |
| **Form 4** — Manage Passengers | ODP.NET Connected | Look up a passenger by ID using a stored procedure. View all passengers via a REF CURSOR stored procedure. |

---

### Reports

| Form | Report | Filter |
|------|--------|--------|
| **Form 5** — Airline Report | `CrystalReport1` | Parameterized by airline name |
| **Form 6** — Payments Report | `CrystalReport5` | Parameterized by payment status |

Both reports are generated using **SAP Crystal Reports** and rendered in an embedded Crystal Report Viewer. Filter values are loaded dynamically from each report's parameter definitions at runtime.

---

## How to Run

1. Make sure **Oracle Database** is installed and running with SID `orcl`
2. Ensure the schema is set up under user `hr` with password `hr`
3. Import all required tables and stored procedures into the `hr` schema
4. Open the solution in **Visual Studio**
5. Restore NuGet packages (ODP.NET, Crystal Reports runtime)
6. Build and run — **Form 1** (Main Menu) will launch automatically

> ⚠️ There is no login screen. Anyone who launches the application has full access to all management screens.

---

## Tech Stack

| Layer | Technology |
|-------|------------|
| Language | C# (.NET Framework) |
| UI | Windows Forms |
| Database | Oracle DB (ODP.NET — `Oracle.DataAccess.Client`) |
| Data Access | ADO.NET — Connected & Disconnected modes |
| Stored Procedures | Oracle PL/SQL (`get_passenger_by_id`, `get_all_passengers`) |
| Reporting | SAP Crystal Reports |
