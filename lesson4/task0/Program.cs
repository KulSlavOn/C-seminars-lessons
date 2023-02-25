// int Prompt(string message)
// {
//     Console.Write(message);
//     string value = Console.ReadLine()!;
//     int number = Convert.ToInt32(value);
//     return number;
// }

// int ReverseNumber(int a)
// {
//     int revNum = 0;
//     int temp = a;
//     while (temp > 0)
//     {
//         revNum = revNum * 10 + temp % 10;
//         temp /= 10;
//     }
//     return revNum;
// }

// int a = Prompt("Введите 5-и значное число: ");
// int reversed = ReverseNumber(a);

// if (a > 9999 && a < 1000000)
// {
//     if (reversed == a)
//     {
//         Console.WriteLine("Число является полиндромом.");
//     }
//     else
//     {
//         Console.WriteLine("Число НЕ является полиндромом.");
//     }
// }

// Задача 24: Напишите программу, которая принимает на вход число (А)
// и выдаёт сумму чисел от 1 до А.

// 7 -> 28
// 4 -> 10
// 8 -> 36

// int GetSumNums(int number)
// {
//     int sum = 0;
//     while (number > 0)
//     {
//         sum = sum + number;
//         number--;
//     }
//     return sum;
// }

// Console.Clear();
// Console.Write("Введите число 1: ");
// int num1 = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число 2: ");
// int num2 = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число 3: ");
// int num3 = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Сумма цифр = {GetSumNums(num1)}");
// Console.WriteLine($"Сумма цифр = {GetSumNums(num2)}");
// Console.WriteLine($"Сумма цифр = {GetSumNums(num3)}");
// // int sumOne = GetSumNums(num1);
// // Console.WriteLine(sumOne);

