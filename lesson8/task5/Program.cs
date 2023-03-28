// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить
// произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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


void Task58()
{
    int m = NumberRows();
    int n = NumberColumns();

    int min = minValue();
    int max = maxValue();

    int[,] matrix1 = GenerateArray(m, n, min, max);
    int[,] matrix2 = GenerateArray(m, n, min, max);

    Console.Write("I");
    PrintArray(matrix1);
    Console.Write("II");
    PrintArray(matrix2);

}

Task58();