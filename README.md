# SuperShop — E-Commerce Management Application

**ASP.NET Core MVC | C# | Microsoft Azure | SQL Server | Xamarin.Forms / Prism**

SuperShop is an e-commerce application developed with C# and ASP.NET Core, combining product and order management, user authentication, relational database operations and integration with Microsoft Azure services.

The solution also includes mobile application projects targeting Android and iOS using Xamarin and Prism.

## Project Overview

SuperShop demonstrates the development of a web-based commerce system with cloud service integration, database persistence and reusable application components.

The project includes:

- **ASP.NET Core MVC Web Application** — Web interface and business operations.
- **API Controllers** — Endpoints supporting application functionality.
- **Mobile Projects** — Xamarin/Prism application structure for Android and iOS.
- **Azure Integration** — Cloud storage and Azure SQL Database deployment configuration.

## Key Features

- Product management
- Order management
- User registration and authentication
- Account and password management
- Country and location data management
- Product image upload using Azure Blob Storage
- Database operations using Entity Framework Core
- Repository Pattern for data access

## Microsoft Azure Integration

### Azure Blob Storage

The application includes a `BlobHelper` service that uses Azure Storage SDK components to upload files to blob containers.

This demonstrates cloud-based file storage integration, including support for file uploads, byte arrays and file streams.

### Azure SQL Database

The project includes deployment configuration referencing Azure SQL Database.

This demonstrates integration of SQL Server-based persistence with Azure cloud infrastructure.

## Technology Stack

| Category | Technologies |
|---|---|
| Language | C# |
| Backend | ASP.NET Core 5, ASP.NET Core MVC |
| Database | SQL Server, Entity Framework Core |
| Cloud | Microsoft Azure Blob Storage, Azure SQL Database |
| Authentication | ASP.NET Core Identity, JWT |
| Mobile | Xamarin, Prism, Android, iOS |
| Architecture | Repository Pattern, Dependency Injection |
| Tools | Visual Studio, Git, GitHub |

## Solution Structure

```text
SuperShop/
├── SuperShop.Web/
│   ├── Controllers/
│   ├── Data/
│   ├── Helpers/
│   ├── Migrations/
│   ├── Models/
│   ├── Views/
│   └── wwwroot/
│
├── SuperShop.Prism/
│   ├── SuperShop.Prism/
│   ├── SuperShop.Prism.Android/
│   └── SuperShop.Prism.iOS/
│
└── SuperShop.sln
```

## Architecture

The ASP.NET Core MVC application handles web requests and application operations.

Entity Framework Core provides database access, while repository classes encapsulate data operations.

ASP.NET Core Identity supports user management and authentication, with JWT authentication configured for API access.

Azure Blob Storage is integrated through a dedicated helper service for file uploads.

The solution also contains Xamarin/Prism mobile projects for Android and iOS.

## Technical Highlights

This project demonstrates experience with:

- C# and ASP.NET Core development
- Integration with Microsoft Azure services
- Relational database management
- Authentication and authorization
- Repository Pattern and Dependency Injection
- Web and mobile application development
- Working with cloud storage and deployment configurations

## Project Notes

This project targets .NET 5 and uses Xamarin-based mobile technologies. These are legacy frameworks and may require an appropriately configured development environment.

The repository demonstrates Azure integration in the source code and deployment configuration; availability of live cloud services is not guaranteed.

## Author

**Reinaldo Espindola Souza**

[LinkedIn](https://www.linkedin.com/in/reinaldoespindolasouza) |
