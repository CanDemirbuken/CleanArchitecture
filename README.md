# 🏛️ CleanArchitecture

[![GitHub](https://img.shields.io/badge/GitHub-CanDemirbuken-181717?style=for-the-badge&logo=github)](https://github.com/CanDemirbuken)
![.NET](https://img.shields.io/badge/.NET-10-512BD4?style=for-the-badge&logo=dotnet)
![ASP.NET Core](https://img.shields.io/badge/ASP.NET_Core-10-512BD4?style=for-the-badge&logo=dotnet)
![EF Core](https://img.shields.io/badge/EF_Core-10-6DB33F?style=for-the-badge)
![Identity](https://img.shields.io/badge/Identity-Authentication-0A66C2?style=for-the-badge)
![JWT](https://img.shields.io/badge/JWT-Security-000000?style=for-the-badge)
![CQRS](https://img.shields.io/badge/CQRS-MediatR-FF6F00?style=for-the-badge)
![Status](https://img.shields.io/badge/Status-In_Progress-orange?style=for-the-badge)

---

# 📖 About The Project

CleanArchitecture is a personal learning project built with **ASP.NET Core 10** to study and apply modern backend development practices using the **Clean Architecture** approach.

Instead of focusing only on writing working code, this project aims to understand **why architectural decisions are made**, how different layers communicate, and how production-ready applications can be designed.

The project evolves incrementally as new concepts are learned and implemented, making it both a learning journey and a long-term reference project.

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
- xUnit
- Moq
- Swagger / OpenAPI

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

The solution follows the **Clean Architecture** principles by separating responsibilities into independent layers.

### Domain

Contains enterprise entities and core business rules.

### Application

Contains CQRS, MediatR handlers, validation rules, abstractions and business logic.

### Persistence

Responsible for Entity Framework Core, database context and data access implementations.

### Infrastructure

Contains external services such as authentication, mail services and framework integrations.

### Presentation

Contains API controllers and presentation-related components.

### WebApi

Application entry point responsible for middleware configuration, authentication and dependency registration.

---

# ✨ Features

## Authentication

- ASP.NET Core Identity
- User Registration
- User Login
- JWT Authentication
- Refresh Token
- Mail Service

## Architecture

- Clean Architecture
- CQRS
- MediatR
- Repository Pattern
- Dependency Injection
- AutoMapper

## Validation

- FluentValidation
- Validation Pipeline
- Global Exception Middleware

## API

- RESTful API
- Swagger Documentation
- Authentication & Authorization

## Testing

- Unit Testing
- Moq

---

# 📈 Current Progress

## ✅ Completed

### Project Setup

- [x] Solution architecture
- [x] Layered project structure
- [x] Dependency Injection
- [x] Entity Framework Core integration
- [x] Entity configurations

### CQRS

- [x] MediatR integration
- [x] CQRS foundation
- [x] Command & Query handlers

### Authentication

- [x] ASP.NET Core Identity
- [x] User Registration
- [x] User Login
- [x] JWT Authentication
- [x] Refresh Token implementation
- [x] Mail Service integration

### Validation

- [x] FluentValidation
- [x] Validation Pipeline
- [x] Global Exception Middleware

### Testing

- [x] Unit Tests
- [x] Moq

---

## 🚧 Roadmap

- [ ] Authorization
- [ ] Role-based Authorization
- [ ] Logging

---

# 🎯 Project Goals

This repository is intended to become a production-oriented reference project that demonstrates modern backend development practices using ASP.NET Core and Clean Architecture.

The primary objectives are:

- Learn Clean Architecture principles
- Master CQRS with MediatR
- Build scalable backend applications
- Understand authentication and authorization
- Write maintainable and testable code
- Apply production-oriented design patterns

---

# 📚 Learning Outcomes

Throughout this project I practice and improve my understanding of:

- Software Architecture
- SOLID Principles
- Clean Architecture
- CQRS
- MediatR
- Dependency Injection
- ASP.NET Core Identity
- JWT Authentication
- Refresh Token
- FluentValidation
- Middleware
- Entity Framework Core
- Unit Testing
- Repository Pattern
- API Design

---

# 🤝 Contributing

This repository is primarily maintained as a personal learning project.

Suggestions, discussions and constructive feedback are always welcome.

---

# ⭐ Acknowledgements

This project is inspired by Clean Architecture principles and modern ASP.NET Core development practices.

It is continuously improved as new architectural concepts and production-ready techniques are learned.

---

> **"Learning by building. Improving with every commit." 🚀**
