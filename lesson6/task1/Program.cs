// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.


void TriangleInequality()
{
    Console.WriteLine("Введите длину трех сторон треугольника");
    Console.Write("Введите сторону a: ");
    int a = int.Parse(Console.ReadLine()!);
    Console.Write("Введите сторону b: ");
    int b = int.Parse(Console.ReadLine()!);
    Console.Write("Введите сторону c: ");
    int c = int.Parse(Console.ReadLine()!);

    if (a + b > c && a + c > b && b + c > a)
    {
        Console.WriteLine("Треугольник с такими сторонами может существовать");
    }
    else
    {
        Console.WriteLine("Треугольник с такими сторонами не может существовать");
    }
}

TriangleInequality();