// Напишите программу, которая будет принимать на вход два 
// числа и выводить, является ли второе число кратным первому.
// Если число 2 не кратно числу 1, то программа выводит
// остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Write("Введите первое число: ");
// int a1 = int.Parse(Console.ReadLine()!);
int a1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
// int a2 = int.Parse(Console.ReadLine()!);
int a2 = Convert.ToInt32(Console.ReadLine());
int res = a1 % a2;
if (res > 0)
{
    Console.WriteLine("Не кратно, остаток от деления = " + res);
}
else
{
    Console.WriteLine(a1 + " Кратно " + a2);
}

// int res = a2 % a1;
// Console.WriteLine("Не кратно, остаток от деления = " + res);
// if (res == 0)
// {
//     Console.WriteLine(a1 + " Кратно " + a2);
// }
// Console.WriteLine("Введите первое число");
// int numberA = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите второе число");
// int numberB = int.Parse(Console.ReadLine()!);
// int numberC = numberB % numberA;
// Console.WriteLine("Остаток от деления " + numberC);
// if (numberC == 0)
// {
// Console.WriteLine("Второе число является кратным первому ");
// }