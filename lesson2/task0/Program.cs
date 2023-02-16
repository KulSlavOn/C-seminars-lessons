
// LESSON2

// Напишите программу, которая выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа.
// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

// int number = new Random().Next(10,100);
// int a1 = number / 10;
// int a2 = number % 10;
// if (a1==a2)
// {
//     Console.WriteLine("цыфры в числе " + number + " равны");
// }
// if (a1>a2)
// {
//     Console.WriteLine("первая цыфра в числе " + number + " больше, это " + a1);
// }
// if (a1<a2)
// {
//     Console.WriteLine("вторая цыфра в числе "  + number + " больше, это " + a2);
// }

// Напишите программу, которая выводит случайное трехзначное число и
// удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

// int num = new Random().Next(10,1000);
// Console.WriteLine(num);
// int a1 = num / 100;
// int a2 = num % 10;
// // Console.Write(a1);
// // Console.Write(a2);
// // Console.WriteLine(a1 * 10 + a2);
// Console.WriteLine(a1 + "" + a2);

// int number = new Random().Next(100, 1000);
// Console.WriteLine(number);
// int number1 = number / 100;
// Console.WriteLine(number1);
// int number2 = number % 100 / 10;
// Console.WriteLine(number2);
// int number3 = number % 10;
// Console.WriteLine(number3);
// Console.WriteLine(number1 * 10 + number3);

// Напишите программу, которая будет принимать на вход два 
// числа и выводить, является ли второе число кратным первому.
// Если число 2 не кратно числу 1, то программа выводит
// остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

// Console.WriteLine("Введите первое число");
// int numberA = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int numberB = int.Parse(Console.ReadLine());
// int numberC = numberB % numberA;
// Console.WriteLine("Остаток от деления " + numberC);
// if (numberC == 0)
// {
// Console.WriteLine("Второе число является кратным первому ");
// }

// Console.Write("Введите первое число: ");
// // int a1 = int.Parse(Console.ReadLine()!);
// int a1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// // int a2 = int.Parse(Console.ReadLine()!);
// int a2 = Convert.ToInt32(Console.ReadLine());
// int res = a1 % a2;
// if (res > 0)
// {
//     Console.WriteLine("Не кратно, остаток от деления = " + res);
// }
// else
// {
//     Console.WriteLine(a1 + " Кратно " + a2);
// }

// Напишите программу, которая принимает на вход число и
// проверяет, кратно ли оно одновременно
// 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да

// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// if (a%7 == 0 && a%23 == 0)
// {
//     Console.WriteLine("Кратно");
// }
// else
// {
//     Console.WriteLine("Не кратно");
// }

// Напишите программу, которая принимает на вход два числа и
// проверяет, является ли одно число квадратом другого.

// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a == b * b || b == a * a)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");    
}