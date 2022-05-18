// Дано число, обозначающее день недели.
// Выяснить - является ли это день выходным 
Console.WriteLine("Enter your number of a day of week");
int a = int.Parse(Console.ReadLine()??"0");
if (a==6||a==7)
{
    Console.WriteLine("It's a day off work");
}
else
{
    Console.WriteLine("It's a working day");
}
