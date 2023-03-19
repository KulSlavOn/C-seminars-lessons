// Напишите программу, которая на вход принимает позиции элемента в 
// массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// [1,7] -> по данным индексам такого числа в массиве нет


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


int IndexStrings()
{
    Console.Write("Введите индекс строки: ");
    int i = int.Parse(Console.ReadLine()!);
    return i;
}

int IndexColumn()
{
    Console.Write("Введите индекс столбца: ");
    int j = int.Parse(Console.ReadLine()!);
    return j;
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

void ArrayElementValue(int[,] array, int i, int j)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);

    if (i >= 0 && i < rows && j >= 0 && j < cols)
    {
        int value = array[i, j];
        Console.WriteLine($"Значение элемента: {value}");
    }
    else
    {
        Console.WriteLine("По данным индексам такого числа в массиве нет");
    }
}

void Task50()
{
    int m = NumberRows();
    int n = NumberColumns();
    
    int min = minValue();
    int max = maxValue();
    
    int[,] array = GenerateArray(m, n, min, max);
    PrintArray(array);

    int i = IndexStrings();
    int j = IndexColumn();

    ArrayElementValue(array, i, j);
}

Task50();