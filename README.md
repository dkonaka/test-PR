# ASP.NET Core 9 Web Application

<!-- 
This README provides comprehensive documentation for the ASP.NET Core 9 web application.
It includes information about the project structure, setup instructions, and development guidelines.
-->

## Project Overview

This project is an ASP.NET Core 9 web application that follows the Model-View-Controller (MVC) architectural pattern. It provides a basic structure for building web applications with ASP.NET Core.

### Architecture Overview

The application follows the standard MVC architecture:
- **Models**: Represent the data and business logic of the application
- **Views**: Handle the presentation and user interface
- **Controllers**: Process incoming requests, interact with models, and return views

## Project Structure

<!-- The following section outlines the main directories and their purposes -->

This project contains the following structure:

- `/Controllers` - Contains controller classes that handle HTTP requests
- `/Models` - Contains model classes that represent data
- `/Views` - Contains Razor views for rendering HTML
  - `/Home` - Views for the Home controller
  - `/Shared` - Shared views like layouts and partials
- `/wwwroot` - Contains static files like CSS, JavaScript, and images
- `/src` - Contains React frontend code (TypeScript)
- `/AspNetCoreApp.Tests` - Contains unit tests for the application

## Getting Started

### Prerequisites

<!-- List of required software and tools needed to run the application -->

- [.NET 9 SDK](https://dotnet.microsoft.com/download)
- [Node.js and npm](https://nodejs.org/) (for React frontend)
- A code editor (Visual Studio, Visual Studio Code, etc.)

### Running the Application

<!-- Step-by-step instructions for running the application locally -->

1. Clone the repository
2. Navigate to the project directory
3. Install frontend dependencies:

```bash
npm install
```

4. Run the application:

```bash
dotnet run
```

5. Open your browser and navigate to `https://localhost:5001` or `http://localhost:5000`

### Building the Application

<!-- Instructions for building the application -->

To build the application, run:

```bash
# Build backend
dotnet build

# Build frontend
npm run build
```

### Running Tests

<!-- Instructions for running tests -->

To run tests, run:

```bash
# Run backend tests
dotnet test

# Run frontend tests
npm test
```

## Development Environment

<!-- Information about different environments and how to configure them -->

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

## Frontend Development

<!-- Information specific to the React frontend -->

The frontend is built with React and TypeScript. Key files include:

- `src/App.tsx` - Main React component
- `src/index.tsx` - Entry point for the React application
- `src/reportWebVitals.ts` - Performance measurement utilities

To start the frontend development server separately:

```bash
npm start
```

## Additional Resources

<!-- Links to external documentation and resources -->

- [ASP.NET Core Documentation](https://docs.microsoft.com/aspnet/core)
- [C# Documentation](https://docs.microsoft.com/dotnet/csharp)
- [Razor Syntax Reference](https://docs.microsoft.com/aspnet/core/mvc/views/razor)
- [React Documentation](https://reactjs.org/docs/getting-started.html)
- [TypeScript Documentation](https://www.typescriptlang.org/docs/)