
using Lesson16_IntroductionToEFCoreAndDbContext;
using System.Net.Mime;

using var context = new AppDbContext();
context.Database.EnsureCreated();

Console.WriteLine("Database ready.");
