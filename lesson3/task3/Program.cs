// Напишите программу, которая принимает на вход число (N) и выдаёт
// таблицу квадратов чисел от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
Console.Write(N + " -> ");
for (int n = 1; n <= N; n++)
{
    Console.Write(n * n + ", ");
}