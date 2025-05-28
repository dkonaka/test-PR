// Program.cs
// This is the entry point for the ASP.NET Core application
// It configures the application services and middleware pipeline

// Create a WebApplicationBuilder which provides the services and configuration needed to build the app
var builder = WebApplication.CreateBuilder(args);

// Add services to the dependency injection container
// AddControllersWithViews registers services for MVC controllers with views
builder.Services.AddControllersWithViews();

// Build the WebApplication instance with all the configured services
var app = builder.Build();

// Configure the HTTP request pipeline with middleware components
// The order of middleware registration is important as it defines the request processing sequence
if (!app.Environment.IsDevelopment())
{
    // In non-development environments, redirect exceptions to the error page
    app.UseExceptionHandler("/Home/Error");
    
    // The default HSTS value is 30 days. You may want to change this for production scenarios.
    // HSTS adds the Strict-Transport-Security header to enforce HTTPS connections
    app.UseHsts();
}

// Redirect HTTP requests to HTTPS
app.UseHttpsRedirection();

// Enable serving static files from the wwwroot folder
app.UseStaticFiles();

// Enable endpoint routing
app.UseRouting();

// Enable authorization capabilities
app.UseAuthorization();

// Configure the default controller route pattern
// This defines how URLs map to controller actions
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Start the application and begin listening for requests
app.Run();