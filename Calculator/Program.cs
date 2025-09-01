using CalculatorApi.Controllers; // <- namespace of CalculatorService

var builder = WebApplication.CreateBuilder(args);

// Register the service
builder.Services.AddSingleton<ICalculator, CalculatorService>();

// Add MVC support
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Calculator}/{action=Index}/{id?}");

app.Run();
