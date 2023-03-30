// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetNumber(string message)
{
    Console.Write(message);
    int number;
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.Write("Некорректный ввод. Пожалуйста, введите целое число: ");
    }
    return number;
}

int SumNaturalNumbersInRange(int m, int n)
{
    if (m > n)
    {
        return 0;
    }

    return m + SumNaturalNumbersInRange(m + 1, n);
}

void Task66()
{
    int m = GetNumber("Введите значение M: ");
    int n = GetNumber("Введите значение N: ");

    int sum = SumNaturalNumbersInRange(m, n);

    Console.WriteLine($"Сумма натуральных чисел в промежутке от {m} до {n}: {sum}");
}

Task66();