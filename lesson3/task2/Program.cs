// Напишите программу, которая принимает на вход координаты двух
// точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// Math.Sqrt()

// AB = √(xb - xa)2 + (yb - ya)2

Console.Write("Введите x первой точки: ");
int xa = int.Parse(Console.ReadLine()!);
Console.Write("Введите y первой точки: ");
int ya = int.Parse(Console.ReadLine()!);
Console.Write("Введите x второй точки: ");
int xb = int.Parse(Console.ReadLine()!);
Console.Write("Введите y второй точки: ");
int yb = int.Parse(Console.ReadLine()!);
// int a = (xb - xa) * (xb - xa);
// Console.WriteLine(a);
// int b = (yb - ya) * (yb - ya);
// Console.WriteLine(b);
// int ab1 = a + b;
// Console.WriteLine(ab1);
double ab = Math.Sqrt((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya));

Console.Write("Растояние между двумя точками: " + Math.Round(ab,2));