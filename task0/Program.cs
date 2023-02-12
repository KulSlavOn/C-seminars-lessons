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

Console.Write("Ведите трёхзначное число: ");
int N =int.Parse(Console.ReadLine()!);
if (N > 99 && N < 1000)
{
    N = N % 10;
    Console.Write("Крайнее число: " + N);
}

/*********************************************************************/