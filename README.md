#PlayStation Management System
Overview
The PlayStation Management System is a comprehensive application designed to manage various aspects of a PlayStation gaming center. It includes features for managing users, devices, expenses, sessions, and more. The application is built using .NET 8 and Windows Forms, with a backend powered by Entity Framework Core.
Features
User Management
•	Add User: Create new user accounts with details such as name, password, and role.
•	Update User: Modify existing user details.
•	Delete User: Soft delete user accounts, marking them as deleted without removing them from the database.
•	Pagination: Display users in a paginated grid for easy navigation.
Device Management
•	Add Device: Add new devices to the system with details such as name, type, and hourly rate.
•	Update Device: Modify existing device details.
•	Remove Device: Remove devices from the system.
•	Device Status: Display the current status of each device (e.g., available, in use).
•	Manage Device: Open a detailed view for managing individual devices.
Expense Management
•	Add Expense: Record new expenses with details such as description, amount, date, and associated user.
•	View Expenses: Display expenses in a paginated grid with details such as description, amount, date, and user.
•	Pagination: Display expenses in a paginated grid for easy navigation.
Session Management
•	Add Session: Start new gaming sessions with details such as start time, end time, device, and total cost.
•	Update Session: Modify existing session details.
•	Delete Session: Remove sessions from the system.
•	Session Reports: Generate reports for sessions based on date ranges (daily, weekly, monthly).
Order Management
•	Add Order: Record new orders with details such as item, quantity, unit price, and total price.
•	View Orders: Display orders associated with sessions.
Cafeteria Management
•	Add Item: Add new items to the cafeteria menu with details such as name, price, and stock.
•	Update Item: Modify existing item details.
•	Remove Item: Remove items from the cafeteria menu.
General Features
•	Global Styles: Apply consistent styling across all forms and controls.
•	Database Integration: Use Entity Framework Core for database operations.
•	Dependency Injection: Use Microsoft.Extensions.DependencyInjection for managing dependencies.
Getting Started
Prerequisites
•	.NET 8 SDK
•	SQL Server
