var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
    app.UseCors();
}
else
    app.UseHttpsRedirection();

// Controller Endpoint
app.MapGet("api/meals", () =>
{
    meal_planning_api.Meal[] meals =
    {
        new() { Id = 1, Name = "Spaghetti" },
        new() { Id = 2, Name = "Pizza" },
        new() { Id = 3, Name = "Steak" },
        new() { Id = 4, Name = "Porkchops" },
        new() { Id = 5, Name = "Hamburgers" },
        new() { Id = 6, Name = "Meatball Subs" },
        new() { Id = 7, Name = "Pancakes" }
    };

    return meals;
});

app.Run();