// Напишите программу, которая принимает на вход число и
// проверяет, кратно ли оно одновременно
// 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
// int a = new Random().Next(1, 200);
Console.Write("Число " + a + " ");
if (a % 7 == 0 && a % 23 == 0)
{
    Console.WriteLine("кратно 7 и 23");
}
else
{
    Console.WriteLine("не кратно 7 и 23");
}
