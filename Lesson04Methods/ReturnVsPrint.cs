using System.ComponentModel;
using System.Runtime.CompilerServices;

class Program
{
    static void Main()
    {
        PrintSum(4,5);
        int sum = Add(4,5);
        Console.WriteLine(sum * 2);
    }

    static void PrintSum(int a, int b)
    {
        Console.WriteLine(a + b);
    }

    static int Add(int a, int b)
    {
        return a + b;
    }

}