// Задача 27: Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int SumDigNum(int num)
{
    int a1 = num / 1000;
    int a2 = num / 100 % 10;
    int a3 = num / 10 % 10;
    int a4 = num % 10;
    int sum = a1 + a2 + a3 + a4;
    // Console.WriteLine($"{a1} {a2} {a3} {a4}");
    return sum;
}

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр в числе = {SumDigNum(num)}");