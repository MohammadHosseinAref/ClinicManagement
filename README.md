# Clinic Management System

A robust Windows-based application designed for efficient clinic operations, including patient scheduling and medical record management. Originally developed in 2017, this project was recognized as the **Top Project** of its training program.

## Overview
This system provides a streamlined administrative interface for managing clinic workflows, featuring two distinct access levels: Administrator and Physician. It ensures organized scheduling, automated reporting, and secure data handling for a clinical environment.

## Technical Stack
- **Type:** Windows Application
- **Language:** C#
- **Database:** SQL Server

## Database Setup & Installation
Since this project uses a local SQL Server database, follow these steps to set it up:

1. **Attach Database:**
   - Locate the `.mdf` file in the project folder.
   - Open **SQL Server Management Studio (SSMS)**.
   - Right-click **Databases** > **Attach...** and select your `.mdf` file to integrate it into your instance.
   

2. **Connection Configuration:**
   - Update the `Connection String` in the `App.config` file to match your SQL Server instance name.

3. **Running the Application:**
   - Open the solution file (`.sln`) in Visual Studio.
   - Build and run the project.

---
*Developed by Mohammad Hossein Aref*