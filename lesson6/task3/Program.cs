// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// void FibonacciNumbers()
// {
//     Console.Write("Введите количество чисел Фибоначчи, которые нужно вывести: ");
//     int n = int.Parse(Console.ReadLine()!);
//     int[] fibNum = new int[n];
//     fibNum[0] = 0;
//     fibNum[1] = 1;

//     for (int i = 2; i < n; i++)
//     {
//         fibNum[i] = fibNum[i - 1] + fibNum[i - 2];
//     }

//     Console.Write("Первые {0} чисел Фибоначчи: ", n);
//     for (int i = 0; i < n; i++)
//     {
//         Console.Write(fibNum[i] + " ");
//     }
// }

void Fiboinachi()
{
    Console.Write("Введите длинну массива >>> ");
    int length = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[length];
    array[0] = 0;
    array[1] = 1;
    Console.Write($"{array[0]}\t {array[1]}\t");
    for (int i = 2; i < length; i++)
    {
        array[i] = array[i - 2] + array[i - 1];
        Console.Write($"{array[i]}\t");
    }
}

// FibonacciNumbers();
Fiboinachi();