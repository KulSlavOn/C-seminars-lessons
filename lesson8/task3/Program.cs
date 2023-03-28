// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


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

void SortRowsDescending(int[,] array)
{
    int m = array.GetLength(0);
    int n = array.GetLength(1);

    for (int i = 0; i < m; i++)
    {
        int[] tempArray = new int[n];

        for (int j = 0; j < n; j++)
        {
            tempArray[j] = array[i, j];
        }

        Array.Sort(tempArray, (x, y) => -1 * x.CompareTo(y));

        for (int j = 0; j < n; j++)
        {
            array[i, j] = tempArray[j];
        }
    }
}

void Task54()
{
    int m = NumberRows();
    int n = NumberColumns();

    int min = minValue();
    int max = maxValue();

    int[,] array = GenerateArray(m, n, min, max);

    Console.Write("Исходный массив:");
    PrintArray(array);

    SortRowsDescending(array);

    Console.Write("Упорядоченный массив:");
    PrintArray(array);
}

Task54();