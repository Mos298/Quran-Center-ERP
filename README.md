# Quran Center ERP 📖✨

> A comprehensive Enterprise Resource Planning (ERP) desktop application designed to streamline administrative, academic, and tracking workflows for Quranic memorization centers.

![C#](https://img.shields.io/badge/Language-C%23-blue)
![Framework](https://img.shields.io/badge/Framework-.NET-purple)
![Database](https://img.shields.io/badge/Database-MS%20SQL%20Server-red)
![Platform](https://img.shields.io/badge/Platform-Windows%20(WinForms)-lightgrey)

---

## 📌 Overview

**Quran Center ERP** provides a centralized system for managing students, teachers, supervisors, and administrative data entry. Built with C# and Microsoft SQL Server, it addresses common tracking challenges in Quranic institutions by offering real-time progress monitoring, structured role management, and detailed academic reporting.

---

## 🚀 Key Features

- **Academic & Progress Tracking:** Record daily memorization (*Hifz*), revision (*Muraja'a*), and attendance metrics.
- **Role-Based Access Modules:** Dedicated modules organized by user responsibility:
  - **Data Entry (`A_Data_entry_A`)**
  - **Supervisors (`B_Supervisors_B`)**
  - **Monitors (`C_monetor_C`)**
  - **Teachers (`D_the_techer_D`)**
  - **Students (`E_Student_E`)**
- **Automated Reporting:** Generate comprehensive performance reports and student tracking analytics.
- **Database Backup & Recovery:** Pre-configured SQL database backup included for rapid deployment.

---

## 🛠️ Tech Stack & Prerequisites

### Tech Stack
* **Programming Language:** C#
* **Framework:** .NET (.NET Framework / .NET Core)
* **UI Framework:** Windows Forms (WinForms)
* **Database:** Microsoft SQL Server

### Prerequisites
Ensure you have the following installed on your machine before running the project:
* [Visual Studio 2022](https://visualstudio.microsoft.com/) (with **.NET desktop development** workload)
* [Microsoft SQL Server](https://www.microsoft.com/en-us/sql-server/) & [SQL Server Management Studio (SSMS)](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms)

---

## 📦 Installation & Setup

### 1. Database Restoration
1. Open **SQL Server Management Studio (SSMS)** and connect to your database instance.
2. Right-click **Databases** -> **Restore Database...**
3. Select **Device**, locate the provided backup file at `Database/QuranCenterDB.bak`, and complete the restore process.

### 2. Project Configuration
1. Clone this repository:
   ```bash
   git clone https://github.com/Mos298/Quran-Center-ERP.git
