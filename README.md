![E-Learning Platform](https://via.placeholder.com/800x200.png?text=E-Learning+Platform)

An advanced e-learning platform for managing courses, students, and evaluations, built with ASP.NET Core and MySQL.

## Table of Contents

- [Features](#features)
- [Technologies Used](#technologies-used)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
- [Usage](#usage)
- [API Endpoints](#api-endpoints)

## Features

- User Management (Admin, Teacher, Student)
- Course Management
- Module and Lesson Management
- Evaluations and Submissions
- Messaging System
- Notifications
- Responsive Design

## Technologies Used

- **Backend**: ASP.NET Core, Entity Framework Core
- **Database**: MySQL
- **Frontend**: Vue.js (planned)
- **Containerization**: Docker (optional)
- **Development Tools**: Visual Studio Code, XAMPP

## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download)
- [XAMPP](https://www.apachefriends.org/index.html) (for MySQL)
- [Node.js](https://nodejs.org/) (for frontend, if applicable)

### Installation

1. **Clone the repository**

   ```bash
   git clone https://github.com/your-username/e-learning-platform.git
   cd e-learning-platform
2. **Set up the database**

    ```bash
    Start XAMPP and ensure MySQL is running.
    Open phpMyAdmin and create a database named ELearningDb.```
3. **Configure the application**

    Update the connection string in **appsettings.json**

```json
{
      "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Database=ELearningDb;User=root;Password=;TreatTinyAsBoolean=true;"
      },
      "Logging": {
        "LogLevel": {
          "Default": "Information",
          "Microsoft": "Warning",
          "Microsoft.Hosting.Lifetime": "Information"
        }
      },
      "AllowedHosts": "*"
    }
```


4. Install dependencies and run migrations

```bash

dotnet restore
dotnet ef migrations add InitialCreate
dotnet ef database update
```

## Run the application

```bash

    dotnet run

    Navigate to the application

    Open your browser and go to https://localhost:5001.
```
### Usage

    API Endpoints: The application exposes several API endpoints for managing users, courses, modules, lessons, evaluations, submissions, messages, and notifications. Detailed documentation for each endpoint is available in the API Documentation.

### API Endpoints
User Endpoints

    GET /api/user
    GET /api/user/{id}
    POST /api/user
    PUT /api/user/{id}
    DELETE /api/user/{id}

## Course Endpoints

    GET /api/course
    GET /api/course/{id}
    POST /api/course
    PUT /api/course/{id}
    DELETE /api/course/{id}

## Swagger UI
![image](https://github.com/ShHaWkK/E-learning-Platform/assets/51519814/908fabaf-d4e8-4422-9464-7150f2f46de3)
