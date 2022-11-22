// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите Координаты точки А:");
Console.Write("x = ");
string xText = Console.ReadLine();
int x = int.Parse(xText);
Console.Write("y = ");
string yText = Console.ReadLine();
int y = int.Parse(yText);

Console.WriteLine("Введите Координаты точки B:");
Console.Write("x = ");
int x2 = int.Parse(Console.ReadLine()); //альтернативная запись
// string xText2 = Console.ReadLine();
// int x2 = int.Parse(xText2);
Console.Write("y = ");
int y2 = int.Parse(Console.ReadLine());
// string yText2 = Console.ReadLine();
// int y2 = int.Parse(yText2);

// AB = √(xb - xa)2 + (yb - ya)2

double AB = Math.Sqrt(Math.Pow((x2-x), 2) + Math.Pow((y2 - y), 2));

Console.WriteLine($"Расстояние между точками А и В = {AB}");
