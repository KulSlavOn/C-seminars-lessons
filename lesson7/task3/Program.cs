// Задача 51: Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

string UserMessage(string message){
    return $"Введите {message} >>> ";
}

int GetRows(string message){
    Console.Write($"{UserMessage(message)}");
    int rows = Convert.ToInt32(Console.ReadLine());
    return rows;
}

int GetCols(string message){
    Console.Write($"{UserMessage(message)}");
    int cols = Convert.ToInt32(Console.ReadLine());
    return cols;
}

// double[,] FillArrayRandomDoubleValues(double[,] matrix, double first, double last){
//     double[,] newMatrix = matrix;
//     for (int rows = 0; rows < newMatrix.GetLength(0); rows++)
//     {
//         for (int cols = 0; cols < newMatrix.GetLength(1); cols++)
//         {
//             newMatrix[rows,cols] = new Random().NextDouble() * (first - last) + last;

//         }    
//     }
//     return newMatrix;
// }

// void PrintDoubleMatrix(double[,] matrix){
//     for (int rows = 0; rows < matrix.GetLength(0); rows++)
//     {
//         for (int cols = 0; cols < matrix.GetLength(1); cols++)
//         {
//             Console.Write($"{matrix[rows,cols]:f2}\t");
//         }
//         Console.WriteLine();
//     }
// }

int[,] FillArrayRandomIntValues(int[,] matrix, int first, int last){
    int[,] newMatrix = matrix;
    for (int rows = 0; rows < newMatrix.GetLength(0); rows++)
    {
        for (int cols = 0; cols < newMatrix.GetLength(1); cols++)
        {
            newMatrix[rows,cols] = new Random().Next(first, last);

        }    
    }
    return newMatrix;
}

void PrintIntMatrix(int[,] matrix){
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int cols = 0; cols < matrix.GetLength(1); cols++)
        {
            Console.Write($"{matrix[rows,cols]}\t");
        }
        Console.WriteLine();
    }
}


int[] GetAvgOfEachColumnMatrix(int[,] matrix){
    int[] avgArrayOfEachColumn = new int[matrix.GetLength(1)];
    for (int cols = 0; cols < matrix.GetLength(1); cols++)
    {
        int sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, cols];
        }
        avgArrayOfEachColumn[cols] = sum;
    }
    return avgArrayOfEachColumn;
}

void Task52(){
    int row = GetRows("количество строк");
    int col = GetCols("количество столбцов");
    int[,] matrix = new int[row, col];
    FillArrayRandomIntValues(matrix, 1, 10);
    PrintIntMatrix(matrix);
    int[] avgArrayOfEachColumn = GetAvgOfEachColumnMatrix(matrix);
    System.Console.WriteLine();
    foreach (int item in avgArrayOfEachColumn)
    {
        Console.Write($"{item}\t");       
    }
}

Task52();

int[,] GenerateArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random rand = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = rand.Next(1, 10);
        }
    }

    return array;
}

int SumMainDiagonal(int[,] array)
{
    int sum = 0;
    int m = array.GetLength(0);
    int n = array.GetLength(1);

    for (int i = 0; i < Math.Min(m, n); i++)
    {
        sum += array[i, i];
    }

    return sum;
}

void PrintArray(int[,] array)
{
    int m = array.GetLength(0);
    int n = array.GetLength(1);

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{array[i, j],4}");
        }

        Console.WriteLine();
    }

    Console.WriteLine();
}

void Main()
{
    int[,] array = GenerateArray(4, 4);
    PrintArray(array);

    int sum = SumMainDiagonal(array);
    Console.WriteLine($"Сумма элементов главной диагонали: {sum}");
}


Main();