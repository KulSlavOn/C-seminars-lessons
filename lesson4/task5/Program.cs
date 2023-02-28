// Задача 25: Напишите цикл, который принимает на вход два 
// числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

void FillArray(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(0, 2);
        // Console.Write(array[i]+" ");
    }
}

void PrintArray(int[] mas)
{
    int len = mas.Length;
    for (int i = 0; i < len; i++)
    {
        Console.Write(mas[i] + " ");
    }
}

int[] arr = new int[8];
Console.Clear();
FillArray(arr);
// Console.WriteLine();
PrintArray(arr);