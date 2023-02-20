// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой
// четверти (x и y).

Console.Write("Введите четверть: ");
int c = int.Parse(Console.ReadLine()!);
if (c == 1)
{
    Console.WriteLine("1 до 5");
}
if (c == 2)
{
    Console.WriteLine("5 до -5");
}
if (c == 3)
{
    Console.WriteLine("-5 до -5");
}
if (c == 4)
{
    Console.WriteLine("5 до -5");
}