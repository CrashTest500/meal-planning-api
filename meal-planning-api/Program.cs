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
        new() { Id = 7, Name = "Pancakes" },
        new() { Id = 8, Name = "Salmon" },
        new() { Id = 9, Name = "Chicken Fried Rice" },
        new() { Id = 10, Name = "BBQ Chicken" },
        new() { Id = 11, Name = "Pancakes" },
        new() { Id = 12, Name = "Tacos" },
        new() { Id = 13, Name = "Chicken Alfredo" },
        new() { Id = 14, Name = "Chicken Bacon Ranch Pasta" },
        new() { Id = 15, Name = "Chicken Noodle Soup" },
        new() { Id = 16, Name = "Biscuits and Gravy" },
        new() { Id = 17, Name = "Lo Mein" },
        new() { Id = 18, Name = "Sweet and Sour Chicken" },
        new() { Id = 19, Name = "Grilled Cheese" },
        new() { Id = 20, Name = "Lasagna" }
    };

    return meals;
});

app.Run();