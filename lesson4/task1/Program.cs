// Задача 24: Напишите программу, которая принимает на вход число (А)
// и выдаёт сумму чисел от 1 до А.

// 7 -> 28
// 4 -> 10
// 8 -> 36

int GetSumNums(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum = sum + number;
        number--;
    }
    return sum;
}

Console.Clear();
Console.Write("Введите число 1: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите число 2: ");
int num2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите число 3: ");
int num3 = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр = {GetSumNums(num1)}");
Console.WriteLine($"Сумма цифр = {GetSumNums(num2)}");
Console.WriteLine($"Сумма цифр = {GetSumNums(num3)}");
// int sumOne = GetSumNums(num1);
// Console.WriteLine(sumOne);