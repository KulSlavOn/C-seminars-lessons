// Задача 38: Задайте массив вещественных чисел. Найдите разницу
// между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// NextDouble()

int[] GetAdArr(int size, int minVal, int maxVel)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minVal, maxVel);
    }
    return res;
}

void PrtArr(int[] arr)
{
    Console.Write("В массиве [ ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

void SumElOddPos(int[] arr)
{
    int max = 0;
    int min = 100000;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
        if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    Console.Write($"] Максимальный элементов {max} минимальным элементов {min} разница между нити {max-min}");
}

int[] arr = GetAdArr(5, 1, 99);
PrtArr(arr);
SumElOddPos(arr);