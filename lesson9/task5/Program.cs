// Задача 64: Задайте значение N. Напишите программу, которая выведет все
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void Task64()
{
    Console.Write("Введите число N: ");
    int n = int.Parse(Console.ReadLine()!);

    Console.Write($"Натуральные числа от {n} до 1: ");
    PrintNaturalNumbers(n);
}


void PrintNaturalNumbers(int n)
{
    if (n <= 0)
    {
        return;
    }

    Console.Write($"{n} ");
    PrintNaturalNumbers(n - 1);
}

Task64();