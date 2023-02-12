// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
// int SumNegative(int[] array)
// {
//     int result = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < 0)
//         {
//             result += array[i];
//         }
//     }
//     return result;
// }
// int SumPositive(int[] array)
// {
//     int result = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0)
//         {
//             result += array[i];
//         }
//     }
//     return result;
// }
// int[] SumNegativeAndPositive(int[] array)
// {
//     int result = new int[2];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < 0)
//         {
//             result[0] += array[i];
//         }
//         else
//         {
//             result[0] += array[i];
//         }
//     }
//     return result;
// }
// int [] myArray = GenerateArray(6, -9, 9);
// PrintArray(myArray);
// int[] sums = SumNegativeAndPositive(myArray);
// System.Console.WriteLine($"Сумма отрицательных элементов равна {sums[0]}");
// System.Console.WriteLine($"Сумма положительных элементов равна {sums[1]}");