Console.Write("Temperature in celsius: ");
int temperature = int.Parse(Console.ReadLine() ?? "0");
if (temperature >= 20)
{
    Console.WriteLine("Warm");
}
else
{
    Console.WriteLine("Cool");
}