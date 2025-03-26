📍 Employee Attendance Management System
✨ Overview
The Employee Attendance Management System is a comprehensive desktop application designed to streamline employee attendance tracking, management, and reporting. It supports three main roles—Employee, Admin, and HR—each with specific permissions and functionalities tailored to their responsibilities. Built using C#, Entity Framework Core, Dapper, and WinForms, this application provides a robust and user-friendly solution for managing attendance and employee data.

👥 Roles and Permissions
1. Admin 🖥️
CRUD Operations: Create, read, update, and delete employees and HR users.
System Management: Oversee system-wide settings and configurations.
2. Employee 👤
Check-In/Check-Out: Check in and out daily using a QR code or biometric integration. 📱
Profile Management: View and update personal profile information. ✏️
Leave Requests: Submit leave requests (e.g., Sick Leave, Vacation, Unpaid Leave) to HR in real-time using SignalR. 📅
3. HR 🧑‍💼
Check-In/Check-Out: Check in and out using a QR code or biometric integration. 📱
Profile Management: View and update personal profile information. ✏️
Employee Management: Perform CRUD operations for employees. 👥
🛠️ Features
Employee Management 👥
Add, update, delete, and view employee details (e.g., Name, Employee ID, Department, Position, Email, Phone).
Assign work schedules (Full-time, Part-time, Remote).
Perform CRUD operations for employees.
Attendance Tracking ⏰
Record daily check-ins and check-outs.
Calculate working hours based on check-in/check-out times.
Highlight late arrivals and early departures.
Leave Management 📅
Allow employees to request leave (Sick Leave, Vacation, Unpaid Leave).
Enable HR to approve or reject leave requests.
Track total leave days per employee.
Reports & Logging 📊
Generate attendance reports:
✅ Daily, weekly, and monthly attendance.
✅ Late arrivals and early departures.
✅ Employees with frequent absences.
Maintain logs of all employee actions (check-ins, check-outs, leave requests).
Bonus Features (Optional) 🌟
Biometric or QR Code integration for attendance tracking. 📷
Export reports to Excel or PDF formats. 📈
Real-time notifications for late arrivals using SignalR. 🔔
💻 Technology Stack
Programming Language: C#
Framework: .NET (WinForms)
Database: SQL Server
ORM: Entity Framework Core, Dapper
UI Components: WinForms
⚙️ Technical Requirements
Uses Entity Framework Core for database interactions. -ões Implements CRUD operations for employees and attendance records.
Follows a Code-First Approach for database migrations.
Includes validation and error handling (e.g., preventing duplicate check-ins).
Supports role-based authentication (Admin, HR, Employee).
📦 Setup Instructions
Prerequisites
.NET Framework (version 6.0 or higher)
SQL Server (Express or higher)
Visual Studio (2019 or later recommended)
Installation
Clone the Repository:
bash

Collapse

Wrap

Copy
git clone https://github.com/[YourUsername]/[YourRepoName].git
Open the Project:
Open the .sln file in Visual Studio.
Configure the Database:
Update the connection string in appsettings.json or App.config with your SQL Server details.
Run this command in the Package Manager Console to apply migrations:
bash

Collapse

Wrap

Copy
Update-Database
Build and Run:
Press F5 in Visual Studio to build and launch the application.
