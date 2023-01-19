// Напишите программу, которая будет создавать копию заданного массива 
// с помощью поэлементного копирования.

int[] GetRandomArray (int size, int min, int max)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

int size = new Random().Next(2, 10);
const int min = -100;
const int max = 100;
int[] massive = GetRandomArray (size, min, max);
Console.WriteLine($"Данный массив: [{string.Join(", ", massive)}]");

int[] newArray = new int[massive.Length];

// создадим цикл для поэлементного копирования
for (int i = 0; i < massive.Length; i++)
{
    newArray[i] = massive[i];
}

massive[0] = 9999; // изменим значение в первом массиве для будущей проверки

Console.WriteLine($"Данный массив: [{string.Join(", ", massive)}]");
Console.WriteLine($"Скопированный массив: [{string.Join(", ", newArray)}]");