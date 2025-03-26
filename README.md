🕒 Employee Attendance Management System
✨ Overview
The Employee Attendance Management System is a comprehensive desktop application designed to streamline employee attendance tracking, management, and reporting. The system supports three main roles: Employee, Admin, and HR, each with specific permissions and functionalities tailored to their responsibilities. Built with C#, Entity Framework Core, Dapper, and WinForms, this application provides a robust and user-friendly solution for managing attendance and employee data.

👥 Roles and Permissions
1. Admin 🖥️
CRUD Operations: Create, Read, Update, and Delete employees , HR users AND departments.
System Management: Manage system-wide settings and configurations.
View Reports : for attendance of employees and hrs .
3. Employee 👤
Check-In/Check-Out: Employees can check in and check out daily using a QR code or biometric integration. 📱
Leave Requests: Submit leave requests (Sick Leave, Vacation, Unpaid Leave) to HR in real-time using SignalR. 📅
4. HR 🧑‍💼
Check-In/Check-Out: HR can check in and check out. 📱
Employee Management: Perform CRUD operations for employees. 👥
View Reports : for attendance of employees .
Tracking attendance : for employees .
🛠️ Features
Employee Management
Add, update, delete, and view employee details (Name, Employee ID, Department, Position, Email, Phone).
Assign work schedules (Full-time, Part-time, Remote).
Attendance Tracking
Record daily employee check-ins and check-outs.
Calculate working hours based on check-in/check-out times.
Highlight late arrivals and early departures.
Leave Management
Allow employees to request leave (Sick Leave, Vacation, Unpaid Leave).
Enable HR to approve or reject leave requests.
Track total leave days per employee.
Reports & Logging
Generate attendance reports:
✅ Daily, weekly, and monthly attendance.
✅ Late arrivals and early departures.
✅ Employees with frequent absences.
Maintain logs of all employee actions (check-ins, check-outs, leave requests).
Bonus Features (Optional)
QR Code integration for attendance tracking. 📷
Export reports to PDF format. 📊
Real-time notifications for late arrivals. 🔔
💻 Technology Stack
Programming Language: C#
Framework: .NET (WinForms)
Database: SQL Server
ORM: Entity Framework Core
UI Components: WinForms
⚙️ Technical Requirements
Utilizes Entity Framework Core for database interactions.
Implements CRUD operations (Create, Read, Update, Delete) for employees and attendance records.
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
git clone https://github.com/AhmedAbuAlmagd/WFProject_EmployeeAttendanceSystem.git
Open the Project:
Open the .sln file in Visual Studio.
Configure the Database:
Update the connection string in App.config with your SQL Server details.
Run the following command in the Package Manager Console to apply migrations:
bash

Collapse

Wrap

Copy
Update-Database
Build and Run:
Press F5 in Visual Studio to build and launch the application.


📬 Contact
For questions or suggestions, feel free to reach out:

GitHub: YourUsername
Email: [YourEmail@example.com]
