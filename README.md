#Calculator API / MVC GUI

This is a simple **Calculator web application** built with **ASP.NET Core MVC**. It demonstrates basic arithmetic operations (Add, Subtract, Multiply, Divide) using a **GUI in Razor views**, with **Dependency Injection** for separation of concerns. No extra packages or folders are required.

Structure

- **Controllers/CalculatorController.cs** – Handles user requests, uses `ICalculator` via DI.  
- **Controllers/CalculatorService.cs** – Implements `ICalculator` interface with arithmetic methods.  
- **Views/Calculator/Index.cshtml** – Provides the input form and displays results.  
- **Program.cs** – Registers services, sets up MVC routes.

How It Works

- The controller receives input from the form and calls the service methods.  
- The service performs calculations and returns results.  
- The view displays results or error messages (e.g., division by zero).  
- Default route: `{controller=Calculator}/{action=Index}/{id?}` → visit `https://localhost:7262/` to access the calculator.

Design Notes

- **Separation of Concerns:** Logic in service, request handling in controller, presentation in view.  
- **Dependency Injection:** `CalculatorService` is registered as a singleton and injected into the controller.

Running

1. Open the solution in Visual Studio.  
2. Set **CalculatorApi** as startup project.  
3. Press **F5**.  
4. Navigate to `https://localhost:7262/` to use the calculator.
