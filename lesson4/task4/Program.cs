// Задача 30: Напишите программу, которая выводит массив из 8
// элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

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