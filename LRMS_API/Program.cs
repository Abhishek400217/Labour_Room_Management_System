using LRMS_API.Data;
using LRMS_API.Repositories;
using LRMS_API.Services;
var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<SqlConnectionFactory>();
builder.Services.AddScoped<LoginRepository>();
builder.Services.AddScoped<LoginService>();

// Dependency Injection
builder.Services.AddSingleton<SqlConnectionFactory>();

var app = builder.Build();

// Configure
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();