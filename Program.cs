// Entry Point for ASP.net Core Web Application (Building Host by Bootstrapping the Application)

var builder = WebApplication.CreateBuilder(args);


// Configure Services and Dependencies Injection (DI) of the Application ( e.g Blazor , MVC , Razor Pages , Database , Authentication)

builder.Services.AddControllers(); 


// Build Application

var app = builder.Build();



// Configure Middleware and Request Pipeline

// app.UseHttpsRedirection();    // Force HTTPS for security
// app.UseAuthorization();       // Enable authentication
app.MapControllers();         // Route requests to controllers


// Endpoint for Testing

app.MapGet("/", () => "Welcome to Simple Book Library Catalog using API! 📚");


// Run Application

app.Run();
