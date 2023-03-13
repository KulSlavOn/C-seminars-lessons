// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте,
// сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

void CountPosNum()
{
    // Запрашиваем у пользователя количество чисел для ввода
    Console.Write("Введите количество чисел для ввода: ");
    int count = int.Parse(Console.ReadLine()!);

    // Считываем числа и считаем количество положительных чисел
    int countPositive = 0;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"Введите число {i + 1}: ");
        int num = int.Parse(Console.ReadLine()!);

        if (num > 0)
        {
            countPositive++;
        }
    }

    // Выводим результат на консоль
    Console.WriteLine($"Количество положительных чисел: {countPositive}");
}

CountPosNum();

// int Prompt(string message)
// {
//     System.Console.Write(message);
//     string value = Console.ReadLine()!;
//     int result = Convert.ToInt32(value);
//     return result;
// }

// int[] InputArray(int length)
// {
//     int[] array = new int[length];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = Prompt($"Введите {i + 1}-й элимент ");
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for(int i =0; i<array.Length; i++)
//     {
//         Console.WriteLine($"a [{i}] = {array[i]}");
//     }
// }

// int CountPosNum(int[] array)
// {
//     int count =0;
//     for (int i = 0; i< array.Length; i++)
//     {
//         if(array[i]>0)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// int length = Prompt("Введите количество элементов >>> ");
// int[] array;
// array=InputArray(length);
// PrintArray(array);
// Console.WriteLine($"Количество чисел больше 0 - {CountPosNum(array)}");
