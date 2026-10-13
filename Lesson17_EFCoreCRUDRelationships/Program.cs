using Lesson17_EFCoreCRUDRelationships;
using Microsoft.EntityFrameworkCore;

using var context = new AppDbContext();
if (!context.Categories.Any())
{
    var category = new Category { Name = "Electronics" };
    category.Products.Add(new Product { Name = "Keyboard", Price = 49.99m });
    category.Products.Add(new Product { Name = "Mouse", Price = 24.99m });

    var category2 = new Category { Name = "Comestics" };
    context.Add(category);
    context.Add(category2);
    context.SaveChanges();
    var product1 = new Product
    {
        Name = "Unnamed Product",
        Price = 89.99m,
        CategoryId = category2.CategoryId
    };
    context.Add(product1);
    context.SaveChanges();
    Console.WriteLine("Database seeded with data");
}

using var queryContext = new AppDbContext();
var category3 = queryContext.Categories
    //.Include(c => c.Products)
    .First();

Console.WriteLine(category3.Name);
foreach (var product in category3.Products)
    Console.WriteLine($"-{product.Name}: {product.Price:C}");

using var updateContext = new AppDbContext();
var keyboard = updateContext.Products.First(p => p.Name == "Keyboard");
keyboard.Price = 39.99m;
updateContext.SaveChanges();

using var deleteContext = new AppDbContext();
var electronics = deleteContext.Categories.First(c => c.Name == "Electronics");
deleteContext.Remove(electronics);
deleteContext.SaveChanges();
