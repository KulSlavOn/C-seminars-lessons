// Задача 25: Напишите цикл, который принимает на вход два 
// числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int RaisNumNatPow(int a, int b)
{
    int sum = a;
    while (b > 1)
    {
        sum = sum * a;
        b--;
    }
    return sum;
}

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
Console.Write("Введите степень возведения: ");
int pow = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{num} в {pow}-й степени = {RaisNumNatPow(num, pow)}");