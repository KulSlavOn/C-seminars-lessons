// Напишите программу, которая выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа.
// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10,100);
int a1 = number / 10;
int a2 = number % 10;
if (a1==a2)
{
    Console.WriteLine("цыфры в числе " + number + " равны");
}
if (a1>a2)
{
    Console.WriteLine("первая цыфра в числе " + number + " больше, это " + a1);
}
if (a1<a2)
{
    Console.WriteLine("вторая цыфра в числе "  + number + " больше, это " + a2);
}
