
using Lesson16_IntroductionToEFCoreAndDbContext;
using System.Net.Mime;

using var context = new AppDbContext();
context.Database.EnsureCreated();

Console.WriteLine("Database ready.");

if (!context.Products.Any())
{
    context.Products.AddRange(
        new Product { Name = "Keyboard", Price = 49.99m },
        new Product { Name = "Mouse", Price = 24.99m },
        new Product { Name = "Monitor", Price = 219.9m }
        );

}
