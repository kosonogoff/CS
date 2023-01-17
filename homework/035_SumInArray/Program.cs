// Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150]. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

int[] GetRandomArray (int size, int leftRange, int rightRange)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(leftRange, rightRange + 1);
    }
    return array;
}

int HowMuch (int[] collection, int min, int max)
{
    int count = 0;
    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i] >= min && collection[i] <= max)
        {
            count = count + 1;
        }
    }
    return count;
}

const int size = 123;
const int leftRange = 0;
const int rightRange = 150;
int result = 0; // сюда пропишем результат решения задачи

int[] massive = GetRandomArray (size, leftRange, rightRange);
Console.WriteLine($"Данный массив: [{string.Join(", ", massive)}]");

result = HowMuch (massive, 10, 99);

Console.WriteLine(); // пустая строка для красоты
Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке [10,99] равно {result}");