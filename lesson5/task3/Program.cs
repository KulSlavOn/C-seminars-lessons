// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат
// в отрезке [10,99]. Пример для массива из 5, а не 123 элементов.
// В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] GetNewArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size]; //Создание нового массива
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue );
    }
    return res;
}

// void PrintArray(int[] inArray)
// {
//     for (int i = 0; i < inArray.Length; i++)
//     {
//         Console.Write($"{inArray[i]} ");
//     }
// }

void PresNumArr(int[] inArray, int minValue, int maxValue)
{
    int count = 0;
    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i] >= minValue && inArray[i] <= maxValue-1)
        {
            count++;
        }
    }
    Console.Write($"Числа в отрезке от {minValue} до {maxValue} присутствует в массиве {count} р. ");
}

Console.WriteLine("Введите параметры отрезка массива");
Console.Write("Минимальное значение: ");
int minVal = int.Parse(Console.ReadLine()!);
Console.Write("Максимальное значение: ");
int maxVal = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите параметры массива");
Console.Write("Размер: ");
int size=int.Parse(Console.ReadLine()!);
Console.Write("Минимальное значение: ");
int minValue=int.Parse(Console.ReadLine()!);
Console.Write("Максимальное значение: ");
int maxValue=int.Parse(Console.ReadLine()!);
int[] array = GetNewArray(size, minValue, maxValue);
PresNumArr(array, minVal, maxVal);
// PrintArray(array);