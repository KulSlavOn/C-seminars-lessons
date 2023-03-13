// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Write("Введите десятичное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int n = number;
int remains = 0;
string res = string.Empty;
while (number > 0)
{
remains = number % 2;
res = remains + res;
number = number / 2;

}
Console.WriteLine($"Двоичное представление: {res}");
