
# Employee Management System README

## Project Overview

The Employee Management System is designed to handle the administration and management of employee data. It includes functionalities like managing employee credentials, personal information, roles, and access rights. The system relies on a Microsoft SQL Server database and is built using .NET Core 9.0. 
The Employee Management System functionality is used to authenticate and authorize users within the application.

This README provides a step-by-step guide for setting up the project, restoring the database, configuring the connection, and building the application.

---

## Prerequisites

Ensure you have the following prerequisites installed and set up before proceeding with the installation:

- .NET Core 9.0 SDK installed on your machine.
- Microsoft SQL Server instance to host the database.
- SQL Server Management Studio (SSMS) or an equivalent SQL management tool.
- Basic knowledge of JSON and MS SQL.

---

## 1. Project Setup

Follow these steps to set up the Employee Management System.
### 1.1 Restore the Database

The Employee Management System relies on a database for storing employee details and authentication data. The database backup file is located inside the **Database Folder**. You will need to restore this database to your SQL Server instance.

Steps to restore the database:

1. Locate the **Database Folder** in the project directory.
2. Inside the folder, you should find a `.bak` backup file.
3. Open **SQL Server Management Studio (SSMS)** or your preferred SQL tool.
4. In SSMS, connect to your SQL Server instance.
5. Right-click on **Databases** and select **Restore Database**.
6. Select **Device** as the source and locate the `.bak` file from the **Database Folder**.
7. Choose the destination database name and click **OK** to restore.

The database will be restored and ready for use by the system.

---

## 2. Configuration

### 2.1 Configure Database Connection

To configure the database connection, you must modify the `appsettings.json` file located in the root directory of the project.

1. Open the `appsettings.json` file in a text editor or IDE.
2. Locate the **ConnectionStrings** section.
3. Update the `DefaultConnection` string to match your database settings. Example:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=<YOUR_SERVER_NAME>;Database=<YOUR_DATABASE_NAME>;User Id=<YOUR_USERNAME>;Password=<YOUR_PASSWORD>;"
  }
}
```

- Replace `<YOUR_SERVER_NAME>` with the name of your SQL Server instance (e.g., `localhost` or `myserver`).
- Replace `<YOUR_DATABASE_NAME>` with the name of the restored database (e.g., `EmployeeDB`).
- Replace `<YOUR_USERNAME>` and `<YOUR_PASSWORD>` with your SQL Server authentication details (if using SQL authentication).

### 2.2 Administrator Credentials

The administrator email and password are essential for system access. These are configured as the default credentials for logging into the system:

- **Administrator Email:** `admin@system.com`
- **Password:** `Admin@2030`

These credentials are used for accessing the admin panel where employee data and roles are managed.

---

## 3. Build and Run the Application

After completing the configuration, you are ready to build and run the **Employee Management System**.

### 3.1 Build the Application

Open a terminal or command prompt and navigate to the root folder of your project. Run the following command to build the application:

```bash
dotnet build
```

This will restore all dependencies, compile the application, and prepare it for running.

### 3.2 Run the Application

To run the application, use the following command:

```bash
dotnet run
```

This command will start the web application, and you should be able to access it via your browser.



If needed, download and install **.NET Core 9.0** from the official Microsoft website.


You have successfully set up the **Employee Management System**. The system is now connected to the SQL Server database and is ready for managing employees. If you face any issues reach out for further assistance.

