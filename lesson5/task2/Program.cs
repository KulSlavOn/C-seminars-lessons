// Задача 33: Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int[] GetNewArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size]; //Создание нового массива
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
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

//Лев
// void PresNumArr(int[] inArray, int num)
// {
//     for (int i = 0; i < inArray.Length; i++)
//     {
//         if (inArray[i] == num)
//         {
//             Console.WriteLine($"Число {num} присутствует в массиве");
//             break;
//         }
//         else
//         {
//             Console.WriteLine($"Число {num} отсутствует в массиве");
//             break;
//         }
//     }
// }

//Я
// void PresNumArr(int[] inArray, int num)
// {
//     int numArr = 0;
//     for (int i = 0; i < inArray.Length; i++)
//     {
//         if (inArray[i] == num)
//         {
//             numArr = num;
//         }
//     }
//     if (numArr == num)
//     {
//         Console.WriteLine($"Число {num} присутствует в массиве");
//     }
//     else
//     {
//         Console.WriteLine($"Число {num} отсутствует в массиве");
//     }
// }

// Дарья
// void PresNumArr(int[] inArray, int num)
// {
//     int count = 0;
//     for (int i = 0; i < inArray.Length; i++)
//     {
//         if (inArray[i] == num)
//         {
//             count++;
//         }
//     }
//     if (count > 0)
//     {
//         Console.WriteLine($"Число {num} присутствует в массиве");
//     }
//     else
//     {
//         Console.WriteLine($"Число {num} отсутствует в массиве");
//     }
// }

// Эльвара
void PresNumArr(int[] inArray, int num)
{
    bool flag = false;
    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i] == num)
        {
            flag = true;
        }
    }
    if (flag)
    {
        Console.Write($"Число {num} присутствует в массиве: ");
    }
    else
    {
        Console.Write($"Число {num} отсутствует в массиве: ");
    }
}

Console.Write("Присутствует ли в массиве число: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите параметры массива");
Console.Write("Размер: ");
int size=int.Parse(Console.ReadLine()!);
Console.Write("Минимальное значение: ");
int minValue=int.Parse(Console.ReadLine()!);
Console.Write("Максимальное значение: ");
int maxValue=int.Parse(Console.ReadLine()!);
int[] array = GetNewArray(size, minValue, maxValue);
PresNumArr(array, num);
PrintArray(array);