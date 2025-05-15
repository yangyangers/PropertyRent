# Group 7: Property Rental Website
###Members at the end

A property rental web application built with ASP.NET Core MVC. This project allows property owners to list rental properties and helps seekers find suitable accommodation based on their preferences.

---
## 📦 Technologies Used
- ASP.NET Core MVC (C#)
- Entity Framework Core
- SQL Server / LocalDB
- Visual Studio 2022
- Razor Views
- Bootstrap (for styling)

---
## 🚀 How to Download and Run the Project
### Prerequisites
- Visual Studio 2022 
- .NET 7.0 SDK or later
- SQL Server (LocalDB or full version)

### Steps
1. **Clone or Download the Project**
   - Clone:
     ```bash
     git clone https://github.com/yangyangers/PropertyRent.git
     ```
   - Or download as ZIP from your repository link, then extract it.

2. **Open the Project**
   - Launch Visual Studio.
   - Open the `PropertyRent.sln` file.

3. **Restore NuGet Packages**
   - Visual Studio will automatically restore dependencies.
   - If not, go to `Tools` > `NuGet Package Manager` > `Manage NuGet Packages for Solution` and restore manually.

4. **Configure the Database**
   - The database connection is configured in `appsettings.json`
   - Update it to match your SQL Server or LocalDB configuration if needed.
   - Run the following in Package Manager Console:
     ```
     Update-Database
     ```

5. **Run the App**
   - Press `Ctrl + F5` or click `Start Without Debugging`.
   - The app will launch in your browser.

---
## 📌 Features
- Browse available properties for rent
- Search and filter properties based on various criteria
- Property details view with images and descriptions
- Property management for owners (add, edit, delete listings)
- Responsive design for mobile and desktop viewing

---
## 👤 Authors
**Group 7**
- [Asid, Shane Mae]
- [Lopez, Shaznay Samantha]
- [Medina, MetchJhon]
- [Sebios, Simon Jhade]
- [Ytang Elgie]
