// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные,
// и замените эти элементы на ихквадраты.

// int[,] array = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         if (i % 2 == 0 && j % 2 == 0)
//         {
//             array[i, j] = array[i, j] * array[i, j];
//         }
//     }
// }

// // Вывод полученного массива
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         Console.Write(array[i, j] + " ");
//     }
//     Console.WriteLine();
// }

/**********************************************************************************/

// int[,] GenerateArray(int m, int n)
// {
//     int[,] array = new int[m, n];
//     Random random = new Random();

//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             array[i, j] = random.Next(1,50);
//         }
//     }

//     return array;
// }

// void ReplaceEvenIndices(int[,] array)
// {
//     int m = array.GetLength(0);
//     int n = array.GetLength(1);

//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0)
//             {
//                 array[i, j] *= array[i, j];
//             }
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     int m = array.GetLength(0);
//     int n = array.GetLength(1);

//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             Console.Write($"{array[i, j],4}");
//         }

//         Console.WriteLine();
//     }

//     Console.WriteLine();
// }

// void Main()
// {
//     int[,] array = GenerateArray(5, 5);
//     PrintArray(array);

//     ReplaceEvenIndices(array);
//     PrintArray(array);
// }

// Main();

/********************************************************************************/

