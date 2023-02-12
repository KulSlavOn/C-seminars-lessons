// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.Write("Ведите число от 1-7: ");
int number =int.Parse(Console.ReadLine()!);
string mon = "Понедельник";
string tue = "Вторник";
string wed = "Среда";
string thu = "Четверг";
string fri = "Пятница";
string sat = "Суббота";
string sun = "Васкресенье";

string day = "В неделе всего 7 дней";  

if (number == 1) day = mon;
if (number == 2) day = tue;
if (number == 3) day = wed;
if (number == 4) day = thu;
if (number == 5) day = fri;
if (number == 6) day = sat;
if (number == 7) day = sun;

Console.Write("День недели: ");
Console.WriteLine(day);

/*************************Второй вариант*******************************/

// Console.Write("Введите число от 1-7: ");
// int number = int.Parse(Console.ReadLine()!);

// if (number == 1)
// {
//     System.Console.WriteLine("Понедельник");
// }

// if (number == 2)
// {
//     System.Console.WriteLine("Вторник");
// }

// if (number == 3)
// {
//     System.Console.WriteLine("Среда");
// }

// if (number == 4)
// {
//     System.Console.WriteLine("Четверг");
// }

// if (number == 5)
// {
//     System.Console.WriteLine("Пятница");
// }

// if (number == 6)
// {
//     System.Console.WriteLine("Суббота");
// }

// if (number == 7)
// {
// System.Console.WriteLine("Воскресенье");
// }