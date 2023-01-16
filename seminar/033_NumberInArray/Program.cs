// Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.

int[] GetRandomArray (int size, int leftRange, int rightRange)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(leftRange, rightRange +1);
    }
    return array;
}

const int size = 10;
const int leftRange = -100;
const int rightRange = 100;

int[] massive = GetRandomArray (size, leftRange, rightRange);
Console.Write("Данный массив: [");
Console.Write(string.Join(", ", massive));
Console.WriteLine("]");

int ReadNumber(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}

int number = ReadNumber("Введите число: ");

for (int i = 0; i < massive.Length; i++)
{

    if (massive[i] == number)
    {
        Console.WriteLine($"В данном массиве есть число {number}");
        break;
    }

    else if (i == massive.Length - 1)
    {
        Console.WriteLine($"В данном массиве нет числа {number}");
    }
}