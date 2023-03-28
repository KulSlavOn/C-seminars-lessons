// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет
// строки на столбцы. В случае, если это невозможно, программа должна
// вывести сообщение для пользователя.

int NumberRows()
{
    Console.Write("Введите количество строк массива: ");
    int m = int.Parse(Console.ReadLine()!);
    return m;
}

int NumberColumns()
{
    Console.Write("Введите количество столбцов массива: ");
    int n = int.Parse(Console.ReadLine()!);
    return n;
}

int minValue()
{
    Console.Write("Введите нижний диапазон рандома: ");
    int min = int.Parse(Console.ReadLine()!);
    return min;
}

int maxValue()
{
    Console.Write("Введите верхний диапазонрандома: ");
    int max = int.Parse(Console.ReadLine()!);
    Console.WriteLine();
    return max;
}

int[,] GenerateArray(int m, int n, int min, int max)
{
    int[,] array = new int[m, n];
    Random rand = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = rand.Next(min, max);
        }
    }

    return array;
}

void PrintArray(int[,] array)
{
    int m = array.GetLength(0);
    int n = array.GetLength(1);

    Console.WriteLine();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{array[i, j],2}");
        }

        Console.WriteLine();
    }

    Console.WriteLine();
}

int[,] CanTranspose(int[,] array)
{
    int m = array.GetLength(0);
    int n = array.GetLength(1);

    if (m != n)
    {
        Console.WriteLine("Ошибка: массив невозможно транспонировать.");
        return null!;
    }

    int[,] transposedArray = new int[n, m];

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            transposedArray[i, j] = array[j, i];
        }
    }

    return transposedArray;
}

void Task55()
{
    int m = NumberRows();
    int n = NumberColumns();

    int min = minValue();
    int max = maxValue();

    int[,] array = GenerateArray(m, n, min, max);

    Console.Write("Исходный массив:");
    PrintArray(array);

    int[,] transposedArray = CanTranspose(array);

    if (transposedArray != null)
    {
        Console.Write("Транспонированный массив:");
        PrintArray(transposedArray);
    }

}

Task55();