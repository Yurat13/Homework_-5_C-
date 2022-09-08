// Написать программу масштабирования фигуры 
// Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком 
// (одной строкой) например: "(0,0) (2,0) (2,2) (0,2)" 
// коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5 
// В результате показать координаты, которые получатся. 
// при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"
//  Console.Clear();

// int x1 = 0, y1 = 0,
//     x2 = 4, y2 = 0,
//     x3 = 4, y3 = 4,
//     x4 = 0, y4 = 4;

// Console.WriteLine("Enter multiplication factor: ");
// int k = int.Parse(Console.ReadLine());

// Console.SetCursorPosition (k * x1, k * y1);
// Console.WriteLine("+");

// Console.SetCursorPosition (k * x2, k * y2);
// Console.WriteLine("+");

// Console.SetCursorPosition (k * x3, k * y3);
// Console.WriteLine("+");

// Console.SetCursorPosition (k * x4, k * y4);
// Console.WriteLine("+");

void function (int x, int y)
{
Console.SetCursorPosition (x, y);
Console.WriteLine("*");
}

function(0, 0);
function(2, 0);
function(2, 2);
function(0, 2);

Console.WriteLine();
Console.WriteLine("Enter multiplication factor: ");
int k = int.Parse(Console.ReadLine());

function(k*0, k*0);
function(k*2, k*0);
function(k*2, k*2);
function(k*0, k*2);