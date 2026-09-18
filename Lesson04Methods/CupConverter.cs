class Program
{
    static void Main()
    {
        double cups = GetCups();
        double ounces = CupsToOunces(cups);
        DisplayResult(cups, ounces);
    }

    static double CupsToOunces(double cups) => cups * 8.0;

    static void DisplayResult(double cups, double ounces)
    {
        Console.WriteLine($"{cups} cups = {ounces} fluid ounces.");
    }

    static double GetCups()
    {
        double cups = 0;
        Console.Write("Enter the number of cups: ");
        // cups = double.Parse(Console.ReadLine() ?? "");
        while (!double.TryParse(Console.ReadLine(), out cups) || cups < 0)
        {
            Console.WriteLine("Invalid input. Enter a valid number.");
            Console.Write("Enter the number of cups: ");
        }
        return cups;
    }
}