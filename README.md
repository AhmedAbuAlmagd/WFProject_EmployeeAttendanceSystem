# ✨ Employee Attendance Management System  

## 📌 Overview  
### The Employee Attendance Management System is a comprehensive desktop application designed to streamline employee attendance tracking, management, and reporting.  
### It supports three main roles—**Employee, Admin, and HR**—each with specific permissions and functionalities tailored to their responsibilities.  
### Built using **C#, Entity Framework Core, Dapper, and WinForms**, this application provides a robust and user-friendly solution for managing attendance and employee data.  

---

## 👥 Roles & Permissions  

### **Admin 🖥️**  
#### - Perform CRUD operations (Employees, HR users, Departments).  
#### - Manage system-wide settings and configurations.  

### **Employee 👤**  
#### - Check-In/Check-Out: Check in and out daily using a QR code or biometric integration. 📱  
#### - Leave Requests: Submit leave requests (e.g., Sick Leave, Vacation, Unpaid Leave) to HR in real-time using SignalR. 📅  

### **HR 🧑‍💼**  
#### - Check-In/Check-Out: Check in and out using a QR code or biometric integration. 📱  
#### - Employee Management: Perform CRUD operations for employees.  

---

## 🛠️ Features  

### **Employee Management 👥**  
#### - Add, update, delete, and view employee details (e.g., Name, Employee ID, Department, Position, Email, Phone).  
#### - Assign work schedules (Full-time, Part-time, Remote).  
#### - Perform CRUD operations for employees.  

### **Attendance Tracking ⏰**  
#### - Record daily check-ins and check-outs.  
#### - Calculate working hours based on check-in/check-out times.  
#### - Highlight late arrivals and early departures.  

### **Leave Management 📅**  
#### - Allow employees to request leave (Sick Leave, Vacation, Unpaid Leave).  
#### - Enable HR to approve or reject leave requests.  
#### - Track total leave days per employee.  

### **Reports & Logging 📊**  
#### - Generate attendance reports:  
  - ✅ **Daily, weekly, and monthly attendance.**  
  - ✅ **Late arrivals and early departures.**  
  - ✅ **Employees with frequent absences.**  
#### - Maintain logs of all employee actions (check-ins, check-outs, leave requests).  

### **Bonus Features (Optional) 🌟**  
#### - Biometric or QR Code integration for attendance tracking. 📷  
#### - Export reports to Excel or PDF formats. 📈  
#### - Real-time notifications for late arrivals using SignalR. 🔔  

---

## 💻 Technology Stack  

### - **Programming Language:** C#  
### - **Framework:** .NET (WinForms)  
### - **Database:** SQL Server  
### - **ORM:** Entity Framework Core, Dapper  
### - **UI Components:** WinForms  

---

## ⚙️ Technical Requirements  

### - Uses Entity Framework Core for database interactions.  
### - Implements CRUD operations for employees and attendance records.  
### - Follows a Code-First Approach for database migrations.  
### - Includes validation and error handling (e.g., preventing duplicate check-ins).  
### - Supports role-based authentication (Admin, HR, Employee).  

---

## 📦 Setup Instructions  

### **1. Prerequisites**  
#### - .NET Framework (version 6.0 or higher)  
#### - SQL Server (Express or higher)  
#### - Visual Studio (2019 or later recommended)  

### **2. Installation**  

#### 1-  Clone the Repository 
``bash

git clone https://github.com/AhmedAbuAlmagd/WFProject_EmployeeAttendanceSystem.git

#### 2- Open the Project:
Open the .sln file in Visual Studio.

#### 3-  Configure the Database:
Update the connection string in  App.config with your SQL Server details.

#### 4- Run this command in the Package Manager Console to apply migrations:
Update-Database

#### 5- Build and Run:
Press F5 in Visual Studio to build and launch the application.

#### 6- Additional Setup 
Create Default Admin User:

Run the following SQL script in SQL Server Management Studio (SSMS) to insert an admin user:

INSERT INTO Users (Username, Password, Role)
VALUES ('admin', 'Admin@123', 'Admin');
