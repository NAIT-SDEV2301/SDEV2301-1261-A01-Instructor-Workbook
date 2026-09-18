using System.Data;
using System.Security.Authentication;

class Program
{
    static void Main()
    {
        Console.WriteLine(MaxValue(4,5));
        Console.WriteLine(MaxValue(4.5, 9.2));
    }

    static int MaxValue(int a, int b) => a > b ? a : b;

    static double MaxValue(double a, double b) => a > b ? a : b;
    
}