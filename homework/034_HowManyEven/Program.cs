// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] GetRandomArray (int size, int min, int max)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

int HowManyEven (int[] collection)
{
    int result = 0;
    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i] % 2 == 0)
        {
            result++;
        }
    }
    return result;
}

int size = new Random().Next(1, 100); // создадим массив с количеством 1-99 элементов
const int min = 100; // наполняем массив числами от 100...
const int max = 999; // ... до 999
int result = 0; // сюда пропишем результат работы программы

int[] massive = GetRandomArray (size, min, max);
Console.WriteLine($"Данный массив: [{string.Join(", ", massive)}]");

result = HowManyEven (massive);
Console.WriteLine(); // снова пустая строка для красоты
Console.WriteLine($"Общее количество элементов в массиве равно {size}"); // не было в техзадании, добавил для себя отображение кол-ва элементов
Console.WriteLine($"Количество чётных чисел в массиве равно {result}");