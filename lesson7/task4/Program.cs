// Задайте двумерный массив размером m×n, заполненный случайными
// вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] GenerateArray(int m, int n)
{
    double[,] array = new double[m, n];
    Random rand = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = rand.NextDouble() * 20 - 10;
        }
    }

    return array;
}

void PrintArray(double[,] array)
{
    int m = array.GetLength(0);
    int n = array.GetLength(1);

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{array[i, j],5:N1}");
        }

        Console.WriteLine();
    }

    Console.WriteLine();
}

void Task47()
{
    Console.Write("Введите m: ");
    int m = int.Parse(Console.ReadLine()!);

    Console.Write("Введите n: ");
    int n = int.Parse(Console.ReadLine()!);

    double[,] array = GenerateArray(m, n);
    PrintArray(array);
}

Task47();