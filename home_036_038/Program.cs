// Задача 36:
//  Задайте одномерный массив, заполненный случайными числами. 
//  Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0



// Console.WriteLine($"Введите длину массива: ");
// int ElementNumbers = Convert.ToInt32(Console.ReadLine());
// int randomNumber = RandomNumbers(ElementNumbers, 1, 10);
// Console.WriteLine($"  Сумма элементов, стоящих на нечётных позициях: {randomNumber}");


// int RandomNumbers(int ElementNumbers, int min, int max)
// {
//     int[] randomNumber = new int[ElementNumbers];
//     int sumElements = 0;
//     Console.Write("Получили массив: ");
//     for (int i = 0; i < randomNumber.Length; i++)
//     {
//         randomNumber[i] = new Random().Next(min, max);
//         Console.Write(randomNumber[i] + " ");
//         if (i % 2 != 1)
//         {
//             sumElements = sumElements + randomNumber[i];
//         }
//     }
//     return sumElements;
// }



// Задача 38: 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Введите длину массива  ");

int size = Convert.ToInt32(Console.ReadLine());

double[] number = new double[size];

FillArrayRandomNumbers(number);

Console.WriteLine("Массив: ");

PrintArray(number);


double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int a = 0; a < number.Length; a++)
{
    if (number[a] > max)
    {
        max = number[a];
    }
    if (number[a] < min)
    {
        min = number[a];
    }
}

Console.WriteLine($"Всего в массиве {number.Length} чисел. Максимальное = {max}, Минимальное = {min}");
Console.WriteLine($"Разность между максимальным и минимальным = {max - min}");

void FillArrayRandomNumbers(double[] number)
{
    for (int i = 0; i < number.Length; i++)
    {
        number[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
    }
}
void PrintArray(double[] number)
{
    Console.Write("[ ");
    for (int i = 0; i < number.Length; i++)
    {
        Console.Write(number[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}