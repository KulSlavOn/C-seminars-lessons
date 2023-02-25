// Задача 28: Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int GetProNums(int n)
{
    int pro = 1;
    while (n > 0)
    {
        pro = pro * n;
        n--;
        // Console.WriteLine(pro);
    }
    return pro;
}

Console.Clear();
Console.Write("Введите число: ");
int pro = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Произведение цифр = {GetProNums(pro)}");