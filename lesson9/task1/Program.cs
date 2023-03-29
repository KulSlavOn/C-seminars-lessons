// Задача 63: Задайте значение N. Напишите программу, которая выведет все
// натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

int n = int.Parse(Console.ReadLine()!);
// int start = 1;
// Concequense(n, start); //int
Console.WriteLine(Concequense(n)!); //string
// for(int i = 1; i <= n; i++)
// {
//     Console.Write($"{i} ");
// }

// void Concequense(int number, int start)
// {
//     if (start <= number)
//     {
//         Console.Write($"{start} ");
//         Concequense(number, start + 1);
//     }
// }

string Concequense(int number)
{
    if (number ==0) return String.Empty;
    else return $"{Concequense(number - 1)}{number} ";
}