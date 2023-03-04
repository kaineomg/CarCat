using CatalogCarDZ.Models;
using CatalogCarDZ.Models.Entity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ApplicationDbContext>();

var app = builder.Build();






app.MapGet("/all", async (HttpContext context, ApplicationDbContext db) =>
{
    return await db.Cars.ToListAsync();

});
app.MapGet("/car/{id}", async (int id, ApplicationDbContext db) =>

    await db.Cars.FindAsync(id)
        is Car cars
            ? Results.Ok(cars)
            : Results.NotFound());
app.MapPost("/add", async (HttpContext context, ApplicationDbContext db) =>
{
    Car? car = await context.Request.ReadFromJsonAsync<Car>();
    if (car != null)
    {
        db.Cars.Add(car);
        db.SaveChanges();
    }
    return car;
});

app.MapDelete("/car/{id}/delete", async (int id,ApplicationDbContext db) =>
{
    if(await db.Cars.FindAsync(id) is Car car)
    {
        db.Cars.Remove(car);
        await db.SaveChangesAsync();
        return Results.Ok(car);
    }
    return Results.NotFound();
}
);
app.Run();