// Задача 23 Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
Console.Write(N + " -> ");
for (int n = 1; n <= N; n++)
{
    Console.Write(n * n * n + ", ");
}