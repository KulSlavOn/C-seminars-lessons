// Задача 43: Напишите программу, которая найдёт точку пересечения
// двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void IntersectionPoint()
{
    Console.WriteLine("Введите значения k1, b1, k2 и b2 для двух прямых:");
    double b1 = ReadDouble("b1");
    double k1 = ReadDouble("k1");
    double b2 = ReadDouble("b2");
    double k2 = ReadDouble("k2");

    double x = FindIntersectionX(k1, b1, k2, b2);
    double y = k1 * x + b1;

    Console.WriteLine($"Точка пересечения: ({x}, {y})");
}

double ReadDouble(string name)
{
    Console.Write($"Введите значение {name}: ");
    return double.Parse(Console.ReadLine()!);
}

double FindIntersectionX(double k1, double b1, double k2, double b2)
{
    return (b2 - b1) / (k1 - k2);
}

IntersectionPoint();