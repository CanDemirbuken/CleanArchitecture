# 🏛️ CleanArchitecture

[![GitHub](https://img.shields.io/badge/GitHub-CanDemirbuken-181717?style=for-the-badge&logo=github)](https://github.com/CanDemirbuken)
![.NET](https://img.shields.io/badge/.NET-10-512BD4?style=for-the-badge&logo=dotnet)
![ASP.NET Core](https://img.shields.io/badge/ASP.NET_Core-10-512BD4?style=for-the-badge&logo=dotnet)
![EF Core](https://img.shields.io/badge/EF_Core-10-6DB33F?style=for-the-badge)
![Identity](https://img.shields.io/badge/Identity-Authentication-0A66C2?style=for-the-badge)
![JWT](https://img.shields.io/badge/JWT-Security-000000?style=for-the-badge)
![CQRS](https://img.shields.io/badge/CQRS-MediatR-FF6F00?style=for-the-badge)
![Status](https://img.shields.io/badge/Status-Completed-success?style=for-the-badge)

---

# 📖 About The Project

CleanArchitecture is a personal reference project built with **ASP.NET Core 10** to study and apply modern backend development practices using the **Clean Architecture** approach.

The project demonstrates how to build a scalable, maintainable and testable backend application by applying modern architectural principles and production-oriented design patterns.

It serves as a long-term reference for future ASP.NET Core projects.

---

# 🚀 Technologies

- ASP.NET Core 10
- Entity Framework Core
- SQL Server
- ASP.NET Core Identity
- JWT Authentication
- Refresh Token
- MailKit
- CQRS
- MediatR
- AutoMapper
- FluentValidation
- Dependency Injection
- Repository Pattern
- Middleware
- Serilog
- Swagger / OpenAPI
- xUnit
- Moq

---

# 📂 Solution Structure

```text
src
├── Core
│   ├── CleanArchitecture.Application
│   └── CleanArchitecture.Domain
│
├── External
│   ├── CleanArchitecture.Infrastructure
│   ├── CleanArchitecture.Persistence
│   └── CleanArchitecture.Presentation
│
└── CleanArchitecture.WebApi

test
└── CleanArchitecture.UnitTest
```

---

# 🏗️ Architecture

The solution follows **Clean Architecture** principles by separating responsibilities into independent layers.

### Domain

Contains enterprise entities, domain models and business rules.

### Application

Contains CQRS, MediatR handlers, validation rules, abstractions, use cases and business logic.

### Persistence

Responsible for Entity Framework Core, DbContext, repositories and database access implementations.

### Infrastructure

Contains external services such as authentication, mail services, logging and framework integrations.

### Presentation

Contains API controllers and presentation-related components.

### WebApi

Application entry point responsible for middleware configuration, authentication, dependency registration and API configuration.

---

# ✨ Features

## Authentication & Authorization

- ASP.NET Core Identity
- User Registration
- User Login
- JWT Authentication
- Refresh Token
- Role-based Authorization
- Custom Authorization Attribute
- Mail Service

---

## Clean Architecture

- Clean Architecture
- CQRS
- MediatR
- Repository Pattern
- Dependency Injection
- AutoMapper
- Service Installer Pattern

---

## Validation & Middleware

- FluentValidation
- Validation Pipeline
- Global Exception Middleware

---

## API

- RESTful API
- Swagger / OpenAPI
- JWT Authentication
- Authorization
- CORS Configuration

---

## Logging

- Serilog Integration

---

## Testing

- Unit Testing
- Moq

---

# 📚 Implemented Concepts

- Clean Architecture
- SOLID Principles
- CQRS
- MediatR
- Dependency Injection
- Repository Pattern
- Generic Repository
- ASP.NET Core Identity
- JWT Authentication
- Refresh Token
- Authorization
- Custom Authorization Attribute
- FluentValidation
- Validation Pipeline
- Exception Middleware
- Entity Framework Core
- AutoMapper
- Service Installer Pattern
- CORS
- Swagger
- Serilog
- Unit Testing

---

# 🎯 Project Goals

The primary goal of this project is to demonstrate how modern ASP.NET Core applications can be developed using Clean Architecture while keeping the codebase scalable, maintainable and testable.

This project serves as a practical reference for:

- Clean Architecture
- Authentication & Authorization
- CQRS with MediatR
- Dependency Injection
- Validation
- Middleware
- Logging
- Testing

---

# 🤝 Contributing

This repository is maintained as a personal learning and reference project.

Suggestions, discussions and constructive feedback are always welcome.

---

# ⭐ Acknowledgements

This project is inspired by Clean Architecture principles and modern ASP.NET Core development practices.

It was developed to better understand architectural design decisions and serve as a reusable reference for future backend projects.

---

> **"Learning by building. Improving with every commit." 🚀**
