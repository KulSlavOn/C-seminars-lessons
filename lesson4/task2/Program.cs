// Задача 26: Напишите программу, которая принимает на вход число и 
// выдаёт количество цифр в числе.

// 456 -> 3
// 78 -> 2
// 89126 -> 5

int GetNumDig(int n)
{
    int num = 0;
    while (n > 0)
    {
        n = n / 10;
        num++;
    }
    return num;
}

Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Кол-во цифр = {GetNumDig(n)}");