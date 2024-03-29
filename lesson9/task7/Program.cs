﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Ackermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    else
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
}

int GetNonNegativeInteger(string message)
{
    Console.Write(message);
    int value;
    while (!int.TryParse(Console.ReadLine(), out value) || value < 0)
    {
        Console.Write("Некорректный ввод. Пожалуйста, введите целое неотрицательное число: ");
    }
    return value;
}

void Task68()
{
    int m = GetNonNegativeInteger("Введите число m: ");
    int n = GetNonNegativeInteger("Введите число n: ");

    int result = Ackermann(m, n);

    Console.WriteLine($"A({m},{n}) = {result}");
}

Task68();