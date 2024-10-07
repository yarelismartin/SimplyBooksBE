# Simply Books

Simply Books is a C# backend API application designed to manage books and authors. It enables users to perform CRUD operations efficiently.

## Table of Contents

- [Get Started](#get-started)
- [Features](#features)
- [Planning](#planning)
- [API Endpoints](#api-endpoints)
- [Postman Documentation](#postman-documentation)
- [Video API Walkthrough](#video-api-walkthrough)
- [Tech Stack](#tech-stack)
- [Contributors](#contributors)

---

## Get Started

Follow these steps to set up the **Simply Books API**:

#### 1. Fork and Clone the Repository
Fork the repository, then clone it to your local machine.

#### 2. Open in Visual Studio 2022
Open the solution file (`.sln`) in **Visual Studio 2022**.

#### 3. Restore Dependencies
Run the following command to restore project dependencies:

```bash
dotnet restore
```

#### 4. Configure User Secrets
Initialize user secrets and set your PostgreSQL connection string:

```bash
dotnet user-secrets init
dotnet user-secrets set "ConnectionStrings:DefaultConnection" "Host=localhost;Database=SimplyBooksDB;Username=postgres;Password=<your_postgresql_password>"
```

Replace `<your_postgresql_password>` with your actual database password.

#### 5. Apply Migrations and Create the Database
Run the following command to apply the existing migrations and create the database:

```bash
dotnet ef database update
```

#### 6. Start Debugging
Run the project in debug mode by selecting the **Start Debugging** option in Visual Studio. This will launch the API, and you can access Swagger to test the endpoints.

#### 7. Test the API
Use **Postman** or Swagger UI to interact with the API and test CRUD operations for books and authors.

## Features

- Users can **Create**, **Read**, **Update**, and **Delete** both books and authors.
- Comprehensive API documentation is available.

## Planning
- [Project Board](https://github.com/users/yarelismartin/projects/12/views/1)

## API Endpoints

| Method | Endpoint                    | Description                           |
|--------|-----------------------------|---------------------------------------|
| GET    | `/api/books`                | Retrieve all books                   |
| GET    | `/api/books/users.{uid}`    | Retrieve all books by uid            |
| GET    | `/api/books/{id}`           | Retrieve a specific book by ID       |
| POST   | `/api/books`                | Create a new book                    |
| PUT    | `/api/books/{id}`           | Update a specific book by ID         |
| DELETE | `/api/books/{id}`           | Delete a specific book by ID         |
| GET    | `/api/authors`              | Retrieve all authors                 |
| GET    | `/api/authors/users.{uid}`  | Retrieve all authors by uid          |
| GET    | `/api/authors/{id}`         | Retrieve a specific author by ID     |
| POST   | `/api/authors`              | Create a new author                  |
| PUT    | `/api/authors/{id}`         | Update a specific author by ID       |
| DELETE | `/api/authors/{id}`         | Delete a specific author by ID       |

## Postman Documentation

The API documentation is available in Postman, providing a detailed guide on how to interact with the Simply Books API.

- [Simply Books API Documentation](https://documenter.getpostman.com/view/31992966/2sAXxMhDxo)

## Video API Walkthrough


## Tech Stack

- C#
- ASP.NET Core
- Entity Framework Core
- SQL Server

## Contributors

- [Yarelis Martin](https://github.com/yarelismartin)
