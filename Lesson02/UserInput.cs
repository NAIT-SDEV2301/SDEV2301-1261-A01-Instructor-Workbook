// Prompt and read the user name
Console.Write("Your Name: ");
string name = Console.ReadLine() ?? "no input";
// Print the name using string interpolation
Console.WriteLine($"Hello, {name}!");

