📋 ##Todo List MVC Application

A simple ASP.NET Core 8 MVC application for managing tasks with CRUD operations, priority levels, status tracking, and due date management.

🏗️ ##Architecture

The project follows a 3-tier architecture:
```bash
Presentation Layer (MVC)
├─ Controllers
├─ Views
└─ ViewModels
       │
Business Logic Layer
├─ Services
├─ DTOs
└─ AutoMapper Profiles
       │
Data Access Layer
├─ DbContext
├─ Models
├─ Repository Pattern
└─ EF Core Migrations
```

🚀 ##Features

✨ CRUD operations for todos
📊 Status tracking: Pending, In Progress, Completed
🎯 Priority levels: Low, Medium, High
📅 Due date management
🕒 Automatic timestamp tracking (Created/Modified dates)
📱 Responsive design with Bootstrap
🎨 Clean and intuitive UI


🛠️ ##Technologies Used
Framework: ASP.NET Core 8.0 MVC
Database: SQL Server
ORM: Entity Framework Core 8.0
Mapping: AutoMapper 16.0
UI Framework: Bootstrap 5
Icons: Bootstrap Icons
Target Framework: .NET 8.0


📋 ##Prerequisites

Before running this application, ensure you have:
.NET 8.0 SDK or later
SQL Server (Express or higher)
Visual Studio 2022 or Visual Studio Code
SQL Server Management Studio (optional, for database management)


⚙️ ##Installation & Setup
Clone the repository
```bash
git clone https://github.com/yourusername/todolist-app-mvc.git
cd todolist-app-mvc
```


📁 ##Project Structure
```bash
TodoList-App-Mvc/
├── TodoList-App-Mvc (Presentation Layer)
│   ├── Controllers/
│   │   ├── HomeController.cs
│   │   └── TodoController.cs
│   ├── Views/
│   │   ├── Todo/
│   │   │   ├── Index.cshtml
│   │   │   ├── Create.cshtml
│   │   │   ├── Edit.cshtml
│   │   │   ├── Details.cshtml
│   │   │   └── Delete.cshtml
│   │   └── Shared/
│   ├── ViewModels/
│   └── Program.cs
│
├── Business-Logic-Layer/
│   ├── DTO/
│   │   ├── TodoDto.cs
│   │   └── AddOrUpdateTodoDto.cs
│   ├── Services/
│   │   ├── Interface/
│   │   │   └── ITodoService.cs
│   │   └── Class/
│   │       └── TodoService.cs
│   └── Profiles/
│       └── MappingProfile.cs
│
└── Data-Access-Layer/
    ├── Models/
    │   ├── Todo.cs
    │   └── Enum/
    │       ├── Status.cs
    │       └── Priority.cs
    ├── Data/
    │   ├── Context/
    │   │   └── TodoDbContext.cs
    │   ├── Configurations/
    │   │   └── TodoConfiguration.cs
    │   ├── Repository/
    │   │   ├── Interface/
    │   │   │   └── ITodoAppRepository.cs
    │   │   └── Class/
    │   │       └── TodoAppRepository.cs
    │   └── Migrations/
```
👤 ##Author : Mohamed Essam

Your Name

GitHub: @yourusername
