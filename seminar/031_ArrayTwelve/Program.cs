﻿// Задайте массив из 12 элементов, заполненный случайными числами 
// из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.

// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
// сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] GetRandomArray (int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(leftRange, rightRange +1);
    }
    return array;
}
const int size = 12;
const int leftRange = -9;
const int rightRange = 9;

int[] massive = GetRandomArray (size, leftRange, rightRange);
Console.WriteLine(string.Join(", ", massive)); // Join метод, привязанный к string

int sumP = 0; // сумма положительных чисел
int sumN = 0; // сумма отрицательных чисел

for (int i = 0; i < massive.Length; i++)
{
    if (massive[i] >= 0) // является ли элемент положительным?
    {
        sumP += massive[i];
    }

    else
    {
        sumN += massive[i];
    }
}

Console.WriteLine($"Сумма положительных элементов равна {sumP}");
Console.WriteLine($"Сумма отрицательных элементов равна {sumN}");