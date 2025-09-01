# Dependency Injection (DI) Choices

The Calculator MVC application uses **constructor injection** to provide the `CalculatorController` with an `ICalculator` service.

- Service Lifetime: `Singleton`  
  - The calculator service is stateless, so a single instance can safely serve all requests, reducing memory usage and simplifying management.

- Benefits:
  1. **Separation of Concerns** – The controller does not handle calculation logic.  
  2. **Testability** – The service can be replaced with a mock for unit testing.  
  3. **Flexibility** – Future implementations of `ICalculator` can be injected without modifying the controller.

Registration in Program.cs:

```csharp
builder.Services.AddSingleton<ICalculator, CalculatorService>();
