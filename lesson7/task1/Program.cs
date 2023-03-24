// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве
// находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4

// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// int m = 3;
// int n = 4;
// int[,] array = new int[m, n];

// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         array[i, j] = i + j;
//         Console.Write(array[i, j] + " ");
//     }
//     Console.WriteLine();
// }

string UserMessage(string message)
{
    return $"Введите количество {message} >>> ";
}

int GetRows()
{
    Console.Write($"{UserMessage("строк")}");
    int rows = Convert.ToInt32(Console.ReadLine());
    return rows;
}

int GetCols()
{
    Console.Write($"{UserMessage("столбцов")}");
    int cols = Convert.ToInt32(Console.ReadLine());
    return cols;
}


int[,] FillArray(int[,] matrix)
{
    int[,] newMatrix = matrix;
    for (int rows = 0; rows < newMatrix.GetLength(0); rows++)
    {
        for (int cols = 0; cols < newMatrix.GetLength(1); cols++)
        {
            newMatrix[rows, cols] = rows + cols;
        }
    }
    return newMatrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int cols = 0; cols < matrix.GetLength(1); cols++)
        {
            Console.Write($"{matrix[rows,cols]} ");
        }
        Console.WriteLine();
    }
}

void Task48()
{
    int rows =GetRows();
    int cols = GetCols();
    int[,] matrix = new int[rows, cols];
    FillArray(matrix);
    PrintMatrix(matrix);
}

Task48();