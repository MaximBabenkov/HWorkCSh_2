// По двум заданным числам определить - является ли одно квадратом другого
Console.WriteLine("Enter your first number");
int a = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Enter your second number");
int b = int.Parse(Console.ReadLine()??"0");
if(a==b*b||b==a*a) 
{
    Console.WriteLine("One number is a square of the other number");
}
else
{
    Console.WriteLine("One number is not a square of the other number");
}
