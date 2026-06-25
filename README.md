# 📦 Logistics Management System (LMS) - Backend

An enterprise-grade Logistics Management System backend built with **.NET 8/9** utilizing **Clean Architecture** principles, **Dapper ORM**, and a robust Domain-Driven approach.

---

## 🚀 Architecture Overview

This project is structured following the **Clean Architecture** (Onion Architecture) pattern to ensure high maintainability, testability, and loose coupling.

```
🏠 LMS-Backend
├── 📂 Core
│   ├── 📂 Domain       # Entities, Enums, Value Objects, Domain Exceptions
│   └── 📂 Application  # Interfaces, DTOs, CQRS (Features), Services
├── 📂 Infrastructure   # Dapper Context, Repositories, External APIs (Fuel Service)
└── 📂 Presentation     # Web API Controllers, Middleware, Configurations
```

### Key Architectural Rules Applied:
* **Independence of Frameworks:** The core business logic does not depend on any database or external library.
* **Loose Coupling:** Dependencies are inverted using Interfaces managed via Dependency Injection.

---

## 🛠️ Tech Stack & Tools

* **Backend Framework:** .NET (C#)
* **Data Access:** Dapper (High-Performance Micro-ORM)
* **Database:** Microsoft SQL Server / PostgreSQL
* **External Integrations:** Fuel Price API Service (Real-time tracking)

---

## ⚙️ Features (Current & Upcoming)

- [x] **Domain Modeling:** Structured Core Domain Entities (Drivers, Vehicles, Shipments) applying OOP encapsulations.
- [ ] **Data Persistence:** Optimized repository pattern implementations with Dapper.
- [ ] **Fuel Management Service:** Automated external API integration to fetch and log daily fuel prices.
- [ ] **RESTful Endpoints:** Secure Web API with global error handling middleware.

---

## 🚀 Getting Started

### Prerequisites
* [.NET SDK](https://dotnet.microsoft.com/download) (Version 8.0 or newer)
* Your preferred IDE (Visual Studio / VS Code / JetBrains Rider)

### Installation & Run

1. Clone the repository:
```
   git clone [https://github.com/igabriel07/Logistics-Management-System.git](https://github.com/igabriel07/Logistics-Management-System.git)
```
2. Navigate to the backend directory:
```
    cd LMS-Backend
```

3. Restore dependencies:
```
    dotnet restore
```

4. Run the API project:
```
    dotnet run --project Presentation
```

👤 Developer
Gabriel Ilikidis - Initial Work / Architecture - @igabriel07