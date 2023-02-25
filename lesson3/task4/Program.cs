// Задача 19 Напишите программу, которая принимает на вход пятизначное
// число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int n = int.Parse(Console.ReadLine()!);
int a = n / 1000;
int b1 = n % 10 * 10;
int b2 = n / 10 % 10;
// int b=b1+b2;
// Console.WriteLine(a + " " + b1 + " " + b2);
// Console.WriteLine(b);
if (a == b1 + b2)
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}