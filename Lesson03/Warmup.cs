using static System.Console; // Enables direct access to all static methods in Console class 
// Prompt for age
// Console.Write("What is your age? ");
Write("What is your age? ");
int age = int.Parse(ReadLine() ?? "0");
if (age >= 18)
{
    WriteLine("Adult");
}
