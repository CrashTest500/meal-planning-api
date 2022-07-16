using meal_planning_api.Repositories;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register Services
builder.Services.AddTransient<IMealsRepository, MealsRepository>();

builder.Services.AddCors(c =>
{
    c.AddDefaultPolicy(p =>
    {
        p.WithMethods("GET", "POST");
        p.AllowAnyOrigin();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
    app.UseHttpsRedirection();

app.UseCors();

// Controller Endpoint
app.MapGet("api/meals", async ([FromServices] IMealsRepository mealsRepo) =>
{
    try
    {
        return await mealsRepo.GetMeals();
    }
    catch
    {
        return null;
    }
});

app.Run();