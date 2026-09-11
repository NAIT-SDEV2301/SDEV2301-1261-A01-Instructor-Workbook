// Console.Write("Enter team size between 9 and 15: ");
// int teamSize = int.Parse(Console.ReadLine() ?? "");
// while (teamSize < 9 || teamSize > 15)
// { 
//     Console.Write("Invalid value. Try again.");
// 	teamSize = int.Parse(Console.ReadLine() ?? ""); 
// }

int teamSize;
do
{
    Console.Write("Enter team size between 9 and 15: ");
    teamSize = int.Parse(Console.ReadLine() ?? "");
} while (teamSize < 9 || teamSize > 15);
