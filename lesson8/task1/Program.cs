// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет
// местами первую и последнюю строку массива.

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

void SwapRows(int[,] array, int rowIndex1, int rowIndex2)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int temp = array[rowIndex1, j];
        array[rowIndex1, j] = array[rowIndex2, j];
        array[rowIndex2, j] = temp;
    }
}

void Task53()
{
    int m = NumberRows();
    int n = NumberColumns();

    int min = minValue();
    int max = maxValue();

    int[,] array = GenerateArray(m, n, min, max);

    Console.Write("Исходный массив:");
    PrintArray(array);

    SwapRows(array, 0, m - 1);

    Console.Write("Изменённый массив:");
    PrintArray(array);

}

Task53();