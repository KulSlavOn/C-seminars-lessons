// LESSON1
// Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное
// на само себя).

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

// Console.Write("Введите число: ");
// int numbers =int.Parse(Console.ReadLine()!);
// int sqr = numbers * numbers;
// Console.WriteLine("Квадрат числа " + numbers + " равен = " + sqr);

/*********************************************************************/

//  Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

// Console.Write("Введите число 1: ");
// int a =int.Parse(Console.ReadLine()!);
// Console.Write("Введите число 2: ");
// int b =int.Parse(Console.ReadLine()!);
// int sqr = b * b;
// if (sqr == a)
// {
//     System.Console.WriteLine("Первое число является квадратом второго");
// }
// else
// {
//     System.Console.WriteLine("Первое число не является квадратом второго");
// }

/*********************************************************************/


// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

// Console.Write("Ведите число от 1-7: ");
// int number =int.Parse(Console.ReadLine()!);
// string mon = "Понедельник";
// string tue = "Вторник";
// string wed = "Среда";
// string thu = "Четверг";
// string fri = "Пятница";
// string sat = "Суббота";
// string sun = "Васкресенье";

// string day = "В неделе всего 7 дней";  

// if (number == 1) day = mon;
// if (number == 2) day = tue;
// if (number == 3) day = wed;
// if (number == 4) day = thu;
// if (number == 5) day = fri;
// if (number == 6) day = sat;
// if (number == 7) day = sun;

// Console.Write("День недели: ");
// Console.WriteLine(day);

/*******Второй вариант********/

// Console.Write("Введите число от 1-7: ");
// int number = int.Parse(Console.ReadLine());
// if (number == 1) {

// System.Console.WriteLine("Понедельник");
// }
// if (number == 2) {

// System.Console.WriteLine("Вторник");
// }
// if (number == 3)
// {

// System.Console.WriteLine("Среда");
// }
// if (number == 4)
// {

// System.Console.WriteLine("Четверг");
// }
// if (number == 5)
// {

// System.Console.WriteLine("Пятница");
// }
// if (number == 6)
// {

// System.Console.WriteLine("Суббота");
// }
// if (number == 7)
// {

// System.Console.WriteLine("Воскресенье");
// }

/*********************************************************************/

// Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

// Console.Write("Ведите число: ");
// int N =int.Parse(Console.ReadLine()!);

// for (int i = -N; i <= N; i++)
// {
//     Console.Write(i + ", ");
// }

/*********************************************************************/

// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

// Console.Write("Ведите трёхзначное число: ");
// int N =int.Parse(Console.ReadLine()!);
// if (N > 99 && N < 1000)
// {
//     N = N % 10;
//     Console.Write("Крайнее число: " + N);
// }
/*********************************************************************/

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

// Console.Write("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// if (a == b * b || b == a * a)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");    
// }