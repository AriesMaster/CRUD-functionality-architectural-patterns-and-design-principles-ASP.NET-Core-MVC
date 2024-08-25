# Telemetry Management Portal

## Overview

This project involves enhancing an existing web application to manage CRUD functionality for project and client data. The focus is on applying architectural patterns and design principles to improve the application's codebase. This application is built using ASP.NET Core MVC and follows the repository pattern to separate data access logic from business logic.

![Screenshot 2024-08-23 143846](https://github.com/user-attachments/assets/c0dd0d3b-a53f-4fc3-bd65-ef69dc39b1b5)



## Requirements

### Functional Requirements

- Manage CRUD operations for projects and clients.
- Implement the repository pattern to manage data access.

### Non-Functional Requirements

- Following best practices in coding and software design.
- Ensuring security by not storing credentials in the repository.

## Design Pattern

### Repository Pattern

The repository pattern is used to encapsulate data access logic, providing a cleaner and more manageable codebase. It separates data access operations from the business logic in the application.

## Implementation

### Repository Classes

Two repository classes have been implemented:

- **ProjectRepository**: Handles all CRUD operations related to `Project` entities.
- **ClientRepository**: Handles all CRUD operations related to `Client` entities.

#### ProjectRepository

- `GetAllProjectsAsync()`: Retrieves all projects.
- `GetProjectByIdAsync(Guid projectId)`: Retrieves a project by its ID.
- `AddProjectAsync(Project project)`: Adds a new project.
- `UpdateProjectAsync(Project project)`: Updates an existing project.
- `DeleteProjectAsync(Guid projectId)`: Deletes a project by its ID.
- `ProjectExistsAsync(Guid projectId)`: Checks if a project exists.

#### ClientRepository

- `GetAllClientsAsync()`: Retrieves all clients.
- `GetClientByIdAsync(Guid clientId)`: Retrieves a client by its ID.
- `AddClientAsync(Client client)`: Adds a new client.
- `UpdateClientAsync(Client client)`: Updates an existing client.
- `DeleteClientAsync(Guid clientId)`: Deletes a client by its ID.

### Transfer Data Access Operations

Data access operations have been moved from the controllers to the respective repository classes:

- **Project Controller**:
  - Uses `ProjectRepository` for data operations.

- **Client Controller**:
  - Uses `ClientRepository` for data operations.

### Implement Repository Classes

The repository classes are now used in the controllers:

- **ProjectsController**:
  - Replaces direct data access code with calls to `ProjectRepository`.

- **ClientsController**:
  - Replaces direct data access code with calls to `ClientRepository`.

# Reference List

- **Microsoft Docs** (n.d.) *Build web apps with ASP.NET Core for beginners*. Available at: [https://learn.microsoft.com/en-us/aspnet/core/?view=aspnetcore-8.0](https://learn.microsoft.com/en-us/aspnet/core/?view=aspnetcore-8.0) (Accessed: 19 August 2024).

- **Microsoft Docs** (n.d.) *ASP.NET MVC Overview*. Available at: [https://learn.microsoft.com/en-us/aspnet/mvc](https://learn.microsoft.com/en-us/aspnet/mvc) (Accessed: 19 August 2024).

- **Microsoft Docs** (n.d.) *Secure a .NET web app with the ASP.NET Core Identity framework*. Available at: [https://learn.microsoft.com/en-us/aspnet/core/security/authentication/identity](https://learn.microsoft.com/en-us/aspnet/core/security/authentication/identity) (Accessed: 19 August 2024).


- **C# Corner** (n.d.) *Design Patterns In C# .NET*. Available at: [https://www.c-sharpcorner.com](https://www.c-sharpcorner.com) (Accessed: 19 August 2024).

- **C# Corner** (n.d.) *Architectural Patterns in .NET*. Available at: [https://www.c-sharpcorner.com](https://www.c-sharpcorner.com) (Accessed: 19 August 2024).
- 
# Reference List Pdf 

[Reference List.pdf](https://github.com/user-attachments/files/16740414/Reference.List.pdf)
