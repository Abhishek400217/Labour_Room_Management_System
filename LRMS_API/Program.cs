using LRMS_API.Data;
using LRMS_API.Repositories;
using LRMS_API.Services;

var builder = WebApplication.CreateBuilder(args);

// =========================
// Services
// =========================

// MVC + Web API
builder.Services.AddControllersWithViews();

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Dependency Injection
builder.Services.AddSingleton<SqlConnectionFactory>();

builder.Services.AddScoped<LoginRepository>();
builder.Services.AddScoped<LoginService>();

var app = builder.Build();

// =========================
// Configure Pipeline
// =========================

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Static Files (CSS, JS, Images)
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// API Controllers
app.MapControllers();

// MVC Route
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();