# Simply Books

Simply Books is a C# backend API application designed to manage books and authors. It enables users to perform CRUD operations efficiently.

## Table of Contents

- [Get Started](#get-started)
- [Features](#features)
- [API Endpoints](#api-endpoints)
- [Postman Documentation](#postman-documentation)
- [Tech Stack](#tech-stack)
- [Contributors](#contributors)

---

## Get Started

Clone this repository and execute the following commands to set up the project:

```bash
dotnet build
```

```bash
dotnet publish
```

```bash
dotnet run
```

## Features

- Users can **Create**, **Read**, **Update**, and **Delete** both books and authors.
- Comprehensive API documentation is available.

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

## Tech Stack

- C#
- ASP.NET Core
- Entity Framework Core
- SQL Server

## Contributors

- [Your Name](https://github.com/your-github-url)
