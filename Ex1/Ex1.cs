// Найти точку пересечения двух прямых заданных уравнением 
// y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
Console.WriteLine("Enter numner b1: ");
int b1 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Enter numner k1: ");
int k1 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Enter numner b2: ");
int b2 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Enter numner k2: ");
int k2 = int.Parse(Console.ReadLine() ?? "0");

int x = (b1 - b2) / (k2 - k1);
int y = b1 * x + k1;

Console.WriteLine ($"Intersection point ({x} , {y})");