// Задача 62 *. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Task62();

void Task62()
{
    int dim1 = DimensionX();
    int dim2 = DimensionY();

    Console.WriteLine();

    int[,] spiralArray = new int[dim1, dim2];

    FillSpiralArray(spiralArray);

    PrintSpiralArray(spiralArray, dim1, dim2);
}

int DimensionX()
{
    Console.Write("Введите количество строк: ");
    int dim1 = int.Parse(Console.ReadLine()!);
    return dim1;
}

int DimensionY()
{
    Console.Write("Введите количество столбцов: ");
    int dim2 = int.Parse(Console.ReadLine()!);
    return dim2;
}

void FillSpiralArray(int[,] array)
{
    int counter = 1;
    int minRow = 0;
    int maxRow = array.GetLength(0) - 1;
    int minColumn = 0;
    int maxColumn = array.GetLength(1) - 1;

    while (minRow <= maxRow && minColumn <= maxColumn)
    {
        for (int j = minColumn; j <= maxColumn; j++)
        {
            array[minRow, j] = counter++;
        }

        for (int i = minRow + 1; i <= maxRow; i++)
        {
            array[i, maxColumn] = counter++;
        }

        if (minRow < maxRow && minColumn < maxColumn)
        {
            for (int j = maxColumn - 1; j >= minColumn; j--)
            {
                array[maxRow, j] = counter++;
            }

            for (int i = maxRow - 1; i > minRow; i--)
            {
                array[i, minColumn] = counter++;
            }
        }

        minRow++;
        maxRow--;
        minColumn++;
        maxColumn--;
    }
}

void PrintSpiralArray(int[,] spiralArray, int dim1, int dim2)
{
    for (int i = 0; i < dim1; i++)
    {
        for (int j = 0; j < dim2; j++)
        {
            Console.Write($"{spiralArray[i, j]:00} ");
        }
        Console.WriteLine();
    }
}