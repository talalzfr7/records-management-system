# Records Management System

A full-stack records management application built with **ASP.NET Core**, **Entity Framework Core**, **SQL Server**, and **Blazor**, demonstrating a clean separation between backend APIs and frontend UI.

---

## Overview

This project consists of:

- A **RESTful ASP.NET Core Web API** responsible for business logic and data access  
- A **Blazor-based admin interface** that consumes backend APIs over HTTP  
- A **SQL Server database** managed via Entity Framework Core migrations  

The application allows users to create, view, update, delete, and export records stored in the system.

---

## Features

### Backend API
- REST API with controller-based endpoints  
- DTO-based request and response models  
- Entity Framework Core integration with SQL Server  
- Code-first database migrations  

### Frontend (Blazor)
- Blazor-based admin interface  
- API consumption using `HttpClient`  
- Record listing and standard CRUD workflows  

### Data Export
- Export records to **PDF**, **Excel**, and **Word** formats  
- Designed for common reporting and data extraction use cases  

### API Documentation & Testing
- Swagger / OpenAPI documentation  
- Manual endpoint testing using Swagger UI and Postman  

---

## Project Structure

```
/Backend
├── Controllers
├── DTOs
├── Data
├── Services
└── Program.cs

/Frontend
├── Pages
├── Components
└── Services
```

- Backend and frontend are logically separated  
- UI communicates with the backend exclusively via HTTP  
- Database access is restricted to the backend layer



---

## Technology Stack

- C#
- ASP.NET Core Web API
- Entity Framework Core
- SQL Server
- Blazor
- Swagger / OpenAPI
- Postman

---

## Running the Project Locally

### Prerequisites

- .NET SDK 6.0 or later  
- SQL Server (LocalDB or full instance)  
- Visual Studio or Visual Studio Code  

### Setup Steps

1. Clone the repository  
2. Configure the SQL Server connection string in `appsettings.json`  
3. Apply Entity Framework Core migrations to create the database  
4. Run the backend API project  
5. Run the Blazor frontend project  
6. Access Swagger UI for API testing  
7. Use the Blazor interface to manage records  

---

## Current Limitations

- Authentication and authorization are not yet implemented  
- Application is intended to run locally at this stage  
- Deployment configuration is planned but not completed  

---

## Planned Enhancements

- JWT-based authentication  
- Role-based authorization  
- Cloud deployment  
- Environment-based configuration  
- Improved validation and error handling  

---

## Purpose

This project was developed as a **learning and portfolio project** to demonstrate backend-focused application design, REST API development, database integration, and frontend-to-backend communication using modern .NET technologies.
