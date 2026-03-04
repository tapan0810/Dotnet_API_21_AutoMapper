# Student Management System API

## Overview

Student Management System API is a RESTful backend application built using **ASP.NET Core Web API**, **Entity Framework Core**, and **AutoMapper**.
The API provides a structured way to manage student records by implementing standard **CRUD operations (Create, Read, Update, Delete)** while following clean architecture practices.

The project demonstrates important backend development concepts such as **DTO-based architecture**, **service layer implementation**, **dependency injection**, and **object mapping using AutoMapper**. The application separates database entities from API response models using **Data Transfer Objects (DTOs)** to improve maintainability and security.

This project is designed as a practical example for developers learning modern **.NET backend development** and how to structure scalable Web APIs.

---

## Features

* RESTful API built with ASP.NET Core
* CRUD operations for managing student records
* DTO pattern to separate API contracts from database models
* AutoMapper integration for entity-to-DTO mapping
* Entity Framework Core for database access
* SQL Server database with EF Core migrations
* Service layer architecture
* Dependency Injection for loose coupling
* Clean and modular project structure

---

## Technology Stack

* **.NET / ASP.NET Core Web API**
* **C#**
* **Entity Framework Core**
* **AutoMapper**
* **SQL Server**
* **Swagger / Scalar API Documentation**

---

## Project Structure

```
Dotnet_API_21_
│
├── Data
│   └── StudentDbContext.cs
│
├── Entities
│   ├── Models
│   │   └── Student.cs
│   │
│   └── Dtos
│       ├── CreateStudentDto.cs
│       ├── UpdateStudentDto.cs
│       ├── GetStudentByIdDto.cs
│       └── GetAllStudentsDto.cs
│
├── Mapping
│   └── StudentMappingProfile.cs
│
├── Service
│   ├── IStudentService.cs
│   └── StudentService.cs
│
├── Controllers
│   └── StudentController.cs
│
├── Migrations
│
├── appsettings.json
└── Program.cs
```

---

## API Endpoints

### Get All Students

```
GET /api/Student/GetAllStudents
```

### Get Student By Id

```
GET /api/Student/{id}
```

### Add Student

```
POST /api/Student/AddStudent
```

Request Body Example:

```json
{
  "studentName": "John Doe",
  "studentEmail": "john@example.com",
  "studentPhone": "9876543210",
  "isActive": true
}
```

### Update Student

```
PUT /api/Student/{id}
```

### Delete Student

```
DELETE /api/Student/{id}
```

---

## Database Setup

1. Configure connection string in **appsettings.json**

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=.;Database=StudentDB;Trusted_Connection=True;TrustServerCertificate=True"
}
```

2. Run migrations

```
Add-Migration InitialCreate
Update-Database
```

This will create the database and required tables.

---

## Running the Project

1. Clone the repository

```
git clone https://github.com/your-username/student-management-api.git
```

2. Navigate to the project folder

```
cd Dotnet_API_21_
```

3. Run the application

```
dotnet run
```

4. Open API documentation

```
https://localhost:xxxx/swagger
```

or

```
https://localhost:xxxx/scalar
```

---

## Learning Outcomes

This project demonstrates:

* Building RESTful APIs with ASP.NET Core
* Implementing DTO pattern
* Using AutoMapper for object mapping
* Implementing service layer architecture
* Using Entity Framework Core with migrations
* Dependency Injection in .NET
* Structuring scalable backend applications

---

## Future Improvements

* Add authentication and authorization (JWT)
* Implement global exception handling middleware
* Add FluentValidation for DTO validation
* Implement repository pattern
* Add unit testing with xUnit or NUnit

---

## Author

**Tapan Ray**
