using Lesson17_EFCoreCRUDRelationships;

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

