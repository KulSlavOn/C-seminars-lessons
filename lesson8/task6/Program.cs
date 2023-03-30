// Задача 60. * ...Сформируйте трёхмерный массив из неповторяющихся двузначных
// чисел. Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Task60();

void Task60()
{
    int dim1 = DimensionX();
    int dim2 = DimensionY();
    int dim3 = DimensionZ();

    int[,,] arr = GenerateArray(dim1, dim2, dim3);

    PrintArray(arr);
}

int DimensionX()
{
    Console.Write("Введите размер первого измерения: ");
    int dim1 = int.Parse(Console.ReadLine()!);
    return dim1;
}

int DimensionY()
{
    Console.Write("Введите размер второго измерения: ");
    int dim2 = int.Parse(Console.ReadLine()!);
    return dim2;
}

int DimensionZ()
{
    Console.Write("Введите размер третьего измерения: ");
    int dim3 = int.Parse(Console.ReadLine()!);
    return dim3;
}

int[,,] GenerateArray(int dim1, int dim2, int dim3)
{
    int[,,] arr = new int[dim1, dim2, dim3];

    Random rnd = new Random();

    for (int i = 0; i < dim1; i++)
    {
        for (int j = 0; j < dim2; j++)
        {
            for (int k = 0; k < dim3; k++)
            {
                int num;
                do
                {
                    num = rnd.Next(10, 100);
                } while (CheckIfNumberExists(arr, num));

                arr[i, j, k] = num;
            }
        }
    }

    return arr;
}

bool CheckIfNumberExists(int[,,] arr, int num)
{
    foreach (int element in arr)
    {
        if (element == num)
        {
            return true;
        }
    }
    return false;
}

void PrintArray(int[,,] arr)
{
    int dim1 = arr.GetLength(0);
    int dim2 = arr.GetLength(1);
    int dim3 = arr.GetLength(2);

    Console.WriteLine($"Трёхмерный массив размером: {dim1} x {dim2} x {dim3}");

    for (int i = 0; i < dim1; i++)
    {
        for (int j = 0; j < dim2; j++)
        {
            for (int k = 0; k < dim3; k++)
            {
                Console.Write($"{arr[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}