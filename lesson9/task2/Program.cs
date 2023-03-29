// Задача 65: Задайте значения M и N. Напишите программу, которая выведет
// все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

int m = int.Parse(Console.ReadLine()!);
int n = int.Parse(Console.ReadLine()!);
Concequense(n, m);

void Concequense(int number, int start)
{
    if (start <= number)
    {
        Console.Write($"{start} ");
        Concequense(number, start + 1);
    }
}