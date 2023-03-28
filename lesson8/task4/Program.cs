// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки
// с наименьшей суммой элементов: 1 строка

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

int FindRowWithMinSum(int[,] array)
{
    int m = array.GetLength(0);
    int n = array.GetLength(1);

    int minSum = int.MaxValue;

    int rowIndex = 0;

    for (int i = 0; i < m; i++)
    {
        int sum = 0;
        for (int j = 0; j < n; j++)
        {
            sum += array[i, j];
        }

        if (sum < minSum)
        {
            minSum = sum;
            rowIndex = i;
        }
    }

    return rowIndex;
}


void Task56()
{
    int m = NumberRows();
    int n = NumberColumns();

    int min = minValue();
    int max = maxValue();

    int[,] array = GenerateArray(m, n, min, max);

    Console.Write("Исходный массив:");
    PrintArray(array);

    int rowIndex = FindRowWithMinSum(array);

    Console.WriteLine($"Строка с наименьшей суммой элементов: {rowIndex + 1}");
}

Task56();