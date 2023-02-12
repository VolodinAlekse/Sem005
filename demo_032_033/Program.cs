﻿// Задача 32: 
// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

// Задача 33:
//  Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

//Задача 32:

// int[] GenerateArray(int size, int leftRange, int rightRange)
// {
//     int[] array = new int[size];
//     var rand = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rand.Next(leftRange, rightRange + 1);
//     }
//     return array;
// }

// void ChangePositiveAndNegative(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = -array[i];
//     }
// }

// void PrintArray(int[] array)
// {
//     System.Console.WriteLine("[" + string.Join(",", array) + "]");
// }

// int[] myArray = GenerateArray(6, -9, 9);
// PrintArray(myArray);
// ChangePositiveAndNegative(myArray);
// PrintArray(myArray);










// Задача 33:




int[] GenerateArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    var rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(",", array) + "]");
}

void FindNumber(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
            System.Console.WriteLine("Такой элемент есть");
            return;
        }
    }
    System.Console.WriteLine("Такого элемента нет");
}

int[] myArray = GenerateArray(6, -9, 9);

int number = 7;

PrintArray(myArray);

FindNumber(myArray, number);
