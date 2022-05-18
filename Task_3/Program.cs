// Задать номер четверти, показать диапазон для возможных координат
Console.Write("Enter your number of a quater: ");
int a = int.Parse(Console.ReadLine()??"0");
if(a>0&&a<=4)
{
    if(a==1) Console.WriteLine("The range of possible coordinates: X>0, y>0");
    else if(a==2) Console.WriteLine("The range of possible coordinates: X<0, y>0");
    else if(a==3) Console.WriteLine("The range of possible coordinates: X<0, y<0");
    else if(a==4) Console.WriteLine("The range of possible coordinates: X>0, y<0");
}
else
{
    Console.WriteLine("Your number of a quater is incorrect");
}
