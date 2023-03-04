// Задача 36: Задайте одномерный массив, заполненный
// числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

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
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 > 0)
        {
            sum = sum + arr[i];
        }
    }
    Console.Write($"] Сумма элементов, стоящих на нечётных позициях {sum}");
}

int[] arr = GetAdArr(4, -99, 99);
PrtArr(arr);
SumElOddPos(arr);