# ASP.NET Core 9 Web Application

## Project Overview

This project is an ASP.NET Core 9 web application that follows the Model-View-Controller (MVC) architectural pattern. It provides a basic structure for building web applications with ASP.NET Core.

### Architecture Overview

The application follows the standard MVC architecture:
- **Models**: Represent the data and business logic of the application
- **Views**: Handle the presentation and user interface
- **Controllers**: Process incoming requests, interact with models, and return views

## Project Structure

This project contains the following structure:

- `/Controllers` - Contains controller classes that handle HTTP requests
- `/Models` - Contains model classes that represent data
- `/Views` - Contains Razor views for rendering HTML
  - `/Home` - Views for the Home controller
  - `/Shared` - Shared views like layouts and partials
- `/wwwroot` - Contains static files like CSS, JavaScript, and images

## Getting Started

### Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/download)
- A code editor (Visual Studio, Visual Studio Code, etc.)

### Running the Application

1. Clone the repository
2. Navigate to the project directory
3. Run the application:

```bash
dotnet run
```

4. Open your browser and navigate to `https://localhost:5001` or `http://localhost:5000`

### Building the Application

To build the application, run:

```bash
dotnet build
```

### Running Tests

To run tests, run:

```bash
dotnet test
```

## Development Environment

The application is configured with different environments:
- **Development**: Used during development
- **Staging**: Used for testing before production
- **Production**: Used for the live application

To specify the environment, set the `ASPNETCORE_ENVIRONMENT` environment variable:

```bash
# Windows
set ASPNETCORE_ENVIRONMENT=Development

# macOS/Linux
export ASPNETCORE_ENVIRONMENT=Development
```

## Additional Resources

- [ASP.NET Core Documentation](https://docs.microsoft.com/aspnet/core)
- [C# Documentation](https://docs.microsoft.com/dotnet/csharp)
- [Razor Syntax Reference](https://docs.microsoft.com/aspnet/core/mvc/views/razor)