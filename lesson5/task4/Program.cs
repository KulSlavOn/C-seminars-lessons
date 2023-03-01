// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] GetNewArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}

void PrintArray(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        Console.Write($"{inArray[i]} ");
    }
}

// Мой вариант
// void PresNumArr(int[] inArray)
// {
//     for (int i = 0; i < inArray.Length/2; i++)
//     {
//         int a = inArray[i];
//         int b = inArray[inArray.Length -1-i];
//         int num = a * b;
//         // Console.WriteLine($"{a} {b} ");
//         Console.Write($"{num} ");
//     }
// }

int[] GetCompos(int[] inArray)
{
    int[] res =new int [inArray.Length/2];
    for (int i = 0; i < inArray.Length/2; i++)
    {
        res[i] = inArray[i]*inArray[inArray.Length -1-i];
    }
    return res;
}

// Console.WriteLine("Введите параметры отрезка массива");
// Console.Write("Минимальное значение: ");
// int minVal = int.Parse(Console.ReadLine()!);
// Console.Write("Максимальное значение: ");
// int maxVal = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите параметры массива");
// Console.Write("Размер: ");
// int size=int.Parse(Console.ReadLine()!);
// Console.Write("Минимальное значение: ");
// int minValue=int.Parse(Console.ReadLine()!);
// Console.Write("Максимальное значение: ");
// int maxValue=int.Parse(Console.ReadLine()!);

int[] array = GetNewArray(10, 1, 10);
PrintArray(array);
Console.WriteLine();
int[] resArr = GetCompos(array);
PrintArray(resArr);