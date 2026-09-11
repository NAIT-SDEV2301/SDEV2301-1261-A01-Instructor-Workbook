Console.Write("Enter a number to add to the sum, 0 to quit: ");
int value = int.Parse(Console.ReadLine() ?? "");
int sum = 0;
while (value != 0)
{
	sum += value;
    Console.Write("Enter a number to add to the sum, 0 to quit: ");
    value = int.Parse(Console.ReadLine() ?? "");

}

Console.WriteLine($"Sum = {sum}");
