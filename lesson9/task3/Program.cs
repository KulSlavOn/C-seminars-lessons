// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);
// // int temp = 0;
// int sum = 0;
// Console.WriteLine(SumNums(number, sum)!);

// // while (number>0)
// // {
// //     temp = number - number % 10;
// //     result = result + (number - temp);
// //     number = number / 10;
// // }
// // Console.Write(result);

// int SumNums(int num, int sum)
// {
//     if (num == 0) return sum;
//     else
//     {
//         sum += num % 10;
//         return SumNums(num / 10, sum);
//     }
// }

Console.Clear();
Console.Write("Введите число: ");
int m = int.Parse(Console.ReadLine()!);

Console.WriteLine($"{m}->{SumNumbers(m)}");

int SumNumbers(int number)
{
if (number == 0) return 0;
return (number % 10 + SumNumbers(number / 10));
}