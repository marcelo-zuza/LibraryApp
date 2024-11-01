# Library Management System

This project is a **Library Management System** built with C# and Entity Framework Core. The application allows users to register books, members, and manage book loans and returns in a library environment. This project simulates a real-world application for junior developers, focusing on CRUD operations, database management, and a layered architecture.

## Table of Contents

- [Features](#features)
- [Technologies Used](#technologies-used)
- [Setup](#setup)
- [Usage](#usage)
- [Project Structure](#project-structure)
- [Contributing](#contributing)
- [License](#license)

---

## Features

- **Book Management**: Add, update, delete, and list books.
- **Member Management**: Register, update, delete, and list members.
- **Loan Management**: Record book loans and returns, check loan status, and enforce loan rules (e.g., due dates).
- **Basic Reporting**: Filter by book availability, author, category, and member.

## Technologies Used

- **C# (.NET Core)**
- **Entity Framework Core** for ORM and SQLite database interaction
- **SQLite** as a lightweight database for data persistence
- **Visual Studio Code** for development

## Setup

1. **Prerequisites**:
   - [.NET SDK](https://dotnet.microsoft.com/download) (version 6 or higher)
   - SQLite database

2. **Clone the repository**:
   ```bash
   git clone https://github.com/your-username/library-management-system.git
   cd library-management-system

3. **Install dependencies: Open the terminal and run**:
    ```bash
    dotnet restore

4. **Set up Entity Framework Core: Install the EF Core CLI (if not already installed)**:
    ```bash
    dotnet tool install --global dotnet-ef

5. **Run database migrations: Generate and apply migrations to create the SQLite database**.
    ```bash
    dotnet ef migrations add InitialCreate
    dotnet ef database update

6. **Run the Application: Start the application in development mode:**
    ```bash
    dotnet run

## Usage
Once the application is running, you can perform the following actions:

* Add a Book: Registers a new book with information such as title, author, category, and availability status.
* List Books: Shows all registered books and allows filtering by category or author.
* Register a Member: Adds a new member with details such as name, email, and address.
* Loan a Book: Allows a registered member to borrow an available book. Books have a maximum loan period of 14 days.

## Project Structure
    ```bash
        LibraryApp/
    ├── Controllers/
    │   ├── LivroController.cs
    │   ├── MembroController.cs
    │   └── EmprestimoController.cs
    ├── Data/
    │   └── BibliotecaContext.cs
    ├── Models/
    │   ├── Livro.cs
    │   ├── Membro.cs
    │   └── Emprestimo.cs
    ├── Program.cs
    └── README.md

* Controllers: Contains the business logic and operations (CRUD) for each entity.
* Data: Houses the DbContext class for database connections.
* Models: Defines the data structure of the main entities.






