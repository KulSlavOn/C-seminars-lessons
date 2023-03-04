// Задача 34: Задайте массив заполненный случайными положительными
// трёхзначными числами. Напишите программу, которая покажет
// количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] GetNewArr(int size, int minVal, int maxVal)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minVal, maxVal);
    }
    return res;
}

void PrintArr(int[] inArr)
{
    Console.Write("В масиве [ ");
    for (int i = 0; i < inArr.Length; i++)
    {
        Console.Write($"{inArr[i]} ");
    }
}

void EevNumArr(int[] inArr)
{
    int count = 0;
    for (int i = 0; i < inArr.Length; i++)
    {
        // int num = inArr[i]%2;
        // System.Console.Write($"  {num}");
        if (inArr[i] % 2 == 0)
        {
            count++;
        }
    }
    Console.Write($"] четных {count}");
}

int[] arr = GetNewArr(15, 100, 1000);
PrintArr(arr);
EevNumArr(arr);