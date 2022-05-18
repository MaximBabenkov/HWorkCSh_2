// Найти расстояние между точками в пространстве 2D/3D
Console.Write("Enter X coordinate of the first point: ");
int x1 = int.Parse(Console.ReadLine()??"0");
Console.Write("Enter Y coordinate of the first point: ");
int y1 = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Enter Z coordinate of the first point");
Console.Write("If there is no Z coordinate - enter 0: ");
int z1 = int.Parse(Console.ReadLine()??"0");
Console.Write("Enter X coordinate of the second point: ");
int x2 = int.Parse(Console.ReadLine()??"0");
Console.Write("Enter Y coordinate of the second point: ");
int y2 = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Enter Z coordinate of the second point");
Console.Write("If there is no Z coordinate - enter 0: ");
int z2 = int.Parse(Console.ReadLine()??"0");
int sum = (x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1);
double dist = Math.Sqrt(sum);
Console.Write($"The distance between these points is: {Math.Round(dist,2)}");
