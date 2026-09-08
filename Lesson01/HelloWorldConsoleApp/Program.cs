namespace HelloWorldConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello, Visual Studio World!");
            Console.Write(" this continues of same line without adding newline");
            Console.WriteLine();
            Console.WriteLine("Write text and create a newline");
            Console.WriteLine("Line 1\nLine 2\nLine 3\n"); // using escape sequence for newline
            Console.WriteLine("""
                Line 1
                Line 2
                Line 3
                """);   // using raw string literal for multiline text
        }
    }
}
